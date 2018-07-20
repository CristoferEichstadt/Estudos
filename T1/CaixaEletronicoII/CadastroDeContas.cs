﻿using System;
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
            try
            {
                Cliente titular = new Cliente(textBoxNomeCliente.Text);
                int numero = Convert.ToInt32(textBoxEnderecoCliente.Text);
                titular.idade = Convert.ToInt16(textBox1.Text);
                Conta conta = null;

                if (comboBoxTipoConta.SelectedIndex == 0)
                {
                    conta = new ContaCorrente()
                    {
                        Titular = titular,
                        Numero = numero
                    };
                }
                else if (comboBoxTipoConta.SelectedIndex == 1)
                {
                    conta = new ContaPoupanca()
                    {
                        Titular = titular,
                        Numero = numero
                    };
                }
                
                aplicacaoPrincipal.AdicionaConta(conta);
            }
            catch (Exception exception)
            {

                MessageBox.Show("Selecione o tipo de conta");
            }
        }
    }
}




