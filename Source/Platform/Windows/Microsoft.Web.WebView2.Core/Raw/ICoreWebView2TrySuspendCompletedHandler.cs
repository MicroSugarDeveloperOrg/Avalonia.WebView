// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2TrySuspendCompletedHandler
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("00F206A7-9D17-4605-91F6-4E8E4DE192E3")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2TrySuspendCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [In] int isSuccessful);
  }
}
