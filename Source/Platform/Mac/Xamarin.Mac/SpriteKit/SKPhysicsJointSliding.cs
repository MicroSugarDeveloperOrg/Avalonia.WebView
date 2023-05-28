using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKPhysicsJointSliding", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsJointSliding : SKPhysicsJoint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_BodyB_Anchor_Axis_ = "jointWithBodyA:bodyB:anchor:axis:";

	private static readonly IntPtr selJointWithBodyA_BodyB_Anchor_Axis_Handle = Selector.GetHandle("jointWithBodyA:bodyB:anchor:axis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowerDistanceLimit = "lowerDistanceLimit";

	private static readonly IntPtr selLowerDistanceLimitHandle = Selector.GetHandle("lowerDistanceLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLowerDistanceLimit_ = "setLowerDistanceLimit:";

	private static readonly IntPtr selSetLowerDistanceLimit_Handle = Selector.GetHandle("setLowerDistanceLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldEnableLimits_ = "setShouldEnableLimits:";

	private static readonly IntPtr selSetShouldEnableLimits_Handle = Selector.GetHandle("setShouldEnableLimits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpperDistanceLimit_ = "setUpperDistanceLimit:";

	private static readonly IntPtr selSetUpperDistanceLimit_Handle = Selector.GetHandle("setUpperDistanceLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldEnableLimits = "shouldEnableLimits";

	private static readonly IntPtr selShouldEnableLimitsHandle = Selector.GetHandle("shouldEnableLimits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpperDistanceLimit = "upperDistanceLimit";

	private static readonly IntPtr selUpperDistanceLimitHandle = Selector.GetHandle("upperDistanceLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsJointSliding");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LowerDistanceLimit
	{
		[Export("lowerDistanceLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLowerDistanceLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLowerDistanceLimitHandle);
		}
		[Export("setLowerDistanceLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLowerDistanceLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLowerDistanceLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEnableLimits
	{
		[Export("shouldEnableLimits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldEnableLimitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldEnableLimitsHandle);
		}
		[Export("setShouldEnableLimits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldEnableLimits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldEnableLimits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat UpperDistanceLimit
	{
		[Export("upperDistanceLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUpperDistanceLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUpperDistanceLimitHandle);
		}
		[Export("setUpperDistanceLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetUpperDistanceLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetUpperDistanceLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKPhysicsJointSliding(NSCoder coder)
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
	protected SKPhysicsJointSliding(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsJointSliding(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:bodyB:anchor:axis:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsJointSliding Create(SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchor, CGVector axis)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SKPhysicsJointSliding>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint_CGVector(class_ptr, selJointWithBodyA_BodyB_Anchor_Axis_Handle, bodyA.Handle, bodyB.Handle, anchor, axis));
	}
}
