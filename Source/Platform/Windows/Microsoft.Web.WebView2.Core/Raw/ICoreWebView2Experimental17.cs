// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental17
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("531FFEE9-6225-43F3-9EA9-5AD3EC887EFD")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Experimental17
  {
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
