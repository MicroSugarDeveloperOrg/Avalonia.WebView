#region Assembly Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// C:\Users\ChisterWu\.nuget\packages\microsoft.web.webview2\1.0.1829-prerelease\lib\netcoreapp3.0\Microsoft.Web.WebView2.Core.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
    //
    // Summary:
    //     This class is the owner of the Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2
    //     object, and provides support for resizing, showing and hiding, focusing, and
    //     other functionality related to windowing and composition.
    //
    // Remarks:
    //     The Microsoft.Web.WebView2.Core.CoreWebView2Controller owns the Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2,
    //     and if all references to the Microsoft.Web.WebView2.Core.CoreWebView2Controller
    //     go away, the WebView will be closed.
    public class CoreWebView2Controller
    {
        private const string HostObjectHelperName = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";

        private CoreWebView2 _coreWebView2;

        internal ICoreWebView2Controller _nativeICoreWebView2ControllerValue;

        internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2Value;

        internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3Value;

        internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4Value;

        internal ICoreWebView2ExperimentalController2 _nativeICoreWebView2ExperimentalController2Value;

        internal ICoreWebView2ExperimentalController _nativeICoreWebView2ExperimentalControllerValue;

        internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialControllerValue;

        internal object _rawNative;

        private EventRegistrationToken _zoomFactorChangedToken;

        private EventHandler<object> zoomFactorChanged;

        private EventRegistrationToken _moveFocusRequestedToken;

        private EventHandler<CoreWebView2MoveFocusRequestedEventArgs> moveFocusRequested;

        private EventRegistrationToken _gotFocusToken;

        private EventHandler<object> gotFocus;

        private EventRegistrationToken _lostFocusToken;

        private EventHandler<object> lostFocus;

        private EventRegistrationToken _acceleratorKeyPressedToken;

        private EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> acceleratorKeyPressed;

        private EventRegistrationToken _rasterizationScaleChangedToken;

        private EventHandler<object> rasterizationScaleChanged;

        private EventRegistrationToken _keyPressedToken;

        private EventHandler<CoreWebView2PrivateKeyPressedEventArgs> keyPressed;

        //
        // Summary:
        //     Gets the Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2 associated
        //     with this Microsoft.Web.WebView2.Core.CoreWebView2Controller.
        public CoreWebView2 CoreWebView2
        {
            get
            {
                if (_nativeICoreWebView2Controller.CoreWebView2 == null)
                {
                    return null;
                }

                if (_coreWebView2 == null)
                {
                    _coreWebView2 = new CoreWebView2(_nativeICoreWebView2Controller.CoreWebView2);
                }

                return _coreWebView2;
            }
        }

        internal ICoreWebView2Controller _nativeICoreWebView2Controller
        {
            get
            {
                if (_nativeICoreWebView2ControllerValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2ControllerValue = (ICoreWebView2Controller)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ControllerValue;
            }
            set
            {
                _nativeICoreWebView2ControllerValue = value;
            }
        }

        internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2
        {
            get
            {
                if (_nativeICoreWebView2Controller2Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller2Value = (ICoreWebView2Controller2)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Controller2Value;
            }
            set
            {
                _nativeICoreWebView2Controller2Value = value;
            }
        }

        internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3
        {
            get
            {
                if (_nativeICoreWebView2Controller3Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller3Value = (ICoreWebView2Controller3)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Controller3Value;
            }
            set
            {
                _nativeICoreWebView2Controller3Value = value;
            }
        }

        internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4
        {
            get
            {
                if (_nativeICoreWebView2Controller4Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller4Value = (ICoreWebView2Controller4)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2Controller4Value;
            }
            set
            {
                _nativeICoreWebView2Controller4Value = value;
            }
        }

        internal ICoreWebView2ExperimentalController2 _nativeICoreWebView2ExperimentalController2
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalController2Value == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalController2Value = (ICoreWebView2ExperimentalController2)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalController2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalController2Value;
            }
            set
            {
                _nativeICoreWebView2ExperimentalController2Value = value;
            }
        }

        internal ICoreWebView2ExperimentalController _nativeICoreWebView2ExperimentalController
        {
            get
            {
                if (_nativeICoreWebView2ExperimentalControllerValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2ExperimentalControllerValue = (ICoreWebView2ExperimentalController)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2ExperimentalControllerValue;
            }
            set
            {
                _nativeICoreWebView2ExperimentalControllerValue = value;
            }
        }

        internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialController
        {
            get
            {
                if (_nativeICoreWebView2PrivatePartialControllerValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2PrivatePartialControllerValue = (ICoreWebView2PrivatePartialController)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartialController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2PrivatePartialControllerValue;
            }
            set
            {
                _nativeICoreWebView2PrivatePartialControllerValue = value;
            }
        }

        //
        // Summary:
        //     Determines whether to show or hide the WebView.
        //
        // Remarks:
        //     If IsVisible is set to false, the WebView is transparent and is not rendered.
        //     However, this does not affect the window containing the WebView (the ParentWindow
        //     parameter that was passed to Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr)
        //     or Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)).
        //     If you want that window to disappear too, run the corresponding Hide method from
        //     the UI framework on it directly in addition to modifying this. WebView as a child
        //     window does not get window messages when the top window is minimized or restored.
        //     For performance reasons, developers should set the IsVisible property of the
        //     WebView to false when the app window is minimized and back to true when the app
        //     window is restored. The app window does this by handling SIZE_MINIMIZED and SIZE_RESTORED
        //     command upon receiving WM_SIZE message. There are CPU and memory benefits when
        //     the page is hidden. For instance Chromium has code that throttles activities
        //     on the page like animations and some tasks are run less frequently. Similarly,
        //     WebView2 will purge some caches to reduce memory usage.
        public bool IsVisible
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Controller.IsVisible != 0;
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
                    _nativeICoreWebView2Controller.IsVisible = (value ? 1 : 0);
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
        //     Gets or sets the WebView bounds.
        //
        // Remarks:
        //     Bounds are relative to the Microsoft.Web.WebView2.Core.CoreWebView2Controller.ParentWindow.
        //     The app has two ways to position a WebView:
        //     • Create a child HWND that is the WebView parent HWND. Position the window where
        //     the WebView should be. Use (0, 0) for the top-left corner (the offset) of the
        //     Bounds of the WebView.
        //     • Use the top-most window of the app as the WebView parent HWND. For example,
        //     to position ebView correctly in the app, set the top-left corner of the Bounds
        //     of the WebView.
        //     The values of Bounds are limited by the coordinate space of the host.
        public Rectangle Bounds
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2Controller.Bounds);
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
                    _nativeICoreWebView2Controller.Bounds = COMDotNetTypeConverter.RectangleNetToCOM(value);
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
        //     Gets or sets the zoom factor for the WebView.
        //
        // Remarks:
        //     Note that changing zoom factor may cause window.innerWidth or window.innerHeight
        //     and page layout to change. A zoom factor that is applied by the host by setting
        //     this ZoomFactor property becomes the new default zoom for the WebView. This zoom
        //     factor applies across navigations and is the zoom factor WebView is returned
        //     to when the user presses Ctrl+0. When the zoom factor is changed by the user
        //     (resulting in the app receiving Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactorChanged),
        //     that zoom applies only for the current page. Any user applied zoom is only for
        //     the current page and is reset on a navigation. Specifying a ZoomFactor less than
        //     or equal to 0 is not allowed. WebView also has an internal supported zoom factor
        //     range. When a specified zoom factor is out of that range, it is normalized to
        //     be within the range, and a Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactorChanged
        //     event is raised for the real applied zoom factor. When this range normalization
        //     happens, this reports the zoom factor specified during the previous modification
        //     of the ZoomFactor property until the Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactorChanged
        //     event is received after WebView applies the normalized zoom factor.
        public double ZoomFactor
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Controller.ZoomFactor;
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
                    _nativeICoreWebView2Controller.ZoomFactor = value;
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
        //     Gets the parent window provided by the app or sets the parent window that this
        //     WebView is using to render content.
        //
        // Remarks:
        //     It initially returns the ParentWindow passed into Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr)
        //     or Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateCoreWebView2ControllerAsync(System.IntPtr,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions).
        //     Setting the property causes the WebView to re-parent the main WebView window
        //     to the newly provided window.
        public IntPtr ParentWindow
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2Controller.ParentWindow;
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
                    _nativeICoreWebView2Controller.ParentWindow = value;
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
        //     Gets or sets the WebView default background color.
        //
        // Remarks:
        //     The `DefaultBackgroundColor` is the color that renders underneath all web content.
        //     This means WebView renders this color when there is no web content loaded such
        //     as before the initial navigation or between navigations. This also means web
        //     pages with undefined css background properties or background properties containing
        //     transparent pixels will render their contents over this color. Web pages with
        //     defined and opaque background properties that span the page will obscure the
        //     `DefaultBackgroundColor` and display normally. The default value for this property
        //     is white to resemble the native browser experience. Currently this API only supports
        //     opaque colors and transparency. It will fail for colors with alpha values that
        //     don't equal 0 or 255 ie. translucent colors are not supported. It also does not
        //     support transparency on Windows 7. On Windows 7, setting DefaultBackgroundColor
        //     to a Color with an Alpha value other than 255 will result in failure. On any
        //     OS above Win7, choosing a transparent color will result in showing hosting app
        //     content. This means webpages without explicit background properties defined will
        //     render web content over hosting app content. This property may also be set via
        //     the `WEBVIEW2_DEFAULT_BACKGROUND_COLOR` environment variable. There is a known
        //     issue with background color where just setting the color by property can still
        //     leave the app with a white flicker before the `DefaultBackgroundColor` property
        //     takes effect. Setting the color via environment variable solves this issue. The
        //     value must be a hex value that can optionally prepend a 0x. The value must account
        //     for the alpha value which is represented by the first 2 digits. So any hex value
        //     fewer than 8 digits will assume a prepended 00 to the hex value and result in
        //     a transparent color. `DefaultBackgroundColor` will return the result of this
        //     environment variable even if it has not been set directly. This environment variable
        //     can only set the `DefaultBackgroundColor` once. Subsequent updates to background
        //     color must be done by setting the property.
        public Color DefaultBackgroundColor
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.ColorCOMToNet(_nativeICoreWebView2Controller2.DefaultBackgroundColor);
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
                    _nativeICoreWebView2Controller2.DefaultBackgroundColor = COMDotNetTypeConverter.ColorNetToCOM(value);
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
        //     Gets or sets the WebView rasterization scale.
        //
        // Remarks:
        //     The rasterization scale is the combination of the monitor DPI scale and text
        //     scaling set by the user. This value should be updated when the DPI scale of the
        //     app's top level window changes (i.e. monitor DPI scale changes or the window
        //     changes monitor) or when the text scale factor of the system changes. Rasterization
        //     scale applies to the WebView content, as well as popups, context menus, scroll
        //     bars, and so on. Normal app scaling scenarios should use the Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor
        //     property or Microsoft.Web.WebView2.Core.CoreWebView2Controller.SetBoundsAndZoomFactor(System.Drawing.Rectangle,System.Double)
        //     method.
        public double RasterizationScale
        {
            get
            {
                try
                {
                    try
                    {
                        return _nativeICoreWebView2Controller3.RasterizationScale;
                    }
                    catch (NotImplementedException)
                    {
                        return _nativeICoreWebView2ExperimentalController.RasterizationScale;
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
                        _nativeICoreWebView2Controller3.RasterizationScale = value;
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalController.RasterizationScale = value;
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
        //     Determines whether the WebView will detect monitor scale changes.
        //
        // Remarks:
        //     ShouldDetectMonitorScaleChanges property determines whether the WebView attempts
        //     to track monitor DPI scale changes. When true, the WebView will track monitor
        //     DPI scale changes, update the Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale
        //     property, and fire Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScaleChanged
        //     event. When false, the WebView will not track monitor DPI scale changes, and
        //     the app must update the Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale
        //     property itself. Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScaleChanged
        //     event will never raise when ShouldDetectMonitorScaleChanges is false. Apps that
        //     want to set their own rasterization scale should set this property to false to
        //     avoid the WebView2 updating the Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale
        //     property to match the monitor DPI scale.
        public bool ShouldDetectMonitorScaleChanges
        {
            get
            {
                try
                {
                    try
                    {
                        return _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges != 0;
                    }
                    catch (NotImplementedException)
                    {
                        return _nativeICoreWebView2ExperimentalController.ShouldDetectMonitorScaleChanges != 0;
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
                        _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalController.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
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
        //     Gets or sets the WebView bounds mode.
        //
        // Remarks:
        //     BoundsMode affects how setting the Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale properties
        //     work. Bounds mode can either be in Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode.UseRawPixels
        //     mode or Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode.UseRasterizationScale
        //     mode.
        public CoreWebView2BoundsMode BoundsMode
        {
            get
            {
                try
                {
                    try
                    {
                        return (CoreWebView2BoundsMode)_nativeICoreWebView2Controller3.BoundsMode;
                    }
                    catch (NotImplementedException)
                    {
                        return (CoreWebView2BoundsMode)_nativeICoreWebView2ExperimentalController.BoundsMode;
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
                        _nativeICoreWebView2Controller3.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalController.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
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
        //     Gets or sets the WebView allow external drop property.
        //
        // Remarks:
        //     The AllowExternalDrop is to configure the capability that dropping files into
        //     webview2 is allowed or permitted. The default value is true.
        public bool AllowExternalDrop
        {
            get
            {
                try
                {
                    try
                    {
                        return _nativeICoreWebView2Controller4.AllowExternalDrop != 0;
                    }
                    catch (NotImplementedException)
                    {
                        return _nativeICoreWebView2ExperimentalController2.AllowExternalDrop != 0;
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
                        _nativeICoreWebView2Controller4.AllowExternalDrop = (value ? 1 : 0);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalController2.AllowExternalDrop = (value ? 1 : 0);
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

        internal bool IsBrowserHitTransparent
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PrivatePartialController.IsBrowserHitTransparent != 0;
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
        //     ZoomFactorChanged is raised when the Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor
        //     property changes.
        //
        // Remarks:
        //     The event may be raised because the Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor
        //     property was modified, or due to the user manually modifying the zoom. When it
        //     is modified using the Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor
        //     property, the internal zoom factor is updated immediately and no ZoomFactorChanged
        //     event is raised. WebView associates the last used zoom factor for each site.
        //     It is possible for the zoom factor to change when navigating to a different page.
        //     When the zoom factor changes due to a navigation change, the ZoomFactorChanged
        //     event is raised right after the Microsoft.Web.WebView2.Core.CoreWebView2.ContentLoading
        //     event.
        public event EventHandler<object> ZoomFactorChanged
        {
            add
            {
                if (zoomFactorChanged == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller.add_ZoomFactorChanged(new CoreWebView2ZoomFactorChangedEventHandler(OnZoomFactorChanged), out _zoomFactorChangedToken);
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

                zoomFactorChanged = (EventHandler<object>)Delegate.Combine(zoomFactorChanged, value);
            }
            remove
            {
                zoomFactorChanged = (EventHandler<object>)Delegate.Remove(zoomFactorChanged, value);
                if (zoomFactorChanged != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Controller.remove_ZoomFactorChanged(_zoomFactorChangedToken);
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
        //     MoveFocusRequested is raised when user tries to tab out of the WebView.
        //
        // Remarks:
        //     The focus of the WebView has not changed when this event is raised.
        public event EventHandler<CoreWebView2MoveFocusRequestedEventArgs> MoveFocusRequested
        {
            add
            {
                if (moveFocusRequested == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller.add_MoveFocusRequested(new CoreWebView2MoveFocusRequestedEventHandler(OnMoveFocusRequested), out _moveFocusRequestedToken);
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

                moveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Combine(moveFocusRequested, value);
            }
            remove
            {
                moveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Remove(moveFocusRequested, value);
                if (moveFocusRequested != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Controller.remove_MoveFocusRequested(_moveFocusRequestedToken);
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
        //     GotFocus is raised when WebView gets focus.
        public event EventHandler<object> GotFocus
        {
            add
            {
                if (gotFocus == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller.add_GotFocus(new CoreWebView2FocusChangedEventHandler(OnGotFocus), out _gotFocusToken);
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

                gotFocus = (EventHandler<object>)Delegate.Combine(gotFocus, value);
            }
            remove
            {
                gotFocus = (EventHandler<object>)Delegate.Remove(gotFocus, value);
                if (gotFocus != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Controller.remove_GotFocus(_gotFocusToken);
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
        //     LostFocus is raised when WebView loses focus.
        //
        // Remarks:
        //     In the case where Microsoft.Web.WebView2.Core.CoreWebView2Controller.MoveFocusRequested
        //     event is raised, the focus is still on WebView when Microsoft.Web.WebView2.Core.CoreWebView2Controller.MoveFocusRequested
        //     event is raised. LostFocus is only raised afterwards when code of the app or
        //     default action of Microsoft.Web.WebView2.Core.CoreWebView2Controller.MoveFocusRequested
        //     event sets focus away from WebView.
        public event EventHandler<object> LostFocus
        {
            add
            {
                if (lostFocus == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller.add_LostFocus(new CoreWebView2FocusChangedEventHandler(OnLostFocus), out _lostFocusToken);
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

                lostFocus = (EventHandler<object>)Delegate.Combine(lostFocus, value);
            }
            remove
            {
                lostFocus = (EventHandler<object>)Delegate.Remove(lostFocus, value);
                if (lostFocus != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Controller.remove_LostFocus(_lostFocusToken);
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
        //     AcceleratorKeyPressed is raised when an accelerator key or key combo is pressed
        //     or released while the WebView is focused.
        //
        // Remarks:
        //     A key is considered an accelerator if either of the following conditions are
        //     true:
        //     • Ctrl or Alt is currently being held.
        //     • The pressed key does not map to a character.
        //     A few specific keys are never considered accelerators, such as Shift. The Escape
        //     key is always considered an accelerator. Autorepeated key events caused by holding
        //     the key down will also raise this event. Filter out the auto-repeated key events
        //     by verifying Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam
        //     or Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus.
        //     In windowed mode, this event is synchronous. Until you set Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.Handled
        //     to true or the event handler returns, the browser process is blocked and outgoing
        //     cross-process COM calls will fail with RPC_E_CANTCALLOUT_ININPUTSYNCCALL. All
        //     Microsoft.Web.WebView2.Core.CoreWebView2Controller.CoreWebView2 methods work,
        //     however. In windowless mode, the event is asynchronous. Further input do not
        //     reach the browser until the event handler returns or Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.Handled
        //     is set to true, but the browser process is not blocked, and outgoing COM calls
        //     work normally. It is recommended to set Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs.Handled
        //     to true as early as you are able to know that you want to handle the accelerator
        //     key.
        public event EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed
        {
            add
            {
                if (acceleratorKeyPressed == null)
                {
                    try
                    {
                        _nativeICoreWebView2Controller.add_AcceleratorKeyPressed(new CoreWebView2AcceleratorKeyPressedEventHandler(OnAcceleratorKeyPressed), out _acceleratorKeyPressedToken);
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

                acceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Combine(acceleratorKeyPressed, value);
            }
            remove
            {
                acceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Remove(acceleratorKeyPressed, value);
                if (acceleratorKeyPressed != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2Controller.remove_AcceleratorKeyPressed(_acceleratorKeyPressedToken);
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
        //     RasterizationScaleChanged is raised when the Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale
        //     property changes.
        //
        // Remarks:
        //     The event is raised when the Webview detects that the monitor DPI scale has changed,
        //     Microsoft.Web.WebView2.Core.CoreWebView2Controller.ShouldDetectMonitorScaleChanges
        //     is true, and the Webview has changed the Microsoft.Web.WebView2.Core.CoreWebView2Controller.RasterizationScale
        //     property.
        public event EventHandler<object> RasterizationScaleChanged
        {
            add
            {
                if (rasterizationScaleChanged == null)
                {
                    try
                    {
                        try
                        {
                            _nativeICoreWebView2Controller3.add_RasterizationScaleChanged(new CoreWebView2RasterizationScaleChangedEventHandler(OnRasterizationScaleChanged), out _rasterizationScaleChangedToken);
                        }
                        catch (NotImplementedException)
                        {
                            _nativeICoreWebView2ExperimentalController.add_RasterizationScaleChanged(new CoreWebView2ExperimentalRasterizationScaleChangedEventHandler(OnRasterizationScaleChanged), out _rasterizationScaleChangedToken);
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

                rasterizationScaleChanged = (EventHandler<object>)Delegate.Combine(rasterizationScaleChanged, value);
            }
            remove
            {
                rasterizationScaleChanged = (EventHandler<object>)Delegate.Remove(rasterizationScaleChanged, value);
                if (rasterizationScaleChanged != null)
                {
                    return;
                }

                try
                {
                    try
                    {
                        _nativeICoreWebView2Controller3.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalController.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
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

        internal event EventHandler<CoreWebView2PrivateKeyPressedEventArgs> KeyPressed
        {
            add
            {
                if (keyPressed == null)
                {
                    try
                    {
                        _nativeICoreWebView2PrivatePartialController.add_KeyPressed(new CoreWebView2PrivateKeyPressedEventHandler(OnKeyPressed), out _keyPressedToken);
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

                keyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Combine(keyPressed, value);
            }
            remove
            {
                keyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Remove(keyPressed, value);
                if (keyPressed != null)
                {
                    return;
                }

                try
                {
                    _nativeICoreWebView2PrivatePartialController.remove_KeyPressed(_keyPressedToken);
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
        //     Moves focus into WebView.
        //
        // Parameters:
        //   reason:
        //     The reason for moving focus.
        //
        // Remarks:
        //     WebView will get focus and focus will be set to correspondent element in the
        //     page hosted in the WebView. For Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic
        //     reason, focus is set to previously focused element or the default element if
        //     no previously focused element exists. For Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next
        //     reason, focus is set to the first element. For Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous
        //     reason, focus is set to the last element. WebView changes focus through user
        //     interaction including selecting into a WebView or Tab into it. For tabbing, the
        //     app runs MoveFocus with Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next
        //     or Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous to align
        //     with Tab and Shift+Tab respectively when it decides the WebView is the next tabbable
        //     element.
        public void MoveFocus(CoreWebView2MoveFocusReason reason)
        {
            try
            {
                _nativeICoreWebView2Controller.MoveFocus((COREWEBVIEW2_MOVE_FOCUS_REASON)reason);
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
            catch (ArgumentException ex3)
            {
                if (ex3.HResult == -2147024809)
                {
                    return;
                }

                throw ex3;
            }
        }

        private void Initialize()
        {
            if (_nativeICoreWebView2Controller != null)
            {
                try
                {
                    CoreWebView2PrivateHostObjectHelper helper = new CoreWebView2PrivateHostObjectHelper();
                    CoreWebView2.AddHostObjectHelper(helper);
                }
                catch (NotImplementedException)
                {
                    ICoreWebView2 coreWebView = _nativeICoreWebView2Controller.CoreWebView2;
                    object @object = new HostObjectHelper();
                    coreWebView.AddHostObjectToScript("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper", ref @object);
                }
            }
        }

        internal CoreWebView2Controller(object rawCoreWebView2Controller)
        {
            _rawNative = rawCoreWebView2Controller;
            Initialize();
        }

        internal void OnZoomFactorChanged(object args)
        {
            zoomFactorChanged?.Invoke(this, args);
        }

        internal void OnMoveFocusRequested(CoreWebView2MoveFocusRequestedEventArgs args)
        {
            moveFocusRequested?.Invoke(this, args);
        }

        internal void OnGotFocus(object args)
        {
            gotFocus?.Invoke(this, args);
        }

        internal void OnLostFocus(object args)
        {
            lostFocus?.Invoke(this, args);
        }

        internal void OnAcceleratorKeyPressed(CoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            acceleratorKeyPressed?.Invoke(this, args);
        }

        //
        // Summary:
        //     Updates Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds and Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor
        //     properties at the same time.
        //
        // Parameters:
        //   Bounds:
        //     The bounds to be updated.
        //
        //   ZoomFactor:
        //     The zoom factor to be updated.
        //
        // Remarks:
        //     This operation is atomic from the perspective of the host. After returning from
        //     this function, the Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor properties
        //     are both updated if the function is successful, or neither is updated if the
        //     function fails. If Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor are both updated
        //     by the same scale (for example, Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds
        //     and Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor are both doubled),
        //     then the page does not display a change in window.innerWidth or window.innerHeight
        //     and the WebView renders the content at the new size and zoom without intermediate
        //     renderings. This function also updates just one of Microsoft.Web.WebView2.Core.CoreWebView2Controller.ZoomFactor
        //     or Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds by passing in the
        //     new value for one and the current value for the other.
        public void SetBoundsAndZoomFactor(Rectangle Bounds, double ZoomFactor)
        {
            try
            {
                _nativeICoreWebView2Controller.SetBoundsAndZoomFactor(COMDotNetTypeConverter.RectangleNetToCOM(Bounds), ZoomFactor);
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
        //     Tells WebView that the main WebView parent (or any ancestor) HWND moved.
        //
        // Remarks:
        //     This is a notification separate from Microsoft.Web.WebView2.Core.CoreWebView2Controller.Bounds.
        //     This is needed for accessibility and certain dialogs in WebView to work correctly.
        public void NotifyParentWindowPositionChanged()
        {
            try
            {
                _nativeICoreWebView2Controller.NotifyParentWindowPositionChanged();
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
        //     Closes the WebView and cleans up the underlying browser instance.
        //
        // Remarks:
        //     Cleaning up the browser instance releases the resources powering the WebView.
        //     The browser instance is shut down if no other WebViews are using it. After running
        //     Close, all methods fail and event handlers stop running. Specifically, the WebView
        //     releases the associated references to any associated event handlers when Close
        //     is run. Close is implicitly run when the Microsoft.Web.WebView2.Core.CoreWebView2Controller
        //     loses the final reference and is destructed. But it is best practice to explicitly
        //     run Close to avoid any accidental cycle of references between the WebView and
        //     the app code. Specifically, if you capture a reference to the WebView in an event
        //     handler you create a reference cycle between the WebView and the event handler.
        //     Run Close to break the cycle by releasing all event handlers. But to avoid the
        //     situation, it is best to both explicitly run Close on the WebView and to not
        //     capture a reference to the WebView to ensure the WebView is cleaned up correctly.
        //     Close is synchronous and won't trigger the beforeunload event.
        public void Close()
        {
            try
            {
                _nativeICoreWebView2Controller.Close();
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

        internal void OnRasterizationScaleChanged(object args)
        {
            rasterizationScaleChanged?.Invoke(this, args);
        }

        internal void OnKeyPressed(CoreWebView2PrivateKeyPressedEventArgs args)
        {
            keyPressed?.Invoke(this, args);
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
