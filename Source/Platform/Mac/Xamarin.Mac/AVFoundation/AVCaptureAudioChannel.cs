using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureAudioChannel", true)]
public class AVCaptureAudioChannel : NSObject
{
	private static readonly IntPtr selPeakHoldLevelHandle = Selector.GetHandle("peakHoldLevel");

	private static readonly IntPtr selAveragePowerLevelHandle = Selector.GetHandle("averagePowerLevel");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureAudioChannel");

	public override IntPtr ClassHandle => class_ptr;

	public virtual float PeakHoldLevel
	{
		[Export("peakHoldLevel")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPeakHoldLevelHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPeakHoldLevelHandle);
		}
	}

	public virtual float AveragePowerLevel
	{
		[Export("averagePowerLevel")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAveragePowerLevelHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAveragePowerLevelHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureAudioChannel()
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
	public AVCaptureAudioChannel(NSCoder coder)
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
	public AVCaptureAudioChannel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureAudioChannel(IntPtr handle)
		: base(handle)
	{
	}
}
