// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental12
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("2B1AAA06-CE28-4565-AE06-26404C2E8D10")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Experimental12
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FaviconChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FaviconChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FaviconChanged([In] EventRegistrationToken token);

    [DispId(1610678274)]
    string FaviconUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetFavicon(
      [In] COREWEBVIEW2_FAVICON_IMAGE_FORMAT format,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2GetFaviconCompletedHandler completedHandler);
  }
}
