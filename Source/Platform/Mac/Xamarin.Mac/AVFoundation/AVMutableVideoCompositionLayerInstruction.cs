using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableVideoCompositionLayerInstruction", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVMutableVideoCompositionLayerInstruction : AVVideoCompositionLayerInstruction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCropRectangle_AtTime_ = "setCropRectangle:atTime:";

	private static readonly IntPtr selSetCropRectangle_AtTime_Handle = Selector.GetHandle("setCropRectangle:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCropRectangleRampFromStartCropRectangle_ToEndCropRectangle_TimeRange_ = "setCropRectangleRampFromStartCropRectangle:toEndCropRectangle:timeRange:";

	private static readonly IntPtr selSetCropRectangleRampFromStartCropRectangle_ToEndCropRectangle_TimeRange_Handle = Selector.GetHandle("setCropRectangleRampFromStartCropRectangle:toEndCropRectangle:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpacity_AtTime_ = "setOpacity:atTime:";

	private static readonly IntPtr selSetOpacity_AtTime_Handle = Selector.GetHandle("setOpacity:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpacityRampFromStartOpacity_ToEndOpacity_TimeRange_ = "setOpacityRampFromStartOpacity:toEndOpacity:timeRange:";

	private static readonly IntPtr selSetOpacityRampFromStartOpacity_ToEndOpacity_TimeRange_Handle = Selector.GetHandle("setOpacityRampFromStartOpacity:toEndOpacity:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrackID_ = "setTrackID:";

	private static readonly IntPtr selSetTrackID_Handle = Selector.GetHandle("setTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransform_AtTime_ = "setTransform:atTime:";

	private static readonly IntPtr selSetTransform_AtTime_Handle = Selector.GetHandle("setTransform:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransformRampFromStartTransform_ToEndTransform_TimeRange_ = "setTransformRampFromStartTransform:toEndTransform:timeRange:";

	private static readonly IntPtr selSetTransformRampFromStartTransform_ToEndTransform_TimeRange_Handle = Selector.GetHandle("setTransformRampFromStartTransform:toEndTransform:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackID = "trackID";

	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionLayerInstruction = "videoCompositionLayerInstruction";

	private static readonly IntPtr selVideoCompositionLayerInstructionHandle = Selector.GetHandle("videoCompositionLayerInstruction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionLayerInstructionWithAssetTrack_ = "videoCompositionLayerInstructionWithAssetTrack:";

	private static readonly IntPtr selVideoCompositionLayerInstructionWithAssetTrack_Handle = Selector.GetHandle("videoCompositionLayerInstructionWithAssetTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableVideoCompositionLayerInstruction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
		}
		[Export("setTrackID:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTrackID_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTrackID_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableVideoCompositionLayerInstruction()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVMutableVideoCompositionLayerInstruction(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableVideoCompositionLayerInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableVideoCompositionLayerInstruction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoCompositionLayerInstruction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableVideoCompositionLayerInstruction Create()
	{
		return Runtime.GetNSObject<AVMutableVideoCompositionLayerInstruction>(Messaging.IntPtr_objc_msgSend(class_ptr, selVideoCompositionLayerInstructionHandle));
	}

	[Export("videoCompositionLayerInstructionWithAssetTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableVideoCompositionLayerInstruction FromAssetTrack(AVAssetTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return Runtime.GetNSObject<AVMutableVideoCompositionLayerInstruction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoCompositionLayerInstructionWithAssetTrack_Handle, track.Handle));
	}

	[Export("setCropRectangleRampFromStartCropRectangle:toEndCropRectangle:timeRange:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCrop(CGRect startCropRectangle, CGRect endCropRectangle, CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_CMTimeRange(base.Handle, selSetCropRectangleRampFromStartCropRectangle_ToEndCropRectangle_TimeRange_Handle, startCropRectangle, endCropRectangle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_CMTimeRange(base.SuperHandle, selSetCropRectangleRampFromStartCropRectangle_ToEndCropRectangle_TimeRange_Handle, startCropRectangle, endCropRectangle, timeRange);
		}
	}

	[Export("setCropRectangle:atTime:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCrop(CGRect cropRectangle, CMTime time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CMTime(base.Handle, selSetCropRectangle_AtTime_Handle, cropRectangle, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CMTime(base.SuperHandle, selSetCropRectangle_AtTime_Handle, cropRectangle, time);
		}
	}

	[Export("setOpacity:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOpacity(float opacity, CMTime time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime(base.Handle, selSetOpacity_AtTime_Handle, opacity, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime(base.SuperHandle, selSetOpacity_AtTime_Handle, opacity, time);
		}
	}

	[Export("setOpacityRampFromStartOpacity:toEndOpacity:timeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOpacityRamp(float startOpacity, float endOpacity, CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float_CMTimeRange(base.Handle, selSetOpacityRampFromStartOpacity_ToEndOpacity_TimeRange_Handle, startOpacity, endOpacity, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float_CMTimeRange(base.SuperHandle, selSetOpacityRampFromStartOpacity_ToEndOpacity_TimeRange_Handle, startOpacity, endOpacity, timeRange);
		}
	}

	[Export("setTransform:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTransform(CGAffineTransform transform, CMTime atTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGAffineTransform_CMTime(base.Handle, selSetTransform_AtTime_Handle, transform, atTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGAffineTransform_CMTime(base.SuperHandle, selSetTransform_AtTime_Handle, transform, atTime);
		}
	}

	[Export("setTransformRampFromStartTransform:toEndTransform:timeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTransformRamp(CGAffineTransform startTransform, CGAffineTransform endTransform, CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGAffineTransform_CGAffineTransform_CMTimeRange(base.Handle, selSetTransformRampFromStartTransform_ToEndTransform_TimeRange_Handle, startTransform, endTransform, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGAffineTransform_CGAffineTransform_CMTimeRange(base.SuperHandle, selSetTransformRampFromStartTransform_ToEndTransform_TimeRange_Handle, startTransform, endTransform, timeRange);
		}
	}
}
