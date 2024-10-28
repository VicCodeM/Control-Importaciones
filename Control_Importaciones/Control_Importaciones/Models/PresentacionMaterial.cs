using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Importaciones.Models
{
    public class PresentacionMaterial
    {
        public int PresentacionId { get; set; }
        public int MaterialId { get; set; }
        public int BultosCajas { get; set; }
        public string Descripcion { get; set; }
    }
}
