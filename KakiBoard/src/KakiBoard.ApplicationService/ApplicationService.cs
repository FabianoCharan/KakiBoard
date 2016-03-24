using KakiBoard.ApplicationService.Usuario.Handler;
using KakiBoard.SharedKernel.Events;
using KakiBoard.SharedKernel.Helpers.Contracts;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService
{
    public class ApplicationService
    {
        private IUnitOfWork _unitOfWork;
        private IHandler<DomainNotification> _notifications;
        private RegistrarUsuarioHandler _registrarUsuarioHandler;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            _registrarUsuarioHandler = DomainEvent.Container.GetService<RegistrarUsuarioHandler>();
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;

            _unitOfWork.Commit();
            return true;
        }
    }
}
