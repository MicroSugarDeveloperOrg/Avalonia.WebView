// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment10
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("EE0EB9DF-6F12-46CE-B53F-3F47B9C928E0")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Environment10 : ICoreWebView2Environment9
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_17();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreateCoreWebView2ControllerWithOptions(
      [In] IntPtr ParentWindow,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ControllerOptions options,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreateCoreWebView2CompositionControllerWithOptions(
      [In] IntPtr ParentWindow,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ControllerOptions options,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);
  }
}
