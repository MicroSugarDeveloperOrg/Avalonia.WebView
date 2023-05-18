// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame2
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("7A6A5834-D185-4DBF-B63F-4A9BC43107D4")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Frame2 : ICoreWebView2Frame
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_8();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigationStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameNavigationStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ContentLoading(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameContentLoadingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ContentLoading([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigationCompleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameNavigationCompletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DOMContentLoaded(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameDOMContentLoadedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DOMContentLoaded([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ExecuteScript([MarshalAs(UnmanagedType.LPWStr), In] string javaScript, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExecuteScriptCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PostWebMessageAsJson([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PostWebMessageAsString([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebMessageReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameWebMessageReceivedEventHandler handler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebMessageReceived([In] EventRegistrationToken token);
  }
}
