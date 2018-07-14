using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoII
{
    public partial class Form1 : Form
    {
        Conta contaGuilherme;
        string valorParaDepositar;
        string valorSaldo;
        double saldoAtual;
        double valorSaldoDepois;

        string valorSaldo2;
        string valorParaSacar;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contaGuilherme = new Conta(0.0, 1);
            contaGuilherme.Titular = new Cliente("Guilherme Francisco", "782.372.283", "Rua Luiza Lucas", "234.543.231-09", 18);

            textBoxTitular.Text = contaGuilherme.Titular.nome;
            textBoxTitular.SelectionStart = 0;
            textBoxSaldo.Text = contaGuilherme.Saldo.ToString();
            //converte int em string para passar p/ textBox
            textBoxNumeroConta.Text = Convert.ToString(contaGuilherme.numero);

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            valorParaDepositar = textBoxValor.Text;
            double valorDoDeposito = Convert.ToDouble(valorParaDepositar);
            contaGuilherme.Deposita(valorDoDeposito);

            valorSaldo = textBoxSaldo.Text;
            valorSaldoDepois = Convert.ToDouble(valorSaldo);

            saldoAtual = valorDoDeposito + valorSaldoDepois;
            textBoxSaldo.Text = contaGuilherme.Saldo.ToString();

            MessageBox.Show("Você depositou R$ " + valorDoDeposito);

            textBoxValor.Clear();
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            valorParaSacar = textBoxValor.Text;
            double valorDoSaque = Convert.ToDouble(valorParaSacar);
            contaGuilherme.Saca(valorDoSaque);

            valorSaldo2 = textBoxSaldo.Text;
            double valorSaldoAntes = Convert.ToDouble(valorSaldo2);

            double saldoAtualDepoisSaque = (valorSaldoAntes - valorDoSaque);
            textBoxSaldo.Text = contaGuilherme.Saldo.ToString();

            MessageBox.Show("Você sacou R$ " + valorDoSaque);

            textBoxValor.Clear();

        }
    }
}
