using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Proveedor
    {
        /*
         Estructura de la tabla Proveedor
         [IdProveedor] int primary key IDENTITY(1,1) NOT NULL,
         [Tipo] int NULL,
         [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS  NULL,
         [Dui] int NULL,
         [Nit] int NULL,
         [FechaRegistro] varchar(100) DEFAULT getdate() NULL
         */
        string descripcion = "", registro = "";
        int tipo = 0;
        public int Id { get; set; }
        public int Tipo { get { return tipo; } set { tipo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public long Dui { get; set; }
        public long Nit { get; set; }
        public string Registro { get { return registro; } set { registro = value; } }

    }
}
