using System;
using ObjCRuntime;

namespace Foundation;

public static class NSKeyedArchiverDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EncodedObject(this INSKeyedArchiverDelegate This, NSKeyedArchiver archiver, NSObject obj)
	{
		if (archiver == null)
		{
			throw new ArgumentNullException("archiver");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("archiver:didEncodeObject:"), archiver.Handle, obj.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Finished(this INSKeyedArchiverDelegate This, NSKeyedArchiver archiver)
	{
		if (archiver == null)
		{
			throw new ArgumentNullException("archiver");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("archiverDidFinish:"), archiver.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject WillEncode(this INSKeyedArchiverDelegate This, NSKeyedArchiver archiver, NSObject obj)
	{
		if (archiver == null)
		{
			throw new ArgumentNullException("archiver");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("archiver:willEncodeObject:"), archiver.Handle, obj.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Finishing(this INSKeyedArchiverDelegate This, NSKeyedArchiver archiver)
	{
		if (archiver == null)
		{
			throw new ArgumentNullException("archiver");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("archiverWillFinish:"), archiver.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReplacingObject(this INSKeyedArchiverDelegate This, NSKeyedArchiver archiver, NSObject oldObject, NSObject newObject)
	{
		if (archiver == null)
		{
			throw new ArgumentNullException("archiver");
		}
		if (oldObject == null)
		{
			throw new ArgumentNullException("oldObject");
		}
		if (newObject == null)
		{
			throw new ArgumentNullException("newObject");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("archiver:willReplaceObject:withObject:"), archiver.Handle, oldObject.Handle, newObject.Handle);
	}
}
