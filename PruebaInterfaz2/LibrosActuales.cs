using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaModelo;

namespace PruebaInterfaz2
{
    public partial class LibrosActuales : Form
    {
        List<Libro> stock = new List<Libro>();
        public LibrosActuales()
        {
            InitializeComponent();
            stock = FD_Stock.obtenerLibros();
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            DT_Libros.Rows.Clear();
            DT_Libros.Columns.Clear();
            DT_Libros.DataSource = null;

            DT_Libros.Columns.Add("Id", "Id");
            DT_Libros.Columns.Add("Nombre", "Nombre");
            DT_Libros.Columns.Add("Unidades", "Unidades");
            DT_Libros.Columns.Add("Cajas", "Cajas");
            DT_Libros.Columns.Add("U/C", "U/C");
            DT_Libros.Columns.Add("Precio/C", "Precio/C");

            foreach (var item in stock)
            {
                string[] val = { item.IdProducto.ToString(), item.Name.ToString(), item.Unidades.ToString(), item.Paquetes.ToString(), item.UnidadPaquete.ToString(), item.PrecioPaquete.ToString() };
                if(txt_Nombre.Text != "")
                {
                    if(txt_Nombre.Text == item.Name)
                    {
                        DT_Libros.Rows.Add(val);
                    }
                }
                else
                {
                    DT_Libros.Rows.Add(val);
                }
            }
        }

        private void icBuscar_Click(object sender, EventArgs e)
        {
            stock = FD_Stock.obtenerLibros();
            MostrarDatos();
        }
    }
}
