using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace EventKit;

[Register("EKAlarm", true)]
public class EKAlarm : EKObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbsoluteDate = "absoluteDate";

	private static readonly IntPtr selAbsoluteDateHandle = Selector.GetHandle("absoluteDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlarmWithAbsoluteDate_ = "alarmWithAbsoluteDate:";

	private static readonly IntPtr selAlarmWithAbsoluteDate_Handle = Selector.GetHandle("alarmWithAbsoluteDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlarmWithRelativeOffset_ = "alarmWithRelativeOffset:";

	private static readonly IntPtr selAlarmWithRelativeOffset_Handle = Selector.GetHandle("alarmWithRelativeOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmailAddress = "emailAddress";

	private static readonly IntPtr selEmailAddressHandle = Selector.GetHandle("emailAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProximity = "proximity";

	private static readonly IntPtr selProximityHandle = Selector.GetHandle("proximity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelativeOffset = "relativeOffset";

	private static readonly IntPtr selRelativeOffsetHandle = Selector.GetHandle("relativeOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAbsoluteDate_ = "setAbsoluteDate:";

	private static readonly IntPtr selSetAbsoluteDate_Handle = Selector.GetHandle("setAbsoluteDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmailAddress_ = "setEmailAddress:";

	private static readonly IntPtr selSetEmailAddress_Handle = Selector.GetHandle("setEmailAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProximity_ = "setProximity:";

	private static readonly IntPtr selSetProximity_Handle = Selector.GetHandle("setProximity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRelativeOffset_ = "setRelativeOffset:";

	private static readonly IntPtr selSetRelativeOffset_Handle = Selector.GetHandle("setRelativeOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSoundName_ = "setSoundName:";

	private static readonly IntPtr selSetSoundName_Handle = Selector.GetHandle("setSoundName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStructuredLocation_ = "setStructuredLocation:";

	private static readonly IntPtr selSetStructuredLocation_Handle = Selector.GetHandle("setStructuredLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUrl_ = "setUrl:";

	private static readonly IntPtr selSetUrl_Handle = Selector.GetHandle("setUrl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSoundName = "soundName";

	private static readonly IntPtr selSoundNameHandle = Selector.GetHandle("soundName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStructuredLocation = "structuredLocation";

	private static readonly IntPtr selStructuredLocationHandle = Selector.GetHandle("structuredLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKAlarm");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? AbsoluteDate
	{
		[Export("absoluteDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selAbsoluteDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbsoluteDateHandle));
		}
		[Export("setAbsoluteDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAbsoluteDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAbsoluteDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? EmailAddress
	{
		[Export("emailAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmailAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmailAddressHandle));
		}
		[Export("setEmailAddress:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmailAddress_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmailAddress_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKAlarmProximity Proximity
	{
		[Export("proximity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKAlarmProximity)Messaging.Int64_objc_msgSend(base.Handle, selProximityHandle);
			}
			return (EKAlarmProximity)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selProximityHandle);
		}
		[Export("setProximity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetProximity_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetProximity_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double RelativeOffset
	{
		[Export("relativeOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRelativeOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRelativeOffsetHandle);
		}
		[Export("setRelativeOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRelativeOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRelativeOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SoundName
	{
		[Export("soundName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSoundNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSoundNameHandle));
		}
		[Export("setSoundName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSoundName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSoundName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKStructuredLocation? StructuredLocation
	{
		[Export("structuredLocation", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKStructuredLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selStructuredLocationHandle));
			}
			return Runtime.GetNSObject<EKStructuredLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStructuredLocationHandle));
		}
		[Export("setStructuredLocation:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStructuredLocation_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStructuredLocation_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKAlarmType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKAlarmType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (EKAlarmType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual NSUrl? Url
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("url", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setUrl:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUrl_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUrl_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[Obsolete("Use the static methods FromDate or FromTimeInterval to create alarms")]
	public EKAlarm()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EKAlarm(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKAlarm(IntPtr handle)
		: base(handle)
	{
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

	[Export("alarmWithAbsoluteDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EKAlarm FromDate(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		return Runtime.GetNSObject<EKAlarm>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAlarmWithAbsoluteDate_Handle, date.Handle));
	}

	[Export("alarmWithRelativeOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EKAlarm FromTimeInterval(double offsetSeconds)
	{
		return Runtime.GetNSObject<EKAlarm>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selAlarmWithRelativeOffset_Handle, offsetSeconds));
	}
}
