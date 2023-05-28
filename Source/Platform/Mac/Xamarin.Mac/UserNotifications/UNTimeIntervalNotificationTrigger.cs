using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNTimeIntervalNotificationTrigger", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class UNTimeIntervalNotificationTrigger : UNNotificationTrigger
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextTriggerDate = "nextTriggerDate";

	private static readonly IntPtr selNextTriggerDateHandle = Selector.GetHandle("nextTriggerDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeInterval = "timeInterval";

	private static readonly IntPtr selTimeIntervalHandle = Selector.GetHandle("timeInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriggerWithTimeInterval_Repeats_ = "triggerWithTimeInterval:repeats:";

	private static readonly IntPtr selTriggerWithTimeInterval_Repeats_Handle = Selector.GetHandle("triggerWithTimeInterval:repeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNTimeIntervalNotificationTrigger");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? NextTriggerDate
	{
		[Export("nextTriggerDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextTriggerDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextTriggerDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeInterval
	{
		[Export("timeInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public UNTimeIntervalNotificationTrigger(NSCoder coder)
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
	protected UNTimeIntervalNotificationTrigger(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNTimeIntervalNotificationTrigger(IntPtr handle)
		: base(handle)
	{
	}

	[Export("triggerWithTimeInterval:repeats:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNTimeIntervalNotificationTrigger CreateTrigger(double timeInterval, bool repeats)
	{
		return Runtime.GetNSObject<UNTimeIntervalNotificationTrigger>(Messaging.IntPtr_objc_msgSend_Double_bool(class_ptr, selTriggerWithTimeInterval_Repeats_Handle, timeInterval, repeats));
	}
}
