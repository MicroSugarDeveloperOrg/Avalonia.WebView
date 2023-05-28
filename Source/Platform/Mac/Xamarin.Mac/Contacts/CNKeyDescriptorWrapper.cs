using System;
using Foundation;
using ObjCRuntime;

namespace Contacts;

internal sealed class CNKeyDescriptorWrapper : BaseWrapper, ICNKeyDescriptor, INativeObject, IDisposable, INSCoding, INSCopying, INSObjectProtocol, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Description
	{
		[Export("description")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("description")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Class Superclass
	{
		[Export("superclass")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("superclass"));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Class Class
	{
		[Export("class")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("class"));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject Self
	{
		[Export("self")]
		get
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("self")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsProxy
	{
		[Export("isProxy")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isProxy"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint RetainCount
	{
		[Export("retainCount")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("retainCount"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSZone Zone
	{
		[Export("zone")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("zone"));
			return (intPtr == IntPtr.Zero) ? null : new NSZone(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public CNKeyDescriptorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("encodeWithCoder:"), encoder.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("hash")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint GetNativeHash()
	{
		return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("hash"));
	}

	[Export("isEqual:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsEqual(NSObject? anObject)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("isEqual:"), anObject?.Handle ?? IntPtr.Zero);
	}

	[Export("performSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject PerformSelector(Selector aSelector)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("performSelector:"), aSelector.Handle));
	}

	[Export("performSelector:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject PerformSelector(Selector aSelector, NSObject? anObject)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("performSelector:withObject:"), aSelector.Handle, anObject?.Handle ?? IntPtr.Zero));
	}

	[Export("performSelector:withObject:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject PerformSelector(Selector aSelector, NSObject? object1, NSObject? object2)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("performSelector:withObject:withObject:"), aSelector.Handle, object1?.Handle ?? IntPtr.Zero, object2?.Handle ?? IntPtr.Zero));
	}

	[Export("isKindOfClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsKindOfClass(Class? aClass)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("isKindOfClass:"), aClass?.Handle ?? IntPtr.Zero);
	}

	[Export("isMemberOfClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsMemberOfClass(Class? aClass)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("isMemberOfClass:"), aClass?.Handle ?? IntPtr.Zero);
	}

	[Export("conformsToProtocol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ConformsToProtocol(IntPtr aProtocol)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("conformsToProtocol:"), aProtocol);
	}

	[Export("respondsToSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool RespondsToSelector(Selector? sel)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("respondsToSelector:"), (sel == null) ? IntPtr.Zero : sel.Handle);
	}

	[Export("retain")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject DangerousRetain()
	{
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("retain")));
	}

	[Export("release")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DangerousRelease()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("release"));
	}

	[Export("autorelease")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject DangerousAutorelease()
	{
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("autorelease")));
	}
}
