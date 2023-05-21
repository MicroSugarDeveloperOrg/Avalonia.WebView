using Avalonia.WebView.iOS.Common;
using Microsoft.Extensions.FileProviders;

namespace Avalonia.WebView.iOS;

internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "app";

    public IFileProvider CreateFileProvider(string contentRootDirFullPath) => new iOSAssetFileProvider(contentRootDirFullPath);

}
