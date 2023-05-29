using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetImageGenerator", true)]
public class AVAssetImageGenerator : NSObject
{
	private static readonly IntPtr selMaximumSizeHandle = Selector.GetHandle("maximumSize");

	private static readonly IntPtr selSetMaximumSize_Handle = Selector.GetHandle("setMaximumSize:");

	private static readonly IntPtr selApertureModeHandle = Selector.GetHandle("apertureMode");

	private static readonly IntPtr selSetApertureMode_Handle = Selector.GetHandle("setApertureMode:");

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	private static readonly IntPtr selAppliesPreferredTrackTransformHandle = Selector.GetHandle("appliesPreferredTrackTransform");

	private static readonly IntPtr selSetAppliesPreferredTrackTransform_Handle = Selector.GetHandle("setAppliesPreferredTrackTransform:");

	private static readonly IntPtr selRequestedTimeToleranceBeforeHandle = Selector.GetHandle("requestedTimeToleranceBefore");

	private static readonly IntPtr selSetRequestedTimeToleranceBefore_Handle = Selector.GetHandle("setRequestedTimeToleranceBefore:");

	private static readonly IntPtr selRequestedTimeToleranceAfterHandle = Selector.GetHandle("requestedTimeToleranceAfter");

	private static readonly IntPtr selSetRequestedTimeToleranceAfter_Handle = Selector.GetHandle("setRequestedTimeToleranceAfter:");

	private static readonly IntPtr selAssetImageGeneratorWithAsset_Handle = Selector.GetHandle("assetImageGeneratorWithAsset:");

	private static readonly IntPtr selInitWithAsset_Handle = Selector.GetHandle("initWithAsset:");

	private static readonly IntPtr selCopyCGImageAtTimeActualTimeError_Handle = Selector.GetHandle("copyCGImageAtTime:actualTime:error:");

	private static readonly IntPtr selGenerateCGImagesAsynchronouslyForTimesCompletionHandler_Handle = Selector.GetHandle("generateCGImagesAsynchronouslyForTimes:completionHandler:");

	private static readonly IntPtr selCancelAllCGImageGenerationHandle = Selector.GetHandle("cancelAllCGImageGeneration");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetImageGenerator");

	private object __mt_ApertureMode_var;

	private object __mt_VideoComposition_var;

	private static NSString _ApertureModeCleanAperture;

	private static NSString _ApertureModeProductionAperture;

	private static NSString _ApertureModeEncodedPixels;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGSize MaximumSize
	{
		[Export("maximumSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumSizeHandle);
		}
		[Export("setMaximumSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaximumSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaximumSize_Handle, value);
			}
		}
	}

	public virtual NSString ApertureMode
	{
		[Export("apertureMode")]
		get
		{
			return (NSString)(__mt_ApertureMode_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApertureModeHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selApertureModeHandle)))));
		}
		[Export("setApertureMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetApertureMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetApertureMode_Handle, value.Handle);
			}
			__mt_ApertureMode_var = value;
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

	public virtual bool AppliesPreferredTrackTransform
	{
		[Export("appliesPreferredTrackTransform")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAppliesPreferredTrackTransformHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAppliesPreferredTrackTransformHandle);
		}
		[Export("setAppliesPreferredTrackTransform:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAppliesPreferredTrackTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAppliesPreferredTrackTransform_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual CMTime RequestedTimeToleranceBefore
	{
		[Export("requestedTimeToleranceBefore")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selRequestedTimeToleranceBeforeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRequestedTimeToleranceBeforeHandle);
			}
			return retval;
		}
		[Export("setRequestedTimeToleranceBefore:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetRequestedTimeToleranceBefore_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetRequestedTimeToleranceBefore_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual CMTime RequestedTimeToleranceAfter
	{
		[Export("requestedTimeToleranceAfter")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selRequestedTimeToleranceAfterHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRequestedTimeToleranceAfterHandle);
			}
			return retval;
		}
		[Export("setRequestedTimeToleranceAfter:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetRequestedTimeToleranceAfter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetRequestedTimeToleranceAfter_Handle, value);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetImageGenerator(NSCoder coder)
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
	public AVAssetImageGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetImageGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetImageGeneratorWithAsset:")]
	public static AVAssetImageGenerator FromAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return (AVAssetImageGenerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetImageGeneratorWithAsset_Handle, asset.Handle));
	}

	[Export("initWithAsset:")]
	public AVAssetImageGenerator(AVAsset asset)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAsset_Handle, asset.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAsset_Handle, asset.Handle);
		}
	}

	[Export("copyCGImageAtTime:actualTime:error:")]
	public virtual CGImage CopyCGImageAtTime(CMTime requestedTime, out CMTime actualTime, out NSError outError)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		CGImage result = ((!IsDirectBinding) ? new CGImage(Messaging.IntPtr_objc_msgSendSuper_CMTime_out_CMTime_IntPtr(base.SuperHandle, selCopyCGImageAtTimeActualTimeError_Handle, requestedTime, out actualTime, intPtr)) : new CGImage(Messaging.IntPtr_objc_msgSend_CMTime_out_CMTime_IntPtr(base.Handle, selCopyCGImageAtTimeActualTimeError_Handle, requestedTime, out actualTime, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("generateCGImagesAsynchronouslyForTimes:completionHandler:")]
	public unsafe virtual void GenerateCGImagesAsynchronously(NSValue[] cmTimesRequestedTimes, AVAssetImageGeneratorCompletionHandler handler)
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
		blockLiteral.SetupBlock(Trampolines.SDAVAssetImageGeneratorCompletionHandler.Handler, handler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGenerateCGImagesAsynchronouslyForTimesCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGenerateCGImagesAsynchronouslyForTimesCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Export("cancelAllCGImageGeneration")]
	public virtual void CancelAllCGImageGeneration()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelAllCGImageGenerationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelAllCGImageGenerationHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ApertureMode_var = null;
			__mt_VideoComposition_var = null;
		}
	}
}
