using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Libro
    {
        public int IdLote { get; set; }
        public int IdProducto { get; set; }
        public string Name { get; set; }
        public int Unidades { get; set; }
        public int Paquetes { get; set; }
        public int UnidadPaquete { get; set; }
        public double PrecioPaquete { get; set; }
        public string fechaRegistro { get; set; }
    }
}
