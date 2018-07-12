using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 15;
            Boolean brasileira = false;

            if (idade >= 16 && brasileira == true)
            {
                MessageBox.Show("Você tem " + idade + " anos e é brasileiro(a). Você pode votar!");
            }
            else if (idade < 16)
            {
                MessageBox.Show("Você não tem idade para votar ainda.");
            }
            else if (brasileira == false)
            {
                MessageBox.Show("Você não é brasileiro(a). Não pode votar.");
            }
        }
    }
}
