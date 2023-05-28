using System;
using ObjCRuntime;

namespace SpriteKit;

public static class SKPhysicsContactDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBeginContact(this ISKPhysicsContactDelegate This, SKPhysicsContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didBeginContact:"), contact.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndContact(this ISKPhysicsContactDelegate This, SKPhysicsContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didEndContact:"), contact.Handle);
	}
}
