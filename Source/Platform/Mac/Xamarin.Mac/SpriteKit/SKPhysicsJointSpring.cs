using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKPhysicsJointSpring", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsJointSpring : SKPhysicsJoint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDamping = "damping";

	private static readonly IntPtr selDampingHandle = Selector.GetHandle("damping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrequency = "frequency";

	private static readonly IntPtr selFrequencyHandle = Selector.GetHandle("frequency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_BodyB_AnchorA_AnchorB_ = "jointWithBodyA:bodyB:anchorA:anchorB:";

	private static readonly IntPtr selJointWithBodyA_BodyB_AnchorA_AnchorB_Handle = Selector.GetHandle("jointWithBodyA:bodyB:anchorA:anchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDamping_ = "setDamping:";

	private static readonly IntPtr selSetDamping_Handle = Selector.GetHandle("setDamping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrequency_ = "setFrequency:";

	private static readonly IntPtr selSetFrequency_Handle = Selector.GetHandle("setFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsJointSpring");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Damping
	{
		[Export("damping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDampingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDampingHandle);
		}
		[Export("setDamping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDamping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDamping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Frequency
	{
		[Export("frequency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFrequencyHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFrequencyHandle);
		}
		[Export("setFrequency:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFrequency_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFrequency_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKPhysicsJointSpring(NSCoder coder)
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
	protected SKPhysicsJointSpring(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsJointSpring(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:bodyB:anchorA:anchorB:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsJointSpring Create(SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchorA, CGPoint anchorB)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SKPhysicsJointSpring>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint_CGPoint(class_ptr, selJointWithBodyA_BodyB_AnchorA_AnchorB_Handle, bodyA.Handle, bodyB.Handle, anchorA, anchorB));
	}
}
