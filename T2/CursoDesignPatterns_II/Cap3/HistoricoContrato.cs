using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap3
{
    public class HistoricoContrato
    {
        private List<EstadoContrato> Estados = new List<EstadoContrato>();
        public void Adiciona(EstadoContrato estado)
        {
            this.Estados.Add(estado);
        }

        public EstadoContrato Pega (int indice)
        {
            return Estados[indice];
        }
    }
}
