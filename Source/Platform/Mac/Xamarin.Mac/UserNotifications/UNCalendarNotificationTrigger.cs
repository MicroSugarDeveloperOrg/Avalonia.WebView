using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNCalendarNotificationTrigger", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class UNCalendarNotificationTrigger : UNNotificationTrigger
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateComponents = "dateComponents";

	private static readonly IntPtr selDateComponentsHandle = Selector.GetHandle("dateComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextTriggerDate = "nextTriggerDate";

	private static readonly IntPtr selNextTriggerDateHandle = Selector.GetHandle("nextTriggerDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriggerWithDateMatchingComponents_Repeats_ = "triggerWithDateMatchingComponents:repeats:";

	private static readonly IntPtr selTriggerWithDateMatchingComponents_Repeats_Handle = Selector.GetHandle("triggerWithDateMatchingComponents:repeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNCalendarNotificationTrigger");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents DateComponents
	{
		[Export("dateComponents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateComponentsHandle));
			}
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateComponentsHandle));
		}
	}

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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public UNCalendarNotificationTrigger(NSCoder coder)
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
	protected UNCalendarNotificationTrigger(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNCalendarNotificationTrigger(IntPtr handle)
		: base(handle)
	{
	}

	[Export("triggerWithDateMatchingComponents:repeats:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNCalendarNotificationTrigger CreateTrigger(NSDateComponents dateComponents, bool repeats)
	{
		if (dateComponents == null)
		{
			throw new ArgumentNullException("dateComponents");
		}
		return Runtime.GetNSObject<UNCalendarNotificationTrigger>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selTriggerWithDateMatchingComponents_Repeats_Handle, dateComponents.Handle, repeats));
	}
}
