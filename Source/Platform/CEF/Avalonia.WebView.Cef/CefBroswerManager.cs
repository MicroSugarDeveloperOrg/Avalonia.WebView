using CefGlue;
using System.Collections.Concurrent;

namespace Avalonia.WebView;
internal class CefBroswerManager
{
    ConcurrentDictionary<nint, CefBrowserHost> _mapCefBroswerHosts = new();
    ConcurrentDictionary<nint, CefBrowser> _mapCefBroswers = new();

    public bool AddHost(CefBrowser browser, CefBrowserHost host)
    {
        if (browser is null || host is null)
            return false;

        var handle = host.GetWindowHandle();
        _mapCefBroswers.TryAdd(handle, browser);
        _mapCefBroswerHosts.TryAdd(handle, host);
        return true;
    }

    public bool RemoveHost(CefBrowser browser, CefBrowserHost host) 
    {
        if (browser is null || host is null)
            return false;

        var handle = host.GetWindowHandle();
        _mapCefBroswers.TryRemove(handle, out _);
        _mapCefBroswerHosts.TryRemove(handle, out _);
        return true;
    }

    public bool StopHosts()
    {
        foreach (var item in _mapCefBroswers)
        {
            item.Value.Dispose();   
        }

        foreach (var item in _mapCefBroswerHosts)
        {
            item.Value.CloseBrowser();
            item.Value.Dispose();
        }

        _mapCefBroswers.Clear();
        _mapCefBroswerHosts.Clear();
        return true;
    }
}
