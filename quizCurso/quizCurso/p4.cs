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
    public partial class p4 : Form
    {
        public p4()
        {
            InitializeComponent();
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (radioButtonCerta.Checked == true)
            {

                MessageBox.Show("Resposta correta!!");
                VariaveisGlobais.acertos+=1;
                p5 p5 = new p5();
                p5.ShowDialog();
                this.Dispose();

            }
            else if (radioButton4.Checked || radiobutton3.Checked || radioButton1.Checked)
            {
                MessageBox.Show("Resposta errada!!");
                VariaveisGlobais.erros+=1;
                p5 p5 = new p5();
                p5.ShowDialog();
                this.Dispose();
            }
        }
    }
}
