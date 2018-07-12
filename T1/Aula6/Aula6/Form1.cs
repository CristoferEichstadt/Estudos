using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int numeroDaConta1 = 1;
            String titularDaConta1 = "Guilherme Francisco";
            Double saldoDaConta1 = 2000.0;

            int numeroDaConta2 = 2;
            String titularDaConta2 = "José Manuel";
            Double saldoDaConta2 = 3200.0;*/

            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Guilherme Francisco";
            umaConta.saldo = 2100.0;
            umaConta.agencia = "123-4";
            umaConta.conta = "65432-1";
            umaConta.cpf = "387.364.236-17";

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "José Costa";
            outraConta.saldo = 5500.0;
            outraConta.agencia = "432-1";
            outraConta.conta = "12345-6";
            outraConta.cpf = "482.597.412-32";

            MessageBox.Show("O titular da conta é: " + umaConta.titular + "\nPossui R$ " + umaConta.saldo + 
                            " de saldo." + "\nAgência: " + umaConta.agencia + ". Conta: " + umaConta.conta + "\nCpf: " + umaConta.cpf);

            MessageBox.Show("O titular da conta é: " + outraConta.titular + "\nPossui R$ " + outraConta.saldo +
                            " de saldo." + "\nAgência: " + outraConta.agencia + ". Conta: " + outraConta.conta + "\nCpf: " + outraConta.cpf);
        }
    }
}
