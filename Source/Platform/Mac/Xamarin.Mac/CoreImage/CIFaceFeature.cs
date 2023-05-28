using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFaceFeature", true)]
public class CIFaceFeature : CIFeature
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceAngle = "faceAngle";

	private static readonly IntPtr selFaceAngleHandle = Selector.GetHandle("faceAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasFaceAngle = "hasFaceAngle";

	private static readonly IntPtr selHasFaceAngleHandle = Selector.GetHandle("hasFaceAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasLeftEyePosition = "hasLeftEyePosition";

	private static readonly IntPtr selHasLeftEyePositionHandle = Selector.GetHandle("hasLeftEyePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMouthPosition = "hasMouthPosition";

	private static readonly IntPtr selHasMouthPositionHandle = Selector.GetHandle("hasMouthPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasRightEyePosition = "hasRightEyePosition";

	private static readonly IntPtr selHasRightEyePositionHandle = Selector.GetHandle("hasRightEyePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasSmile = "hasSmile";

	private static readonly IntPtr selHasSmileHandle = Selector.GetHandle("hasSmile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasTrackingFrameCount = "hasTrackingFrameCount";

	private static readonly IntPtr selHasTrackingFrameCountHandle = Selector.GetHandle("hasTrackingFrameCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasTrackingID = "hasTrackingID";

	private static readonly IntPtr selHasTrackingIDHandle = Selector.GetHandle("hasTrackingID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftEyeClosed = "leftEyeClosed";

	private static readonly IntPtr selLeftEyeClosedHandle = Selector.GetHandle("leftEyeClosed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftEyePosition = "leftEyePosition";

	private static readonly IntPtr selLeftEyePositionHandle = Selector.GetHandle("leftEyePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouthPosition = "mouthPosition";

	private static readonly IntPtr selMouthPositionHandle = Selector.GetHandle("mouthPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightEyeClosed = "rightEyeClosed";

	private static readonly IntPtr selRightEyeClosedHandle = Selector.GetHandle("rightEyeClosed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightEyePosition = "rightEyePosition";

	private static readonly IntPtr selRightEyePositionHandle = Selector.GetHandle("rightEyePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackingFrameCount = "trackingFrameCount";

	private static readonly IntPtr selTrackingFrameCountHandle = Selector.GetHandle("trackingFrameCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackingID = "trackingID";

	private static readonly IntPtr selTrackingIDHandle = Selector.GetHandle("trackingID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIFaceFeature");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public new virtual CGRect Bounds
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("bounds", ArgumentSemantic.Assign)]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual float FaceAngle
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("faceAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFaceAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFaceAngleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool HasFaceAngle
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("hasFaceAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasFaceAngleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasFaceAngleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasLeftEyePosition
	{
		[Export("hasLeftEyePosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasLeftEyePositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasLeftEyePositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMouthPosition
	{
		[Export("hasMouthPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasMouthPositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasMouthPositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasRightEyePosition
	{
		[Export("hasRightEyePosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasRightEyePositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasRightEyePositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool HasSmile
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("hasSmile")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasSmileHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasSmileHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasTrackingFrameCount
	{
		[Export("hasTrackingFrameCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasTrackingFrameCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasTrackingFrameCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasTrackingId
	{
		[Export("hasTrackingID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasTrackingIDHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasTrackingIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool LeftEyeClosed
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("leftEyeClosed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLeftEyeClosedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLeftEyeClosedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LeftEyePosition
	{
		[Export("leftEyePosition", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selLeftEyePositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selLeftEyePositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint MouthPosition
	{
		[Export("mouthPosition", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selMouthPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selMouthPositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool RightEyeClosed
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("rightEyeClosed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRightEyeClosedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRightEyeClosedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint RightEyePosition
	{
		[Export("rightEyePosition", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selRightEyePositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selRightEyePositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int TrackingFrameCount
	{
		[Export("trackingFrameCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackingFrameCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackingFrameCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int TrackingId
	{
		[Export("trackingID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackingIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackingIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIFaceFeature(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIFaceFeature(IntPtr handle)
		: base(handle)
	{
	}
}
