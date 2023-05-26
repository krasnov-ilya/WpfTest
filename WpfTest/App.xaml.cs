using System.Windows;
using Microsoft.Extensions.Hosting;

namespace WpfTest;

public partial class App : Application
{
    private readonly IHost _host;
    
    public App()
    {
        _host = BuildHost();
    }
    
    private static IHost BuildHost() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices(x =>
            {
                
            })
            .Build();

    protected override async void OnStartup(StartupEventArgs e)
    {
        await _host.StartAsync();
        base.OnStartup(e);
    }
    
    protected override async void OnExit(ExitEventArgs e)
    {
        using (_host)
            await _host.StopAsync();

        base.OnExit(e);
    }
}