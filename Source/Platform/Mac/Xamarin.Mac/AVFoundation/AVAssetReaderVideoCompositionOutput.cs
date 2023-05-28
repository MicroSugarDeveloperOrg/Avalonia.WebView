using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderVideoCompositionOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetReaderVideoCompositionOutput : AVAssetReaderOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderVideoCompositionOutputWithVideoTracks_VideoSettings_ = "assetReaderVideoCompositionOutputWithVideoTracks:videoSettings:";

	private static readonly IntPtr selAssetReaderVideoCompositionOutputWithVideoTracks_VideoSettings_Handle = Selector.GetHandle("assetReaderVideoCompositionOutputWithVideoTracks:videoSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomVideoCompositor = "customVideoCompositor";

	private static readonly IntPtr selCustomVideoCompositorHandle = Selector.GetHandle("customVideoCompositor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVideoTracks_VideoSettings_ = "initWithVideoTracks:videoSettings:";

	private static readonly IntPtr selInitWithVideoTracks_VideoSettings_Handle = Selector.GetHandle("initWithVideoTracks:videoSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoComposition_ = "setVideoComposition:";

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoComposition = "videoComposition";

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoSettings = "videoSettings";

	private static readonly IntPtr selVideoSettingsHandle = Selector.GetHandle("videoSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoTracks = "videoTracks";

	private static readonly IntPtr selVideoTracksHandle = Selector.GetHandle("videoTracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReaderVideoCompositionOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual IAVVideoCompositing? CustomVideoCompositor
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("customVideoCompositor", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IAVVideoCompositing>(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomVideoCompositorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IAVVideoCompositing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomVideoCompositorHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CVPixelBufferAttributes? UncompressedVideoSettings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakVideoSettings != null) ? new NSMutableDictionary(WeakVideoSettings) : null);
			return (nSMutableDictionary == null) ? null : new CVPixelBufferAttributes(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoComposition? VideoComposition
	{
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle));
			}
			return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle));
		}
		[Export("setVideoComposition:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoComposition_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoComposition_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack[] VideoTracks
	{
		[Export("videoTracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakVideoSettings
	{
		[Export("videoSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReaderVideoCompositionOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReaderVideoCompositionOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithVideoTracks:videoSettings:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderVideoCompositionOutput(AVAssetTrack[] videoTracks, NSDictionary? videoSettings)
		: base(NSObjectFlag.Empty)
	{
		if (videoTracks == null)
		{
			throw new ArgumentNullException("videoTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(videoTracks);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithVideoTracks_VideoSettings_Handle, nSArray.Handle, videoSettings?.Handle ?? IntPtr.Zero), "initWithVideoTracks:videoSettings:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithVideoTracks_VideoSettings_Handle, nSArray.Handle, videoSettings?.Handle ?? IntPtr.Zero), "initWithVideoTracks:videoSettings:");
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderVideoCompositionOutput(AVAssetTrack[] videoTracks, CVPixelBufferAttributes? settings)
		: this(videoTracks, settings.GetDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetReaderVideoCompositionOutput Create(AVAssetTrack[] videoTracks, CVPixelBufferAttributes? settings)
	{
		return WeakFromTracks(videoTracks, settings.GetDictionary());
	}

	[Export("assetReaderVideoCompositionOutputWithVideoTracks:videoSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'Create' method.")]
	internal static AVAssetReaderVideoCompositionOutput WeakFromTracks(AVAssetTrack[] videoTracks, NSDictionary? videoSettings)
	{
		if (videoTracks == null)
		{
			throw new ArgumentNullException("videoTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(videoTracks);
		AVAssetReaderVideoCompositionOutput nSObject = Runtime.GetNSObject<AVAssetReaderVideoCompositionOutput>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderVideoCompositionOutputWithVideoTracks_VideoSettings_Handle, nSArray.Handle, videoSettings?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}
}
