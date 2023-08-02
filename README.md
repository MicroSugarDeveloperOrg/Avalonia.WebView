# Avalonia.WebView
WebView for avalonia

English| [简体中文](./README.zh-CN.md)

## Develop
* please install VisualStudio 2022 or greater or rider
* use .net7 runtime (version 7.0.0 or greater)(if you want to use others, please modify the version in the global.json)
* please setup workloads include Android, iOS, Wasm , MacOS
* please open the long path support in Windows OS(https://learn.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation?tabs=registry)

## How to use

1. Add [WebView.Avalonia][nuget] or [BlazorWebView.Avalonia][nuget] nuget package to your avaloniaui shared project:

       dotnet add package WebView.Avalonia
                    OR
       dotnet add package BlazorWebView.Avalonia

2. Add [WebView.Avalonia.Desktop][nuget] nuget package to your avaloniaui desktop project:

       dotnet add package WebView.Avalonia.Desktop

3. Add [WebView.Avalonia.Android][nuget] nuget package to your avaloniaui Android project:

       dotnet add package WebView.Avalonia.Android

4. Add [WebView.Avalonia.iOS][nuget] nuget package to your avaloniaui iOS project:

       dotnet add package WebView.Avalonia.iOS

5. Edit `App.axaml.cs` file:
   ```
    using AvaloniaWebView;

    OR

    using AvaloniaBlazorWebView;
    ...
     public override void RegisterServices()
     {
        base.RegisterServices();
        
        // if you use only WebView  
        AvaloniaWebViewBuilder.Initialize(default);

        // Or
    
        // if you use BlazorWebView, please setting for blazor 
        AvaloniaBlazorWebViewBuilder.Initialize(default, setting =>
        {
            //this is setting for blazor 
            setting.ComponentType = typeof(AppWeb);
            setting.Selector = "#app";

            //because avalonia support the html css and js for resource ,so you must set the ResourceAssembly 
            setting.IsAvaloniaResource = true;
            setting.ResourceAssembly = typeof(AppWeb).Assembly;
        }, inject =>
        {
            //you can inject the resource in this
            inject.AddSingleton<WeatherForecastService>();
        });
     }
   ```

6. Edit `Program` file for Desktop:
    ```
    using Avalonia.WebView.Desktop; <<---add this
    ...
     public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .UseReactiveUI()
            .UseDesktopWebView();   <<---add this
    ```

7. Edit `SplashActivity` file for Android:
    ```
    using Avalonia.WebView.Android; <<---add this
    ...
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .UseReactiveUI()
            .UseAndroidWebView();  <<---add this
    }
    ```

8. Edit `AppDelegate` file for iOS:
    ```
    using Avalonia.WebView.iOS;     <<---add this
    ...
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return builder.UseReactiveUI()
        .UseIosWebView();           <<---add this
    }
    ```

## Description

   > use Webview2 for Windows (please install Microsoft edge Webview2)

   > use WKWebView[Appkit] for MacOS (system in)

   > use Webkit Webview for Linux (if not please install [sudo apt-get libwebkit2gtk-4-37])

   > use Android.Webkit.WebView  for Android (this is in Microsoft-Android [net5.0-Android; net6.0-Android; net7.0-Android])

   > use WKWebView[UIKit] for iOS (this is in Microsoft-iOS [net5.0-ios; net6.0-ios; net7.0-ios])

| Platform                 | Technologies           |
|:-------------------------|:-----------------------|
| Windows                  | WebView2               |
| MacOS                    | WKWebView(Appkit)      |
| Linux                    | Gtk3,WebKitGtk3        |
| Android                  | Android.Webkit.WebView |
| iOS                      | WKWebView(UIKit)       |

## Demo

You can always download demo executable to play around with WebView
  > https://github.com/MicroSugarDeveloperOrg/Avalonia.WebView.Sample

## Version compatibility

| WebView.Avalonia Version | Avalonia Version |
|:-------------------------|:-----------------|
| 0.1.0-rc1.x              | 11.0-rc1.x       |
| 11.0.x                   | 11.0.x           |

**NOTE**

WebView.Avalonia is moving forward together with Avalonia preview versions now. So new feature/fixes are not backported to previous preview versions. If you need a feature/fix for outdated avalonia preview version, please raise an issue so we can do that for you. 

## Credits

[Avalonia](https://github.com/AvaloniaUI/Avalonia)

[Maui](https://github.com/dotnet/maui)

[Xamarin.MacIos](https://github.com/xamarin/xamarin-macios)

[Microsoft.WebView2](https://github.com/MicrosoftEdge/WebView2Samples)

[GTKSharp](https://github.com/GtkSharp/GtkSharp)

[WebkitGtkSharp](https://github.com/GtkSharp/GtkSharp)