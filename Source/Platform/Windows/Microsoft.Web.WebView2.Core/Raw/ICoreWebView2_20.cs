using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Web.WebView2.Core.Raw;
[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B4BC1926-7305-11EE-B962-0242AC120002")]
[TypeIdentifier]
public interface ICoreWebView2_20 : ICoreWebView2_19
{
    void _VtblGap1_118();

    [DispId(1611923456)]
    uint FrameId
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        get;
    }
}
