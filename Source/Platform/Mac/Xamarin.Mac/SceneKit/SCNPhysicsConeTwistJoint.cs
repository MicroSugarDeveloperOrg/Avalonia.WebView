using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsConeTwistJoint", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsConeTwistJoint : SCNPhysicsBehavior
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyA = "bodyA";

	private static readonly IntPtr selBodyAHandle = Selector.GetHandle("bodyA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyB = "bodyB";

	private static readonly IntPtr selBodyBHandle = Selector.GetHandle("bodyB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameA = "frameA";

	private static readonly IntPtr selFrameAHandle = Selector.GetHandle("frameA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameB = "frameB";

	private static readonly IntPtr selFrameBHandle = Selector.GetHandle("frameB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBody_Frame_ = "jointWithBody:frame:";

	private static readonly IntPtr selJointWithBody_Frame_Handle = Selector.GetHandle("jointWithBody:frame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_FrameA_BodyB_FrameB_ = "jointWithBodyA:frameA:bodyB:frameB:";

	private static readonly IntPtr selJointWithBodyA_FrameA_BodyB_FrameB_Handle = Selector.GetHandle("jointWithBodyA:frameA:bodyB:frameB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumAngularLimit1 = "maximumAngularLimit1";

	private static readonly IntPtr selMaximumAngularLimit1Handle = Selector.GetHandle("maximumAngularLimit1");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumAngularLimit2 = "maximumAngularLimit2";

	private static readonly IntPtr selMaximumAngularLimit2Handle = Selector.GetHandle("maximumAngularLimit2");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumTwistAngle = "maximumTwistAngle";

	private static readonly IntPtr selMaximumTwistAngleHandle = Selector.GetHandle("maximumTwistAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameA_ = "setFrameA:";

	private static readonly IntPtr selSetFrameA_Handle = Selector.GetHandle("setFrameA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameB_ = "setFrameB:";

	private static readonly IntPtr selSetFrameB_Handle = Selector.GetHandle("setFrameB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumAngularLimit1_ = "setMaximumAngularLimit1:";

	private static readonly IntPtr selSetMaximumAngularLimit1_Handle = Selector.GetHandle("setMaximumAngularLimit1:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumAngularLimit2_ = "setMaximumAngularLimit2:";

	private static readonly IntPtr selSetMaximumAngularLimit2_Handle = Selector.GetHandle("setMaximumAngularLimit2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumTwistAngle_ = "setMaximumTwistAngle:";

	private static readonly IntPtr selSetMaximumTwistAngle_Handle = Selector.GetHandle("setMaximumTwistAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsConeTwistJoint");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual SCNPhysicsBody? BodyB
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
	public virtual SCNMatrix4 FrameA
	{
		[Export("frameA", ArgumentSemantic.Assign)]
		get
		{
			SCNMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNMatrix4_objc_msgSend_stret(out retval, base.Handle, selFrameAHandle);
			}
			else
			{
				Messaging.SCNMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameAHandle);
			}
			return retval;
		}
		[Export("setFrameA:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNMatrix4(base.Handle, selSetFrameA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNMatrix4(base.SuperHandle, selSetFrameA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMatrix4 FrameB
	{
		[Export("frameB", ArgumentSemantic.Assign)]
		get
		{
			SCNMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNMatrix4_objc_msgSend_stret(out retval, base.Handle, selFrameBHandle);
			}
			else
			{
				Messaging.SCNMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameBHandle);
			}
			return retval;
		}
		[Export("setFrameB:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNMatrix4(base.Handle, selSetFrameB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNMatrix4(base.SuperHandle, selSetFrameB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaximumAngularLimit1
	{
		[Export("maximumAngularLimit1")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumAngularLimit1Handle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumAngularLimit1Handle);
		}
		[Export("setMaximumAngularLimit1:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumAngularLimit1_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumAngularLimit1_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaximumAngularLimit2
	{
		[Export("maximumAngularLimit2")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumAngularLimit2Handle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumAngularLimit2Handle);
		}
		[Export("setMaximumAngularLimit2:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumAngularLimit2_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumAngularLimit2_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaximumTwistAngle
	{
		[Export("maximumTwistAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumTwistAngleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumTwistAngleHandle);
		}
		[Export("setMaximumTwistAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumTwistAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumTwistAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNPhysicsConeTwistJoint()
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
	public SCNPhysicsConeTwistJoint(NSCoder coder)
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
	protected SCNPhysicsConeTwistJoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsConeTwistJoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:frameA:bodyB:frameB:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsConeTwistJoint FromBodies(SCNPhysicsBody bodyA, SCNMatrix4 frameA, SCNPhysicsBody bodyB, SCNMatrix4 frameB)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SCNPhysicsConeTwistJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNMatrix4_IntPtr_SCNMatrix4(class_ptr, selJointWithBodyA_FrameA_BodyB_FrameB_Handle, bodyA.Handle, frameA, bodyB.Handle, frameB));
	}

	[Export("jointWithBody:frame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsConeTwistJoint FromBody(SCNPhysicsBody body, SCNMatrix4 frame)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return Runtime.GetNSObject<SCNPhysicsConeTwistJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNMatrix4(class_ptr, selJointWithBody_Frame_Handle, body.Handle, frame));
	}
}
