// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental15
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("D267CA18-6779-49F9-B18E-75C25C61FA9B")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Experimental15
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ServerCertificateErrorDetected(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ServerCertificateErrorDetectedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ServerCertificateErrorDetected([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearServerCertificateErrorActions(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler);
  }
}
