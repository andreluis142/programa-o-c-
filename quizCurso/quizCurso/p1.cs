using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizCurso
{
    public partial class p1 : Form
    {
        public p1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (radioCerta.Checked == true)
            {

                MessageBox.Show("Resposta correta!!");
                VariaveisGlobais.acertos+=1;
                p2 p2 = new p2();
                p2.ShowDialog();
                this.Dispose();

            }
            else if (radioButton1.Checked || radioButton4.Checked || radioButton2.Checked)
            {
                MessageBox.Show("Resposta errada!!");
                VariaveisGlobais.erros+=1;
                p2 p2 = new p2();
                p2.ShowDialog();
                this.Dispose();
            }
        }
    }
}
