using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextTab", true)]
public class NSTextTab : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnTerminatorsForLocale_ = "columnTerminatorsForLocale:";

	private static readonly IntPtr selColumnTerminatorsForLocale_Handle = Selector.GetHandle("columnTerminatorsForLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTextAlignment_Location_Options_ = "initWithTextAlignment:location:options:";

	private static readonly IntPtr selInitWithTextAlignment_Location_Options_Handle = Selector.GetHandle("initWithTextAlignment:location:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithType_Location_ = "initWithType:location:";

	private static readonly IntPtr selInitWithType_Location_Handle = Selector.GetHandle("initWithType:location:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocation = "location";

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabStopType = "tabStopType";

	private static readonly IntPtr selTabStopTypeHandle = Selector.GetHandle("tabStopType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextTab");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Location
	{
		[Export("location")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLocationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextTabType TabStopType
	{
		[Export("tabStopType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextTabType)Messaging.UInt64_objc_msgSend(base.Handle, selTabStopTypeHandle);
			}
			return (NSTextTabType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabStopTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextTab()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSTextTab(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSTextTab(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextTab(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTextAlignment:location:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextTab(NSTextAlignment alignment, nfloat loc, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_nfloat_IntPtr(base.Handle, selInitWithTextAlignment_Location_Options_Handle, (ulong)alignment, loc, options.Handle), "initWithTextAlignment:location:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_nfloat_IntPtr(base.SuperHandle, selInitWithTextAlignment_Location_Options_Handle, (ulong)alignment, loc, options.Handle), "initWithTextAlignment:location:options:");
		}
	}

	[Export("initWithType:location:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextTab(NSTextTabType type, nfloat loc)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_nfloat(base.Handle, selInitWithType_Location_Handle, (ulong)type, loc), "initWithType:location:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_nfloat(base.SuperHandle, selInitWithType_Location_Handle, (ulong)type, loc), "initWithType:location:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("columnTerminatorsForLocale:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet GetColumnTerminators(NSLocale? locale)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColumnTerminatorsForLocale_Handle, locale?.Handle ?? IntPtr.Zero));
	}
}
