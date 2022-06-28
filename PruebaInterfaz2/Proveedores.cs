using CapaDatos;
using CapaModelo;
using System.Globalization;

namespace PruebaInterfaz2
{
    public partial class Proveedores : Form
    {
        Proveedor prov = new Proveedor();

        public Proveedores()
        {
            InitializeComponent();
            cb_Tipo.SelectedIndex = 0;
            // errorProvider1.SetIconAlignment(textBox1, ErrorIconAlignment.BottomRight);
            // errorProvider1.SetError(textBox1, "Hola");
            MostrarDatos(FD_Proveedores.ObtenerProveedores());
        }
        public void LimpiarCampos()
        {
            txt_Dui.Text = "";
            txt_Name.Text = "";
            txt_Nit.Text = "";
            cb_Tipo.Text = "";
        }
        public void MostrarDatos(List<Proveedor> proveedors)
        {
            DT_Provider.Rows.Clear();
            DT_Provider.Columns.Clear();
            DT_Provider.DataSource = null;
            DT_Provider.Columns.Add("IdProveedor", "Id");
            DT_Provider.Columns.Add("Tipo", "Tipo");
            DT_Provider.Columns.Add("Descripcion", "Descripcion");
            DT_Provider.Columns.Add("Dui", "Dui");
            DT_Provider.Columns.Add("Nit", "Nit");
            DT_Provider.Columns.Add("FechaRegistro", "FechaRegistro");
            string tipo;
            foreach (var pr in proveedors)
            {
                string Dui = "", Nit = "";
                if (pr.Tipo == 1)
                {
                    tipo = "Negocio Formal";
                    Nit = pr.Nit.ToString();
                }
                else
                {
                    tipo = "Persona Natural";
                    Dui = pr.Dui.ToString();
                }
                object[] valores = { pr.Id.ToString(), tipo, pr.Descripcion, Dui, Nit, pr.Registro };
                DT_Provider.Rows.Add(valores);
            }
        }

        private void Proveedores_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                prov.Registro = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                prov.Tipo = 0;
                prov.Descripcion = txt_Name.Text;
                if (cb_Tipo.Text.Equals("Persona Natural"))
                {
                    prov.Dui = System.Convert.ToInt64(txt_Dui.Text);
                }
                else if (cb_Tipo.Text.Equals("Empresa"))
                {
                    prov.Nit = System.Convert.ToInt64(txt_Nit.Text);
                }
                bool i = FD_Proveedores.GuardarProveedores(prov);
                MostrarDatos(FD_Proveedores.ObtenerProveedores());
                if (i)
                {
                    MessageBox.Show(@"Proveedor registrado correctamente");
                }
                else
                {
                    MessageBox.Show(i.ToString(), @"Error al guardar");//error de procedimiento almacenado
                }
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                prov.Registro = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                prov.Descripcion = txt_Name.Text;
                if (cb_Tipo.Text == @"Persona Natural")
                {
                    prov.Dui = System.Convert.ToInt64(txt_Dui.Text);
                }
                else if (cb_Tipo.Text == @"Empresa")
                {
                    prov.Nit = System.Convert.ToInt64(txt_Nit.Text);
                }
                bool i = FD_Proveedores.ModificarProveedores(prov);
                MostrarDatos(FD_Proveedores.ObtenerProveedores());
                if (i)
                {
                    MessageBox.Show(@$"Datos de proveedor {prov.Descripcion} modificados");
                }
                else
                {
                    MessageBox.Show(@"Error al modificar");//error de procedimiento almacenado
                }
                btnGuardar.Enabled = true;
                txtBuscar.Enabled = true;
                btnModificar.Enabled = false;
            }

        }

        private void DT_Provider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                prov.Id = System.Convert.ToInt32(DT_Provider.Rows[e.RowIndex].Cells["IdProveedor"].Value);
                txt_Dui.Text = DT_Provider.Rows[e.RowIndex].Cells["Dui"].Value.ToString();
                txt_Name.Text = DT_Provider.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txt_Nit.Text = DT_Provider.Rows[e.RowIndex].Cells["Nit"].Value.ToString();
                cb_Tipo.Text = DT_Provider.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                btnGuardar.Enabled = false;
                txtBuscar.Enabled = false;
                btnModificar.Enabled = true;

                MostrarDatos(FD_Proveedores.BuscarProveedores(prov.Id));


            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "")
                {
                    MostrarDatos(FD_Proveedores.BuscarProveedores(System.Convert.ToInt32(txtBuscar.Text)));
                }
                else
                {
                    MostrarDatos(FD_Proveedores.ObtenerProveedores());
                }

            }
            catch (Exception)
            {

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "")
                {
                    MostrarDatos(FD_Proveedores.BuscarProveedores(System.Convert.ToInt32(txtBuscar.Text)));
                }
                else
                {
                    MostrarDatos(FD_Proveedores.ObtenerProveedores());
                }

            }
            catch (Exception)
            {

            }



        }
        public bool ValidarCampos()
        {
            if (cb_Tipo.Text.Equals("Persona Natural"))
            {
                prov.Tipo = 0;
                prov.Nit = 0;
                prov.Dui = 1;
                txt_Nit.Enabled = false;
                txt_Dui.Enabled = true;
            }
            else if (cb_Tipo.Text.Equals("Empresa"))
            {
                prov.Tipo = 1;
                prov.Dui = 0;
                prov.Nit = 1;
                txt_Nit.Enabled = true;
                txt_Dui.Enabled = false;
            }
            bool rs = false;
            //vacio
            if (txt_Name.Text == "")
            {
                MessageBox.Show(@"El campo Nombre no puede estar vacío");
                rs = true;
            }
            if (cb_Tipo.Text == "")
            {
                MessageBox.Show(@"Seleccione un Tipo de registro");
                rs = true;
            }
            //datos
            if (prov.Nit == 0)
            {
                try
                {
                    System.Convert.ToInt64(txt_Dui.Text);
                    if ((txt_Dui.Text).Length != 9)
                    {
                        MessageBox.Show(@"Dui invalido, (debe contener 9 digitos del 0 al 9)");
                        return true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Dui invalido, (debe contener 9 digitos del 0 al 9");
                    return true;
                }
            }
            if (prov.Dui == 0)
            {
                try
                {
                    System.Convert.ToInt64(txt_Nit.Text);
                    if ((txt_Nit.Text).Length != 14)
                    {
                        MessageBox.Show(@"Nit invalido, (debe contener 14 digitos del 0 al 9)");
                        return true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Nit invalido, (debe contener 14 digitos del 0 al 9)");
                    return true;
                }
            }

            return rs;
        }

        private void cb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Tipo.Text.Equals("Persona Natural"))
            {
                prov.Tipo = 0;
                prov.Nit = 0;
                txt_Nit.Enabled = false;
                txt_Nit.Text = "";
                txt_Dui.Enabled = true;
            }
            else if (cb_Tipo.Text.Equals("Empresa"))
            {
                prov.Tipo = 1;
                prov.Dui = 0;
                txt_Nit.Enabled = true;
                txt_Dui.Enabled = false;
                txt_Dui.Text = "";
            }
            else if (cb_Tipo.Text == "")
            {
                txt_Nit.Enabled = false;
                txt_Dui.Enabled = false;
            }
        }

        private void DT_Provider_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Dui_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
