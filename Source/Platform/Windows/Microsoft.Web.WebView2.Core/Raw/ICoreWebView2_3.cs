// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("A0D6DF20-3B92-416D-AA0C-437A9C727857")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2_3 : ICoreWebView2_2
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    void _VtblGap1_65();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TrySuspend([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2TrySuspendCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Resume();

    [DispId(1610809346)]
    int IsSuspended { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetVirtualHostNameToFolderMapping(
      [MarshalAs(UnmanagedType.LPWStr), In] string hostName,
      [MarshalAs(UnmanagedType.LPWStr), In] string folderPath,
      [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearVirtualHostNameToFolderMapping([MarshalAs(UnmanagedType.LPWStr), In] string hostName);
  }
}
