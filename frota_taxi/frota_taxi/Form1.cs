using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frota_taxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Combustivel c = new Combustivel();
            c.km = double.Parse(textBoxKm.Text);
            c.litros = double.Parse(textBoxLitros.Text);
            c.gasolina = double.Parse(textBoxPrecoGasolina.Text);
            c.alcool = double.Parse(textBoxPrecoAlcool.Text);
            c.rendimentoG = double.Parse(textBoxGasolina.Text);
            c.rendimentoA = double.Parse(textBoxAlcool.Text);
            c.resultadoRendimento = c.rendimentoA / c.rendimentoG;
            c.resultadoA = (c.km / c.litros) * c.resultadoRendimento;
            c.resultadoG = c.km / c.litros;


            listBox1.Items.Add("Km/l percorridos com gasolina: " + c.resultadoG);
            listBox1.Items.Add("Km/l percorridos com alcool: " + c.resultadoA);
            listBox1.Items.Add("Valor gasto com Gasolina: " + c.litros * c.gasolina);
            listBox1.Items.Add("Valor gasto com Alcool: " + c.litros * c.alcool);
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
