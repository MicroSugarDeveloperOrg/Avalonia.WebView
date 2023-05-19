using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaBlazorWebView;
using Microsoft.Extensions.DependencyInjection;
using SampleBlazorWebView.Data;
using SampleBlazorWebView.ViewModels;
using SampleBlazorWebView.Views;

namespace SampleBlazorWebView;
public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void RegisterServices()
    {
        base.RegisterServices();

        AvaloniaLocator.CurrentMutable.UseAvaloniaBlazorWebView(default, setting =>
        {
            setting.ComponentType = typeof(AppWeb);
            setting.Selector = "#app";
        }, inject =>
        {
            inject.AddSingleton<WeatherForecastService>();
        });
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}