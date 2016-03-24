using System;
using KakiBoard.Domain.Tarefa.Scopes;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Tipo
    {

        public Tipo(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public void Registar()
        {
            this.RegistrarTipoEscopoEstaValido();
        }

    }
}