using CursoDesignPatterns_II.Cap2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),
            };

            var piano = new Piano();
            piano.Toca(musica);
        }
    }
}
