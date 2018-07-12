using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMediaIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double idadeGuilherme = 18;
            double idadeDylan = 22;
            double idadeBruno = 17;
            double idadeValter = 49;

            double mediaIdade = ((idadeGuilherme + idadeDylan + idadeBruno + idadeValter) / 4);

            MessageBox.Show("A média de idade é de " + mediaIdade + " anos");
        }
    }
}
