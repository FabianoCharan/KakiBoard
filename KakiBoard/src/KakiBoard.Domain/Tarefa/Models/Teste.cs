using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Teste
    {
        public int Id { get; private set; }
        public string Testador { get; private set; }
        public string Perfil { get; private set; }
        public bool Aprovado { get; private set; }
        public DateTime? Data { get; private set; }

        protected Teste() { }

        public Teste(string testador, string perfil)
        {
            Testador = testador;
            Perfil = perfil;
        }
    }
}
