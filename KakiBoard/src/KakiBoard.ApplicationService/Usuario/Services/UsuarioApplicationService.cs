using System.Collections.Generic;
using KakiBoard.Domain.Usuario.Commands;
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

        public Domain.Usuario.Models.Usuario Atualizar(RegistrarUsuarioCommand command)
        {
            var usuario = new Domain.Usuario.Models.Usuario(command.Nome, command.Email, command.Senha, command.Perfil);

            if (_repository.UsuarioJaExiste(command.EmailNovo))
                DomainEvent.Raise(new DomainNotification("RegistroExistente", "O E-mail já está registrado no sistema."));

            usuario.Atualizar();

            if(Commit())
            {
                _repository.Update(usuario);

                //Raise Domain events here
                return usuario;
            }

            return null;
        }

        public List<Domain.Usuario.Models.Usuario> ListarTodosUsuarios()
        {
            return _repository.Listar();
        }

        public Domain.Usuario.Models.Usuario Registrar(RegistrarUsuarioCommand command)
        {
            var usuario = new Domain.Usuario.Models.Usuario(command.Nome, command.Email, command.Senha, command.Perfil);

            if (_repository.UsuarioJaExiste(usuario.Email))
                DomainEvent.Raise(new DomainNotification("RegistroExistente", "O E-mail já está registrado no sistema."));

            usuario.Registrar();

            if (Commit())
            {
                _repository.Add(usuario);
                
                //disparar Domain events aqui
                DomainEvent.Raise(new RegistrarUsuario(usuario));
                return usuario;
            }

            return null;
        }
    }
}
