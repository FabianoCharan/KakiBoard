
using System.Collections.Generic;

namespace KakiBoard.Domain.Usuario.Services
{
    public interface IUsuarioApplicationService
    {
        Models.Usuario Registrar(Commands.RegistrarUsuarioCommand command);
        Models.Usuario Atualizar(Commands.RegistrarUsuarioCommand command);

        List<Models.Usuario> ListarTodosUsuarios();
    }
}
