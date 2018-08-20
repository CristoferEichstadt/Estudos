using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemDaNota
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(String descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
