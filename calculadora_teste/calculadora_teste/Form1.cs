using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_teste
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);    
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = c.num1 + c.num2;
            textBoxResultado.Text = c.resultado.ToString();
            Math.Round(c.resultado, 2);
            textBoxResultado.Copy();
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = c.num1 - c.num2;
            textBoxResultado.Text = c.resultado.ToString();
            Math.Round(c.resultado, 2);
            textBoxResultado.Copy();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = c.num1 * c.num2;
            textBoxResultado.Text = c.resultado.ToString();
            Math.Round(c.resultado, 2);
            textBoxResultado.Copy();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = c.num1 / c.num2;
            textBoxResultado.Text = c.resultado.ToString();
            Math.Round(c.resultado, 2);
            textBoxResultado.Copy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNum1.Clear();
            textBoxNum2.Clear();
        }

        private void buttonPotenciacao_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = Math.Pow(c.num2, c.num1);
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();
        }

        private void buttonPorcentagem_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = (c.num1 / 100) * c.num2;
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);          
            c.resultado = Math.Sqrt(c.num1);
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();
        }

        private void buttonDicas_Click(object sender, EventArgs e)
        {
            dicas dicas = new dicas();
            dicas.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.num2 = double.Parse(textBoxNum2.Text);
            c.resultado = Math.Log(c.num1, c.num2);
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.resultado = Math.Cos(c.num1);
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.resultado = Math.Tan(c.num1);
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            calculos c = new calculos();
            c.num1 = double.Parse(textBoxNum1.Text);
            c.resultado = c.num1 * 3.14;
            textBoxResultado.Text = c.resultado.ToString();
            textBoxResultado.Copy();
        }
    }
}
