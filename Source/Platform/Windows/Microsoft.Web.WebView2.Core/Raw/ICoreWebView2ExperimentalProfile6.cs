// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile6
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("CF9A4B21-5022-4E67-983D-922DDD53D4B6")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2ExperimentalProfile6
  {
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
