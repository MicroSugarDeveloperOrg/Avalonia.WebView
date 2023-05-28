using System;
using ObjCRuntime;

namespace Foundation;

public static class NSCacheDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillEvictObject(this INSCacheDelegate This, NSCache cache, NSObject obj)
	{
		if (cache == null)
		{
			throw new ArgumentNullException("cache");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cache:willEvictObject:"), cache.Handle, obj.Handle);
	}
}
