using CapaDatos;
using CapaModelo;

namespace PruebaInterfaz2
{
    public partial class Ordenes : Form
    {
        List<Producto> prod = new List<Producto>();
        Orden articulo_actual = new Orden();
        List<Orden> ordenes = new List<Orden>();
        public Ordenes()
        {
            InitializeComponent();
            Get_Produces_cbox();
        }
        private void Get_Produces_cbox()
        {
            prod = FD_Productos.ObtenerPoductos();
            foreach (var product in prod)
            {
                cb_Productos.Items.Add(product.Descripcion);
            }
        }
        private void mostrarDatos()
        {
            DT_Ordenes.Rows.Clear();
            DT_Ordenes.Columns.Clear();
            DT_Ordenes.DataSource = null;

            DT_Ordenes.Columns.Add("Id Producto", "Id Producto");
            DT_Ordenes.Columns.Add("Id Proveedor", "Id Proveedor");
            DT_Ordenes.Columns.Add("Nombre", "Nombre");
            DT_Ordenes.Columns.Add("Paquetes", "Paquetes");
            DT_Ordenes.Columns.Add("Total", "Total");

            foreach (var order in ordenes)
            {
                string[] val = {order.IdProducto.ToString(),order.IdProveedor.ToString(),order.Name.ToString(),order.Paquetes.ToString(),order.Total.ToString()};
                DT_Ordenes.Rows.Add(val);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ordenes_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Proveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var product in prod)
            {
                if (i == Convert.ToInt32(cb_Productos.SelectedIndex.ToString()))
                {
                    //asignacion de campos
                    txt_IdProduct.Text = product.Id.ToString();
                    txtProveedor.Text = product.IdProveedor.ToString();
                    txtNombre.Text = product.Descripcion.ToString();
                    try
                    {
                        txtTotal.Text = (Convert.ToInt32(txtPaquetes.Text) * product.PrecioPaquete).ToString();
                    }
                    catch (Exception)
                    {

                    }

                    //asignacion de objeto orden
                    articulo_actual.IdProducto = product.Id;
                    articulo_actual.IdProveedor = product.IdProveedor;
                    articulo_actual.Name = product.Descripcion;
                    articulo_actual.PrecioPaquete = product.PrecioPaquete;
                    articulo_actual.UnidadPaquete = product.UnidadPaquete;
                    
                    try
                    {
                        articulo_actual.Paquetes = Convert.ToInt32(txtPaquetes.Text);
                        articulo_actual.Total = Convert.ToInt32(txtPaquetes.Text) * product.PrecioPaquete;
                        btnAgregar.Enabled = true;
                    }
                    catch (Exception)
                    {
                        articulo_actual.Total = 0;
                        btnAgregar.Enabled = false;
                    }



                }
                i++;
            }
        }

        private void txtPaquetes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = (Convert.ToInt32(txtPaquetes.Text) * articulo_actual.PrecioPaquete).ToString();
                articulo_actual.Paquetes = Convert.ToInt32(txtPaquetes.Text);
                articulo_actual.Total = Convert.ToInt32(txtPaquetes.Text) * articulo_actual.PrecioPaquete;
                btnAgregar.Enabled = true;
            }
            catch (Exception)
            {
                articulo_actual.Total = 0;
                btnAgregar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ordenes.Add(articulo_actual);
            mostrarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
