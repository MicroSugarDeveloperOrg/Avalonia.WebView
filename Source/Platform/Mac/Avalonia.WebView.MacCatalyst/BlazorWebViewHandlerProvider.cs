namespace Avalonia.WebView.MacCatalyst;
internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "app";

    public IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath)
    {
        if (Directory.Exists(contentRootDirFullPath))
            return new PhysicalFileProvider(contentRootDirFullPath);
        else
            return new NullFileProvider();
    }
}
