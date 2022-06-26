using System.Runtime.InteropServices;
using CapaModelo;
using CapaDatos;

namespace PruebaInterfaz2;

public partial class FormLogin : Form
{
    public static string _usuario;
    private Usuario user = new Usuario();
    public FormLogin()
    {
        InitializeComponent();
        _usuario = "";
    }

    private void AbrirForms()
    {
        user.User = txtUsusario.Text;
        user.Pass = txtPass.Text;
        bool val = FD_LOGIN.ValidarUsuario(user);
        if (val == false) {
            MessageBox.Show("Usuario o contraseña incorrectos ", val.ToString());
            return;
        }
        _usuario = txtUsusario.Text;
        Hide();
        new FormWelcome().ShowDialog();
        new FormPrincipal().Show();
    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int param);
    private void FormLogin_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void btnAcceder_Click(object sender, EventArgs e)
    {
        AbrirForms();
        
    }

    private void txtPass_KeyDown(object sender, KeyEventArgs e)
    {
        if (!e.KeyCode.Equals(Keys.Enter)) return;
        AbrirForms();
    }
}