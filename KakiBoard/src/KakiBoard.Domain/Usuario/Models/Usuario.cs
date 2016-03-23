using KakiBoard.Domain.Usuario.Scope;
using System;

namespace KakiBoard.Domain.Usuario.Models
{
    public class Usuario
    {
        //public Guid _id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Perfil { get; private set; }

        protected Usuario() { }

        public Usuario(string nome, string email, string senha, string perfil)
        {
            //_id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Perfil = perfil;
        }

        public void Registrar()
        {
            if (UsuarioEscopo.RegistrarUsuarioEscopoValido(this))
                return;
        }

        public void Atualizar()
        {
            if (UsuarioEscopo.AtualizarUsuarioEscopoValido(this))
                return;
        }

        public void AtualizarEmail(string emailNovo)
        {
            Email = emailNovo;
        }

        public void Autenticar(string email, string senha)
        {

        }
    }
}
