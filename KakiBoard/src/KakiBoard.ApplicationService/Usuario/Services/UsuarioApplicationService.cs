using KakiBoard.Domain.Usuario.Events.UserEvents;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Domain.Usuario.Services;
using KakiBoard.SharedKernel.Events;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService.Usuario.Services
{
    public class UsuarioApplicationService : ApplicationService, IUsuarioApplicationService
    {
        private IUsuarioRepository _repository;

        public UsuarioApplicationService(IUsuarioRepository repository, IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _repository = repository;
        }

        public Domain.Usuario.Models.Usuario Registrar(Domain.Usuario.Commands.RegistrarUsuarioCommand command)
        {
            var usuario = new Domain.Usuario.Models.Usuario(command.Nome, command.Email, command.Senha, command.Perfil);

            var usuarioExiste = _repository.UsuarioJaExiste(usuario);
            usuario.Registrar();

            if (Commit())
            {
                _repository.Registrar(usuario);
                
                //disparar Domain events aqui
                DomainEvent.Raise(new RegistrarUsuario(usuario));
                return usuario;
            }

            return null;
        }
    }
}
