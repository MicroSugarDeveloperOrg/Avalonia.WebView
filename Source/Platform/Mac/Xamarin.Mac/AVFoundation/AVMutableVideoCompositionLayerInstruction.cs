using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableVideoCompositionLayerInstruction", true)]
public class AVMutableVideoCompositionLayerInstruction : AVVideoCompositionLayerInstruction
{
	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	private static readonly IntPtr selSetTrackID_Handle = Selector.GetHandle("setTrackID:");

	private static readonly IntPtr selVideoCompositionLayerInstructionWithAssetTrack_Handle = Selector.GetHandle("videoCompositionLayerInstructionWithAssetTrack:");

	private static readonly IntPtr selVideoCompositionLayerInstructionHandle = Selector.GetHandle("videoCompositionLayerInstruction");

	private static readonly IntPtr selSetTransformRampFromStartTransformToEndTransformTimeRange_Handle = Selector.GetHandle("setTransformRampFromStartTransform:toEndTransform:timeRange:");

	private static readonly IntPtr selSetTransformAtTime_Handle = Selector.GetHandle("setTransform:atTime:");

	private static readonly IntPtr selSetOpacityRampFromStartOpacityToEndOpacityTimeRange_Handle = Selector.GetHandle("setOpacityRampFromStartOpacity:toEndOpacity:timeRange:");

	private static readonly IntPtr selSetOpacityAtTime_Handle = Selector.GetHandle("setOpacity:atTime:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableVideoCompositionLayerInstruction");

	public override IntPtr ClassHandle => class_ptr;

	public new virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
		}
		[Export("setTrackID:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTrackID_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTrackID_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableVideoCompositionLayerInstruction()
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
	public AVMutableVideoCompositionLayerInstruction(NSCoder coder)
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
	public AVMutableVideoCompositionLayerInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableVideoCompositionLayerInstruction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoCompositionLayerInstructionWithAssetTrack:")]
	public static AVMutableVideoCompositionLayerInstruction FromAssetTrack(AVAssetTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return (AVMutableVideoCompositionLayerInstruction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoCompositionLayerInstructionWithAssetTrack_Handle, track.Handle));
	}

	[Export("videoCompositionLayerInstruction")]
	public static AVMutableVideoCompositionLayerInstruction Create()
	{
		return (AVMutableVideoCompositionLayerInstruction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selVideoCompositionLayerInstructionHandle));
	}

	[Export("setTransformRampFromStartTransform:toEndTransform:timeRange:")]
	public virtual void SetTransformRamp(CGAffineTransform startTransform, CGAffineTransform endTransform, CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGAffineTransform_CGAffineTransform_CMTimeRange(base.Handle, selSetTransformRampFromStartTransformToEndTransformTimeRange_Handle, startTransform, endTransform, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGAffineTransform_CGAffineTransform_CMTimeRange(base.SuperHandle, selSetTransformRampFromStartTransformToEndTransformTimeRange_Handle, startTransform, endTransform, timeRange);
		}
	}

	[Export("setTransform:atTime:")]
	public virtual void SetTransform(CGAffineTransform transform, CMTime atTime)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGAffineTransform_CMTime(base.Handle, selSetTransformAtTime_Handle, transform, atTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGAffineTransform_CMTime(base.SuperHandle, selSetTransformAtTime_Handle, transform, atTime);
		}
	}

	[Export("setOpacityRampFromStartOpacity:toEndOpacity:timeRange:")]
	public virtual void SetOpacityRamp(float startOpacity, float endOpacity, CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float_CMTimeRange(base.Handle, selSetOpacityRampFromStartOpacityToEndOpacityTimeRange_Handle, startOpacity, endOpacity, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float_CMTimeRange(base.SuperHandle, selSetOpacityRampFromStartOpacityToEndOpacityTimeRange_Handle, startOpacity, endOpacity, timeRange);
		}
	}

	[Export("setOpacity:atTime:")]
	public virtual void SetOpacity(float opacity, CMTime time)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime(base.Handle, selSetOpacityAtTime_Handle, opacity, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime(base.SuperHandle, selSetOpacityAtTime_Handle, opacity, time);
		}
	}
}
