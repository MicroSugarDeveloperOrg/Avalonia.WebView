﻿using Avalonia.WebView.MacCatalyst.Handlers;
using Avalonia.WebView.MacCatalyst.Helpers;
using CoreGraphics;

namespace Avalonia.WebView.MacCatalyst.Core;
public partial class MacCatalystWebViewCore : IPlatformWebView<MacCatalystWebViewCore>
{
    public MacCatalystWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _provider = provider;
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;
        _config = new WKWebViewConfiguration();
        _config.Preferences.SetValueForKey(NSObject.FromObject(_creationProperties.AreDevToolEnabled), new NSString("developerExtrasEnabled"));

        if (provider is not null)
        {
            if (provider.ResourceRequestedFilterProvider(this, out var filter))
            {
                _filter = filter;
                _config.UserContentController.AddScriptMessageHandler(new WebViewScriptMessageHandler(filter.BaseUri, MessageReceived), _filterKeyWord);
                _config.UserContentController.AddUserScript(new WKUserScript(new NSString(BlazorScriptHelper.BlazorStartingScript), WKUserScriptInjectionTime.AtDocumentEnd, true));
                _config.SetUrlSchemeHandler(new SchemeHandler(this, provider, filter), urlScheme: filter.Scheme);
            }

            _isBlazorWebView = true;
        }

        _webView = new WKWebView(CGRect.Empty, _config)
        { 
            AutoresizesSubviews = true
        };

        NativeHandler = _webView.Handle;
        RegisterEvents();
    }

    ~MacCatalystWebViewCore()
    {
        Dispose(disposing: false);
    }

    WKWebView _webView;
    readonly WebScheme? _filter;
    readonly WKWebViewConfiguration _config;
    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;
    readonly string _filterKeyWord = "webview";
    readonly string _dispatchMessageCallback = "__dispatchMessageCallback";

    bool _isBlazorWebView = false;

    bool _isInitialized = false;
    public bool IsInitialized
    {
        get => Volatile.Read(ref _isInitialized);
        private set => Volatile.Write(ref _isInitialized, value);
    }

    bool _isdisposed = false;
    public bool IsDisposed
    {
        get => Volatile.Read(ref _isdisposed);
        private set => Volatile.Write(ref _isdisposed, value);
    }


    public WKWebView WebView
    {
        get => _webView;
        private set => _webView = value;
    }
}
