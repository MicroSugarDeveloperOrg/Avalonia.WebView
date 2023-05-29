using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVPlayerItemOutputPullDelegate", true)]
[Model]
public class AVPlayerItemOutputPullDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemOutputPullDelegate()
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
	public AVPlayerItemOutputPullDelegate(NSCoder coder)
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
	public AVPlayerItemOutputPullDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemOutputPullDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("outputMediaDataWillChange:")]
	public virtual void OutputMediaDataWillChange(AVPlayerItemOutput sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outputSequenceWasFlushed:")]
	public virtual void OutputSequenceWasFlushed(AVPlayerItemOutput output)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
