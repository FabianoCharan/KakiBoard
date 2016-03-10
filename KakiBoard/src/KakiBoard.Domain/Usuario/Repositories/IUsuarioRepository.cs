using System.Collections.Generic;

namespace KakiBoard.Domain.Usuario.Repositories
{
    public interface IUsuarioRepository
    {
        List<Models.Usuario> ListarUsuarios();
    }
}
