using System.Runtime.InteropServices;

namespace PruebaInterfaz2
{
    public partial class FormPrincipal : Form
    {
        //Fields
        private Form formularioActivo;
        private int borderSize = 6;
        private Size _formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        public FormPrincipal()
        {
            InitializeComponent();
            formularioActivo = null;
            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(46, 43, 20);
            timer1.Start();
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }


        #region Funcionalidades del formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int param);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int wmNccalcsize = 0x0083; //Standar Title Bar - Snap Window
            const int wmSyscommand = 0x0112;
            const int scMinimize = 0xF020; //Minimize form (Before)
            const int scRestore = 0xF120; //Restore form (Before)
            const int wmNchittest = 0x0084; //Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10; //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12; //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13; //Upper-left corner of a window border, allows resize diagonally to the left
            const int
                HTTOPRIGHT = 14; //Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int
                HTBOTTOMLEFT = 16; //Lower-left corner of a window border, allows resize diagonally to the left
            const int
                HTBOTTOMRIGHT = 17; //Lower-right corner of a window border, allows resize diagonally to the right

            //<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == wmNchittest)
            {
                //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (WindowState == FormWindowState.Normal) //Resize the form if it is in normal state
                    if ((int) m.Result == HTCLIENT) //If the result of the m (mouse pointer) is in the client area of the window
                    {
                        var screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        var clientPoint = PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize) //If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr) HTTOPLEFT; //Resize diagonally to the left
                            else if
                                (clientPoint.X < Size.Width - resizeAreaSize) //If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr) HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr) HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= Size.Height - resizeAreaSize) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize) //Resize horizontally to the left
                                m.Result = (IntPtr) HTLEFT;
                            else if (clientPoint.X > Width - resizeAreaSize) //Resize horizontally to the right
                                m.Result = (IntPtr) HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize) //Resize diagonally to the left
                                m.Result = (IntPtr) HTBOTTOMLEFT;
                            else if (clientPoint.X < Size.Width - resizeAreaSize) //Resize vertically down
                                m.Result = (IntPtr) HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr) HTBOTTOMRIGHT;
                        }
                    }

                return;
            }
            
            //Remove border and keep snap window
            if (m.Msg == wmNccalcsize && m.WParam.ToInt32() == 1)
            {
                return;
            }
            
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == wmSyscommand)
            {
                // <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                // Quote:
                // In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                // are used internally by the system.To obtain the correct result when testing 
                // the value of wParam, an application must combine the value 0xFFF0 with the 
                // wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == scMinimize) //Before
                    _formSize = this.ClientSize;
                if (wParam == scRestore) // Restored form(Before)
                    this.Size = _formSize;
            }

            base.WndProc(ref m);
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                _formSize = ClientSize;
                //MaximumSize = Screen.GetWorkingArea(this).Size;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = _formSize;
            }
            AjustarFormulario();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void panelBarraTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                _formSize = ClientSize;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                Size = _formSize;
                WindowState = FormWindowState.Normal;
            }
            
            AjustarFormulario();
        }

        private void AbrirForm(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formularioHijo);
            panelFormularios.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void AbrirFormulario<TMiForm>() where TMiForm : Form, new()
        {
            Form? formulario = panelFormularios.Controls.OfType<TMiForm>().FirstOrDefault();

            //Si el formulario/instancia no existe
            if (formulario is null)
            {
                formulario = new TMiForm();
                formulario.TopLevel = false;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BackColor = panelFormularios.BackColor;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
            }
            
            formulario.BringToFront();

        }

        private void btnCompraLibros_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Expediciones>();
            AbrirForm(new Expediciones());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            if (formularioActivo != null)
                formularioActivo.Close();
            pictureBox5.BringToFront();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Ordenes>();
            AbrirForm(new Ordenes());
        }

        private void AjustarFormulario()
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Padding = new Padding(9, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (Padding.Top != borderSize)
                        Padding = new Padding(borderSize);
                    break;
                case FormWindowState.Minimized:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(new Random().Next(0, 255), new Random().Next(0, 255), 
                new Random().Next(0, 255));
        }

        private void btnListaLibros_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<LibrosActuales>();
            AbrirForm(new LibrosActuales());
        }

        private void btnEstadisticaCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEstadisticasRecepciones_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void panelSubMenu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click_2(object sender, EventArgs e)
        {
            //AbrirFormulario<Productos>();
            AbrirForm(new Productos());

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //AbrirFormulario<Proveedores>();
            AbrirForm(new Proveedores());
        }
    }
}