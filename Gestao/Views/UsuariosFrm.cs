using Gestao.Models;
using Gestao.Repositories;
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
    public partial class UsuariosFrm : Form
    {
        public UsuariosFrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }


        private void CarregarUsuarios()
        {
            UsuarioRepository repo = new UsuarioRepository();
            dataGridView1.DataSource = repo.ListarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUserFrm createUser = new CreateUserFrm();
            createUser.Show();
            //this.Hide();
        }
    }
}
