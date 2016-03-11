using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Domain.Usuario.Services;
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

        public Domain.Usuario.Models.Usuario Registrar(Domain.Usuario.Models.Usuario usuario)
        {
            _repository.Registrar(usuario);

            if (Commit())
            {
                //disparar Domain events aqui
                //DomainEvent.Raise()
                return usuario;
            }

            return null;
        }
    }
}
