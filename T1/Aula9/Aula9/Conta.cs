using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class Conta
    {
        public double saldo;
        public int numero;
        public Cliente cliente;

        public bool Saca(double valor)
        {
            if (valor > this.saldo || valor < 0)
            {
                return false;
            }
            else
            {
                if (this.cliente.MaiorDeIdade())
                {
                    this.saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

