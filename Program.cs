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

namespace SATRpaToJson
{
    class Program
    {


        static void Main(string[] args)
        {
            var csvsToConvert = args.Where(x => x.EndsWith(".csv"));
            var jsonsToCreateInsert = args.Where(x => x.EndsWith(".json"));

            //jsonsToCreateInsert = new List<String>() { @"D:\GoogleDrive\META\UtilShare\313288\RPAs\GERAL\JSON\202202-AUTO POSTO B MARGINAL LTDA-RPA - Cupom de Movimento_Fevereiro_2022_24361667000188.xlsx - CDU113_RPA_CFe_SAT.json" };
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
                Console.WriteLine("Multiplis csvs e jsons são aceitos em cada execução, basta selecionar todos os arquivos e arrastar em cima do exe deste app. Serão criados arquivos com o mesmo nome na pasta original, com a extensão do arquivo destino (csv > gera json, json > gera sql)");
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
        }

        private static void CriarInsertSqlFromJson( string arquivoJson)
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
