[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(EasyCredit.App_Start.SimpleInjectorInitializer), "Initialize")]
namespace EasyCredit.App_Start
{
    using Datos;
    using Factory;
    using Helper;
    using SelectPdf;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using System.Reflection;
    using System.Web.Mvc;
    
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
            container.Register < EmpresaHelp >(Lifestyle.Scoped);
            container.Register<PrestamoDbContext>(Lifestyle.Scoped);
            container.Register<ClienteHelp>(Lifestyle.Scoped);
            container.Register<TipoIdentificacionHelp>(Lifestyle.Scoped);
            container.Register<TipoTelefonoHelp>(Lifestyle.Scoped);
            container.Register<FiadorHelp>(Lifestyle.Scoped);
            container.Register<AreaHelp>(Lifestyle.Scoped);
            container.Register<TelefonoHelp>(Lifestyle.Scoped);
            container.Register<ReferenciaHelp>(Lifestyle.Scoped);
            container.Register< PrestamoHelp>(Lifestyle.Scoped);
            container. Register<AmortizacionHelp>(Lifestyle.Scoped);
            container.Register<TipoCobroHelp>(Lifestyle.Scoped);
            container.Register<PagoHelp>(Lifestyle.Scoped); 
            container.Register<TipoPagoHelp>(Lifestyle.Scoped); 
            container.Register<FormaPagoHelp>(Lifestyle.Scoped);
            container.Register<UsuarioHelp>(Lifestyle.Scoped);
            container.Register<EmpleadoHelp>(Lifestyle.Scoped);
            container.Register<TipoRegimenHelp>(Lifestyle.Scoped);
            container.Register<RoleHelp>(Lifestyle.Scoped);
            container.Register<CategoriaHelp>(Lifestyle.Scoped);
            container.Register<ProductoHelp>(Lifestyle.Scoped);
            container.Register<UnidadMedidaHelp>(Lifestyle.Scoped); 
            container.Register<ExistenciaHelp> (Lifestyle.Scoped);  
          //  container.Register<HtmlToPdf>(Lifestyle.Scoped);
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}