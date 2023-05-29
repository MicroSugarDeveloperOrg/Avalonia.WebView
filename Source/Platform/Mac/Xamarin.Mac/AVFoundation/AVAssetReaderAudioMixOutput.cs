using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderAudioMixOutput", true)]
public class AVAssetReaderAudioMixOutput : AVAssetReaderOutput
{
	private static readonly IntPtr selAudioTracksHandle = Selector.GetHandle("audioTracks");

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	private static readonly IntPtr selSetAudioMix_Handle = Selector.GetHandle("setAudioMix:");

	private static readonly IntPtr selAudioSettingsHandle = Selector.GetHandle("audioSettings");

	private static readonly IntPtr selAssetReaderAudioMixOutputWithAudioTracksAudioSettings_Handle = Selector.GetHandle("assetReaderAudioMixOutputWithAudioTracks:audioSettings:");

	private static readonly IntPtr selInitWithAudioTracksAudioSettings_Handle = Selector.GetHandle("initWithAudioTracks:audioSettings:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetReaderAudioMixOutput");

	private object __mt_AudioTracks_var;

	private object __mt_AudioMix_var;

	private object __mt_AudioSettings_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVAssetTrack[] AudioTracks
	{
		[Export("audioTracks")]
		get
		{
			return (AVAssetTrack[])(__mt_AudioTracks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTracksHandle)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTracksHandle))));
		}
	}

	public virtual AVAudioMix AudioMix
	{
		[Export("audioMix", ArgumentSemantic.Copy)]
		get
		{
			return (AVAudioMix)(__mt_AudioMix_var = ((!IsDirectBinding) ? ((AVAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioMixHandle))) : ((AVAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioMixHandle)))));
		}
		[Export("setAudioMix:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioMix_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioMix_Handle, value.Handle);
			}
			__mt_AudioMix_var = value;
		}
	}

	public virtual NSDictionary AudioSettings
	{
		[Export("audioSettings")]
		get
		{
			return (NSDictionary)(__mt_AudioSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioSettingsHandle)))));
		}
	}

	public AudioSettings Settings
	{
		get
		{
			NSDictionary audioSettings = AudioSettings;
			if (audioSettings != null)
			{
				return new AudioSettings(audioSettings);
			}
			return null;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetReaderAudioMixOutput(NSCoder coder)
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
	public AVAssetReaderAudioMixOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetReaderAudioMixOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetReaderAudioMixOutputWithAudioTracks:audioSettings:")]
	public static AVAssetReaderAudioMixOutput FromTracks(AVAssetTrack[] audioTracks, NSDictionary audioSettings)
	{
		if (audioTracks == null)
		{
			throw new ArgumentNullException("audioTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(audioTracks);
		AVAssetReaderAudioMixOutput result = (AVAssetReaderAudioMixOutput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderAudioMixOutputWithAudioTracksAudioSettings_Handle, nSArray.Handle, audioSettings?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	public AVAssetReaderAudioMixOutput Create(AVAssetTrack[] audioTracks, AudioSettings settings)
	{
		return FromTracks(audioTracks, settings?.Dictionary);
	}

	[Export("initWithAudioTracks:audioSettings:")]
	public AVAssetReaderAudioMixOutput(AVAssetTrack[] audioTracks, NSDictionary audioSettings)
		: base(NSObjectFlag.Empty)
	{
		if (audioTracks == null)
		{
			throw new ArgumentNullException("audioTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(audioTracks);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAudioTracksAudioSettings_Handle, nSArray.Handle, audioSettings?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAudioTracksAudioSettings_Handle, nSArray.Handle, audioSettings?.Handle ?? IntPtr.Zero);
		}
		nSArray.Dispose();
	}

	public AVAssetReaderAudioMixOutput(AVAssetTrack[] audioTracks, AudioSettings settings)
		: this(audioTracks, settings?.Dictionary)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AudioTracks_var = null;
			__mt_AudioMix_var = null;
			__mt_AudioSettings_var = null;
		}
	}
}
