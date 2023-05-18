// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [Guid("76ECEACB-0462-4D94-AC83-423A6793775E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2
  {
    [DispId(1610678272)]
    ICoreWebView2Settings Settings { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610678273)]
    string Source { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Navigate([MarshalAs(UnmanagedType.LPWStr), In] string uri);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NavigateToString([MarshalAs(UnmanagedType.LPWStr), In] string htmlContent);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigationStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ContentLoading(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContentLoadingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ContentLoading([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_SourceChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SourceChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_SourceChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_HistoryChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2HistoryChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_HistoryChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigationCompleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FrameNavigationStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FrameNavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FrameNavigationCompleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FrameNavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ScriptDialogOpening(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ScriptDialogOpening([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PermissionRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PermissionRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PermissionRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ProcessFailed(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProcessFailedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ProcessFailed([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddScriptToExecuteOnDocumentCreated(
      [MarshalAs(UnmanagedType.LPWStr), In] string javaScript,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveScriptToExecuteOnDocumentCreated([MarshalAs(UnmanagedType.LPWStr), In] string id);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ExecuteScript([MarshalAs(UnmanagedType.LPWStr), In] string javaScript, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExecuteScriptCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CapturePreview(
      [In] COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat,
      [MarshalAs(UnmanagedType.Interface), In] IStream imageStream,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CapturePreviewCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Reload();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PostWebMessageAsJson([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PostWebMessageAsString([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebMessageReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebMessageReceivedEventHandler handler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebMessageReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CallDevToolsProtocolMethod(
      [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
      [MarshalAs(UnmanagedType.LPWStr), In] string parametersAsJson,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

    [DispId(1610678306)]
    uint BrowserProcessId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678307)]
    int CanGoBack { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678308)]
    int CanGoForward { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GoBack();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GoForward();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver([MarshalAs(UnmanagedType.LPWStr), In] string eventName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Stop();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewWindowRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewWindowRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewWindowRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DocumentTitleChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DocumentTitleChanged([In] EventRegistrationToken token);

    [DispId(1610678317)]
    string DocumentTitle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddHostObjectToScript([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.Struct), In] ref object @object);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveHostObjectFromScript([MarshalAs(UnmanagedType.LPWStr), In] string name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OpenDevToolsWindow();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ContainsFullScreenElementChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token);

    [DispId(1610678323)]
    int ContainsFullScreenElement { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebResourceRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebResourceRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebResourceRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddWebResourceRequestedFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveWebResourceRequestedFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowCloseRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowCloseRequested([In] EventRegistrationToken token);
  }
}
