namespace Avalonia.WebView.Windows;

internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "https";

    public IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath)
    {
        if (Directory.Exists(contentRootDirFullPath))
            return new PhysicalFileProvider(contentRootDirFullPath);
        else
            return new NullFileProvider();
    }
}
