using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns_II.Cap5;

namespace CursoDesignPatterns_II.Cap4
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao e)
        {
            this.expressao = e;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(expressao.Avalia());
        }
    }
}
