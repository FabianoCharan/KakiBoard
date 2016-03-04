using System;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Interacao
    {
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }

        protected Interacao() { }

        public Interacao(DateTime dataInicio)
        {
            DataInicio = dataInicio;
        }

    }
}
