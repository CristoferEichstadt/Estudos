using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1_CII
{
    public partial class Form1 : Form
    {
        Conta conta1;
        Cliente cliente1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conta1.Deposita(100.0);
            MessageBox.Show("Você depositou R$ 100 em sua conta!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* if para a ação de sacar da conta1 | if vai verificar se o método Saca vai retornar
             * true (aparece mensagem de saque efetuado) ou false (aí retorna msg de sem saldo)*/
            if (conta1.Saca(50.0))
            {
                MessageBox.Show("Saque efetuado!");
            }
            else
            {
                MessageBox.Show("Sem saldo em conta para efetuar o saque");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta1 = new Conta();
            cliente1 = new Cliente();
            conta1.Titular = cliente1;
            cliente1.idade = 18;
            cliente1.nome = "Guilherme Francisco";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo em conta: " + conta1.Saldo);

        }
    }
}
