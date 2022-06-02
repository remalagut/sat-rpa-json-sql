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
using SATRpaToJson.ConsultaLotesEnviadosWS;
using System.Net;
using System.Xml;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SATRpaToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //(RPA) csvs rpa baixados do SGR para converter para json (upado e baixado como csv do google docs)
            var csvsToConvert = args.Where(x => x.EndsWith(".csv"));
            
            //(RPA) jsons criados do rpa acima (csv) para posteriormente converter em sql
            var jsonsToCreateInsert = args.Where(x => x.EndsWith(".json") && !x.Contains("xmlcfe"));
            
            // (RPA) json dos json convertido do csv acima
            var jsonFromXmlsToCreateInsert = args.Where(x => x.EndsWith(".xmlcfe.json"));

            //(CFe) xmls dos documentos baixados do sgr para converter diretamente sql OU arquivo resLote consultaLoteWS
            var xmlsCfeToCreateInsert = args.Where(x => x.EndsWith(".xml")).OrderBy(x => x).ToList();

            //arquivo de download de lote via web service, formato de cada linha:
            //nSerieSat=000945311|dhInicial=15052022000000|dhFinal=31052022004400|chaveSegurancaSat=fff02796-29e4-4855-b152-7e0b136d4631
            var arquivosLoteDownloadSatWS = args.Where(x => x.EndsWith(".wssatdownload"));

            var arquivosSqlToCreateCompiledExecutionCmd = args.Where(x => x.EndsWith(".sql"));
            //xmlsCfeToCreateInsert = new List<string>() { @"C:\transient\fast-tests\LotesParaBaixar\LotesParaBaixar.wssatdownload-f4dbd070-c996-4575-b103-491561ea83c4.xml",
            //@"C:\transient\fast-tests\LotesParaBaixar\LotesParaBaixar.wssatdownload-9fde3172-49a2-487f-bd3b-86edf3874daf.xml"};
            //arquivosLoteDownloadSatWS = new List<string>() { @"C:\transient\fast-tests\LotesParaBaixar.wssatdownload" };
            //arquivosSqlToCreateCompiledExecutionCmd = new List<string>() {
            //    @"C:\sources\satRpaTOJson\SATRpaToJson\bin\Debug\LotesParaBaixar\LotesParaBaixar.wssatdownload-5e00839c-c330-4354-9acb-3fa16e840d73.sql",
            //    @"C:\sources\satRpaTOJson\SATRpaToJson\bin\Debug\LotesParaBaixar\LotesParaBaixar.wssatdownload-47959f49-2a55-4f09-8817-84c64dd0b9ac.sql",
            //    @"C:\sources\satRpaTOJson\SATRpaToJson\bin\Debug\LotesParaBaixar\LotesParaBaixar.wssatdownload-8691ad92-236f-4411-82aa-29039b3e108d.sql",
            //    @"C:\sources\satRpaTOJson\SATRpaToJson\bin\Debug\LotesParaBaixar\LotesParaBaixar.wssatdownload-0b4fc1d8-226f-4510-807f-09cd8d4836b4.sql",
            //    @"C:\sources\satRpaTOJson\SATRpaToJson\bin\Debug\LotesParaBaixar\LotesParaBaixar.wssatdownload-a7ab4874-981b-4d95-b493-44537275653f.sql",
            //};

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
                Console.WriteLine("9 - [FUNCIONALIDADE CONVERSAO XML CFE SGR DIRETO PARA SQL] - arrastar xmls dos cfes para o exe deste programa");
                Console.WriteLine("10 - Parametrização de arquivo wssatdownload para baixar de forma programática os lotes do web service sefaz, será salvo na pasta do exe do programa numa pasta com o nome do arquivo de origem, dentro da pasta terão os xmls baixados deste arquivo de parametros");
                Console.WriteLine("11 - Conversao dos xmls consulta lote para sql - arrastar os xmls resLote para esse programa");


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
                ProcessarArquivoXml(arquivoJsonFromXml);
            }

            if(xmlsCfeToCreateInsert.Count > 0)
            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, Guid.NewGuid().ToString() + ".sql")))
            {
                foreach (var arquivoXmlEnvCFe in xmlsCfeToCreateInsert)
                {
                    var outputSqlFile = ProcessarArquivoXml(arquivoXmlEnvCFe);
                    sw.WriteLine(":r \"" + outputSqlFile + "\"");
                }
            }

            //realiza apenas o download, a conversão é feita carregando o xml baixado no exe do programa
            foreach (var arquivoDownloadSatWS in arquivosLoteDownloadSatWS)
            {
                var listaArquivosLoadXml = BaixarXmlsConsultaLoteWSSat(arquivoDownloadSatWS);
                //BuildListaDocumentosFromXmlConsultaLoteWS(satXmlString, listaDocumentosToGenerateInsert, formatString, textXml);
            }

            if(arquivosSqlToCreateCompiledExecutionCmd.Count() > 0)
            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, Guid.NewGuid().ToString() + ".sql")))
            {
                foreach (var arquivoSql in arquivosSqlToCreateCompiledExecutionCmd)
                {
                    sw.WriteLine(":r \"" + arquivoSql + "\"");
                }
            }
                
            

            Console.WriteLine("Processamento de documentos concluído, você pode fechar esta janela.");
            Console.ReadKey();
        }

        private static void BuildListaDocsInsertFromConsultaLoteDownloadWS(List<string> listaXmlsToParse)
        {
            //var xmlDataCFe = textXml.DeserializeXML<XmlParserModel.FromVS.envCFe>();
            var listaDocumentosToGenerateInsert = new List<DocumentoCFe>();
            
            foreach (var rawXmlContentLote in listaXmlsToParse)
            {
                var newDocsFromXml = BuildListaDocsInsertFromRawXmlConsultaLote(rawXmlContentLote);
                listaDocumentosToGenerateInsert.AddRange(newDocsFromXml);
            }

            //GerarArquivoSqlFromJsonXmlCFe(listaDocumentosToGenerateInsert, )
        }

        private static List<DocumentoCFe> BuildListaDocsInsertFromRawXmlConsultaLote(string rawXmlContentLote)
        {
            string formatString = "yyyyMMddHHmmss";
            var xmlDataCFe = rawXmlContentLote.DeserializeXML<Model.ConsultaLoteWS.resLote>();
            var listaDocumentos = new List<DocumentoCFe>();

            Console.WriteLine("BuildListaDocsInsertFromRawXmlConsultaLote");
            foreach (var lote in xmlDataCFe.Lote)
            {
                foreach (var documento in lote.InfCfe)
                {
                    var dataHoraDoc = documento.dEmi + documento.hEmi?.PadLeft(6, '0');
                    if(String.IsNullOrEmpty(dataHoraDoc))
                       dataHoraDoc = lote.dhProcessamento;

                    var newDocument = new DocumentoCFe()
                    {
                        DocumentoId = Guid.NewGuid(),
                        ChaveConsulta = documento.Chave,
                        NumeroCFe = documento.nCupom,
                        NumeroSerieEquipamentoSat = "Importado download lote web service",
                        tpAmb = 0,
                        IdLote = "NRec="+lote.NRec,
                        //cNF = cfeContentFromXml.c.CNf,
                        EmitenteCNPJ = xmlDataCFe.infContribstringe?.CNPJ,
                        EmitenteNome = xmlDataCFe.infContribstringe?.xNome,
                        //ChaveInfCpl = rawXmlContentLote.infCFe.infAdic?.infCpl?.ToString(),
                        //NumeroCaixa = rawXmlContentLote.infCFe.ide.numeroCaixa.ToString(),
                        ValorTotal = Convert.ToDecimal(documento.vCFe.ToString().Replace(".", ",") ?? "0"),
                        DataHoraEmissao = DateTime.ParseExact(
                            dataHoraDoc
                            , formatString, CultureInfo.InvariantCulture),
                        //DataHoraEmissao = DateTime.ParseExact(rawXmlContentLote.infCFe.ide.dEmi.ToString() + rawXmlContentLote.infCFe.ide.hEmi.ToString().PadLeft(6, '0'), formatString, null),
                        Itens = new List<DocumentoCFeItem>(),
                        CupomDeCancelamento = lote.TipoLote != "Movimento"
                    };
                    listaDocumentos.Add(newDocument);
                }
            }
            return listaDocumentos;
        }

        /// <summary>
        /// baixa lotes xml e salva na pasta com padrao enviroment path > nome arquivo parametros  >  nome arquivo parametros + guid.xml
        /// </summary>
        /// <param name="pathArquivoInputConfigDownloadLotes"></param>
        /// <returns></returns>
        private static List<string> BaixarXmlsConsultaLoteWSSat(string pathArquivoInputConfigDownloadLotes)
        {
            var listaArquivosXmlsBaixadosSefaz = new List<string>();
            Console.WriteLine("BaixarXmlsConsultaLoteWSSat " + pathArquivoInputConfigDownloadLotes);

            //verifica se existe diretorio para o arquivo de input (um arquivo = um diretorio na pasta de execuçao)
            //diretorio utilizado para armazenar os download de xmls consulta lote ws
            string outputFolderPath = Path.Combine(Environment.CurrentDirectory, Path.GetFileNameWithoutExtension(pathArquivoInputConfigDownloadLotes + "-" + Guid.NewGuid()));
            
            if (!Directory.Exists(Path.GetFullPath(outputFolderPath)))
            {
                Directory.CreateDirectory(outputFolderPath);
            }

            var listaDocumentosToGenerateInsert = new List<DocumentoCFe>();
            string formatString = "yyyyMMddHHmmss";

            using (StreamReader sr = new StreamReader(pathArquivoInputConfigDownloadLotes))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var dadosParametroLinha = line.Split('|');
                    string nSerieSat, dhInicial, dhFinal, chaveSeguranca;
                    TratarParametrosInputConsultaWSLote(dadosParametroLinha, out nSerieSat, out dhInicial, out dhFinal, out chaveSeguranca);
                    var xmlFromSefaz = BaixarLotesSatWS(nSerieSat, dhInicial, dhFinal, chaveSeguranca, line);
                    var filename = Path.GetFileName(pathArquivoInputConfigDownloadLotes);
                    var outputFilename = Path.Combine(outputFolderPath, filename + "-" + Guid.NewGuid() + ".xml");
                    File.WriteAllText(outputFilename, xmlFromSefaz);
                    listaArquivosXmlsBaixadosSefaz.Add(xmlFromSefaz);
                }
            }
            return listaArquivosXmlsBaixadosSefaz;
        }

        private static void TratarParametrosInputConsultaWSLote(string[] dadosParametroLinha, out string nSerieSat, out string dhInicial, out string dhFinal, out string chaveSeguranca)
        {
            nSerieSat = dadosParametroLinha[0].Replace("nSerieSat=", "");
            dhInicial = dadosParametroLinha[1].Replace("dhInicial=", "");
            ;
            dhFinal = dadosParametroLinha[2].Replace("dhFinal=", "");
            ;
            chaveSeguranca = dadosParametroLinha[3].Replace("chaveSegurancaSat=", "");
            ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nserieSAT">Numeração do SAT (até antes do hífen)</param>
        /// <param name="dhInicial">Data inicial formato ddMMyyyyHHmmss Ex 01/06/2022 14:08:32 = 01062022140532</param>
        /// <param name="dhFinal">Data Final no formato ddMMyyyyHHmmss Ex 01/06/2022 14:08:32 = 01062022140532</param>
        /// <param name="chaveSeguranca">Chave segurança gerada anexo 3 https://portal.fazenda.sp.gov.br/_layouts/download.aspx?SourceUrl=/servicos/sat/Downloads/Manual%20para%20Consultar%20lotes%20enviados%20via%20Webservice%20(Estadual)%20v1%201.pdf</param>
        private static string BaixarLotesSatWS(string nserieSAT, string dhInicial, string dhFinal, string chaveSeguranca, string fullLine)
        {
            Console.WriteLine("BaixarLotesSatWS: " + fullLine);
            CfeConsultaLotesSoapClient client = new CfeConsultaLotesSoapClient();
            var binding = client.Endpoint.Binding;
            if (binding is BasicHttpBinding)
            {
                ((BasicHttpBinding)binding).MaxReceivedMessageSize = int.MaxValue;
            }
            else if (binding is WSHttpBinding)
            {
                ((WSHttpBinding)binding).MaxReceivedMessageSize = int.MaxValue;
            }
            else
            {
                // outros tipos
                var newBinding = new CustomBinding(binding);
                for (var i = 0; i < newBinding.Elements.Count; i++)
                {
                    if (newBinding.Elements[i] is TransportBindingElement)
                    {
                        ((TransportBindingElement)newBinding.Elements[i]).MaxReceivedMessageSize = int.MaxValue;
                    }
                }

                client.Endpoint.Binding = newBinding;
            }
         
            CfeCabecMsgSoapEntity cabecalhoEnvio = new CfeCabecMsgSoapEntity();
            cabecalhoEnvio.cUF = "35";
            cabecalhoEnvio.versaoDados = "0.08";
            var consultaLoteBody = $"<consLote xmlns=\"http://www.fazenda.sp.gov.br/sat\" versao=\"0.08\"><nserieSAT>{nserieSAT}</nserieSAT><dhInicial>{dhInicial}</dhInicial><dhFinal>{dhFinal}</dhFinal><chaveSeguranca>{chaveSeguranca}</chaveSeguranca></consLote>";
            Console.WriteLine("Disparando consulta de lote WS sat:");
            Console.WriteLine(consultaLoteBody);
            try
            {
                Task.Delay(1500);
                var result = client.ConsultarLotesEnviadosAsync(cabecalhoEnvio, consultaLoteBody).Result;

                return result.CfeConsultarLotesResult;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.InnerException + "\n" + ex.StackTrace);
                return null;
            }
            
            //var result = CreateSoapEnvelope().Result;
        }

        private static string ProcessarArquivoXml(string arquivoXmlCFe)
        {
            Console.WriteLine("ProcessarArquivoXml " + arquivoXmlCFe);
            var listaDocumentosToGenerateInsert = new List<DocumentoCFe>();
            string formatString = "yyyyMMddHHmmss";

            var textXml = File.ReadAllText(arquivoXmlCFe);
            //xml de envio de movimento sat
            if (textXml.EndsWith("</envCFe>"))
            {
                BuildListaDocsInsertCFe(listaDocumentosToGenerateInsert, formatString, textXml);
            }

            //xml de cancelamento sat
            if (textXml.EndsWith("</cancCFe>"))
            {
                BuildListaDocsInsertCFeCanc(listaDocumentosToGenerateInsert, formatString, textXml);
            }

            //xml resposta consulta lote WS
            if (textXml.EndsWith("</resLote>"))
            {

                listaDocumentosToGenerateInsert.AddRange(BuildListaDocsInsertFromRawXmlConsultaLote(textXml));
                //GerarArquivoSqlFromJsonXmlCFe(listaDocumentosToGenerateInsert, arquivoXmlCFe);
            }


            return GerarArquivoSqlFromJsonXmlCFe(listaDocumentosToGenerateInsert, arquivoXmlCFe);
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
            var xmlDataCFe = textXml.DeserializeXML<XmlParserModel.FromVS.envCFe>();

            foreach (var documentoCfe in xmlDataCFe.LoteCFe)
            {
                Console.WriteLine("BuildListaDocsInsertCFe documento " + documentoCfe.infCFe.Id);

                var newDocument = new DocumentoCFe()
                {
                    DocumentoId = Guid.NewGuid(),
                    ChaveConsulta = documentoCfe.infCFe.Id,
                    NumeroCFe = documentoCfe.infCFe.ide.nCFe.ToString(),
                    NumeroSerieEquipamentoSat = xmlDataCFe.nserieSAT.ToString(),
                    tpAmb = Convert.ToInt64(xmlDataCFe.tpAmb),
                    IdLote = xmlDataCFe.idLote.ToString(),
                    //cNF = cfeContentFromXml.c.CNf,
                    EmitenteCNPJ = documentoCfe.infCFe.emit.CNPJ.ToString(),
                    EmitenteNome = documentoCfe.infCFe.emit.xNome.ToString(),
                    ChaveInfCpl = documentoCfe.infCFe.infAdic?.infCpl?.ToString(),
                    NumeroCaixa = documentoCfe.infCFe.ide.numeroCaixa.ToString(),
                    ValorTotal = Convert.ToDecimal(documentoCfe.infCFe?.total?.vCFe.ToString().Replace(".", ",") ?? "0"),
                    DataHoraEmissao = DateTime.ParseExact(documentoCfe.infCFe.ide.dEmi.ToString() + documentoCfe.infCFe.ide.hEmi.ToString().PadLeft(6, '0'), formatString, null),
                    Itens = new List<DocumentoCFeItem>(),
                    CupomDeCancelamento=false
                };

                foreach (var itemDocumento in documentoCfe.infCFe.det.ToList())
                {
                    DocumentoCFeItem newItemDocumento = new DocumentoCFeItem()
                    {
                        NumeroItem = itemDocumento.nItem.ToString(),
                        CFOP = itemDocumento.prod.CFOP.ToString(),
                        //CodigoBarraMercadoria = itemDocumento.Prod.,
                        CodigoCadastroMercadoria = itemDocumento.prod.cProd.ToString(),
                        DescricaoMercadoria = itemDocumento.prod.xProd,
                        NCM = itemDocumento.prod.NCM.ToString(),
                        ValorItem = Convert.ToDecimal(itemDocumento.prod.vItem.ToString().Replace(".", ",")),
                        DocumentoId = newDocument.DocumentoId
                    };
                    newDocument.Itens.Add(newItemDocumento);
                }
                listaDocumentosToGenerateInsert.Add(newDocument);
            }
        }

        //GerarArquivoSqlFromJsonXmlCFe(listaDocumentosToGenerateInsert, arquivoXmlCFe);
        //}

        private static string GerarArquivoSqlFromJsonXmlCFe(List<DocumentoCFe> listaDocumentosToGenerateInsert, string arquivoXml)
        {
            var createTablesSql = $@"set dateformat ymd;
IF NOT EXISTS (
    select * from sysobjects where name='DocumentoCFe' and xtype='U'
) CREATE TABLE DocumentoCFe (
    [DocumentoId] VARCHAR(MAX),
    [ChaveConsulta] VARCHAR(200),
    [NumeroCFe]  VARCHAR(MAX) NOT NULL,
    [IdLote]  VARCHAR(MAX),
    [cNF]  VARCHAR(MAX),
    [NumeroSerieEquipamentoSat]  VARCHAR(MAX),
    [DataHoraEmissao] DATETIME,
    [tpAmb]  VARCHAR(MAX),
    [NumeroCaixa]  VARCHAR(MAX),
    [EmitenteCNPJ]  VARCHAR(MAX) NOT NULL,
    [EmitenteNome]  VARCHAR(MAX),
	[ValorTotal] DECIMAL(16, 3),
    [ChaveInfCpl] VARCHAR(MAX),
    [ChaveCFeCancelado] VARCHAR(MAX) DEFAULT NULL,
	[CupomDeCancelamento] bit default(0)
);

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name = 'UQ_EMPRESA_DOCUMENTO' AND type='K') ALTER TABLE DocumentoCFe
  ADD CONSTRAINT UQ_EMPRESA_DOCUMENTO UNIQUE(ChaveConsulta);

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
                    string sqlInsertDocumento = $@"
IF NOT EXISTS (SELECT * FROM DocumentoCFe WHERE ChaveConsulta = '{documento.ChaveConsulta}')
BEGIN
INSERT INTO [dbo].[DocumentoCFe]
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
           ,{(documento.CupomDeCancelamento ? "1" : "0") });
END;";
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
            return outputFilename;
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
