using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrl_PromisedItems
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckPromisedItemIsReachableAndReturnError_ = "checkPromisedItemIsReachableAndReturnError:";

	private static readonly IntPtr selCheckPromisedItemIsReachableAndReturnError_Handle = Selector.GetHandle("checkPromisedItemIsReachableAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPromisedItemResourceValue_ForKey_Error_ = "getPromisedItemResourceValue:forKey:error:";

	private static readonly IntPtr selGetPromisedItemResourceValue_ForKey_Error_Handle = Selector.GetHandle("getPromisedItemResourceValue:forKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPromisedItemResourceValuesForKeys_Error_ = "promisedItemResourceValuesForKeys:error:";

	private static readonly IntPtr selPromisedItemResourceValuesForKeys_Error_Handle = Selector.GetHandle("promisedItemResourceValuesForKeys:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSURL");

	[Obsolete("Use overload with an 'out NSObject value' parameter.")]
	public static bool GetPromisedItemResourceValue(NSUrl This, NSObject value, NSString key, out NSError error)
	{
		return This.GetPromisedItemResourceValue(out value, key, out error);
	}

	[Export("checkPromisedItemIsReachableAndReturnError:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CheckPromisedItemIsReachable(this NSUrl This, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_ref_IntPtr(This.Handle, selCheckPromisedItemIsReachableAndReturnError_Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("getPromisedItemResourceValue:forKey:error:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetPromisedItemResourceValue(this NSUrl This, out NSObject value, NSString key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(This.Handle, selGetPromisedItemResourceValue_ForKey_Error_Handle, ref arg, key.Handle, ref arg2);
		value = Runtime.GetNSObject<NSObject>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("promisedItemResourceValuesForKeys:error:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary GetPromisedItemResourceValues(this NSUrl This, NSString[] keys, out NSError error)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(keys);
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, selPromisedItemResourceValuesForKeys_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}
