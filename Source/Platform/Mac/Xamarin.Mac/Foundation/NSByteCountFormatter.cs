using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSByteCountFormatter", true)]
public class NSByteCountFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedUnits = "allowedUnits";

	private static readonly IntPtr selAllowedUnitsHandle = Selector.GetHandle("allowedUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsNonnumericFormatting = "allowsNonnumericFormatting";

	private static readonly IntPtr selAllowsNonnumericFormattingHandle = Selector.GetHandle("allowsNonnumericFormatting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountStyle = "countStyle";

	private static readonly IntPtr selCountStyleHandle = Selector.GetHandle("countStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattingContext = "formattingContext";

	private static readonly IntPtr selFormattingContextHandle = Selector.GetHandle("formattingContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesActualByteCount = "includesActualByteCount";

	private static readonly IntPtr selIncludesActualByteCountHandle = Selector.GetHandle("includesActualByteCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesCount = "includesCount";

	private static readonly IntPtr selIncludesCountHandle = Selector.GetHandle("includesCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesUnit = "includesUnit";

	private static readonly IntPtr selIncludesUnitHandle = Selector.GetHandle("includesUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdaptive = "isAdaptive";

	private static readonly IntPtr selIsAdaptiveHandle = Selector.GetHandle("isAdaptive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAdaptive_ = "setAdaptive:";

	private static readonly IntPtr selSetAdaptive_Handle = Selector.GetHandle("setAdaptive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedUnits_ = "setAllowedUnits:";

	private static readonly IntPtr selSetAllowedUnits_Handle = Selector.GetHandle("setAllowedUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsNonnumericFormatting_ = "setAllowsNonnumericFormatting:";

	private static readonly IntPtr selSetAllowsNonnumericFormatting_Handle = Selector.GetHandle("setAllowsNonnumericFormatting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCountStyle_ = "setCountStyle:";

	private static readonly IntPtr selSetCountStyle_Handle = Selector.GetHandle("setCountStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormattingContext_ = "setFormattingContext:";

	private static readonly IntPtr selSetFormattingContext_Handle = Selector.GetHandle("setFormattingContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesActualByteCount_ = "setIncludesActualByteCount:";

	private static readonly IntPtr selSetIncludesActualByteCount_Handle = Selector.GetHandle("setIncludesActualByteCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesCount_ = "setIncludesCount:";

	private static readonly IntPtr selSetIncludesCount_Handle = Selector.GetHandle("setIncludesCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesUnit_ = "setIncludesUnit:";

	private static readonly IntPtr selSetIncludesUnit_Handle = Selector.GetHandle("setIncludesUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZeroPadsFractionDigits_ = "setZeroPadsFractionDigits:";

	private static readonly IntPtr selSetZeroPadsFractionDigits_Handle = Selector.GetHandle("setZeroPadsFractionDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForObjectValue_ = "stringForObjectValue:";

	private static readonly IntPtr selStringForObjectValue_Handle = Selector.GetHandle("stringForObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromByteCount_ = "stringFromByteCount:";

	private static readonly IntPtr selStringFromByteCount_Handle = Selector.GetHandle("stringFromByteCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromByteCount_CountStyle_ = "stringFromByteCount:countStyle:";

	private static readonly IntPtr selStringFromByteCount_CountStyle_Handle = Selector.GetHandle("stringFromByteCount:countStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZeroPadsFractionDigits = "zeroPadsFractionDigits";

	private static readonly IntPtr selZeroPadsFractionDigitsHandle = Selector.GetHandle("zeroPadsFractionDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSByteCountFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Adaptive
	{
		[Export("isAdaptive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdaptiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdaptiveHandle);
		}
		[Export("setAdaptive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAdaptive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAdaptive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSByteCountFormatterUnits AllowedUnits
	{
		[Export("allowedUnits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSByteCountFormatterUnits)Messaging.UInt64_objc_msgSend(base.Handle, selAllowedUnitsHandle);
			}
			return (NSByteCountFormatterUnits)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAllowedUnitsHandle);
		}
		[Export("setAllowedUnits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAllowedUnits_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAllowedUnits_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsNonnumericFormatting
	{
		[Export("allowsNonnumericFormatting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsNonnumericFormattingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsNonnumericFormattingHandle);
		}
		[Export("setAllowsNonnumericFormatting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsNonnumericFormatting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsNonnumericFormatting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSByteCountFormatterCountStyle CountStyle
	{
		[Export("countStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSByteCountFormatterCountStyle)Messaging.Int64_objc_msgSend(base.Handle, selCountStyleHandle);
			}
			return (NSByteCountFormatterCountStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCountStyleHandle);
		}
		[Export("setCountStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCountStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCountStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSFormattingContext FormattingContext
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("formattingContext")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFormattingContext)Messaging.Int64_objc_msgSend(base.Handle, selFormattingContextHandle);
			}
			return (NSFormattingContext)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFormattingContextHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setFormattingContext:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFormattingContext_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFormattingContext_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesActualByteCount
	{
		[Export("includesActualByteCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesActualByteCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesActualByteCountHandle);
		}
		[Export("setIncludesActualByteCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesActualByteCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesActualByteCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesCount
	{
		[Export("includesCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesCountHandle);
		}
		[Export("setIncludesCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesUnit
	{
		[Export("includesUnit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesUnitHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesUnitHandle);
		}
		[Export("setIncludesUnit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesUnit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesUnit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ZeroPadsFractionDigits
	{
		[Export("zeroPadsFractionDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selZeroPadsFractionDigitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selZeroPadsFractionDigitsHandle);
		}
		[Export("setZeroPadsFractionDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetZeroPadsFractionDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetZeroPadsFractionDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSByteCountFormatter()
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
	public NSByteCountFormatter(NSCoder coder)
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
	protected NSByteCountFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSByteCountFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stringFromByteCount:countStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string Format(long byteCount, NSByteCountFormatterCountStyle countStyle)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64_Int64(class_ptr, selStringFromByteCount_CountStyle_Handle, byteCount, (long)countStyle));
	}

	[Export("stringFromByteCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Format(long byteCount)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selStringFromByteCount_Handle, byteCount));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selStringFromByteCount_Handle, byteCount));
	}

	[Export("stringForObjectValue:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetString(NSObject? obj)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForObjectValue_Handle, obj?.Handle ?? IntPtr.Zero));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForObjectValue_Handle, obj?.Handle ?? IntPtr.Zero));
	}
}
