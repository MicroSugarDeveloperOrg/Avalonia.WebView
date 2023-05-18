// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_17
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("702E75D4-FD44-434D-9D70-1A68A6B1192A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2_17 : ICoreWebView2_16
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_113();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PostSharedBufferToScript(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SharedBuffer sharedBuffer,
      [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access,
      [MarshalAs(UnmanagedType.LPWStr), In] string additionalDataAsJson);
  }
}
