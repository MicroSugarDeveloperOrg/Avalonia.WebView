using Avalonia.WebView.Android.Common;
using Microsoft.Extensions.FileProviders;

namespace Avalonia.WebView.Android;
internal class BlazorWebViewHandlerProvider : IPlatformBlazorWebViewProvider
{
    public string Scheme => "https";     
    public IFileProvider CreateFileProvider(string contentRootDirFullPath) => new AndroidAssetFileProvider(contentRootDirFullPath);

}
