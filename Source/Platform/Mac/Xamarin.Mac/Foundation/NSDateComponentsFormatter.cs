using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSDateComponentsFormatter", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSDateComponentsFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedUnits = "allowedUnits";

	private static readonly IntPtr selAllowedUnitsHandle = Selector.GetHandle("allowedUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsFractionalUnits = "allowsFractionalUnits";

	private static readonly IntPtr selAllowsFractionalUnitsHandle = Selector.GetHandle("allowsFractionalUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendar = "calendar";

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsesLargestUnit = "collapsesLargestUnit";

	private static readonly IntPtr selCollapsesLargestUnitHandle = Selector.GetHandle("collapsesLargestUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattingContext = "formattingContext";

	private static readonly IntPtr selFormattingContextHandle = Selector.GetHandle("formattingContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetObjectValue_ForString_ErrorDescription_ = "getObjectValue:forString:errorDescription:";

	private static readonly IntPtr selGetObjectValue_ForString_ErrorDescription_Handle = Selector.GetHandle("getObjectValue:forString:errorDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesApproximationPhrase = "includesApproximationPhrase";

	private static readonly IntPtr selIncludesApproximationPhraseHandle = Selector.GetHandle("includesApproximationPhrase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesTimeRemainingPhrase = "includesTimeRemainingPhrase";

	private static readonly IntPtr selIncludesTimeRemainingPhraseHandle = Selector.GetHandle("includesTimeRemainingPhrase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringFromDateComponents_UnitsStyle_ = "localizedStringFromDateComponents:unitsStyle:";

	private static readonly IntPtr selLocalizedStringFromDateComponents_UnitsStyle_Handle = Selector.GetHandle("localizedStringFromDateComponents:unitsStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumUnitCount = "maximumUnitCount";

	private static readonly IntPtr selMaximumUnitCountHandle = Selector.GetHandle("maximumUnitCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceDate = "referenceDate";

	private static readonly IntPtr selReferenceDateHandle = Selector.GetHandle("referenceDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedUnits_ = "setAllowedUnits:";

	private static readonly IntPtr selSetAllowedUnits_Handle = Selector.GetHandle("setAllowedUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsFractionalUnits_ = "setAllowsFractionalUnits:";

	private static readonly IntPtr selSetAllowsFractionalUnits_Handle = Selector.GetHandle("setAllowsFractionalUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendar_ = "setCalendar:";

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsesLargestUnit_ = "setCollapsesLargestUnit:";

	private static readonly IntPtr selSetCollapsesLargestUnit_Handle = Selector.GetHandle("setCollapsesLargestUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormattingContext_ = "setFormattingContext:";

	private static readonly IntPtr selSetFormattingContext_Handle = Selector.GetHandle("setFormattingContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesApproximationPhrase_ = "setIncludesApproximationPhrase:";

	private static readonly IntPtr selSetIncludesApproximationPhrase_Handle = Selector.GetHandle("setIncludesApproximationPhrase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesTimeRemainingPhrase_ = "setIncludesTimeRemainingPhrase:";

	private static readonly IntPtr selSetIncludesTimeRemainingPhrase_Handle = Selector.GetHandle("setIncludesTimeRemainingPhrase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumUnitCount_ = "setMaximumUnitCount:";

	private static readonly IntPtr selSetMaximumUnitCount_Handle = Selector.GetHandle("setMaximumUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReferenceDate_ = "setReferenceDate:";

	private static readonly IntPtr selSetReferenceDate_Handle = Selector.GetHandle("setReferenceDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnitsStyle_ = "setUnitsStyle:";

	private static readonly IntPtr selSetUnitsStyle_Handle = Selector.GetHandle("setUnitsStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZeroFormattingBehavior_ = "setZeroFormattingBehavior:";

	private static readonly IntPtr selSetZeroFormattingBehavior_Handle = Selector.GetHandle("setZeroFormattingBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForObjectValue_ = "stringForObjectValue:";

	private static readonly IntPtr selStringForObjectValue_Handle = Selector.GetHandle("stringForObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromDate_ToDate_ = "stringFromDate:toDate:";

	private static readonly IntPtr selStringFromDate_ToDate_Handle = Selector.GetHandle("stringFromDate:toDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromDateComponents_ = "stringFromDateComponents:";

	private static readonly IntPtr selStringFromDateComponents_Handle = Selector.GetHandle("stringFromDateComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromTimeInterval_ = "stringFromTimeInterval:";

	private static readonly IntPtr selStringFromTimeInterval_Handle = Selector.GetHandle("stringFromTimeInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitsStyle = "unitsStyle";

	private static readonly IntPtr selUnitsStyleHandle = Selector.GetHandle("unitsStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZeroFormattingBehavior = "zeroFormattingBehavior";

	private static readonly IntPtr selZeroFormattingBehaviorHandle = Selector.GetHandle("zeroFormattingBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDateComponentsFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCalendarUnit AllowedUnits
	{
		[Export("allowedUnits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSCalendarUnit)Messaging.UInt64_objc_msgSend(base.Handle, selAllowedUnitsHandle);
			}
			return (NSCalendarUnit)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAllowedUnitsHandle);
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
	public virtual bool AllowsFractionalUnits
	{
		[Export("allowsFractionalUnits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsFractionalUnitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsFractionalUnitsHandle);
		}
		[Export("setAllowsFractionalUnits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsFractionalUnits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsFractionalUnits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCalendar Calendar
	{
		[Export("calendar", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarHandle));
			}
			return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarHandle));
		}
		[Export("setCalendar:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalendar_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalendar_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CollapsesLargestUnit
	{
		[Export("collapsesLargestUnit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCollapsesLargestUnitHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCollapsesLargestUnitHandle);
		}
		[Export("setCollapsesLargestUnit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCollapsesLargestUnit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCollapsesLargestUnit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFormattingContext FormattingContext
	{
		[Export("formattingContext")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFormattingContext)Messaging.Int64_objc_msgSend(base.Handle, selFormattingContextHandle);
			}
			return (NSFormattingContext)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFormattingContextHandle);
		}
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
	public virtual bool IncludesApproximationPhrase
	{
		[Export("includesApproximationPhrase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesApproximationPhraseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesApproximationPhraseHandle);
		}
		[Export("setIncludesApproximationPhrase:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesApproximationPhrase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesApproximationPhrase_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesTimeRemainingPhrase
	{
		[Export("includesTimeRemainingPhrase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesTimeRemainingPhraseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesTimeRemainingPhraseHandle);
		}
		[Export("setIncludesTimeRemainingPhrase:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesTimeRemainingPhrase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesTimeRemainingPhrase_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumUnitCount
	{
		[Export("maximumUnitCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumUnitCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumUnitCountHandle);
		}
		[Export("setMaximumUnitCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumUnitCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumUnitCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSDate? ReferenceDate
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("referenceDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selReferenceDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferenceDateHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setReferenceDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetReferenceDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetReferenceDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponentsFormatterUnitsStyle UnitsStyle
	{
		[Export("unitsStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateComponentsFormatterUnitsStyle)Messaging.Int64_objc_msgSend(base.Handle, selUnitsStyleHandle);
			}
			return (NSDateComponentsFormatterUnitsStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUnitsStyleHandle);
		}
		[Export("setUnitsStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUnitsStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUnitsStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponentsFormatterZeroFormattingBehavior ZeroFormattingBehavior
	{
		[Export("zeroFormattingBehavior")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateComponentsFormatterZeroFormattingBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selZeroFormattingBehaviorHandle);
			}
			return (NSDateComponentsFormatterZeroFormattingBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selZeroFormattingBehaviorHandle);
		}
		[Export("setZeroFormattingBehavior:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetZeroFormattingBehavior_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetZeroFormattingBehavior_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateComponentsFormatter()
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
	public NSDateComponentsFormatter(NSCoder coder)
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
	protected NSDateComponentsFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDateComponentsFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getObjectValue:forString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetObjectValue(out NSObject obj, string str, out string error)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(str);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(base.Handle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2));
		NSString.ReleaseNative(arg3);
		obj = Runtime.GetNSObject<NSObject>(arg);
		error = NSString.FromHandle(arg2);
		return result;
	}

	[Export("localizedStringFromDateComponents:unitsStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizedStringFromDateComponents(NSDateComponents components, NSDateComponentsFormatterUnitsStyle unitsStyle)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(class_ptr, selLocalizedStringFromDateComponents_UnitsStyle_Handle, components.Handle, (long)unitsStyle));
	}

	[Export("stringForObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringForObjectValue(NSObject? obj)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForObjectValue_Handle, obj?.Handle ?? IntPtr.Zero));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForObjectValue_Handle, obj?.Handle ?? IntPtr.Zero));
	}

	[Export("stringFromDate:toDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromDate(NSDate startDate, NSDate endDate)
	{
		if (startDate == null)
		{
			throw new ArgumentNullException("startDate");
		}
		if (endDate == null)
		{
			throw new ArgumentNullException("endDate");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selStringFromDate_ToDate_Handle, startDate.Handle, endDate.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStringFromDate_ToDate_Handle, startDate.Handle, endDate.Handle));
	}

	[Export("stringFromDateComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromDateComponents(NSDateComponents components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromDateComponents_Handle, components.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromDateComponents_Handle, components.Handle));
	}

	[Export("stringFromTimeInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromTimeInterval(double ti)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selStringFromTimeInterval_Handle, ti));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selStringFromTimeInterval_Handle, ti));
	}
}
