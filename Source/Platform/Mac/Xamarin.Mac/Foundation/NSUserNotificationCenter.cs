using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSUserNotificationCenter", true)]
[Advice("'NSUserNotification' usages should be replaced with 'UserNotifications' framework.")]
public class NSUserNotificationCenter : NSObject
{
	[Register]
	internal class _NSUserNotificationCenterDelegate : NSObject, INSUserNotificationCenterDelegate, INativeObject, IDisposable
	{
		internal EventHandler<UNCDidActivateNotificationEventArgs>? didActivateNotification;

		internal EventHandler<UNCDidDeliverNotificationEventArgs>? didDeliverNotification;

		internal UNCShouldPresentNotification? shouldPresentNotification;

		public _NSUserNotificationCenterDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("userNotificationCenter:didActivateNotification:")]
		public void DidActivateNotification(NSUserNotificationCenter center, NSUserNotification notification)
		{
			EventHandler<UNCDidActivateNotificationEventArgs> eventHandler = didActivateNotification;
			if (eventHandler != null)
			{
				UNCDidActivateNotificationEventArgs e = new UNCDidActivateNotificationEventArgs(notification);
				eventHandler(center, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("userNotificationCenter:didDeliverNotification:")]
		public void DidDeliverNotification(NSUserNotificationCenter center, NSUserNotification notification)
		{
			EventHandler<UNCDidDeliverNotificationEventArgs> eventHandler = didDeliverNotification;
			if (eventHandler != null)
			{
				UNCDidDeliverNotificationEventArgs e = new UNCDidDeliverNotificationEventArgs(notification);
				eventHandler(center, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("userNotificationCenter:shouldPresentNotification:")]
		public bool ShouldPresentNotification(NSUserNotificationCenter center, NSUserNotification notification)
		{
			return shouldPresentNotification?.Invoke(center, notification) ?? false;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultUserNotificationCenter = "defaultUserNotificationCenter";

	private static readonly IntPtr selDefaultUserNotificationCenterHandle = Selector.GetHandle("defaultUserNotificationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeliverNotification_ = "deliverNotification:";

	private static readonly IntPtr selDeliverNotification_Handle = Selector.GetHandle("deliverNotification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeliveredNotifications = "deliveredNotifications";

	private static readonly IntPtr selDeliveredNotificationsHandle = Selector.GetHandle("deliveredNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllDeliveredNotifications = "removeAllDeliveredNotifications";

	private static readonly IntPtr selRemoveAllDeliveredNotificationsHandle = Selector.GetHandle("removeAllDeliveredNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDeliveredNotification_ = "removeDeliveredNotification:";

	private static readonly IntPtr selRemoveDeliveredNotification_Handle = Selector.GetHandle("removeDeliveredNotification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveScheduledNotification_ = "removeScheduledNotification:";

	private static readonly IntPtr selRemoveScheduledNotification_Handle = Selector.GetHandle("removeScheduledNotification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleNotification_ = "scheduleNotification:";

	private static readonly IntPtr selScheduleNotification_Handle = Selector.GetHandle("scheduleNotification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduledNotifications = "scheduledNotifications";

	private static readonly IntPtr selScheduledNotificationsHandle = Selector.GetHandle("scheduledNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScheduledNotifications_ = "setScheduledNotifications:";

	private static readonly IntPtr selSetScheduledNotifications_Handle = Selector.GetHandle("setScheduledNotifications:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUserNotificationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserNotificationCenter DefaultUserNotificationCenter
	{
		[Export("defaultUserNotificationCenter")]
		get
		{
			return Runtime.GetNSObject<NSUserNotificationCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultUserNotificationCenterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSUserNotificationCenterDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSUserNotificationCenterDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUserNotification[] DeliveredNotifications
	{
		[Export("deliveredNotifications")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeliveredNotificationsHandle));
			}
			return NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeliveredNotificationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUserNotification[] ScheduledNotifications
	{
		[Export("scheduledNotifications", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSend(base.Handle, selScheduledNotificationsHandle));
			}
			return NSArray.ArrayFromHandle<NSUserNotification>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScheduledNotificationsHandle));
		}
		[Export("setScheduledNotifications:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScheduledNotifications_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScheduledNotifications_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSUserNotificationCenterDelegate);

	public UNCShouldPresentNotification? ShouldPresentNotification
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUserNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUserNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("deliverNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeliverNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeliverNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeliverNotification_Handle, notification.Handle);
		}
	}

	[Export("removeAllDeliveredNotifications")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllDeliveredNotifications()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllDeliveredNotificationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllDeliveredNotificationsHandle);
		}
	}

	[Export("removeDeliveredNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDeliveredNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDeliveredNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDeliveredNotification_Handle, notification.Handle);
		}
	}

	[Export("removeScheduledNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveScheduledNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveScheduledNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveScheduledNotification_Handle, notification.Handle);
		}
	}

	[Export("scheduleNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScheduleNotification(NSUserNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScheduleNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScheduleNotification_Handle, notification.Handle);
		}
	}

	internal virtual _NSUserNotificationCenterDelegate CreateInternalEventDelegateType()
	{
		return new _NSUserNotificationCenterDelegate();
	}

	internal _NSUserNotificationCenterDelegate EnsureNSUserNotificationCenterDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSUserNotificationCenterDelegate nSUserNotificationCenterDelegate = Delegate as _NSUserNotificationCenterDelegate;
		if (nSUserNotificationCenterDelegate == null)
		{
			nSUserNotificationCenterDelegate = (_NSUserNotificationCenterDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSUserNotificationCenterDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
