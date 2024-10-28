using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Importaciones.Models
{
    public class Impuestos
    {
        public int ImpuestosId { get; set; }
        public int PedimentoId { get; set; }
        public decimal ValorDolares { get; set; }
        public decimal ValorAduana { get; set; }
        public decimal ValorComercial { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Dta { get; set; }
        public decimal Iva { get; set; }
        public decimal Prevalidacion { get; set; }
        public decimal IvaPrevalidacion { get; set; }
        public decimal Igi { get; set; }
    }
}
