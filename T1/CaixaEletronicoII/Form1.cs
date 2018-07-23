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
            var contas = new List<Conta>(); //cria List de Contas;
            var c1 = new ContaCorrente();
            var clienteC1 = new Cliente();
            c1.Titular = clienteC1;
            c1.Titular.nome = "Guilherme";
            contas.Add(c1); //adiciona a c1 ao List criado(contas);

            Conta copiaC1 = contas[0]; //"copiaC1" vai ser igual ao "c1";

            var c2 = new ContaCorrente();
            var clienteC2 = new Cliente();
            c2.Titular = clienteC2;
            c2.Titular.nome = "Bruno";
            contas.Add(c2);

            //contas.RemoveAt(0); //remove na posição 0 da List;

            MessageBox.Show("Tem? " + contas.Contains(c1)); //".Contains" -> vai verificar se c1 está na List, retornando true ou false;
            MessageBox.Show("Tem? " + contas.Contains(c2));

            //contas.Remove(c1); //remove pelo nome da conta;

            MessageBox.Show("Número de contas na List: " + contas.Count);//".Count" -> retorna a quantidade de elementos na List;

            foreach (var conta in contas) //vai passar todos os elementos da List contas;
            {
                MessageBox.Show(conta.Titular.nome); //vai retornar o nome do titular de cada conta;
            }

            var contasCorrente = new HashSet<Conta>(); //HashSet verifica cada elemento e impede que haja repetição na List;
            var contaCorrente1 = new ContaCorrente();
            var clienteCO1 = new Cliente();
            contaCorrente1.Titular = clienteCO1;
            contaCorrente1.Titular.nome = "Guilherme";

            contasCorrente.Add(contaCorrente1);
            contasCorrente.Add(contaCorrente1);//adicionando duas vezes o mesmo elemento para testar HashSet;

            foreach (var contasCo in contasCorrente)
            {
                MessageBox.Show(contasCo.Titular.nome);//vai retornar o nome do titular de todas as contas da List, mas com HashSet, vai tirar as repetidas;
            }

            SortedSet<string> palavras = new SortedSet<string>();//mantem todos elementos em ordem crescente/alfabética e também não aceita repetição;
            palavras.Add("vida");
            palavras.Add("furadeira");
            palavras.Add("maçã");
            foreach (string palavra in palavras)
            {
                MessageBox.Show(palavra);//vai mostrar em ordem alfabética;
            }

            Dictionary<string, string> nomesEPalavras = new Dictionary<string, string>();   
            nomesEPalavras.Add("Erich", "vida");
            nomesEPalavras.Add("Alberto", "delicia");
            MessageBox.Show(nomesEPalavras["Erich"]);//vai retornar "vida", pois a chave Erich está associada à palavra "vida";

            SortedDictionary<string, string> nomes = new SortedDictionary<string, string>();//igual dictionary, mas vai organizar em ordem crescente das chaves;
            nomes.Add("Adriano", "Almeida");
            nomes.Add("Mario", "Amaral");
            nomes.Add("Eric", "Torti");
            nomes.Add("Guilherme", "Silveira");
            foreach (var i in nomes)
            {
                MessageBox.Show(i.Key + " " + i.Value);
            }
        }

        private Conta ContaComSaldo(double saldo)
        {
            Conta conta = new ContaCorrente();
            conta.Deposita(saldo);
            return conta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var contas = new List<Conta>(); //cria List de Contas;
            contas.Add(ContaComSaldo(2300));//adiciona ao List uma conta com tal saldo;
            contas.Add(ContaComSaldo(3000));

            var contasFiltradas = from conta in contas
                                  where conta.Saldo > 2000
                                  select conta; //LINQ -> equivale a um foreach

            foreach (var conta in contasFiltradas)
            {
                MessageBox.Show("Saldo da conta: " + conta.Saldo); //vai mostrar as contas da List de contasfiltradas;
            }
        }
    }
}

