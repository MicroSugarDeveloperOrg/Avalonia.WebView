using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUserNotificationCenter", true)]
[MountainLion]
public class NSUserNotificationCenter : NSObject
{
	[Register]
	private sealed class _NSUserNotificationCenterDelegate : NSUserNotificationCenterDelegate
	{
		internal EventHandler<UNCDidDeliverNotificationEventArgs> didDeliverNotification;

		internal EventHandler<UNCDidActivateNotificationEventArgs> didActivateNotification;

		internal UNCShouldPresentNotification shouldPresentNotification;

		[Preserve(Conditional = true)]
		public override void DidDeliverNotification(NSUserNotificationCenter center, NSUserNotification notification)
		{
			EventHandler<UNCDidDeliverNotificationEventArgs> eventHandler = didDeliverNotification;
			if (eventHandler != null)
			{
				UNCDidDeliverNotificationEventArgs e = new UNCDidDeliverNotificationEventArgs(notification);
				eventHandler(center, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidActivateNotification(NSUserNotificationCenter center, NSUserNotification notification)
		{
			EventHandler<UNCDidActivateNotificationEventArgs> eventHandler = didActivateNotification;
			if (eventHandler != null)
			{
				UNCDidActivateNotificationEventArgs e = new UNCDidActivateNotificationEventArgs(notification);
				eventHandler(center, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool ShouldPresentNotification(NSUserNotificationCenter center, NSUserNotification notification)
		{
			return shouldPresentNotification?.Invoke(center, notification) ?? false;
		}
	}

	private static readonly IntPtr selDefaultUserNotificationCenterHandle = Selector.GetHandle("defaultUserNotificationCenter");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selScheduledNotificationsHandle = Selector.GetHandle("scheduledNotifications");

	private static readonly IntPtr selSetScheduledNotifications_Handle = Selector.GetHandle("setScheduledNotifications:");

	private static readonly IntPtr selDeliveredNotificationsHandle = Selector.GetHandle("deliveredNotifications");

	private static readonly IntPtr selScheduleNotification_Handle = Selector.GetHandle("scheduleNotification:");

	private static readonly IntPtr selRemoveScheduledNotification_Handle = Selector.GetHandle("removeScheduledNotification:");

	private static readonly IntPtr selDeliverNotification_Handle = Selector.GetHandle("deliverNotification:");

	private static readonly IntPtr selRemoveDeliveredNotification_Handle = Selector.GetHandle("removeDeliveredNotification:");

	private static readonly IntPtr selRemoveAllDeliveredNotificationsHandle = Selector.GetHandle("removeAllDeliveredNotifications");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSUserNotificationCenter");

	private static object __mt_DefaultUserNotificationCenter_var_static;

	private object __mt_WeakDelegate_var;

	private object __mt_ScheduledNotifications_var;

	private object __mt_DeliveredNotifications_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSUserNotificationCenter DefaultUserNotificationCenter
	{
		[Export("defaultUserNotificationCenter")]
		get
		{
			return (NSUserNotificationCenter)(__mt_DefaultUserNotificationCenter_var_static = (NSUserNotificationCenter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultUserNotificationCenterHandle)));
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSUserNotificationCenterDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSUserNotificationCenterDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSUserNotification[] ScheduledNotifications
	{
		[Export("scheduledNotifications")]
		get
		{
			return (NSUserNotification[])(__mt_ScheduledNotifications_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScheduledNotificationsHandle)) : NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSend(base.Handle, selScheduledNotificationsHandle))));
		}
		[Export("setScheduledNotifications:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScheduledNotifications_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScheduledNotifications_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_ScheduledNotifications_var = value;
		}
	}

	public virtual NSUserNotification[] DeliveredNotifications
	{
		[Export("deliveredNotifications")]
		get
		{
			return (NSUserNotification[])(__mt_DeliveredNotifications_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeliveredNotificationsHandle)) : NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeliveredNotificationsHandle))));
		}
	}

	public UNCShouldPresentNotification ShouldPresentNotification
	{
		get
		{
			return EnsureNSUserNotificationCenterDelegate().shouldPresentNotification;
		}
		set
		{
			EnsureNSUserNotificationCenterDelegate().shouldPresentNotification = value;
		}
	}

	public event EventHandler<UNCDidDeliverNotificationEventArgs> DidDeliverNotification
	{
		add
		{
			_NSUserNotificationCenterDelegate nSUserNotificationCenterDelegate = EnsureNSUserNotificationCenterDelegate();
			nSUserNotificationCenterDelegate.didDeliverNotification = (EventHandler<UNCDidDeliverNotificationEventArgs>)System.Delegate.Combine(nSUserNotificationCenterDelegate.didDeliverNotification, value);
		}
		remove
		{
			_NSUserNotificationCenterDelegate nSUserNotificationCenterDelegate = EnsureNSUserNotificationCenterDelegate();
			nSUserNotificationCenterDelegate.didDeliverNotification = (EventHandler<UNCDidDeliverNotificationEventArgs>)System.Delegate.Remove(nSUserNotificationCenterDelegate.didDeliverNotification, value);
		}
	}

	public event EventHandler<UNCDidActivateNotificationEventArgs> DidActivateNotification
	{
		add
		{
			_NSUserNotificationCenterDelegate nSUserNotificationCenterDelegate = EnsureNSUserNotificationCenterDelegate();
			nSUserNotificationCenterDelegate.didActivateNotification = (EventHandler<UNCDidActivateNotificationEventArgs>)System.Delegate.Combine(nSUserNotificationCenterDelegate.didActivateNotification, value);
		}
		remove
		{
			_NSUserNotificationCenterDelegate nSUserNotificationCenterDelegate = EnsureNSUserNotificationCenterDelegate();
			nSUserNotificationCenterDelegate.didActivateNotification = (EventHandler<UNCDidActivateNotificationEventArgs>)System.Delegate.Remove(nSUserNotificationCenterDelegate.didActivateNotification, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUserNotificationCenter(NSCoder coder)
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
	public NSUserNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUserNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("scheduleNotification:")]
	public virtual void ScheduleNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScheduleNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScheduleNotification_Handle, notification.Handle);
		}
		_ = ScheduledNotifications;
	}

	[Export("removeScheduledNotification:")]
	public virtual void RemoveScheduledNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveScheduledNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveScheduledNotification_Handle, notification.Handle);
		}
		_ = ScheduledNotifications;
	}

	[Export("deliverNotification:")]
	public virtual void DeliverNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeliverNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeliverNotification_Handle, notification.Handle);
		}
		_ = DeliveredNotifications;
	}

	[Export("removeDeliveredNotification:")]
	public virtual void RemoveDeliveredNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDeliveredNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDeliveredNotification_Handle, notification.Handle);
		}
		_ = DeliveredNotifications;
	}

	[Export("removeAllDeliveredNotifications")]
	public virtual void RemoveAllDeliveredNotifications()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllDeliveredNotificationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllDeliveredNotificationsHandle);
		}
		_ = DeliveredNotifications;
	}

	private _NSUserNotificationCenterDelegate EnsureNSUserNotificationCenterDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSUserNotificationCenterDelegate))
		{
			nSObject = (WeakDelegate = new _NSUserNotificationCenterDelegate());
		}
		return (_NSUserNotificationCenterDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_ScheduledNotifications_var = null;
			__mt_DeliveredNotifications_var = null;
		}
	}
}
