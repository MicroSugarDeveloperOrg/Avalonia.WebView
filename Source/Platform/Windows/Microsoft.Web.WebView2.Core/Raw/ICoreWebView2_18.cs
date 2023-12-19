using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Web.WebView2.Core.Raw;
[ComImport]
[CompilerGenerated]
[Guid("7A626017-28BE-49B2-B865-3BA2B3522D90")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_18 : ICoreWebView2_17
{
    void _VtblGap1_114();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_LaunchingExternalUriScheme([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2LaunchingExternalUriSchemeEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_LaunchingExternalUriScheme([In] EventRegistrationToken token);
}
