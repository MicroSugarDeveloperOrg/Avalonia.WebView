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
    //     This mostly represents a combined win32 POINTER_INFO, POINTER_TOUCH_INFO, and
    //     POINTER_PEN_INFO object.
    public class CoreWebView2PointerInfo
    {
        internal ICoreWebView2PointerInfo _nativeICoreWebView2PointerInfoValue;

        internal object _rawNative;

        internal ICoreWebView2PointerInfo _nativeICoreWebView2PointerInfo
        {
            get
            {
                if (_nativeICoreWebView2PointerInfoValue == null)
                {
                    try
                    {
                        _nativeICoreWebView2PointerInfoValue = (ICoreWebView2PointerInfo)_rawNative;
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                    }
                }

                return _nativeICoreWebView2PointerInfoValue;
            }
            set
            {
                _nativeICoreWebView2PointerInfoValue = value;
            }
        }

        //
        // Summary:
        //     Gets or sets the PointerKind of the pointer event.
        //
        // Remarks:
        //     This corresponds to the pointerKind property of the POINTER_INFO struct. The
        //     values are defined by the POINTER_INPUT_KIND enum in the Windows SDK (_winuser.h_).
        //     Supports PT_PEN and PT_TOUCH.
        public uint PointerKind
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PointerKind;
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
                    _nativeICoreWebView2PointerInfo.PointerKind = value;
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
        //     Gets or sets the PointerId of the pointer event.
        //
        // Remarks:
        //     This corresponds to the pointerId property of the POINTER_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint PointerId
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PointerId;
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
                    _nativeICoreWebView2PointerInfo.PointerId = value;
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
        //     Gets or sets the FrameID of the pointer event.
        //
        // Remarks:
        //     This corresponds to the frameId property of the POINTER_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint FrameId
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.FrameId;
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
                    _nativeICoreWebView2PointerInfo.FrameId = value;
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
        //     Gets or sets the PointerFlags of the pointer event.
        //
        // Remarks:
        //     This corresponds to the pointerFlags property of the POINTER_INFO struct. The
        //     values are defined by the POINTER_FLAGS constants in the Windows SDK (_winuser.h_).
        public uint PointerFlags
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PointerFlags;
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
                    _nativeICoreWebView2PointerInfo.PointerFlags = value;
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
        //     Gets or sets the PointerDeviceRect of the sourceDevice property of the POINTER_INFO
        //     struct as defined in the Windows SDK (_winuser.h_).
        public Rectangle PointerDeviceRect
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.PointerDeviceRect);
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
                    _nativeICoreWebView2PointerInfo.PointerDeviceRect = COMDotNetTypeConverter.RectangleNetToCOM(value);
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
        //     Gets or sets the DisplayRect of the sourceDevice property of the POINTER_INFO
        //     struct as defined in the Windows SDK (_winuser.h_).
        public Rectangle DisplayRect
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.DisplayRect);
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
                    _nativeICoreWebView2PointerInfo.DisplayRect = COMDotNetTypeConverter.RectangleNetToCOM(value);
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
        //     Gets or sets the PixelLocation of the pointer event.
        //
        // Remarks:
        //     This corresponds to the ptPixelLocation property of the POINTER_INFO struct as
        //     defined in the Windows SDK (_winuser.h_).
        public Point PixelLocation
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.PixelLocation);
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
                    _nativeICoreWebView2PointerInfo.PixelLocation = COMDotNetTypeConverter.PointNetToCOM(value);
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
        //     Gets or sets the HimetricLocation of the pointer event.
        //
        // Remarks:
        //     This corresponds to the ptHimetricLocation property of the POINTER_INFO struct
        //     as defined in the Windows SDK (_winuser.h_).
        public Point HimetricLocation
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.HimetricLocation);
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
                    _nativeICoreWebView2PointerInfo.HimetricLocation = COMDotNetTypeConverter.PointNetToCOM(value);
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
        //     Gets or sets the PixelLocationRaw of the pointer event.
        //
        // Remarks:
        //     This corresponds to the ptPixelLocationRaw property of the POINTER_INFO struct
        //     as defined in the Windows SDK (_winuser.h_).
        public Point PixelLocationRaw
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.PixelLocationRaw);
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
                    _nativeICoreWebView2PointerInfo.PixelLocationRaw = COMDotNetTypeConverter.PointNetToCOM(value);
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
        //     Gets or sets the HimetricLocationRaw of the pointer event.
        //
        // Remarks:
        //     This corresponds to the ptHimetricLocationRaw property of the POINTER_INFO struct
        //     as defined in the Windows SDK (_winuser.h_).
        public Point HimetricLocationRaw
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2PointerInfo.HimetricLocationRaw);
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
                    _nativeICoreWebView2PointerInfo.HimetricLocationRaw = COMDotNetTypeConverter.PointNetToCOM(value);
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
        //     Gets or sets the Time of the pointer event.
        //
        // Remarks:
        //     This corresponds to the dwTime property of the POINTER_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint Time
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.Time;
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
                    _nativeICoreWebView2PointerInfo.Time = value;
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
        //     Gets or sets the HistoryCount of the pointer event.
        //
        // Remarks:
        //     This corresponds to the historyCount property of the POINTER_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint HistoryCount
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.HistoryCount;
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
                    _nativeICoreWebView2PointerInfo.HistoryCount = value;
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
        //     Gets or sets the InputData of the pointer event.
        //
        // Remarks:
        //     This corresponds to the InputData property of the POINTER_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public int InputData
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.InputData;
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
                    _nativeICoreWebView2PointerInfo.InputData = value;
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
        //     Gets or sets the KeyStates of the pointer event.
        //
        // Remarks:
        //     This corresponds to the dwKeyStates property of the POINTER_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint KeyStates
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.KeyStates;
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
                    _nativeICoreWebView2PointerInfo.KeyStates = value;
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
        //     Gets or sets the PerformanceCount of the pointer event.
        //
        // Remarks:
        //     This corresponds to the PerformanceCount property of the POINTER_INFO struct
        //     as defined in the Windows SDK (_winuser.h_).
        public ulong PerformanceCount
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PerformanceCount;
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
                    _nativeICoreWebView2PointerInfo.PerformanceCount = value;
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
        //     Gets or sets the ButtonChangeKind of the pointer event.
        //
        // Remarks:
        //     This corresponds to the ButtonChangeKind property of the POINTER_INFO struct.
        //     The values are defined by the POINTER_BUTTON_CHANGE_KIND enum in the Windows
        //     SDK (_winuser.h_).
        public int ButtonChangeKind
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.ButtonChangeKind;
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
                    _nativeICoreWebView2PointerInfo.ButtonChangeKind = value;
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
        //     Gets or sets the PenFlags of the pointer event.
        //
        // Remarks:
        //     This corresponds to the penFlags property of the POINTER_PEN_INFO struct. The
        //     values are defined by the PEN_FLAGS constants in the Windows SDK (_winuser.h_).
        public uint PenFlags
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PenFlags;
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
                    _nativeICoreWebView2PointerInfo.PenFlags = value;
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
        //     Gets or sets the PenMask of the pointer event.
        //
        // Remarks:
        //     This corresponds to the penMask property of the POINTER_PEN_INFO struct. The
        //     values are defined by the PEN_MASK constants in the Windows SDK (_winuser.h_).
        public uint PenMask
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PenMask;
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
                    _nativeICoreWebView2PointerInfo.PenMask = value;
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
        //     Gets or sets the PenPressure of the pointer event.
        //
        // Remarks:
        //     This corresponds to the pressure property of the POINTER_PEN_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint PenPressure
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PenPressure;
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
                    _nativeICoreWebView2PointerInfo.PenPressure = value;
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
        //     Gets or sets the PenRotation of the pointer event.
        //
        // Remarks:
        //     This corresponds to the rotation property of the POINTER_PEN_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public uint PenRotation
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PenRotation;
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
                    _nativeICoreWebView2PointerInfo.PenRotation = value;
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
        //     Gets or sets the PenTiltX of the pointer event.
        //
        // Remarks:
        //     This corresponds to the tiltX property of the POINTER_PEN_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public int PenTiltX
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PenTiltX;
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
                    _nativeICoreWebView2PointerInfo.PenTiltX = value;
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
        //     Gets or sets the PenTiltY of the pointer event.
        //
        // Remarks:
        //     This corresponds to the tiltY property of the POINTER_PEN_INFO struct as defined
        //     in the Windows SDK (_winuser.h_).
        public int PenTiltY
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.PenTiltY;
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
                    _nativeICoreWebView2PointerInfo.PenTiltY = value;
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
        //     Gets or sets the TouchFlags of the pointer event.
        //
        // Remarks:
        //     This corresponds to the touchFlags property of the POINTER_TOUCH_INFO struct.
        //     The values are defined by the TOUCH_FLAGS constants in the Windows SDK (_winuser.h_).
        public uint TouchFlags
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.TouchFlags;
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
                    _nativeICoreWebView2PointerInfo.TouchFlags = value;
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
        //     Gets or sets the TouchMask of the pointer event.
        //
        // Remarks:
        //     This corresponds to the touchMask property of the POINTER_TOUCH_INFO struct.
        //     The values are defined by the TOUCH_MASK constants in the Windows SDK (_winuser.h_).
        public uint TouchMask
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.TouchMask;
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
                    _nativeICoreWebView2PointerInfo.TouchMask = value;
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
        //     Gets or sets the TouchContact of the pointer event.
        //
        // Remarks:
        //     This corresponds to the rcContact property of the POINTER_TOUCH_INFO struct as
        //     defined in the Windows SDK (_winuser.h_).
        public Rectangle TouchContact
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.TouchContact);
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
                    _nativeICoreWebView2PointerInfo.TouchContact = COMDotNetTypeConverter.RectangleNetToCOM(value);
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
        //     Gets or sets the TouchContactRaw of the pointer event.
        //
        // Remarks:
        //     This corresponds to the rcContactRaw property of the POINTER_TOUCH_INFO struct
        //     as defined in the Windows SDK (_winuser.h_).
        public Rectangle TouchContactRaw
        {
            get
            {
                try
                {
                    return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2PointerInfo.TouchContactRaw);
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
                    _nativeICoreWebView2PointerInfo.TouchContactRaw = COMDotNetTypeConverter.RectangleNetToCOM(value);
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
        //     Gets or sets the TouchOrientation of the pointer event.
        //
        // Remarks:
        //     This corresponds to the orientation property of the POINTER_TOUCH_INFO struct
        //     as defined in the Windows SDK (_winuser.h_).
        public uint TouchOrientation
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.TouchOrientation;
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
                    _nativeICoreWebView2PointerInfo.TouchOrientation = value;
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
        //     Gets or sets the TouchPressure of the pointer event.
        //
        // Remarks:
        //     This corresponds to the pressure property of the POINTER_TOUCH_INFO struct as
        //     defined in the Windows SDK (_winuser.h_).
        public uint TouchPressure
        {
            get
            {
                try
                {
                    return _nativeICoreWebView2PointerInfo.TouchPressure;
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
                    _nativeICoreWebView2PointerInfo.TouchPressure = value;
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

        internal CoreWebView2PointerInfo(object rawCoreWebView2PointerInfo)
        {
            _rawNative = rawCoreWebView2PointerInfo;
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
