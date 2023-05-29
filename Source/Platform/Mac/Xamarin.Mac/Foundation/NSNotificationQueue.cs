using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNotificationQueue", true)]
public class NSNotificationQueue : NSObject
{
	private static readonly IntPtr selDefaultQueueHandle = Selector.GetHandle("defaultQueue");

	private static readonly IntPtr selInitWithNotificationCenter_Handle = Selector.GetHandle("initWithNotificationCenter:");

	private static readonly IntPtr selEnqueueNotificationPostingStyle_Handle = Selector.GetHandle("enqueueNotification:postingStyle:");

	private static readonly IntPtr selEnqueueNotificationPostingStyleCoalesceMaskForModes_Handle = Selector.GetHandle("enqueueNotification:postingStyle:coalesceMask:forModes:");

	private static readonly IntPtr selDequeueNotificationsMatchingCoalesceMask_Handle = Selector.GetHandle("dequeueNotificationsMatching:coalesceMask:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNotificationQueue");

	[ThreadStatic]
	private static object __mt_DefaultQueue_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSObject DefaultQueue
	{
		[Export("defaultQueue")]
		get
		{
			return (NSObject)(__mt_DefaultQueue_var_static = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultQueueHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNotificationQueue()
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
	public NSNotificationQueue(NSCoder coder)
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
	public NSNotificationQueue(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNotificationQueue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNotificationCenter:")]
	public NSNotificationQueue(NSNotificationCenter notificationCenter)
		: base(NSObjectFlag.Empty)
	{
		if (notificationCenter == null)
		{
			throw new ArgumentNullException("notificationCenter");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNotificationCenter_Handle, notificationCenter.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNotificationCenter_Handle, notificationCenter.Handle);
		}
	}

	[Export("enqueueNotification:postingStyle:")]
	public virtual void EnqueueNotification(NSNotification notification, NSPostingStyle postingStyle)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selEnqueueNotificationPostingStyle_Handle, notification.Handle, (ulong)postingStyle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selEnqueueNotificationPostingStyle_Handle, notification.Handle, (ulong)postingStyle);
		}
	}

	[Export("enqueueNotification:postingStyle:coalesceMask:forModes:")]
	public virtual void EnqueueNotification(NSNotification notification, NSPostingStyle postingStyle, NSNotificationCoalescing coalesceMask, string[] modes)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (modes == null)
		{
			throw new ArgumentNullException("modes");
		}
		NSArray nSArray = NSArray.FromStrings(modes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr(base.Handle, selEnqueueNotificationPostingStyleCoalesceMaskForModes_Handle, notification.Handle, (ulong)postingStyle, (ulong)coalesceMask, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr(base.SuperHandle, selEnqueueNotificationPostingStyleCoalesceMaskForModes_Handle, notification.Handle, (ulong)postingStyle, (ulong)coalesceMask, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("dequeueNotificationsMatching:coalesceMask:")]
	public virtual void DequeueNotificationsMatchingcoalesceMask(NSNotification notification, NSNotificationCoalescing coalesceMask)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selDequeueNotificationsMatchingCoalesceMask_Handle, notification.Handle, (ulong)coalesceMask);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selDequeueNotificationsMatchingCoalesceMask_Handle, notification.Handle, (ulong)coalesceMask);
		}
	}
}
