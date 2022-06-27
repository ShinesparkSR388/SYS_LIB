using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Orden
    {
        /*
         * STOCK
          [IdItem] int primary key IDENTITY(1,1) NOT NULL,********************
          [IdProducto] int foreign key references PRODUCTS(IdProducto),********************
          [Unidades] int NOT NULL,********************
          [Paquetes] int NOT NULL,********************
          [UnidadPaquete] int NOT NULL,********************
          [PrecioPaquete] float (30) DEFAULT (0),********************
          [FechaRegistro] datetime DEFAULT getdate() NULL********************
        
            ORDEN
          [IdEntrada] int primary key IDENTITY(1,1) NOT NULL,********************
          [IdProveedor] int foreign key references PROVIDER(IdProveedor),********************
          [IdProducto] int foreign key references PRODUCTS(IdProducto),********************
          [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS  NULL,********************
          [Paquetes] int NOT NULL,********************
          [UnidadPaquete] int NOT NULL,********************
          [PrecioPaquete] float (30) default(0),********************
          [FechaRegistro] datetime DEFAULT getdate() NULL********************
         */
        public int IdProducto { get; set; }//Pre- definido
        public int IdProveedor { get; set; }//Pre- definido
        public string Name { get; set; }//Pre- definido
        public int Paquetes { get; set; }
        public int UnidadPaquete { get; set; }//Pre- definido
        public double PrecioPaquete { get; set; }//Pre- definido
        public double Total { get; set; }
        public string FechaRegistro { get; set; }//Auto- definido
    }
}
