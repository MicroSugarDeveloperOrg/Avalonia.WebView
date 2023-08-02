using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.System;

namespace WebKit;

[Register("WKPreferences", true)]
public class WKPreferences : NSObject
{
    private const string selEncodeWithCoder_ = "encodeWithCoder:";
    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    private const string selInitWithCoder_ = "initWithCoder:";
    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    private const string selIsFraudulentWebsiteWarningEnabled = "isFraudulentWebsiteWarningEnabled";
    private static readonly IntPtr selIsFraudulentWebsiteWarningEnabledHandle = Selector.GetHandle("isFraudulentWebsiteWarningEnabled");

    private const string selJavaEnabled = "javaEnabled";
    private static readonly IntPtr selJavaEnabledHandle = Selector.GetHandle("javaEnabled");

    private const string selJavaScriptCanOpenWindowsAutomatically = "javaScriptCanOpenWindowsAutomatically";
    private static readonly IntPtr selJavaScriptCanOpenWindowsAutomaticallyHandle = Selector.GetHandle("javaScriptCanOpenWindowsAutomatically");

    private const string selJavaScriptEnabled = "javaScriptEnabled";
    private static readonly IntPtr selJavaScriptEnabledHandle = Selector.GetHandle("javaScriptEnabled");

    private const string selMinimumFontSize = "minimumFontSize";
    private static readonly IntPtr selMinimumFontSizeHandle = Selector.GetHandle("minimumFontSize");

    private const string selPlugInsEnabled = "plugInsEnabled";
    private static readonly IntPtr selPlugInsEnabledHandle = Selector.GetHandle("plugInsEnabled");

    private const string selSetFraudulentWebsiteWarningEnabled_ = "setFraudulentWebsiteWarningEnabled:";
    private static readonly IntPtr selSetFraudulentWebsiteWarningEnabled_Handle = Selector.GetHandle("setFraudulentWebsiteWarningEnabled:");

    private const string selSetJavaEnabled_ = "setJavaEnabled:";
    private static readonly IntPtr selSetJavaEnabled_Handle = Selector.GetHandle("setJavaEnabled:");

    private const string selSetJavaScriptCanOpenWindowsAutomatically_ = "setJavaScriptCanOpenWindowsAutomatically:";
    private static readonly IntPtr selSetJavaScriptCanOpenWindowsAutomatically_Handle = Selector.GetHandle("setJavaScriptCanOpenWindowsAutomatically:");

    private const string selSetJavaScriptEnabled_ = "setJavaScriptEnabled:";
    private static readonly IntPtr selSetJavaScriptEnabled_Handle = Selector.GetHandle("setJavaScriptEnabled:");

    private const string selSetMinimumFontSize_ = "setMinimumFontSize:";
    private static readonly IntPtr selSetMinimumFontSize_Handle = Selector.GetHandle("setMinimumFontSize:");

    private const string selSetPlugInsEnabled_ = "setPlugInsEnabled:";
    private static readonly IntPtr selSetPlugInsEnabled_Handle = Selector.GetHandle("setPlugInsEnabled:");

    private const string selSetTabFocusesLinks_ = "setTabFocusesLinks:";
    private static readonly IntPtr selSetTabFocusesLinks_Handle = Selector.GetHandle("setTabFocusesLinks:");

    private const string selTabFocusesLinks = "tabFocusesLinks";
    private static readonly IntPtr selTabFocusesLinksHandle = Selector.GetHandle("tabFocusesLinks");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKPreferences");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKPreferences()
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public WKPreferences(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKPreferences(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKPreferences(IntPtr handle)
        : base(handle)
    {
    }

    public virtual bool FraudulentWebsiteWarningEnabled
    {

        [Export("isFraudulentWebsiteWarningEnabled")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selIsFraudulentWebsiteWarningEnabledHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsFraudulentWebsiteWarningEnabledHandle);
        }

        [Export("setFraudulentWebsiteWarningEnabled:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetFraudulentWebsiteWarningEnabled_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetFraudulentWebsiteWarningEnabled_Handle, value);
            }
        }
    }


    public virtual bool JavaEnabled
    {
        [Export("javaEnabled")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selJavaEnabledHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selJavaEnabledHandle);
        }
        [Export("setJavaEnabled:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetJavaEnabled_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetJavaEnabled_Handle, value);
            }
        }
    }

    public virtual bool JavaScriptCanOpenWindowsAutomatically
    {
        [Export("javaScriptCanOpenWindowsAutomatically")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
        }
        [Export("setJavaScriptCanOpenWindowsAutomatically:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
            }
        }
    }

    public virtual bool JavaScriptEnabled
    {
        [Export("javaScriptEnabled")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selJavaScriptEnabledHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selJavaScriptEnabledHandle);
        }
        [Export("setJavaScriptEnabled:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetJavaScriptEnabled_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetJavaScriptEnabled_Handle, value);
            }
        }
    }

    public virtual nfloat MinimumFontSize
    {
        [Export("minimumFontSize")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(Handle, selMinimumFontSizeHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(SuperHandle, selMinimumFontSizeHandle);
        }
        [Export("setMinimumFontSize:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_nfloat(Handle, selSetMinimumFontSize_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_nfloat(SuperHandle, selSetMinimumFontSize_Handle, value);
            }
        }
    }
    public virtual bool PlugInsEnabled
    {
        [Export("plugInsEnabled")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selPlugInsEnabledHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selPlugInsEnabledHandle);
        }
        [Export("setPlugInsEnabled:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetPlugInsEnabled_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetPlugInsEnabled_Handle, value);
            }
        }
    }

    public virtual bool TabFocusesLinks
    {
        [Export("tabFocusesLinks")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selTabFocusesLinksHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selTabFocusesLinksHandle);
        }
        [Export("setTabFocusesLinks:")]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_bool(Handle, selSetTabFocusesLinks_Handle, value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetTabFocusesLinks_Handle, value);
            }
        }
    }
}
