using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderAudioMixOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetReaderAudioMixOutput : AVAssetReaderOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderAudioMixOutputWithAudioTracks_AudioSettings_ = "assetReaderAudioMixOutputWithAudioTracks:audioSettings:";

	private static readonly IntPtr selAssetReaderAudioMixOutputWithAudioTracks_AudioSettings_Handle = Selector.GetHandle("assetReaderAudioMixOutputWithAudioTracks:audioSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioMix = "audioMix";

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioSettings = "audioSettings";

	private static readonly IntPtr selAudioSettingsHandle = Selector.GetHandle("audioSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTimePitchAlgorithm = "audioTimePitchAlgorithm";

	private static readonly IntPtr selAudioTimePitchAlgorithmHandle = Selector.GetHandle("audioTimePitchAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTracks = "audioTracks";

	private static readonly IntPtr selAudioTracksHandle = Selector.GetHandle("audioTracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioTracks_AudioSettings_ = "initWithAudioTracks:audioSettings:";

	private static readonly IntPtr selInitWithAudioTracks_AudioSettings_Handle = Selector.GetHandle("initWithAudioTracks:audioSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioMix_ = "setAudioMix:";

	private static readonly IntPtr selSetAudioMix_Handle = Selector.GetHandle("setAudioMix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTimePitchAlgorithm_ = "setAudioTimePitchAlgorithm:";

	private static readonly IntPtr selSetAudioTimePitchAlgorithm_Handle = Selector.GetHandle("setAudioTimePitchAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReaderAudioMixOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioMix? AudioMix
	{
		[Export("audioMix", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioMix>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioMixHandle));
			}
			return Runtime.GetNSObject<AVAudioMix>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioMixHandle));
		}
		[Export("setAudioMix:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioMix_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioMix_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'Settings' property.")]
	internal virtual NSDictionary? AudioSettings
	{
		[Export("audioSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioSettingsHandle));
		}
	}

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
	public virtual AVAssetTrack[] AudioTracks
	{
		[Export("audioTracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AudioSettings? Settings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((AudioSettings != null) ? new NSMutableDictionary(AudioSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReaderAudioMixOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReaderAudioMixOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioTracks:audioSettings:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderAudioMixOutput(AVAssetTrack[] audioTracks, NSDictionary? audioSettings)
		: base(NSObjectFlag.Empty)
	{
		if (audioTracks == null)
		{
			throw new ArgumentNullException("audioTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(audioTracks);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAudioTracks_AudioSettings_Handle, nSArray.Handle, audioSettings?.Handle ?? IntPtr.Zero), "initWithAudioTracks:audioSettings:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAudioTracks_AudioSettings_Handle, nSArray.Handle, audioSettings?.Handle ?? IntPtr.Zero), "initWithAudioTracks:audioSettings:");
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderAudioMixOutput(AVAssetTrack[] audioTracks, AudioSettings? settings)
		: this(audioTracks, settings.GetDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderAudioMixOutput Create(AVAssetTrack[] audioTracks, AudioSettings? settings)
	{
		return FromTracks(audioTracks, settings.GetDictionary());
	}

	[Export("assetReaderAudioMixOutputWithAudioTracks:audioSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'Create' method.")]
	internal static AVAssetReaderAudioMixOutput FromTracks(AVAssetTrack[] audioTracks, NSDictionary? audioSettings)
	{
		if (audioTracks == null)
		{
			throw new ArgumentNullException("audioTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(audioTracks);
		AVAssetReaderAudioMixOutput nSObject = Runtime.GetNSObject<AVAssetReaderAudioMixOutput>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderAudioMixOutputWithAudioTracks_AudioSettings_Handle, nSArray.Handle, audioSettings?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}
}
