using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conv
    {
        public static string P_coma(string punto) {
            string coma;
            coma = punto.Replace(".", ",");
            return coma;
        }
    }
}
