﻿using CapaDatos;
using CapaModelo;

namespace PruebaInterfaz2
{
    public partial class Productos : Form
    {
        List<Producto> prod = new List<Producto>();
        List<Proveedor> providers = new List<Proveedor>();
        Producto actual = new Producto();
        public Productos()
        {
            InitializeComponent();
            Get_Providers_cbox();
        }
        private void Get_Providers_cbox()
        {
            providers = FD_Proveedores.ObtenerProveedores();
            foreach (var provider in providers)
            {
                cb_Proveedores.Items.Add(provider.Descripcion);
            }
            mostrarDatos(FD_Productos.ObtenerPoductos());
        }
        private void mostrarDatos(List<Producto> data)
        {
            if(data == null) { return; }
            DT_Productos.Rows.Clear();
            DT_Productos.Columns.Clear();
            DT_Productos.DataSource = null;            

            DT_Productos.Columns.Add("Id", "Id");
            DT_Productos.Columns.Add("Nombre", "Nombre");
            DT_Productos.Columns.Add("Proveedor", "Proveedor");
            DT_Productos.Columns.Add("Unidad/C", "Unidad/C");
            DT_Productos.Columns.Add("Precio/C", "Precio/C");

            foreach (var item in data)
            {
                string prov = "";
                foreach (var provider in providers)
                {
                    if (provider.Id == item.IdProveedor)
                    {
                        prov = provider.Descripcion;
                    }
                }

                string[] val = { item.Id.ToString(), item.Descripcion.ToString(), prov, item.UnidadPaquete.ToString(), item.PrecioPaquete.ToString() };
                DT_Productos.Rows.Add(val);
            }
        }
        private bool ValidarDatos()
        {
            if (cb_Proveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proveedor");
                return true;
            }
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return true;
            }
            try
            {
                if (System.Convert.ToInt32(txt_Unidades.Text) <= 0)
                {
                    MessageBox.Show("El numero de unidades por caja debe ser de 1 o mas");
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Ingrese un numero de unidades Valido");
                return true;
            }
            try
            {
                if (System.Convert.ToDouble(txt_Precio.Text) <= 0)
                {
                    MessageBox.Show("El precio por caja debe ser mayor que 0");
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Ingrese un Precio Valido");
                return true;
            }
            return false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_Proveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var provider in providers)
            {
                if (i == System.Convert.ToInt32(cb_Proveedores.SelectedIndex.ToString()))
                {
                    txt_IdProvider.Text = provider.Id.ToString();
                }
                i++;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            bool val_data = ValidarDatos();
            if(val_data == true)
            {
                return;
            }
            actual.IdProveedor = System.Convert.ToInt32(txt_IdProvider.Text);
            actual.Descripcion = txt_Nombre.Text;
            actual.UnidadPaquete = System.Convert.ToInt32(txt_Unidades.Text);
            actual.PrecioPaquete = System.Convert.ToDouble(Conv.P_coma(txt_Precio.Text));
            actual.FechaRegistro = DateTime.Now.ToString();

            bool val = FD_Productos.GuardarProducto(actual);
            if (val == false)
            {
                MessageBox.Show("Producto registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            mostrarDatos(FD_Productos.ObtenerPoductos());
        }

        private void DT_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            if(DT_Productos.Rows.Count < e.RowIndex) { return; }
            txt_Id.Text = DT_Productos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            prod = FD_Productos.ObtenerPoductos();
            foreach(Producto pv in prod){
                if (pv.Id == System.Convert.ToInt32(txt_Id.Text))
                {
                    txt_IdProvider.Text = pv.IdProveedor.ToString();
                }
            }
            cb_Proveedores.Text = DT_Productos.Rows[e.RowIndex].Cells["Proveedor"].Value.ToString();
            txt_Nombre.Text = DT_Productos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txt_Unidades.Text = DT_Productos.Rows[e.RowIndex].Cells["Unidad/C"].Value.ToString();
            txt_Precio.Text = DT_Productos.Rows[e.RowIndex].Cells["Precio/C"].Value.ToString();
            btnEditar.Enabled = true;
            txtBuscar.Enabled = false;
            btnRegistro.Enabled = false;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }
        private void limpiar()
        {
            txt_Id.Text = "";
            txt_IdProvider.Text = "";
            txt_Nombre.Text = "";
            txt_Precio.Text = "";
            cb_Proveedores.Text = "";
            txt_Unidades.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool val_data = ValidarDatos();
            if (val_data == true)
            {
                return;
            }
            actual.Id = System.Convert.ToInt32(txt_Id.Text);
            actual.IdProveedor = System.Convert.ToInt32(txt_IdProvider.Text);
            actual.Descripcion = txt_Nombre.Text;
            actual.UnidadPaquete = System.Convert.ToInt32(txt_Unidades.Text);
            actual.PrecioPaquete = System.Convert.ToDouble(Conv.P_coma(txt_Precio.Text));

            bool val = FD_Productos.ModificarProducto(actual);
            if (val == false)
            {
                MessageBox.Show("Producto registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            mostrarDatos(FD_Productos.ObtenerPoductos());

            btnEditar.Enabled = false;
            txtBuscar.Enabled = true;
            btnRegistro.Enabled = true;
            btnCancelar.Visible = false;
            limpiar();
        }

        private void DT_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "")
            {
                mostrarDatos(FD_Productos.BuscarProductos(txtBuscar.Text));
            }
            else
            {
                mostrarDatos(FD_Productos.ObtenerPoductos());
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            txtBuscar.Enabled = true;
            btnRegistro.Enabled = true;
            btnCancelar.Visible = false;
            limpiar();
        }

        private void cb_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_IdProvider_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
