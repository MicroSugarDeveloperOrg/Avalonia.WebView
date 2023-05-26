using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKPreferences", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class WKPreferences : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFraudulentWebsiteWarningEnabled = "isFraudulentWebsiteWarningEnabled";

	private static readonly IntPtr selIsFraudulentWebsiteWarningEnabledHandle = Selector.GetHandle("isFraudulentWebsiteWarningEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJavaEnabled = "javaEnabled";

	private static readonly IntPtr selJavaEnabledHandle = Selector.GetHandle("javaEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJavaScriptCanOpenWindowsAutomatically = "javaScriptCanOpenWindowsAutomatically";

	private static readonly IntPtr selJavaScriptCanOpenWindowsAutomaticallyHandle = Selector.GetHandle("javaScriptCanOpenWindowsAutomatically");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJavaScriptEnabled = "javaScriptEnabled";

	private static readonly IntPtr selJavaScriptEnabledHandle = Selector.GetHandle("javaScriptEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumFontSize = "minimumFontSize";

	private static readonly IntPtr selMinimumFontSizeHandle = Selector.GetHandle("minimumFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlugInsEnabled = "plugInsEnabled";

	private static readonly IntPtr selPlugInsEnabledHandle = Selector.GetHandle("plugInsEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFraudulentWebsiteWarningEnabled_ = "setFraudulentWebsiteWarningEnabled:";

	private static readonly IntPtr selSetFraudulentWebsiteWarningEnabled_Handle = Selector.GetHandle("setFraudulentWebsiteWarningEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJavaEnabled_ = "setJavaEnabled:";

	private static readonly IntPtr selSetJavaEnabled_Handle = Selector.GetHandle("setJavaEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJavaScriptCanOpenWindowsAutomatically_ = "setJavaScriptCanOpenWindowsAutomatically:";

	private static readonly IntPtr selSetJavaScriptCanOpenWindowsAutomatically_Handle = Selector.GetHandle("setJavaScriptCanOpenWindowsAutomatically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJavaScriptEnabled_ = "setJavaScriptEnabled:";

	private static readonly IntPtr selSetJavaScriptEnabled_Handle = Selector.GetHandle("setJavaScriptEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumFontSize_ = "setMinimumFontSize:";

	private static readonly IntPtr selSetMinimumFontSize_Handle = Selector.GetHandle("setMinimumFontSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlugInsEnabled_ = "setPlugInsEnabled:";

	private static readonly IntPtr selSetPlugInsEnabled_Handle = Selector.GetHandle("setPlugInsEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabFocusesLinks_ = "setTabFocusesLinks:";

	private static readonly IntPtr selSetTabFocusesLinks_Handle = Selector.GetHandle("setTabFocusesLinks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabFocusesLinks = "tabFocusesLinks";

	private static readonly IntPtr selTabFocusesLinksHandle = Selector.GetHandle("tabFocusesLinks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKPreferences");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool FraudulentWebsiteWarningEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isFraudulentWebsiteWarningEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFraudulentWebsiteWarningEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFraudulentWebsiteWarningEnabledHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setFraudulentWebsiteWarningEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFraudulentWebsiteWarningEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFraudulentWebsiteWarningEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Feature no longer supported.")]
	public virtual bool JavaEnabled
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Feature no longer supported.")]
		[Export("javaEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selJavaEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selJavaEnabledHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Feature no longer supported.")]
		[Export("setJavaEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool JavaScriptCanOpenWindowsAutomatically
	{
		[Export("javaScriptCanOpenWindowsAutomatically")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selJavaScriptCanOpenWindowsAutomaticallyHandle);
		}
		[Export("setJavaScriptCanOpenWindowsAutomatically:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaScriptCanOpenWindowsAutomatically_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool JavaScriptEnabled
	{
		[Export("javaScriptEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selJavaScriptEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selJavaScriptEnabledHandle);
		}
		[Export("setJavaScriptEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJavaScriptEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJavaScriptEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumFontSize
	{
		[Export("minimumFontSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumFontSizeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumFontSizeHandle);
		}
		[Export("setMinimumFontSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumFontSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Feature no longer supported.")]
	public virtual bool PlugInsEnabled
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Feature no longer supported.")]
		[Export("plugInsEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPlugInsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPlugInsEnabledHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Feature no longer supported.")]
		[Export("setPlugInsEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPlugInsEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPlugInsEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual bool TabFocusesLinks
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("tabFocusesLinks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTabFocusesLinksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTabFocusesLinksHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("setTabFocusesLinks:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTabFocusesLinks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTabFocusesLinks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKPreferences()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WKPreferences(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WKPreferences(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKPreferences(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
