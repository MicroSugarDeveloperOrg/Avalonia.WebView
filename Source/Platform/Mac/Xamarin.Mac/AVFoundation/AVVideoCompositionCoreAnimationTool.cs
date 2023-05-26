using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoCompositionCoreAnimationTool", true)]
public class AVVideoCompositionCoreAnimationTool : NSObject
{
	private static readonly IntPtr selVideoCompositionCoreAnimationToolWithAdditionalLayerAsTrackID_Handle = Selector.GetHandle("videoCompositionCoreAnimationToolWithAdditionalLayer:asTrackID:");

	private static readonly IntPtr selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayerInLayer_Handle = Selector.GetHandle("videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer:inLayer:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVVideoCompositionCoreAnimationTool");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoCompositionCoreAnimationTool()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVVideoCompositionCoreAnimationTool(NSCoder coder)
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
	public AVVideoCompositionCoreAnimationTool(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVVideoCompositionCoreAnimationTool(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoCompositionCoreAnimationToolWithAdditionalLayer:asTrackID:")]
	public static AVVideoCompositionCoreAnimationTool FromLayer(CALayer layer, int trackID)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		return (AVVideoCompositionCoreAnimationTool)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_int(class_ptr, selVideoCompositionCoreAnimationToolWithAdditionalLayerAsTrackID_Handle, layer.Handle, trackID));
	}

	[Export("videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer:inLayer:")]
	public static AVVideoCompositionCoreAnimationTool FromLayer(CALayer videoLayer, CALayer animationLayer)
	{
		if (videoLayer == null)
		{
			throw new ArgumentNullException("videoLayer");
		}
		if (animationLayer == null)
		{
			throw new ArgumentNullException("animationLayer");
		}
		return (AVVideoCompositionCoreAnimationTool)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayerInLayer_Handle, videoLayer.Handle, animationLayer.Handle));
	}
}
