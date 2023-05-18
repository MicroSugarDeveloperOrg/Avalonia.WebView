// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs3
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("E61670BC-3DCE-4177-86D2-C629AE3CB6AC")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2PermissionRequestedEventArgs3 : 
    ICoreWebView2PermissionRequestedEventArgs2
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_8();

    [DispId(1610809344)]
    int SavesInProfile { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
