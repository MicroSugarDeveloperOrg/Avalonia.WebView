using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("AF641F58-72B2-11EE-B962-0242AC120002")]
[TypeIdentifier]
public interface ICoreWebView2Environment13 : ICoreWebView2Environment12
{
    void _VtblGap1_22();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetProcessExtendedInfos([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetProcessExtendedInfosCompletedHandler handler);
}
