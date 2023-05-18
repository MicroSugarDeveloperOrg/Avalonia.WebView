// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile2
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("FA740D4B-5EAE-4344-A8AD-74BE31925397")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2Profile2 : ICoreWebView2Profile
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_7();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearBrowsingData(
      [In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearBrowsingDataInTimeRange(
      [In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds,
      [In] double startTime,
      [In] double endTime,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearBrowsingDataAll(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
  }
}
