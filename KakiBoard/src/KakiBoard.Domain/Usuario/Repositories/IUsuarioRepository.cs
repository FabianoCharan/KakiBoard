using System.Collections.Generic;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.Domain.Usuario.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Models.Usuario>
    {
        void Autenticar(Models.Usuario usuario);
        List<Models.Usuario> Listar();
        bool UsuarioJaExiste(string email);
    }
}
