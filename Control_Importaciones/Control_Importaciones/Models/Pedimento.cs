using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Importaciones.Models
{
    public class Pedimento
    {
        public int PedimentoId { get; set; }
        public int ImportacionId { get; set; }
        public string ClavePedimento { get; set; }
        public string NumeroPedimento { get; set; }
        public byte[] PedimentoPdf { get; set; }
    }
}
