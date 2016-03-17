using KakiBoard.Domain.Usuario.Events.UserEvents;
using KakiBoard.SharedKernel.Helpers.Contracts;
using System.Collections.Generic;

namespace KakiBoard.ApplicationService.Usuario.Handler
{
    public class RegistrarUsuarioHandler : IHandler<RegistrarUsuario>
    {
        private List<RegistrarUsuario> _notifications;

        public void Handle(RegistrarUsuario args)
        {
            //disparar eventos aqui

        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }

        public IEnumerable<RegistrarUsuario> Notify()
        {
            return GetValue();
        }

        private List<RegistrarUsuario> GetValue()
        {
            return _notifications;
        }

        public void Dispose()
        {
            _notifications = new List<RegistrarUsuario>();
        }

    }
}
