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
        Conta[] contas;
        int indiceSelecionado;
        Conta contaSelecionada;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //criando array de contas:
            contas = new Conta[2];
            contas[0] = new Conta(2500.0, 1);
            contas[0].Titular = new Cliente("Guilherme Francisco", "782.372.283", "Rua Luiza Lucas", "234.543.231-09", 18);

            contas[1] = new Conta(1500.0, 2);
            contas[1].Titular = new Cliente("João Silva", "241.421.563", "Rua São Paulo", "213.758.132-23", 20);

            foreach (Conta conta in contas)
            {
                comboBoxContas.Items.Add(conta.Titular.nome);
            }

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
                contaSelecionada.Deposita(valorDoDeposito);

                string valorSaldo = textBoxSaldo.Text;
                double valorSaldoDepois = Convert.ToDouble(valorSaldo);

                double saldoAtual = valorDoDeposito + valorSaldoDepois;
                textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

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
            else if (Convert.ToDouble(textBoxValor.Text.ToString()) > Convert.ToDouble(contaSelecionada.Saldo.ToString())) //Verifica se o valor digitado é maior que saldo em conta.
            {
                MessageBox.Show("Valor superior ao saldo. Digite um valor válido.");
                textBoxValor.Clear();
            }
            else //se não for letras nem vazio, faz saque
            {
                string valorParaSacar = textBoxValor.Text;
                double valorDoSaque = Convert.ToDouble(valorParaSacar);
                contaSelecionada.Saca(valorDoSaque);

                string valorSaldo2 = textBoxSaldo.Text;
                double valorSaldoAntes = Convert.ToDouble(valorSaldo2);

                double saldoAtualDepoisSaque = (valorSaldoAntes - valorDoSaque);
                textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

                MessageBox.Show("Você sacou R$ " + valorDoSaque);

                textBoxValor.Clear();
            }
        }


        private void comboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceSelecionado = comboBoxContas.SelectedIndex;
            contaSelecionada = contas[indiceSelecionado];
            //vai ver qual conta foi selecionada no comboBox e usá-la

            textBoxTitular.Text = Convert.ToString(contaSelecionada.Titular.nome);
            textBoxSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textBoxNumeroConta.Text = Convert.ToString(contaSelecionada.numero);

        }
    }
}
