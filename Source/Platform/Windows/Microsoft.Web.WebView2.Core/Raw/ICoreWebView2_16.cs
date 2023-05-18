// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_16
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("0EB34DC9-9F91-41E1-8639-95CD5943906B")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2_16 : ICoreWebView2_15
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_110();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Print([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintSettings printSettings, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ShowPrintUI([In] COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintToPdfStream(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintSettings printSettings,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintToPdfStreamCompletedHandler handler);
  }
}
