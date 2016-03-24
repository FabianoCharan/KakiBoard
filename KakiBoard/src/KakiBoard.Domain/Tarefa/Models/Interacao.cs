using System;
using KakiBoard.Domain.Tarefa.Scopes;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Interacao
    {

        public Interacao()
        {
            Id = Guid.NewGuid();
            DataInicio = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }

        public void Registrar()
        {
            this.RegistrarInteracaoEscopoEstaValido();
        }

    }
}