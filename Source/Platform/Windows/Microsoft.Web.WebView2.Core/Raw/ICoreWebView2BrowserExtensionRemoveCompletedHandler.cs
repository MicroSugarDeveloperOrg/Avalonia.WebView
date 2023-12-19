using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8E41909A-9B18-4BB1-8CDF-930F467A50BE")]
[TypeIdentifier]
public interface ICoreWebView2BrowserExtensionRemoveCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode);
}
