namespace CapaModelo
{
    public class Producto
    {
        /*
              [IdProducto] int primary key IDENTITY(1,1) NOT NULL,
              [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
              [IdProveedor] int foreign key references PROVIDER(IdProveedor) NOT NULL,
              [UnidadPaquete] int NOT NULL default(0),
              [PrecioPaquete] float (30) NOT NULL DEFAULT (0),
              [FechaRegistro] varchar(100) DEFAULT getdate() NOT NULL
         */
        string descripcion = "", fecha = "";
        public int Id { get; set; }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int IdProveedor { get; set; }
        public int UnidadPaquete { get; set; }
        public double PrecioPaquete { get; set; }
        public string FechaRegistro { get { return fecha; } set { fecha = value; } }
    }
}
