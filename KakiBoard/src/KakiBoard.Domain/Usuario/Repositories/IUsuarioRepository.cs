using KakiBoard.SharedKernel.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KakiBoard.Domain.Usuario.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Models.Usuario>
    {
        void Registrar(Models.Usuario usuario);
        void Autenticar(Models.Usuario usuario);
        List<Models.Usuario> ListarUsuarios();
        bool UsuarioJaExiste(Models.Usuario usuario);
        void AtualizarUsuario(Models.Usuario usuario);
    }
}
