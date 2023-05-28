using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKPhysicsContact", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsContact : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyA = "bodyA";

	private static readonly IntPtr selBodyAHandle = Selector.GetHandle("bodyA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyB = "bodyB";

	private static readonly IntPtr selBodyBHandle = Selector.GetHandle("bodyB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollisionImpulse = "collisionImpulse";

	private static readonly IntPtr selCollisionImpulseHandle = Selector.GetHandle("collisionImpulse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactNormal = "contactNormal";

	private static readonly IntPtr selContactNormalHandle = Selector.GetHandle("contactNormal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactPoint = "contactPoint";

	private static readonly IntPtr selContactPointHandle = Selector.GetHandle("contactPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsContact");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPhysicsBody BodyA
	{
		[Export("bodyA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyAHandle));
			}
			return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyAHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPhysicsBody BodyB
	{
		[Export("bodyB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyBHandle));
			}
			return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyBHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat CollisionImpulse
	{
		[Export("collisionImpulse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selCollisionImpulseHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selCollisionImpulseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGVector ContactNormal
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("contactNormal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGVector_objc_msgSend(base.Handle, selContactNormalHandle);
			}
			return Messaging.CGVector_objc_msgSendSuper(base.SuperHandle, selContactNormalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ContactPoint
	{
		[Export("contactPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selContactPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selContactPointHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKPhysicsContact(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsContact(IntPtr handle)
		: base(handle)
	{
	}
}
