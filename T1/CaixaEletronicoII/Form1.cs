using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benner.CaixaEletronicoII.Contas;
using Benner.CaixaEletronicoII.Usuarios;

namespace Benner.CaixaEletronicoII
{
    public partial class Form1 : Form
    {
        Conta contaSelecionada;
        Conta contaSelecionadaTransfere;
        private Conta[] contas;

        private int quantidadeDeContas;
        int indiceSelecionado;
        int indiceSelecionadoTransferencia;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelEscolherConta.Select();
            contas = new Conta[10];
        }
        private void PopulaContas(ComboBox combo)
        {
            textBoxTitular.Text = Convert.ToString(contas[comboBoxContas.SelectedIndex].Titular.nome);
            textBoxSaldo.Text = Convert.ToString(contas[comboBoxContas.SelectedIndex].Saldo);
            textBoxNumeroConta.Text = Convert.ToString(contas[comboBoxContas.SelectedIndex].Numero);
        }
        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                string valorParaDepositar = textBoxValor.Text;

                double valorDoDeposito = Convert.ToDouble(valorParaDepositar);
                contaSelecionada.Deposita(valorDoDeposito);

                string valorSaldo = textBoxSaldo.Text;
                double valorSaldoDepois = Convert.ToDouble(valorSaldo);

                double saldoAtual = valorDoDeposito + valorSaldoDepois;
                textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

                MessageBox.Show("Você depositou R$ " + valorDoDeposito);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Digite um valor válido no campo.");
            }
            catch (ValorIgualZeroException exception)
            {
                MessageBox.Show("Valor não pode ser zero! Digite um valor válido.");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor negativo é inválido! Digite novamente.");
            }
            finally
            {
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
                MessageBox.Show("Digite um valor válido no campo.");
            }

            catch (SaldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo insuficiente! Digite um valor válido.");
            }
            catch (ValorIgualZeroException exception)
            {
                MessageBox.Show("Valor não pode ser zero! Digite um valor válido.");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor negativo é inválido! Digite novamente.");
            }
            finally
            {
                textBoxValor.Clear();
            }
        }
        private void comboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceSelecionado = comboBoxContas.SelectedIndex;
            contaSelecionada = contas[indiceSelecionado];
            PopulaContas(comboBoxContas);
            comboBoxTransferencia.Items.Clear();

            for (int i = 0; i < quantidadeDeContas; i++)
            {
                if (!contas[i].Titular.nome.Equals(comboBoxContas.Text))
                {
                    comboBoxTransferencia.Items.Add(contas[i].Titular.nome);
                }
            }
        }
        private void comboBoxTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < quantidadeDeContas; i++)
            {
                if (contas[i].Titular.nome == comboBoxTransferencia.Text)
                {
                    contaSelecionadaTransfere = contas[i];
                }

            }
        }
        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                string valorParaTransferir = textBoxValor.Text;
                double valorDaTransferencia = Convert.ToDouble(valorParaTransferir);
                contaSelecionada.Transfere(valorDaTransferencia, contaSelecionadaTransfere);
                MessageBox.Show("novo saldo " + contaSelecionada.Saldo);
                string valorSaldo = textBoxSaldo.Text;
                double valorSaldoDepois = Convert.ToDouble(valorSaldo);

                double saldoAtual = valorDaTransferencia - valorSaldoDepois;
                textBoxSaldo.Text = contaSelecionada.Saldo.ToString();

                MessageBox.Show("Você transferiu R$ " + valorDaTransferencia);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Digite um valor válido no campo.");
            }
            catch (SaldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo insuficiente! Digite um valor válido.");
            }
            catch (ValorIgualZeroException exception)
            {
                MessageBox.Show("Valor não pode ser zero! Digite um valor válido.");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor negativo é inválido! Digite novamente.");
            }
            finally
            {
                textBoxValor.Clear();
            }
        }
        public void AdicionaConta(Conta conta)
        {
            if (this.quantidadeDeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;
            comboBoxContas.Items.Add(conta.Titular.nome);
            comboBoxContas.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeContas formularioDeCadastro = new CadastroDeContas(this);
            formularioDeCadastro.ShowDialog();
        }

        public void RemoverContas(Conta conta)
        {
            comboBoxContas.Items.Remove(conta);

            int i;
            for (i = 0; i < this.quantidadeDeContas; i++)
            {
                if (this.contas[i] == conta)
                {
                    break;
                }
            }
            while (i + 1 <= this.quantidadeDeContas)
            {
                this.contas[i] = this.contas[i + 1];
                i++;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RemoverContas(contas[comboBoxContas.SelectedIndex]);

            if (quantidadeDeContas > 1)
            {
                PopulaContas(comboBoxContas);
            }
            else
            {
                comboBoxContas.Items.Clear();
                textBoxNumeroConta.Clear();
                textBoxSaldo.Clear();
                textBoxTitular.Clear();
                textBoxValor.Clear();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>(); //cria List de Contas
            var c1 = new ContaCorrente();
            var ClienteC1 = new Cliente();
            c1.Titular = ClienteC1;
            c1.Titular.nome = "Guilherme";
            contas.Add(c1); //adiciona a c1 ao List criado(contas)

            Conta copiaC1 = contas[0]; //"copiaC1" vai ser igual ao "c1"

            var c2 = new ContaCorrente();
            var ClienteC2 = new Cliente();
            c2.Titular = ClienteC2;
            c2.Titular.nome = "Bruno";

            MessageBox.Show("Tem? " + contas.Contains(c1)); //".Contains" -> vai verificar se c1 está na List, retornando true ou false
            MessageBox.Show("Tem? " + contas.Contains(c2));

        }
    }
}

