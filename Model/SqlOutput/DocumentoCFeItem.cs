using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATRpaToJson.Model.SqlOutput
{
    public class DocumentoCFeItem
    {
        public string CodigoCadastroMercadoria { get; set; }
        public string CodigoBarraMercadoria { get; set; }
        public string DescricaoMercadoria { get; set; }
        public string NCM { get; set; }
        public string CFOP { get; set; }
        public decimal ValorItem { get; set; }
        public string NumeroItem { get; set; }

        public Guid DocumentoId { get; set; }
    }
}
