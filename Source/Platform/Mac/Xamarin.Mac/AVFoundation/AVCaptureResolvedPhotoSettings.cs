using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVCaptureResolvedPhotoSettings", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class AVCaptureResolvedPhotoSettings : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmbeddedThumbnailDimensions = "embeddedThumbnailDimensions";

	private static readonly IntPtr selEmbeddedThumbnailDimensionsHandle = Selector.GetHandle("embeddedThumbnailDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpectedPhotoCount = "expectedPhotoCount";

	private static readonly IntPtr selExpectedPhotoCountHandle = Selector.GetHandle("expectedPhotoCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDualCameraFusionEnabled = "isDualCameraFusionEnabled";

	private static readonly IntPtr selIsDualCameraFusionEnabledHandle = Selector.GetHandle("isDualCameraFusionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlashEnabled = "isFlashEnabled";

	private static readonly IntPtr selIsFlashEnabledHandle = Selector.GetHandle("isFlashEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLivePhotoMovieDimensions = "livePhotoMovieDimensions";

	private static readonly IntPtr selLivePhotoMovieDimensionsHandle = Selector.GetHandle("livePhotoMovieDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoDimensions = "photoDimensions";

	private static readonly IntPtr selPhotoDimensionsHandle = Selector.GetHandle("photoDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewDimensions = "previewDimensions";

	private static readonly IntPtr selPreviewDimensionsHandle = Selector.GetHandle("previewDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRawPhotoDimensions = "rawPhotoDimensions";

	private static readonly IntPtr selRawPhotoDimensionsHandle = Selector.GetHandle("rawPhotoDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniqueID = "uniqueID";

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureResolvedPhotoSettings");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'VirtualDeviceFusionEnabled' instead.")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	public virtual bool DualCameraFusionEnabled
	{
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'VirtualDeviceFusionEnabled' instead.")]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("isDualCameraFusionEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDualCameraFusionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDualCameraFusionEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CMVideoDimensions EmbeddedThumbnailDimensions
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("embeddedThumbnailDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CMVideoDimensions_objc_msgSend(base.Handle, selEmbeddedThumbnailDimensionsHandle);
			}
			return Messaging.CMVideoDimensions_objc_msgSendSuper(base.SuperHandle, selEmbeddedThumbnailDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint ExpectedPhotoCount
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("expectedPhotoCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selExpectedPhotoCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selExpectedPhotoCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFlashEnabled
	{
		[Export("isFlashEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlashEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlashEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMVideoDimensions LivePhotoMovieDimensions
	{
		[Export("livePhotoMovieDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CMVideoDimensions_objc_msgSend(base.Handle, selLivePhotoMovieDimensionsHandle);
			}
			return Messaging.CMVideoDimensions_objc_msgSendSuper(base.SuperHandle, selLivePhotoMovieDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMVideoDimensions PhotoDimensions
	{
		[Export("photoDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CMVideoDimensions_objc_msgSend(base.Handle, selPhotoDimensionsHandle);
			}
			return Messaging.CMVideoDimensions_objc_msgSendSuper(base.SuperHandle, selPhotoDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMVideoDimensions PreviewDimensions
	{
		[Export("previewDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CMVideoDimensions_objc_msgSend(base.Handle, selPreviewDimensionsHandle);
			}
			return Messaging.CMVideoDimensions_objc_msgSendSuper(base.SuperHandle, selPreviewDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMVideoDimensions RawPhotoDimensions
	{
		[Export("rawPhotoDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CMVideoDimensions_objc_msgSend(base.Handle, selRawPhotoDimensionsHandle);
			}
			return Messaging.CMVideoDimensions_objc_msgSendSuper(base.SuperHandle, selRawPhotoDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long UniqueID
	{
		[Export("uniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selUniqueIDHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureResolvedPhotoSettings(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureResolvedPhotoSettings(IntPtr handle)
		: base(handle)
	{
	}
}
