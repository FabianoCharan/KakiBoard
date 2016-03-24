using KakiBoard.ApplicationService.Tarefa;
using KakiBoard.ApplicationService.Usuario.Handler;
using KakiBoard.ApplicationService.Usuario.Services;
using KakiBoard.CrossCutting.Events;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Domain.Tarefa.Services;
using KakiBoard.Domain.Usuario.Events.UserEvents;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Domain.Usuario.Services;
using KakiBoard.Infrastructure.Context;
using KakiBoard.Infrastructure.Repositories.Tarefa;
using KakiBoard.Infrastructure.Repositories.Usuario;
using KakiBoard.Infrastructure.Transaction;
using KakiBoard.SharedKernel.Events;
using KakiBoard.SharedKernel.Helpers.Contracts;
using KakiBoard.SharedKernel.Repositories;
using Microsoft.Practices.Unity;

namespace KakiBoard.CrossCutting.Dependency
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<KakiBoardContext, KakiBoardContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<IUsuarioRepository, UsuarioRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITipoRepository, TipoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProjetoRepository, ProjetoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IStatusRepository, StatusRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IUsuarioApplicationService, UsuarioApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITipoApplicationService, TipoApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IStatusApplicationService, StatusApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IProjetoApplicationService, ProjetoApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandler<RegistrarUsuario>, RegistrarUsuarioHandler>();

        }
    }
}
