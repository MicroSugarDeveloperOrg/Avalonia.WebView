using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKPhysicsJointFixed", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsJointFixed : SKPhysicsJoint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_BodyB_Anchor_ = "jointWithBodyA:bodyB:anchor:";

	private static readonly IntPtr selJointWithBodyA_BodyB_Anchor_Handle = Selector.GetHandle("jointWithBodyA:bodyB:anchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsJointFixed");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKPhysicsJointFixed(NSCoder coder)
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
	protected SKPhysicsJointFixed(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsJointFixed(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:bodyB:anchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsJointFixed Create(SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchor)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SKPhysicsJointFixed>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint(class_ptr, selJointWithBodyA_BodyB_Anchor_Handle, bodyA.Handle, bodyB.Handle, anchor));
	}
}
