using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetImageGenerator", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetImageGenerator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApertureMode = "apertureMode";

	private static readonly IntPtr selApertureModeHandle = Selector.GetHandle("apertureMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppliesPreferredTrackTransform = "appliesPreferredTrackTransform";

	private static readonly IntPtr selAppliesPreferredTrackTransformHandle = Selector.GetHandle("appliesPreferredTrackTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetImageGeneratorWithAsset_ = "assetImageGeneratorWithAsset:";

	private static readonly IntPtr selAssetImageGeneratorWithAsset_Handle = Selector.GetHandle("assetImageGeneratorWithAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelAllCGImageGeneration = "cancelAllCGImageGeneration";

	private static readonly IntPtr selCancelAllCGImageGenerationHandle = Selector.GetHandle("cancelAllCGImageGeneration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyCGImageAtTime_ActualTime_Error_ = "copyCGImageAtTime:actualTime:error:";

	private static readonly IntPtr selCopyCGImageAtTime_ActualTime_Error_Handle = Selector.GetHandle("copyCGImageAtTime:actualTime:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomVideoCompositor = "customVideoCompositor";

	private static readonly IntPtr selCustomVideoCompositorHandle = Selector.GetHandle("customVideoCompositor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateCGImagesAsynchronouslyForTimes_CompletionHandler_ = "generateCGImagesAsynchronouslyForTimes:completionHandler:";

	private static readonly IntPtr selGenerateCGImagesAsynchronouslyForTimes_CompletionHandler_Handle = Selector.GetHandle("generateCGImagesAsynchronouslyForTimes:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_ = "initWithAsset:";

	private static readonly IntPtr selInitWithAsset_Handle = Selector.GetHandle("initWithAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumSize = "maximumSize";

	private static readonly IntPtr selMaximumSizeHandle = Selector.GetHandle("maximumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedTimeToleranceAfter = "requestedTimeToleranceAfter";

	private static readonly IntPtr selRequestedTimeToleranceAfterHandle = Selector.GetHandle("requestedTimeToleranceAfter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedTimeToleranceBefore = "requestedTimeToleranceBefore";

	private static readonly IntPtr selRequestedTimeToleranceBeforeHandle = Selector.GetHandle("requestedTimeToleranceBefore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApertureMode_ = "setApertureMode:";

	private static readonly IntPtr selSetApertureMode_Handle = Selector.GetHandle("setApertureMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppliesPreferredTrackTransform_ = "setAppliesPreferredTrackTransform:";

	private static readonly IntPtr selSetAppliesPreferredTrackTransform_Handle = Selector.GetHandle("setAppliesPreferredTrackTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumSize_ = "setMaximumSize:";

	private static readonly IntPtr selSetMaximumSize_Handle = Selector.GetHandle("setMaximumSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestedTimeToleranceAfter_ = "setRequestedTimeToleranceAfter:";

	private static readonly IntPtr selSetRequestedTimeToleranceAfter_Handle = Selector.GetHandle("setRequestedTimeToleranceAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestedTimeToleranceBefore_ = "setRequestedTimeToleranceBefore:";

	private static readonly IntPtr selSetRequestedTimeToleranceBefore_Handle = Selector.GetHandle("setRequestedTimeToleranceBefore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoComposition_ = "setVideoComposition:";

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoComposition = "videoComposition";

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetImageGenerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeCleanAperture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeEncodedPixels;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeProductionAperture;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString? ApertureMode
	{
		[Export("apertureMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selApertureModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApertureModeHandle));
		}
		[Export("setApertureMode:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetApertureMode_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetApertureMode_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AppliesPreferredTrackTransform
	{
		[Export("appliesPreferredTrackTransform")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAppliesPreferredTrackTransformHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAppliesPreferredTrackTransformHandle);
		}
		[Export("setAppliesPreferredTrackTransform:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAppliesPreferredTrackTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAppliesPreferredTrackTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual AVAsset Asset
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("asset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle));
			}
			return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle));
		}
	}

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
	public virtual CGSize MaximumSize
	{
		[Export("maximumSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumSizeHandle);
		}
		[Export("setMaximumSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaximumSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaximumSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime RequestedTimeToleranceAfter
	{
		[Export("requestedTimeToleranceAfter", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selRequestedTimeToleranceAfterHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRequestedTimeToleranceAfterHandle);
			}
			return retval;
		}
		[Export("setRequestedTimeToleranceAfter:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetRequestedTimeToleranceAfter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetRequestedTimeToleranceAfter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime RequestedTimeToleranceBefore
	{
		[Export("requestedTimeToleranceBefore", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selRequestedTimeToleranceBeforeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRequestedTimeToleranceBeforeHandle);
			}
			return retval;
		}
		[Export("setRequestedTimeToleranceBefore:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetRequestedTimeToleranceBefore_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetRequestedTimeToleranceBefore_Handle, value);
			}
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

	[Field("AVAssetImageGeneratorApertureModeCleanAperture", "AVFoundation")]
	public static NSString ApertureModeCleanAperture
	{
		get
		{
			if (_ApertureModeCleanAperture == null)
			{
				_ApertureModeCleanAperture = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetImageGeneratorApertureModeCleanAperture");
			}
			return _ApertureModeCleanAperture;
		}
	}

	[Field("AVAssetImageGeneratorApertureModeEncodedPixels", "AVFoundation")]
	public static NSString ApertureModeEncodedPixels
	{
		get
		{
			if (_ApertureModeEncodedPixels == null)
			{
				_ApertureModeEncodedPixels = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetImageGeneratorApertureModeEncodedPixels");
			}
			return _ApertureModeEncodedPixels;
		}
	}

	[Field("AVAssetImageGeneratorApertureModeProductionAperture", "AVFoundation")]
	public static NSString ApertureModeProductionAperture
	{
		get
		{
			if (_ApertureModeProductionAperture == null)
			{
				_ApertureModeProductionAperture = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetImageGeneratorApertureModeProductionAperture");
			}
			return _ApertureModeProductionAperture;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetImageGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetImageGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetImageGenerator(AVAsset asset)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAsset_Handle, asset.Handle), "initWithAsset:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAsset_Handle, asset.Handle), "initWithAsset:");
		}
	}

	[Export("cancelAllCGImageGeneration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelAllCGImageGeneration()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelAllCGImageGenerationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelAllCGImageGenerationHandle);
		}
	}

	[Export("copyCGImageAtTime:actualTime:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual CGImage? CopyCGImageAtTime(CMTime requestedTime, out CMTime actualTime, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_CMTime_out_CMTime_ref_IntPtr(base.SuperHandle, selCopyCGImageAtTime_ActualTime_Error_Handle, requestedTime, out actualTime, ref arg) : Messaging.IntPtr_objc_msgSend_CMTime_out_CMTime_ref_IntPtr(base.Handle, selCopyCGImageAtTime_ActualTime_Error_Handle, requestedTime, out actualTime, ref arg));
		CGImage result = null;
		if (intPtr != IntPtr.Zero)
		{
			result = new CGImage(intPtr);
			Messaging.void_objc_msgSend(intPtr, Selector.GetHandle("release"));
		}
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("assetImageGeneratorWithAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetImageGenerator FromAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<AVAssetImageGenerator>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetImageGeneratorWithAsset_Handle, asset.Handle));
	}

	[Export("generateCGImagesAsynchronouslyForTimes:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GenerateCGImagesAsynchronously(NSValue[] cmTimesRequestedTimes, [BlockProxy(typeof(Trampolines.NIDAVAssetImageGeneratorCompletionHandler))] AVAssetImageGeneratorCompletionHandler handler)
	{
		if (cmTimesRequestedTimes == null)
		{
			throw new ArgumentNullException("cmTimesRequestedTimes");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(cmTimesRequestedTimes);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVAssetImageGeneratorCompletionHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGenerateCGImagesAsynchronouslyForTimes_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGenerateCGImagesAsynchronouslyForTimes_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}
}
