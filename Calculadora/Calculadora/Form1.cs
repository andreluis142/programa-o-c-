using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            calculadora n = new calculadora();
            n.num1 = double.Parse(textBoxNumero1.Text);
            n.num2 = double.Parse(textBoxNumero2.Text);
            n.somar();
            labelValorFinal.Text = Convert.ToString(n.somar());

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            calculadora n = new calculadora();
            n.num1 = double.Parse(textBoxNumero1.Text);
            n.num2 = double.Parse(textBoxNumero2.Text);
            n.multiplicar();
            labelValorFinal.Text = Convert.ToString(n.multiplicar());
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            calculadora n = new calculadora();
            n.num1 = double.Parse(textBoxNumero1.Text);
            n.num2 = double.Parse(textBoxNumero2.Text);
            n.subtrair();
            labelValorFinal.Text = Convert.ToString(n.subtrair());
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            calculadora n = new calculadora();
            n.num1 = double.Parse(textBoxNumero1.Text);
            n.num2 = double.Parse(textBoxNumero2.Text);
            n.dividir();
            labelValorFinal.Text = Convert.ToString(n.dividir());
        }

        private void textBoxNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }
    }
}
