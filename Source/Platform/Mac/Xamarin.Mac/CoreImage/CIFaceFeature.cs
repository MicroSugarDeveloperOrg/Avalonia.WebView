using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFaceFeature", true)]
public class CIFaceFeature : CIFeature
{
	private static readonly IntPtr selHasLeftEyePositionHandle = Selector.GetHandle("hasLeftEyePosition");

	private static readonly IntPtr selLeftEyePositionHandle = Selector.GetHandle("leftEyePosition");

	private static readonly IntPtr selHasRightEyePositionHandle = Selector.GetHandle("hasRightEyePosition");

	private static readonly IntPtr selRightEyePositionHandle = Selector.GetHandle("rightEyePosition");

	private static readonly IntPtr selHasMouthPositionHandle = Selector.GetHandle("hasMouthPosition");

	private static readonly IntPtr selMouthPositionHandle = Selector.GetHandle("mouthPosition");

	private static readonly IntPtr selHasTrackingIDHandle = Selector.GetHandle("hasTrackingID");

	private static readonly IntPtr selTrackingIDHandle = Selector.GetHandle("trackingID");

	private static readonly IntPtr selHasTrackingFrameCountHandle = Selector.GetHandle("hasTrackingFrameCount");

	private static readonly IntPtr selTrackingFrameCountHandle = Selector.GetHandle("trackingFrameCount");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIFaceFeature");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool HasLeftEyePosition
	{
		[Export("hasLeftEyePosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasLeftEyePositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasLeftEyePositionHandle);
		}
	}

	public virtual CGPoint LeftEyePosition
	{
		[Export("leftEyePosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selLeftEyePositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selLeftEyePositionHandle);
		}
	}

	public virtual bool HasRightEyePosition
	{
		[Export("hasRightEyePosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasRightEyePositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasRightEyePositionHandle);
		}
	}

	public virtual CGPoint RightEyePosition
	{
		[Export("rightEyePosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selRightEyePositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selRightEyePositionHandle);
		}
	}

	public virtual bool HasMouthPosition
	{
		[Export("hasMouthPosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasMouthPositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasMouthPositionHandle);
		}
	}

	public virtual CGPoint MouthPosition
	{
		[Export("mouthPosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selMouthPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selMouthPositionHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool HasTrackingId
	{
		[Export("hasTrackingID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasTrackingIDHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasTrackingIDHandle);
		}
	}

	[Since(6, 0)]
	public virtual int TrackingId
	{
		[Export("trackingID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackingIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackingIDHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool HasTrackingFrameCount
	{
		[Export("hasTrackingFrameCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasTrackingFrameCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasTrackingFrameCountHandle);
		}
	}

	[Since(6, 0)]
	public virtual int TrackingFrameCount
	{
		[Export("trackingFrameCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackingFrameCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackingFrameCountHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFaceFeature(NSCoder coder)
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
	public CIFaceFeature(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIFaceFeature(IntPtr handle)
		: base(handle)
	{
	}
}
