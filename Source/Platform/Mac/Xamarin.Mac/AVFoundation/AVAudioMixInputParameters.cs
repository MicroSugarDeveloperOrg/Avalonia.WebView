using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioMixInputParameters", true)]
public class AVAudioMixInputParameters : NSObject
{
	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	private static readonly IntPtr selGetVolumeRampForTimeStartVolumeEndVolumeTimeRange_Handle = Selector.GetHandle("getVolumeRampForTime:startVolume:endVolume:timeRange:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAudioMixInputParameters");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioMixInputParameters()
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
	public AVAudioMixInputParameters(NSCoder coder)
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
	public AVAudioMixInputParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioMixInputParameters(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getVolumeRampForTime:startVolume:endVolume:timeRange:")]
	public virtual bool GetVolumeRamp(CMTime forTime, ref float startVolume, ref float endVolume, ref CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime_out_Single_out_Single_out_CMTimeRange(base.Handle, selGetVolumeRampForTimeStartVolumeEndVolumeTimeRange_Handle, forTime, out startVolume, out endVolume, out timeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime_out_Single_out_Single_out_CMTimeRange(base.SuperHandle, selGetVolumeRampForTimeStartVolumeEndVolumeTimeRange_Handle, forTime, out startVolume, out endVolume, out timeRange);
	}
}
