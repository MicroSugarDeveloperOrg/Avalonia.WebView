#region Assembly Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// C:\Users\ChisterWu\.nuget\packages\microsoft.web.webview2\1.0.1829-prerelease\lib\netcoreapp3.0\Microsoft.Web.WebView2.Core.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
    //
    // Summary:
    //     CoreWebView2Frame provides direct access to the iframes information and handling.
    public class CoreWebView2Frame
    {
        internal ICoreWebView2Frame _nativeICoreWebView2FrameValue;

        internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2Value;

        internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3Value;

        internal ICoreWebView2Frame4 _nativeICoreWebView2Frame4Value;

        internal ICoreWebView2ExperimentalFrame4 _nativeICoreWebView2ExperimentalFrame4Value;

        internal ICoreWebView2ExperimentalFrame3 _nativeICoreWebView2ExperimentalFrame3Value;

        internal ICoreWebView2ExperimentalFrame2 _nativeICoreWebView2ExperimentalFrame2Value;

        internal ICoreWebView2ExperimentalFrame _nativeICoreWebView2ExperimentalFrameValue;

        internal object _rawNative;

        private EventRegistrationToken _nameChangedToken;

        private EventHandler<object> nameChanged;

        private EventRegistrationToken _destroyedToken;

        private EventHandler<object> destroyed;

        private EventRegistrationToken _navigationStartingToken;

        private EventHandler<CoreWebView2NavigationStartingEventArgs> navigationStarting;

        private EventRegistrationToken _contentLoadingToken;

        private EventHandler<CoreWebView2ContentLoadingEventArgs> contentLoading;

        private EventRegistrationToken _navigationCompletedToken;

        private EventHandler<CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

        private EventRegistrationToken _dOMContentLoadedToken;

        private EventHandler<CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

        private EventRegistrationToken _webMessageReceivedToken;

        private EventHandler<CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

        private EventRegistrationToken _permissionRequestedToken;

        private EventHandler<CoreWebView2PermissionRequestedEventArgs> permissionRequested;

        internal ICoreWebView2Frame _nativeICoreWebView2Frame
        {
            get
            {
                if (_nativeICoreWebView2FrameValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2FrameValue = (ICoreWebView2Frame)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2FrameValue;
            }
            set
            {
                _nativeICoreWebView2FrameValue = value;
            }
        }

        internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2
        {
            get
            {
                if (_nativeICoreWebView2Frame2Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Frame2Value = (ICoreWebView2Frame2)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Frame2Value;
            }
            set
            {
                _nativeICoreWebView2Frame2Value = value;
            }
        }

        internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3
        {
            get
            {
                if (_nativeICoreWebView2Frame3Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Frame3Value = (ICoreWebView2Frame3)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Frame3Value;
            }
            set
            {
                _nativeICoreWebView2Frame3Value = value;
            }
        }

        internal ICoreWebView2Frame4 _nativeICoreWebView2Frame4
        {
            get
            {
                if (_nativeICoreWebView2Frame4Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Frame4Value = (ICoreWebView2Frame4)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Frame4Value;
            }
            set
            {
                _nativeICoreWebView2Frame4Value = value;
            }
        }

        internal ICoreWebView2ExperimentalFrame4 _nativeICoreWebView2ExperimentalFrame4
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalFrame4Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalFrame4Value = (ICoreWebView2ExperimentalFrame4)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalFrame4Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalFrame4Value = value;
            }
        }

        internal ICoreWebView2ExperimentalFrame3 _nativeICoreWebView2ExperimentalFrame3
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalFrame3Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalFrame3Value = (ICoreWebView2ExperimentalFrame3)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalFrame3Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalFrame3Value = value;
            }
        }

        internal ICoreWebView2ExperimentalFrame2 _nativeICoreWebView2ExperimentalFrame2
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalFrame2Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalFrame2Value = (ICoreWebView2ExperimentalFrame2)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalFrame2Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalFrame2Value = value;
            }
        }

        internal ICoreWebView2ExperimentalFrame _nativeICoreWebView2ExperimentalFrame
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalFrameValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalFrameValue = (ICoreWebView2ExperimentalFrame)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalFrameValue;
            }
            set
            {
                _nativeICoreWebView2ExperimentalFrameValue = value;
            }
        }

        //
        // Summary:
        //     The name of the iframe from the iframe html tag declaring it.
        public string Name
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Frame.Name;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    }

                    throw ex;
                }
                catch (COMException ex2)
                {
                    if (ex2.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                    }

                    throw ex2;
                }
            }
        }

        //
        // Summary:
        //     NameChanged is raised when the iframe changes its window.name property.
        public event EventHandler<object> NameChanged
        {
            add
            {
                if (nameChanged == null)
                {
                    try
                    {
                        _nativeICoreWebView2Frame.add_NameChanged(new CoreWebView2FrameNameChangedEventHandler(OnNameChanged), out _nameChangedToken);
                    }
                    catch (InvalidCastException ex)
                    {
                        if (ex.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                        }

                        throw ex;
                    }
                    catch (COMException ex2)
                    {
                        if (ex2.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                        }

                        throw ex2;
                    }
                }

                nameChanged = (EventHandler<object>)Delegate.Combine(nameChanged, value);
            }
            remove
            {
                nameChanged = (EventHandler<object>)Delegate.Remove(nameChanged, value);
                if (nameChanged != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Frame.remove_NameChanged(_nameChangedToken);
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    }

                    throw ex;
                }
                catch (COMException ex2)
                {
                    if (ex2.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                    }

                    throw ex2;
                }
            }
        }

        //
        // Summary:
        //     Destroyed event is raised when the iframe corresponding to this Microsoft.Web.WebView2.Core.CoreWebView2Frame
        //     object is removed or the document containing that iframe is destroyed.
        public event EventHandler<object> Destroyed
        {
            add
            {
                if (destroyed == null)
                {
                    try
                    {
                        _nativeICoreWebView2Frame.add_Destroyed(new CoreWebView2FrameDestroyedEventHandler(OnDestroyed), out _destroyedToken);
                    }
                    catch (InvalidCastException ex)
                    {
                        if (ex.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                        }

                        throw ex;
                    }
                    catch (COMException ex2)
                    {
                        if (ex2.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                        }

                        throw ex2;
                    }
                }

                destroyed = (EventHandler<object>)Delegate.Combine(destroyed, value);
            }
            remove
            {
                destroyed = (EventHandler<object>)Delegate.Remove(destroyed, value);
                if (destroyed != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Frame.remove_Destroyed(_destroyedToken);
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    }

                    throw ex;
                }
                catch (COMException ex2)
                {
                    if (ex2.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                    }

                    throw ex2;
                }
            }
        }

        //
        // Summary:
        //     NavigationStarting is raised when the current frame is requesting permission
        //     to navigate to a different URI.
        //
        // Remarks:
        //     A frame navigation will raise a Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting
        //     event and a Microsoft.Web.WebView2.Core.CoreWebView2.FrameNavigationStarting
        //     event. All of the Microsoft.Web.WebView2.Core.CoreWebView2.FrameNavigationStarting
        //     event handlers will be run before the Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting
        //     event handlers. All of the event handlers share a common Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs
        //     object. Whichever event handler is last to change the Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel
        //     property will decide if the frame navigation will be cancelled. Redirects raise
        //     this event as well, and the navigation id is the same as the original one. You
        //     may block corresponding navigations until the event handler returns.
        public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting
        {
            add
            {
                if (navigationStarting == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Frame2.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler(OnNavigationStarting), out _navigationStartingToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalFrame.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler(OnNavigationStarting), out _navigationStartingToken);
                        }
                    }
                    catch (InvalidCastException ex2)
                    {
                        if (ex2.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                        }

                        throw ex2;
                    }
                    catch (COMException ex3)
                    {
                        if (ex3.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                        }

                        throw ex3;
                    }
                }

                navigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(navigationStarting, value);
            }
            remove
            {
                navigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(navigationStarting, value);
                if (navigationStarting != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Frame2.remove_NavigationStarting(_navigationStartingToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalFrame.remove_NavigationStarting(_navigationStartingToken);
                    }
                }
                catch (InvalidCastException ex2)
                {
                    if (ex2.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                    }

                    throw ex2;
                }
                catch (COMException ex3)
                {
                    if (ex3.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                    }

                    throw ex3;
                }
            }
        }

        //
        // Summary:
        //     ContentLoading is raised before any content is loaded, including scripts added
        //     with Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String).
        //     ContentLoading is not raised if a same page navigation occurs.
        //
        // Remarks:
        //     This operation follows the Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationStarting
        //     event and precedes the Microsoft.Web.WebView2.Core.CoreWebView2Frame.DOMContentLoaded
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Frame.NavigationCompleted events.
        public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
        {
            add
            {
                if (contentLoading == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Frame2.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler(OnContentLoading), out _contentLoadingToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalFrame.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler(OnContentLoading), out _contentLoadingToken);
                        }
                    }
                    catch (InvalidCastException ex2)
                    {
                        if (ex2.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                        }

                        throw ex2;
                    }
                    catch (COMException ex3)
                    {
                        if (ex3.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                        }

                        throw ex3;
                    }
                }

                contentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Combine(contentLoading, value);
            }
            remove
            {
                contentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Remove(contentLoading, value);
                if (contentLoading != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Frame2.remove_ContentLoading(_contentLoadingToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalFrame.remove_ContentLoading(_contentLoadingToken);
                    }
                }
                catch (InvalidCastException ex2)
                {
                    if (ex2.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                    }

                    throw ex2;
                }
                catch (COMException ex3)
                {
                    if (ex3.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                    }

                    throw ex3;
                }
            }
        }

        //
        // Summary:
        //     NavigationCompleted is raised when the current frame has completely loaded (body.onload
        //     has been raised) or loading stopped with error.
        public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
        {
            add
            {
                if (navigationCompleted == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Frame2.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler(OnNavigationCompleted), out _navigationCompletedToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalFrame.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler(OnNavigationCompleted), out _navigationCompletedToken);
                        }
                    }
                    catch (InvalidCastException ex2)
                    {
                        if (ex2.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                        }

                        throw ex2;
                    }
                    catch (COMException ex3)
                    {
                        if (ex3.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                        }

                        throw ex3;
                    }
                }

                navigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(navigationCompleted, value);
            }
            remove
            {
                navigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(navigationCompleted, value);
                if (navigationCompleted != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Frame2.remove_NavigationCompleted(_navigationCompletedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalFrame.remove_NavigationCompleted(_navigationCompletedToken);
                    }
                }
                catch (InvalidCastException ex2)
                {
                    if (ex2.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                    }

                    throw ex2;
                }
                catch (COMException ex3)
                {
                    if (ex3.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                    }

                    throw ex3;
                }
            }
        }

        //
        // Summary:
        //     DOMContentLoaded is raised when the initial HTML document has been parsed.
        //
        // Remarks:
        //     This aligns with the the document's DOMContentLoaded event in HTML.
        public event EventHandler<CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
        {
            add
            {
                if (dOMContentLoaded == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Frame2.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler(OnDOMContentLoaded), out _dOMContentLoadedToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalFrame.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler(OnDOMContentLoaded), out _dOMContentLoadedToken);
                        }
                    }
                    catch (InvalidCastException ex2)
                    {
                        if (ex2.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                        }

                        throw ex2;
                    }
                    catch (COMException ex3)
                    {
                        if (ex3.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                        }

                        throw ex3;
                    }
                }

                dOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Combine(dOMContentLoaded, value);
            }
            remove
            {
                dOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Remove(dOMContentLoaded, value);
                if (dOMContentLoaded != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Frame2.remove_DOMContentLoaded(_dOMContentLoadedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalFrame.remove_DOMContentLoaded(_dOMContentLoadedToken);
                    }
                }
                catch (InvalidCastException ex2)
                {
                    if (ex2.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                    }

                    throw ex2;
                }
                catch (COMException ex3)
                {
                    if (ex3.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                    }

                    throw ex3;
                }
            }
        }

        //
        // Summary:
        //     WebMessageReceived is raised when the Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled
        //     setting is set and the iframe runs window.chrome.webview.postMessage.
        //
        // Remarks:
        //     The postMessage function is void postMessage(object) where object is any object
        //     supported by JSON conversion. When postMessage is called, the handler's Invoke
        //     method will be called with the object parameter postMessage converted to a JSON
        //     string.
        public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
        {
            add
            {
                if (webMessageReceived == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Frame2.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler(OnWebMessageReceived), out _webMessageReceivedToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalFrame2.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler(OnWebMessageReceived), out _webMessageReceivedToken);
                        }
                    }
                    catch (InvalidCastException ex2)
                    {
                        if (ex2.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                        }

                        throw ex2;
                    }
                    catch (COMException ex3)
                    {
                        if (ex3.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                        }

                        throw ex3;
                    }
                }

                webMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Combine(webMessageReceived, value);
            }
            remove
            {
                webMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Remove(webMessageReceived, value);
                if (webMessageReceived != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Frame2.remove_WebMessageReceived(_webMessageReceivedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalFrame2.remove_WebMessageReceived(_webMessageReceivedToken);
                    }
                }
                catch (InvalidCastException ex2)
                {
                    if (ex2.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                    }

                    throw ex2;
                }
                catch (COMException ex3)
                {
                    if (ex3.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                    }

                    throw ex3;
                }
            }
        }

        //
        // Summary:
        //     PermissionRequested is raised when content in an iframe or any of its descendant
        //     iframes requests permission to access some privileged resources.
        //
        // Remarks:
        //     This relates to the PermissionRequested event on the CoreWebView2. Both these
        //     events will be raised in the case of an iframe requesting permission. The CoreWebView2Frame's
        //     event handlers will be invoked before the event handlers on the CoreWebView2.
        //     If the Handled property of the PermissionRequestedEventArgs is set to TRUE within
        //     the CoreWebView2Frame event handler, then the event will not be raised on the
        //     CoreWebView2, and it's event handlers will not be invoked. In the case of nested
        //     iframes, the PermissionRequested event will be raised from the top level iframe.
        //     If a deferral is not taken on the event args, the subsequent scripts are blocked
        //     until the event handler returns. If a deferral is taken, the scripts are blocked
        //     until the deferral is completed.
        public event EventHandler<CoreWebView2PermissionRequestedEventArgs> PermissionRequested
        {
            add
            {
                if (permissionRequested == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Frame3.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler(OnPermissionRequested), out _permissionRequestedToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalFrame3.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler(OnPermissionRequested), out _permissionRequestedToken);
                        }
                    }
                    catch (InvalidCastException ex2)
                    {
                        if (ex2.HResult == -2147467262)
                        {
                            throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                        }

                        throw ex2;
                    }
                    catch (COMException ex3)
                    {
                        if (ex3.HResult == -2147019873)
                        {
                            throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                        }

                        throw ex3;
                    }
                }

                permissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Combine(permissionRequested, value);
            }
            remove
            {
                permissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Remove(permissionRequested, value);
                if (permissionRequested != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Frame3.remove_PermissionRequested(_permissionRequestedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalFrame3.remove_PermissionRequested(_permissionRequestedToken);
                    }
                }
                catch (InvalidCastException ex2)
                {
                    if (ex2.HResult == -2147467262)
                    {
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                    }

                    throw ex2;
                }
                catch (COMException ex3)
                {
                    if (ex3.HResult == -2147019873)
                    {
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                    }

                    throw ex3;
                }
            }
        }

        //
        // Summary:
        //     Adds the provided host object to script running in the WebViewFrame with the
        //     specified name for the list of the specified origins. The host object will be
        //     accessible for this iframe only if the iframe's origin during access matches
        //     one of the origins which are passed. The provided origins will be normalized
        //     before comparing to the origin of the document. So the scheme name is made lower
        //     case, the host will be punycode decoded as appropriate, default port values will
        //     be removed, and so on. This means the origin's host may be punycode encoded or
        //     not and will match regardless. If list contains malformed origin the call will
        //     fail. The method can be called multiple times in a row without calling RemoveHostObjectFromScript
        //     for the same object name. It will replace the previous object with the new object
        //     and new list of origins. List of origins will be treated as following: 1. empty
        //     list - call will succeed and object will be added for the iframe but it will
        //     not be exposed to any origin; 2. list with origins - during access to host object
        //     from iframe the origin will be checked that it belongs to this list; 3. list
        //     with "*" element - host object will be available for iframe for all origins.
        //     We suggest not to use this feature without understanding security implications
        //     of giving access to host object from from iframes with unknown origins. 4. list
        //     with "file://" element - host object will be available for iframes loaded via
        //     file protocol.
        //
        // Parameters:
        //   name:
        //     The name of the host object.
        //
        //   rawObject:
        //     The host object to be added to script.
        //
        //   origins:
        //     The list of the iframe origins for which host object will be accessible.
        public void AddHostObjectToScript(string name, object rawObject, IEnumerable<string> origins)
        {
            ICoreWebView2Frame nativeICoreWebView2Frame = _nativeICoreWebView2Frame;
            object @object = rawObject;
            nativeICoreWebView2Frame.AddHostObjectToScriptWithOrigins(name, ref @object, (uint)origins.Count(), origins.Select((string origin) => origin).ToArray());
        }

        internal CoreWebView2Frame(object rawCoreWebView2Frame)
        {
            _rawNative = rawCoreWebView2Frame;
        }

        internal void OnNameChanged(object args)
        {
            nameChanged?.Invoke(this, args);
        }

        internal void OnDestroyed(object args)
        {
            destroyed?.Invoke(this, args);
        }

        //
        // Summary:
        //     Remove the host object specified by the name so that it is no longer accessible
        //     from JavaScript code in the iframe.
        //
        // Remarks:
        //     While new access attempts are denied, if the object is already obtained by JavaScript
        //     code in the iframe, the JavaScript code continues to have access to that object.
        //     Calling this method for a name that is already removed or was never added fails.
        //     If the iframe is destroyed this method will return fail also.
        public void RemoveHostObjectFromScript(string name)
        {
            try
            {
                _nativeICoreWebView2Frame.RemoveHostObjectFromScript(name);
            }
            catch (InvalidCastException ex)
            {
                if (ex.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                }

                throw ex;
            }
            catch (COMException ex2)
            {
                if (ex2.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                }

                throw ex2;
            }
        }

        //
        // Summary:
        //     Check whether a frame is destroyed. Returns true during the Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed
        //     event.
        public int IsDestroyed()
        {
            try
            {
                return _nativeICoreWebView2Frame.IsDestroyed();
            }
            catch (InvalidCastException ex)
            {
                if (ex.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                }

                throw ex;
            }
            catch (COMException ex2)
            {
                if (ex2.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
                }

                throw ex2;
            }
        }

        internal void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
        {
            navigationStarting?.Invoke(this, args);
        }

        internal void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
        {
            contentLoading?.Invoke(this, args);
        }

        internal void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
        {
            navigationCompleted?.Invoke(this, args);
        }

        internal void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
        {
            dOMContentLoaded?.Invoke(this, args);
        }

        internal void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
        {
            webMessageReceived?.Invoke(this, args);
        }

        //
        // Summary:
        //     Runs JavaScript code from the javaScript parameter in the current frame.
        //
        // Parameters:
        //   javaScript:
        //     The JavaScript code to be run in the current frame.
        //
        // Returns:
        //     A JSON encoded string that represents the result of running the provided JavaScript.
        //
        // Remarks:
        //     A function that has no explicit return value returns undefined. If the script
        //     that was run throws an unhandled exception, then the result is also null. This
        //     method is applied asynchronously. If the method is run before Microsoft.Web.WebView2.Core.CoreWebView2Frame.ContentLoading,
        //     the script will not be executed and the JSON null will be returned. This operation
        //     works even if Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsScriptEnabled
        //     is set to false.
        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            CoreWebView2ExecuteScriptCompletedHandler handler;
            try
            {
                try
                {
                    handler = new CoreWebView2ExecuteScriptCompletedHandler();
                    _nativeICoreWebView2Frame2.ExecuteScript(javaScript, handler);
                }
                catch (NotImplementedException)
                {
                    handler = new CoreWebView2ExecuteScriptCompletedHandler();
                    _nativeICoreWebView2ExperimentalFrame.ExecuteScript(javaScript, handler);
                }
            }
            catch (InvalidCastException ex2)
            {
                if (ex2.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                }

                throw ex2;
            }
            catch (COMException ex3)
            {
                if (ex3.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                }

                throw ex3;
            }

            await handler;
            Marshal.ThrowExceptionForHR(handler.errCode);
            return handler.resultObjectAsJson;
        }

        //
        // Summary:
        //     Posts the specified webMessageAsJson to the current frame.
        //
        // Parameters:
        //   webMessageAsJson:
        //     The web message to be posted to the iframe.
        //
        // Remarks:
        //     The event args is an instance of MessageEvent. The Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled
        //     setting must be true or the message will not be sent. The event arg's data property
        //     of the event arg is the webMessageAsJson string parameter parsed as a JSON string
        //     into a JavaScript object. The event arg's source property of the event arg is
        //     a reference to the window.chrome.webview object. For information about sending
        //     messages from the iframe to the host, navigate to Microsoft.Web.WebView2.Core.CoreWebView2Frame.WebMessageReceived.
        //     The message is sent asynchronously. If a navigation occurs before the message
        //     is posted to the iframe, the message is not be sent.
        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Frame2.PostWebMessageAsJson(webMessageAsJson);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalFrame2.PostWebMessageAsJson(webMessageAsJson);
                }
            }
            catch (InvalidCastException ex2)
            {
                if (ex2.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                }

                throw ex2;
            }
            catch (COMException ex3)
            {
                if (ex3.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                }

                throw ex3;
            }
        }

        //
        // Summary:
        //     Posts a message that is a simple string rather than a JSON string representation
        //     of a JavaScript object.
        //
        // Parameters:
        //   webMessageAsString:
        //     The web message to be posted to the iframe.
        //
        // Remarks:
        //     This behaves in exactly the same manner as Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostWebMessageAsJson(System.String),
        //     but the data property of the event arg of the window.chrome.webview message is
        //     a string with the same value as webMessageAsString. Use this instead of Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostWebMessageAsJson(System.String)
        //     if you want to communicate using simple strings rather than JSON objects.
        public void PostWebMessageAsString(string webMessageAsString)
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Frame2.PostWebMessageAsString(webMessageAsString);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalFrame2.PostWebMessageAsString(webMessageAsString);
                }
            }
            catch (InvalidCastException ex2)
            {
                if (ex2.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                }

                throw ex2;
            }
            catch (COMException ex3)
            {
                if (ex3.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                }

                throw ex3;
            }
        }

        internal void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
        {
            permissionRequested?.Invoke(this, args);
        }

        //
        // Summary:
        //     Share a shared buffer object with script of the iframe in the WebView.
        //
        // Parameters:
        //   sharedBuffer:
        //     The Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer object to be shared
        //     with script.
        //
        //   access:
        //     The desired Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess given
        //     to script.
        //
        //   additionalDataAsJson:
        //     Additional data to be send to script. If it is not null or empty string, and
        //     it is not a valid JSON string, System.ArgumentException will be thrown.
        //
        // Remarks:
        //     The script will receive a sharedbufferreceived event from chrome.webview. The
        //     event arg for that event will have the following methods and properties.
        //     Property Description
        //     getBuffer() A method that returns an ArrayBuffer object with the backing content
        //     from the shared buffer.
        //     additionalData An object as the result of parsing additionalDataAsJson as JSON
        //     string. This property will be undefined if additionalDataAsJson is nullptr or
        //     empty string.
        //     source With a value set as chrome.webview object.
        //     If access is Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess.ReadOnly,
        //     the script will only have read access to the buffer. If the script tries to modify
        //     the content in a read only buffer, it will cause an access violation in WebView
        //     renderer process and crash the renderer process. If the shared buffer is already
        //     closed, the API throws System.Runtime.InteropServices.COMException with error
        //     code of RO_E_CLOSED. The script code should call chrome.webview.releaseBuffer
        //     with the shared buffer as the parameter to release underlying resources as soon
        //     as it does not need access to the shared buffer any more. The application can
        //     post the same shared buffer object to multiple web pages or iframes, or post
        //     to the same web page or iframe multiple times. Each PostSharedBufferToScript
        //     will create a separate ArrayBuffer object with its own view of the memory and
        //     is separately released. The underlying shared memory will be released when all
        //     the views are released. Sharing a buffer to script has security risk. You should
        //     only share buffer with trusted site. If a buffer is shared to a untrusted site,
        //     possible sensitive information could be leaked. If a buffer is shared as modifiable
        //     by the script and the script modifies it in an unexpected way, it could result
        //     in corrupted data that might even crash the application. The example code shows
        //     how to send data to script for one time read only consumption.
        public void PostSharedBufferToScript(CoreWebView2SharedBuffer sharedBuffer, CoreWebView2SharedBufferAccess access, string additionalDataAsJson)
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Frame4.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalFrame4.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
                }
            }
            catch (InvalidCastException ex2)
            {
                if (ex2.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                }

                throw ex2;
            }
            catch (COMException ex3)
            {
                if (ex3.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                }

                throw ex3;
            }
        }
    }
}
#if false // Decompilation log
'201' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\mscorlib.dll'
------------------
Resolve: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Drawing.dll'
------------------
Resolve: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.dll'
------------------
Resolve: 'System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Numerics.dll'
------------------
Resolve: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Core.dll'
------------------
Resolve: 'Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.CSharp, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '4.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\Microsoft.CSharp.dll'
------------------
Resolve: 'Microsoft.Win32.Registry, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.Win32.Registry, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\Microsoft.Win32.Registry.dll'
------------------
Resolve: 'System.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Runtime.dll'
------------------
Resolve: 'System.Security.Principal.Windows, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Principal.Windows, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Security.Principal.Windows.dll'
------------------
Resolve: 'System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Security.Permissions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.Security.Permissions.dll'
------------------
Resolve: 'System.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Collections.dll'
------------------
Resolve: 'System.Collections.NonGeneric, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.NonGeneric, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Collections.NonGeneric.dll'
------------------
Resolve: 'System.Collections.Concurrent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Concurrent, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Collections.Concurrent.dll'
------------------
Resolve: 'System.ObjectModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Console, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Console, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Console.dll'
------------------
Resolve: 'System.Runtime.InteropServices, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.InteropServices, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Runtime.InteropServices.dll'
------------------
Resolve: 'System.Diagnostics.Contracts, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Contracts, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.Contracts.dll'
------------------
Resolve: 'System.Diagnostics.StackTrace, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.StackTrace, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.StackTrace.dll'
------------------
Resolve: 'System.Diagnostics.Tracing, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Tracing, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.Tracing.dll'
------------------
Resolve: 'System.IO.FileSystem.DriveInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.DriveInfo, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.FileSystem.DriveInfo.dll'
------------------
Resolve: 'System.IO.IsolatedStorage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.IsolatedStorage, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.IsolatedStorage.dll'
------------------
Resolve: 'System.ComponentModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ComponentModel.dll'
------------------
Resolve: 'System.Threading.Thread, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Thread, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Threading.Thread.dll'
------------------
Resolve: 'System.Reflection.Emit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Reflection.Emit.dll'
------------------
Resolve: 'System.Reflection.Emit.ILGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit.ILGeneration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Reflection.Emit.ILGeneration.dll'
------------------
Resolve: 'System.Reflection.Emit.Lightweight, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit.Lightweight, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Reflection.Emit.Lightweight.dll'
------------------
Resolve: 'System.Reflection.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Reflection.Primitives.dll'
------------------
Resolve: 'System.Resources.Writer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Resources.Writer, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Resources.Writer.dll'
------------------
Resolve: 'System.Runtime.CompilerServices.VisualC, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.CompilerServices.VisualC, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Runtime.CompilerServices.VisualC.dll'
------------------
Resolve: 'System.Runtime.Serialization.Formatters, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.Serialization.Formatters, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Runtime.Serialization.Formatters.dll'
------------------
Resolve: 'System.Security.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.AccessControl, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Security.AccessControl.dll'
------------------
Resolve: 'System.IO.FileSystem.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.AccessControl, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.FileSystem.AccessControl.dll'
------------------
Resolve: 'System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.AccessControl, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.Threading.AccessControl.dll'
------------------
Resolve: 'System.Security.Claims, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Claims, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Security.Claims.dll'
------------------
Resolve: 'System.Security.Cryptography, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Cryptography, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Security.Cryptography.dll'
------------------
Resolve: 'System.Text.Encoding.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.Encoding.Extensions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Text.Encoding.Extensions.dll'
------------------
Resolve: 'System.Threading, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Threading.dll'
------------------
Resolve: 'System.Threading.Overlapped, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Overlapped, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Threading.Overlapped.dll'
------------------
Resolve: 'System.Threading.ThreadPool, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.ThreadPool, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Threading.ThreadPool.dll'
------------------
Resolve: 'System.Threading.Tasks.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Tasks.Parallel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Threading.Tasks.Parallel.dll'
------------------
Resolve: 'System.Drawing.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.Drawing.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Drawing.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Drawing.Primitives.dll'
------------------
Resolve: 'System.ComponentModel.TypeConverter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.TypeConverter, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ComponentModel.TypeConverter.dll'
------------------
Resolve: 'System.Configuration.ConfigurationManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Configuration.ConfigurationManager, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.Configuration.ConfigurationManager.dll'
------------------
Resolve: 'System.CodeDom, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.CodeDom.dll'
------------------
Resolve: 'Microsoft.Win32.SystemEvents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'Microsoft.Win32.SystemEvents, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\Microsoft.Win32.SystemEvents.dll'
------------------
Resolve: 'System.Diagnostics.Process, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Process, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.Process.dll'
------------------
Resolve: 'System.Collections.Specialized, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Specialized, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Collections.Specialized.dll'
------------------
Resolve: 'System.ComponentModel.EventBasedAsync, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.EventBasedAsync, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ComponentModel.EventBasedAsync.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'Microsoft.Win32.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.Win32.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\Microsoft.Win32.Primitives.dll'
------------------
Resolve: 'System.Diagnostics.TraceSource, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.TraceSource, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.TraceSource.dll'
------------------
Resolve: 'System.Diagnostics.TextWriterTraceListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.TextWriterTraceListener, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.TextWriterTraceListener.dll'
------------------
Resolve: 'System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.PerformanceCounter, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.PerformanceCounter.dll'
------------------
Resolve: 'System.Diagnostics.EventLog, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.EventLog, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.EventLog.dll'
------------------
Resolve: 'System.Diagnostics.FileVersionInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.FileVersionInfo, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Diagnostics.FileVersionInfo.dll'
------------------
Resolve: 'System.IO.Compression, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.IO.Compression, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.Compression.dll'
------------------
Resolve: 'System.IO.FileSystem.Watcher, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.Watcher, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.FileSystem.Watcher.dll'
------------------
Resolve: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Windows.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Windows.Extensions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\7.0.3\ref\net7.0\System.Windows.Extensions.dll'
------------------
Resolve: 'System.Net.Requests, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Requests, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.Requests.dll'
------------------
Resolve: 'System.Net.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.Primitives.dll'
------------------
Resolve: 'System.Net.HttpListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.HttpListener, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.HttpListener.dll'
------------------
Resolve: 'System.Net.ServicePoint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.ServicePoint, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.ServicePoint.dll'
------------------
Resolve: 'System.Net.NameResolution, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NameResolution, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.NameResolution.dll'
------------------
Resolve: 'System.Net.WebClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.WebClient, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.WebClient.dll'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.WebHeaderCollection.dll'
------------------
Resolve: 'System.Net.WebProxy, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.WebProxy, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.WebProxy.dll'
------------------
Resolve: 'System.Net.Mail, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.Mail, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.Mail.dll'
------------------
Resolve: 'System.Net.NetworkInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NetworkInformation, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.NetworkInformation.dll'
------------------
Resolve: 'System.Net.Ping, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Ping, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.Ping.dll'
------------------
Resolve: 'System.Net.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Security, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.Security.dll'
------------------
Resolve: 'System.Net.Sockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Sockets, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.Sockets.dll'
------------------
Resolve: 'System.Net.WebSockets.Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebSockets.Client, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.WebSockets.Client.dll'
------------------
Resolve: 'System.Net.WebSockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebSockets, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.WebSockets.dll'
------------------
Resolve: 'System.Text.RegularExpressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.RegularExpressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Text.RegularExpressions.dll'
------------------
Resolve: 'System.Runtime.Numerics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.Numerics, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Runtime.Numerics.dll'
------------------
Resolve: 'System.Numerics.Vectors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Numerics.Vectors, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Numerics.Vectors.dll'
------------------
Resolve: 'System.IO.MemoryMappedFiles, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.MemoryMappedFiles, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.MemoryMappedFiles.dll'
------------------
Resolve: 'System.IO.Pipes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.Pipes, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.Pipes.dll'
------------------
Resolve: 'System.Linq.Expressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq.Expressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Linq.Expressions.dll'
------------------
Resolve: 'System.IO.Pipes.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.Pipes.AccessControl, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.IO.Pipes.AccessControl.dll'
------------------
Resolve: 'System.Linq, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Linq.dll'
------------------
Resolve: 'System.Linq.Queryable, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq.Queryable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Linq.Queryable.dll'
------------------
Resolve: 'System.Linq.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq.Parallel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '7.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Linq.Parallel.dll'
------------------
Resolve: 'System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Runtime.dll'
------------------
Resolve: 'System.Security.AccessControl, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.AccessControl, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Security.AccessControl.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'System.ObjectModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Drawing.Common, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.Drawing.Common, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.3\ref\net7.0\System.Net.WebHeaderCollection.dll'
#endif
