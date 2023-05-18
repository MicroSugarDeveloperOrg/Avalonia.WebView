// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings2
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("EE9A0F68-F46C-4E32-AC23-EF8CAC224D2A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Settings2 : ICoreWebView2Settings
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_18();

    [DispId(1610743808)]
    string UserAgent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.LPWStr), In] set; }
  }
}
