using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using MediaToolbox;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableAudioMixInputParameters", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMutableAudioMixInputParameters : AVAudioMixInputParameters
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioMixInputParameters = "audioMixInputParameters";

	private static readonly IntPtr selAudioMixInputParametersHandle = Selector.GetHandle("audioMixInputParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioMixInputParametersWithTrack_ = "audioMixInputParametersWithTrack:";

	private static readonly IntPtr selAudioMixInputParametersWithTrack_Handle = Selector.GetHandle("audioMixInputParametersWithTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTapProcessor = "audioTapProcessor";

	private static readonly IntPtr selAudioTapProcessorHandle = Selector.GetHandle("audioTapProcessor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTimePitchAlgorithm = "audioTimePitchAlgorithm";

	private static readonly IntPtr selAudioTimePitchAlgorithmHandle = Selector.GetHandle("audioTimePitchAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTapProcessor_ = "setAudioTapProcessor:";

	private static readonly IntPtr selSetAudioTapProcessor_Handle = Selector.GetHandle("setAudioTapProcessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTimePitchAlgorithm_ = "setAudioTimePitchAlgorithm:";

	private static readonly IntPtr selSetAudioTimePitchAlgorithm_Handle = Selector.GetHandle("setAudioTimePitchAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrackID_ = "setTrackID:";

	private static readonly IntPtr selSetTrackID_Handle = Selector.GetHandle("setTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_AtTime_ = "setVolume:atTime:";

	private static readonly IntPtr selSetVolume_AtTime_Handle = Selector.GetHandle("setVolume:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolumeRampFromStartVolume_ToEndVolume_TimeRange_ = "setVolumeRampFromStartVolume:toEndVolume:timeRange:";

	private static readonly IntPtr selSetVolumeRampFromStartVolume_ToEndVolume_TimeRange_Handle = Selector.GetHandle("setVolumeRampFromStartVolume:toEndVolume:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackID = "trackID";

	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableAudioMixInputParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public override MTAudioProcessingTap? AudioTapProcessor
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("audioTapProcessor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return MTAudioProcessingTap.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTapProcessorHandle));
			}
			return MTAudioProcessingTap.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTapProcessorHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setAudioTapProcessor:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioTapProcessor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioTapProcessor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public override NSString? AudioTimePitchAlgorithm
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("audioTimePitchAlgorithm", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTimePitchAlgorithmHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTimePitchAlgorithmHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAudioTimePitchAlgorithm:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioTimePitchAlgorithm_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioTimePitchAlgorithm_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
		}
		[Export("setTrackID:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTrackID_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTrackID_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableAudioMixInputParameters()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableAudioMixInputParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableAudioMixInputParameters(IntPtr handle)
		: base(handle)
	{
	}

	[Export("audioMixInputParameters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableAudioMixInputParameters Create()
	{
		return Runtime.GetNSObject<AVMutableAudioMixInputParameters>(Messaging.IntPtr_objc_msgSend(class_ptr, selAudioMixInputParametersHandle));
	}

	[Export("audioMixInputParametersWithTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableAudioMixInputParameters FromTrack(AVAssetTrack? track)
	{
		return Runtime.GetNSObject<AVMutableAudioMixInputParameters>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAudioMixInputParametersWithTrack_Handle, track?.Handle ?? IntPtr.Zero));
	}

	[Export("setVolume:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVolume(float volume, CMTime atTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime(base.Handle, selSetVolume_AtTime_Handle, volume, atTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime(base.SuperHandle, selSetVolume_AtTime_Handle, volume, atTime);
		}
	}

	[Export("setVolumeRampFromStartVolume:toEndVolume:timeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVolumeRamp(float startVolume, float endVolume, CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float_CMTimeRange(base.Handle, selSetVolumeRampFromStartVolume_ToEndVolume_TimeRange_Handle, startVolume, endVolume, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float_CMTimeRange(base.SuperHandle, selSetVolumeRampFromStartVolume_ToEndVolume_TimeRange_Handle, startVolume, endVolume, timeRange);
		}
	}
}
