using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHImageManager", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHImageManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelImageRequest_ = "cancelImageRequest:";

	private static readonly IntPtr selCancelImageRequest_Handle = Selector.GetHandle("cancelImageRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultManager = "defaultManager";

	private static readonly IntPtr selDefaultManagerHandle = Selector.GetHandle("defaultManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAVAssetForVideo_Options_ResultHandler_ = "requestAVAssetForVideo:options:resultHandler:";

	private static readonly IntPtr selRequestAVAssetForVideo_Options_ResultHandler_Handle = Selector.GetHandle("requestAVAssetForVideo:options:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestExportSessionForVideo_Options_ExportPreset_ResultHandler_ = "requestExportSessionForVideo:options:exportPreset:resultHandler:";

	private static readonly IntPtr selRequestExportSessionForVideo_Options_ExportPreset_ResultHandler_Handle = Selector.GetHandle("requestExportSessionForVideo:options:exportPreset:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestImageDataAndOrientationForAsset_Options_ResultHandler_ = "requestImageDataAndOrientationForAsset:options:resultHandler:";

	private static readonly IntPtr selRequestImageDataAndOrientationForAsset_Options_ResultHandler_Handle = Selector.GetHandle("requestImageDataAndOrientationForAsset:options:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestImageForAsset_TargetSize_ContentMode_Options_ResultHandler_ = "requestImageForAsset:targetSize:contentMode:options:resultHandler:";

	private static readonly IntPtr selRequestImageForAsset_TargetSize_ContentMode_Options_ResultHandler_Handle = Selector.GetHandle("requestImageForAsset:targetSize:contentMode:options:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestLivePhotoForAsset_TargetSize_ContentMode_Options_ResultHandler_ = "requestLivePhotoForAsset:targetSize:contentMode:options:resultHandler:";

	private static readonly IntPtr selRequestLivePhotoForAsset_TargetSize_ContentMode_Options_ResultHandler_Handle = Selector.GetHandle("requestLivePhotoForAsset:targetSize:contentMode:options:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestPlayerItemForVideo_Options_ResultHandler_ = "requestPlayerItemForVideo:options:resultHandler:";

	private static readonly IntPtr selRequestPlayerItemForVideo_Options_ResultHandler_Handle = Selector.GetHandle("requestPlayerItemForVideo:options:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHImageManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHImageManager DefaultManager
	{
		[Export("defaultManager")]
		get
		{
			return Runtime.GetNSObject<PHImageManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultManagerHandle));
		}
	}

	[Field("PHImageManagerMaximumSize", "Photos")]
	public static CGSize MaximumSize => Dlfcn.GetCGSize(Libraries.Photos.Handle, "PHImageManagerMaximumSize");

	[Obsolete("Compatibility stub - This was marked as unavailable on macOS with Xcode 11.")]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, "Use 'RequestImageDataAndOrientation (PHAsset asset, [NullAllowed] PHImageRequestOptions options, PHImageManagerRequestImageDataHandler resultHandler)' instead.")]
	public virtual int RequestImageData(PHAsset asset, PHImageRequestOptions options, PHImageDataHandler handler)
	{
		return -1;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHImageManager()
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
	protected PHImageManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHImageManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelImageRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelImageRequest(int requestID)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selCancelImageRequest_Handle, requestID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selCancelImageRequest_Handle, requestID);
		}
	}

	[Export("requestAVAssetForVideo:options:resultHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestAvAsset(PHAsset asset, PHVideoRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDPHImageManagerRequestAvAssetHandler))] PHImageManagerRequestAvAssetHandler resultHandler)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHImageManagerRequestAvAssetHandler.Handler, resultHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestAVAssetForVideo_Options_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr) : Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRequestAVAssetForVideo_Options_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("requestExportSessionForVideo:options:exportPreset:resultHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestExportSession(PHAsset asset, PHVideoRequestOptions? options, string exportPreset, [BlockProxy(typeof(Trampolines.NIDPHImageManagerRequestExportHandler))] PHImageManagerRequestExportHandler resultHandler)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (exportPreset == null)
		{
			throw new ArgumentNullException("exportPreset");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		IntPtr arg = NSString.CreateNative(exportPreset);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHImageManagerRequestExportHandler.Handler, resultHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestExportSessionForVideo_Options_ExportPreset_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, arg, (IntPtr)ptr) : Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRequestExportSessionForVideo_Options_ExportPreset_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, arg, (IntPtr)ptr));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Export("requestImageDataAndOrientationForAsset:options:resultHandler:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestImageDataAndOrientation(PHAsset asset, PHImageRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDPHImageManagerRequestImageDataHandler))] PHImageManagerRequestImageDataHandler resultHandler)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHImageManagerRequestImageDataHandler.Handler, resultHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestImageDataAndOrientationForAsset_Options_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr) : Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRequestImageDataAndOrientationForAsset_Options_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("requestImageForAsset:targetSize:contentMode:options:resultHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestImageForAsset(PHAsset asset, CGSize targetSize, PHImageContentMode contentMode, PHImageRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDPHImageResultHandler))] PHImageResultHandler resultHandler)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHImageResultHandler.Handler, resultHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_CGSize_Int64_IntPtr_IntPtr(base.SuperHandle, selRequestImageForAsset_TargetSize_ContentMode_Options_ResultHandler_Handle, asset.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr) : Messaging.int_objc_msgSend_IntPtr_CGSize_Int64_IntPtr_IntPtr(base.Handle, selRequestImageForAsset_TargetSize_ContentMode_Options_ResultHandler_Handle, asset.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("requestLivePhotoForAsset:targetSize:contentMode:options:resultHandler:")]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestLivePhoto(PHAsset asset, CGSize targetSize, PHImageContentMode contentMode, PHLivePhotoRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDPHImageManagerRequestLivePhoto))] PHImageManagerRequestLivePhoto resultHandler)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHImageManagerRequestLivePhoto.Handler, resultHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_CGSize_Int64_IntPtr_IntPtr(base.SuperHandle, selRequestLivePhotoForAsset_TargetSize_ContentMode_Options_ResultHandler_Handle, asset.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr) : Messaging.int_objc_msgSend_IntPtr_CGSize_Int64_IntPtr_IntPtr(base.Handle, selRequestLivePhotoForAsset_TargetSize_ContentMode_Options_ResultHandler_Handle, asset.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("requestPlayerItemForVideo:options:resultHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestPlayerItem(PHAsset asset, PHVideoRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDPHImageManagerRequestPlayerHandler))] PHImageManagerRequestPlayerHandler resultHandler)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHImageManagerRequestPlayerHandler.Handler, resultHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestPlayerItemForVideo_Options_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr) : Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRequestPlayerItemForVideo_Options_ResultHandler_Handle, asset.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}
}
