using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CálculoImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 7001;

            if (valorDaNotaFiscal < 1000)
            {
                double imposto = (valorDaNotaFiscal * 2) / 100;
                MessageBox.Show("O imposto em cima do valor de " + valorDaNotaFiscal + " reais é de " + imposto + " reais. Imposto de 2%.\n" + "Valor com impostos: R$ " + (valorDaNotaFiscal + imposto) + ".");


            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal < 3000)
            {
                double imposto = (valorDaNotaFiscal * 2.5) / 100;
                MessageBox.Show("O imposto em cima do valor de " + valorDaNotaFiscal + " reais é de " + imposto + " reais. Imposto de 2.5%.\n" + "Valor com impostos: R$ " + (valorDaNotaFiscal + imposto) + ".");

            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal < 7000)
            {
                double imposto = (valorDaNotaFiscal * 2.8) / 100;
                MessageBox.Show("O imposto em cima do valor de " + valorDaNotaFiscal + " reais é de " + imposto + " reais. Imposto de 2.8%.\n" + "Valor com impostos: R$ " + (valorDaNotaFiscal + imposto) + ".");
            }
            else if (valorDaNotaFiscal > 7000)
            {
                double imposto = (valorDaNotaFiscal * 3) / 100;
                MessageBox.Show("O imposto em cima do valor de " + valorDaNotaFiscal + " reais é de " + imposto + " reais. Imposto de 3%.\n" + "Valor com impostos: R$ " + (valorDaNotaFiscal + imposto) + ".");
            }
        }
    }
}
