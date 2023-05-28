using System;
using ObjCRuntime;

namespace Foundation;

public static class NSKeyedUnarchiverDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DecodedObject(this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, NSObject obj)
	{
		if (unarchiver == null)
		{
			throw new ArgumentNullException("unarchiver");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("unarchiver:didDecodeObject:"), unarchiver.Handle, obj.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Finished(this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver)
	{
		if (unarchiver == null)
		{
			throw new ArgumentNullException("unarchiver");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("unarchiverDidFinish:"), unarchiver.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class CannotDecodeClass(this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, string klass, string[] classes)
	{
		if (unarchiver == null)
		{
			throw new ArgumentNullException("unarchiver");
		}
		if (klass == null)
		{
			throw new ArgumentNullException("klass");
		}
		if (classes == null)
		{
			throw new ArgumentNullException("classes");
		}
		IntPtr intPtr = NSString.CreateNative(klass);
		NSArray nSArray = NSArray.FromStrings(classes);
		IntPtr intPtr2 = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("unarchiver:cannotDecodeObjectOfClassName:originalClasses:"), unarchiver.Handle, intPtr, nSArray.Handle);
		NSString.ReleaseNative(intPtr);
		nSArray.Dispose();
		return (intPtr2 == IntPtr.Zero) ? null : new Class(intPtr2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Finishing(this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver)
	{
		if (unarchiver == null)
		{
			throw new ArgumentNullException("unarchiver");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("unarchiverWillFinish:"), unarchiver.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReplacingObject(this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
	{
		if (unarchiver == null)
		{
			throw new ArgumentNullException("unarchiver");
		}
		if (oldObject == null)
		{
			throw new ArgumentNullException("oldObject");
		}
		if (newObject == null)
		{
			throw new ArgumentNullException("newObject");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("unarchiver:willReplaceObject:withObject:"), unarchiver.Handle, oldObject.Handle, newObject.Handle);
	}
}
