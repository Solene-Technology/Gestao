using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gestao.Services.UserService;

namespace Gestao.Views
{
    public partial class CreateUserFrm : Form
    {
        public CreateUserFrm()
        {
            InitializeComponent();
        }

        private void CreateUserFrm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioService service = new UsuarioService();
                if (!txtSenha.Text.Equals(txtSenha2.Text))
                {
                    throw new Exception("As senhas são diferentes");
                }
                bool sucesso = service.CriarUsuario(txtNome.Text, txtUsername.Text, txtSenha.Text, txtPerfil.Text);

                if (sucesso)
                    MessageBox.Show("Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
