namespace KakiBoard.Domain.Usuario.Models
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Perfil { get; private set; }

        protected Usuario() {}

        public Usuario(string nome,string email,string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }



}
