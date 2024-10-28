using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Importaciones.Models
{
    public class Importacion
    {
        public int ImportacionId { get; set; }
        public int ProveedorId { get; set; }
        public DateTime FechaPago { get; set; }
        public string NumeroFactura { get; set; }
        public string OrdenCompra { get; set; }
        public byte[] FacturaPdf { get; set; }
        public byte[] PackingListPdf { get; set; }
        public byte[] GuiaPdf { get; set; }
    }
}
