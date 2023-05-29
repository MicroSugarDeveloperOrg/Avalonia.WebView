using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderTrackOutput", true)]
public class AVAssetReaderTrackOutput : AVAssetReaderOutput
{
	private static readonly IntPtr selTrackHandle = Selector.GetHandle("track");

	private static readonly IntPtr selOutputSettingsHandle = Selector.GetHandle("outputSettings");

	private static readonly IntPtr selAssetReaderTrackOutputWithTrackOutputSettings_Handle = Selector.GetHandle("assetReaderTrackOutputWithTrack:outputSettings:");

	private static readonly IntPtr selInitWithTrackOutputSettings_Handle = Selector.GetHandle("initWithTrack:outputSettings:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetReaderTrackOutput");

	private object __mt_Track_var;

	private object __mt_OutputSettings_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVAssetTrack Track
	{
		[Export("track")]
		get
		{
			return (AVAssetTrack)(__mt_Track_var = ((!IsDirectBinding) ? ((AVAssetTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackHandle))) : ((AVAssetTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackHandle)))));
		}
	}

	public virtual NSDictionary OutputSettings
	{
		[Export("outputSettings")]
		get
		{
			return (NSDictionary)(__mt_OutputSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputSettingsHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetReaderTrackOutput(NSCoder coder)
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
	public AVAssetReaderTrackOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetReaderTrackOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetReaderTrackOutputWithTrack:outputSettings:")]
	public static AVAssetReaderTrackOutput FromTrack(AVAssetTrack track, NSDictionary outputSettings)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return (AVAssetReaderTrackOutput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderTrackOutputWithTrackOutputSettings_Handle, track.Handle, outputSettings?.Handle ?? IntPtr.Zero));
	}

	public static AVAssetReaderTrackOutput Create(AVAssetTrack track, AudioSettings settings)
	{
		return FromTrack(track, settings?.Dictionary);
	}

	public static AVAssetReaderTrackOutput Create(AVAssetTrack track, AVVideoSettingsUncompressed settings)
	{
		return FromTrack(track, settings?.Dictionary);
	}

	[Export("initWithTrack:outputSettings:")]
	public AVAssetReaderTrackOutput(AVAssetTrack track, NSDictionary outputSettings)
		: base(NSObjectFlag.Empty)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTrackOutputSettings_Handle, track.Handle, outputSettings?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTrackOutputSettings_Handle, track.Handle, outputSettings?.Handle ?? IntPtr.Zero);
		}
	}

	public AVAssetReaderTrackOutput(AVAssetTrack track, AudioSettings settings)
		: this(track, settings?.Dictionary)
	{
	}

	public AVAssetReaderTrackOutput(AVAssetTrack track, AVVideoSettingsUncompressed settings)
		: this(track, settings?.Dictionary)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Track_var = null;
			__mt_OutputSettings_var = null;
		}
	}
}
