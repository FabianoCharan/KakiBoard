using System;
using KakiBoard.Domain.Tarefa.Scopes;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Status
    {

        public Status(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public void Registrar()
        {
            this.RegistrarStatusEscopoEstaValido();
        }

    }
}