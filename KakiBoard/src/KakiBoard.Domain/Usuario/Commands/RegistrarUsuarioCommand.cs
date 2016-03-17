namespace KakiBoard.Domain.Usuario.Commands
{
    public class RegistrarUsuarioCommand
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
    }
}
