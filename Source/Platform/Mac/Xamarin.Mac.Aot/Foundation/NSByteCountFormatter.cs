using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSByteCountFormatter", true)]
public class NSByteCountFormatter : NSFormatter
{
	private static readonly IntPtr selAllowsNonnumericFormattingHandle = Selector.GetHandle("allowsNonnumericFormatting");

	private static readonly IntPtr selSetAllowsNonnumericFormatting_Handle = Selector.GetHandle("setAllowsNonnumericFormatting:");

	private static readonly IntPtr selIncludesUnitHandle = Selector.GetHandle("includesUnit");

	private static readonly IntPtr selSetIncludesUnit_Handle = Selector.GetHandle("setIncludesUnit:");

	private static readonly IntPtr selIncludesCountHandle = Selector.GetHandle("includesCount");

	private static readonly IntPtr selSetIncludesCount_Handle = Selector.GetHandle("setIncludesCount:");

	private static readonly IntPtr selIncludesActualByteCountHandle = Selector.GetHandle("includesActualByteCount");

	private static readonly IntPtr selSetIncludesActualByteCount_Handle = Selector.GetHandle("setIncludesActualByteCount:");

	private static readonly IntPtr selIsAdaptiveHandle = Selector.GetHandle("isAdaptive");

	private static readonly IntPtr selSetAdaptive_Handle = Selector.GetHandle("setAdaptive:");

	private static readonly IntPtr selZeroPadsFractionDigitsHandle = Selector.GetHandle("zeroPadsFractionDigits");

	private static readonly IntPtr selSetZeroPadsFractionDigits_Handle = Selector.GetHandle("setZeroPadsFractionDigits:");

	private static readonly IntPtr selAllowedUnitsHandle = Selector.GetHandle("allowedUnits");

	private static readonly IntPtr selSetAllowedUnits_Handle = Selector.GetHandle("setAllowedUnits:");

	private static readonly IntPtr selCountStyleHandle = Selector.GetHandle("countStyle");

	private static readonly IntPtr selSetCountStyle_Handle = Selector.GetHandle("setCountStyle:");

	private static readonly IntPtr selStringFromByteCountCountStyle_Handle = Selector.GetHandle("stringFromByteCount:countStyle:");

	private static readonly IntPtr selStringFromByteCount_Handle = Selector.GetHandle("stringFromByteCount:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSByteCountFormatter");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool AllowsNonnumericFormatting
	{
		[Export("allowsNonnumericFormatting")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsNonnumericFormattingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsNonnumericFormattingHandle);
		}
		[Export("setAllowsNonnumericFormatting:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsNonnumericFormatting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsNonnumericFormatting_Handle, value);
			}
		}
	}

	public virtual bool IncludesUnit
	{
		[Export("includesUnit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesUnitHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesUnitHandle);
		}
		[Export("setIncludesUnit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesUnit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesUnit_Handle, value);
			}
		}
	}

	public virtual bool IncludesCount
	{
		[Export("includesCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesCountHandle);
		}
		[Export("setIncludesCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesCount_Handle, value);
			}
		}
	}

	public virtual bool IncludesActualByteCount
	{
		[Export("includesActualByteCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesActualByteCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesActualByteCountHandle);
		}
		[Export("setIncludesActualByteCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesActualByteCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesActualByteCount_Handle, value);
			}
		}
	}

	public virtual bool Adaptive
	{
		[Export("isAdaptive")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdaptiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdaptiveHandle);
		}
		[Export("setAdaptive:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAdaptive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAdaptive_Handle, value);
			}
		}
	}

	public virtual bool ZeroPadsFractionDigits
	{
		[Export("zeroPadsFractionDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selZeroPadsFractionDigitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selZeroPadsFractionDigitsHandle);
		}
		[Export("setZeroPadsFractionDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetZeroPadsFractionDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetZeroPadsFractionDigits_Handle, value);
			}
		}
	}

	public virtual NSByteCountFormatterUnits AllowedUnits
	{
		[Export("allowedUnits")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSByteCountFormatterUnits)Messaging.UInt64_objc_msgSend(base.Handle, selAllowedUnitsHandle);
			}
			return (NSByteCountFormatterUnits)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAllowedUnitsHandle);
		}
		[Export("setAllowedUnits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAllowedUnits_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAllowedUnits_Handle, (ulong)value);
			}
		}
	}

	public virtual NSByteCountFormatterCountStyle CountStyle
	{
		[Export("countStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSByteCountFormatterCountStyle)Messaging.Int64_objc_msgSend(base.Handle, selCountStyleHandle);
			}
			return (NSByteCountFormatterCountStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCountStyleHandle);
		}
		[Export("setCountStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCountStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCountStyle_Handle, (long)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSByteCountFormatter()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSByteCountFormatter(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSByteCountFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSByteCountFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stringFromByteCount:countStyle:")]
	public static string Format(long byteCount, NSByteCountFormatterCountStyle countStyle)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64_Int64(class_ptr, selStringFromByteCountCountStyle_Handle, byteCount, (long)countStyle));
	}

	[Export("stringFromByteCount:")]
	public virtual string Format(long byteCount)
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selStringFromByteCount_Handle, byteCount));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selStringFromByteCount_Handle, byteCount));
	}
}
