using Gestao.Models;
using Gestao.Views;
using System.Runtime.InteropServices;
namespace Gestao
{
    public partial class Form1 : Form
    {
        private string perfilUsuario;
        public Form1(String pertilUsuario)
        {
            this.perfilUsuario = pertilUsuario;
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void BtnSuspender_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
                MenuVertical.Width = 60;
            else
                MenuVertical.Width = 250;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PrintControllerWithStatusDialog(this.Handle);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.perfilUsuario = null;
            LoginFrm Login = new LoginFrm();
            Login.Show();
            this.Hide();
        }
    }
}
