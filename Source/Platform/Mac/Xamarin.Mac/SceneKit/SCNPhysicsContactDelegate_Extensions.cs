using System;
using ObjCRuntime;

namespace SceneKit;

public static class SCNPhysicsContactDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBeginContact(this ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
	{
		if (world == null)
		{
			throw new ArgumentNullException("world");
		}
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("physicsWorld:didBeginContact:"), world.Handle, contact.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUpdateContact(this ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
	{
		if (world == null)
		{
			throw new ArgumentNullException("world");
		}
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("physicsWorld:didUpdateContact:"), world.Handle, contact.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndContact(this ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
	{
		if (world == null)
		{
			throw new ArgumentNullException("world");
		}
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("physicsWorld:didEndContact:"), world.Handle, contact.Handle);
	}
}
