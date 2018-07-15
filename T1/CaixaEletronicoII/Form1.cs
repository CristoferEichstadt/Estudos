﻿using System;
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
        ContaPoupanca contaPoupancaGuilherme;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contaGuilherme = new Conta(100.0, 1);
            contaGuilherme.Titular = new Cliente("Guilherme Francisco", "782.372.283", "Rua Luiza Lucas", "234.543.231-09", 18);
            contaPoupancaGuilherme = new ContaPoupanca();
            contaPoupancaGuilherme.Titular = contaGuilherme.Titular;

            textBoxTitular.Text = contaGuilherme.Titular.nome;
            textBoxTitular.SelectionStart = 0;
            textBoxSaldo.Text = contaGuilherme.Saldo.ToString();
            //converte int em string para passar p/ textBox
            textBoxNumeroConta.Text = Convert.ToString(contaGuilherme.numero);
        }
        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            if (textBoxValor.Text == string.Empty || Char.IsLetter(textBoxValor.Text, 0)) //Verifica se o textBox está vazio || Verifica se está digitado com letras.
            {
                MessageBox.Show("Valor inválido. Digite novamente!");
                textBoxValor.Clear();
            }
            else // se não for letras nem vazio, faz o depósito.
            {
                string valorParaDepositar = textBoxValor.Text;
                double valorDoDeposito = Convert.ToDouble(valorParaDepositar);
                contaGuilherme.Deposita(valorDoDeposito);

                string valorSaldo = textBoxSaldo.Text;
                double valorSaldoDepois = Convert.ToDouble(valorSaldo);

                double saldoAtual = valorDoDeposito + valorSaldoDepois;
                textBoxSaldo.Text = contaGuilherme.Saldo.ToString();

                MessageBox.Show("Você depositou R$ " + valorDoDeposito);

                textBoxValor.Clear();
            }
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            if (textBoxValor.Text == string.Empty || Char.IsLetter(textBoxValor.Text, 0))
            {
                MessageBox.Show("Valor inválido. Digite novamente!");
                textBoxValor.Clear();
            }
            else if (Convert.ToDouble(textBoxValor.Text.ToString()) > Convert.ToDouble(contaGuilherme.Saldo.ToString())) //Verifica se o valor digitado é maior que saldo em conta.
            {
                MessageBox.Show("Valor superior ao saldo. Digite um valor válido.");
                textBoxValor.Clear();
            }
            else //se não for letras nem vazio, faz saque
            {
                string valorParaSacar = textBoxValor.Text;
                double valorDoSaque = Convert.ToDouble(valorParaSacar);
                contaGuilherme.Saca(valorDoSaque);

                string valorSaldo2 = textBoxSaldo.Text;
                double valorSaldoAntes = Convert.ToDouble(valorSaldo2);

                double saldoAtualDepoisSaque = (valorSaldoAntes - valorDoSaque);
                textBoxSaldo.Text = contaGuilherme.Saldo.ToString();

                MessageBox.Show("Você sacou R$ " + valorDoSaque);

                textBoxValor.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contaPoupancaGuilherme.Deposita(100);
            contaPoupancaGuilherme.Saca(10);

            MessageBox.Show("Saldo da conta poupança é R$ " + contaPoupancaGuilherme.Saldo);
        }
    }
}
