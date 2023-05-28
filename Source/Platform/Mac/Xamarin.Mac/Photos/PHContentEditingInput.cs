using System;
using System.ComponentModel;
using AppKit;
using AVFoundation;
using CoreImage;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHContentEditingInput", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class PHContentEditingInput : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdjustmentData = "adjustmentData";

	private static readonly IntPtr selAdjustmentDataHandle = Selector.GetHandle("adjustmentData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudiovisualAsset = "audiovisualAsset";

	private static readonly IntPtr selAudiovisualAssetHandle = Selector.GetHandle("audiovisualAsset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationDate = "creationDate";

	private static readonly IntPtr selCreationDateHandle = Selector.GetHandle("creationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaySizeImage = "displaySizeImage";

	private static readonly IntPtr selDisplaySizeImageHandle = Selector.GetHandle("displaySizeImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullSizeImageOrientation = "fullSizeImageOrientation";

	private static readonly IntPtr selFullSizeImageOrientationHandle = Selector.GetHandle("fullSizeImageOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullSizeImageURL = "fullSizeImageURL";

	private static readonly IntPtr selFullSizeImageURLHandle = Selector.GetHandle("fullSizeImageURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLivePhoto = "livePhoto";

	private static readonly IntPtr selLivePhotoHandle = Selector.GetHandle("livePhoto");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocation = "location";

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSubtypes = "mediaSubtypes";

	private static readonly IntPtr selMediaSubtypesHandle = Selector.GetHandle("mediaSubtypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaybackStyle = "playbackStyle";

	private static readonly IntPtr selPlaybackStyleHandle = Selector.GetHandle("playbackStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformTypeIdentifier = "uniformTypeIdentifier";

	private static readonly IntPtr selUniformTypeIdentifierHandle = Selector.GetHandle("uniformTypeIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHContentEditingInput");

	[Obsolete("Compatibility stub - This was marked as unavailable on macOS with Xcode 11.")]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, "Use 'AudiovisualAsset' instead.")]
	public virtual AVAsset AvAsset => AudiovisualAsset;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAdjustmentData? AdjustmentData
	{
		[Export("adjustmentData", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHAdjustmentData>(Messaging.IntPtr_objc_msgSend(base.Handle, selAdjustmentDataHandle));
			}
			return Runtime.GetNSObject<PHAdjustmentData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAdjustmentDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual AVAsset? AudiovisualAsset
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("audiovisualAsset", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudiovisualAssetHandle));
			}
			return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudiovisualAssetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate CreationDate
	{
		[Export("creationDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage DisplaySizeImage
	{
		[Export("displaySizeImage", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplaySizeImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplaySizeImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImageOrientation FullSizeImageOrientation
	{
		[Export("fullSizeImageOrientation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CIImageOrientation)Messaging.int_objc_msgSend(base.Handle, selFullSizeImageOrientationHandle);
			}
			return (CIImageOrientation)Messaging.int_objc_msgSendSuper(base.SuperHandle, selFullSizeImageOrientationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl FullSizeImageUrl
	{
		[Export("fullSizeImageURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFullSizeImageURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFullSizeImageURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual PHLivePhoto? LivePhoto
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("livePhoto", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHLivePhoto>(Messaging.IntPtr_objc_msgSend(base.Handle, selLivePhotoHandle));
			}
			return Runtime.GetNSObject<PHLivePhoto>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLivePhotoHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocation Location
	{
		[Export("location", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationHandle));
			}
			return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetMediaSubtype MediaSubtypes
	{
		[Export("mediaSubtypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetMediaSubtype)Messaging.UInt64_objc_msgSend(base.Handle, selMediaSubtypesHandle);
			}
			return (PHAssetMediaSubtype)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMediaSubtypesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetMediaType MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetMediaType)Messaging.Int64_objc_msgSend(base.Handle, selMediaTypeHandle);
			}
			return (PHAssetMediaType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual PHAssetPlaybackStyle PlaybackStyle
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("playbackStyle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetPlaybackStyle)Messaging.Int64_objc_msgSend(base.Handle, selPlaybackStyleHandle);
			}
			return (PHAssetPlaybackStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPlaybackStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UniformTypeIdentifier
	{
		[Export("uniformTypeIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniformTypeIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniformTypeIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHContentEditingInput()
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
	protected PHContentEditingInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHContentEditingInput(IntPtr handle)
		: base(handle)
	{
	}
}
