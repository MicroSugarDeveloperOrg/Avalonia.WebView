using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVAudioPlayerDelegate", true)]
[Model]
public class AVAudioPlayerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioPlayerDelegate()
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
	public AVAudioPlayerDelegate(NSCoder coder)
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
	public AVAudioPlayerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioPlayerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("audioPlayerDidFinishPlaying:successfully:")]
	public virtual void FinishedPlaying(AVAudioPlayer player, bool flag)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("audioPlayerDecodeErrorDidOccur:error:")]
	public virtual void DecoderError(AVAudioPlayer player, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
