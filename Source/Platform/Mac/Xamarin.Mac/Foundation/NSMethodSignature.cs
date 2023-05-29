using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMethodSignature", true)]
public class NSMethodSignature : NSObject
{
	private static readonly IntPtr selNumberOfArgumentsHandle = Selector.GetHandle("numberOfArguments");

	private static readonly IntPtr selFrameLengthHandle = Selector.GetHandle("frameLength");

	private static readonly IntPtr selMethodReturnLengthHandle = Selector.GetHandle("methodReturnLength");

	private static readonly IntPtr selIsOnewayHandle = Selector.GetHandle("isOneway");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMethodSignature");

	public override IntPtr ClassHandle => class_ptr;

	public virtual uint NumberOfArguments
	{
		[Export("numberOfArguments")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selNumberOfArgumentsHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selNumberOfArgumentsHandle);
		}
	}

	public virtual uint FrameLength
	{
		[Export("frameLength")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFrameLengthHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFrameLengthHandle);
		}
	}

	public virtual uint MethodReturnLength
	{
		[Export("methodReturnLength")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMethodReturnLengthHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMethodReturnLengthHandle);
		}
	}

	public virtual bool IsOneway
	{
		[Export("isOneway")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOnewayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOnewayHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMethodSignature(NSCoder coder)
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
	public NSMethodSignature(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMethodSignature(IntPtr handle)
		: base(handle)
	{
	}
}
