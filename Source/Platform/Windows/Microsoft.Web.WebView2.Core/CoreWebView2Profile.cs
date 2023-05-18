#region Assembly Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// C:\Users\ChisterWu\.nuget\packages\microsoft.web.webview2\1.0.1829-prerelease\lib\netcoreapp3.0\Microsoft.Web.WebView2.Core.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
    //
    // Summary:
    //     Multiple profiles can be created under a single user data directory but with
    //     separated cookies, user preference settings, and various data storage etc.. If
    //     the CoreWebView2 was created with a Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions,
    //     the CoreWebView2Profile will match those specified options. Otherwise if this
    //     CoreWebView2 was created without a Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions,
    //     then this will be the default CoreWebView2Profile for the corresponding CoreWebView2Environment.
    public class CoreWebView2Profile
    {
        internal ICoreWebView2Profile _nativeICoreWebView2ProfileValue;

        internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2Value;

        internal ICoreWebView2Profile3 _nativeICoreWebView2Profile3Value;

        internal ICoreWebView2Profile4 _nativeICoreWebView2Profile4Value;

        internal ICoreWebView2Profile5 _nativeICoreWebView2Profile5Value;

        internal ICoreWebView2Profile6 _nativeICoreWebView2Profile6Value;

        internal ICoreWebView2ExperimentalProfile11 _nativeICoreWebView2ExperimentalProfile11Value;

        internal ICoreWebView2ExperimentalProfile8 _nativeICoreWebView2ExperimentalProfile8Value;

        internal ICoreWebView2ExperimentalProfile7 _nativeICoreWebView2ExperimentalProfile7Value;

        internal ICoreWebView2ExperimentalProfile6 _nativeICoreWebView2ExperimentalProfile6Value;

        internal ICoreWebView2ExperimentalProfile5 _nativeICoreWebView2ExperimentalProfile5Value;

        internal ICoreWebView2ExperimentalProfile4 _nativeICoreWebView2ExperimentalProfile4Value;

        internal ICoreWebView2ExperimentalProfile3 _nativeICoreWebView2ExperimentalProfile3Value;

        internal ICoreWebView2ExperimentalProfile2 _nativeICoreWebView2ExperimentalProfile2Value;

        internal ICoreWebView2ExperimentalProfile10 _nativeICoreWebView2ExperimentalProfile10Value;

        internal object _rawNative;

        private EventRegistrationToken _deletedToken;

        private EventHandler<object> deleted;

        internal ICoreWebView2Profile _nativeICoreWebView2Profile
        {
            get
            {
                if (_nativeICoreWebView2ProfileValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2ProfileValue = (ICoreWebView2Profile)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ProfileValue;
            }
            set
            {
                _nativeICoreWebView2ProfileValue = value;
            }
        }

        internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2
        {
            get
            {
                if (_nativeICoreWebView2Profile2Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Profile2Value = (ICoreWebView2Profile2)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Profile2Value;
            }
            set
            {
                _nativeICoreWebView2Profile2Value = value;
            }
        }

        internal ICoreWebView2Profile3 _nativeICoreWebView2Profile3
        {
            get
            {
                if (_nativeICoreWebView2Profile3Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Profile3Value = (ICoreWebView2Profile3)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Profile3Value;
            }
            set
            {
                _nativeICoreWebView2Profile3Value = value;
            }
        }

        internal ICoreWebView2Profile4 _nativeICoreWebView2Profile4
        {
            get
            {
                if (_nativeICoreWebView2Profile4Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Profile4Value = (ICoreWebView2Profile4)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Profile4Value;
            }
            set
            {
                _nativeICoreWebView2Profile4Value = value;
            }
        }

        internal ICoreWebView2Profile5 _nativeICoreWebView2Profile5
        {
            get
            {
                if (_nativeICoreWebView2Profile5Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Profile5Value = (ICoreWebView2Profile5)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Profile5Value;
            }
            set
            {
                _nativeICoreWebView2Profile5Value = value;
            }
        }

        internal ICoreWebView2Profile6 _nativeICoreWebView2Profile6
        {
            get
            {
                if (_nativeICoreWebView2Profile6Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Profile6Value = (ICoreWebView2Profile6)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Profile6Value;
            }
            set
            {
                _nativeICoreWebView2Profile6Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile11 _nativeICoreWebView2ExperimentalProfile11
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile11Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile11Value = (ICoreWebView2ExperimentalProfile11)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile11Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile11Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile8 _nativeICoreWebView2ExperimentalProfile8
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile8Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile8Value = (ICoreWebView2ExperimentalProfile8)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile8Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile8Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile7 _nativeICoreWebView2ExperimentalProfile7
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile7Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile7Value = (ICoreWebView2ExperimentalProfile7)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile7Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile7Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile6 _nativeICoreWebView2ExperimentalProfile6
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile6Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile6Value = (ICoreWebView2ExperimentalProfile6)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile6Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile6Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile5 _nativeICoreWebView2ExperimentalProfile5
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile5Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile5Value = (ICoreWebView2ExperimentalProfile5)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile5Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile5Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile4 _nativeICoreWebView2ExperimentalProfile4
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile4Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile4Value = (ICoreWebView2ExperimentalProfile4)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile4Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile4Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile3 _nativeICoreWebView2ExperimentalProfile3
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile3Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile3Value = (ICoreWebView2ExperimentalProfile3)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile3Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile3Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile2 _nativeICoreWebView2ExperimentalProfile2
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile2Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile2Value = (ICoreWebView2ExperimentalProfile2)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile2Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile2Value = value;
            }
        }

        internal ICoreWebView2ExperimentalProfile10 _nativeICoreWebView2ExperimentalProfile10
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalProfile10Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile10Value = (ICoreWebView2ExperimentalProfile10)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalProfile10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalProfile10Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalProfile10Value = value;
            }
        }

        //
        // Summary:
        //     The name of the profile.
        public string ProfileName
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Profile.ProfileName;
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
        //     InPrivate mode is enabled or not.
        public bool IsInPrivateModeEnabled
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Profile.IsInPrivateModeEnabled != 0;
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
        //     Full path of the profile directory.
        public string ProfilePath
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Profile.ProfilePath;
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
        //     The default download folder path.
        //
        // Remarks:
        //     The default value is the system default download folder path for the user. The
        //     default download folder path is persisted in the user data folder across sessions.
        //     The value should be an absolute path to a folder that the user and application
        //     can write to. Throws an exception if the value is invalid, and the default download
        //     path is not changed. Otherwise the path is changed immediately. If the directory
        //     does not yet exist, it is created at the time of the next download. If the host
        //     application does not have permission to create the directory, then the user is
        //     prompted to provide a new path through the Save As dialog. The user can override
        //     the default download folder path for a given download by choosing a different
        //     path in the Save As dialog.
        public string DefaultDownloadFolderPath
        {
            get
            {
                try
                {
                    try
                    {
                        return _nativeICoreWebView2Profile.DefaultDownloadFolderPath;
                    }
                    catch (NotImplementedException)
                    {
                        return _nativeICoreWebView2ExperimentalProfile3.DefaultDownloadFolderPath;
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
            set
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Profile.DefaultDownloadFolderPath = value;
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalProfile3.DefaultDownloadFolderPath = value;
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
        //     The PreferredColorScheme property sets the overall color scheme of the WebView2s
        //     associated with this profile.
        //
        // Remarks:
        //     This sets the color scheme for WebView2 UI like dialogs, prompts, and menus by
        //     setting the media feature prefers-color-scheme. The default value for this is
        //     Microsoft.Web.WebView2.Core.CoreWebView2PreferredColorScheme.Auto, which will
        //     follow whatever color scheme the OS is currently set to.
        public CoreWebView2PreferredColorScheme PreferredColorScheme
        {
            get
            {
                try
                {
                    try
                    {
                        return (CoreWebView2PreferredColorScheme)_nativeICoreWebView2Profile.PreferredColorScheme;
                    }
                    catch (NotImplementedException)
                    {
                        return (CoreWebView2PreferredColorScheme)_nativeICoreWebView2ExperimentalProfile2.PreferredColorScheme;
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
            set
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Profile.PreferredColorScheme = (COREWEBVIEW2_PREFERRED_COLOR_SCHEME)value;
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalProfile2.PreferredColorScheme = (COREWEBVIEW2_PREFERRED_COLOR_SCHEME)value;
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
        //     The PreferredTrackingPreventionLevel property allows you to control levels of
        //     tracking prevention for WebView2 which are associated with a profile. This level
        //     would apply to the context of the profile. That is, all WebView2s sharing the
        //     same profile will be affected and also the value is persisted in the user data
        //     folder.
        //
        // Remarks:
        //     If tracking prevention feature is enabled when creating the WebView2 environment,
        //     you can also disable tracking prevention later using this property and Microsoft.Web.WebView2.Core.CoreWebView2TrackingPreventionLevel.None
        //     value but that doesn't improves runtime performance. There is Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.EnableTrackingPrevention
        //     property to enable/disable tracking prevention feature for all the WebView2's
        //     created in the same environment. If enabled, PreferredTrackingPreventionLevel
        //     is set to Microsoft.Web.WebView2.Core.CoreWebView2TrackingPreventionLevel.Balanced
        //     by default for all the WebView2's and profiles created in the same environment
        //     or is set to the level whatever value was last changed/persisted to the profile.
        //     If disabled PreferredTrackingPreventionLevel is not respected by WebView2. If
        //     PreferredTrackingPreventionLevel is set when the feature is disabled, the property
        //     value get changed and persisted but it will takes effect only if Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.EnableTrackingPrevention
        //     is true. See Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.EnableTrackingPrevention
        //     for more details.
        public CoreWebView2TrackingPreventionLevel PreferredTrackingPreventionLevel
        {
            get
            {
                try
                {
                    try
                    {
                        return (CoreWebView2TrackingPreventionLevel)_nativeICoreWebView2Profile3.PreferredTrackingPreventionLevel;
                    }
                    catch (NotImplementedException)
                    {
                        return (CoreWebView2TrackingPreventionLevel)_nativeICoreWebView2ExperimentalProfile5.PreferredTrackingPreventionLevel;
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
            set
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Profile3.PreferredTrackingPreventionLevel = (COREWEBVIEW2_TRACKING_PREVENTION_LEVEL)value;
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalProfile5.PreferredTrackingPreventionLevel = (COREWEBVIEW2_TRACKING_PREVENTION_LEVEL)value;
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
        //     Get the Microsoft.Web.WebView2.Core.CoreWebView2CookieManager which Creates,
        //     adds or updates, gets, or or view the cookies for the current profile.
        //
        // Remarks:
        //     All CoreWebView2s associated with this profile share the same cookie values.
        //     Changes to cookies in this cookie manager apply to all CoreWebView2s associated
        //     with this profile.
        public CoreWebView2CookieManager CookieManager
        {
            get
            {
                try
                {
                    try
                    {
                        return (_nativeICoreWebView2Profile5.CookieManager == null) ? null : new CoreWebView2CookieManager(_nativeICoreWebView2Profile5.CookieManager);
                    }
                    catch (NotImplementedException)
                    {
                        return (_nativeICoreWebView2ExperimentalProfile8.CookieManager == null) ? null : new CoreWebView2CookieManager(_nativeICoreWebView2ExperimentalProfile8.CookieManager);
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
        //     Determines whether password information will be autosaved.
        //
        // Remarks:
        //     When disabled, no new password data is saved and no Save/Update Password prompts
        //     are displayed. However, if there was password data already saved before disabling
        //     this setting, then that password information is auto-populated, suggestions are
        //     shown and clicking on one will populate the fields. When enabled, password information
        //     is auto-populated, suggestions are shown and clicking on one will populate the
        //     fields, new data is saved, and a Save/Update Password prompt is displayed. The
        //     default value is false. It will apply immediately after setting. This property
        //     has the same value as Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsPasswordAutosaveEnabled,
        //     and changing one will change the other. All WebView2s with the same Microsoft.Web.WebView2.Core.CoreWebView2Profile
        //     will share the same value for this property, so for the WebView2s with the same
        //     profile, their Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsPasswordAutosaveEnabled
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsPasswordAutosaveEnabled
        //     will always have the same value.
        public bool IsPasswordAutosaveEnabled
        {
            get
            {
                try
                {
                    try
                    {
                        return _nativeICoreWebView2Profile6.IsPasswordAutosaveEnabled != 0;
                    }
                    catch (NotImplementedException)
                    {
                        return _nativeICoreWebView2ExperimentalProfile11.IsPasswordAutosaveEnabled != 0;
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
            set
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Profile6.IsPasswordAutosaveEnabled = (value ? 1 : 0);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalProfile11.IsPasswordAutosaveEnabled = (value ? 1 : 0);
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
        //     Determines whether general form information will be saved and autofilled.
        //
        // Remarks:
        //     General autofill information includes information like names, street and email
        //     addresses, phone numbers, and arbitrary input. This excludes password information.
        //     When disabled, no suggestions appear, and no new information is saved. When enabled,
        //     information is saved, suggestions appear, and clicking on one will populate the
        //     form fields. The default value is true. It will apply immediately after setting.
        //     This property has the same value as Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsGeneralAutofillEnabled,
        //     and changing one will change the other. All WebView2s with the same Microsoft.Web.WebView2.Core.CoreWebView2Profile
        //     will share the same value for this property, so for the WebView2s with the same
        //     profile, their Microsoft.Web.WebView2.Core.CoreWebView2Settings.IsGeneralAutofillEnabled
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsGeneralAutofillEnabled
        //     will always have the same value.
        public bool IsGeneralAutofillEnabled
        {
            get
            {
                try
                {
                    try
                    {
                        return _nativeICoreWebView2Profile6.IsGeneralAutofillEnabled != 0;
                    }
                    catch (NotImplementedException)
                    {
                        return _nativeICoreWebView2ExperimentalProfile11.IsGeneralAutofillEnabled != 0;
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
            set
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Profile6.IsGeneralAutofillEnabled = (value ? 1 : 0);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalProfile11.IsGeneralAutofillEnabled = (value ? 1 : 0);
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
        //     Raised when profile is marked for deletion.
        //
        // Remarks:
        //     When this event is raised, the CoreWebView2Profile and its corresponding CoreWebView2s
        //     have been closed, and cannot be used anymore.
        public event EventHandler<object> Deleted
        {
            add
            {
                if (deleted == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalProfile10.add_Deleted(new CoreWebView2ExperimentalProfileDeletedEventHandler(OnDeleted), out _deletedToken);
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

                deleted = (EventHandler<object>)Delegate.Combine(deleted, value);
            }
            remove
            {
                deleted = (EventHandler<object>)Delegate.Remove(deleted, value);
                if (deleted != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2ExperimentalProfile10.remove_Deleted(_deletedToken);
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
        //     Clear the browsing data for the specified dataKinds between the startTime and
        //     endTime. Overload the ClearBrowsingDataAsync method to allow for additional time
        //     parameters.
        public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTime startTime, DateTime endTime)
        {
            CoreWebView2ClearBrowsingDataCompletedHandler handler;
            try
            {
                double startTime2 = new DateTimeOffset(startTime).ToUnixTimeSeconds();
                double endTime2 = new DateTimeOffset(endTime).ToUnixTimeSeconds();
                handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
                _nativeICoreWebView2Profile2.ClearBrowsingDataInTimeRange((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, startTime2, endTime2, handler);
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
        //     Clear the entirety of the browsing data associated with the profile it is called
        //     on. It clears the data regardless of timestamp.
        public async Task ClearBrowsingDataAsync()
        {
            CoreWebView2ClearBrowsingDataCompletedHandler handler;
            try
            {
                handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
                _nativeICoreWebView2Profile2.ClearBrowsingDataAll(handler);
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

        internal CoreWebView2Profile(object rawCoreWebView2Profile)
        {
            _rawNative = rawCoreWebView2Profile;
        }

        //
        // Summary:
        //     Clear the browsing data of the associated profile.
        //
        // Remarks:
        //     Clears browsing data on the profile the method is called on. Additional optional
        //     parameters include the start time and end time to clear the browsing data between
        //     as well as the data specific data kinds to clear on the profile. The method may
        //     be overloaded to take:
        //     • No parameters - in which the entirety of the data on the profile will be cleared.
        //     • The data kind(s) - in which the data kind(s) will be cleared for their entirety.
        //     • The data kind(s), start time, and end time - in which the data kind(s) will
        //     be cleared between the start and end time. The start time will be offset by -1.0
        //     and the end time will be offset by +1.0 to include the last fractional second
        //     on each respective end. The start time is inclusive in the time period while
        //     the end time is exclusive.
        //     The exposed methods are as follows:
        //     ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds);
        //     ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTime startTime,
        //     DateTime endTime);
        //     ClearBrowsingDataAsync();
        public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds)
        {
            CoreWebView2ClearBrowsingDataCompletedHandler handler;
            try
            {
                try
                {
                    handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
                    _nativeICoreWebView2Profile2.ClearBrowsingData((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, handler);
                }
                catch (NotImplementedException)
                {
                    handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
                    _nativeICoreWebView2ExperimentalProfile4.ClearBrowsingData((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, handler);
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
        }

        //
        // Summary:
        //     Sets permission state for the given permission kind and origin asynchronously.
        //
        // Remarks:
        //     The state change persists across sessions until it is changed by another call
        //     to SetPermissionState, or by setting the State property in PermissionRequestedEventArgs.
        //     Setting the state to Microsoft.Web.WebView2.Core.CoreWebView2PermissionState.Default
        //     will erase any state saved in the profile and restore the default behavior. The
        //     origin should have a valid scheme and host (e.g. "https://www.example.com"),
        //     otherwise the method fails. Additional URI parts like path and fragment are ignored.
        //     For example, "https://wwww.example.com/app1/index.html/" is treated the same
        //     as "https://wwww.example.com". See the [MDN origin definition](https://developer.mozilla.org/docs/Glossary/Origin)
        //     for more details.
        public async Task SetPermissionStateAsync(CoreWebView2PermissionKind PermissionKind, string origin, CoreWebView2PermissionState State)
        {
            CoreWebView2SetPermissionStateCompletedHandler handler;
            try
            {
                try
                {
                    handler = new CoreWebView2SetPermissionStateCompletedHandler();
                    _nativeICoreWebView2Profile4.SetPermissionState((COREWEBVIEW2_PERMISSION_KIND)PermissionKind, origin, (COREWEBVIEW2_PERMISSION_STATE)State, handler);
                }
                catch (NotImplementedException)
                {
                    handler = new CoreWebView2SetPermissionStateCompletedHandler();
                    _nativeICoreWebView2ExperimentalProfile6.SetPermissionState((COREWEBVIEW2_PERMISSION_KIND)PermissionKind, origin, (COREWEBVIEW2_PERMISSION_STATE)State, handler);
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
        }

        //
        // Summary:
        //     Invokes the handler with a collection of all nondefault permission settings.
        //
        // Remarks:
        //     Use this method to get the permission state set in the current and previous sessions.
        public async Task<IReadOnlyList<CoreWebView2PermissionSetting>> GetNonDefaultPermissionSettingsAsync()
        {
            CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler handler;
            try
            {
                try
                {
                    handler = new CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler();
                    _nativeICoreWebView2Profile4.GetNonDefaultPermissionSettings(handler);
                }
                catch (NotImplementedException)
                {
                    handler = new CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler();
                    _nativeICoreWebView2ExperimentalProfile6.GetNonDefaultPermissionSettings(handler);
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
            return handler.collectionView;
        }

        //
        // Summary:
        //     Clears all DOM storage and cookies in the specified custom data partition.
        //
        // Parameters:
        //   CustomDataPartitionId:
        //     The id of the custom data partition. If null or empty string is specified, System.ArgumentException
        //     will be thrown.
        //
        // Remarks:
        //     Clears all DOM storage and cookies in the custom data partition identified by
        //     the CustomDataPartitionId. If no partition is found for the specified CustomDataPartitionId,
        //     the API succeeds without doing anything.
        //     As DOM storage and cookies in the custom data partition is also browsing data,
        //     they will also be cleared when Microsoft.Web.WebView2.Core.CoreWebView2Profile.ClearBrowsingDataAsync,
        //     Microsoft.Web.WebView2.Core.CoreWebView2Profile.ClearBrowsingDataAsync(Microsoft.Web.WebView2.Core.CoreWebView2BrowsingDataKinds)
        //     or Microsoft.Web.WebView2.Core.CoreWebView2Profile.ClearBrowsingDataAsync(Microsoft.Web.WebView2.Core.CoreWebView2BrowsingDataKinds,System.DateTime,System.DateTime)
        //     is called and the clearing condition is met.
        public async Task ClearCustomDataPartitionAsync(string CustomDataPartitionId)
        {
            CoreWebView2ClearCustomDataPartitionCompletedHandler handler;
            try
            {
                handler = new CoreWebView2ClearCustomDataPartitionCompletedHandler();
                _nativeICoreWebView2ExperimentalProfile7.ClearCustomDataPartition(CustomDataPartitionId, handler);
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

        internal void OnDeleted(object args)
        {
            deleted?.Invoke(this, args);
        }

        //
        // Summary:
        //     Delete this profile.
        //
        // Remarks:
        //     After the API is called, the profile will be marked for deletion. The local profile's
        //     directory will be deleted at browser process exit. If it fails to delete, because
        //     something else is holding the files open, WebView2 will try to delete the profile
        //     at all future browser process starts until successful. The corresponding CoreWebView2s
        //     will be closed and the CoreWebView2Profile.Deleted event will be raised. See
        //     `CoreWebView2Profile.Deleted` for more information. If you try to create a new
        //     profile with the same name as an existing profile that has been marked as deleted
        //     but hasn't yet been deleted, profile creation will fail with HRESULT_FROM_WIN32(ERROR_DELETE_PENDING).
        public void Delete()
        {
            try
            {
                _nativeICoreWebView2ExperimentalProfile10.Delete();
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
