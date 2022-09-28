using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace quizCurso
{
    public partial class p3 : Form
    {
        public p3()
        {
            InitializeComponent();
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (radioButtonCerta.Checked == true)
            {

                MessageBox.Show("Resposta correta!!");
                VariaveisGlobais.acertos+=1;
                p4 p4 = new p4();
                p4.ShowDialog();
                this.Dispose();

            }
            else if (radiobutton3.Checked || radioButton1.Checked || radioButton2.Checked)
            {
                MessageBox.Show("Resposta errada!!");
                VariaveisGlobais.erros+=1;
                p4 p4 = new p4();
                p4.ShowDialog();
                this.Dispose();
            }
        }
    }
}
