// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_11
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("0BE78E56-C193-4051-B943-23B460C08BDB")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2_11 : ICoreWebView2_10
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_96();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CallDevToolsProtocolMethodForSession(
      [MarshalAs(UnmanagedType.LPWStr), In] string sessionId,
      [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
      [MarshalAs(UnmanagedType.LPWStr), In] string parametersAsJson,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ContextMenuRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContextMenuRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ContextMenuRequested([In] EventRegistrationToken token);
  }
}
