using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoCompositionCoreAnimationTool", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVVideoCompositionCoreAnimationTool : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionCoreAnimationToolWithAdditionalLayer_AsTrackID_ = "videoCompositionCoreAnimationToolWithAdditionalLayer:asTrackID:";

	private static readonly IntPtr selVideoCompositionCoreAnimationToolWithAdditionalLayer_AsTrackID_Handle = Selector.GetHandle("videoCompositionCoreAnimationToolWithAdditionalLayer:asTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer_InLayer_ = "videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer:inLayer:";

	private static readonly IntPtr selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer_InLayer_Handle = Selector.GetHandle("videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer:inLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayers_InLayer_ = "videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayers:inLayer:";

	private static readonly IntPtr selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayers_InLayer_Handle = Selector.GetHandle("videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayers:inLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVVideoCompositionCoreAnimationTool");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoCompositionCoreAnimationTool()
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
	protected AVVideoCompositionCoreAnimationTool(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVVideoCompositionCoreAnimationTool(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayers:inLayer:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVVideoCompositionCoreAnimationTool FromComposedVideoFrames(CALayer[] videoLayers, CALayer inAnimationlayer)
	{
		if (videoLayers == null)
		{
			throw new ArgumentNullException("videoLayers");
		}
		if (inAnimationlayer == null)
		{
			throw new ArgumentNullException("inAnimationlayer");
		}
		NSArray nSArray = NSArray.FromNSObjects(videoLayers);
		AVVideoCompositionCoreAnimationTool nSObject = Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayers_InLayer_Handle, nSArray.Handle, inAnimationlayer.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("videoCompositionCoreAnimationToolWithAdditionalLayer:asTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVVideoCompositionCoreAnimationTool FromLayer(CALayer layer, int trackID)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		return Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSend_IntPtr_int(class_ptr, selVideoCompositionCoreAnimationToolWithAdditionalLayer_AsTrackID_Handle, layer.Handle, trackID));
	}

	[Export("videoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer:inLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVideoCompositionCoreAnimationToolWithPostProcessingAsVideoLayer_InLayer_Handle, videoLayer.Handle, animationLayer.Handle));
	}
}
