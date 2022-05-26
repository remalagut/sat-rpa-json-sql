using Newtonsoft.Json;
using SATRpaToJson.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;
using SATRpaToJson.Model.SqlOutput;
using System.Globalization;
using System.Xml.Serialization;
using SATRpaToJson.Extensions;

namespace SATRpaToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvsToConvert = args.Where(x => x.EndsWith(".csv"));
            var jsonsToCreateInsert = args.Where(x => x.EndsWith(".json") && !x.Contains("xmlcfe"));
            var jsonFromXmlsToCreateInsert = args.Where(x => x.EndsWith(".xmlcfe.json"));
            var xmlsCfeToCreateInsert = args.Where(x => x.EndsWith(".xml")).OrderBy(x => x).ToList();

            //xmlsCfeToCreateInsert = new List<string>() { @"C:\transient\cfecanc353220308005625843759 (1).xml" };

            if (args.Length == 0)
            {
                var linkSefazRPA = @"https://satsp.fazenda.sp.gov.br/COMSAT/Private/ConsultarRelatoriosEscrituracao/ConsultarRelatoriosEscrituracao.aspx";
                Console.WriteLine("=============================================================================================================");
                Console.WriteLine("Aplicação para extração de dados do relatório de apoio à escrituração sefaz SP para o formato JSON");
                Console.WriteLine("=============================================================================================================");
                Console.WriteLine("1 - Baixe o arquivo RPA do site da sefaz: " + linkSefazRPA + ";");
                Console.WriteLine("2 - Faça o upload da planilha para o planilhas google;");
                Console.WriteLine("3 - Na planilha do google, clique em arquivo > fazer download > valores separados por vírgulas (csv);");
                Console.WriteLine("4 - Faça a etapa 3 para todos os RPAs que você precisa converter;");
                Console.WriteLine("5 - Selecione todos os arquivos csv baixados e arraste para o exe deste programa;");
                Console.WriteLine("6 - Na pasta onde estão os arquivos csv, será gerado um arquivo json para cada RPA.");
                Console.WriteLine("7 - Caso já tenha um json convertido do RPA e queira gerar os comandos SQL para os dados do RPA, basta dropar o json neste mesmo aplicativo, com as seguintes observações:");
                Console.WriteLine("7.1 - No app.config, insira na chave SqlTableName o nome da tabela que deseja que seja criada com os dados do RPA;");
                Console.WriteLine("Multiplos csvs e jsons são aceitos em cada execução, basta selecionar todos os arquivos e arrastar em cima do exe deste app. Serão criados arquivos com o mesmo nome na pasta original, com a extensão do arquivo destino (csv > gera json, json > gera sql)");
                Console.WriteLine("8 - Foi adicionada possibilidade de conversao do XML cfe que é baixado do SGR Sat ser convertido em comandos sql, basta converter o arquivo xml que vem da sefaz no site https://jsonformatter.org/xml-formatter com a opçao \"xml to json\" e manter o arquivo com a extensao .xmlcfe.json, inves de apenas json (utilizado pros rpas)");
                Console.WriteLine("8.1 - faça o join de seus arquivos de lote cfe no site https://www.filesmerge.com/pt/merge-text-files e converta em apenas um json para geração do sql, isso facilitará seu trabalho");


                Console.WriteLine("===================================== renanmalagutti.dev@gmail.com ==========================================");
                Console.ReadKey();
            }

            foreach (var arquivoRpa in csvsToConvert)
            {
                ProcessarConversaoArquivoCsvToJson(arquivoRpa);
            }

            foreach (var arquivoJson in jsonsToCreateInsert)
            {
                CriarInsertSqlFromJson(arquivoJson);
            }

            foreach (var arquivoJsonFromXml in jsonFromXmlsToCreateInsert)
            {
                CriarInsertFromXmlCfeSat(arquivoJsonFromXml);
            }

            foreach (var arquivoXmlEnvCFe in xmlsCfeToCreateInsert)
            {
                CriarInsertFromXmlCfeSat(arquivoXmlEnvCFe);
            }

            Console.WriteLine("Processamento de documentos concluído, você pode fechar esta janela.");
            Console.ReadKey();
        }

        private static void CriarInsertFromXmlCfeSat(string arquivoXmlCFe)
        {
            Console.WriteLine("CriarInsertFromXmlCfeSat " + arquivoXmlCFe);
            var listaDocumentosToGenerateInsert = new List<DocumentoCFe>();
            string formatString = "yyyyMMddHHmmss";

            var textXml = File.ReadAllText(arquivoXmlCFe);
            if (textXml.EndsWith("</envCFe>"))
            {
                BuildListaDocsInsertCFe(listaDocumentosToGenerateInsert, formatString, textXml);
            }
            if (textXml.EndsWith("</cancCFe>"))
            {
                BuildListaDocsInsertCFeCanc(listaDocumentosToGenerateInsert, formatString, textXml);
            }
            GerarArquivoSqlFromJsonXmlCFe(listaDocumentosToGenerateInsert, arquivoXmlCFe);
        }

        private static void BuildListaDocsInsertCFeCanc(List<DocumentoCFe> listaDocumentosToGenerateInsert, string formatString, string textXml)
        {
            var xmlDataCFe = textXml.DeserializeXML<XmlParserModel.XmlSharpCFeCancModel.CancCFe>();

            foreach (var documentoCfe in xmlDataCFe.LoteCFeCanc.CFeCanc)
            {
                Console.WriteLine("BuildListaDocsInsertCFeCanc documento " + documentoCfe.InfCFe.Id);
                //documentoCfe.InfCFe.ChCanc
                var newDocument = new DocumentoCFe()
                {
                    DocumentoId = Guid.NewGuid(),
                    ChaveConsulta = documentoCfe.InfCFe.Id,
                    NumeroCFe = documentoCfe.InfCFe.Ide.NCFe,
                    NumeroSerieEquipamentoSat = xmlDataCFe.NserieSAT,
                    tpAmb = Convert.ToInt64(xmlDataCFe.TpAmb),
                    IdLote = xmlDataCFe.IdLote,
                    //cNF = cfeContentFromXml.c.CNf,
                    EmitenteCNPJ = documentoCfe.InfCFe.Emit.CNPJ,
                    EmitenteNome = documentoCfe.InfCFe.Emit.XNome.ToString(),
                    //ChaveInfCpl = documentoCfe.InfCFe.InfAdic?.InfCpl?.ToString(),
                    NumeroCaixa = documentoCfe.InfCFe.Ide.NumeroCaixa,
                    ValorTotal = Convert.ToDecimal(documentoCfe.InfCFe?.Total?.VCFe.Replace(".", ",") ?? "0"),
                    DataHoraEmissao = DateTime.ParseExact(documentoCfe.InfCFe.Ide.DEmi.ToString() + documentoCfe.InfCFe.Ide.HEmi.ToString().PadLeft(6, '0'), formatString, null),
                    Itens = new List<DocumentoCFeItem>(),
                    CupomDeCancelamento= true,
                    ChaveCancelado=documentoCfe.InfCFe.ChCanc
                };

                //foreach (var itemDocumento in documentoCfe.InfCFe.Det.ToList())
                //{
                //    DocumentoCFeItem newItemDocumento = new DocumentoCFeItem()
                //    {
                //        NumeroItem = itemDocumento.NItem,
                //        CFOP = itemDocumento.Prod.CFOP,
                //        //CodigoBarraMercadoria = itemDocumento.Prod.,
                //        CodigoCadastroMercadoria = itemDocumento.Prod.CProd.ToString(),
                //        DescricaoMercadoria = itemDocumento.Prod.XProd,
                //        NCM = itemDocumento.Prod.NCM,
                //        ValorItem = Convert.ToDecimal(itemDocumento.Prod.VItem.Replace(".", ",")),
                //        DocumentoId = newDocument.DocumentoId
                //    };
                //    newDocument.Itens.Add(newItemDocumento);
                //}
                listaDocumentosToGenerateInsert.Add(newDocument);
            }
        }

        private static void BuildListaDocsInsertCFe(List<DocumentoCFe> listaDocumentosToGenerateInsert, string formatString, string textXml)
        {
            var xmlDataCFe = textXml.DeserializeXML<XmlParserModel.EnvCFe>();

            foreach (var documentoCfe in xmlDataCFe.LoteCFe.CFe)
            {
                Console.WriteLine("BuildListaDocsInsertCFe documento " + documentoCfe.InfCFe.Id);

                var newDocument = new DocumentoCFe()
                {
                    DocumentoId = Guid.NewGuid(),
                    ChaveConsulta = documentoCfe.InfCFe.Id,
                    NumeroCFe = documentoCfe.InfCFe.Ide.NCFe,
                    NumeroSerieEquipamentoSat = xmlDataCFe.NserieSAT,
                    tpAmb = Convert.ToInt64(xmlDataCFe.TpAmb),
                    IdLote = xmlDataCFe.IdLote,
                    //cNF = cfeContentFromXml.c.CNf,
                    EmitenteCNPJ = documentoCfe.InfCFe.Emit.CNPJ,
                    EmitenteNome = documentoCfe.InfCFe.Emit.XNome.ToString(),
                    ChaveInfCpl = documentoCfe.InfCFe.InfAdic?.InfCpl?.ToString(),
                    NumeroCaixa = documentoCfe.InfCFe.Ide.NumeroCaixa,
                    ValorTotal = Convert.ToDecimal(documentoCfe.InfCFe?.Total?.VCFe.Replace(".", ",") ?? "0"),
                    DataHoraEmissao = DateTime.ParseExact(documentoCfe.InfCFe.Ide.DEmi.ToString() + documentoCfe.InfCFe.Ide.HEmi.ToString().PadLeft(6, '0'), formatString, null),
                    Itens = new List<DocumentoCFeItem>(),
                    CupomDeCancelamento=false
                };

                foreach (var itemDocumento in documentoCfe.InfCFe.Det.ToList())
                {
                    DocumentoCFeItem newItemDocumento = new DocumentoCFeItem()
                    {
                        NumeroItem = itemDocumento.NItem,
                        CFOP = itemDocumento.Prod.CFOP,
                        //CodigoBarraMercadoria = itemDocumento.Prod.,
                        CodigoCadastroMercadoria = itemDocumento.Prod.CProd.ToString(),
                        DescricaoMercadoria = itemDocumento.Prod.XProd,
                        NCM = itemDocumento.Prod.NCM,
                        ValorItem = Convert.ToDecimal(itemDocumento.Prod.VItem.Replace(".", ",")),
                        DocumentoId = newDocument.DocumentoId
                    };
                    newDocument.Itens.Add(newItemDocumento);
                }
                listaDocumentosToGenerateInsert.Add(newDocument);
            }
        }

        //GerarArquivoSqlFromJsonXmlCFe(listaDocumentosToGenerateInsert, arquivoXmlCFe);
        //}

        private static void GerarArquivoSqlFromJsonXmlCFe(List<DocumentoCFe> listaDocumentosToGenerateInsert, string arquivoXml)
        {
            var createTablesSql = $@"set dateformat ymd;
IF NOT EXISTS (
    select * from sysobjects where name='DocumentoCFe' and xtype='U'
) CREATE TABLE DocumentoCFe (
    [DocumentoId] VARCHAR(MAX),
    [ChaveConsulta] VARCHAR(MAX),
    [NumeroCFe]  VARCHAR(MAX),
    [IdLote]  VARCHAR(MAX),
    [cNF]  VARCHAR(MAX),
    [NumeroSerieEquipamentoSat]  VARCHAR(MAX),
    [DataHoraEmissao] DATETIME,
    [tpAmb]  VARCHAR(MAX),
    [NumeroCaixa]  VARCHAR(MAX),
    [EmitenteCNPJ]  VARCHAR(MAX),
    [EmitenteNome]  VARCHAR(MAX),
	[ValorTotal] DECIMAL(16, 3),
    [ChaveInfCpl] VARCHAR(MAX),
    [ChaveCFeCancelado] VARCHAR(MAX) DEFAULT NULL,
	[CupomDeCancelamento] bit default(0)
);

IF NOT EXISTS (
    select * from sysobjects where name='DocumentoCFeItem' and xtype='U'
) CREATE TABLE DocumentoCFeItem (
	[CodigoCadastroMercadoria] VARCHAR(MAX),
    [CodigoBarraMercadoria] VARCHAR(MAX),
    [DescricaoMercadoria] VARCHAR(MAX),
    [NCM] VARCHAR(MAX),
    [CFOP] VARCHAR(MAX),
    [ValorItem] DECIMAL(16, 3),
    [NumeroItem] VARCHAR(MAX),
    [DocumentoId] VARCHAR(MAX)
);

";

            var outputFilename = GetFullFilenameWithNewExtension(arquivoXml, "sql");
            using (StreamWriter sw = new StreamWriter(outputFilename))
            {
                sw.WriteLine(createTablesSql);

                foreach (var documento in listaDocumentosToGenerateInsert)
                {
                    string sqlInsertDocumento = $@"INSERT INTO [dbo].[DocumentoCFe]
           ([DocumentoId]
           ,[ChaveConsulta]
           ,[NumeroCFe]
           ,[IdLote]
           ,[cNF]
           ,[NumeroSerieEquipamentoSat]
           ,[DataHoraEmissao]
           ,[tpAmb]
           ,[NumeroCaixa]
           ,[EmitenteCNPJ]
           ,[EmitenteNome]
           ,[ValorTotal]
           ,[ChaveInfCpl]
           ,[ChaveCFeCancelado]
           ,[CupomDeCancelamento])
     VALUES
           ('{documento.DocumentoId.ToString()}'
           ,'{documento.ChaveConsulta}'
           ,'{documento.NumeroCFe}'
           ,'{documento.IdLote}'
           ,'{documento.cNF}'
           ,'{documento.NumeroSerieEquipamentoSat}'
           ,'{documento.DataHoraEmissao.ToString("yyyy-MM-dd HH:mm:ss")}'
           ,'{documento.tpAmb}'
           ,'{documento.NumeroCaixa}'
           ,'{documento.EmitenteCNPJ}'
           ,'{documento.EmitenteNome}'
           ,{documento.ValorTotal.ToString("0.00", CultureInfo.InvariantCulture)}
           ,'{documento.ChaveInfCpl}'
           ,'{documento.ChaveCancelado}'
           ,{(documento.CupomDeCancelamento ? "1" : "0") });";
                    sw.WriteLine(sqlInsertDocumento);

                    foreach (var itemCfe in documento.Itens)
                    {
                        string sqlInsertItem = $@"INSERT INTO [dbo].[DocumentoCFeItem]
           ([CodigoCadastroMercadoria]
           ,[CodigoBarraMercadoria]
           ,[DescricaoMercadoria]
           ,[NCM]
           ,[CFOP]
           ,[ValorItem]
           ,[NumeroItem]
           ,[DocumentoId])
     VALUES
           ('{itemCfe.CodigoCadastroMercadoria}'
           ,'{itemCfe.CodigoBarraMercadoria}'
           ,'{itemCfe.DescricaoMercadoria}'
           ,'{itemCfe.NCM}'
           ,'{itemCfe.CFOP}'
           ,{itemCfe.ValorItem.ToString("0.00", CultureInfo.InvariantCulture)}
           ,'{itemCfe.NumeroItem}'
           ,'{itemCfe.DocumentoId}');";
                        sw.WriteLine(sqlInsertItem);
                    }

                }

            }

            Console.WriteLine("Concluída geração de sql " + outputFilename);
        }

        private static void CriarInsertSqlFromJson(string arquivoJson)
        {
            Console.WriteLine("Iniciando processamento arquivo json para sql: " + arquivoJson);
            var sqlTableName = ConfigurationSettings.AppSettings.Get("SqlTableName");
            string createTableSQL = $@"IF NOT EXISTS (SELECT * FROM sys.objects where name = '{sqlTableName}' AND type = 'U')
BEGIN
CREATE TABLE {sqlTableName}(
	CNPJ VARCHAR(MAX),
	Estabelecimento VARCHAR(MAX),
	DataMovimento DATE,
	ValorContabil NUMERIC(16,2),
	QuantidadeCuponsCancelados INTEGER,
	NumeroEquipamentoSAT VARCHAR(MAX),
	NumeroCFeInicial VARCHAR(MAX),
	NumeroCFeFinal VARCHAR(MAX),
	NumeroLinha VARCHAR(MAX));
END;";
            var outputFilename = GetFullFilenameWithNewExtension(arquivoJson, "sql");
            var jsonContent = File.ReadAllText(arquivoJson);
            var objetoRegistroFromJson = JsonConvert.DeserializeObject<DadosRPA>(jsonContent);
            using (StreamWriter sw = new StreamWriter(outputFilename))
            {
                sw.WriteLine(createTableSQL);
                foreach (var registro in objetoRegistroFromJson.Registros)
                {
                    string lineInsertSQL = $@"INSERT INTO {sqlTableName}(Estabelecimento,CNPJ,DataMovimento,ValorContabil,QuantidadeCuponsCancelados,NumeroEquipamentoSAT,NumeroCFeInicial,NumeroCFeFinal,NumeroLinha) VALUES ('{objetoRegistroFromJson.Estabelecimento}','{objetoRegistroFromJson.CNPJ}','{registro.Data.ToString("yyyy-MM-dd")}',{registro.ValorContabil.ToString().Replace(",", ".")},{registro.QuantidadeCuponsCancelados},{registro.NumeroEquipamentoSAT},{registro.NumeroCFeInicial.ToString()},{registro.NumeroCFeFinal.ToString()},{registro.NumeroLinha});";
                    sw.WriteLine(lineInsertSQL);
                }
            }

            Console.WriteLine("Finalizando processamento arquivo json para sql: " + arquivoJson);
        }

        private static void ProcessarConversaoArquivoCsvToJson(string arquivoRpa)
        {
            Console.WriteLine("Iniciando processamento arquivo csv para json: " + arquivoRpa);
            DadosRPA dadosRPA = new DadosRPA();
            dadosRPA.Registros = new List<RegistroEquipamentoDiarioRPA>();
            RegistroEquipamentoDiarioRPA registro = new RegistroEquipamentoDiarioRPA();
            int linha = 1;
            DateTime dataRegistro = DateTime.Now;
            var filePath = arquivoRpa;
            PercorrerLinhasArquivoCSV(dadosRPA, ref registro, ref linha, ref dataRegistro, filePath);
            WriteOutputArquivoJsonConvertido(dadosRPA, filePath);
            Console.WriteLine("Concluído processamento arquivo csv para json: " + arquivoRpa);
        }

        private static void WriteOutputArquivoJsonConvertido(DadosRPA dadosRPA, string filePath)
        {
            var serializedRPA = JsonConvert.SerializeObject(dadosRPA);
            string filenameJson = GetFullFilenameWithNewExtension(filePath, "json");
            File.WriteAllText(filenameJson, serializedRPA);
        }

        private static string GetFullFilenameWithNewExtension(string filePath, string newExtension)
        {
            var fileName = Path.GetFileNameWithoutExtension(filePath);
            return Path.Combine(new FileInfo(filePath).Directory.FullName, fileName + "." + newExtension);
        }

        private static void PercorrerLinhasArquivoCSV(DadosRPA dadosRPA, ref RegistroEquipamentoDiarioRPA registro, ref int linha, ref DateTime dataRegistro, string filePath)
        {
            foreach (string line in System.IO.File.ReadLines(filePath))
            {
                Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                var valoresSeparadosPorVirgula = regx.Split(line);

                if (valoresSeparadosPorVirgula.Length <= 2)
                {
                    continue;
                }

                BuildRegistroLinhaCSV(dadosRPA, ref registro, linha, ref dataRegistro, line, valoresSeparadosPorVirgula);

                linha++;
            }
        }

        private static void BuildRegistroLinhaCSV(DadosRPA dadosRPA, ref RegistroEquipamentoDiarioRPA registro, int linha, ref DateTime dataRegistro, string line, string[] valoresSeparadosPorVirgula)
        {
            System.Console.WriteLine("Efetuando processamento da linha: " + line);
            if (int.TryParse(valoresSeparadosPorVirgula[3], out int numeroEquipamentoSat))
            {
                registro = new RegistroEquipamentoDiarioRPA();
                if (DateTime.TryParse(valoresSeparadosPorVirgula[1], out DateTime parsedDate))
                {
                    dataRegistro = parsedDate;
                }
                registro.NumeroEquipamentoSAT = numeroEquipamentoSat.ToString();
                registro.Data = dataRegistro;
                registro.NumeroCFeInicial = valoresSeparadosPorVirgula[5];
                registro.NumeroCFeFinal = valoresSeparadosPorVirgula[7];
                registro.QuantidadeCuponsCancelados = Convert.ToInt32(valoresSeparadosPorVirgula[10]);
            }

            if (line.Contains("Estabelecimento: "))
            {
                dadosRPA.Estabelecimento = valoresSeparadosPorVirgula[1].Replace("Estabelecimento: ", "");
            }

            if (line.Contains("CNPJ: "))
            {

                dadosRPA.CNPJ = valoresSeparadosPorVirgula[1].Replace("CNPJ: ", "");
            }

            if (line.Contains("Total do Equipamento"))
            {
                var valorContabil = Convert.ToDecimal(valoresSeparadosPorVirgula[21].Replace('"', ' '));
                registro.ValorContabil = valorContabil;
                registro.NumeroLinha = linha.ToString();
                dadosRPA.Registros.Add(registro);
                registro = new RegistroEquipamentoDiarioRPA();
            }
        }
    }
}
