using Gestao.Repositories;
using Gestao.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao.Views
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UsuarioRepository repo = new UsuarioRepository();
            var usuario = repo.Login(txtUsername.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário ou senha inválidos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SessionManager.UsuarioId = usuario.Id;
            SessionManager.Nome = usuario.Nome;
            SessionManager.Perfil = usuario.Perfil;
            Form1 dashboard = new Form1(usuario.Perfil);
            dashboard.Show();
            this.Hide();
        }
    }
}
