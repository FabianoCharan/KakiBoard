using KakiBoard.Domain.Usuario.Events.UserEvents;
using KakiBoard.SharedKernel.Helpers.Contracts;

namespace KakiBoard.Domain.Usuario.Handler
{
    public interface IRegistrarUsuarioHandler : IHandler<RegistrarUsuario>
    {
    }
}
