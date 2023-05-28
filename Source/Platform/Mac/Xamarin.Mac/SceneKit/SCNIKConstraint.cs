using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNIKConstraint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNIKConstraint : SCNConstraint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChainRootNode = "chainRootNode";

	private static readonly IntPtr selChainRootNodeHandle = Selector.GetHandle("chainRootNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithChainRootNode_ = "initWithChainRootNode:";

	private static readonly IntPtr selInitWithChainRootNode_Handle = Selector.GetHandle("initWithChainRootNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInverseKinematicsConstraintWithChainRootNode_ = "inverseKinematicsConstraintWithChainRootNode:";

	private static readonly IntPtr selInverseKinematicsConstraintWithChainRootNode_Handle = Selector.GetHandle("inverseKinematicsConstraintWithChainRootNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxAllowedRotationAngleForJoint_ = "maxAllowedRotationAngleForJoint:";

	private static readonly IntPtr selMaxAllowedRotationAngleForJoint_Handle = Selector.GetHandle("maxAllowedRotationAngleForJoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxAllowedRotationAngle_ForJoint_ = "setMaxAllowedRotationAngle:forJoint:";

	private static readonly IntPtr selSetMaxAllowedRotationAngle_ForJoint_Handle = Selector.GetHandle("setMaxAllowedRotationAngle:forJoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTargetPosition_ = "setTargetPosition:";

	private static readonly IntPtr selSetTargetPosition_Handle = Selector.GetHandle("setTargetPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetPosition = "targetPosition";

	private static readonly IntPtr selTargetPositionHandle = Selector.GetHandle("targetPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNIKConstraint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode ChainRootNode
	{
		[Export("chainRootNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selChainRootNodeHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChainRootNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 TargetPosition
	{
		[Export("targetPosition")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selTargetPositionHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTargetPositionHandle);
			}
			return retval;
		}
		[Export("setTargetPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetTargetPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetTargetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNIKConstraint(NSCoder coder)
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
	protected SCNIKConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNIKConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithChainRootNode:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNIKConstraint(SCNNode chainRootNode)
		: base(NSObjectFlag.Empty)
	{
		if (chainRootNode == null)
		{
			throw new ArgumentNullException("chainRootNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithChainRootNode_Handle, chainRootNode.Handle), "initWithChainRootNode:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithChainRootNode_Handle, chainRootNode.Handle), "initWithChainRootNode:");
		}
	}

	[Export("inverseKinematicsConstraintWithChainRootNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNIKConstraint Create(SCNNode chainRootNode)
	{
		if (chainRootNode == null)
		{
			throw new ArgumentNullException("chainRootNode");
		}
		return Runtime.GetNSObject<SCNIKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInverseKinematicsConstraintWithChainRootNode_Handle, chainRootNode.Handle));
	}

	[Export("maxAllowedRotationAngleForJoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetMaxAllowedRotationAngle(SCNNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr(base.Handle, selMaxAllowedRotationAngleForJoint_Handle, node.Handle);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr(base.SuperHandle, selMaxAllowedRotationAngleForJoint_Handle, node.Handle);
	}

	[Export("setMaxAllowedRotationAngle:forJoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMaxAllowedRotationAnglet(nfloat angle, SCNNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selSetMaxAllowedRotationAngle_ForJoint_Handle, angle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selSetMaxAllowedRotationAngle_ForJoint_Handle, angle, node.Handle);
		}
	}
}
