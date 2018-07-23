using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    static class StringUtils 
    {
        public static string Pluralize (string palavra)
        {
            if (palavra.EndsWith("s")) //se a palavra termina em S
            {
                return palavra;
            }
            else
            {
                return palavra + "s";
            }
        }
    }
}
