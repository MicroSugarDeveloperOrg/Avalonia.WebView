using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoCompositionLayerInstruction", true)]
public class AVVideoCompositionLayerInstruction : NSObject
{
	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	private static readonly IntPtr selGetTransformRampForTimeStartTransformEndTransformTimeRange_Handle = Selector.GetHandle("getTransformRampForTime:startTransform:endTransform:timeRange:");

	private static readonly IntPtr selGetOpacityRampForTimeStartOpacityEndOpacityTimeRange_Handle = Selector.GetHandle("getOpacityRampForTime:startOpacity:endOpacity:timeRange:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVVideoCompositionLayerInstruction");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int TrackID
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
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoCompositionLayerInstruction()
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
	public AVVideoCompositionLayerInstruction(NSCoder coder)
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
	public AVVideoCompositionLayerInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVVideoCompositionLayerInstruction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getTransformRampForTime:startTransform:endTransform:timeRange:")]
	public virtual bool GetTransformRamp(CMTime time, ref CGAffineTransform startTransform, ref CGAffineTransform endTransform, ref CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime_out_CGAffineTransform_out_CGAffineTransform_out_CMTimeRange(base.Handle, selGetTransformRampForTimeStartTransformEndTransformTimeRange_Handle, time, out startTransform, out endTransform, out timeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime_out_CGAffineTransform_out_CGAffineTransform_out_CMTimeRange(base.SuperHandle, selGetTransformRampForTimeStartTransformEndTransformTimeRange_Handle, time, out startTransform, out endTransform, out timeRange);
	}

	[Export("getOpacityRampForTime:startOpacity:endOpacity:timeRange:")]
	public virtual bool GetOpacityRamp(CMTime time, ref float startOpacity, ref float endOpacity, ref CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime_out_Single_out_Single_out_CMTimeRange(base.Handle, selGetOpacityRampForTimeStartOpacityEndOpacityTimeRange_Handle, time, out startOpacity, out endOpacity, out timeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime_out_Single_out_Single_out_CMTimeRange(base.SuperHandle, selGetOpacityRampForTimeStartOpacityEndOpacityTimeRange_Handle, time, out startOpacity, out endOpacity, out timeRange);
	}
}
