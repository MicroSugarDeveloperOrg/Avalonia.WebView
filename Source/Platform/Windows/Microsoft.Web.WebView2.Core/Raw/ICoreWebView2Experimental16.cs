// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental16
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("679DDF3F-9044-486F-8458-16653A0E1603")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Experimental16
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddWebResourceRequestedFilterWithRequestSourceKinds(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext,
      [In] COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveWebResourceRequestedFilterWithRequestSourceKinds(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext,
      [In] COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds);
  }
}
