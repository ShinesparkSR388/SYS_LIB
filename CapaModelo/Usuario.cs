using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Usuario
    {
        string user, pass;
        public string User { get { return user; } set { user = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
    }
}
