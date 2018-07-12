using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.cliente = cliente;

            cliente.nome = "Guilherme";
            cliente.endereco = "Rua Luíza Lucas";
            cliente.rg = "5.726.289";

            MessageBox.Show("O cliente " + conta.cliente.nome + " reside em " + conta.cliente.endereco + "," +
                            "\ne é portador do Rg " + conta.cliente.rg);
        }
    }
}
