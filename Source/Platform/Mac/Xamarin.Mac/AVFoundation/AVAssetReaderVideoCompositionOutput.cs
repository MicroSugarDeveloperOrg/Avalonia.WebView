using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderVideoCompositionOutput", true)]
public class AVAssetReaderVideoCompositionOutput : AVAssetReaderOutput
{
	private static readonly IntPtr selVideoTracksHandle = Selector.GetHandle("videoTracks");

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	private static readonly IntPtr selVideoSettingsHandle = Selector.GetHandle("videoSettings");

	private static readonly IntPtr selAssetReaderVideoCompositionOutputWithVideoTracksVideoSettings_Handle = Selector.GetHandle("assetReaderVideoCompositionOutputWithVideoTracks:videoSettings:");

	private static readonly IntPtr selInitWithVideoTracksVideoSettings_Handle = Selector.GetHandle("initWithVideoTracks:videoSettings:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetReaderVideoCompositionOutput");

	private object __mt_VideoTracks_var;

	private object __mt_VideoComposition_var;

	private object __mt_WeakVideoSettings_var;

	[Advice("Use UncompressedVideoSettings property")]
	public AVVideoSettings VideoSettings
	{
		get
		{
			if (WeakVideoSettings.TryGetValue(CVPixelBuffer.PixelFormatTypeKey, out var value) && value is NSNumber)
			{
				return new AVVideoSettings((CVPixelFormatType)(value as NSNumber).Int32Value);
			}
			return new AVVideoSettings();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVAssetTrack[] VideoTracks
	{
		[Export("videoTracks")]
		get
		{
			return (AVAssetTrack[])(__mt_VideoTracks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoTracksHandle)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoTracksHandle))));
		}
	}

	public virtual AVVideoComposition VideoComposition
	{
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			return (AVVideoComposition)(__mt_VideoComposition_var = ((!IsDirectBinding) ? ((AVVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle))) : ((AVVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle)))));
		}
		[Export("setVideoComposition:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoComposition_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoComposition_Handle, value.Handle);
			}
			__mt_VideoComposition_var = value;
		}
	}

	public virtual NSDictionary WeakVideoSettings
	{
		[Export("videoSettings")]
		get
		{
			return (NSDictionary)(__mt_WeakVideoSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoSettingsHandle)))));
		}
	}

	public CVPixelBufferAttributes UncompressedVideoSettings
	{
		get
		{
			NSDictionary weakVideoSettings = WeakVideoSettings;
			if (weakVideoSettings != null)
			{
				return new CVPixelBufferAttributes(weakVideoSettings);
			}
			return null;
		}
	}

	[Advice("Use overload with PixelBufferAttributes")]
	public AVAssetReaderVideoCompositionOutput(AVAssetTrack[] videoTracks, AVVideoSettings videoSettings)
		: this(videoTracks, videoSettings?.ToDictionary())
	{
	}

	[Advice("Use Create method or constructor")]
	public AVAssetReaderVideoCompositionOutput FromTracks(AVAssetTrack[] videoTracks, AVVideoSettings videoSettings)
	{
		return WeakFromTracks(videoTracks, videoSettings?.ToDictionary());
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetReaderVideoCompositionOutput(NSCoder coder)
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
	public AVAssetReaderVideoCompositionOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetReaderVideoCompositionOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetReaderVideoCompositionOutputWithVideoTracks:videoSettings:")]
	public static AVAssetReaderVideoCompositionOutput WeakFromTracks(AVAssetTrack[] videoTracks, NSDictionary videoSettings)
	{
		if (videoTracks == null)
		{
			throw new ArgumentNullException("videoTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(videoTracks);
		AVAssetReaderVideoCompositionOutput result = (AVAssetReaderVideoCompositionOutput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderVideoCompositionOutputWithVideoTracksVideoSettings_Handle, nSArray.Handle, videoSettings?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	public static AVAssetReaderVideoCompositionOutput Create(AVAssetTrack[] videoTracks, CVPixelBufferAttributes settings)
	{
		return WeakFromTracks(videoTracks, settings?.Dictionary);
	}

	[Export("initWithVideoTracks:videoSettings:")]
	public AVAssetReaderVideoCompositionOutput(AVAssetTrack[] videoTracks, NSDictionary videoSettings)
		: base(NSObjectFlag.Empty)
	{
		if (videoTracks == null)
		{
			throw new ArgumentNullException("videoTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(videoTracks);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithVideoTracksVideoSettings_Handle, nSArray.Handle, videoSettings?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithVideoTracksVideoSettings_Handle, nSArray.Handle, videoSettings?.Handle ?? IntPtr.Zero);
		}
		nSArray.Dispose();
	}

	public AVAssetReaderVideoCompositionOutput(AVAssetTrack[] videoTracks, CVPixelBufferAttributes settings)
		: this(videoTracks, settings?.Dictionary)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_VideoTracks_var = null;
			__mt_VideoComposition_var = null;
			__mt_WeakVideoSettings_var = null;
		}
	}
}
