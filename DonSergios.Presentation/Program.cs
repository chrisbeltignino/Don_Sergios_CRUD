using DonSergios.Applications.Interfaces;
using DonSergios.Infraestructure.Persistence;
using DonSergios.Infraestructure.Repositories;
using DonSergios.Infraestructure.Services;
using DonSergios.Presentation.Presentation;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using Container = SimpleInjector.Container;

namespace DonSergios.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear el contenedor de IoC
            var container = new Container();

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

                // Registra tus servicios y repositorios aquí
                container.Register<IClienteService, ClienteService>();
                container.Register<IAutoService, AutoService>();
                container.Register<IServicioService, ServicioService>();
                container.Register<IModeloService, ModeloService>();

                container.Register<IClienteRepository, ClienteRepository>();
                container.Register<IAutoRepository, AutoRepository>();
                container.Register<IServicioRepository, ServicioRepository>();
                container.Register<IModeloRepository, ModeloRepository>();

                // Registra tu DbContext aquí
                container.Register<DBDON_SERGIOSEntities>(Lifestyle.Scoped);

                // Registra el Formulario Hijo
                
                //container.Register<FrmClientes>(Lifestyle.Scoped);
                //container.Register<FrmAutos>();
                //container.Register<FrmDashboard>();
                //container.Register<FrmRepuestos>();
                
                // Comprueba si la configuración del contenedor es válida
                container.Verify();

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new FrmMenu(
                    container.GetInstance<IClienteService>(),
                    container.GetInstance<IAutoService>(),
                    container.GetInstance<IServicioService>(),
                    container.GetInstance<IModeloService>()));
            }
        }
    }
}