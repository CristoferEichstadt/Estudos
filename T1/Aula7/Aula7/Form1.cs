using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta Guilherme = new Conta();
            Conta Mauricio = new Conta();
            
            Guilherme.saldo = 2000.0;
            Mauricio.saldo = 1000.0;

            Guilherme.Transfere(200.0, Mauricio);
            MessageBox.Show("-> O saldo de Guilherme agora é de: R$ " + Guilherme.saldo);
            MessageBox.Show("-> O saldo de Maurício agora é de: R$ " + Mauricio.saldo);

            double rendimentoAnual = Mauricio.CalculaRendimentoAnual();
            MessageBox.Show("O rendimento da conta de Maurício depois de 1 ano será: R$ " + rendimentoAnual + 
                            "\nSaldo após 1 ano em conta: R$ " + (Mauricio.saldo+rendimentoAnual));
        }
    }
}
