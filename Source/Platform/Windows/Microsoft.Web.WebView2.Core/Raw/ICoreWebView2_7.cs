// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_7
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("79C24D83-09A3-45AE-9418-487F32A58740")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2_7 : ICoreWebView2_6
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_77();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintToPdf(
      [MarshalAs(UnmanagedType.LPWStr), In] string ResultFilePath,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintSettings printSettings,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintToPdfCompletedHandler handler);
  }
}
