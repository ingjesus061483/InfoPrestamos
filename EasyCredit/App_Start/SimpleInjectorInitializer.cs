[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(EasyCredit.App_Start.SimpleInjectorInitializer), "Initialize")]
namespace EasyCredit.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using Datos;
    using Helper;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<PrestamoDbContext>(Lifestyle.Scoped);
            container.Register<ClienteHelp>(Lifestyle.Scoped);
            container.Register<TipoIdentificacionHelp>(Lifestyle.Scoped);
            container.Register<TipoTelefonoHelp>(Lifestyle.Scoped);
            container.Register<FiadorHelp>(Lifestyle.Scoped);
            container.Register<AreaHelp>(Lifestyle.Scoped);
            container.Register<TelefonoHelp>(Lifestyle.Scoped);
            container.Register<ReferenciaHelp>(Lifestyle.Scoped);
            container.Register< PrestamoHelp>(Lifestyle.Scoped);
            container. Register<CuotaHelp>(Lifestyle.Scoped);
            container.Register<TipoCobroHelp>(Lifestyle.Scoped);
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}