// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental14
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("C8F5F3A6-9890-4A1A-AF82-9C86CC99C2D6")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Experimental14
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CallDevToolsProtocolMethodForSession(
      [MarshalAs(UnmanagedType.LPWStr), In] string sessionId,
      [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
      [MarshalAs(UnmanagedType.LPWStr), In] string parametersAsJson,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);
  }
}
