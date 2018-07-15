﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class ContaInvestimento : Conta
    {
        public override bool Saca(double valor)
        {
            if (valor > this.Saldo || valor <= 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.MaiorDeIdade())
                {
                    this.Saldo -= valor;
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
