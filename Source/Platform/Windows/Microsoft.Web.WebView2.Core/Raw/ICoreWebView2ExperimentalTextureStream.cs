// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalTextureStream
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("AFCA8431-633F-4528-ABFE-7FC3BEDD8962")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2ExperimentalTextureStream
  {
    [DispId(1610678272)]
    string Id { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddAllowedOrigin([MarshalAs(UnmanagedType.LPWStr), In] string origin, [In] int value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveAllowedOrigin([MarshalAs(UnmanagedType.LPWStr), In] string origin);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_StartRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTextureStreamStartRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_StartRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Stopped(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTextureStreamStoppedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Stopped([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ExperimentalTexture CreateTexture([In] uint widthInTexels, [In] uint heightInTexels);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ExperimentalTexture GetAvailableTexture();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CloseTexture([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTexture texture);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PresentTexture([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTexture texture);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Stop();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ErrorReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTextureStreamErrorReceivedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ErrorReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetD3DDevice([MarshalAs(UnmanagedType.IUnknown), In] object d3dDevice);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebTextureReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTextureStreamWebTextureReceivedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebTextureReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebTextureStreamStopped(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalTextureStreamWebTextureStreamStoppedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebTextureStreamStopped([In] EventRegistrationToken token);
  }
}
