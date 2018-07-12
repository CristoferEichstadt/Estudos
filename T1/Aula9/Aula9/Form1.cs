using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaGuilherme = new Conta();
            contaGuilherme.numero = 1;
            contaGuilherme.saldo = 5000.0;

            Cliente clienteGuilherme= new Cliente();
            clienteGuilherme.nome = "Guilherme Francisco";
            clienteGuilherme.endereco = "Rua Luíza Lucas";
            clienteGuilherme.cpf = "094.124.329-09";
            clienteGuilherme.idade = 17;

            contaGuilherme.cliente = clienteGuilherme;

            bool checar = contaGuilherme.Saca(1000.0);

            /*condição vai ver se a variavel bool checar vai ser true ou false, com isso vai saber se pode sacar tal quantia ou não
            ou seja, se tem 18 anos ou não.*/

            if (checar) //se checar true, entao pode sacar
            {
                MessageBox.Show("Guilherme possui a quantia de R$ " + contaGuilherme.saldo + " em sua conta");
            }
            else
            {
                MessageBox.Show("Guilherme não possui idade para fazer saque nessa quantia");
            }            
        }
    }
}
