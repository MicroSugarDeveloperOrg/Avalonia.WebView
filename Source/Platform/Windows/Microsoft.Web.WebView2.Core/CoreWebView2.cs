#region Assembly Microsoft.Web.WebView2.Core, Version=1.0.2210.55, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// C:\Users\MicroSugar\.nuget\packages\microsoft.web.webview2\1.0.2210.55\lib\netcoreapp3.0\Microsoft.Web.WebView2.Core.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

//
// Summary:
//     WebView2 enables you to host web content using the latest Microsoft Edge browser
//     and web technology.
public class CoreWebView2
{
    internal ICoreWebView2 _nativeICoreWebView2Value;

    internal ICoreWebView2_2 _nativeICoreWebView2_2Value;

    internal ICoreWebView2_3 _nativeICoreWebView2_3Value;

    internal ICoreWebView2_4 _nativeICoreWebView2_4Value;

    internal ICoreWebView2_5 _nativeICoreWebView2_5Value;

    internal ICoreWebView2_6 _nativeICoreWebView2_6Value;

    internal ICoreWebView2_7 _nativeICoreWebView2_7Value;

    internal ICoreWebView2_8 _nativeICoreWebView2_8Value;

    internal ICoreWebView2_9 _nativeICoreWebView2_9Value;

    internal ICoreWebView2_10 _nativeICoreWebView2_10Value;

    internal ICoreWebView2_11 _nativeICoreWebView2_11Value;

    internal ICoreWebView2_12 _nativeICoreWebView2_12Value;

    internal ICoreWebView2_13 _nativeICoreWebView2_13Value;

    internal ICoreWebView2_14 _nativeICoreWebView2_14Value;

    internal ICoreWebView2_15 _nativeICoreWebView2_15Value;

    internal ICoreWebView2_16 _nativeICoreWebView2_16Value;

    internal ICoreWebView2_17 _nativeICoreWebView2_17Value;

    internal ICoreWebView2_18 _nativeICoreWebView2_18Value;

    internal ICoreWebView2_19 _nativeICoreWebView2_19Value;

    internal ICoreWebView2_20 _nativeICoreWebView2_20Value;

    internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartialValue;

    internal object _rawNative;

    private EventRegistrationToken _navigationStartingToken;

    private EventHandler<CoreWebView2NavigationStartingEventArgs> navigationStarting;

    private EventRegistrationToken _contentLoadingToken;

    private EventHandler<CoreWebView2ContentLoadingEventArgs> contentLoading;

    private EventRegistrationToken _sourceChangedToken;

    private EventHandler<CoreWebView2SourceChangedEventArgs> sourceChanged;

    private EventRegistrationToken _historyChangedToken;

    private EventHandler<object> historyChanged;

    private EventRegistrationToken _navigationCompletedToken;

    private EventHandler<CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

    private EventRegistrationToken _frameNavigationStartingToken;

    private EventHandler<CoreWebView2NavigationStartingEventArgs> frameNavigationStarting;

    private EventRegistrationToken _frameNavigationCompletedToken;

    private EventHandler<CoreWebView2NavigationCompletedEventArgs> frameNavigationCompleted;

    private EventRegistrationToken _scriptDialogOpeningToken;

    private EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> scriptDialogOpening;

    private EventRegistrationToken _permissionRequestedToken;

    private EventHandler<CoreWebView2PermissionRequestedEventArgs> permissionRequested;

    private EventRegistrationToken _processFailedToken;

    private EventHandler<CoreWebView2ProcessFailedEventArgs> processFailed;

    private EventRegistrationToken _webMessageReceivedToken;

    private EventHandler<CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

    private EventRegistrationToken _newWindowRequestedToken;

    private EventHandler<CoreWebView2NewWindowRequestedEventArgs> newWindowRequested;

    private EventRegistrationToken _documentTitleChangedToken;

    private EventHandler<object> documentTitleChanged;

    private EventRegistrationToken _containsFullScreenElementChangedToken;

    private EventHandler<object> containsFullScreenElementChanged;

    private EventRegistrationToken _webResourceRequestedToken;

    private EventHandler<CoreWebView2WebResourceRequestedEventArgs> webResourceRequested;

    private EventRegistrationToken _windowCloseRequestedToken;

    private EventHandler<object> windowCloseRequested;

    private EventRegistrationToken _webResourceResponseReceivedToken;

    private EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> webResourceResponseReceived;

    private EventRegistrationToken _dOMContentLoadedToken;

    private EventHandler<CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

    private EventRegistrationToken _frameCreatedToken;

    private EventHandler<CoreWebView2FrameCreatedEventArgs> frameCreated;

    private EventRegistrationToken _downloadStartingToken;

    private EventHandler<CoreWebView2DownloadStartingEventArgs> downloadStarting;

    private EventRegistrationToken _clientCertificateRequestedToken;

    private EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> clientCertificateRequested;

    private EventRegistrationToken _isMutedChangedToken;

    private EventHandler<object> isMutedChanged;

    private EventRegistrationToken _isDocumentPlayingAudioChangedToken;

    private EventHandler<object> isDocumentPlayingAudioChanged;

    private EventRegistrationToken _isDefaultDownloadDialogOpenChangedToken;

    private EventHandler<object> isDefaultDownloadDialogOpenChanged;

    private EventRegistrationToken _basicAuthenticationRequestedToken;

    private EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> basicAuthenticationRequested;

    private EventRegistrationToken _contextMenuRequestedToken;

    private EventHandler<CoreWebView2ContextMenuRequestedEventArgs> contextMenuRequested;

    private EventRegistrationToken _statusBarTextChangedToken;

    private EventHandler<object> statusBarTextChanged;

    private EventRegistrationToken _serverCertificateErrorDetectedToken;

    private EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> serverCertificateErrorDetected;

    private EventRegistrationToken _faviconChangedToken;

    private EventHandler<object> faviconChanged;

    private EventRegistrationToken _launchingExternalUriSchemeToken;

    private EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> launchingExternalUriScheme;

    internal ICoreWebView2 _nativeICoreWebView2
    {
        get
        {
            if (_nativeICoreWebView2Value == null)
            {
                try
                {
                    _nativeICoreWebView2Value = (ICoreWebView2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Value;
        }
        set
        {
            _nativeICoreWebView2Value = value;
        }
    }

    internal ICoreWebView2_2 _nativeICoreWebView2_2
    {
        get
        {
            if (_nativeICoreWebView2_2Value == null)
            {
                try
                {
                    _nativeICoreWebView2_2Value = (ICoreWebView2_2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_2Value;
        }
        set
        {
            _nativeICoreWebView2_2Value = value;
        }
    }

    internal ICoreWebView2_3 _nativeICoreWebView2_3
    {
        get
        {
            if (_nativeICoreWebView2_3Value == null)
            {
                try
                {
                    _nativeICoreWebView2_3Value = (ICoreWebView2_3)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_3Value;
        }
        set
        {
            _nativeICoreWebView2_3Value = value;
        }
    }

    internal ICoreWebView2_4 _nativeICoreWebView2_4
    {
        get
        {
            if (_nativeICoreWebView2_4Value == null)
            {
                try
                {
                    _nativeICoreWebView2_4Value = (ICoreWebView2_4)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_4Value;
        }
        set
        {
            _nativeICoreWebView2_4Value = value;
        }
    }

    internal ICoreWebView2_5 _nativeICoreWebView2_5
    {
        get
        {
            if (_nativeICoreWebView2_5Value == null)
            {
                try
                {
                    _nativeICoreWebView2_5Value = (ICoreWebView2_5)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_5Value;
        }
        set
        {
            _nativeICoreWebView2_5Value = value;
        }
    }

    internal ICoreWebView2_6 _nativeICoreWebView2_6
    {
        get
        {
            if (_nativeICoreWebView2_6Value == null)
            {
                try
                {
                    _nativeICoreWebView2_6Value = (ICoreWebView2_6)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_6Value;
        }
        set
        {
            _nativeICoreWebView2_6Value = value;
        }
    }

    internal ICoreWebView2_7 _nativeICoreWebView2_7
    {
        get
        {
            if (_nativeICoreWebView2_7Value == null)
            {
                try
                {
                    _nativeICoreWebView2_7Value = (ICoreWebView2_7)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_7Value;
        }
        set
        {
            _nativeICoreWebView2_7Value = value;
        }
    }

    internal ICoreWebView2_8 _nativeICoreWebView2_8
    {
        get
        {
            if (_nativeICoreWebView2_8Value == null)
            {
                try
                {
                    _nativeICoreWebView2_8Value = (ICoreWebView2_8)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_8Value;
        }
        set
        {
            _nativeICoreWebView2_8Value = value;
        }
    }

    internal ICoreWebView2_9 _nativeICoreWebView2_9
    {
        get
        {
            if (_nativeICoreWebView2_9Value == null)
            {
                try
                {
                    _nativeICoreWebView2_9Value = (ICoreWebView2_9)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_9Value;
        }
        set
        {
            _nativeICoreWebView2_9Value = value;
        }
    }

    internal ICoreWebView2_10 _nativeICoreWebView2_10
    {
        get
        {
            if (_nativeICoreWebView2_10Value == null)
            {
                try
                {
                    _nativeICoreWebView2_10Value = (ICoreWebView2_10)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_10Value;
        }
        set
        {
            _nativeICoreWebView2_10Value = value;
        }
    }

    internal ICoreWebView2_11 _nativeICoreWebView2_11
    {
        get
        {
            if (_nativeICoreWebView2_11Value == null)
            {
                try
                {
                    _nativeICoreWebView2_11Value = (ICoreWebView2_11)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_11Value;
        }
        set
        {
            _nativeICoreWebView2_11Value = value;
        }
    }

    internal ICoreWebView2_12 _nativeICoreWebView2_12
    {
        get
        {
            if (_nativeICoreWebView2_12Value == null)
            {
                try
                {
                    _nativeICoreWebView2_12Value = (ICoreWebView2_12)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_12Value;
        }
        set
        {
            _nativeICoreWebView2_12Value = value;
        }
    }

    internal ICoreWebView2_13 _nativeICoreWebView2_13
    {
        get
        {
            if (_nativeICoreWebView2_13Value == null)
            {
                try
                {
                    _nativeICoreWebView2_13Value = (ICoreWebView2_13)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_13Value;
        }
        set
        {
            _nativeICoreWebView2_13Value = value;
        }
    }

    internal ICoreWebView2_14 _nativeICoreWebView2_14
    {
        get
        {
            if (_nativeICoreWebView2_14Value == null)
            {
                try
                {
                    _nativeICoreWebView2_14Value = (ICoreWebView2_14)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_14.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_14Value;
        }
        set
        {
            _nativeICoreWebView2_14Value = value;
        }
    }

    internal ICoreWebView2_15 _nativeICoreWebView2_15
    {
        get
        {
            if (_nativeICoreWebView2_15Value == null)
            {
                try
                {
                    _nativeICoreWebView2_15Value = (ICoreWebView2_15)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_15.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_15Value;
        }
        set
        {
            _nativeICoreWebView2_15Value = value;
        }
    }

    internal ICoreWebView2_16 _nativeICoreWebView2_16
    {
        get
        {
            if (_nativeICoreWebView2_16Value == null)
            {
                try
                {
                    _nativeICoreWebView2_16Value = (ICoreWebView2_16)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_16.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_16Value;
        }
        set
        {
            _nativeICoreWebView2_16Value = value;
        }
    }

    internal ICoreWebView2_17 _nativeICoreWebView2_17
    {
        get
        {
            if (_nativeICoreWebView2_17Value == null)
            {
                try
                {
                    _nativeICoreWebView2_17Value = (ICoreWebView2_17)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_17.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_17Value;
        }
        set
        {
            _nativeICoreWebView2_17Value = value;
        }
    }

    internal ICoreWebView2_18 _nativeICoreWebView2_18
    {
        get
        {
            if (_nativeICoreWebView2_18Value == null)
            {
                try
                {
                    _nativeICoreWebView2_18Value = (ICoreWebView2_18)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_18.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_18Value;
        }
        set
        {
            _nativeICoreWebView2_18Value = value;
        }
    }

    internal ICoreWebView2_19 _nativeICoreWebView2_19
    {
        get
        {
            if (_nativeICoreWebView2_19Value == null)
            {
                try
                {
                    _nativeICoreWebView2_19Value = (ICoreWebView2_19)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_19.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_19Value;
        }
        set
        {
            _nativeICoreWebView2_19Value = value;
        }
    }

    internal ICoreWebView2_20 _nativeICoreWebView2_20
    {
        get
        {
            if (_nativeICoreWebView2_20Value == null)
            {
                try
                {
                    _nativeICoreWebView2_20Value = (ICoreWebView2_20)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_20.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2_20Value;
        }
        set
        {
            _nativeICoreWebView2_20Value = value;
        }
    }

    internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartial
    {
        get
        {
            if (_nativeICoreWebView2PrivatePartialValue == null)
            {
                try
                {
                    _nativeICoreWebView2PrivatePartialValue = (ICoreWebView2PrivatePartial)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartial.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2PrivatePartialValue;
        }
        set
        {
            _nativeICoreWebView2PrivatePartialValue = value;
        }
    }

    //
    // Summary:
    //     Gets the Microsoft.Web.WebView2.Core.CoreWebView2Settings object contains various
    //     modifiable settings for the running WebView.
    public CoreWebView2Settings Settings
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2.Settings == null) ? null : new CoreWebView2Settings(_nativeICoreWebView2.Settings);
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
    //     Gets the URI of the current top level document.
    //
    // Remarks:
    //     This value potentially changes as a part of the Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged
    //     event raised for some cases such as navigating to a different site or fragment
    //     navigations. It remains the same for other types of navigations such as page
    //     refreshes or history.pushState with the same URL as the current page.
    public string Source
    {
        get
        {
            try
            {
                return _nativeICoreWebView2.Source;
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
    //     Gets the process ID of the browser process that hosts the WebView.
    public uint BrowserProcessId
    {
        get
        {
            try
            {
                return _nativeICoreWebView2.BrowserProcessId;
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
    //     true if the WebView is able to navigate to a previous page in the navigation
    //     history.
    //
    // Remarks:
    //     If CanGoBack changes value, the Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged
    //     event is raised.
    public bool CanGoBack
    {
        get
        {
            try
            {
                return _nativeICoreWebView2.CanGoBack != 0;
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
    //     true if the WebView is able to navigate to a next page in the navigation history.
    //
    //
    // Remarks:
    //     If CanGoForward changes value, the Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged
    //     event is raised.
    public bool CanGoForward
    {
        get
        {
            try
            {
                return _nativeICoreWebView2.CanGoForward != 0;
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
    //     Gets the title for the current top-level document.
    //
    // Remarks:
    //     If the document has no explicit title or is otherwise empty, a default that may
    //     or may not match the URI of the document is used.
    public string DocumentTitle
    {
        get
        {
            try
            {
                return _nativeICoreWebView2.DocumentTitle;
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
    //     Indicates if the WebView contains a fullscreen HTML element.
    public bool ContainsFullScreenElement
    {
        get
        {
            try
            {
                return _nativeICoreWebView2.ContainsFullScreenElement != 0;
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
    //     Gets the Microsoft.Web.WebView2.Core.CoreWebView2CookieManager object associated
    //     with this Microsoft.Web.WebView2.Core.CoreWebView2.
    public CoreWebView2CookieManager CookieManager
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2_2.CookieManager == null) ? null : new CoreWebView2CookieManager(_nativeICoreWebView2_2.CookieManager);
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
    //     Exposes the Microsoft.Web.WebView2.Core.CoreWebView2Environment used to create
    //     this Microsoft.Web.WebView2.Core.CoreWebView2.
    public CoreWebView2Environment Environment
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2_2.Environment == null) ? null : new CoreWebView2Environment(_nativeICoreWebView2_2.Environment);
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
    //     Whether WebView is suspended.
    //
    // Remarks:
    //     True when WebView is suspended, from the time when Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync
    //     has completed successfully until WebView is resumed.
    public bool IsSuspended
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_3.IsSuspended != 0;
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
    //     Indicates whether all audio output from this CoreWebView2 is muted or not. Set
    //     to true will mute this CoreWebView2, and set to false will unmute this CoreWebView2.
    //     true if audio is muted.
    public bool IsMuted
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_8.IsMuted != 0;
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
        set
        {
            try
            {
                _nativeICoreWebView2_8.IsMuted = (value ? 1 : 0);
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
    //     Indicates whether any audio output from this CoreWebView2 is playing. true if
    //     audio is playing even if Microsoft.Web.WebView2.Core.CoreWebView2.IsMuted is
    //     true.
    public bool IsDocumentPlayingAudio
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_8.IsDocumentPlayingAudio != 0;
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
    //     True if the default download dialog is currently open.
    //
    // Remarks:
    //     The value of this property changes only when the default download dialog is explicitly
    //     opened or closed. Hiding the WebView implicitly hides the dialog, but does not
    //     change the value of this property.
    public bool IsDefaultDownloadDialogOpen
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_9.IsDefaultDownloadDialogOpen != 0;
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
    //     The default download dialog corner alignment.
    //
    // Remarks:
    //     The dialog can be aligned to any of the WebView corners (see Microsoft.Web.WebView2.Core.CoreWebView2DefaultDownloadDialogCornerAlignment).
    //     When the WebView or dialog changes size, the dialog keeps it position relative
    //     to the corner. The dialog may become partially or completely outside of the WebView
    //     bounds if the WebView is small enough. Set the margin from the corner with the
    //     Microsoft.Web.WebView2.Core.CoreWebView2.DefaultDownloadDialogMargin property.
    //     The corner alignment and margin should be set during initialization to ensure
    //     that they are correctly applied when the layout is first computed, otherwise
    //     they will not take effect until the next time the WebView position or size is
    //     updated.
    public CoreWebView2DefaultDownloadDialogCornerAlignment DefaultDownloadDialogCornerAlignment
    {
        get
        {
            try
            {
                return (CoreWebView2DefaultDownloadDialogCornerAlignment)_nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment;
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
        set
        {
            try
            {
                _nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment = (COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT)value;
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
    //     The default download dialog margin relative to the WebView corner specified by
    //     Microsoft.Web.WebView2.Core.CoreWebView2.DefaultDownloadDialogCornerAlignment.
    //
    //
    // Remarks:
    //     The margin is a point that describes the vertical and horizontal distances between
    //     the chosen WebView corner and the default download dialog corner nearest to it.
    //     Positive values move the dialog towards the center of the WebView from the chosen
    //     WebView corner, and negative values move the dialog away from it. Use (0, 0)
    //     to align the dialog to the WebView corner with no margin. The corner alignment
    //     and margin should be set during initialization to ensure that they are correctly
    //     applied when the layout is first computed, otherwise they will not take effect
    //     until the next time the WebView position or size is updated.
    public Point DefaultDownloadDialogMargin
    {
        get
        {
            try
            {
                return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2_9.DefaultDownloadDialogMargin);
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
        set
        {
            try
            {
                _nativeICoreWebView2_9.DefaultDownloadDialogMargin = COMDotNetTypeConverter.PointNetToCOM(value);
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
    //     The current text of the statusbar as defined by [Window.statusbar](https://developer.mozilla.org/docs/Web/API/Window/statusbar).
    public string StatusBarText
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_12.StatusBarText;
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
    //     The associated Microsoft.Web.WebView2.Core.CoreWebView2Profile object of Microsoft.Web.WebView2.Core.CoreWebView2.
    public CoreWebView2Profile Profile
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2_13.Profile == null) ? null : new CoreWebView2Profile(_nativeICoreWebView2_13.Profile);
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
    //     Get the Uri as a string of the current Favicon. This will be an empty string
    //     if the page does not have a Favicon.
    public string FaviconUri
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_15.FaviconUri;
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
    //     Desired Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel of a WebView.
    //
    //
    // Remarks:
    //     An app may set Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel
    //     to indicate desired memory consumption level of WebView. Scripts will not be
    //     impacted and continue to run. This is useful for inactive apps that still want
    //     to run scripts and/or keep network connections alive and therefore could not
    //     call Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync and Microsoft.Web.WebView2.Core.CoreWebView2.Resume
    //     to reduce memory consumption. These apps can set memory usage target level to
    //     Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Low when the app
    //     becomes inactive, and set back to Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Normal
    //     when the app becomes active. It is not necessary to set CoreWebView2Controller's
    //     IsVisible property to false when setting the property. It is a best effort operation
    //     to change memory usage level, and the API will return before the operation completes.
    //     Setting the level to Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Low
    //     could potentially cause memory for some WebView browser processes to be swapped
    //     out to disk in some circumstances. It is a best effort to reduce memory usage
    //     as much as possible. If a script runs after its related memory has been swapped
    //     out, the memory will be swapped back in to ensure the script can still run, but
    //     performance might be impacted. Therefore, the app should set the level back to
    //     Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Normal when the
    //     app becomes active again. Setting memory usage target level back to normal will
    //     not happen automatically. An app should choose to use either the combination
    //     of Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync and Microsoft.Web.WebView2.Core.CoreWebView2.Resume
    //     or the combination of setting MemoryUsageTargetLevel to Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Low
    //     and Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Normal. It
    //     is not advisable to mix them. Trying to set Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel
    //     while suspended will be ignored. The Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync
    //     and Microsoft.Web.WebView2.Core.CoreWebView2.Resume methods will change the Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel.
    //     Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync will automatically set
    //     Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel to Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Low
    //     while Microsoft.Web.WebView2.Core.CoreWebView2.Resume on suspended WebView will
    //     automatically set Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel
    //     to Microsoft.Web.WebView2.Core.CoreWebView2MemoryUsageTargetLevel.Normal. Calling
    //     Microsoft.Web.WebView2.Core.CoreWebView2.Resume when the WebView is not suspended
    //     would not change Microsoft.Web.WebView2.Core.CoreWebView2.MemoryUsageTargetLevel.
    public CoreWebView2MemoryUsageTargetLevel MemoryUsageTargetLevel
    {
        get
        {
            try
            {
                return (CoreWebView2MemoryUsageTargetLevel)_nativeICoreWebView2_19.MemoryUsageTargetLevel;
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
        set
        {
            try
            {
                _nativeICoreWebView2_19.MemoryUsageTargetLevel = (COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL)value;
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
    //     The unique identifier of the main frame. It's the same kind of ID as with the
    //     Microsoft.Web.WebView2.Core.CoreWebView2Frame.FrameId and Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo.FrameId.
    //
    //
    // Remarks:
    //     FrameId may not be valid if Microsoft.Web.WebView2.Core.CoreWebView2 has not
    //     done any navigation. It's safe to get this value during or after the first Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading
    //     event. Otherwise, it could return the invalid frame Id 0.
    public uint FrameId
    {
        get
        {
            try
            {
                return _nativeICoreWebView2_20.FrameId;
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
    //     NavigationStarting is raised when the WebView main frame is requesting permission
    //     to navigate to a different URI.
    //
    // Remarks:
    //     Redirects raise this event as well, and the navigation id is the same as the
    //     original one. You may block corresponding navigations until the event handler
    //     returns.
    public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting
    {
        add
        {
            if (navigationStarting == null)
            {
                try
                {
                    _nativeICoreWebView2.add_NavigationStarting(new CoreWebView2NavigationStartingEventHandler(OnNavigationStarting), out _navigationStartingToken);
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
                _nativeICoreWebView2.remove_NavigationStarting(_navigationStartingToken);
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
    //     ContentLoading is raised before any content is loaded, including scripts added
    //     with Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String).
    //     ContentLoading is not raised if a same page navigation occurs (such as through
    //     fragment navigations or history.pushState navigations).
    //
    // Remarks:
    //     This operation follows the Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting
    //     and Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged events and precedes
    //     the Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged and Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted
    //     events.
    public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
    {
        add
        {
            if (contentLoading == null)
            {
                try
                {
                    _nativeICoreWebView2.add_ContentLoading(new CoreWebView2ContentLoadingEventHandler(OnContentLoading), out _contentLoadingToken);
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
                _nativeICoreWebView2.remove_ContentLoading(_contentLoadingToken);
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
    //     SourceChanged is raised when the Microsoft.Web.WebView2.Core.CoreWebView2.Source
    //     property changes.
    //
    // Remarks:
    //     SourceChanged is raised when navigating to a different site or fragment navigations.
    //     It is not raised for other types of navigations such as page refreshes or history.pushState
    //     with the same URL as the current page. This event is raised before Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading
    //     for navigation to a new document.
    public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged
    {
        add
        {
            if (sourceChanged == null)
            {
                try
                {
                    _nativeICoreWebView2.add_SourceChanged(new CoreWebView2SourceChangedEventHandler(OnSourceChanged), out _sourceChangedToken);
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

            sourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Combine(sourceChanged, value);
        }
        remove
        {
            sourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Remove(sourceChanged, value);
            if (sourceChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_SourceChanged(_sourceChangedToken);
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
    //     HistoryChanged is raised for changes to joint session history, which consists
    //     of top-level and manual frame navigations.
    //
    // Remarks:
    //     Use HistoryChanged to verify that the Microsoft.Web.WebView2.Core.CoreWebView2.CanGoBack
    //     or Microsoft.Web.WebView2.Core.CoreWebView2.CanGoForward value has changed. HistoryChanged
    //     is also raised for using Microsoft.Web.WebView2.Core.CoreWebView2.GoBack or Microsoft.Web.WebView2.Core.CoreWebView2.GoForward.
    //     HistoryChanged is raised after Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged
    //     and Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading. CanGoBack is false
    //     for navigations initiated through CoreWebView2Frame APIs if there has not yet
    //     been a user gesture.
    public event EventHandler<object> HistoryChanged
    {
        add
        {
            if (historyChanged == null)
            {
                try
                {
                    _nativeICoreWebView2.add_HistoryChanged(new CoreWebView2HistoryChangedEventHandler(OnHistoryChanged), out _historyChangedToken);
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

            historyChanged = (EventHandler<object>)Delegate.Combine(historyChanged, value);
        }
        remove
        {
            historyChanged = (EventHandler<object>)Delegate.Remove(historyChanged, value);
            if (historyChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_HistoryChanged(_historyChangedToken);
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
    //     NavigationCompleted is raised when the WebView has completely loaded (body.onload
    //     has been raised) or loading stopped with error.
    public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
    {
        add
        {
            if (navigationCompleted == null)
            {
                try
                {
                    _nativeICoreWebView2.add_NavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(OnNavigationCompleted), out _navigationCompletedToken);
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
                _nativeICoreWebView2.remove_NavigationCompleted(_navigationCompletedToken);
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
    //     FrameNavigationStarting is raised when a child frame in the WebView requests
    //     permission to navigate to a different URI.
    //
    // Remarks:
    //     Redirects raise this operation as well, and the navigation id is the same as
    //     the original one. You may block corresponding navigations until the event handler
    //     returns.
    public event EventHandler<CoreWebView2NavigationStartingEventArgs> FrameNavigationStarting
    {
        add
        {
            if (frameNavigationStarting == null)
            {
                try
                {
                    _nativeICoreWebView2.add_FrameNavigationStarting(new CoreWebView2NavigationStartingEventHandler(OnFrameNavigationStarting), out _frameNavigationStartingToken);
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

            frameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(frameNavigationStarting, value);
        }
        remove
        {
            frameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(frameNavigationStarting, value);
            if (frameNavigationStarting != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_FrameNavigationStarting(_frameNavigationStartingToken);
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
    //     FrameNavigationCompleted is raised when a child frame has completely loaded (body.onload
    //     has been raised) or loading stopped with error.
    public event EventHandler<CoreWebView2NavigationCompletedEventArgs> FrameNavigationCompleted
    {
        add
        {
            if (frameNavigationCompleted == null)
            {
                try
                {
                    _nativeICoreWebView2.add_FrameNavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(OnFrameNavigationCompleted), out _frameNavigationCompletedToken);
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

            frameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(frameNavigationCompleted, value);
        }
        remove
        {
            frameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(frameNavigationCompleted, value);
            if (frameNavigationCompleted != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_FrameNavigationCompleted(_frameNavigationCompletedToken);
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
    //     ScriptDialogOpening is raised when a JavaScript dialog (alert, confirm, prompt,
    //     or beforeunload) displays for the WebView.
    //
    // Remarks:
    //     This event only is raised if the Microsoft.Web.WebView2.Core.CoreWebView2Settings.AreDefaultScriptDialogsEnabled
    //     property is set to false. This event suppresses dialogs or replaces default dialogs
    //     with custom dialogs. If a deferral is not taken on the event args, the subsequent
    //     scripts are blocked until the event handler returns. If a deferral is taken,
    //     the scripts are blocked until the deferral is completed.
    public event EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> ScriptDialogOpening
    {
        add
        {
            if (scriptDialogOpening == null)
            {
                try
                {
                    _nativeICoreWebView2.add_ScriptDialogOpening(new CoreWebView2ScriptDialogOpeningEventHandler(OnScriptDialogOpening), out _scriptDialogOpeningToken);
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

            scriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Combine(scriptDialogOpening, value);
        }
        remove
        {
            scriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Remove(scriptDialogOpening, value);
            if (scriptDialogOpening != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_ScriptDialogOpening(_scriptDialogOpeningToken);
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
    //     PermissionRequested is raised when content in a WebView requests permission to
    //     access some privileged resources.
    //
    // Remarks:
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
                    _nativeICoreWebView2.add_PermissionRequested(new CoreWebView2PermissionRequestedEventHandler(OnPermissionRequested), out _permissionRequestedToken);
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
                _nativeICoreWebView2.remove_PermissionRequested(_permissionRequestedToken);
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
    //     ProcessFailed is raised when a WebView process ends unexpectedly or becomes unresponsive.
    //
    //
    // Remarks:
    //     ProcessFailed is raised when any of the processes in the WebView2 Process Group
    //     encounters one of the following conditions:
    //
    //     Condition – Details
    //     Unexpected exit – The process indicated by the event args has exited unexpectedly
    //     (usually due to a crash). The failure might or might not be recoverable, and
    //     some failures are auto-recoverable.
    //     Unresponsiveness – The process indicated by the event args has become unresponsive
    //     to user input. This is only reported for renderer processes, and will run every
    //     few seconds until the process becomes responsive again.
    //
    //     Note: When the failing process is the browser process, a Microsoft.Web.WebView2.Core.CoreWebView2Environment.BrowserProcessExited
    //     event will run too. Your application can use Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs
    //     to identify which condition and process the event is for, and to collect diagnostics
    //     and handle recovery if necessary. For more details about which cases need to
    //     be handled by your application, see Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.
    public event EventHandler<CoreWebView2ProcessFailedEventArgs> ProcessFailed
    {
        add
        {
            if (processFailed == null)
            {
                try
                {
                    _nativeICoreWebView2.add_ProcessFailed(new CoreWebView2ProcessFailedEventHandler(OnProcessFailed), out _processFailedToken);
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

            processFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Combine(processFailed, value);
        }
        remove
        {
            processFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Remove(processFailed, value);
            if (processFailed != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_ProcessFailed(_processFailedToken);
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
    //     WebMessageReceived is raised when the Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled
    //     setting is set and the top-level document of the WebView runs window.chrome.webview.postMessage
    //     or window.chrome.webview.postMessageWithAdditionalObjects.
    //
    // Remarks:
    //     The postMessage function is void postMessage(object) where object is any object
    //     supported by JSON conversion. When postMessage is called, the handler's Invoke
    //     method will be called with the object parameter postMessage converted to a JSON
    //     string. If the same page calls postMessage multiple times, the corresponding
    //     WebMessageReceived events are guaranteed to be fired in the same order. However,
    //     if multiple frames call postMessage, there is no guaranteed order. In addition,
    //     WebMessageReceived events caused by calls to postMessage are not guaranteed to
    //     be sequenced with events caused by DOM APIs. For example, if the page runs
    //
    //     chrome.webview.postMessage("message");
    //     window.open();
    //
    //     then the Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested event might
    //     be fired before the WebMessageReceived event. If you need the WebMessageReceived
    //     event to happen before anything else, then in the WebMessageReceived handler
    //     you can post a message back to the page and have the page wait until it receives
    //     that message before continuing.
    public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
    {
        add
        {
            if (webMessageReceived == null)
            {
                try
                {
                    _nativeICoreWebView2.add_WebMessageReceived(new CoreWebView2WebMessageReceivedEventHandler(OnWebMessageReceived), out _webMessageReceivedToken);
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
                _nativeICoreWebView2.remove_WebMessageReceived(_webMessageReceivedToken);
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
    //     NewWindowRequested is raised when content inside the WebView requests to open
    //     a new window, such as through window.open().
    //
    // Remarks:
    //     The app can pass a target WebView that is considered the opened window or mark
    //     the event as Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Handled,
    //     in which case WebView2 does not open a window. If either Handled or Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow
    //     properties are not set, the target content will be opened on a popup window.
    //     If a deferral is not taken on the event args, scripts that resulted in the new
    //     window that are requested are blocked until the event handler returns. If a deferral
    //     is taken, then scripts are blocked until the deferral is completed. On Hololens
    //     2, if the Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow
    //     property is not set and the Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Handled
    //     property is not set to true, the WebView2 will navigate to the Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Uri.
    //     If either of these properties are set, the WebView2 will not navigate to the
    //     Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.Uri and the
    //     the Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested event will continue
    //     as normal.
    public event EventHandler<CoreWebView2NewWindowRequestedEventArgs> NewWindowRequested
    {
        add
        {
            if (newWindowRequested == null)
            {
                try
                {
                    _nativeICoreWebView2.add_NewWindowRequested(new CoreWebView2NewWindowRequestedEventHandler(OnNewWindowRequested), out _newWindowRequestedToken);
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

            newWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Combine(newWindowRequested, value);
        }
        remove
        {
            newWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Remove(newWindowRequested, value);
            if (newWindowRequested != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_NewWindowRequested(_newWindowRequestedToken);
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
    //     DocumentTitleChanged is raised when the Microsoft.Web.WebView2.Core.CoreWebView2.DocumentTitle
    //     property changes and may be raised before or after the Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted
    //     event.
    public event EventHandler<object> DocumentTitleChanged
    {
        add
        {
            if (documentTitleChanged == null)
            {
                try
                {
                    _nativeICoreWebView2.add_DocumentTitleChanged(new CoreWebView2DocumentTitleChangedEventHandler(OnDocumentTitleChanged), out _documentTitleChangedToken);
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

            documentTitleChanged = (EventHandler<object>)Delegate.Combine(documentTitleChanged, value);
        }
        remove
        {
            documentTitleChanged = (EventHandler<object>)Delegate.Remove(documentTitleChanged, value);
            if (documentTitleChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_DocumentTitleChanged(_documentTitleChangedToken);
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
    //     ContainsFullScreenElementChanged is raised when the Microsoft.Web.WebView2.Core.CoreWebView2.ContainsFullScreenElement
    //     property changes.
    //
    // Remarks:
    //     An HTML element inside the WebView may enter fullscreen to the size of the WebView
    //     or leave fullscreen. This event is useful when, for example, a video element
    //     requests to go fullscreen. The listener of this event may resize the WebView
    //     in response.
    public event EventHandler<object> ContainsFullScreenElementChanged
    {
        add
        {
            if (containsFullScreenElementChanged == null)
            {
                try
                {
                    _nativeICoreWebView2.add_ContainsFullScreenElementChanged(new CoreWebView2ContainsFullScreenElementChangedEventHandler(OnContainsFullScreenElementChanged), out _containsFullScreenElementChangedToken);
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

            containsFullScreenElementChanged = (EventHandler<object>)Delegate.Combine(containsFullScreenElementChanged, value);
        }
        remove
        {
            containsFullScreenElementChanged = (EventHandler<object>)Delegate.Remove(containsFullScreenElementChanged, value);
            if (containsFullScreenElementChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_ContainsFullScreenElementChanged(_containsFullScreenElementChangedToken);
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
    //     WebResourceRequested is raised when the WebView is performing a URL request to
    //     a matching URL and resource context filter that was added with Microsoft.Web.WebView2.Core.CoreWebView2.AddWebResourceRequestedFilter(System.String,Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext).
    //
    //
    // Remarks:
    //     At least one filter must be added for the event to be raised. The web resource
    //     requested may be blocked until the event handler returns if a deferral is not
    //     taken on the event args. If a deferral is taken, then the web resource requested
    //     is blocked until the deferral is completed. If this event is subscribed in the
    //     Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested handler it should
    //     be called after the new window is set. For more details see Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow.
    //     This event is by default raised for file, http, and https URI schemes. This is
    //     also raised for registered custome URI schemes. See Microsoft.Web.WebView2.Core.CoreWebView2CustomSchemeRegistration
    //     for more details.
    public event EventHandler<CoreWebView2WebResourceRequestedEventArgs> WebResourceRequested
    {
        add
        {
            if (webResourceRequested == null)
            {
                try
                {
                    _nativeICoreWebView2.add_WebResourceRequested(new CoreWebView2WebResourceRequestedEventHandler(OnWebResourceRequested), out _webResourceRequestedToken);
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

            webResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Combine(webResourceRequested, value);
        }
        remove
        {
            webResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Remove(webResourceRequested, value);
            if (webResourceRequested != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_WebResourceRequested(_webResourceRequestedToken);
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
    //     WindowCloseRequested is raised when content inside the WebView requested to close
    //     the window, such as after window.close() is run.
    //
    // Remarks:
    //     The app should close the WebView and related app window if that makes sense to
    //     the app.
    public event EventHandler<object> WindowCloseRequested
    {
        add
        {
            if (windowCloseRequested == null)
            {
                try
                {
                    _nativeICoreWebView2.add_WindowCloseRequested(new CoreWebView2WindowCloseRequestedEventHandler(OnWindowCloseRequested), out _windowCloseRequestedToken);
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

            windowCloseRequested = (EventHandler<object>)Delegate.Combine(windowCloseRequested, value);
        }
        remove
        {
            windowCloseRequested = (EventHandler<object>)Delegate.Remove(windowCloseRequested, value);
            if (windowCloseRequested != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2.remove_WindowCloseRequested(_windowCloseRequestedToken);
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
    //     WebResourceResponseReceived is raised when the WebView receives the response
    //     for a request for a web resource (any URI resolution performed by the WebView;
    //     such as HTTP/HTTPS, file and data requests from redirects, navigations, declarations
    //     in HTML, implicit Favicon lookups, and fetch API usage in the document).
    //
    // Remarks:
    //     The host app can use this event to view the actual request and response for a
    //     web resource. There is no guarantee about the order in which the WebView processes
    //     the response and the host app's handler runs. The app's handler will not block
    //     the WebView from processing the response. The event args include the Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest
    //     as sent by the wire and Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse
    //     received, including any additional headers added by the network stack that were
    //     not be included as part of the associated Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested
    //     event, such as Authentication headers.
    public event EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> WebResourceResponseReceived
    {
        add
        {
            if (webResourceResponseReceived == null)
            {
                try
                {
                    _nativeICoreWebView2_2.add_WebResourceResponseReceived(new CoreWebView2WebResourceResponseReceivedEventHandler(OnWebResourceResponseReceived), out _webResourceResponseReceivedToken);
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

            webResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Combine(webResourceResponseReceived, value);
        }
        remove
        {
            webResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Remove(webResourceResponseReceived, value);
            if (webResourceResponseReceived != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_2.remove_WebResourceResponseReceived(_webResourceResponseReceivedToken);
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
                    _nativeICoreWebView2_2.add_DOMContentLoaded(new CoreWebView2DOMContentLoadedEventHandler(OnDOMContentLoaded), out _dOMContentLoadedToken);
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
                _nativeICoreWebView2_2.remove_DOMContentLoaded(_dOMContentLoadedToken);
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
    //     FrameCreated is raised when a new iframe is created. Handle this event to get
    //     access to Microsoft.Web.WebView2.Core.CoreWebView2Frame objects.
    //
    // Remarks:
    //     Use the Microsoft.Web.WebView2.Core.CoreWebView2Frame.Destroyed to listen for
    //     when this iframe goes away.
    public event EventHandler<CoreWebView2FrameCreatedEventArgs> FrameCreated
    {
        add
        {
            if (frameCreated == null)
            {
                try
                {
                    _nativeICoreWebView2_4.add_FrameCreated(new CoreWebView2FrameCreatedEventHandler(OnFrameCreated), out _frameCreatedToken);
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

            frameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Combine(frameCreated, value);
        }
        remove
        {
            frameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Remove(frameCreated, value);
            if (frameCreated != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_4.remove_FrameCreated(_frameCreatedToken);
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
    //     DownloadStarting is raised when a download has begun, blocking the default download
    //     dialog, but not blocking the progress of the download.
    //
    // Remarks:
    //     The host can choose to cancel a download, change the result file path, and hide
    //     the default download dialog. If download is not handled or canceled, the download
    //     is saved to the default path after the event completes with default download
    //     dialog shown.
    public event EventHandler<CoreWebView2DownloadStartingEventArgs> DownloadStarting
    {
        add
        {
            if (downloadStarting == null)
            {
                try
                {
                    _nativeICoreWebView2_4.add_DownloadStarting(new CoreWebView2DownloadStartingEventHandler(OnDownloadStarting), out _downloadStartingToken);
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

            downloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Combine(downloadStarting, value);
        }
        remove
        {
            downloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Remove(downloadStarting, value);
            if (downloadStarting != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_4.remove_DownloadStarting(_downloadStartingToken);
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
    //     ClientCertificateRequested is raised when WebView2 is making a request to an
    //     HTTP server that needs a client certificate for HTTP authentication. Read more
    //     about HTTP client certificates at [RFC 8446 The Transport Layer Security (TLS)
    //     Protocol Version 1.3](https://tools.ietf.org/html/rfc8446).
    //
    // Remarks:
    //     The host have several options for responding to client certificate requests:
    //
    //
    //     Scenario Handled Cancel SelectedCertificate
    //     Respond to server with a certificate True False MutuallyTrustedCertificate value
    //
    //     Respond to server without certificate True False null
    //     Display default client certificate selection dialog prompt False False n/a
    //     Cancel the request n/a True n/a
    //
    //     If the host don't handle the event, WebView2 will show the default client certificate
    //     selection dialog prompt to the user.
    public event EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> ClientCertificateRequested
    {
        add
        {
            if (clientCertificateRequested == null)
            {
                try
                {
                    _nativeICoreWebView2_5.add_ClientCertificateRequested(new CoreWebView2ClientCertificateRequestedEventHandler(OnClientCertificateRequested), out _clientCertificateRequestedToken);
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

            clientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Combine(clientCertificateRequested, value);
        }
        remove
        {
            clientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Remove(clientCertificateRequested, value);
            if (clientCertificateRequested != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_5.remove_ClientCertificateRequested(_clientCertificateRequestedToken);
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
    //     IsMutedChanged is raised when the mute state changes.
    public event EventHandler<object> IsMutedChanged
    {
        add
        {
            if (isMutedChanged == null)
            {
                try
                {
                    _nativeICoreWebView2_8.add_IsMutedChanged(new CoreWebView2IsMutedChangedEventHandler(OnIsMutedChanged), out _isMutedChangedToken);
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

            isMutedChanged = (EventHandler<object>)Delegate.Combine(isMutedChanged, value);
        }
        remove
        {
            isMutedChanged = (EventHandler<object>)Delegate.Remove(isMutedChanged, value);
            if (isMutedChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_8.remove_IsMutedChanged(_isMutedChangedToken);
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
    //     IsDocumentPlayingAudioChanged is raised when document starts or stops playing
    //     audio.
    public event EventHandler<object> IsDocumentPlayingAudioChanged
    {
        add
        {
            if (isDocumentPlayingAudioChanged == null)
            {
                try
                {
                    _nativeICoreWebView2_8.add_IsDocumentPlayingAudioChanged(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler(OnIsDocumentPlayingAudioChanged), out _isDocumentPlayingAudioChangedToken);
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

            isDocumentPlayingAudioChanged = (EventHandler<object>)Delegate.Combine(isDocumentPlayingAudioChanged, value);
        }
        remove
        {
            isDocumentPlayingAudioChanged = (EventHandler<object>)Delegate.Remove(isDocumentPlayingAudioChanged, value);
            if (isDocumentPlayingAudioChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_8.remove_IsDocumentPlayingAudioChanged(_isDocumentPlayingAudioChangedToken);
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
    //     Raised when the Microsoft.Web.WebView2.Core.CoreWebView2.IsDefaultDownloadDialogOpen
    //     property changes.
    //
    // Remarks:
    //     This event comes after the Microsoft.Web.WebView2.Core.CoreWebView2.DownloadStarting
    //     event. Setting the Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs.Handled
    //     property disables the default download dialog and ensures that this event is
    //     never raised.
    public event EventHandler<object> IsDefaultDownloadDialogOpenChanged
    {
        add
        {
            if (isDefaultDownloadDialogOpenChanged == null)
            {
                try
                {
                    _nativeICoreWebView2_9.add_IsDefaultDownloadDialogOpenChanged(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(OnIsDefaultDownloadDialogOpenChanged), out _isDefaultDownloadDialogOpenChangedToken);
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

            isDefaultDownloadDialogOpenChanged = (EventHandler<object>)Delegate.Combine(isDefaultDownloadDialogOpenChanged, value);
        }
        remove
        {
            isDefaultDownloadDialogOpenChanged = (EventHandler<object>)Delegate.Remove(isDefaultDownloadDialogOpenChanged, value);
            if (isDefaultDownloadDialogOpenChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_9.remove_IsDefaultDownloadDialogOpenChanged(_isDefaultDownloadDialogOpenChangedToken);
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
    //     BasicAuthenticationRequested event is raised when WebView encounters a Basic
    //     HTTP Authentication request as described in https://developer.mozilla.org/docs/Web/HTTP/Authentication,
    //     a Digest HTTP Authentication request as described in https://developer.mozilla.org/docs/Web/HTTP/Headers/Authorization#digest,
    //     an NTLM authentication or a Proxy Authentication request.
    //
    // Remarks:
    //     The host can provide a response with credentials for the authentication or cancel
    //     the request. If the host sets the Cancel property to false but does not provide
    //     either UserName or Password properties on the Response property, then WebView2
    //     will show the default authentication challenge dialog prompt to the user.
    public event EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> BasicAuthenticationRequested
    {
        add
        {
            if (basicAuthenticationRequested == null)
            {
                try
                {
                    _nativeICoreWebView2_10.add_BasicAuthenticationRequested(new CoreWebView2BasicAuthenticationRequestedEventHandler(OnBasicAuthenticationRequested), out _basicAuthenticationRequestedToken);
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

            basicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Combine(basicAuthenticationRequested, value);
        }
        remove
        {
            basicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Remove(basicAuthenticationRequested, value);
            if (basicAuthenticationRequested != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_10.remove_BasicAuthenticationRequested(_basicAuthenticationRequestedToken);
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
    //     ContextMenuRequested is raised when a context menu is requested by the user and
    //     the content inside WebView hasn't disabled context menus.
    //
    // Remarks:
    //     The host has the option to create their own context menu with the information
    //     provided in the event or can add items to or remove items from WebView context
    //     menu. If the host doesn't handle the event, WebView will display the default
    //     context menu.
    public event EventHandler<CoreWebView2ContextMenuRequestedEventArgs> ContextMenuRequested
    {
        add
        {
            if (contextMenuRequested == null)
            {
                try
                {
                    _nativeICoreWebView2_11.add_ContextMenuRequested(new CoreWebView2ContextMenuRequestedEventHandler(OnContextMenuRequested), out _contextMenuRequestedToken);
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

            contextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Combine(contextMenuRequested, value);
        }
        remove
        {
            contextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Remove(contextMenuRequested, value);
            if (contextMenuRequested != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_11.remove_ContextMenuRequested(_contextMenuRequestedToken);
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
    //     StatusBarTextChanged event is raised when the text in the [Window.statusbar](https://developer.mozilla.org/docs/Web/API/Window/statusbar)
    //     changes. When the event is fired use the property Microsoft.Web.WebView2.Core.CoreWebView2.StatusBarText
    //     to get the current statusbar text.
    //
    // Remarks:
    //     Events which cause causes can be anything from hover, url events, and others.
    //     There is not a finite list on how to cause the statusbar to change. The developer
    //     must create the status bar and set the text.
    public event EventHandler<object> StatusBarTextChanged
    {
        add
        {
            if (statusBarTextChanged == null)
            {
                try
                {
                    _nativeICoreWebView2_12.add_StatusBarTextChanged(new CoreWebView2StatusBarTextChangedEventHandler(OnStatusBarTextChanged), out _statusBarTextChangedToken);
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

            statusBarTextChanged = (EventHandler<object>)Delegate.Combine(statusBarTextChanged, value);
        }
        remove
        {
            statusBarTextChanged = (EventHandler<object>)Delegate.Remove(statusBarTextChanged, value);
            if (statusBarTextChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_12.remove_StatusBarTextChanged(_statusBarTextChangedToken);
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
    //     The ServerCertificateErrorDetected event is raised when the WebView2 cannot verify
    //     server's digital certificate while loading a web page.
    //
    // Remarks:
    //     This event will raise for all web resources and follows the Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested
    //     event. If you don't handle the event, WebView2 will show the default TLS interstitial
    //     error page to the user for navigations, and for non-navigations the web request
    //     is cancelled. Note that WebView2 before raising `ServerCertificateErrorDetected`
    //     raises a Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted event with
    //     Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess
    //     as FALSE and any of the below WebErrorStatuses that indicate a certificate failure.
    //
    //
    //     • Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateCommonNameIsIncorrect
    //
    //     • Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateExpired
    //     • Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.ClientCertificateContainsErrors
    //
    //     • Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateRevoked
    //     • Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.CertificateIsInvalid
    //
    //
    //     For more details see Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess
    //     and handle ServerCertificateErrorDetected event or show the default TLS interstitial
    //     error page to the user according to the app needs. WebView2 caches the response
    //     when action is Microsoft.Web.WebView2.Core.CoreWebView2ServerCertificateErrorAction.AlwaysAllow
    //     for the RequestUri's host and the server certificate in the session and the Microsoft.Web.WebView2.Core.CoreWebView2.ServerCertificateErrorDetected
    //     event won't be raised again. To raise the event again you must clear the cache
    //     using Microsoft.Web.WebView2.Core.CoreWebView2.ClearServerCertificateErrorActionsAsync.
    public event EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> ServerCertificateErrorDetected
    {
        add
        {
            if (serverCertificateErrorDetected == null)
            {
                try
                {
                    _nativeICoreWebView2_14.add_ServerCertificateErrorDetected(new CoreWebView2ServerCertificateErrorDetectedEventHandler(OnServerCertificateErrorDetected), out _serverCertificateErrorDetectedToken);
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

            serverCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Combine(serverCertificateErrorDetected, value);
        }
        remove
        {
            serverCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Remove(serverCertificateErrorDetected, value);
            if (serverCertificateErrorDetected != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_14.remove_ServerCertificateErrorDetected(_serverCertificateErrorDetectedToken);
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
    //     Raised when the Favicon has changed. This can include when a new page is loaded
    //     and thus by default no icon is set or the icon is set for the page by DOM or
    //     JavaScript.
    //
    // Remarks:
    //     The first argument is the Webview2 which saw the changed Favicon and the second
    //     is null.
    public event EventHandler<object> FaviconChanged
    {
        add
        {
            if (faviconChanged == null)
            {
                try
                {
                    _nativeICoreWebView2_15.add_FaviconChanged(new CoreWebView2FaviconChangedEventHandler(OnFaviconChanged), out _faviconChangedToken);
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

            faviconChanged = (EventHandler<object>)Delegate.Combine(faviconChanged, value);
        }
        remove
        {
            faviconChanged = (EventHandler<object>)Delegate.Remove(faviconChanged, value);
            if (faviconChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_15.remove_FaviconChanged(_faviconChangedToken);
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
    //     LaunchingExternalUriScheme is raised when a navigation request is made to a URI
    //     scheme that is registered with the OS.
    //
    // Remarks:
    //     The Microsoft.Web.WebView2.Core.CoreWebView2.LaunchingExternalUriScheme event
    //     handler may suppress the default dialog or replace the default dialog with a
    //     custom dialog. If a Microsoft.Web.WebView2.Core.CoreWebView2Deferral is not taken
    //     on the event args, the external URI scheme launch is blocked until the event
    //     handler returns. If a deferral is taken, the external URI scheme launch is blocked
    //     until the Microsoft.Web.WebView2.Core.CoreWebView2Deferral is completed. The
    //     host also has the option to cancel the URI scheme launch. The Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting
    //     and Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted events will
    //     be raised, regardless of whether the Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel
    //     property is set to true or false. The Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted
    //     event will be raised with the Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.IsSuccess
    //     property set to false and the Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs.WebErrorStatus
    //     property set to Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus.ConnectionAborted
    //     regardless of whether the host sets the Microsoft.Web.WebView2.Core.CoreWebView2LaunchingExternalUriSchemeEventArgs.Cancel
    //     property. The Microsoft.Web.WebView2.Core.CoreWebView2.SourceChanged, Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading
    //     and Microsoft.Web.WebView2.Core.CoreWebView2.HistoryChanged events will not be
    //     raised for this navigation to the external URI scheme regardless of the Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel
    //     property. The Microsoft.Web.WebView2.Core.CoreWebView2.LaunchingExternalUriScheme
    //     event will be raised after the Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting
    //     event and before the Microsoft.Web.WebView2.Core.CoreWebView2.NavigationCompleted
    //     event. The default Microsoft.Web.WebView2.Core.CoreWebView2Settings will also
    //     be updated upon navigation to an external URI scheme. If a setting on the Microsoft.Web.WebView2.Core.CoreWebView2Settings
    //     interface has been changed, navigating to an external URI scheme will trigger
    //     the Microsoft.Web.WebView2.Core.CoreWebView2Settings to update. The WebView2
    //     may not display the default dialog based on user settings, browser settings,
    //     and whether the origin is determined as a [trustworthy origin](https://w3c.github.io/webappsec-secure-contexts#potentially-trustworthy-origin);
    //     however, the event will still be raised. If the request is initiated by a cross-origin
    //     frame without a user gesture, the request will be blocked and the `LaunchingExternalUriScheme`
    //     event will not be raised.
    public event EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs> LaunchingExternalUriScheme
    {
        add
        {
            if (launchingExternalUriScheme == null)
            {
                try
                {
                    _nativeICoreWebView2_18.add_LaunchingExternalUriScheme(new CoreWebView2LaunchingExternalUriSchemeEventHandler(OnLaunchingExternalUriScheme), out _launchingExternalUriSchemeToken);
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

            launchingExternalUriScheme = (EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs>)Delegate.Combine(launchingExternalUriScheme, value);
        }
        remove
        {
            launchingExternalUriScheme = (EventHandler<CoreWebView2LaunchingExternalUriSchemeEventArgs>)Delegate.Remove(launchingExternalUriScheme, value);
            if (launchingExternalUriScheme != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2_18.remove_LaunchingExternalUriScheme(_launchingExternalUriSchemeToken);
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
    //     Print the current page to PDF asynchronously with the provided settings.
    //
    // Remarks:
    //     See Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings for description of
    //     settings. Passing null for printSettings results in default print settings used.
    //     Use resultFilePath to specify the path to the PDF file. The host should provide
    //     an absolute path, including file name. If the path points to an existing file,
    //     the file will be overwritten. If the path is not valid, the method fails. The
    //     async PrintToPdf operation completes when the data has been written to the PDF
    //     file. If the application exits before printing is complete, the file is not saved.
    //     Only one `Printing` operation can be in progress at a time. If PrintToPdf is
    //     called while a `PrintToPdf` or `PrintToPdfStream` or `Print` operation is in
    //     progress, the operation completes and returns false.
    public async Task<bool> PrintToPdfAsync(string ResultFilePath, CoreWebView2PrintSettings printSettings = null)
    {
        CoreWebView2PrintToPdfCompletedHandler handler;
        try
        {
            handler = new CoreWebView2PrintToPdfCompletedHandler();
            ICoreWebView2PrintSettings printSettings2 = printSettings?._nativeICoreWebView2PrintSettings;
            _nativeICoreWebView2_7.PrintToPdf(ResultFilePath, printSettings2, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.isSuccessful;
    }

    //
    // Summary:
    //     Opens the browser print preview dialog to print the current web page
    public void ShowPrintUI()
    {
        try
        {
            CoreWebView2PrintDialogKind printDialogKind = CoreWebView2PrintDialogKind.Browser;
            _nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
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

    internal CoreWebView2(object rawCoreWebView2)
    {
        _rawNative = rawCoreWebView2;
    }

    internal void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
    {
        navigationStarting?.Invoke(this, args);
    }

    internal void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
    {
        contentLoading?.Invoke(this, args);
    }

    internal void OnSourceChanged(CoreWebView2SourceChangedEventArgs args)
    {
        sourceChanged?.Invoke(this, args);
    }

    internal void OnHistoryChanged(object args)
    {
        historyChanged?.Invoke(this, args);
    }

    internal void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
    {
        navigationCompleted?.Invoke(this, args);
    }

    internal void OnFrameNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
    {
        frameNavigationStarting?.Invoke(this, args);
    }

    internal void OnFrameNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
    {
        frameNavigationCompleted?.Invoke(this, args);
    }

    internal void OnScriptDialogOpening(CoreWebView2ScriptDialogOpeningEventArgs args)
    {
        scriptDialogOpening?.Invoke(this, args);
    }

    internal void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
    {
        permissionRequested?.Invoke(this, args);
    }

    internal void OnProcessFailed(CoreWebView2ProcessFailedEventArgs args)
    {
        processFailed?.Invoke(this, args);
    }

    internal void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
    {
        webMessageReceived?.Invoke(this, args);
    }

    internal void OnNewWindowRequested(CoreWebView2NewWindowRequestedEventArgs args)
    {
        newWindowRequested?.Invoke(this, args);
    }

    internal void OnDocumentTitleChanged(object args)
    {
        documentTitleChanged?.Invoke(this, args);
    }

    internal void OnContainsFullScreenElementChanged(object args)
    {
        containsFullScreenElementChanged?.Invoke(this, args);
    }

    internal void OnWebResourceRequested(CoreWebView2WebResourceRequestedEventArgs args)
    {
        webResourceRequested?.Invoke(this, args);
    }

    internal void OnWindowCloseRequested(object args)
    {
        windowCloseRequested?.Invoke(this, args);
    }

    //
    // Summary:
    //     Causes a navigation of the top level document to the specified URI.
    //
    // Parameters:
    //   uri:
    //     The URI to navigate to.
    //
    // Remarks:
    //     For more information, navigate to [Navigation event](/microsoft-edge/webview2/concepts/navigation-events).
    //     Note that this operation starts a navigation and the corresponding Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting
    //     event is raised sometime after Navigate runs.
    public void Navigate(string uri)
    {
        try
        {
            _nativeICoreWebView2.Navigate(uri);
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
    //     Initiates a navigation to htmlContent as source HTML of a new document.
    //
    // Parameters:
    //   htmlContent:
    //     A source HTML of a new document.
    //
    // Remarks:
    //     The htmlContent parameter may not be larger than 2 MB (2 * 1024 * 1024 bytes)
    //     in total size. The origin of the new page is about:blank.
    public void NavigateToString(string htmlContent)
    {
        try
        {
            _nativeICoreWebView2.NavigateToString(htmlContent);
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
    //     Adds the provided JavaScript to a list of scripts that should be run after the
    //     global object has been created, but before the HTML document has been parsed
    //     and before any other script included by the HTML document is run.
    //
    // Parameters:
    //   javaScript:
    //     The JavaScript code to be run.
    //
    // Returns:
    //     A script ID that may be passed when calling Microsoft.Web.WebView2.Core.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(System.String).
    //
    //
    // Remarks:
    //     The injected script will apply to all future top level document and child frame
    //     navigations until removed with Microsoft.Web.WebView2.Core.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(System.String).
    //     This is applied asynchronously and you must wait for the returned System.Threading.Tasks.Task`1
    //     to complete before you can be sure that the script is ready to execute on future
    //     navigations. If the method is run in Microsoft.Web.WebView2.Core.CoreWebView2.NewWindowRequested
    //     handler, it should be called before the new window is set. For more details see
    //     Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs.NewWindow.
    //     Note that if an HTML document has sandboxing of some kind via [sandbox](https://developer.mozilla.org/docs/Web/HTML/Element/iframe#attr-sandbox)
    //     properties or the [Content-Security-Policy HTTP header](https://developer.mozilla.org/docs/Web/HTTP/Headers/Content-Security-Policy)
    //     this will affect the script run here. So, for example, if the allow-modals keyword
    //     is not set then calls to the alert function will be ignored.
    public async Task<string> AddScriptToExecuteOnDocumentCreatedAsync(string javaScript)
    {
        CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler;
        try
        {
            handler = new CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler();
            _nativeICoreWebView2.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.id;
    }

    //
    // Summary:
    //     Removes the corresponding JavaScript added via Microsoft.Web.WebView2.Core.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String)
    //     with the specified script ID.
    //
    // Parameters:
    //   id:
    //     The ID corresponds to the JavaScript code to be removed from the list of scripts.
    public void RemoveScriptToExecuteOnDocumentCreated(string id)
    {
        try
        {
            _nativeICoreWebView2.RemoveScriptToExecuteOnDocumentCreated(id);
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
    //     Runs JavaScript code from the javaScript parameter in the current top-level document
    //     rendered in the WebView.
    //
    // Parameters:
    //   javaScript:
    //     The JavaScript code to be run in the current top-level document rendered in the
    //     WebView.
    //
    // Returns:
    //     A JSON encoded string that represents the result of running the provided JavaScript.
    //
    //
    // Remarks:
    //     If the result is undefined, contains a reference cycle, or otherwise is not able
    //     to be encoded into JSON, the JSON null value is returned as the "null" string.
    //     A function that has no explicit return value returns undefined. If the script
    //     that was run throws an unhandled exception, then the result is also null. This
    //     method is applied asynchronously. If the method is run after the Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting
    //     event during a navigation, the script runs in the new document when loading it,
    //     around the time Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading is run.
    //     This operation works even if Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsScriptEnabled
    //     is set to false.
    public async Task<string> ExecuteScriptAsync(string javaScript)
    {
        CoreWebView2ExecuteScriptCompletedHandler handler;
        try
        {
            handler = new CoreWebView2ExecuteScriptCompletedHandler();
            _nativeICoreWebView2.ExecuteScript(javaScript, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.resultObjectAsJson;
    }

    //
    // Summary:
    //     Captures an image of what WebView is displaying.
    //
    // Parameters:
    //   imageFormat:
    //     The format of the image to be captured.
    //
    //   imageStream:
    //     The stream to which the resulting image binary data is written.
    //
    // Remarks:
    //     When CapturePreviewAsync finishes writing to the stream, the Invoke method on
    //     the provided handler parameter is called. This method fails if called before
    //     the first Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading event. For
    //     example if this is called in the Microsoft.Web.WebView2.Core.CoreWebView2.NavigationStarting
    //     event for the first navigation it will fail. For subsequent navigations, the
    //     method may not fail, but will not capture an image of a given webpage until the
    //     Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading event has been fired
    //     for it. Any call to this method prior to that will result in a capture of the
    //     page being navigated away from.
    public async Task CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat imageFormat, Stream imageStream)
    {
        CoreWebView2CapturePreviewCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CapturePreviewCompletedHandler();
            _nativeICoreWebView2.CapturePreview((COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT)imageFormat, (imageStream == null) ? null : new ManagedIStream(imageStream), handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
    }

    //
    // Summary:
    //     Reloads the current page.
    //
    // Remarks:
    //     This is similar to navigating to the URI of current top level document including
    //     all navigation events firing and respecting any entries in the HTTP cache. But,
    //     the back or forward history will not be modified.
    public void Reload()
    {
        try
        {
            _nativeICoreWebView2.Reload();
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
    //     Posts the specified webMessageAsJson to the top level document in this WebView.
    //
    //
    // Parameters:
    //   webMessageAsJson:
    //     The web message to be posted to the top level document in this WebView.
    //
    // Remarks:
    //     The event args is an instance of MessageEvent. The Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsWebMessageEnabled
    //     setting must be true or the message will not be sent. The event arg's data property
    //     of the event arg is the webMessageAsJson string parameter parsed as a JSON string
    //     into a JavaScript object. The event arg's source property of the event arg is
    //     a reference to the window.chrome.webview object. For information about sending
    //     messages from the HTML document in the WebView to the host, navigate to Microsoft.Web.WebView2.Core.CoreWebView2.WebMessageReceived.
    //     The message is sent asynchronously. If a navigation occurs before the message
    //     is posted to the page, the message is not be sent.
    public void PostWebMessageAsJson(string webMessageAsJson)
    {
        try
        {
            _nativeICoreWebView2.PostWebMessageAsJson(webMessageAsJson);
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
    //     Posts a message that is a simple string rather than a JSON string representation
    //     of a JavaScript object.
    //
    // Parameters:
    //   webMessageAsString:
    //     The web message to be posted to the top level document in this WebView.
    //
    // Remarks:
    //     This behaves in exactly the same manner as Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String),
    //     but the data property of the event arg of the window.chrome.webview message is
    //     a string with the same value as webMessageAsString. Use this instead of Microsoft.Web.WebView2.Core.CoreWebView2.PostWebMessageAsJson(System.String)
    //     if you want to communicate using simple strings rather than JSON objects.
    public void PostWebMessageAsString(string webMessageAsString)
    {
        try
        {
            _nativeICoreWebView2.PostWebMessageAsString(webMessageAsString);
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
    //     Runs an asynchronous DevToolsProtocol method.
    //
    // Parameters:
    //   methodName:
    //     The full name of the method in the format {domain}.{method}.
    //
    //   parametersAsJson:
    //     A JSON formatted string containing the parameters for the corresponding method.
    //
    //
    // Returns:
    //     A JSON string that represents the method's return object.
    //
    // Remarks:
    //     For more information about available methods, navigate to [DevTools Protocol
    //     Viewer](https://aka.ms/DevToolsProtocolDocs). The returned task is completed
    //     when the method asynchronously completes and will return the method's return
    //     object as a JSON string. Note even though WebView2 dispatches the CDP messages
    //     in the order called, CDP method calls may be processed out of order. If you require
    //     CDP methods to run in a particular order, you should await for the previous method
    //     call.
    public async Task<string> CallDevToolsProtocolMethodAsync(string methodName, string parametersAsJson)
    {
        CoreWebView2CallDevToolsProtocolMethodCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
            _nativeICoreWebView2.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.returnObjectAsJson;
    }

    //
    // Summary:
    //     Navigates the WebView to the previous page in the navigation history.
    public void GoBack()
    {
        try
        {
            _nativeICoreWebView2.GoBack();
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
    //     Navigates the WebView to the next page in the navigation history.
    public void GoForward()
    {
        try
        {
            _nativeICoreWebView2.GoForward();
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
    //     Gets a DevTools Protocol event receiver that allows you to subscribe to a DevToolsProtocol
    //     event.
    //
    // Parameters:
    //   eventName:
    //     The full name of the event in the format {domain}.{event}.
    //
    // Returns:
    //     A Devtools Protocol event receiver.
    //
    // Remarks:
    //     For more information about DevToolsProtocol events description and event args,
    //     navigate to [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs).
    public CoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(string eventName)
    {
        try
        {
            return new CoreWebView2DevToolsProtocolEventReceiver(_nativeICoreWebView2.GetDevToolsProtocolEventReceiver(eventName));
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
    //     Stops all navigations and pending resource fetches.
    //
    // Remarks:
    //     Does not stop scripts.
    public void Stop()
    {
        try
        {
            _nativeICoreWebView2.Stop();
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
    //     Adds the provided host object to script running in the WebView with the specified
    //     name.
    //
    // Parameters:
    //   name:
    //     The name of the host object.
    //
    //   rawObject:
    //     The host object to be added to script.
    //
    // Remarks:
    //     Host objects are exposed as host object proxies via window.chrome.webview.hostObjects.{name}.
    //     Host object proxies are promises and will resolve to an object representing the
    //     host object. Only the COM visible objects/properties/methods can be accessed
    //     from script. The app can control which part of .NET objects are exposed using
    //     System.Runtime.InteropServices.ComVisibleAttribute. JavaScript code in the WebView
    //     will be able to access appObject as following and then access attributes and
    //     methods of appObject. Note that while simple types, IDispatch and array are supported,
    //     and IUnknown objects that also implement IDispatch are treated as IDispatch,
    //     generic IUnknown, VT_DECIMAL, or VT_RECORD variant is not supported. Remote JavaScript
    //     objects like callback functions are represented as an VT_DISPATCH VARIANT with
    //     the object implementing IDispatch. The JavaScript callback method may be invoked
    //     using DISPID_VALUE for the DISPID. Such callback method invocations will return
    //     immediately and will not wait for the JavaScript function to run and so will
    //     not provide the return value of the JavaScript function. Nested arrays are supported
    //     up to a depth of 3. Arrays of by reference types are not supported. VT_EMPTY
    //     and VT_NULL are mapped into JavaScript as null. In JavaScript null and undefined
    //     are mapped to VT_EMPTY. Additionally, all host objects are exposed as window.chrome.webview.hostObjects.sync.{name}.
    //     Here the host objects are exposed as synchronous host object proxies. These are
    //     not promises and calls to functions or property access synchronously block running
    //     script waiting to communicate cross process for the host code to run. Accordingly
    //     this can result in reliability issues and it is recommended that you use the
    //     promise based asynchronous window.chrome.webview.hostObjects.{name} API described
    //     above. Synchronous host object proxies and asynchronous host object proxies can
    //     both proxy the same host object. Remote changes made by one proxy will be reflected
    //     in any other proxy of that same host object whether the other proxies and synchronous
    //     or asynchronous. While JavaScript is blocked on a synchronous call to native
    //     code, that native code is unable to call back to JavaScript. Attempts to do so
    //     will fail with HRESULT_FROM_WIN32(ERROR_POSSIBLE_DEADLOCK). Host object proxies
    //     are JavaScript Proxy objects that intercept all property get, property set, and
    //     method invocations. Properties or methods that are a part of the Function or
    //     Object prototype are run locally. Additionally any property or method in the
    //     array chrome.webview.hostObjects.options.forceLocalProperties will also be run
    //     locally. This defaults to including optional methods that have meaning in JavaScript
    //     like toJSON and Symbol.toPrimitive. You can add more to this array as required.
    //     There's a method chrome.webview.hostObjects.cleanupSome that will best effort
    //     garbage collect host object proxies. The chrome.webview.hostObjects.options object
    //     provides the ability to change some functionality of host objects.
    //
    //     Options property – Details
    //     forceLocalProperties – This is an array of host object property names that will
    //     be run locally, instead of being called on the native host object. This defaults
    //     to then, toJSON, Symbol.toString, and Symbol.toPrimitive. You can add other properties
    //     to specify that they should be run locally on the JavaScript host object proxy.
    //
    //     log – This is a callback that will be called with debug information. For example,
    //     you can set this to console.log.bind(console) to have it print debug information
    //     to the console to help when troubleshooting host object usage. By default this
    //     is null.
    //     shouldSerializeDates – By default this is false, and JavaScript Date objects
    //     will be sent to host objects as a string using JSON.stringify. You can set this
    //     property to true to have Date objects properly serialize as a System.DateTime
    //     when sending to the .NET host object, and have System.DateTime properties and
    //     return values create a JavaScript Date object.
    //     defaultSyncProxy – When calling a method on a synchronous proxy, the result should
    //     also be a synchronous proxy. But in some cases, the sync/async context is lost
    //     (for example, when providing to native code a reference to a function, and then
    //     calling that function in native code). In these cases, the proxy will be asynchronous,
    //     unless this property is set.
    //     forceAsyncMethodMatches – This is an array of regular expressions. When calling
    //     a method on a synchronous proxy, the method call will be performed asynchronously
    //     if the method name matches a string or regular expression in this array. Setting
    //     this value to Async will make any method that ends with Async be an asynchronous
    //     method call. If an async method doesn't match here and isn't forced to be asynchronous,
    //     the method will be invoked synchronously, blocking execution of the calling JavaScript
    //     and then returning the resolution of the promise, rather than returning a promise.
    //
    //     ignoreMemberNotFoundError – By default, an exception is thrown when attempting
    //     to get the value of a proxy property that doesn't exist on the corresponding
    //     native class. Setting this property to true switches the behavior to match Chakra
    //     WinRT projection (and general JavaScript) behavior of returning undefined with
    //     no error.
    //
    //     Host object proxies additionally have the following methods:
    //
    //     Method name – Details
    //     applyHostFunction, getHostProperty, setHostProperty – Perform a method invocation,
    //     property get, or property set on the host object. You can use these to explicitly
    //     force a method or property to run remotely if there is a conflicting local method
    //     or property. For instance, proxy.toString() will run the local toString method
    //     on the proxy object. But proxy.applyHostFunction('toString') runs toString on
    //     the host proxied object instead.
    //     getLocalProperty, setLocalProperty – Perform property get, or property set locally.
    //     You can use these methods to force getting or setting a property on the host
    //     object proxy itself rather than on the host object it represents. For instance,
    //     proxy.unknownProperty will get the property named unknownProperty from the host
    //     proxied object. But proxy.getLocalProperty('unknownProperty') will get the value
    //     of the property unknownProperty on the proxy object itself.
    //     addEventListener – This method only exists on proxies for .NET objects. Bind
    //     the JavaScript handler to the C# event, so that the JavaScript handler can be
    //     called through the C# event. For example, chrome.webview.hostObjects.sample.addEventListener('TestEvent',
    //     () => { alert('Invoked from remote');}); bind an anonymous JavaScript function
    //     to a C# event called 'TestEvent'. When calling TestEvent?.Invoke() on C# side,
    //     the JavaScript function that was just bound will be called asynchronously. It
    //     allows adding more than one handler for an event, but if the handler is already
    //     in the list of event handler, it will not be added a second time. If the host
    //     object cannot find the event with the name passed in by the addEventListener
    //     function or it is no public or its return type is not void, an exception will
    //     be thrown. If the count and type of C# event's parameters do not match the count
    //     and type of JavaScript handler, invoke addEventListener will be successful but
    //     an exception will be passed to JavaScript when invoke the event on C# side. If
    //     the host object has defined addEventListener function, use the defined function
    //     rather than the additionally addEventListener function.
    //     removeEventListener – This method only exists on proxies for .NET objects. Removes
    //     a handler previously bound with addEventListener(). If the handler does not exist
    //     in the list of event handler, nothing will happen. If the host object cannot
    //     find the event with the name passed in by the removeEventListener function or
    //     it is no public, an exception will be thrown. If the host object has defined
    //     removeEventListener function, use the defined function rather than the additionally
    //     removeEventListener function.
    //     sync – Asynchronous host object proxies expose a sync method which returns a
    //     promise for a synchronous host object proxy for the same host object. For example,
    //     chrome.webview.hostObjects.sample.methodCall() returns an asynchronous host object
    //     proxy. You can use the sync method to obtain a synchronous host object proxy
    //     instead: const syncProxy = await chrome.webview.hostObjects.sample.methodCall().sync()
    //
    //     async – Synchronous host object proxies expose an async method which blocks and
    //     returns an asynchronous host object proxy for the same host object. For example,
    //     chrome.webview.hostObjects.sync.sample.methodCall() returns a synchronous host
    //     object proxy. Calling the async method on this blocks and then returns an asynchronous
    //     host object proxy for the same host object: const asyncProxy = chrome.webview.hostObjects.sync.sample.methodCall().async()
    //
    //     then – Asynchronous host object proxies have a then method. This allows them
    //     to be awaitable. then will return a promise that resolves with a representation
    //     of the host object. If the proxy represents a JavaScript literal then a copy
    //     of that is returned locally. If the proxy represents a function then a non-awaitable
    //     proxy is returned. If the proxy represents a JavaScript object with a mix of
    //     literal properties and function properties, then the a copy of the object is
    //     returned with some properties as host object proxies.
    //     cancelPromise – This method attempts to cancel the fulfillment of a promised
    //     value. If the promise hasn't already been fulfilled and cancelation is supported,
    //     the promise will get rejected. cancelPromise supports cancelation of IAsyncOperation
    //     and IAsyncAction methods. If the promise is successfully canceled, then calling
    //     await on the promise will throw. For example, chrome.webview.hostObjects.cancelPromise(promise);
    //     await promise; will throw with "Promise Canceled". Once a promise has been canceled,
    //     a subsequent cancel on the same promise will throw an exception as well.
    //
    //     All other property and method invocations (other than the above Remote object
    //     proxy methods, forceLocalProperties list, and properties on Function and Object
    //     prototypes) are run remotely. Asynchronous host object proxies return a promise
    //     representing asynchronous completion of remotely invoking the method, or getting
    //     the property. The promise resolves after the remote operations complete and the
    //     promises resolve to the resulting value of the operation. Synchronous host object
    //     proxies work similarly but block JavaScript execution and wait for the remote
    //     operation to complete. Setting a property on an asynchronous host object proxy
    //     works slightly differently. The set returns immediately and the return value
    //     is the value that will be set. This is a requirement of the JavaScript Proxy
    //     object. If you need to asynchronously wait for the property set to complete,
    //     use the setHostProperty method which returns a promise as described above. Synchronous
    //     object property set property synchronously blocks until the property is set.
    //     Exposing host objects to script has security risk. Please follow [best practices](/microsoft-edge/webview2/concepts/security).
    public void AddHostObjectToScript(string name, object rawObject)
    {
        try
        {
            ICoreWebView2 nativeICoreWebView = _nativeICoreWebView2;
            object @object = rawObject;
            nativeICoreWebView.AddHostObjectToScript(name, ref @object);
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
    //     Removes the host object specified by the name so that it is no longer accessible
    //     from JavaScript code in the WebView.
    //
    // Parameters:
    //   name:
    //     The name of the host object to be removed.
    //
    // Remarks:
    //     While new access attempts are denied, if the object is already obtained by JavaScript
    //     code in the WebView, the JavaScript code continues to have access to that object.
    //     Running this method for a name that is already removed or never added fails.
    public void RemoveHostObjectFromScript(string name)
    {
        try
        {
            _nativeICoreWebView2.RemoveHostObjectFromScript(name);
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
    //     Opens the DevTools window for the current document in the WebView.
    //
    // Remarks:
    //     Does nothing if run when the DevTools window is already open.
    public void OpenDevToolsWindow()
    {
        try
        {
            _nativeICoreWebView2.OpenDevToolsWindow();
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
    //     Adds a URI and resource context filter for the Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested
    //     event.
    //
    // Parameters:
    //   uri:
    //     An URI to be added to the Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested
    //     event.
    //
    //   ResourceContext:
    //     A resource context filter to be added to the Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested
    //     event.
    //
    // Remarks:
    //     A web resource request with a resource context that matches this filter's resource
    //     context and a URI that matches this filter's URI wildcard string will be raised
    //     via the Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested event.
    //     The uri parameter value is a wildcard string matched against the URI of the web
    //     resource request. This is a glob style wildcard string in which a * matches zero
    //     or more characters and a ? matches exactly one character. These wildcard characters
    //     can be escaped using a backslash just before the wildcard character in order
    //     to represent the literal * or ?. The matching occurs over the URI as a whole
    //     string and not limiting wildcard matches to particular parts of the URI. The
    //     wildcard filter is compared to the URI after the URI has been normalized, any
    //     URI fragment has been removed, and non-ASCII hostnames have been converted to
    //     punycode. Specifying a nullptr for the uri is equivalent to an empty string which
    //     matches no URIs. For more information about resource context filters, navigate
    //     to Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext.
    //
    //     URI Filter String Request URI Match Notes
    //     * https://contoso.com/a/b/c Yes A single * will match all URIs
    //     *://contoso.com/* https://contoso.com/a/b/c Yes Matches everything in contoso.com
    //     across all schemes
    //     *://contoso.com/* https://example.com/?https://contoso.com/ Yes But also matches
    //     a URI with just the same text anywhere in the URI
    //     example https://contoso.com/example No The filter does not perform partial matches
    //
    //     *example https://contoso.com/example Yes The filter matches across URI parts
    //
    //     *example https://contoso.com/path/?example Yes The filter matches across URI
    //     parts
    //     *example https://contoso.com/path/?query#example No The filter is matched against
    //     the URI with no fragment
    //     *example https://example No The URI is normalized before filter matching so the
    //     actual URI used for comparison is https://example.com/
    //     *example/ https://example Yes Just like above, but this time the filter ends
    //     with a / just like the normalized URI
    //     https://xn--qei.example/ https://❤.example/ Yes Non-ASCII hostnames are normalized
    //     to punycode before wildcard comparison
    //     https://❤.example/ https://xn--qei.example/ No Non-ASCII hostnames are normalized
    //     to punycode before wildcard comparison
    public void AddWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext)
    {
        try
        {
            _nativeICoreWebView2.AddWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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
    //     Removes a matching WebResource filter that was previously added for the Microsoft.Web.WebView2.Core.CoreWebView2.WebResourceRequested
    //     event.
    //
    // Parameters:
    //   uri:
    //     An URI to at which a web resource filter was added.
    //
    //   ResourceContext:
    //     A previously added resource context filter to be removed.
    //
    // Exceptions:
    //   T:System.ArgumentException:
    //     A filter that was never added.
    //
    // Remarks:
    //     If the same filter was added multiple times, then it must need to be removed
    //     as many times as it was added for the removal to be effective.
    public void RemoveWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext)
    {
        try
        {
            _nativeICoreWebView2.RemoveWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

    internal void OnWebResourceResponseReceived(CoreWebView2WebResourceResponseReceivedEventArgs args)
    {
        webResourceResponseReceived?.Invoke(this, args);
    }

    internal void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
    {
        dOMContentLoaded?.Invoke(this, args);
    }

    //
    // Summary:
    //     Navigates using a constructed Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest
    //     object.
    //
    // Parameters:
    //   Request:
    //     The constructed web resource object to provide post data or additional request
    //     headers during navigation.
    //
    // Remarks:
    //     The headers in the Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest
    //     override headers added by WebView2 runtime except for Cookie headers. Method
    //     can only be either GET or POST. Provided post data will only be sent only if
    //     the method is POST and the uri scheme is HTTP(S).
    public void NavigateWithWebResourceRequest(CoreWebView2WebResourceRequest Request)
    {
        try
        {
            _nativeICoreWebView2_2.NavigateWithWebResourceRequest(Request._nativeICoreWebView2WebResourceRequest);
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
    //     An app may call this API to have the WebView2 consume less memory.
    //
    // Remarks:
    //     This is useful when a Win32 app becomes invisible, or when a Universal Windows
    //     Platform app is being suspended, during the suspended event handler before completing
    //     the suspended event. The Microsoft.Web.WebView2.Core.CoreWebView2Controller.IsVisible
    //     property must be false when the API is called. Otherwise, the API throws COMException
    //     with error code of HRESULT_FROM_WIN32(ERROR_INVALID_STATE). Suspending is similar
    //     to putting a tab to sleep in the Edge browser. Suspending pauses WebView script
    //     timers and animations, minimizes CPU usage for the associated browser renderer
    //     process and allows the operating system to reuse the memory that was used by
    //     the renderer process for other processes. Note that Suspend is best effort and
    //     considered completed successfully once the request is sent to browser renderer
    //     process. If there is a running script, the script will continue to run and the
    //     renderer process will be suspended after that script is done. See [Sleeping Tabs
    //     FAQ](https://techcommunity.microsoft.com/t5/articles/sleeping-tabs-faq/m-p/1705434)
    //     for conditions that might prevent WebView from being suspended. In those situations,
    //     the result of the async task is false. The WebView will be automatically resumed
    //     when it becomes visible. Therefore, the app normally does not have to call Microsoft.Web.WebView2.Core.CoreWebView2.Resume
    //     explicitly. The app can call Microsoft.Web.WebView2.Core.CoreWebView2.Resume
    //     and then Microsoft.Web.WebView2.Core.CoreWebView2.TrySuspendAsync periodically
    //     for an invisible WebView so that the invisible WebView can sync up with latest
    //     data and the page ready to show fresh content when it becomes visible. All WebView
    //     APIs can still be accessed when a WebView is suspended. Some APIs like Navigate
    //     will auto resume the WebView. To avoid unexpected auto resume, check Microsoft.Web.WebView2.Core.CoreWebView2.IsSuspended
    //     property before calling APIs that might change WebView state.
    public async Task<bool> TrySuspendAsync()
    {
        CoreWebView2TrySuspendCompletedHandler handler;
        try
        {
            handler = new CoreWebView2TrySuspendCompletedHandler();
            _nativeICoreWebView2_3.TrySuspend(handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.isSuccessful;
    }

    //
    // Summary:
    //     Resumes the WebView so that it resumes activities on the web page.
    //
    // Remarks:
    //     This API can be called while the WebView2 controller is invisible. The app can
    //     interact with the WebView immediately after Microsoft.Web.WebView2.Core.CoreWebView2.Resume.
    //     WebView will be automatically resumed when it becomes visible.
    public void Resume()
    {
        try
        {
            _nativeICoreWebView2_3.Resume();
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
    //     Sets a mapping between a virtual host name and a folder path to make available
    //     to web sites via that host name.
    //
    // Parameters:
    //   hostName:
    //     A virtual host name.
    //
    //   folderPath:
    //     A folder path name to be mapped to the virtual host name. The length must not
    //     exceed the Windows MAX_PATH limit.
    //
    //   accessKind:
    //     The level of access to resources under the virtual host from other sites.
    //
    // Remarks:
    //     After setting the mapping, documents loaded in the WebView can use HTTP or HTTPS
    //     URLs at the specified host name specified by hostName to access files in the
    //     local folder specified by folderPath. This mapping applies to both top-level
    //     document and iframe navigations as well as subresource references from a document.
    //     This also applies to dedicated and shared worker scripts but does not apply to
    //     service worker scripts. Due to a current implementation limitation, media files
    //     accessed using virtual host name can be very slow to load. As the resource loaders
    //     for the current page might have already been created and running, changes to
    //     the mapping might not be applied to the current page and a reload of the page
    //     is needed to apply the new mapping. Both absolute and relative paths are supported
    //     for folderPath. Relative paths are interpreted as relative to the folder where
    //     the exe of the app is in.
    //
    //     For example, after calling SetVirtualHostNameToFolderMapping("appassets.example",
    //     "assets", CoreWebView2HostResourceAccessKind.Deny);, navigating to https://appassets.example/my-local-file.html
    //     will show content from my-local-file.html in the assets subfolder located on
    //     disk under the same path as the app's executable file. DOM elements that want
    //     to reference local files will have their host reference virtual host in the source.
    //     If there are multiple folders being used, define one unique virtual host per
    //     folder.
    //
    //     You should typically choose virtual host names that are never used by real sites.
    //     If you own a domain such as example.com, another option is to use a subdomain
    //     reserved for the app (like my-app.example.com).
    //
    //     [RFC 6761](https://tools.ietf.org/html/rfc6761) has reserved several special-use
    //     domain names that are guaranteed to not be used by real sites (for example, .example,
    //     .test, and .invalid).
    //
    //     Note that using .local as the top-level domain name will work but can cause a
    //     delay during navigations. You should avoid using .local if you can.
    //
    //     Apps should use distinct domain names when mapping folder from different sources
    //     that should be isolated from each other. For instance, the app might use app-file.example
    //     for files that ship as part of the app, and book1.example might be used for files
    //     containing books from a less trusted source that were previously downloaded and
    //     saved to the disk by the app.
    //
    //     The host name used in the APIs is canonicalized using Chromium's host name parsing
    //     logic before being used internally. For more information see [HTML5 2.6 URLs](https://dev.w3.org/html5/spec-LC/urls.html).
    //
    //
    //     All host names that are canonicalized to the same string are considered identical.
    //     For example, EXAMPLE.COM and example.com are treated as the same host name. An
    //     international host name and its Punycode-encoded host name are considered the
    //     same host name. There is no DNS resolution for host name and the trailing '.'
    //     is not normalized as part of canonicalization.
    //
    //     Therefore example.com and example.com. are treated as different host names. Similarly,
    //     virtual-host-name and virtual-host-name.example.com are treated as different
    //     host names even if the machine has a DNS suffix of example.com.
    //
    //     Specify the minimal cross-origin access necessary to run the app. If there is
    //     not a need to access local resources from other origins, use Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Deny.
    public void SetVirtualHostNameToFolderMapping(string hostName, string folderPath, CoreWebView2HostResourceAccessKind accessKind)
    {
        try
        {
            _nativeICoreWebView2_3.SetVirtualHostNameToFolderMapping(hostName, folderPath, (COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND)accessKind);
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
    //     Clears a host name mapping for local folder that was added by Microsoft.Web.WebView2.Core.CoreWebView2.SetVirtualHostNameToFolderMapping(System.String,System.String,Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind).
    //
    //
    // Parameters:
    //   hostName:
    //     The host name to be removed from the mapping.
    public void ClearVirtualHostNameToFolderMapping(string hostName)
    {
        try
        {
            _nativeICoreWebView2_3.ClearVirtualHostNameToFolderMapping(hostName);
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

    internal void OnFrameCreated(CoreWebView2FrameCreatedEventArgs args)
    {
        frameCreated?.Invoke(this, args);
    }

    internal void OnDownloadStarting(CoreWebView2DownloadStartingEventArgs args)
    {
        downloadStarting?.Invoke(this, args);
    }

    internal void OnClientCertificateRequested(CoreWebView2ClientCertificateRequestedEventArgs args)
    {
        clientCertificateRequested?.Invoke(this, args);
    }

    //
    // Summary:
    //     Opens the Browser Task Manager view as a new window in the foreground.
    //
    // Remarks:
    //     If the Browser Task Manager is already open, this will bring it into the foreground.
    //     WebView2 currently blocks the Shift+Esc shortcut for opening the task manager.
    //     An end user can open the browser task manager manually via the Browser task manager
    //     entry of the DevTools window's title bar's context menu.
    public void OpenTaskManagerWindow()
    {
        try
        {
            _nativeICoreWebView2_6.OpenTaskManagerWindow();
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

    internal void OnIsMutedChanged(object args)
    {
        isMutedChanged?.Invoke(this, args);
    }

    internal void OnIsDocumentPlayingAudioChanged(object args)
    {
        isDocumentPlayingAudioChanged?.Invoke(this, args);
    }

    internal void OnIsDefaultDownloadDialogOpenChanged(object args)
    {
        isDefaultDownloadDialogOpenChanged?.Invoke(this, args);
    }

    //
    // Summary:
    //     Open the default download dialog.
    //
    // Remarks:
    //     If the dialog is opened before there are recent downloads, the dialog shows all
    //     past downloads for the current profile. Otherwise, the dialog shows only the
    //     recent downloads with a "See more" button for past downloads. Calling this method
    //     raises the Microsoft.Web.WebView2.Core.CoreWebView2.IsDefaultDownloadDialogOpenChanged
    //     event if the dialog was closed. No effect if the dialog is already open.
    public void OpenDefaultDownloadDialog()
    {
        try
        {
            _nativeICoreWebView2_9.OpenDefaultDownloadDialog();
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
    //     Close the default download dialog.
    //
    // Remarks:
    //     Calling this method raises the Microsoft.Web.WebView2.Core.CoreWebView2.IsDefaultDownloadDialogOpenChanged
    //     event if the dialog was open. No effect if the dialog is already closed.
    public void CloseDefaultDownloadDialog()
    {
        try
        {
            _nativeICoreWebView2_9.CloseDefaultDownloadDialog();
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

    internal void OnBasicAuthenticationRequested(CoreWebView2BasicAuthenticationRequestedEventArgs args)
    {
        basicAuthenticationRequested?.Invoke(this, args);
    }

    internal void OnContextMenuRequested(CoreWebView2ContextMenuRequestedEventArgs args)
    {
        contextMenuRequested?.Invoke(this, args);
    }

    //
    // Summary:
    //     Runs an asynchronous DevToolsProtocol method for a specific session of an attached
    //     target.
    //
    // Parameters:
    //   sessionId:
    //     The sessionId for an attached target. null or empty string is treated as the
    //     session for the default target for the top page.
    //
    //   methodName:
    //     The full name of the method in the format {domain}.{method}.
    //
    //   parametersAsJson:
    //     A JSON formatted string containing the parameters for the corresponding method.
    //
    //
    // Returns:
    //     A JSON string that represents the method's return object.
    //
    // Remarks:
    //     There could be multiple DevToolsProtocol targets in a WebView. Besides the top
    //     level page, iframes from different origin and web workers are also separate targets.
    //     Attaching to these targets allows interaction with them. When the DevToolsProtocol
    //     is attached to a target, the connection is identified by a sessionId. To use
    //     this API, you must set the flatten parameter to true when calling Target.attachToTarget
    //     or Target.setAutoAttach DevToolsProtocol method. Using Target.setAutoAttach is
    //     recommended as that would allow you to attach to dedicated worker targets, which
    //     are not discoverable via other APIs like Target.getTargets. For more information
    //     about targets and sessions, navigate to [Chrome DevTools Protocol - Target domain](
    //     https://chromedevtools.github.io/devtools-protocol/tot/Target). For more information
    //     about available methods, navigate to [DevTools Protocol Viewer](https://aka.ms/DevToolsProtocolDocs).
    //     The handler's Invoke method will be called when the method asynchronously completes.
    //     Invoke will be called with the method's return object as a JSON string.
    public async Task<string> CallDevToolsProtocolMethodForSessionAsync(string sessionId, string methodName, string parametersAsJson)
    {
        CoreWebView2CallDevToolsProtocolMethodCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
            _nativeICoreWebView2_11.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.returnObjectAsJson;
    }

    internal void OnStatusBarTextChanged(object args)
    {
        statusBarTextChanged?.Invoke(this, args);
    }

    internal void OnServerCertificateErrorDetected(CoreWebView2ServerCertificateErrorDetectedEventArgs args)
    {
        serverCertificateErrorDetected?.Invoke(this, args);
    }

    //
    // Summary:
    //     Clears all cached decisions to proceed with TLS certificate errors from the Microsoft.Web.WebView2.Core.CoreWebView2.ServerCertificateErrorDetected
    //     event for all WebView2's sharing the same session.
    public async Task ClearServerCertificateErrorActionsAsync()
    {
        CoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler;
        try
        {
            handler = new CoreWebView2ClearServerCertificateErrorActionsCompletedHandler();
            _nativeICoreWebView2_14.ClearServerCertificateErrorActions(handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
    }

    internal void OnFaviconChanged(object args)
    {
        faviconChanged?.Invoke(this, args);
    }

    //
    // Summary:
    //     Get the downloaded Favicon image for the current page and copy it to the image
    //     stream.
    //
    // Parameters:
    //   format:
    //     The format to retrieve the Favicon in.
    //
    // Returns:
    //     An IStream populated with the downloaded Favicon.
    public async Task<Stream> GetFaviconAsync(CoreWebView2FaviconImageFormat format)
    {
        CoreWebView2GetFaviconCompletedHandler handler;
        try
        {
            handler = new CoreWebView2GetFaviconCompletedHandler();
            _nativeICoreWebView2_15.GetFavicon((COREWEBVIEW2_FAVICON_IMAGE_FORMAT)format, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.faviconStream;
    }

    //
    // Summary:
    //     Print the current web page asynchronously to the specified printer with the provided
    //     settings.
    //
    // Remarks:
    //     See Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings for description of
    //     settings. Passing null for printSettings results in default print settings used.
    //     The method will return Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus as
    //     Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.PrinterUnavailable if printerName
    //     doesn't match with the name of any installed printers on the user OS. The method
    //     will throw ArgumentException if the caller provides invalid settings for a given
    //     printer. The async Print operation completes when it finishes printing to the
    //     printer. Only one Printing operation can be in progress at a time. If Print is
    //     called while a Microsoft.Web.WebView2.Core.CoreWebView2.PrintAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     or Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     or Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     job is in progress, System.Threading.Tasks.Task`1 throws exception. This is only
    //     for printing operation on one webview.
    //
    //     Error PrintStatus Notes
    //     No Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.Succeeded Print operation
    //     succeeded.
    //     No Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.PrinterUnavailable If
    //     specified printer is not found or printer status is not available, offline or
    //     error state.
    //     No Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.OtherError Print operation
    //     is failed.
    //     ArgumentException Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.OtherError
    //     If the caller provides invalid settings for the specified printer.
    //     Exception Microsoft.Web.WebView2.Core.CoreWebView2PrintStatus.OtherError Print
    //     operation is failed as printing job already in progress.
    public async Task<CoreWebView2PrintStatus> PrintAsync(CoreWebView2PrintSettings printSettings)
    {
        CoreWebView2PrintCompletedHandler handler;
        try
        {
            handler = new CoreWebView2PrintCompletedHandler();
            _nativeICoreWebView2_16.Print(printSettings?._nativeICoreWebView2PrintSettings, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.printStatus;
    }

    //
    // Summary:
    //     Opens the print dialog to print the current web page.
    //
    // Remarks:
    //     See Microsoft.Web.WebView2.Core.CoreWebView2PrintDialogKind for descriptions
    //     of print dialog kinds. Invoking browser or system print dialog doesn't open new
    //     print dialog if it is already open.
    public void ShowPrintUI(CoreWebView2PrintDialogKind printDialogKind)
    {
        try
        {
            _nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
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
    //     Provides the Pdf data of current web page asynchronously for the provided settings.
    //
    //
    // Remarks:
    //     Stream will be rewound to the start of the pdf data. See Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings
    //     for description of settings. Passing null for printSettings results in default
    //     print settings used. The async PrintToPdfStream operation completes when it finishes
    //     writing to the stream. Only one Printing operation can be in progress at a time.
    //     If Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     is called while a Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfStreamAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     or Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     or Microsoft.Web.WebView2.Core.CoreWebView2.PrintAsync(Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     job is in progress, the System.Threading.Tasks.Task`1 throws an exception. This
    //     is only for printing operation on one webview.
    public async Task<Stream> PrintToPdfStreamAsync(CoreWebView2PrintSettings printSettings)
    {
        CoreWebView2PrintToPdfStreamCompletedHandler handler;
        try
        {
            handler = new CoreWebView2PrintToPdfStreamCompletedHandler();
            _nativeICoreWebView2_16.PrintToPdfStream(printSettings?._nativeICoreWebView2PrintSettings, handler);
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

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.pdfStream;
    }

    //
    // Summary:
    //     Share a shared buffer object with script of the main frame in the WebView.
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
    //
    //     Property Description
    //     getBuffer() A method that returns an ArrayBuffer object with the backing content
    //     from the shared buffer.
    //     additionalData An object as the result of parsing additionalDataAsJson as JSON
    //     string. This property will be undefined if additionalDataAsJson is nullptr or
    //     empty string.
    //     source With a value set as chrome.webview object.
    //
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
            _nativeICoreWebView2_17.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2SharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
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

    internal void OnLaunchingExternalUriScheme(CoreWebView2LaunchingExternalUriSchemeEventArgs args)
    {
        launchingExternalUriScheme?.Invoke(this, args);
    }

    internal void AddHostObjectHelper(CoreWebView2PrivateHostObjectHelper helper)
    {
        try
        {
            _nativeICoreWebView2PrivatePartial.AddHostObjectHelper(helper._nativeICoreWebView2PrivateHostObjectHelper);
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
#if false // Decompilation log
'201' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\mscorlib.dll'
------------------
Resolve: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Drawing.dll'
------------------
Resolve: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.dll'
------------------
Resolve: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Core.dll'
------------------
Resolve: 'Microsoft.Win32.Registry, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.Win32.Registry, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\Microsoft.Win32.Registry.dll'
------------------
Resolve: 'System.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Runtime.dll'
------------------
Resolve: 'System.Security.Principal.Windows, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Security.Principal.Windows.dll'
------------------
Resolve: 'System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Security.Permissions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.Security.Permissions.dll'
------------------
Resolve: 'System.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Collections.dll'
------------------
Resolve: 'System.Collections.NonGeneric, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.NonGeneric, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Collections.NonGeneric.dll'
------------------
Resolve: 'System.Collections.Concurrent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Collections.Concurrent.dll'
------------------
Resolve: 'System.ObjectModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Console, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Console, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Console.dll'
------------------
Resolve: 'System.Runtime.InteropServices, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Runtime.InteropServices.dll'
------------------
Resolve: 'System.Diagnostics.Contracts, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Contracts, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.Contracts.dll'
------------------
Resolve: 'System.Diagnostics.StackTrace, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.StackTrace, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.StackTrace.dll'
------------------
Resolve: 'System.Diagnostics.Tracing, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Tracing, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.Tracing.dll'
------------------
Resolve: 'System.IO.FileSystem.DriveInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.DriveInfo, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.FileSystem.DriveInfo.dll'
------------------
Resolve: 'System.IO.IsolatedStorage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.IsolatedStorage, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.IsolatedStorage.dll'
------------------
Resolve: 'System.ComponentModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ComponentModel.dll'
------------------
Resolve: 'System.Threading.Thread, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Thread, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Threading.Thread.dll'
------------------
Resolve: 'System.Reflection.Emit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Reflection.Emit.dll'
------------------
Resolve: 'System.Reflection.Emit.ILGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit.ILGeneration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Reflection.Emit.ILGeneration.dll'
------------------
Resolve: 'System.Reflection.Emit.Lightweight, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit.Lightweight, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Reflection.Emit.Lightweight.dll'
------------------
Resolve: 'System.Reflection.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Reflection.Primitives.dll'
------------------
Resolve: 'System.Resources.Writer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Resources.Writer, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Resources.Writer.dll'
------------------
Resolve: 'System.Runtime.CompilerServices.VisualC, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.CompilerServices.VisualC, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Runtime.CompilerServices.VisualC.dll'
------------------
Resolve: 'System.Runtime.Serialization.Formatters, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.Serialization.Formatters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Runtime.Serialization.Formatters.dll'
------------------
Resolve: 'System.Security.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Security.AccessControl.dll'
------------------
Resolve: 'System.IO.FileSystem.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.FileSystem.AccessControl.dll'
------------------
Resolve: 'System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.Threading.AccessControl.dll'
------------------
Resolve: 'System.Security.Claims, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Security.Claims.dll'
------------------
Resolve: 'System.Security.Cryptography, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Cryptography, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Security.Cryptography.dll'
------------------
Resolve: 'System.Text.Encoding.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.Encoding.Extensions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Text.Encoding.Extensions.dll'
------------------
Resolve: 'System.Threading, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Threading.dll'
------------------
Resolve: 'System.Threading.Overlapped, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Overlapped, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Threading.Overlapped.dll'
------------------
Resolve: 'System.Threading.ThreadPool, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.ThreadPool, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Threading.ThreadPool.dll'
------------------
Resolve: 'System.Threading.Tasks.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Tasks.Parallel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Threading.Tasks.Parallel.dll'
------------------
Resolve: 'System.Drawing.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.Drawing.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Drawing.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Drawing.Primitives.dll'
------------------
Resolve: 'System.ComponentModel.TypeConverter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.TypeConverter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ComponentModel.TypeConverter.dll'
------------------
Resolve: 'System.Configuration.ConfigurationManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Configuration.ConfigurationManager, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.Configuration.ConfigurationManager.dll'
------------------
Resolve: 'System.CodeDom, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.CodeDom, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.CodeDom.dll'
------------------
Resolve: 'Microsoft.Win32.SystemEvents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'Microsoft.Win32.SystemEvents, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\Microsoft.Win32.SystemEvents.dll'
------------------
Resolve: 'System.Diagnostics.Process, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Process, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.Process.dll'
------------------
Resolve: 'System.Collections.Specialized, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Specialized, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Collections.Specialized.dll'
------------------
Resolve: 'System.ComponentModel.EventBasedAsync, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.EventBasedAsync, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ComponentModel.EventBasedAsync.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'Microsoft.Win32.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.Win32.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\Microsoft.Win32.Primitives.dll'
------------------
Resolve: 'System.Diagnostics.TraceSource, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.TraceSource, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.TraceSource.dll'
------------------
Resolve: 'System.Diagnostics.TextWriterTraceListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.TextWriterTraceListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.TextWriterTraceListener.dll'
------------------
Resolve: 'System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.PerformanceCounter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.PerformanceCounter.dll'
------------------
Resolve: 'System.Diagnostics.EventLog, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.EventLog, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.EventLog.dll'
------------------
Resolve: 'System.Diagnostics.FileVersionInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.FileVersionInfo, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Diagnostics.FileVersionInfo.dll'
------------------
Resolve: 'System.IO.Compression, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.IO.Compression, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.Compression.dll'
------------------
Resolve: 'System.IO.FileSystem.Watcher, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.Watcher, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.FileSystem.Watcher.dll'
------------------
Resolve: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Windows.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Windows.Extensions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.0\ref\net8.0\System.Windows.Extensions.dll'
------------------
Resolve: 'System.Net.Requests, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Requests, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.Requests.dll'
------------------
Resolve: 'System.Net.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.Primitives.dll'
------------------
Resolve: 'System.Net.HttpListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.HttpListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.HttpListener.dll'
------------------
Resolve: 'System.Net.ServicePoint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.ServicePoint, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.ServicePoint.dll'
------------------
Resolve: 'System.Net.NameResolution, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NameResolution, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.NameResolution.dll'
------------------
Resolve: 'System.Net.WebClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.WebClient, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.WebClient.dll'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.WebHeaderCollection.dll'
------------------
Resolve: 'System.Net.WebProxy, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.WebProxy, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.WebProxy.dll'
------------------
Resolve: 'System.Net.Mail, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.Mail, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.Mail.dll'
------------------
Resolve: 'System.Net.NetworkInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NetworkInformation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.NetworkInformation.dll'
------------------
Resolve: 'System.Net.Ping, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Ping, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.Ping.dll'
------------------
Resolve: 'System.Net.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Security, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.Security.dll'
------------------
Resolve: 'System.Net.Sockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Sockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.Sockets.dll'
------------------
Resolve: 'System.Net.WebSockets.Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebSockets.Client, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.WebSockets.Client.dll'
------------------
Resolve: 'System.Net.WebSockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebSockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.WebSockets.dll'
------------------
Resolve: 'System.Text.RegularExpressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Text.RegularExpressions.dll'
------------------
Resolve: 'System.IO.MemoryMappedFiles, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.MemoryMappedFiles, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.MemoryMappedFiles.dll'
------------------
Resolve: 'System.IO.Pipes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.Pipes.dll'
------------------
Resolve: 'System.Linq.Expressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq.Expressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Linq.Expressions.dll'
------------------
Resolve: 'System.IO.Pipes.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.Pipes.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.IO.Pipes.AccessControl.dll'
------------------
Resolve: 'System.Linq, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Linq.dll'
------------------
Resolve: 'System.Linq.Queryable, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq.Queryable, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Linq.Queryable.dll'
------------------
Resolve: 'System.Linq.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Linq.Parallel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Linq.Parallel.dll'
------------------
Resolve: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Runtime.dll'
------------------
Resolve: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Security.AccessControl.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Drawing.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.Drawing.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\ref\net8.0\System.Net.WebHeaderCollection.dll'
#endif
