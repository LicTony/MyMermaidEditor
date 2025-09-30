using System.Configuration;
using System.Data;
using System.Windows;
using Serilog;

namespace MermaidEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // Configurar Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logs/mermaid-editor-.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Console()
                .CreateLogger();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Log.Information("Aplicación iniciándose");
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Log.Information("Aplicación cerrándose");
            Log.CloseAndFlush();
            base.OnExit(e);
        }
    }

}
