namespace Avalonia.WebView;
internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => throw new NotImplementedException();

    public IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath)
    {
        throw new NotImplementedException();
    }
}
