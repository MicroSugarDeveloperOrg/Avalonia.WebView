using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTouch", true)]
public class NSTouch : NSObject
{
	private static readonly IntPtr selIdentityHandle = Selector.GetHandle("identity");

	private static readonly IntPtr selPhaseHandle = Selector.GetHandle("phase");

	private static readonly IntPtr selNormalizedPositionHandle = Selector.GetHandle("normalizedPosition");

	private static readonly IntPtr selIsRestingHandle = Selector.GetHandle("isResting");

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	private static readonly IntPtr selDeviceSizeHandle = Selector.GetHandle("deviceSize");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTouch");

	private object __mt_Identity_var;

	private object __mt_Device_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Identity
	{
		[Export("identity", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Identity_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentityHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentityHandle))));
		}
	}

	public virtual NSTouchPhase Phase
	{
		[Export("phase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTouchPhase)Messaging.UInt64_objc_msgSend(base.Handle, selPhaseHandle);
			}
			return (NSTouchPhase)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPhaseHandle);
		}
	}

	public virtual CGPoint NormalizedPosition
	{
		[Export("normalizedPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selNormalizedPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selNormalizedPositionHandle);
		}
	}

	public virtual bool IsResting
	{
		[Export("isResting")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRestingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRestingHandle);
		}
	}

	public virtual NSObject Device
	{
		[Export("device", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Device_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle))));
		}
	}

	public virtual CGSize DeviceSize
	{
		[Export("deviceSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selDeviceSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selDeviceSizeHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTouch()
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
	public NSTouch(NSCoder coder)
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
	public NSTouch(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTouch(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Identity_var = null;
			__mt_Device_var = null;
		}
	}
}
