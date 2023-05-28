using System;
using ObjCRuntime;

namespace SceneKit;

public static class SCNAvoidOccluderConstraintDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldAvoidOccluder(this ISCNAvoidOccluderConstraintDelegate This, SCNAvoidOccluderConstraint constraint, SCNNode occluder, SCNNode node)
	{
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		if (occluder == null)
		{
			throw new ArgumentNullException("occluder");
		}
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("avoidOccluderConstraint:shouldAvoidOccluder:forNode:"), constraint.Handle, occluder.Handle, node.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAvoidOccluder(this ISCNAvoidOccluderConstraintDelegate This, SCNAvoidOccluderConstraint constraint, SCNNode occluder, SCNNode node)
	{
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		if (occluder == null)
		{
			throw new ArgumentNullException("occluder");
		}
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("avoidOccluderConstraint:didAvoidOccluder:forNode:"), constraint.Handle, occluder.Handle, node.Handle);
	}
}
