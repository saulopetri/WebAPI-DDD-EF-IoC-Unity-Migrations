using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;
using ProjetoModeloDDD.Infra.Data.Context;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace ProjetoModeloDDD.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType <DbContext, ProjetoModeloDDDContext>(new HierarchicalLifetimeManager());

            //Application
            container.RegisterType(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.RegisterType<IClienteAppService, ClienteAppService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEnderecoAppService, EnderecoAppService>(new HierarchicalLifetimeManager());

            //Domain
            container.RegisterType(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.RegisterType<IClienteService, ClienteService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEnderecoService, EnderecoService>(new HierarchicalLifetimeManager());

            //Repository
            container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.RegisterType<IClienteRepository, ClienteRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEnderecoRepository, EnderecoRepository>(new HierarchicalLifetimeManager());
        }
    }
}
