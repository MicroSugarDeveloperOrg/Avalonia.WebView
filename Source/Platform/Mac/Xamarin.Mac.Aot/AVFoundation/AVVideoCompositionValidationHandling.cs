using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVVideoCompositionValidationHandling", true)]
[Model]
public class AVVideoCompositionValidationHandling : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVVideoCompositionValidationHandling(NSCoder coder)
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
	public AVVideoCompositionValidationHandling(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVVideoCompositionValidationHandling(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:")]
	public virtual bool ShouldContinueValidatingAfterFindingInvalidValueForKey(AVVideoComposition videoComposition, string key)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:")]
	public virtual bool ShouldContinueValidatingAfterFindingEmptyTimeRange(AVVideoComposition videoComposition, CMTimeRange timeRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:")]
	public virtual bool ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction(AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:")]
	public virtual bool ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction(AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
