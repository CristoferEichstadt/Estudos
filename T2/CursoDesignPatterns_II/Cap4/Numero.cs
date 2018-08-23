using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap4
{
    public class Numero : IExpressao
    {
        private int numero;
        public Numero(int Numero)
        {
            numero = Numero;
        }

        public int Avalia()
        {
            return numero;
        }
    }
}
