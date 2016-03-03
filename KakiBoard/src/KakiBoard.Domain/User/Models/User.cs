using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KakiBoard.Domain.User.Models
{
    public class User
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        protected User() {}

        public User(string nome,string email,string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }



}
