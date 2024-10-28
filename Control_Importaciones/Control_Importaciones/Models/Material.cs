using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Importaciones.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public int ImportacionId { get; set; }
        public string MaterialName { get; set; } // Cambiado de 'Material' a 'MaterialName'
        public string Descripcion { get; set; }
    }
}
