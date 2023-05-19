using Microsoft.AspNetCore.Components.WebView.Wpf;
using Microsoft.Extensions.DependencyInjection;
using SampleBlazorWebViewShared;
using System.Windows;

namespace SampleBlazorWebView.Wpf;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        var services1 = new ServiceCollection();
        services1.AddWpfBlazorWebView();
#if DEBUG
        services1.AddBlazorWebViewDeveloperTools();
#endif

        Resources.Add("services1", services1.BuildServiceProvider());

        InitializeComponent();

        blazorWebView1.RootComponents.Add(new RootComponent() { ComponentType = typeof(AppWeb), Selector = "#app" });

    }
}
