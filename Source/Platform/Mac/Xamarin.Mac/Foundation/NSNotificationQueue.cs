using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNotificationQueue", true)]
public class NSNotificationQueue : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultQueue = "defaultQueue";

	private static readonly IntPtr selDefaultQueueHandle = Selector.GetHandle("defaultQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDequeueNotificationsMatching_CoalesceMask_ = "dequeueNotificationsMatching:coalesceMask:";

	private static readonly IntPtr selDequeueNotificationsMatching_CoalesceMask_Handle = Selector.GetHandle("dequeueNotificationsMatching:coalesceMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnqueueNotification_PostingStyle_ = "enqueueNotification:postingStyle:";

	private static readonly IntPtr selEnqueueNotification_PostingStyle_Handle = Selector.GetHandle("enqueueNotification:postingStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnqueueNotification_PostingStyle_CoalesceMask_ForModes_ = "enqueueNotification:postingStyle:coalesceMask:forModes:";

	private static readonly IntPtr selEnqueueNotification_PostingStyle_CoalesceMask_ForModes_Handle = Selector.GetHandle("enqueueNotification:postingStyle:coalesceMask:forModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNotificationCenter_ = "initWithNotificationCenter:";

	private static readonly IntPtr selInitWithNotificationCenter_Handle = Selector.GetHandle("initWithNotificationCenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNotificationQueue");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNotificationQueue DefaultQueue
	{
		[Export("defaultQueue", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSNotificationQueue>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultQueueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNotificationQueue()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSNotificationQueue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNotificationQueue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNotificationCenter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNotificationQueue(NSNotificationCenter notificationCenter)
		: base(NSObjectFlag.Empty)
	{
		if (notificationCenter == null)
		{
			throw new ArgumentNullException("notificationCenter");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNotificationCenter_Handle, notificationCenter.Handle), "initWithNotificationCenter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNotificationCenter_Handle, notificationCenter.Handle), "initWithNotificationCenter:");
		}
	}

	[Export("dequeueNotificationsMatching:coalesceMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DequeueNotificationsMatchingcoalesceMask(NSNotification notification, NSNotificationCoalescing coalesceMask)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selDequeueNotificationsMatching_CoalesceMask_Handle, notification.Handle, (ulong)coalesceMask);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selDequeueNotificationsMatching_CoalesceMask_Handle, notification.Handle, (ulong)coalesceMask);
		}
	}

	[Export("enqueueNotification:postingStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnqueueNotification(NSNotification notification, NSPostingStyle postingStyle)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selEnqueueNotification_PostingStyle_Handle, notification.Handle, (ulong)postingStyle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selEnqueueNotification_PostingStyle_Handle, notification.Handle, (ulong)postingStyle);
		}
	}

	[Export("enqueueNotification:postingStyle:coalesceMask:forModes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr(base.Handle, selEnqueueNotification_PostingStyle_CoalesceMask_ForModes_Handle, notification.Handle, (ulong)postingStyle, (ulong)coalesceMask, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr(base.SuperHandle, selEnqueueNotification_PostingStyle_CoalesceMask_ForModes_Handle, notification.Handle, (ulong)postingStyle, (ulong)coalesceMask, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
