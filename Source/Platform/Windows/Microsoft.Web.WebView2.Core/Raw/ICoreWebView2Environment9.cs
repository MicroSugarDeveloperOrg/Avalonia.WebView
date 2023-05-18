// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment9
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("F06F41BF-4B5A-49D8-B9F6-FA16CD29F274")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Environment9 : ICoreWebView2Environment8
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_16();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ContextMenuItem CreateContextMenuItem(
      [MarshalAs(UnmanagedType.LPWStr), In] string Label,
      [MarshalAs(UnmanagedType.Interface), In] IStream iconStream,
      [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind);
  }
}
