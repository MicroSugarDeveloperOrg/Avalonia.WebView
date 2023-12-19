#region Assembly Microsoft.Web.WebView2.Core, Version=1.0.2210.55, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// C:\Users\ChisterWu\.nuget\packages\microsoft.web.webview2\1.0.2210.55\lib\netcoreapp3.0\Microsoft.Web.WebView2.Core.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using Microsoft.Web.WebView2.Core.Raw;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Web.WebView2.Core;

//
// Summary:
//     This represents the WebView2 Environment.
//
// Remarks:
//     WebViews created from an environment run on the Browser process specified with
//     environment parameters and objects created from an environment should be used
//     in the same environment. Using it in different environments are not guaranteed
//     to be compatible and may fail.
public class CoreWebView2Environment
{
    private enum ProcessorArchitecture : ushort
    {
        x86 = 0,
        x64 = 9,
        ARM64 = 12,
        Unknown = ushort.MaxValue
    }

    private struct SYSTEM_INFO
    {
        internal ushort wProcessorArchitecture;

        private ushort wReserved;

        private int dwPageSize;

        private IntPtr lpMinimumApplicationAddress;

        private IntPtr lpMaximumApplicationAddress;

        private IntPtr dwActiveProcessorMask;

        private int dwNumberOfProcessors;

        private int dwProcessorType;

        private int dwAllocationGranularity;

        private short wProcessorLevel;

        private short wProcessorRevision;
    }

    private const char DirectorySeparatorChar = '\\';

    private const char AltDirectorySeparatorChar = '/';

    private const char VolumeSeparatorChar = ':';

    private static bool webView2LoaderLoaded;

    private static string loaderDllFolderPath;

    internal ICoreWebView2Environment _nativeICoreWebView2EnvironmentValue;

    internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2Value;

    internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3Value;

    internal ICoreWebView2Environment4 _nativeICoreWebView2Environment4Value;

    internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5Value;

    internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6Value;

    internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7Value;

    internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8Value;

    internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9Value;

    internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10Value;

    internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11Value;

    internal ICoreWebView2Environment12 _nativeICoreWebView2Environment12Value;

    internal ICoreWebView2Environment13 _nativeICoreWebView2Environment13Value;

    internal object _rawNative;

    private EventRegistrationToken _newBrowserVersionAvailableToken;

    private EventHandler<object> newBrowserVersionAvailable;

    private EventRegistrationToken _browserProcessExitedToken;

    private EventHandler<CoreWebView2BrowserProcessExitedEventArgs> browserProcessExited;

    private EventRegistrationToken _processInfosChangedToken;

    private EventHandler<object> processInfosChanged;

    internal ICoreWebView2Environment _nativeICoreWebView2Environment
    {
        get
        {
            if (_nativeICoreWebView2EnvironmentValue == null)
            {
                try
                {
                    _nativeICoreWebView2EnvironmentValue = (ICoreWebView2Environment)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2EnvironmentValue;
        }
        set
        {
            _nativeICoreWebView2EnvironmentValue = value;
        }
    }

    internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2
    {
        get
        {
            if (_nativeICoreWebView2Environment2Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment2Value = (ICoreWebView2Environment2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment2Value;
        }
        set
        {
            _nativeICoreWebView2Environment2Value = value;
        }
    }

    internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3
    {
        get
        {
            if (_nativeICoreWebView2Environment3Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment3Value = (ICoreWebView2Environment3)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment3Value;
        }
        set
        {
            _nativeICoreWebView2Environment3Value = value;
        }
    }

    internal ICoreWebView2Environment4 _nativeICoreWebView2Environment4
    {
        get
        {
            if (_nativeICoreWebView2Environment4Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment4Value = (ICoreWebView2Environment4)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment4Value;
        }
        set
        {
            _nativeICoreWebView2Environment4Value = value;
        }
    }

    internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5
    {
        get
        {
            if (_nativeICoreWebView2Environment5Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment5Value = (ICoreWebView2Environment5)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment5Value;
        }
        set
        {
            _nativeICoreWebView2Environment5Value = value;
        }
    }

    internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6
    {
        get
        {
            if (_nativeICoreWebView2Environment6Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment6Value = (ICoreWebView2Environment6)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment6Value;
        }
        set
        {
            _nativeICoreWebView2Environment6Value = value;
        }
    }

    internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7
    {
        get
        {
            if (_nativeICoreWebView2Environment7Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment7Value = (ICoreWebView2Environment7)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment7Value;
        }
        set
        {
            _nativeICoreWebView2Environment7Value = value;
        }
    }

    internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8
    {
        get
        {
            if (_nativeICoreWebView2Environment8Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment8Value = (ICoreWebView2Environment8)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment8Value;
        }
        set
        {
            _nativeICoreWebView2Environment8Value = value;
        }
    }

    internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9
    {
        get
        {
            if (_nativeICoreWebView2Environment9Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment9Value = (ICoreWebView2Environment9)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment9Value;
        }
        set
        {
            _nativeICoreWebView2Environment9Value = value;
        }
    }

    internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10
    {
        get
        {
            if (_nativeICoreWebView2Environment10Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment10Value = (ICoreWebView2Environment10)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment10Value;
        }
        set
        {
            _nativeICoreWebView2Environment10Value = value;
        }
    }

    internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11
    {
        get
        {
            if (_nativeICoreWebView2Environment11Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment11Value = (ICoreWebView2Environment11)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment11Value;
        }
        set
        {
            _nativeICoreWebView2Environment11Value = value;
        }
    }

    internal ICoreWebView2Environment12 _nativeICoreWebView2Environment12
    {
        get
        {
            if (_nativeICoreWebView2Environment12Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment12Value = (ICoreWebView2Environment12)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment12Value;
        }
        set
        {
            _nativeICoreWebView2Environment12Value = value;
        }
    }

    internal ICoreWebView2Environment13 _nativeICoreWebView2Environment13
    {
        get
        {
            if (_nativeICoreWebView2Environment13Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment13Value = (ICoreWebView2Environment13)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }

            return _nativeICoreWebView2Environment13Value;
        }
        set
        {
            _nativeICoreWebView2Environment13Value = value;
        }
    }

    //
    // Summary:
    //     Gets the browser version info of the current Microsoft.Web.WebView2.Core.CoreWebView2Environment,
    //     including channel name if it is not the stable channel.
    //
    // Remarks:
    //     It matches the format of the Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetAvailableBrowserVersionString(System.String)
    //     method. Channel names are beta, dev, and canary.
    public string BrowserVersionString
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Environment.BrowserVersionString;
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
    //     Gets the user data folder that all CoreWebView2s created from this environment
    //     are using.
    //
    // Remarks:
    //     This could be either the value passed in by the developer when creating the environment
    //     object or the calculated one for default handling. And will always be an absolute
    //     path.
    public string UserDataFolder
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Environment7.UserDataFolder;
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
    //     Gets the failure report folder that all CoreWebView2s created from this environment
    //     are using.
    public string FailureReportFolderPath
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Environment11.FailureReportFolderPath;
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
    //     NewBrowserVersionAvailable is raised when a newer version of the WebView2 Runtime
    //     is installed and available using WebView2.
    //
    // Remarks:
    //     To use the newer version of the browser you must create a new environment and
    //     WebView. The event is only raised for new version from the same WebView2 Runtime
    //     from which the code is running. When not running with installed WebView2 Runtime,
    //     no event is raised. Because a user data folder is only able to be used by one
    //     browser process at a time, if you want to use the same user data folder in the
    //     WebViews using the new version of the browser, you must close the environment
    //     and instance of WebView that are using the older version of the browser first.
    //     Or simply prompt the user to restart the app.
    public event EventHandler<object> NewBrowserVersionAvailable
    {
        add
        {
            if (newBrowserVersionAvailable == null)
            {
                try
                {
                    _nativeICoreWebView2Environment.add_NewBrowserVersionAvailable(new CoreWebView2NewBrowserVersionAvailableEventHandler(OnNewBrowserVersionAvailable), out _newBrowserVersionAvailableToken);
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

            newBrowserVersionAvailable = (EventHandler<object>)Delegate.Combine(newBrowserVersionAvailable, value);
        }
        remove
        {
            newBrowserVersionAvailable = (EventHandler<object>)Delegate.Remove(newBrowserVersionAvailable, value);
            if (newBrowserVersionAvailable != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2Environment.remove_NewBrowserVersionAvailable(_newBrowserVersionAvailableToken);
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
    //     BrowserProcessExited is raised when the collection of WebView2 Runtime processes
    //     for the browser process of this Microsoft.Web.WebView2.Core.CoreWebView2Environment
    //     terminate due to browser process failure or normal shutdown (for example, when
    //     all associated WebViews are closed), after all resources have been released (including
    //     the user data folder).
    //
    // Remarks:
    //     Multiple app processes can share a browser process by creating their webviews
    //     from a Microsoft.Web.WebView2.Core.CoreWebView2Environment with the same user
    //     data folder. When the entire collection of WebView2Runtime processes for the
    //     browser process exit, all associated Microsoft.Web.WebView2.Core.CoreWebView2Environment
    //     objects receive the BrowserProcessExited event. Multiple processes sharing the
    //     same browser process need to coordinate their use of the shared user data folder
    //     to avoid race conditions and unnecessary waits. For example, one process should
    //     not clear the user data folder at the same time that another process recovers
    //     from a crash by recreating its WebView controls; one process should not block
    //     waiting for the event if other app processes are using the same browser process
    //     (the browser process will not exit until those other processes have closed their
    //     webviews too). Note this is an event from Microsoft.Web.WebView2.Core.CoreWebView2Environment,
    //     not Microsoft.Web.WebView2.Core.CoreWebView2. The difference between BrowserProcessExited
    //     and Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed is that BrowserProcessExited
    //     is raised for any browser process exit (expected or unexpected, after all associated
    //     processes have exited too), while Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed
    //     is raised for unexpected process exits of any kind (browser, render, GPU, and
    //     all other types), or for main frame render process unresponsiveness. To learn
    //     more about the WebView2 Process Model, go to [Process model](/microsoft-edge/webview2/concepts/process-model).
    //     In the case the browser process crashes, both BrowserProcessExited and Microsoft.Web.WebView2.Core.CoreWebView2.ProcessFailed
    //     events are raised, but the order is not guaranteed. These events are intended
    //     for different scenarios. It is up to the app to coordinate the handlers so they
    //     do not try to perform reliability recovery while also trying to move to a new
    //     WebView2 Runtime version or remove the user data folder.
    public event EventHandler<CoreWebView2BrowserProcessExitedEventArgs> BrowserProcessExited
    {
        add
        {
            if (browserProcessExited == null)
            {
                try
                {
                    _nativeICoreWebView2Environment5.add_BrowserProcessExited(new CoreWebView2BrowserProcessExitedEventHandler(OnBrowserProcessExited), out _browserProcessExitedToken);
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

            browserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Combine(browserProcessExited, value);
        }
        remove
        {
            browserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Remove(browserProcessExited, value);
            if (browserProcessExited != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2Environment5.remove_BrowserProcessExited(_browserProcessExitedToken);
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
    //     ProcessInfosChanged is raised when a collection of WebView2 Runtime processes
    //     changed due to new process being detected or when a existing process gone away.
    public event EventHandler<object> ProcessInfosChanged
    {
        add
        {
            if (processInfosChanged == null)
            {
                try
                {
                    _nativeICoreWebView2Environment8.add_ProcessInfosChanged(new CoreWebView2ProcessInfosChangedEventHandler(OnProcessInfosChanged), out _processInfosChangedToken);
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

            processInfosChanged = (EventHandler<object>)Delegate.Combine(processInfosChanged, value);
        }
        remove
        {
            processInfosChanged = (EventHandler<object>)Delegate.Remove(processInfosChanged, value);
            if (processInfosChanged != null)
            {
                return;
            }

            try
            {
                _nativeICoreWebView2Environment8.remove_ProcessInfosChanged(_processInfosChangedToken);
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

    [DllImport("WebView2Loader.dll")]
    internal static extern int CreateCoreWebView2EnvironmentWithOptions([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, [In][MarshalAs(UnmanagedType.LPWStr)] string userDataFolder, ICoreWebView2EnvironmentOptions options, ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environment_created_handler);

    [DllImport("WebView2Loader.dll")]
    internal static extern int GetAvailableCoreWebView2BrowserVersionString([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, [MarshalAs(UnmanagedType.LPWStr)] ref string versionInfo);

    [DllImport("WebView2Loader.dll")]
    internal static extern int CompareBrowserVersions([In][MarshalAs(UnmanagedType.LPWStr)] string version1, [In][MarshalAs(UnmanagedType.LPWStr)] string version2, ref int result);

    //
    // Summary:
    //     Creates a WebView2 Environment using the installed or a custom WebView2 Runtime
    //     version.
    //
    // Parameters:
    //   browserExecutableFolder:
    //     The relative path to the folder that contains a custom version of WebView2 Runtime.
    //
    //
    //     To use a fixed version of the WebView2 Runtime, pass the folder path that contains
    //     the fixed version of the WebView2 Runtime to browserExecutableFolder. BrowserExecutableFolder
    //     supports both relative (to the application's executable) and absolute file paths.
    //     To create WebView2 controls that use the installed version of the WebView2 Runtime
    //     that exists on user machines, pass a null or empty string to browserExecutableFolder.
    //     In this scenario, the API tries to find a compatible version of the WebView2
    //     Runtime that is installed on the user machine (first at the machine level, and
    //     then per user) using the selected channel preference. The path of fixed version
    //     of the WebView2 Runtime should not contain \Edge\Application\. When such a path
    //     is used, the API fails with ERROR_NOT_SUPPORTED.
    //
    //   userDataFolder:
    //     The user data folder location for WebView2.
    //
    //     The path is either an absolute file path or a relative file path that is interpreted
    //     as relative to the compiled code for the current process. The default user data
    //     folder {Executable File Name}.WebView2 is created in the same directory next
    //     to the compiled code for the app. WebView2 creation fails if the compiled code
    //     is running in a directory in which the process does not have permission to create
    //     a new directory. The app is responsible to clean up the associated user data
    //     folder when it is done.
    //
    //   options:
    //     Options used to create WebView2 Environment.
    //
    //     As a browser process may be shared among WebViews, WebView creation fails if
    //     the specified options does not match the options of the WebViews that are currently
    //     running in the shared browser process.
    //
    // Remarks:
    //     The default channel search order is the WebView2 Runtime, Beta, Dev, and Canary.
    //     When an override WEBVIEW2_RELEASE_CHANNEL_PREFERENCE environment variable or
    //     applicable releaseChannelPreference registry value is set to 1, the channel search
    //     order is reversed.
    //
    //     To use a fixed version of the WebView2 Runtime, pass the relative folder path
    //     that contains the fixed version of the WebView2 Runtime to browserExecutableFolder.
    //     To create WebView2 controls that use the installed version of the WebView2 Runtime
    //     that exists on user machines, pass a null or empty string to browserExecutableFolder.
    //     In this scenario, the API tries to find a compatible version of the WebView2
    //     Runtime that is installed on the user machine (first at the machine level, and
    //     then per user) using the selected channel preference. The path of fixed version
    //     of the WebView2 Runtime should not contain \Edge\Application\. When such a path
    //     is used, the API fails with the following error.
    //
    //     The browserExecutableFolder, userDataFolder, and options may be overridden by
    //     values either specified in environment variables or in the registry.
    //
    //     When creating a Microsoft.Web.WebView2.Core.CoreWebView2Environment the following
    //     environment variables are verified.
    //
    //     • WEBVIEW2_BROWSER_EXECUTABLE_FOLDER –
    //     • WEBVIEW2_USER_DATA_FOLDER –
    //     • WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS –
    //     • WEBVIEW2_RELEASE_CHANNEL_PREFERENCE –
    //
    //     If browser executable folder or user data folder is specified in an environment
    //     variable or in the registry, the specified browserExecutableFolder or userDataFolder
    //     values are overridden. If additional browser arguments are specified in an environment
    //     variable or in the registry, it is appended to the corresponding value in the
    //     specified options.
    //
    //     While not strictly overrides, additional environment variables may be set.
    //
    //     Value – Description
    //     WEBVIEW2_WAIT_FOR_SCRIPT_DEBUGGER – When found with a non-empty value, this indicates
    //     that the WebView is being launched under a script debugger. In this case, the
    //     WebView issues a Page.waitForDebugger CDP command that runs the script inside
    //     the WebView to pause on launch, until a debugger issues a corresponding Runtime.runIfWaitingForDebugger
    //     CDP command to resume the runtime. Note that this environment variable does not
    //     have a registry key equivalent.
    //     WEBVIEW2_PIPE_FOR_SCRIPT_DEBUGGER – When found with a non-empty value, it indicates
    //     that the WebView is being launched under a script debugger that also supports
    //     host apps that use multiple WebViews. The value is used as the identifier for
    //     a named pipe that is opened and written to when a new WebView is created by the
    //     host app. The payload should match the payload of the remote-debugging-port JSON
    //     target and an external debugger may use it to attach to a specific WebView instance.
    //     The format of the pipe created by the debugger should be \\.\pipe\WebView2\Debugger\{app_name}\{pipe_name},
    //     where the following are true.
    //
    //     • {app_name} is the host app exe file name, for example, WebView2Example.exe
    //
    //     • {pipe_name} is the value set for WEBVIEW2_PIPE_FOR_SCRIPT_DEBUGGER
    //
    //     To enable debugging of the targets identified by the JSON, you must set the WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS
    //     environment variable to send --remote-debugging-port={port_num}, where the following
    //     is true.
    //
    //     • {port_num} is the port on which the CDP server binds.
    //
    //     If both WEBVIEW2_PIPE_FOR_SCRIPT_DEBUGGER and WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS
    //     environment variables, the WebViews hosted in your app and associated contents
    //     may exposed to 3rd party apps such as debuggers. Note that this environment variable
    //     does not have a registry key equivalent.
    //
    //     If none of those environment variables exist, then the registry is examined next.
    //
    //
    //     • [{Root}]\Software\Policies\Microsoft\Edge\WebView2\BrowserExecutableFolder
    //     "{AppId}"="" –
    //     • [{Root}]\Software\Policies\Microsoft\Edge\WebView2\ReleaseChannelPreference
    //     "{AppId}"="" –
    //     • [{Root}]\Software\Policies\Microsoft\Edge\WebView2\AdditionalBrowserArguments
    //     "{AppId}"="" –
    //     • [{Root}]\Software\Policies\Microsoft\Edge\WebView2\UserDataFolder "{AppId}"=""
    //     –
    //
    //     Use a group policy under Administrative Templates > Microsoft Edge WebView2 to
    //     configure browser executable folder and release channel preference.
    //
    //     Value – Description
    //     ERROR_DISK_FULL – In the unlikely scenario where some instances of WebView are
    //     open during a browser update, the deletion of the previous WebView2 Runtime may
    //     be blocked. To avoid running out of disk space, a new WebView creation fails
    //     with this error if it detects that too many previous WebView2 Runtime versions
    //     exist.
    //     COREWEBVIEW2_MAX_INSTANCES – The default maximum number of WebView2 Runtime versions
    //     allowed is 20. To override the maximum number of the previous WebView2 Runtime
    //     versions allowed, set the value of the following environment variable.
    //     ERROR_PRODUCT_UNINSTALLED – If the Webview depends upon an installed WebView2
    //     Runtime version and it is uninstalled, any subsequent creation fails with this
    //     error.
    //
    //     First verify with Root as HKLM and then HKCU. AppId is first set to the Application
    //     User Model ID of the process, then if no corresponding registry key, the AppId
    //     is set to the compiled code name of the process, or if that is not a registry
    //     key then *. If an override registry key is found, use the browserExecutableFolder
    //     and userDataFolder registry values as replacements and append additionalBrowserArguments
    //     registry values for the corresponding values in the provided options.
    public static async Task<CoreWebView2Environment> CreateAsync(string browserExecutableFolder = null, string userDataFolder = null, CoreWebView2EnvironmentOptions options = null)
    {
        LoadWebView2LoaderDll();
        CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler handler = new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler();
        CoreWebView2EnvironmentOptions coreWebView2EnvironmentOptions = options ?? new CoreWebView2EnvironmentOptions();
        int num = CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder, coreWebView2EnvironmentOptions._nativeICoreWebView2EnvironmentOptions, handler);
        if (num == -2147024894)
        {
            throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(num));
        }

        Marshal.ThrowExceptionForHR(num);
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.createdEnvironment;
    }

    //
    // Summary:
    //     Gets the browser version info including channel name if it is not the stable
    //     channel or WebView2 Runtime.
    //
    // Parameters:
    //   browserExecutableFolder:
    //     The relative path to the folder that contains the WebView2 Runtime.
    //
    // Exceptions:
    //   T:Microsoft.Web.WebView2.Core.WebView2RuntimeNotFoundException:
    //     WebView2 Runtime installation is missing.
    public static string GetAvailableBrowserVersionString(string browserExecutableFolder = null)
    {
        LoadWebView2LoaderDll();
        string versionInfo = null;
        int availableCoreWebView2BrowserVersionString = GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, ref versionInfo);
        if (availableCoreWebView2BrowserVersionString == -2147024894)
        {
            throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(availableCoreWebView2BrowserVersionString));
        }

        Marshal.ThrowExceptionForHR(availableCoreWebView2BrowserVersionString);
        return versionInfo;
    }

    //
    // Summary:
    //     Compares two instances of browser versions correctly and returns an integer that
    //     indicates whether the first instance is older, the same as, or newer than the
    //     second instance.
    //
    // Parameters:
    //   version1:
    //     One of the version strings to compare.
    //
    //   version2:
    //     The other version string to compare.
    //
    // Returns:
    //     An integer that indicates whether the first instance is older, the same as, or
    //     newer than the second instance.
    //
    //     Value Type Condition
    //     Less than zero version1 is older than version2.
    //     Zero version1 is the same as version2.
    //     Greater than zero version1 is newer than version2.
    public static int CompareBrowserVersions(string version1, string version2)
    {
        LoadWebView2LoaderDll();
        int result = 0;
        Marshal.ThrowExceptionForHR(CompareBrowserVersions(version1, version2, ref result));
        return result;
    }

    //
    // Summary:
    //     Creates a new Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest object.
    //
    //
    // Parameters:
    //   uri:
    //     The request URI.
    //
    //   Method:
    //     The HTTP request method.
    //
    //   postData:
    //
    //   Headers:
    //     The raw request header string delimited by CRLF (optional in last header).
    //
    // Remarks:
    //     uri parameter must be absolute URI. It's also possible to create this object
    //     with null headers string and then use the Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders
    //     to construct the headers line by line.
    public CoreWebView2WebResourceRequest CreateWebResourceRequest(string uri, string Method, Stream postData, string Headers)
    {
        return new CoreWebView2WebResourceRequest(_nativeICoreWebView2Environment2.CreateWebResourceRequest(uri, Method, (postData == null) ? null : new ManagedIStream(postData), Headers));
    }

    //
    // Summary:
    //     Creates a new Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions object,
    //     which can be passed as a parameter in Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)
    //     and Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2CompositionControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)
    //     function for multiple profiles support.
    //
    // Returns:
    //     A Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions that can be passed
    //     when calling Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)
    //     and Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2CompositionControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions).
    //
    //
    // Remarks:
    //     The options is a settable property while the default for profile name is an empty
    //     string and the default value for Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions.IsInPrivateModeEnabled
    //     is false. The profile will be created on disk or opened when calling CreateCoreWebView2ControllerWithOptions
    //     no matter InPrivate mode is enabled or not, and it will be released in memory
    //     when the correspoding Microsoft.Web.WebView2.Core.CoreWebView2Controller is closed
    //     but still remain on disk. As WebView2 is built on top of Edge browser, it follows
    //     Edge's behavior pattern. To create an InPrivate WebView, we get an off-the-record
    //     profile (an InPrivate profile) from a regular profile, then create the WebView
    //     with the off-the-record profile. Also the profile name can be reused.
    public CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions()
    {
        try
        {
            return new CoreWebView2ControllerOptions(_nativeICoreWebView2Environment10.CreateCoreWebView2ControllerOptions());
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
            }

            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CreateCoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex2);
            }

            throw ex2;
        }
    }

    //
    // Summary:
    //     Asynchronously creates a new Microsoft.Web.WebView2.Core.CoreWebView2Controller
    //     object.
    //
    // Parameters:
    //   ParentWindow:
    //     The HWND in which the WebView should be displayed and from which receive input.
    //
    //
    //   options:
    //     The options contains profileName and inPrivate parameters that could be used
    //     to create CoreWebView2Profile, and it can be used to create multiple WebViews
    //     with multiple profiles under a single user data directory.
    //
    // Remarks:
    //     Multiple profiles under single user data directory can share some system resources
    //     including memory, CPU footprint, disk space (such as compiled shaders and safebrowsing
    //     data) etc.
    public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
    {
        CoreWebView2CreateCoreWebView2ControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
            _nativeICoreWebView2Environment10.CreateCoreWebView2ControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, handler);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
            }

            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CreateCoreWebView2ControllerAsync failed to create the controller due to incompatible options.", ex2);
            }

            throw ex2;
        }

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.createdController;
    }

    //
    // Summary:
    //     Asynchronously creates a new Microsoft.Web.WebView2.Core.CoreWebView2CompositionController
    //     object.
    //
    // Parameters:
    //   ParentWindow:
    //     The HWND in which the WebView should be displayed and from which receive input.
    //
    //
    //   options:
    //     The options contains profileName and inPrivate parameters that could be used
    //     to create CoreWebView2Profile, and it can be used to create multiple WebViews
    //     with multiple profiles under a single user data directory.
    //
    // Remarks:
    //     Multiple profiles under single user data directory can share some system resources
    //     including memory, CPU footprint, disk space (such as compiled shaders and safebrowsing
    //     data) etc.
    public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
    {
        CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
            _nativeICoreWebView2Environment10.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, handler);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
            }

            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CreateCoreWebView2CompositionControllerAsync failed to create the composition controller due to incompatible options.", ex2);
            }

            throw ex2;
        }

        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.webView;
    }

    private static ProcessorArchitecture GetArchitecture()
    {
        GetSystemInfo(out var lpSystemInfo);
        return (ProcessorArchitecture)lpSystemInfo.wProcessorArchitecture;
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern IntPtr LoadLibrary(string dllToLoad);

    private static bool IsDirectorySeparator(char c)
    {
        if (c != '\\')
        {
            return c == '/';
        }

        return true;
    }

    internal static bool IsValidDriveChar(char value)
    {
        if (value < 'A' || value > 'Z')
        {
            if (value >= 'a')
            {
                return value <= 'z';
            }

            return false;
        }

        return true;
    }

    private static bool IsDotNetFramework()
    {
        return typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET Framework");
    }

    private static string GetAssemblyLocationDirectory()
    {
        try
        {
            return Path.GetDirectoryName(typeof(CoreWebView2Environment).Assembly.Location);
        }
        catch
        {
            return "";
        }
    }

    private static string GetAssemblyCodeBaseDirectory()
    {
        try
        {
            string text = typeof(CoreWebView2Environment).Assembly.CodeBase;
            if (text.StartsWith("file:///"))
            {
                text = Path.GetDirectoryName(text.Substring("file:///".Length));
            }

            return text;
        }
        catch
        {
            return "";
        }
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern uint GetModuleFileName([In] IntPtr hModule, [Out] StringBuilder lpFilename, [In][MarshalAs(UnmanagedType.U4)] int nSize);

    private static string GetCurrentDllRuningDirectory()
    {
        try
        {
            IntPtr moduleHandle = GetModuleHandle("Microsoft.Web.WebView2.Core.dll");
            StringBuilder stringBuilder = new StringBuilder(256);
            if (GetModuleFileName(moduleHandle, stringBuilder, stringBuilder.Capacity) == 0)
            {
                return "";
            }

            return Path.GetDirectoryName(stringBuilder.ToString());
        }
        catch
        {
            return "";
        }
    }

    private static string GetProcessArchSubFolder()
    {
        string text = "runtimes\\win-";
        return Path.Combine(GetArchitecture() switch
        {
            ProcessorArchitecture.x86 => text + "x86",
            ProcessorArchitecture.x64 => text + "x64",
            ProcessorArchitecture.ARM64 => text + "arm64",
            _ => throw new NotSupportedException("Unknown Processor Architecture of WebView2Loader.dll is not supported"),
        }, "native");
    }

    //
    // Summary:
    //     Set the path of the folder containing the `WebView2Loader.dll`.
    //
    // Parameters:
    //   folderPath:
    //     The path of the folder containing the `WebView2Loader.dll`.
    //
    // Exceptions:
    //   T:System.InvalidOperationException:
    //     Thrown when `WebView2Loader.dll` has been successfully loaded.
    //
    // Remarks:
    //     This function allows you to set the path of the folder containing the `WebView2Loader.dll`.
    //     This should be the path of a folder containing `WebView2Loader.dll` and not a
    //     path to the `WebView2Loader.dll` file itself. Note that the WebView2 SDK contains
    //     multiple `WebView2Loader.dll` files for different CPU architectures. When specifying
    //     folder path, you must specify one containing a `WebView2Loader.dll` module with
    //     a CPU architecture matching the current process CPU architecture. This function
    //     is used to load the `WebView2Loader.dll` module during calls to any other static
    //     methods on `CoreWebView2Environment`. So, the path should be specified before
    //     any other API is called in `CoreWebView2Environment` class. Once `WebView2Loader.dll`
    //     is successfully loaded this function will throw an InvalidOperationException
    //     exception. The path can be relative or absolute. Relative paths are relative
    //     to the path of the `Microsoft.Web.WebView2.Core.dll` module. If the `WebView2Loader.dll`
    //     file does not exist in that path or LoadLibrary cannot load the file, or LoadLibrary
    //     fails for any other reason, an exception corresponding to the LoadLibrary failure
    //     is thrown when any other API is called in `CoreWebView2Environment` class. For
    //     instance, if the file cannot be found a `DllNotFoundException` exception will
    //     be thrown.
    public static void SetLoaderDllFolderPath(string folderPath)
    {
        if (!webView2LoaderLoaded)
        {
            loaderDllFolderPath = folderPath;
            return;
        }

        throw new InvalidOperationException("The function should be called before before any other API is called in `CoreWebView2Environment` class.");
    }

    private static string TrimFormat(string path)
    {
        char[] trimChars = new char[2] { '/', '\\' };
        path = path.Trim(new char[1] { ' ' });
        path = path.TrimEnd(trimChars);
        return path;
    }

    private static void LoadWebView2LoaderDll()
    {
        if (webView2LoaderLoaded)
        {
            return;
        }

        string text = "";
        if (!string.IsNullOrEmpty(loaderDllFolderPath))
        {
            text = loaderDllFolderPath;
        }
        else if (IsDotNetFramework())
        {
            text = GetProcessArchSubFolder();
        }

        if (!string.IsNullOrEmpty(text))
        {
            text = TrimFormat(text);
            ArrayList arrayList = new ArrayList();
            if (Path.IsPathRooted(text))
            {
                arrayList.Add(text);
            }
            else
            {
                arrayList.Add(Path.Combine(GetAssemblyLocationDirectory(), text));
                arrayList.Add(Path.Combine(GetAssemblyCodeBaseDirectory(), text));
                arrayList.Add(Path.Combine(GetCurrentDllRuningDirectory(), text));
            }

            arrayList.Add("");
            string text2 = "";
            foreach (string item in arrayList)
            {
                text2 = Path.Combine(item, "WebView2Loader.dll");
                if (LoadLibrary(text2) != IntPtr.Zero)
                {
                    webView2LoaderLoaded = true;
                    break;
                }
            }

            if (!webView2LoaderLoaded && !string.IsNullOrEmpty(loaderDllFolderPath))
            {
                int hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
                throw new DllNotFoundException($"Unable to load DLL '{text2}' or one of its dependencies: {new Win32Exception(hRForLastWin32Error).Message} (0x{hRForLastWin32Error:X})");
            }
        }

        webView2LoaderLoaded = true;
    }

    internal CoreWebView2Environment(object rawCoreWebView2Environment)
    {
        _rawNative = rawCoreWebView2Environment;
    }

    internal void OnNewBrowserVersionAvailable(object args)
    {
        newBrowserVersionAvailable?.Invoke(this, args);
    }

    //
    // Summary:
    //     Asynchronously creates a new WebView.
    //
    // Parameters:
    //   ParentWindow:
    //     The HWND in which the WebView should be displayed and from which receive input.
    //
    //
    // Remarks:
    //     The WebView adds a child window to the provided window during WebView creation.
    //     Z-order and other things impacted by sibling window order are affected accordingly.
    //
    //
    //     HWND_MESSAGE is a valid parameter for ParentWindow for an invisible WebView for
    //     Windows 8 and above. In this case the window will never become visible. You are
    //     not able to reparent the window after you have created the WebView. This is not
    //     supported in Windows 7 or below. Passing this parameter in Windows 7 or below
    //     will return ERROR_INVALID_WINDOW_HANDLE in the controller callback.
    //
    //     It can also accept a Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions
    //     which is created by Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerOptions
    //     as the second parameter for multiple profiles support. As WebView2 is built on
    //     top of Edge browser, it follows Edge's behavior pattern. To create an InPrivate
    //     WebView, we gets an off-the-record profile (an InPrivate profile) from a regular
    //     profile, then create the WebView with the off-the-record profile. Multiple profiles
    //     under single user data directory can share some system resources including memory,
    //     CPU footprint, disk space (such as compiled shaders and safebrowsing data) etc.
    //
    //
    //     It is recommended that the application set Application User Model ID for the
    //     process or the application window. If none is set, during WebView creation a
    //     generated Application User Model ID is set to root window of ParentWindow.
    //
    //     It is recommended that the app handles restart manager messages, to gracefully
    //     restart it in the case when the app is using the WebView2 Runtime from a certain
    //     installation and that installation is being uninstalled. For example, if a user
    //     installs a version of the WebView2 Runtime and opts to use another version of
    //     the WebView2 Runtime for testing the app, and then uninstalls the 1st version
    //     of the WebView2 Runtime without closing the app, the app restarts to allow un-installation
    //     to succeed.
    //
    //     When the app retries CreateCoreWebView2ControllerAsync upon failure, it is recommended
    //     that the app restarts from creating a new WebView2 Environment. If a WebView2
    //     Runtime update happens, the version associated with a WebView2 Environment may
    //     have been removed and causing the object to no longer work. Creating a new WebView2
    //     Environment works since it uses the latest version.
    //
    //     WebView creation fails if a running instance using the same user data folder
    //     exists, and the Environment objects have different Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.
    //     For example, if a WebView was created with one Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.Language,
    //     an attempt to create a WebView with a different Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.Language
    //     using the same user data folder fails.
    //
    //     WebView creation can fail with `E_UNEXPECTED` if runtime does not have permissions
    //     to the user data folder.
    public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow)
    {
        CoreWebView2CreateCoreWebView2ControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
            _nativeICoreWebView2Environment.CreateCoreWebView2Controller(ParentWindow, handler);
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
        return handler.createdController;
    }

    //
    // Summary:
    //     Creates a new Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse object.
    //
    //
    // Parameters:
    //   Content:
    //     HTTP response content as stream.
    //
    //   StatusCode:
    //     The HTTP response status code.
    //
    //   ReasonPhrase:
    //     The HTTP response reason phrase.
    //
    //   Headers:
    //     The raw response header string delimited by newline.
    //
    // Remarks:
    //     It is also possible to create this object with empty headers string and then
    //     use the Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders to construct
    //     the headers line by line.
    public CoreWebView2WebResourceResponse CreateWebResourceResponse(Stream Content, int StatusCode, string ReasonPhrase, string Headers)
    {
        try
        {
            return new CoreWebView2WebResourceResponse(_nativeICoreWebView2Environment.CreateWebResourceResponse((Content == null) ? null : new ManagedIStream(Content), StatusCode, ReasonPhrase, Headers));
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
    //     Asynchronously creates a new WebView for use with visual hosting.
    //
    // Parameters:
    //   ParentWindow:
    //     The HWND in which the app will connect the visual tree of the WebView.
    //
    // Remarks:
    //     ParentWindow will be the HWND that the app will receive pointer/mouse input meant
    //     for the WebView (and will need to use Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendMouseInput(Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind,Microsoft.Web.WebView2.Core.CoreWebView2MouseEventVirtualKeys,System.UInt32,System.Drawing.Point)
    //     or Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendPointerInput(Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind,Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo)
    //     to forward). If the app moves the WebView visual tree to underneath a different
    //     window, then it needs to set Microsoft.Web.WebView2.Core.CoreWebView2Controller.ParentWindow
    //     to update the new parent HWND of the visual tree. Set Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.RootVisualTarget
    //     property on the created Microsoft.Web.WebView2.Core.CoreWebView2CompositionController
    //     to provide a visual to host the browser's visual tree. It is recommended that
    //     the application set Application User Model ID for the process or the application
    //     window. If none is set, during WebView creation a generated Application User
    //     Model ID is set to root window of ParentWindow. It can also accept a Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions
    //     which is created by Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerOptions
    //     as the second parameter for multiple profiles support. CreateCoreWebView2CompositionController
    //     is supported in the following versions of Windows:
    //
    //     • Windows 11
    //     • Windows 10
    //     • Windows Server 2019
    //     • Windows Server 2016
    public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow)
    {
        CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
            _nativeICoreWebView2Environment3.CreateCoreWebView2CompositionController(ParentWindow, handler);
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
        return handler.webView;
    }

    //
    // Summary:
    //     Creates an empty Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo.
    //
    // Remarks:
    //     The returned Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo needs to be
    //     populated with all of the relevant info before calling Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.SendPointerInput(Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind,Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo).
    public CoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
    {
        try
        {
            return new CoreWebView2PointerInfo(_nativeICoreWebView2Environment3.CreateCoreWebView2PointerInfo());
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

    internal void OnBrowserProcessExited(CoreWebView2BrowserProcessExitedEventArgs args)
    {
        browserProcessExited?.Invoke(this, args);
    }

    //
    // Summary:
    //     Creates the Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings used by the
    //     Microsoft.Web.WebView2.Core.CoreWebView2.PrintToPdfAsync(System.String,Microsoft.Web.WebView2.Core.CoreWebView2PrintSettings)
    //     method.
    public CoreWebView2PrintSettings CreatePrintSettings()
    {
        try
        {
            return new CoreWebView2PrintSettings(_nativeICoreWebView2Environment6.CreatePrintSettings());
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

    internal void OnProcessInfosChanged(object args)
    {
        processInfosChanged?.Invoke(this, args);
    }

    //
    // Summary:
    //     Returns the list of all Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo using
    //     same user data folder except for crashpad process.
    public IReadOnlyList<CoreWebView2ProcessInfo> GetProcessInfos()
    {
        try
        {
            return COMDotNetTypeConverter.ProcessInfoCollectionCOMToNet(_nativeICoreWebView2Environment8.GetProcessInfos());
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
    //     Create a custom Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem object
    //     to insert into the WebView context menu.
    //
    // Remarks:
    //     CoreWebView2 will rewind the icon stream before decoding. There is a limit of
    //     1000 active custom context menu items at a given time per Microsoft.Web.WebView2.Core.CoreWebView2Environment.
    //     Attempting to create more before deleting existing ones will fail with ERROR_NOT_ENOUGH_QUOTA.
    //     It is recommended to reuse custom ContextMenuItems across CoreWebView2ContextMenuRequested
    //     events for performance. The created object's Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.IsEnabled
    //     property will default to true and Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.IsChecked
    //     property will default to false. A Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem.CommandId
    //     will be assigned that's unique across active custom context menu items, but command
    //     ID values of deleted custom ContextMenuItems can be reassigned.
    public CoreWebView2ContextMenuItem CreateContextMenuItem(string Label, Stream iconStream, CoreWebView2ContextMenuItemKind Kind)
    {
        try
        {
            return new CoreWebView2ContextMenuItem(_nativeICoreWebView2Environment9.CreateContextMenuItem(Label, (iconStream == null) ? null : new ManagedIStream(iconStream), (COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND)Kind));
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
    //     Create a shared memory based buffer with the specified size in bytes.
    //
    // Remarks:
    //     The buffer can be shared with web contents in WebView by calling Microsoft.Web.WebView2.Core.CoreWebView2.PostSharedBufferToScript(Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer,Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess,System.String)
    //     or Microsoft.Web.WebView2.Core.CoreWebView2Frame.PostSharedBufferToScript(Microsoft.Web.WebView2.Core.CoreWebView2SharedBuffer,Microsoft.Web.WebView2.Core.CoreWebView2SharedBufferAccess,System.String).
    //     Once shared, the same content of the buffer will be accessible from both the
    //     app process and script in WebView. Modification to the content will be visible
    //     to all parties that have access to the buffer. The shared buffer is presented
    //     to the script as ArrayBuffer. All JavaScript APIs that work for ArrayBuffer including
    //     Atomics APIs can be used on it. There is currently a limitation that only size
    //     less than 2GB is supported.
    public CoreWebView2SharedBuffer CreateSharedBuffer(ulong Size)
    {
        try
        {
            return new CoreWebView2SharedBuffer(_nativeICoreWebView2Environment12.CreateSharedBuffer(Size));
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
    //     Returns a snapshot collection of Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo
    //     corresponding to all currently running processes associated with this Microsoft.Web.WebView2.Core.CoreWebView2Environment
    //     excludes crashpad process. This provides the same list of Microsoft.Web.WebView2.Core.CoreWebView2ProcessInfo
    //     as what's provided in Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetProcessInfos,
    //     but additionally provides a list of associated Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo
    //     which are actively running (showing or hiding UI elements) in the renderer process.
    //     See Microsoft.Web.WebView2.Core.CoreWebView2ProcessExtendedInfo.AssociatedFrameInfos
    //     for more information.
    public async Task<IReadOnlyList<CoreWebView2ProcessExtendedInfo>> GetProcessExtendedInfosAsync()
    {
        CoreWebView2GetProcessExtendedInfosCompletedHandler handler;
        try
        {
            handler = new CoreWebView2GetProcessExtendedInfosCompletedHandler();
            _nativeICoreWebView2Environment13.GetProcessExtendedInfos(handler);
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
        return handler.value;
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
