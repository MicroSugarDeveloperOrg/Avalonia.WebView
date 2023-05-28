using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace EventKit;

[Register("EKRecurrenceDayOfWeek", true)]
public class EKRecurrenceDayOfWeek : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfTheWeek = "dayOfTheWeek";

	private static readonly IntPtr selDayOfTheWeekHandle = Selector.GetHandle("dayOfTheWeek");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfWeek_ = "dayOfWeek:";

	private static readonly IntPtr selDayOfWeek_Handle = Selector.GetHandle("dayOfWeek:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfWeek_WeekNumber_ = "dayOfWeek:weekNumber:";

	private static readonly IntPtr selDayOfWeek_WeekNumber_Handle = Selector.GetHandle("dayOfWeek:weekNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDayOfTheWeek_WeekNumber_ = "initWithDayOfTheWeek:weekNumber:";

	private static readonly IntPtr selInitWithDayOfTheWeek_WeekNumber_Handle = Selector.GetHandle("initWithDayOfTheWeek:weekNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeekNumber = "weekNumber";

	private static readonly IntPtr selWeekNumberHandle = Selector.GetHandle("weekNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKRecurrenceDayOfWeek");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DayOfTheWeek
	{
		[Export("dayOfTheWeek")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDayOfTheWeekHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDayOfTheWeekHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WeekNumber
	{
		[Export("weekNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWeekNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWeekNumberHandle);
		}
	}

	public static EKRecurrenceDayOfWeek FromDay(EKDay dayOfTheWeek)
	{
		return _FromDay((int)dayOfTheWeek);
	}

	public static EKRecurrenceDayOfWeek FromDay(EKDay dayOfTheWeek, nint weekNumber)
	{
		return _FromDay((int)dayOfTheWeek, weekNumber);
	}

	public static EKRecurrenceDayOfWeek FromWeekDay(nint dayOfWeek, nint weekNumber)
	{
		return FromDay((EKDay)(int)dayOfWeek, weekNumber);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public EKRecurrenceDayOfWeek()
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
	public EKRecurrenceDayOfWeek(NSCoder coder)
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
	protected EKRecurrenceDayOfWeek(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKRecurrenceDayOfWeek(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDayOfTheWeek:weekNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EKRecurrenceDayOfWeek(nint dayOfTheWeek, nint weekNumber)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selInitWithDayOfTheWeek_WeekNumber_Handle, dayOfTheWeek, weekNumber), "initWithDayOfTheWeek:weekNumber:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selInitWithDayOfTheWeek_WeekNumber_Handle, dayOfTheWeek, weekNumber), "initWithDayOfTheWeek:weekNumber:");
		}
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

	[Export("dayOfWeek:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static EKRecurrenceDayOfWeek _FromDay(nint dayOfTheWeek)
	{
		return Runtime.GetNSObject<EKRecurrenceDayOfWeek>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selDayOfWeek_Handle, dayOfTheWeek));
	}

	[Export("dayOfWeek:weekNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static EKRecurrenceDayOfWeek _FromDay(nint dayOfTheWeek, nint weekNumber)
	{
		return Runtime.GetNSObject<EKRecurrenceDayOfWeek>(Messaging.IntPtr_objc_msgSend_nint_nint(class_ptr, selDayOfWeek_WeekNumber_Handle, dayOfTheWeek, weekNumber));
	}
}
