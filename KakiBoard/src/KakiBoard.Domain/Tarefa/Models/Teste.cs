using System;
using KakiBoard.Domain.Tarefa.Scopes;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Teste
    {

        public Teste(string tester, string role)
        {
            Id = Guid.NewGuid();
            Tester = tester;
            Role = role;
        }

        public Guid Id { get; private set; }
        public string Tester { get; private set; }
        public string Role { get; private set; }
        public bool Approved { get; private set; }
        public DateTime? Date { get; private set; }

        public void Registrar()
        {
            this.RegistrarTesteEscopoEstaValido();
        }

    }
}