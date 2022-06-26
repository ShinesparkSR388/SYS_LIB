using System.Runtime.InteropServices;

namespace PruebaInterfaz2;

public partial class FormWelcome : Form
{
    public FormWelcome()
    {
        InitializeComponent();
        lblUsuario.Text = $@"Bienvenido {FormLogin._usuario}";
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (Opacity < 1) Opacity += 0.05;
        circularProgressBar1.Value += 1;
        circularProgressBar1.Text = circularProgressBar1.Value.ToString();
        if (circularProgressBar1.Value != 100) return;
        timer1.Stop();
        timer2.Start();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
        Opacity -= 0.1;
        if (Opacity != 0) return;
        timer2.Stop();
        Close();
    }

    private void FormWelcome_Load(object sender, EventArgs e)
    {
        Opacity = 0.0D;
        timer1.Start();
        circularProgressBar1.Value = 0;
        circularProgressBar1.Minimum = 0;
        circularProgressBar1.Maximum = 100;
        timer3.Start();
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int param);
    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void timer3_Tick(object sender, EventArgs e)
    {
        int[] rgb = {new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255)};
        lblUsuario.ForeColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
    }
}