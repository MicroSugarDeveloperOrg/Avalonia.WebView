using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTimeZone", true)]
public class NSTimeZone : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	private static ReadOnlyCollection<string> known_time_zone_names;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbbreviation = "abbreviation";

	private static readonly IntPtr selAbbreviationHandle = Selector.GetHandle("abbreviation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbbreviationDictionary = "abbreviationDictionary";

	private static readonly IntPtr selAbbreviationDictionaryHandle = Selector.GetHandle("abbreviationDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbbreviationForDate_ = "abbreviationForDate:";

	private static readonly IntPtr selAbbreviationForDate_Handle = Selector.GetHandle("abbreviationForDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDaylightSavingTimeOffsetForDate_ = "daylightSavingTimeOffsetForDate:";

	private static readonly IntPtr selDaylightSavingTimeOffsetForDate_Handle = Selector.GetHandle("daylightSavingTimeOffsetForDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTimeZone = "defaultTimeZone";

	private static readonly IntPtr selDefaultTimeZoneHandle = Selector.GetHandle("defaultTimeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ = "initWithName:";

	private static readonly IntPtr selInitWithName_Handle = Selector.GetHandle("initWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Data_ = "initWithName:data:";

	private static readonly IntPtr selInitWithName_Data_Handle = Selector.GetHandle("initWithName:data:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDaylightSavingTimeForDate_ = "isDaylightSavingTimeForDate:";

	private static readonly IntPtr selIsDaylightSavingTimeForDate_Handle = Selector.GetHandle("isDaylightSavingTimeForDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnownTimeZoneNames = "knownTimeZoneNames";

	private static readonly IntPtr selKnownTimeZoneNamesHandle = Selector.GetHandle("knownTimeZoneNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalTimeZone = "localTimeZone";

	private static readonly IntPtr selLocalTimeZoneHandle = Selector.GetHandle("localTimeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName_Locale_ = "localizedName:locale:";

	private static readonly IntPtr selLocalizedName_Locale_Handle = Selector.GetHandle("localizedName:locale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextDaylightSavingTimeTransitionAfterDate_ = "nextDaylightSavingTimeTransitionAfterDate:";

	private static readonly IntPtr selNextDaylightSavingTimeTransitionAfterDate_Handle = Selector.GetHandle("nextDaylightSavingTimeTransitionAfterDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetSystemTimeZone = "resetSystemTimeZone";

	private static readonly IntPtr selResetSystemTimeZoneHandle = Selector.GetHandle("resetSystemTimeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondsFromGMT = "secondsFromGMT";

	private static readonly IntPtr selSecondsFromGMTHandle = Selector.GetHandle("secondsFromGMT");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondsFromGMTForDate_ = "secondsFromGMTForDate:";

	private static readonly IntPtr selSecondsFromGMTForDate_Handle = Selector.GetHandle("secondsFromGMTForDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultTimeZone_ = "setDefaultTimeZone:";

	private static readonly IntPtr selSetDefaultTimeZone_Handle = Selector.GetHandle("setDefaultTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemTimeZone = "systemTimeZone";

	private static readonly IntPtr selSystemTimeZoneHandle = Selector.GetHandle("systemTimeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZoneDataVersion = "timeZoneDataVersion";

	private static readonly IntPtr selTimeZoneDataVersionHandle = Selector.GetHandle("timeZoneDataVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZoneForSecondsFromGMT_ = "timeZoneForSecondsFromGMT:";

	private static readonly IntPtr selTimeZoneForSecondsFromGMT_Handle = Selector.GetHandle("timeZoneForSecondsFromGMT:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZoneWithAbbreviation_ = "timeZoneWithAbbreviation:";

	private static readonly IntPtr selTimeZoneWithAbbreviation_Handle = Selector.GetHandle("timeZoneWithAbbreviation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZoneWithName_ = "timeZoneWithName:";

	private static readonly IntPtr selTimeZoneWithName_Handle = Selector.GetHandle("timeZoneWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZoneWithName_Data_ = "timeZoneWithName:data:";

	private static readonly IntPtr selTimeZoneWithName_Data_Handle = Selector.GetHandle("timeZoneWithName:data:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTimeZone");

	public static ReadOnlyCollection<string> KnownTimeZoneNames
	{
		get
		{
			if (known_time_zone_names == null)
			{
				known_time_zone_names = new ReadOnlyCollection<string>(_KnownTimeZoneNames);
			}
			return known_time_zone_names;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary Abbreviations
	{
		[Export("abbreviationDictionary")]
		get
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(class_ptr, selAbbreviationDictionaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string DataVersion
	{
		[Export("timeZoneDataVersion")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selTimeZoneDataVersionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimeZone DefaultTimeZone
	{
		[Export("defaultTimeZone", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultTimeZoneHandle));
		}
		[Export("setDefaultTimeZone:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetDefaultTimeZone_Handle, value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetSecondsFromGMT
	{
		[Export("secondsFromGMT")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSecondsFromGMTHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSecondsFromGMTHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimeZone LocalTimeZone
	{
		[Export("localTimeZone", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(class_ptr, selLocalTimeZoneHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimeZone SystemTimeZone
	{
		[Export("systemTimeZone", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemTimeZoneHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static string[] _KnownTimeZoneNames
	{
		[Export("knownTimeZoneNames")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selKnownTimeZoneNamesHandle));
		}
	}

	public override string ToString()
	{
		return Name;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTimeZone(NSCoder coder)
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
	protected NSTimeZone(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTimeZone(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTimeZone(string name)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithName_Handle, arg), "initWithName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithName_Handle, arg), "initWithName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:data:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_Data_Handle, arg, data.Handle), "initWithName:data:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_Data_Handle, arg, data.Handle), "initWithName:data:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("abbreviation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Abbreviation()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAbbreviationHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbbreviationHandle));
	}

	[Export("abbreviationForDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Abbreviation(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAbbreviationForDate_Handle, date.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAbbreviationForDate_Handle, date.Handle));
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("daylightSavingTimeOffsetForDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DaylightSavingTimeOffset(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDaylightSavingTimeOffsetForDate_Handle, date.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDaylightSavingTimeOffsetForDate_Handle, date.Handle);
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

	[Export("timeZoneWithAbbreviation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimeZone FromAbbreviation(string abbreviation)
	{
		if (abbreviation == null)
		{
			throw new ArgumentNullException("abbreviation");
		}
		IntPtr arg = NSString.CreateNative(abbreviation);
		NSTimeZone nSObject = Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTimeZoneWithAbbreviation_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("timeZoneForSecondsFromGMT:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimeZone FromGMT(nint seconds)
	{
		return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selTimeZoneForSecondsFromGMT_Handle, seconds));
	}

	[Export("timeZoneWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimeZone FromName(string tzName)
	{
		if (tzName == null)
		{
			throw new ArgumentNullException("tzName");
		}
		IntPtr arg = NSString.CreateNative(tzName);
		NSTimeZone nSObject = Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTimeZoneWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("timeZoneWithName:data:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSTimeZone nSObject = Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTimeZoneWithName_Data_Handle, arg, data.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("localizedName:locale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLocalizedName(NSTimeZoneNameStyle style, NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(base.Handle, selLocalizedName_Locale_Handle, (long)style, locale.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selLocalizedName_Locale_Handle, (long)style, locale.Handle));
	}

	[Export("isDaylightSavingTimeForDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDaylightSavingsTime(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDaylightSavingTimeForDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDaylightSavingTimeForDate_Handle, date.Handle);
	}

	[Export("nextDaylightSavingTimeTransitionAfterDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate NextDaylightSavingTimeTransitionAfter(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNextDaylightSavingTimeTransitionAfterDate_Handle, date.Handle));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNextDaylightSavingTimeTransitionAfterDate_Handle, date.Handle));
	}

	[Export("resetSystemTimeZone")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResetSystemTimeZone()
	{
		Messaging.void_objc_msgSend(class_ptr, selResetSystemTimeZoneHandle);
	}

	[Export("secondsFromGMTForDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SecondsFromGMT(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selSecondsFromGMTForDate_Handle, date.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selSecondsFromGMTForDate_Handle, date.Handle);
	}
}
