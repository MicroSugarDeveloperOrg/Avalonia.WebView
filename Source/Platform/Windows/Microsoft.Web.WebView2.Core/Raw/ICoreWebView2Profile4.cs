// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile4
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("8F4AE680-192E-4EC8-833A-21CFADAEF628")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Profile4 : ICoreWebView2Profile3
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_12();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetPermissionState(
      [In] COREWEBVIEW2_PERMISSION_KIND PermissionKind,
      [MarshalAs(UnmanagedType.LPWStr), In] string origin,
      [In] COREWEBVIEW2_PERMISSION_STATE State,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SetPermissionStateCompletedHandler completedHandler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetNonDefaultPermissionSettings(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler completedHandler);
  }
}
