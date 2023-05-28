using System;
using ObjCRuntime;

namespace Foundation;

public static class NSMetadataQueryDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ReplacementObjectForResultObject(this INSMetadataQueryDelegate This, NSMetadataQuery query, NSMetadataItem result)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("metadataQuery:replacementObjectForResultObject:"), query.Handle, result.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ReplacementValueForAttributevalue(this INSMetadataQueryDelegate This, NSMetadataQuery query, string attributeName, NSObject value)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr intPtr = NSString.CreateNative(attributeName);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("metadataQuery:replacementValueForAttribute:value:"), query.Handle, intPtr, value.Handle));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}
