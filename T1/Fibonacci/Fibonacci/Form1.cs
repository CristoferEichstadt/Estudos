using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fibonacci = "";

            int agora = 1;
            int antes = 0;




            while (agora <= 100)
            {

                fibonacci += agora + " ";
                int proximo = antes + agora;
                antes = agora;
                agora = proximo;

            }

            MessageBox.Show("--> Números de Fibonacci até 100: " + fibonacci + "<--");

        }
    }
}
