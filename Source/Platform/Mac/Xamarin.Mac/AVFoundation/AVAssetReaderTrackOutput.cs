using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderTrackOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetReaderTrackOutput : AVAssetReaderOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderTrackOutputWithTrack_OutputSettings_ = "assetReaderTrackOutputWithTrack:outputSettings:";

	private static readonly IntPtr selAssetReaderTrackOutputWithTrack_OutputSettings_Handle = Selector.GetHandle("assetReaderTrackOutputWithTrack:outputSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTimePitchAlgorithm = "audioTimePitchAlgorithm";

	private static readonly IntPtr selAudioTimePitchAlgorithmHandle = Selector.GetHandle("audioTimePitchAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTrack_OutputSettings_ = "initWithTrack:outputSettings:";

	private static readonly IntPtr selInitWithTrack_OutputSettings_Handle = Selector.GetHandle("initWithTrack:outputSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputSettings = "outputSettings";

	private static readonly IntPtr selOutputSettingsHandle = Selector.GetHandle("outputSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTimePitchAlgorithm_ = "setAudioTimePitchAlgorithm:";

	private static readonly IntPtr selSetAudioTimePitchAlgorithm_Handle = Selector.GetHandle("setAudioTimePitchAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrack = "track";

	private static readonly IntPtr selTrackHandle = Selector.GetHandle("track");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReaderTrackOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSString AudioTimePitchAlgorithm
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAudioTimePitchAlgorithm:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioTimePitchAlgorithm_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioTimePitchAlgorithm_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? OutputSettings
	{
		[Export("outputSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack Track
	{
		[Export("track")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackHandle));
			}
			return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReaderTrackOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReaderTrackOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTrack:outputSettings:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderTrackOutput(AVAssetTrack track, NSDictionary? outputSettings)
		: base(NSObjectFlag.Empty)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTrack_OutputSettings_Handle, track.Handle, outputSettings?.Handle ?? IntPtr.Zero), "initWithTrack:outputSettings:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTrack_OutputSettings_Handle, track.Handle, outputSettings?.Handle ?? IntPtr.Zero), "initWithTrack:outputSettings:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderTrackOutput(AVAssetTrack track, AudioSettings? settings)
		: this(track, settings.GetDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderTrackOutput(AVAssetTrack track, AVVideoSettingsUncompressed? settings)
		: this(track, settings.GetDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetReaderTrackOutput Create(AVAssetTrack track, AudioSettings? settings)
	{
		return FromTrack(track, settings.GetDictionary());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetReaderTrackOutput Create(AVAssetTrack track, AVVideoSettingsUncompressed? settings)
	{
		return FromTrack(track, settings.GetDictionary());
	}

	[Export("assetReaderTrackOutputWithTrack:outputSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'Create' method.")]
	internal static AVAssetReaderTrackOutput FromTrack(AVAssetTrack track, NSDictionary? outputSettings)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return Runtime.GetNSObject<AVAssetReaderTrackOutput>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderTrackOutputWithTrack_OutputSettings_Handle, track.Handle, outputSettings?.Handle ?? IntPtr.Zero));
	}
}
