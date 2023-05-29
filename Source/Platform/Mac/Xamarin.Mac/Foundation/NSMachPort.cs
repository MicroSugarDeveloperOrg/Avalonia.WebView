using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMachPort", true)]
public class NSMachPort : NSPort
{
	private static readonly IntPtr selMachPortHandle = Selector.GetHandle("machPort");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selPortWithMachPort_Handle = Selector.GetHandle("portWithMachPort:");

	private static readonly IntPtr selPortWithMachPortOptions_Handle = Selector.GetHandle("portWithMachPort:options:");

	private static readonly IntPtr selRemoveFromRunLoopForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	private static readonly IntPtr selScheduleInRunLoopForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMachPort");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual uint MachPort
	{
		[Export("machPort")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMachPortHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMachPortHandle);
		}
	}

	public new virtual NSObject WeakDelegate
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

	public new NSMachPortDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSMachPortDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMachPort()
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
	public NSMachPort(NSCoder coder)
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
	public NSMachPort(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMachPort(IntPtr handle)
		: base(handle)
	{
	}

	[Export("portWithMachPort:")]
	public static NSPort FromMachPort(uint port)
	{
		return (NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selPortWithMachPort_Handle, port));
	}

	[Export("portWithMachPort:options:")]
	public static NSPort FromMachPort(uint port, NSMachPortRights options)
	{
		return (NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32_UInt64(class_ptr, selPortWithMachPortOptions_Handle, port, (ulong)options));
	}

	[Export("removeFromRunLoop:forMode:")]
	public virtual void RemoveFromRunLoop(NSRunLoop runLoop, NSString mode)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveFromRunLoopForMode_Handle, runLoop.Handle, mode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveFromRunLoopForMode_Handle, runLoop.Handle, mode.Handle);
		}
	}

	[Export("scheduleInRunLoop:forMode:")]
	public virtual void ScheduleInRunLoop(NSRunLoop runLoop, NSString mode)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoopForMode_Handle, runLoop.Handle, mode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoopForMode_Handle, runLoop.Handle, mode.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
