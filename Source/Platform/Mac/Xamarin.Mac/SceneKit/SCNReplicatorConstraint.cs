using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNReplicatorConstraint", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class SCNReplicatorConstraint : SCNConstraint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientationOffset = "orientationOffset";

	private static readonly IntPtr selOrientationOffsetHandle = Selector.GetHandle("orientationOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositionOffset = "positionOffset";

	private static readonly IntPtr selPositionOffsetHandle = Selector.GetHandle("positionOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplicatesOrientation = "replicatesOrientation";

	private static readonly IntPtr selReplicatesOrientationHandle = Selector.GetHandle("replicatesOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplicatesPosition = "replicatesPosition";

	private static readonly IntPtr selReplicatesPositionHandle = Selector.GetHandle("replicatesPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplicatesScale = "replicatesScale";

	private static readonly IntPtr selReplicatesScaleHandle = Selector.GetHandle("replicatesScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplicatorConstraintWithTarget_ = "replicatorConstraintWithTarget:";

	private static readonly IntPtr selReplicatorConstraintWithTarget_Handle = Selector.GetHandle("replicatorConstraintWithTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleOffset = "scaleOffset";

	private static readonly IntPtr selScaleOffsetHandle = Selector.GetHandle("scaleOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientationOffset_ = "setOrientationOffset:";

	private static readonly IntPtr selSetOrientationOffset_Handle = Selector.GetHandle("setOrientationOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPositionOffset_ = "setPositionOffset:";

	private static readonly IntPtr selSetPositionOffset_Handle = Selector.GetHandle("setPositionOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReplicatesOrientation_ = "setReplicatesOrientation:";

	private static readonly IntPtr selSetReplicatesOrientation_Handle = Selector.GetHandle("setReplicatesOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReplicatesPosition_ = "setReplicatesPosition:";

	private static readonly IntPtr selSetReplicatesPosition_Handle = Selector.GetHandle("setReplicatesPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReplicatesScale_ = "setReplicatesScale:";

	private static readonly IntPtr selSetReplicatesScale_Handle = Selector.GetHandle("setReplicatesScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleOffset_ = "setScaleOffset:";

	private static readonly IntPtr selSetScaleOffset_Handle = Selector.GetHandle("setScaleOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNReplicatorConstraint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNQuaternion OrientationOffset
	{
		[Export("orientationOffset", ArgumentSemantic.Assign)]
		get
		{
			SCNQuaternion retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNQuaternion_objc_msgSend_stret(out retval, base.Handle, selOrientationOffsetHandle);
			}
			else
			{
				Messaging.SCNQuaternion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOrientationOffsetHandle);
			}
			return retval;
		}
		[Export("setOrientationOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNQuaternion(base.Handle, selSetOrientationOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNQuaternion(base.SuperHandle, selSetOrientationOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 PositionOffset
	{
		[Export("positionOffset", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selPositionOffsetHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPositionOffsetHandle);
			}
			return retval;
		}
		[Export("setPositionOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetPositionOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetPositionOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReplicatesOrientation
	{
		[Export("replicatesOrientation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReplicatesOrientationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReplicatesOrientationHandle);
		}
		[Export("setReplicatesOrientation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReplicatesOrientation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReplicatesOrientation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReplicatesPosition
	{
		[Export("replicatesPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReplicatesPositionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReplicatesPositionHandle);
		}
		[Export("setReplicatesPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReplicatesPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReplicatesPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReplicatesScale
	{
		[Export("replicatesScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReplicatesScaleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReplicatesScaleHandle);
		}
		[Export("setReplicatesScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReplicatesScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReplicatesScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 ScaleOffset
	{
		[Export("scaleOffset", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selScaleOffsetHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selScaleOffsetHandle);
			}
			return retval;
		}
		[Export("setScaleOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetScaleOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetScaleOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode? Target
	{
		[Export("target", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle));
		}
		[Export("setTarget:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNReplicatorConstraint()
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
	public SCNReplicatorConstraint(NSCoder coder)
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
	protected SCNReplicatorConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNReplicatorConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("replicatorConstraintWithTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNReplicatorConstraint FromTarget(SCNNode? target)
	{
		return Runtime.GetNSObject<SCNReplicatorConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReplicatorConstraintWithTarget_Handle, target?.Handle ?? IntPtr.Zero));
	}
}
