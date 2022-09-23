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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            cadastro c = new cadastro();
            c.nome = textBoxNome.Text;
            c.cpf = maskedTextBoxCpf.Text;
            c.id = maskedTextBoxId.Text;
            c.sexo = comboBoxSexo.Text;
            c.cidade = textBoxCidade.Text;

            listBox1.Items.Add(c.nome);
            listBox1.Items.Add(c.sexo);
            listBox1.Items.Add(c.cidade);
            listBox1.Items.Add(c.id);  
            listBox1.Items.Add(c.cpf);    
              


        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxVer_Click(object sender, EventArgs e)
        {
            pictureBoxOcultar.BringToFront();
            textBoxSenha.PasswordChar = '\0';
        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            pictureBoxVer.BringToFront();
            textBoxSenha.PasswordChar = '*';
        }
    }
}
