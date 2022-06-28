using CapaDatos;
using CapaModelo;

namespace PruebaInterfaz2
{
    public partial class Expediciones : Form
    {
        Libro Libro_actual = new Libro();
        Venta venta = new Venta();
        List<Libro> libros = new List<Libro>();
        List<Libro> nuevo_stock = new List<Libro>();
        List<Venta> ventas = new List<Venta>();
        int IdIndex;
        public Expediciones()
        {
            InitializeComponent();
            libros = FD_Stock.obtenerLibros();
            MostrarDatos();
        }
        private void MostrarDatos()
        {

            DT_Productos.Rows.Clear();
            DT_Productos.Columns.Clear();
            DT_Productos.DataSource = null;
            if (libros == null) { return; }
            int t = 0;

            DT_Productos.Columns.Add("Id", "Id");
            DT_Productos.Columns.Add("Nombre", "Nombre");
            DT_Productos.Columns.Add("Unidades", "Unidades");
            DT_Productos.Columns.Add("Cajas", "Cajas");
            DT_Productos.Columns.Add("U/C", "U/C");
            DT_Productos.Columns.Add("Precio/C", "Precio/C");

            foreach (var item in libros)
            {
                string[] val = { item.IdProducto.ToString(), item.Name.ToString(), item.Unidades.ToString(), item.Paquetes.ToString(), item.UnidadPaquete.ToString(), item.PrecioPaquete.ToString() };
                bool l = false;
                foreach (var valor in nuevo_stock)
                {
                    if (valor.IdProducto == item.IdProducto) { l = true; }
                }
                if (l == false)
                {
                    DT_Productos.Rows.Add(val);
                }
            }
        }
        private void MostrarDatos_Venta(List<Venta> data)
        {
            if (data == null) { return; }
            DT_Ventas.Rows.Clear();
            DT_Ventas.Columns.Clear();
            DT_Ventas.DataSource = null;

            DT_Ventas.Columns.Add("Id", "Id");
            DT_Ventas.Columns.Add("Nombre", "Nombre");
            DT_Ventas.Columns.Add("Unidades", "Unidades");
            DT_Ventas.Columns.Add("Cajas", "Cajas");
            DT_Ventas.Columns.Add("Precio Total", "Precio Total");
            btnGrabar.Enabled = true;
            foreach (var item in data)
            {
                string[] val = { item.IdProducto.ToString(), item.Name.ToString(), item.Unidades.ToString(), item.Paquetes.ToString(), item.PrecioTotal.ToString() };
                DT_Ventas.Rows.Add(val);
            }
        }
        private void Validar_Calculos(bool val)
        {
            try
            {
                int i = Libro_actual.Paquetes - Convert.ToInt32(txtPaquetes.Text);
                if (i < 0)
                {
                    return;
                }
                venta.Paquetes = Convert.ToInt32(txtPaquetes.Text);
                if (Convert.ToInt32(txtUnidades.Text) > Libro_actual.UnidadPaquete)
                {
                    return;
                }
                i = Libro_actual.Unidades - Convert.ToInt32(txtUnidades.Text);
                if (i < 0)
                {
                    if (Libro_actual.Paquetes == venta.Paquetes)
                    {
                        return;
                    }

                }
                venta.Unidades = Convert.ToInt32(txtUnidades.Text);
                venta.PrecioTotal = (venta.Paquetes * Libro_actual.PrecioPaquete) + (venta.Unidades * (Libro_actual.PrecioPaquete / Libro_actual.UnidadPaquete));
                txtTotal.Text = venta.PrecioTotal.ToString();
                btnGuardar.Enabled = true;
                if (val == true)
                {
                    Libro_actual.Paquetes = Libro_actual.Paquetes - venta.Paquetes;
                    if (i < 0)
                    {
                        Libro_actual.Paquetes--;
                        Libro_actual.Unidades = Libro_actual.Unidades + Libro_actual.UnidadPaquete;
                    }
                    Libro_actual.Unidades = Libro_actual.Unidades - venta.Unidades;
                    nuevo_stock.Add(Libro_actual);
                    venta.fechaRegistro = DateTime.Now.ToString();
                    ventas.Add(venta);
                    btnGuardar.Enabled = false;
                    Libro_actual = null;
                    Libro_actual = new Libro();
                    venta = null;
                    venta = new Venta();
                    MessageBox.Show("Venta agregada");
                }

            }
            catch (Exception ex)
            {
                txtTotal.Text = "0";
                btnGuardar.Enabled = false;

            }

        }

        private void DT_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Libro_actual = null;
            Libro_actual = new Libro();
            venta = null;
            venta = new Venta();
            if (e.RowIndex == -1) { return; }
            Libro_actual.IdProducto = Convert.ToInt32(DT_Productos.Rows[e.RowIndex].Cells["Id"].Value);
            libros = FD_Stock.obtenerLibros();
            foreach (var item in libros)
            {
                if (item.IdProducto == Libro_actual.IdProducto)
                {
                    Libro_actual = item;
                    venta.IdProducto = Libro_actual.IdProducto;
                    venta.Name = Libro_actual.Name;
                }
            }
            txtLibro.Text = Libro_actual.Name;
            Validar_Calculos(false);
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            Validar_Calculos(false);
        }

        private void txtPaquetes_TextChanged(object sender, EventArgs e)
        {
            Validar_Calculos(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validar_Calculos(true);
            libros = FD_Stock.obtenerLibros();
            MostrarDatos();
            MostrarDatos_Venta(ventas);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int i = 0, var = 0;

            foreach (var lib in nuevo_stock)
            {
                if (lib.IdProducto == IdIndex)
                {
                    var = i;
                }
                else
                {
                    i++;
                }

            }
            nuevo_stock.RemoveAt(var);
            i = var = 0;
            foreach (var Vout in ventas)
            {
                if (Vout.IdProducto == IdIndex)
                {
                    var = i;
                }
                else
                {
                    i++;
                }
            }
            ventas.RemoveAt(var);
            libros = FD_Stock.obtenerLibros();
            MostrarDatos();
            MostrarDatos_Venta(ventas);
            btnQuitar.Enabled = false;
        }

        private void DT_Ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdIndex = Convert.ToInt32(DT_Ventas.Rows[e.RowIndex].Cells["Id"].Value);
                btnQuitar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnQuitar.Enabled = false;
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool ver1, ver2;

            if ((MessageBox.Show("La operacion NO puede desacerse... ¿Desea Continuar?", "CONFIRMAR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                foreach (var item in ventas)
                {
                    ver1 = FD_Output.registrarVenta(item);

                    if (ver1 == true)
                    {
                        MessageBox.Show("Error al guardar la venta ", item.Name.ToString());
                    }
                    else
                    {
                        foreach (var item2 in nuevo_stock)
                        {
                            if (item2.IdProducto.Equals(item.IdProducto))
                            {
                                ver2 = FD_Stock.actualizarStock(item2);
                                if (ver2 == true)
                                {
                                    MessageBox.Show("Error al guardar la venta ", item.Name.ToString());
                                    bool t = FD_Output.EliminarVenta(item);
                                    if(t == true)
                                    {
                                        MessageBox.Show("Fatal Error");
                                    }
                                }
                                else { 
                                    
                                }
                            }

                        }
                    }
                }
                ventas.Clear();
                nuevo_stock.Clear();
                libros.Clear();
                libros = FD_Stock.obtenerLibros();
                MostrarDatos();
                MostrarDatos_Venta(ventas);
            }
        }
    }
}
