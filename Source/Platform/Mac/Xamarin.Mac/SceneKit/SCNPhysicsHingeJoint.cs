using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsHingeJoint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsHingeJoint : SCNPhysicsBehavior
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorA = "anchorA";

	private static readonly IntPtr selAnchorAHandle = Selector.GetHandle("anchorA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorB = "anchorB";

	private static readonly IntPtr selAnchorBHandle = Selector.GetHandle("anchorB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAxisA = "axisA";

	private static readonly IntPtr selAxisAHandle = Selector.GetHandle("axisA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAxisB = "axisB";

	private static readonly IntPtr selAxisBHandle = Selector.GetHandle("axisB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyA = "bodyA";

	private static readonly IntPtr selBodyAHandle = Selector.GetHandle("bodyA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyB = "bodyB";

	private static readonly IntPtr selBodyBHandle = Selector.GetHandle("bodyB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBody_Axis_Anchor_ = "jointWithBody:axis:anchor:";

	private static readonly IntPtr selJointWithBody_Axis_Anchor_Handle = Selector.GetHandle("jointWithBody:axis:anchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_AxisA_AnchorA_BodyB_AxisB_AnchorB_ = "jointWithBodyA:axisA:anchorA:bodyB:axisB:anchorB:";

	private static readonly IntPtr selJointWithBodyA_AxisA_AnchorA_BodyB_AxisB_AnchorB_Handle = Selector.GetHandle("jointWithBodyA:axisA:anchorA:bodyB:axisB:anchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorA_ = "setAnchorA:";

	private static readonly IntPtr selSetAnchorA_Handle = Selector.GetHandle("setAnchorA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorB_ = "setAnchorB:";

	private static readonly IntPtr selSetAnchorB_Handle = Selector.GetHandle("setAnchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAxisA_ = "setAxisA:";

	private static readonly IntPtr selSetAxisA_Handle = Selector.GetHandle("setAxisA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAxisB_ = "setAxisB:";

	private static readonly IntPtr selSetAxisB_Handle = Selector.GetHandle("setAxisB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsHingeJoint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AnchorA
	{
		[Export("anchorA")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAnchorAHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAnchorAHandle);
			}
			return retval;
		}
		[Export("setAnchorA:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAnchorA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAnchorA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AnchorB
	{
		[Export("anchorB")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAnchorBHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAnchorBHandle);
			}
			return retval;
		}
		[Export("setAnchorB:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAnchorB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAnchorB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AxisA
	{
		[Export("axisA")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAxisAHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAxisAHandle);
			}
			return retval;
		}
		[Export("setAxisA:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAxisA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAxisA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AxisB
	{
		[Export("axisB")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAxisBHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAxisBHandle);
			}
			return retval;
		}
		[Export("setAxisB:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAxisB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAxisB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBody BodyA
	{
		[Export("bodyA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyAHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyAHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBody BodyB
	{
		[Export("bodyB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyBHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyBHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsHingeJoint(NSCoder coder)
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
	protected SCNPhysicsHingeJoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsHingeJoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:axisA:anchorA:bodyB:axisB:anchorB:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsHingeJoint Create(SCNPhysicsBody bodyA, SCNVector3 axisA, SCNVector3 anchorA, SCNPhysicsBody? bodyB, SCNVector3 axisB, SCNVector3 anchorB)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		return Runtime.GetNSObject<SCNPhysicsHingeJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3_IntPtr_SCNVector3_SCNVector3(class_ptr, selJointWithBodyA_AxisA_AnchorA_BodyB_AxisB_AnchorB_Handle, bodyA.Handle, axisA, anchorA, bodyB?.Handle ?? IntPtr.Zero, axisB, anchorB));
	}

	[Export("jointWithBody:axis:anchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsHingeJoint Create(SCNPhysicsBody body, SCNVector3 axis, SCNVector3 anchor)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return Runtime.GetNSObject<SCNPhysicsHingeJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3(class_ptr, selJointWithBody_Axis_Anchor_Handle, body.Handle, axis, anchor));
	}
}
