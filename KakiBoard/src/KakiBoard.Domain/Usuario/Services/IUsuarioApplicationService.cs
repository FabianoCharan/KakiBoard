
namespace KakiBoard.Domain.Usuario.Services
{
    public interface IUsuarioApplicationService
    {
        Models.Usuario Registrar(Commands.RegistrarUsuarioCommand command);
    }
}
