using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsBallSocketJoint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsBallSocketJoint : SCNPhysicsBehavior
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorA = "anchorA";

	private static readonly IntPtr selAnchorAHandle = Selector.GetHandle("anchorA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorB = "anchorB";

	private static readonly IntPtr selAnchorBHandle = Selector.GetHandle("anchorB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyA = "bodyA";

	private static readonly IntPtr selBodyAHandle = Selector.GetHandle("bodyA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyB = "bodyB";

	private static readonly IntPtr selBodyBHandle = Selector.GetHandle("bodyB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBody_Anchor_ = "jointWithBody:anchor:";

	private static readonly IntPtr selJointWithBody_Anchor_Handle = Selector.GetHandle("jointWithBody:anchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_AnchorA_BodyB_AnchorB_ = "jointWithBodyA:anchorA:bodyB:anchorB:";

	private static readonly IntPtr selJointWithBodyA_AnchorA_BodyB_AnchorB_Handle = Selector.GetHandle("jointWithBodyA:anchorA:bodyB:anchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorA_ = "setAnchorA:";

	private static readonly IntPtr selSetAnchorA_Handle = Selector.GetHandle("setAnchorA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorB_ = "setAnchorB:";

	private static readonly IntPtr selSetAnchorB_Handle = Selector.GetHandle("setAnchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsBallSocketJoint");

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
	public SCNPhysicsBallSocketJoint(NSCoder coder)
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
	protected SCNPhysicsBallSocketJoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsBallSocketJoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:anchorA:bodyB:anchorB:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsBallSocketJoint Create(SCNPhysicsBody bodyA, SCNVector3 anchorA, SCNPhysicsBody bodyB, SCNVector3 anchorB)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SCNPhysicsBallSocketJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNVector3_IntPtr_SCNVector3(class_ptr, selJointWithBodyA_AnchorA_BodyB_AnchorB_Handle, bodyA.Handle, anchorA, bodyB.Handle, anchorB));
	}

	[Export("jointWithBody:anchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsBallSocketJoint Create(SCNPhysicsBody body, SCNVector3 anchor)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return Runtime.GetNSObject<SCNPhysicsBallSocketJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNVector3(class_ptr, selJointWithBody_Anchor_Handle, body.Handle, anchor));
	}
}
