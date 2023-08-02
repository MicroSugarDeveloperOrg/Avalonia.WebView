using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTimeZone", true)]
public class NSTimeZone : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selLocalTimeZoneHandle = Selector.GetHandle("localTimeZone");

	private static readonly IntPtr selSecondsFromGMTHandle = Selector.GetHandle("secondsFromGMT");

	private static readonly IntPtr selDefaultTimeZoneHandle = Selector.GetHandle("defaultTimeZone");

	private static readonly IntPtr selSetDefaultTimeZone_Handle = Selector.GetHandle("setDefaultTimeZone:");

	private static readonly IntPtr selSystemTimeZoneHandle = Selector.GetHandle("systemTimeZone");

	private static readonly IntPtr selKnownTimeZoneNamesHandle = Selector.GetHandle("knownTimeZoneNames");

	private static readonly IntPtr selTimeZoneDataVersionHandle = Selector.GetHandle("timeZoneDataVersion");

	private static readonly IntPtr selInitWithName_Handle = Selector.GetHandle("initWithName:");

	private static readonly IntPtr selInitWithNameData_Handle = Selector.GetHandle("initWithName:data:");

	private static readonly IntPtr selSecondsFromGMTForDate_Handle = Selector.GetHandle("secondsFromGMTForDate:");

	private static readonly IntPtr selAbbreviationForDate_Handle = Selector.GetHandle("abbreviationForDate:");

	private static readonly IntPtr selIsDaylightSavingTimeForDate_Handle = Selector.GetHandle("isDaylightSavingTimeForDate:");

	private static readonly IntPtr selDaylightSavingTimeOffsetForDate_Handle = Selector.GetHandle("daylightSavingTimeOffsetForDate:");

	private static readonly IntPtr selNextDaylightSavingTimeTransitionAfterDate_Handle = Selector.GetHandle("nextDaylightSavingTimeTransitionAfterDate:");

	private static readonly IntPtr selTimeZoneWithName_Handle = Selector.GetHandle("timeZoneWithName:");

	private static readonly IntPtr selTimeZoneWithNameData_Handle = Selector.GetHandle("timeZoneWithName:data:");

	private static readonly IntPtr selResetSystemTimeZoneHandle = Selector.GetHandle("resetSystemTimeZone");

	private static readonly IntPtr selTimeZoneWithAbbreviation_Handle = Selector.GetHandle("timeZoneWithAbbreviation:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTimeZone");

	private object __mt_Data_var;

	private static object __mt_LocalTimeZone_var_static;

	private static object __mt_DefaultTimeZone_var_static;

	private static object __mt_SystemTimeZone_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

	public static NSTimeZone LocalTimeZone
	{
		[Export("localTimeZone")]
		get
		{
			return (NSTimeZone)(__mt_LocalTimeZone_var_static = (NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLocalTimeZoneHandle)));
		}
	}

	public virtual long GetSecondsFromGMT
	{
		[Export("secondsFromGMT")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSecondsFromGMTHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSecondsFromGMTHandle);
		}
	}

	public static NSTimeZone DefaultTimeZone
	{
		[Export("defaultTimeZone")]
		get
		{
			return (NSTimeZone)(__mt_DefaultTimeZone_var_static = (NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultTimeZoneHandle)));
		}
		[Export("setDefaultTimeZone:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetDefaultTimeZone_Handle, value.Handle);
		}
	}

	public static NSTimeZone SystemTimeZone
	{
		[Export("systemTimeZone")]
		get
		{
			return (NSTimeZone)(__mt_SystemTimeZone_var_static = (NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemTimeZoneHandle)));
		}
	}

	internal static string[] _KnownTimeZoneNames
	{
		[Export("knownTimeZoneNames")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selKnownTimeZoneNamesHandle));
		}
	}

	public static string DataVersion
	{
		[Export("timeZoneDataVersion")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selTimeZoneDataVersionHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTimeZone(NSCoder coder)
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
	public NSTimeZone(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTimeZone(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:")]
	public NSTimeZone(string name)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithName_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:data:")]
	public NSTimeZone(string name, NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNameData_Handle, arg, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNameData_Handle, arg, data.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("secondsFromGMTForDate:")]
	public virtual long SecondsFromGMT(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selSecondsFromGMTForDate_Handle, date.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selSecondsFromGMTForDate_Handle, date.Handle);
	}

	[Export("abbreviationForDate:")]
	public virtual string Abbreviation(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAbbreviationForDate_Handle, date.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAbbreviationForDate_Handle, date.Handle));
	}

	[Export("isDaylightSavingTimeForDate:")]
	public virtual bool IsDaylightSavingsTime(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDaylightSavingTimeForDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDaylightSavingTimeForDate_Handle, date.Handle);
	}

	[Export("daylightSavingTimeOffsetForDate:")]
	public virtual double DaylightSavingTimeOffset(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDaylightSavingTimeOffsetForDate_Handle, date.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDaylightSavingTimeOffsetForDate_Handle, date.Handle);
	}

	[Export("nextDaylightSavingTimeTransitionAfterDate:")]
	public virtual NSDate NextDaylightSavingTimeTransitionAfter(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNextDaylightSavingTimeTransitionAfterDate_Handle, date.Handle));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNextDaylightSavingTimeTransitionAfterDate_Handle, date.Handle));
	}

	[Export("timeZoneWithName:")]
	public static NSTimeZone FromName(string tzName)
	{
		if (tzName == null)
		{
			throw new ArgumentNullException("tzName");
		}
		IntPtr arg = NSString.CreateNative(tzName);
		NSTimeZone result = (NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTimeZoneWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("timeZoneWithName:data:")]
	public static NSTimeZone FromName(string tzName, NSData data)
	{
		if (tzName == null)
		{
			throw new ArgumentNullException("tzName");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(tzName);
		NSTimeZone result = (NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTimeZoneWithNameData_Handle, arg, data.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("resetSystemTimeZone")]
	public static void ResetSystemTimeZone()
	{
		Messaging.void_objc_msgSend(class_ptr, selResetSystemTimeZoneHandle);
	}

	[Export("timeZoneWithAbbreviation:")]
	public static NSTimeZone FromAbbreviation(string abbreviation)
	{
		if (abbreviation == null)
		{
			throw new ArgumentNullException("abbreviation");
		}
		IntPtr arg = NSString.CreateNative(abbreviation);
		NSTimeZone result = (NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTimeZoneWithAbbreviation_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Data_var = null;
		}
	}
}
