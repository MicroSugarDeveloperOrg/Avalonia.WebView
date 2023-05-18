// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("3DF9B733-B9AE-4A15-86B4-EB9EE9826469")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2CompositionController
  {
    [DispId(1610678272)]
    object RootVisualTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SendMouseInput(
      [In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind,
      [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
      [In] uint mouseData,
      [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SendPointerInput(
      [In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PointerInfo pointerInfo);

    [DispId(1610678276)]
    IntPtr Cursor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678277)]
    uint SystemCursorId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CursorChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CursorChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CursorChanged([In] EventRegistrationToken token);
  }
}
