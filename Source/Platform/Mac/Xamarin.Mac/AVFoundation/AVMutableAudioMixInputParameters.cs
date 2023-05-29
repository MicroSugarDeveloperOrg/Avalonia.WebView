using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableAudioMixInputParameters", true)]
public class AVMutableAudioMixInputParameters : AVAudioMixInputParameters
{
	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	private static readonly IntPtr selSetTrackID_Handle = Selector.GetHandle("setTrackID:");

	private static readonly IntPtr selAudioMixInputParametersWithTrack_Handle = Selector.GetHandle("audioMixInputParametersWithTrack:");

	private static readonly IntPtr selAudioMixInputParametersHandle = Selector.GetHandle("audioMixInputParameters");

	private static readonly IntPtr selSetVolumeRampFromStartVolumeToEndVolumeTimeRange_Handle = Selector.GetHandle("setVolumeRampFromStartVolume:toEndVolume:timeRange:");

	private static readonly IntPtr selSetVolumeAtTime_Handle = Selector.GetHandle("setVolume:atTime:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableAudioMixInputParameters");

	public override IntPtr ClassHandle => class_ptr;

	public new virtual int TrackID
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
		[Export("setTrackID:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTrackID_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTrackID_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableAudioMixInputParameters()
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
	public AVMutableAudioMixInputParameters(NSCoder coder)
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
	public AVMutableAudioMixInputParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableAudioMixInputParameters(IntPtr handle)
		: base(handle)
	{
	}

	[Export("audioMixInputParametersWithTrack:")]
	public static AVMutableAudioMixInputParameters FromTrack(AVAssetTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return (AVMutableAudioMixInputParameters)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAudioMixInputParametersWithTrack_Handle, track.Handle));
	}

	[Export("audioMixInputParameters")]
	public static AVMutableAudioMixInputParameters Create()
	{
		return (AVMutableAudioMixInputParameters)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAudioMixInputParametersHandle));
	}

	[Export("setVolumeRampFromStartVolume:toEndVolume:timeRange:")]
	public virtual void SetVolumeRamp(float startVolume, float endVolume, CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float_CMTimeRange(base.Handle, selSetVolumeRampFromStartVolumeToEndVolumeTimeRange_Handle, startVolume, endVolume, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float_CMTimeRange(base.SuperHandle, selSetVolumeRampFromStartVolumeToEndVolumeTimeRange_Handle, startVolume, endVolume, timeRange);
		}
	}

	[Export("setVolume:atTime:")]
	public virtual void SetVolume(float volume, CMTime atTime)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime(base.Handle, selSetVolumeAtTime_Handle, volume, atTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime(base.SuperHandle, selSetVolumeAtTime_Handle, volume, atTime);
		}
	}
}
