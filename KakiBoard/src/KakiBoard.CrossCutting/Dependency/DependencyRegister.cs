using KakiBoard.ApplicationService.Usuario.Services;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Domain.Usuario.Services;
using KakiBoard.Infrastructure.Context;
using KakiBoard.Infrastructure.Repositories.Usuario;
using KakiBoard.Infrastructure.Transaction;
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

            container.RegisterType<IUsuarioApplicationService, UsuarioApplicationService>(new HierarchicalLifetimeManager());
        }
    }
}
