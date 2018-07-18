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
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;

        string titular, rg, cpf, endereco;
        Cliente cliente;

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {

        }
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            titular = textBoxNomeCliente.Text;
            rg = textBoxRgCliente.Text;
            cpf = textBoxCpfCliente.Text;
            endereco = textBoxEnderecoCliente.Text;

            cliente = new Cliente();

        }
    }
}
