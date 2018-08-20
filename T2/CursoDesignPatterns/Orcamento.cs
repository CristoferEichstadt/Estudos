using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento()
        {
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}