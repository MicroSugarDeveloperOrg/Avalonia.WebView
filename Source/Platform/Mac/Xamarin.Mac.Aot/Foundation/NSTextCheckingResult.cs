using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTextCheckingResult", true)]
public class NSTextCheckingResult : NSObject
{
	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	private static readonly IntPtr selRangeHandle = Selector.GetHandle("range");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextCheckingResult");

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTextCheckingType ResultType
	{
		[Export("resultType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSTextCheckingType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSTextCheckingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
	}

	public virtual NSRange Range
	{
		[Export("range")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTextCheckingResult(NSCoder coder)
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
	public NSTextCheckingResult(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextCheckingResult(IntPtr handle)
		: base(handle)
	{
	}
}
