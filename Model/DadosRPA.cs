using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATRpaToJson.Model
{
    public class DadosRPA
    {
        public string Estabelecimento { get; set; }
        public string CNPJ { get; set; }
        public List<RegistroEquipamentoDiarioRPA> Registros { get; set; }
        public string PeriodoReferencia { get; set; }
    }

    public class RegistroEquipamentoDiarioRPA
    {
        public DateTime Data { get; set; }
        public decimal ValorContabil { get; set; }
        public int QuantidadeCuponsCancelados { get; set; }
        public string NumeroEquipamentoSAT { get; set; }
        public string NumeroCFeInicial { get; set; }
        public string NumeroCFeFinal { get; set; }
        public string NumeroLinha { get; set; }
    }
}
