using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using WebView2Control = Microsoft.Web.WebView2.Wpf.WebView2;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;

internal class WebView2WebViewManager : WebViewManager
{
    // Using an IP address means that WebView2 doesn't wait for any DNS resolution,
    // making it substantially faster. Note that this isn't real HTTP traffic, since
    // we intercept all the requests within this origin.
    internal static readonly string AppHostAddress = "0.0.0.0";

    /// <summary>
    /// Gets the application's base URI. Defaults to <c>https://0.0.0.0/</c>
    /// </summary>
    protected static readonly string AppOrigin = $"https://{AppHostAddress}/";

    internal static readonly Uri AppOriginUri = new(AppOrigin);
    private readonly ILogger _logger;
    private readonly WebView2Control _webview;
    private readonly Task<bool> _webviewReadyTask;
    private readonly string _contentRootRelativeToAppRoot;


    private protected CoreWebView2Environment? _coreWebView2Environment;
    private readonly Action<UrlLoadingEventArgs> _urlLoading;
    private readonly Action<BlazorWebViewInitializingEventArgs> _blazorWebViewInitializing;
    private readonly Action<BlazorWebViewInitializedEventArgs> _blazorWebViewInitialized;
    private readonly BlazorWebViewDeveloperTools _developerTools;

    internal WebView2WebViewManager(
        WebView2Control webview,
        IServiceProvider services,
        Dispatcher dispatcher,
        IFileProvider fileProvider,
        JSComponentConfigurationStore jsComponents,
        string contentRootRelativeToAppRoot,
        string hostPagePathWithinFileProvider,
        Action<UrlLoadingEventArgs> urlLoading,
        Action<BlazorWebViewInitializingEventArgs> blazorWebViewInitializing,
        Action<BlazorWebViewInitializedEventArgs> blazorWebViewInitialized,
        ILogger logger)
        : base(services, dispatcher, AppOriginUri, fileProvider, jsComponents, hostPagePathWithinFileProvider)

    {
        ArgumentNullException.ThrowIfNull(webview);


        if (services.GetService<WpfBlazorMarkerService>() is null)
        {
            throw new InvalidOperationException(
                "Unable to find the required services. " +
                $"Please add all the required services by calling '{nameof(IServiceCollection)}.{nameof(BlazorWebViewServiceCollectionExtensions.AddWpfBlazorWebView)}' in the application startup code.");
        }


        _logger = logger;
        _webview = webview;
        _urlLoading = urlLoading;
        _blazorWebViewInitializing = blazorWebViewInitializing;
        _blazorWebViewInitialized = blazorWebViewInitialized;
        _developerTools = services.GetRequiredService<BlazorWebViewDeveloperTools>();
        _contentRootRelativeToAppRoot = contentRootRelativeToAppRoot;

        _webviewReadyTask = TryInitializeWebView2();
    }

    /// <inheritdoc />
    protected override void NavigateCore(Uri absoluteUri)
    {
        _ = Dispatcher.InvokeAsync(async () =>
        {
            var isWebviewInitialized = await _webviewReadyTask;

            if (isWebviewInitialized)
            {
                _webview.Source = absoluteUri;
            }
        });
    }

    /// <inheritdoc />
    protected override void SendMessage(string message)
        => _webview.CoreWebView2.PostWebMessageAsString(message);

    private async Task<bool> TryInitializeWebView2()
    {
        var args = new BlazorWebViewInitializingEventArgs();

        _blazorWebViewInitializing?.Invoke(args);
        var userDataFolder = args.UserDataFolder ?? GetWebView2UserDataFolder();
        _coreWebView2Environment = await CoreWebView2Environment.CreateAsync(
            browserExecutableFolder: args.BrowserExecutableFolder!,
            userDataFolder: userDataFolder!,
            options: args.EnvironmentOptions!)
        .ConfigureAwait(true);

        await _webview.EnsureCoreWebView2Async(_coreWebView2Environment);

        var developerTools = _developerTools;


        ApplyDefaultWebViewSettings(developerTools);


        _blazorWebViewInitialized?.Invoke(new BlazorWebViewInitializedEventArgs
        {
            WebView = _webview,
        });

        _webview.CoreWebView2.AddWebResourceRequestedFilter($"{AppOrigin}*", CoreWebView2WebResourceContext.All);

        _webview.CoreWebView2.WebResourceRequested += async (s, eventArgs) =>
        {
            await HandleWebResourceRequest(eventArgs);
        };

        _webview.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
        _webview.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;

        // The code inside blazor.webview.js is meant to be agnostic to specific webview technologies,
        // so the following is an adaptor from blazor.webview.js conventions to WebView2 APIs
        await _webview.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(@"
				window.external = {
					sendMessage: message => {
						window.chrome.webview.postMessage(message);
					},
					receiveMessage: callback => {
						window.chrome.webview.addEventListener('message', e => callback(e.data));
					}
				};
			")
            .ConfigureAwait(true);

        QueueBlazorStart();

        _webview.CoreWebView2.WebMessageReceived += (s, e) => MessageReceived(new Uri(e.Source), e.TryGetWebMessageAsString());

        return true;
    }

    protected virtual Task HandleWebResourceRequest(CoreWebView2WebResourceRequestedEventArgs eventArgs)
    {

        var allowFallbackOnHostPage =
            eventArgs.ResourceContext == CoreWebView2WebResourceContext.Document ||
            eventArgs.ResourceContext == CoreWebView2WebResourceContext.Other; // e.g., dev tools requesting page source

        var requestUri = QueryStringHelper.RemovePossibleQueryString(eventArgs.Request.Uri);



        if (TryGetResponseContent(requestUri, allowFallbackOnHostPage, out var statusCode, out var statusMessage, out var content, out var headers))
        {
            StaticContentHotReloadManager.TryReplaceResponseContent(_contentRootRelativeToAppRoot, requestUri, ref statusCode, ref content, headers);

            var headerString = GetHeaderString(headers);

            var autoCloseStream = new AutoCloseOnReadCompleteStream(content);



            eventArgs.Response = _coreWebView2Environment!.CreateWebResourceResponse(autoCloseStream, statusCode, statusMessage, headerString);
        }
        else
        {

        }

        return Task.CompletedTask;
    }


    protected virtual void QueueBlazorStart()
    {
    }

    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs args)
    {
        if (Uri.TryCreate(args.Uri, UriKind.RelativeOrAbsolute, out var uri))
        {
            var callbackArgs = UrlLoadingEventArgs.CreateWithDefaultLoadingStrategy(uri, AppOriginUri);


            _urlLoading?.Invoke(callbackArgs);


            if (callbackArgs.UrlLoadingStrategy == UrlLoadingStrategy.OpenExternally)
            {
                LaunchUriInExternalBrowser(uri);
            }

            args.Cancel = callbackArgs.UrlLoadingStrategy != UrlLoadingStrategy.OpenInWebView;
        }
    }

    private void CoreWebView2_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs args)
    {
        if (Uri.TryCreate(args.Uri, UriKind.RelativeOrAbsolute, out var uri))
        {
            LaunchUriInExternalBrowser(uri);
            args.Handled = true;
        }
    }

    private void LaunchUriInExternalBrowser(Uri uri)
    {


        using (var launchBrowser = new Process())
        {
            launchBrowser.StartInfo.UseShellExecute = true;
            launchBrowser.StartInfo.FileName = uri.ToString();
            launchBrowser.Start();
        }

    }

    private protected static string GetHeaderString(IDictionary<string, string> headers) =>
        string.Join(Environment.NewLine, headers.Select(kvp => $"{kvp.Key}: {kvp.Value}"));

    private void ApplyDefaultWebViewSettings(BlazorWebViewDeveloperTools devTools)
    {
        _webview.CoreWebView2.Settings.AreDevToolsEnabled = devTools.Enabled;

        // Desktop applications typically don't want the default web browser context menu
        _webview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

        // Desktop applications almost never want to show a URL preview when hovering over a link
        _webview.CoreWebView2.Settings.IsStatusBarEnabled = false;
    }

    private static string? GetWebView2UserDataFolder()
    {
        if (Assembly.GetEntryAssembly() is { } mainAssembly)
        {
            var applicationName = mainAssembly.GetName().Name;
            var result = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                $"{applicationName}.WebView2");

            return result;
        }

        return null;
    }
}