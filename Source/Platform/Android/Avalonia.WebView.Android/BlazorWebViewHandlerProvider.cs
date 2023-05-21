namespace Avalonia.WebView.Android;

internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "https";
    public IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath) => new AndroidAssetFileProvider(assembly, contentRootDirFullPath);

}
