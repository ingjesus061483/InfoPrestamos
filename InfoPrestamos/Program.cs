using Datos;
using Helper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoPrestamos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServiceCollection services = new ServiceCollection();
            Configservice(services);
            var servicesprovider = services.BuildServiceProvider();
            var mainForm  = servicesprovider.GetRequiredService<MainForm >();
            Application.Run(mainForm );
        }
        static void Configservice(ServiceCollection services)
        {
            services.AddScoped<MainForm>();
            services.AddScoped<PrestamoDbContext>();
            services.AddScoped<ClienteHelp >();
            services.AddScoped<AmortizacionHelp>();
            services.AddScoped<EmpleadoHelp>();
            services.AddScoped<FiadorHelp>();
            services.AddScoped<FormaPagoHelp>();
            services.AddScoped<PagoHelp>();
            services.AddScoped<PrestamoHelp>();
            services.AddScoped<RoleHelp>();
            services.AddScoped<TipoCobroHelp>();
            services.AddScoped<TipoIdentificacionHelp>();
            services.AddScoped<UsuarioHelp>();
            services.AddScoped<TelefonoHelp>();
            services.AddScoped<TipoTelefonoHelp>();

        }
    }
}
