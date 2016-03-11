using KakiBoard.SharedKernel.Repositories;
using System.Collections.Generic;

namespace KakiBoard.Domain.Usuario.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Models.Usuario>
    {
        void Registrar(Models.Usuario usuario);
        List<Models.Usuario> ListarUsuarios();
    }
}
