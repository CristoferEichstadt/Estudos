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
        ContaCorrente[] contas;
        ContaCorrente contaSelecionada;
        ContaCorrente contaSelecionadaTransefere;
        int indiceSelecionado;
        int indiceSelecionadoTransferencia;
        int contaTeste;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //criando array de contas:
            contas = new ContaCorrente[3];
            contas[0] = new ContaCorrente(2500.0, 1);
            contas[0].Titular = new Cliente("Guilherme Francisco", "782.372.283", "Rua Luiza Lucas", "234.543.231-09", 18);

            contas[1] = new ContaCorrente(1500.0, 2);
            contas[1].Titular = new Cliente("João Silva", "241.421.563", "Rua São Paulo", "213.758.132-23", 20);

            contas[2] = new ContaCorrente(2000.0, 3);
            contas[2].Titular = new Cliente("Gabriel Menezes", "566.983.653", "Rua Itajaí", "621.354.953.93", 41);

            PopulaContas(comboBoxContas);
            PopulaContas(comboBoxTransferencia);
            labelEscolherConta.Select();
        }

        private void PopulaContas(ComboBox combo)
        {
            foreach (Conta conta in contas)
            {
                combo.Items.Add(conta.Titular.nome);
            }
        }
        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                string valorParaDepositar = textBoxValor.Text;
                try
                {
                    double valorDoDeposito = Convert.ToDouble(valorParaDepositar);
                    contaSelecionada.Deposita(valorDoDeposito);
                    contaSelecionada.Deposita(valorDoDeposito);

                    string valorSaldo = textBoxSaldo.Text;
                    double valorSaldoDepois = Convert.ToDouble(valorSaldo);

                    double saldoAtual = valorDoDeposito + valorSaldoDepois;
                    textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

                    MessageBox.Show("Você depositou R$ " + valorDoDeposito);

                    textBoxValor.Clear();
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("Digite algum valor no campo.");
                }
            }
            catch (ValorIgualZeroException exception)
            {
                MessageBox.Show("Valor não pode ser zero! Digite um valor válido.");
                textBoxValor.Clear();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor negativo é inválido! Digite novamente.");
                textBoxValor.Clear();
            }
            catch (ValorDigitadoLetrasExeption exception)
            {
                MessageBox.Show("Valor Inválido! Digite novamente.");
                textBoxValor.Clear();
            }
        }
        private void buttonSacar_Click(object sender, EventArgs e)
        {
            try
            {
                string valorParaSacar = textBoxValor.Text;
                double valorDoSaque = Convert.ToDouble(valorParaSacar);
                contaSelecionada.Saca(valorDoSaque);

                string valorSaldo2 = textBoxSaldo.Text;
                double valorSaldoAntes = Convert.ToDouble(valorSaldo2);

                double saldoAtualDepoisSaque = (valorSaldoAntes - valorDoSaque);
                textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

                MessageBox.Show("Você sacou R$ " + valorDoSaque);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Digite um valor válido.");
            }

            catch (SaldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo insuficiente! Digite um valor válido.");
            }
            catch (ValorIgualZeroException exception)
            {
                MessageBox.Show("Valor não pode ser zero! Digite um valor válido.");
                textBoxValor.Clear();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor negativo é inválido! Digite novamente.");
                textBoxValor.Clear();
            }
            catch (ValorDigitadoLetrasExeption exception)
            {
                MessageBox.Show("Valor inválido! Digite novamente.");
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


            comboBoxTransferencia.Items.Clear();

            for (int i = 0; i < contas.Length; i++)
            {
                if (!contas[i].Titular.nome.Equals(comboBoxContas.Text)) //se tudo o que for de diferente do que está no textBox..
                {
                    comboBoxTransferencia.Items.Add(contas[i].Titular.nome); //vai adicionar tudo o que for diferente do que foi selecionado no primeiro comboBox
                }
            }

        }
        private void comboBoxTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            indiceSelecionadoTransferencia = comboBoxTransferencia.SelectedIndex;
            contaSelecionadaTransefere = contas[indiceSelecionadoTransferencia];

        }
        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            if (textBoxValor.Text == string.Empty || Char.IsLetter(textBoxValor.Text, 0)) //Verifica se o textBox está vazio || Verifica se está digitado com letras.
            {
                MessageBox.Show("Valor inválido. Digite novamente!");
                textBoxValor.Clear();
            }
            else // se não for letras nem vazio, faz o depósito.
            {
                string valorParaTransferir = textBoxValor.Text;
                double valorDaTransferencia = Convert.ToDouble(valorParaTransferir);
                contaSelecionada.Transfere(valorDaTransferencia, contaSelecionadaTransefere);

                string valorSaldo = textBoxSaldo.Text;
                double valorSaldoDepois = Convert.ToDouble(valorSaldo);

                double saldoAtual = valorDaTransferencia - valorSaldoDepois;
                textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

                MessageBox.Show("Você transferiu R$ " + valorDaTransferencia);



            }
        }
    }
}
