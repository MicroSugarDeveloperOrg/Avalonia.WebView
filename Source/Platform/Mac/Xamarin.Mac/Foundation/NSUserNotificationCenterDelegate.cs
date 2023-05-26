using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUserNotificationCenterDelegate", true)]
[Model]
[MountainLion]
public class NSUserNotificationCenterDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserNotificationCenterDelegate()
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
	public NSUserNotificationCenterDelegate(NSCoder coder)
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
	public NSUserNotificationCenterDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUserNotificationCenterDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("userNotificationCenter:didDeliverNotification:")]
	public virtual void DidDeliverNotification(NSUserNotificationCenter center, NSUserNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("userNotificationCenter:didActivateNotification:")]
	public virtual void DidActivateNotification(NSUserNotificationCenter center, NSUserNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("userNotificationCenter:shouldPresentNotification:")]
	public virtual bool ShouldPresentNotification(NSUserNotificationCenter center, NSUserNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
