namespace Avalonia.WebView.iOS;

internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "app";

    public IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath) => new iOSAssetFileProvider(contentRootDirFullPath);

}
