// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("177CD9E7-B6F5-451A-94A0-5D7A3A4C4141")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2CookieManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie CreateCookie([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.LPWStr), In] string value, [MarshalAs(UnmanagedType.LPWStr), In] string Domain, [MarshalAs(UnmanagedType.LPWStr), In] string Path);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie CopyCookie([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Cookie cookieParam);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetCookies([MarshalAs(UnmanagedType.LPWStr), In] string uri, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2GetCookiesCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddOrUpdateCookie([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Cookie cookie);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteCookie([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Cookie cookie);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteCookies([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.LPWStr), In] string uri);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteCookiesWithDomainAndPath([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.LPWStr), In] string Domain, [MarshalAs(UnmanagedType.LPWStr), In] string Path);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteAllCookies();
  }
}
