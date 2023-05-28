using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsContact", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsContact : NSObject
{
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
	private const string selNodeA = "nodeA";

	private static readonly IntPtr selNodeAHandle = Selector.GetHandle("nodeA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeB = "nodeB";

	private static readonly IntPtr selNodeBHandle = Selector.GetHandle("nodeB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPenetrationDistance = "penetrationDistance";

	private static readonly IntPtr selPenetrationDistanceHandle = Selector.GetHandle("penetrationDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSweepTestFraction = "sweepTestFraction";

	private static readonly IntPtr selSweepTestFractionHandle = Selector.GetHandle("sweepTestFraction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsContact");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual SCNVector3 ContactNormal
	{
		[Export("contactNormal")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selContactNormalHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContactNormalHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 ContactPoint
	{
		[Export("contactPoint")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selContactPointHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContactPointHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode NodeA
	{
		[Export("nodeA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeAHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeAHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode NodeB
	{
		[Export("nodeB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeBHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeBHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat PenetrationDistance
	{
		[Export("penetrationDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPenetrationDistanceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPenetrationDistanceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nfloat SweepTestFraction
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("sweepTestFraction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSweepTestFractionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSweepTestFractionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNPhysicsContact(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsContact(IntPtr handle)
		: base(handle)
	{
	}
}
