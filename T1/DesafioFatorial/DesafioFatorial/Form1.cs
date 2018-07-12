using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroFatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                numeroFatorial = numeroFatorial * n;
                MessageBox.Show("O fatorial de " + n + " é " + numeroFatorial);
            }

        }
    }
}
