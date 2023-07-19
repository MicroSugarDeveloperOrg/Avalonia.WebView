# Avalonia.WebView

[English](./README.md)| 简体中文

## 开发
* 请安装 VisualStudio 2022 或更高版本或 Rider
* 使用 .NET 7 运行时（版本 7.0.0 或更高）（如果您想使用其他版本，请在 global.json 中进行修改）
* 请设置包括 Android、iOS、Wasm 和 MacOS 在内的工作负载
* 请在 Windows 操作系统中打开长路径支持（https://learn.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation?tabs=registry）

## 如何使用

1. 将 [WebView.Avalonia][nuget] 或 [BlazorWebView.Avalonia][nuget] NuGet 包添加到您的 AvaloniaUI 共享项目中：

       dotnet add package WebView.Avalonia
                    或
       dotnet add package BlazorWebView.Avalonia

2. 将 [WebView.Avalonia.Desktop][nuget] NuGet 包添加到您的 AvaloniaUI 桌面项目中：

       dotnet add package WebView.Avalonia.Desktop

3. 将 [WebView.Avalonia.Android][nuget] NuGet 包添加到您的 AvaloniaUI Android 项目中：

       dotnet add package WebView.Avalonia.Android

4. 将 [WebView.Avalonia.iOS][nuget] NuGet 包添加到您的 AvaloniaUI iOS 项目中：

       dotnet add package WebView.Avalonia.iOS

5. 编辑 `App.axaml.cs` 文件：
   ```
    using AvaloniaWebView;

    或

    using AvaloniaBlazorWebView;
    ...
     public override void RegisterServices()
     {
        base.RegisterServices();
        
        // 如果只使用 WebView
        AvaloniaWebViewBuilder.Initialize(default);

        // 或者

        // 如果使用 BlazorWebView，请进行 Blazor 设置
        AvaloniaBlazorWebViewBuilder.Initialize(default, setting =>
        {
            // 这是 Blazor 设置
            setting.ComponentType = typeof(AppWeb);
            setting.Selector = "#app";

            // 因为 Avalonia 支持资源中的 HTML、CSS 和 JS，所以必须设置 ResourceAssembly
            setting.IsAvaloniaResource = true;
            setting.ResourceAssembly = typeof(AppWeb).Assembly;
        }, inject =>
        {
            // 您可以在此处注入资源
            inject.AddSingleton<WeatherForecastService>();
        });
     }
   ```

6. 编辑桌面项目的 `Program` 文件：
    ```
    using Avalonia.WebView.Desktop; <<--- 添加此行
    ...
     public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .UseReactiveUI()
            .UseDesktopWebView();   <<--- 添加此行
    ```

7. 编辑 Android 项目的 `SplashActivity` 文件：
    ```
    using Avalonia.WebView.Android; <<--- 添加此行
    ...
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .UseReactiveUI()
            .UseAndroidWebView();  <<--- 添加此行
    }
    ```

8. 编辑 iOS 项目的 `AppDelegate` 文件：
    ```
    using Avalonia.WebView.iOS;     <<--- 添加此行
    ...
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return builder.UseReactiveUI()
        .UseIosWebView();           <<--- 添加此行
    }
    ```

## 描述

   > 在 Windows 上使用 Webview2（请安装 Microsoft Edge Webview2）

   > 在 MacOS 上使用 WKWebView[Appkit]（系统自带）

   > 在 Linux 上使用 Webkit Webview（如果没有，请安装 [sudo apt-get libwebkit2gtk-4-37]）

   > 在 Android 上使用 Android.Webkit.WebView（这是在 Microsoft-Android 中的 [net5.0-Android; net6.0-Android; net7.0-Android]）

   > 在 iOS 上使用 WKWebView[UIKit]（这是在 Microsoft-iOS 中的 [net5.0-ios; net6.0-ios; net7.0-ios]）

## 演示

您可以随时下载演示可执行文件来体验 WebView
  > https://github.com/MicroSugarDeveloperOrg/Avalonia.WebView.Sample

## 版本兼容性

| WebView.Avalonia 版本 | Avalonia 版本 |
|:-------------------------|:-----------------|
| 0.1.0-rc1.x              | 11.0-rc1.x       |

**注意**

WebView.Avalonia 现在与 Avalonia 预览版本一起前进。因此，新功能/修复不会被回溯到以前的预览版本。如果您需要过时的 Avalonia 预览版本的功能/修复，请提出问题，我们可以为您解决。

## 鸣谢

[Avalonia](https://github.com/AvaloniaUI/Avalonia)

[Maui](https://github.com/dotnet/maui)

[Xamarin.MacIos](https://github.com/xamarin/xamarin-macios)

[Microsoft.WebView2](https://github.com/MicrosoftEdge/WebView2Samples)

[GTKSharp](https://github.com/GtkSharp/GtkSharp)

[WebkitGtkSharp](https://github.com/GtkSharp/GtkSharp)"