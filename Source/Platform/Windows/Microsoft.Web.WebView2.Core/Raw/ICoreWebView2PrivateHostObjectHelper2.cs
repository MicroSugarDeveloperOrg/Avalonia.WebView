// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper2
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("A791A659-3AD9-41C3-9C7E-768FCC233666")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2PrivateHostObjectHelper2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsAsyncMethod([MarshalAs(UnmanagedType.Struct), In] ref object @object, [MarshalAs(UnmanagedType.LPWStr), In] string methodName, [In] int parameterCount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetAsyncMethodContinuation(
      [MarshalAs(UnmanagedType.Struct), In] ref object @object,
      [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
      [In] int parameterCount,
      [MarshalAs(UnmanagedType.Struct), In] ref object methodResult,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation);
  }
}
