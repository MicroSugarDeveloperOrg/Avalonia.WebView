using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Web.WebView2.Core;
internal class CoreWebView2LaunchingExternalUriSchemeEventHandler : ICoreWebView2LaunchingExternalUriSchemeEventHandler
{
    public delegate void CallbackType(CoreWebView2LaunchingExternalUriSchemeEventArgs args);

    private CallbackType _callback;

    public CoreWebView2LaunchingExternalUriSchemeEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2LaunchingExternalUriSchemeEventArgs args)
    {
        _callback(new CoreWebView2LaunchingExternalUriSchemeEventArgs(args));
    }
}
