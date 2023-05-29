using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVAudioRecorderDelegate", true)]
[Model]
public class AVAudioRecorderDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioRecorderDelegate()
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
	public AVAudioRecorderDelegate(NSCoder coder)
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
	public AVAudioRecorderDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioRecorderDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("audioRecorderDidFinishRecording:successfully:")]
	public virtual void FinishedRecording(AVAudioRecorder recorder, bool flag)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("audioRecorderEncodeErrorDidOccur:error:")]
	public virtual void EncoderError(AVAudioRecorder recorder, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
