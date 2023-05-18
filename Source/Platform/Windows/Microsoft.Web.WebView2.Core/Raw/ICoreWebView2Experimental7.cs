// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental7
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("72A78E99-C92E-4616-8130-D57407EC5341")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Experimental7
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintToPdf(
      [MarshalAs(UnmanagedType.LPWStr), In] string ResultFilePath,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintSettings printSettings,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintToPdfCompletedHandler handler);
  }
}
