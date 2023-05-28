using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHCachingImageManager", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHCachingImageManager : PHImageManager
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCachingHighQualityImages = "allowsCachingHighQualityImages";

	private static readonly IntPtr selAllowsCachingHighQualityImagesHandle = Selector.GetHandle("allowsCachingHighQualityImages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsCachingHighQualityImages_ = "setAllowsCachingHighQualityImages:";

	private static readonly IntPtr selSetAllowsCachingHighQualityImages_Handle = Selector.GetHandle("setAllowsCachingHighQualityImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartCachingImagesForAssets_TargetSize_ContentMode_Options_ = "startCachingImagesForAssets:targetSize:contentMode:options:";

	private static readonly IntPtr selStartCachingImagesForAssets_TargetSize_ContentMode_Options_Handle = Selector.GetHandle("startCachingImagesForAssets:targetSize:contentMode:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopCachingImagesForAllAssets = "stopCachingImagesForAllAssets";

	private static readonly IntPtr selStopCachingImagesForAllAssetsHandle = Selector.GetHandle("stopCachingImagesForAllAssets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopCachingImagesForAssets_TargetSize_ContentMode_Options_ = "stopCachingImagesForAssets:targetSize:contentMode:options:";

	private static readonly IntPtr selStopCachingImagesForAssets_TargetSize_ContentMode_Options_Handle = Selector.GetHandle("stopCachingImagesForAssets:targetSize:contentMode:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHCachingImageManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsCachingHighQualityImages
	{
		[Export("allowsCachingHighQualityImages")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCachingHighQualityImagesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCachingHighQualityImagesHandle);
		}
		[Export("setAllowsCachingHighQualityImages:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCachingHighQualityImages_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCachingHighQualityImages_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHCachingImageManager()
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
	protected PHCachingImageManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHCachingImageManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("startCachingImagesForAssets:targetSize:contentMode:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartCaching(PHAsset[] assets, CGSize targetSize, PHImageContentMode contentMode, PHImageRequestOptions? options)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGSize_Int64_IntPtr(base.Handle, selStartCachingImagesForAssets_TargetSize_ContentMode_Options_Handle, nSArray.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGSize_Int64_IntPtr(base.SuperHandle, selStartCachingImagesForAssets_TargetSize_ContentMode_Options_Handle, nSArray.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero);
		}
		nSArray.Dispose();
	}

	[Export("stopCachingImagesForAssets:targetSize:contentMode:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopCaching(PHAsset[] assets, CGSize targetSize, PHImageContentMode contentMode, PHImageRequestOptions? options)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGSize_Int64_IntPtr(base.Handle, selStopCachingImagesForAssets_TargetSize_ContentMode_Options_Handle, nSArray.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGSize_Int64_IntPtr(base.SuperHandle, selStopCachingImagesForAssets_TargetSize_ContentMode_Options_Handle, nSArray.Handle, targetSize, (long)contentMode, options?.Handle ?? IntPtr.Zero);
		}
		nSArray.Dispose();
	}

	[Export("stopCachingImagesForAllAssets")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopCaching()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopCachingImagesForAllAssetsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopCachingImagesForAllAssetsHandle);
		}
	}
}
