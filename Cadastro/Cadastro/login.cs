using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBoxVerLogin_Click(object sender, EventArgs e)
        {
            pictureBoxOcultarLogin.BringToFront();
            textBoxLoginSenha.PasswordChar = '*';
        }

        private void pictureBoxOcultarLogin_Click(object sender, EventArgs e)
        {
            pictureBoxVerLogin.BringToFront();
            textBoxLoginSenha.PasswordChar = '\0';
        }

        private void textBoxLoginSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxLoginSenha.PasswordChar = '*';
        }

        private void buttonFazerLogin_Click(object sender, EventArgs e)
        {
            cadastro c = new cadastro();
            if ( c.nome == c.nome)
            MessageBox.Show("Parabéns, login efetuado com sucesso");
        }
    }
}
