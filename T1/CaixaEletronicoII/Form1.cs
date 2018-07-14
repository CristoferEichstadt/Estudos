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
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta contaGuilherme = new Conta(500.0 , 1);
            contaGuilherme.Titular = new Cliente("Guilherme Francisco", "782.372.283", "Rua Luiza Lucas", "234.543.231-09");

            textBoxTitular.Text = contaGuilherme.Titular.nome;
            textBoxTitular.SelectionStart = 0;

            textBoxSaldo.Text = contaGuilherme.Saldo.ToString();
        }
    }
}
