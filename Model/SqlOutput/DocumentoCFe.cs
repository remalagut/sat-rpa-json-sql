using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATRpaToJson.Model.SqlOutput
{
    public class DocumentoCFe
    {
        public Guid DocumentoId { get; set; }
        public string ChaveConsulta { get; set; }

        public string NumeroCFe { get; set; }

        public string IdLote { get; set; }

        public string cNF { get; set; }
        public string NumeroSerieEquipamentoSat { get; set; }
        public DateTime DataHoraEmissao { get; set; }
        public long tpAmb { get; set; }
        public string NumeroCaixa { get; set; }


        public string EmitenteCNPJ { get; set; }
        public string EmitenteNome { get; set; }
        public List<DocumentoCFeItem> Itens { get; set; }

        public decimal ValorTotal { get; set; }

        public string ChaveInfCpl { get; set; }
        public string ChaveCancelado { get; set; }
        public bool CupomDeCancelamento { get; set; }

    }
}
