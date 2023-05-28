using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

public static class MTLResource_Extensions
{
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeAliasable(this IMTLResource This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("makeAliasable"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLStorageMode GetStorageMode(this IMTLResource This)
	{
		return (MTLStorageMode)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("storageMode"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLHeap GetHeap(this IMTLResource This)
	{
		return Runtime.GetINativeObject<IMTLHeap>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("heap")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetIsAliasable(this IMTLResource This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isAliasable"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetAllocatedSize(this IMTLResource This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("allocatedSize"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLResourceOptions GetResourceOptions(this IMTLResource This)
	{
		return (MTLResourceOptions)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("resourceOptions"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetHeapOffset(this IMTLResource This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("heapOffset"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLHazardTrackingMode GetHazardTrackingMode(this IMTLResource This)
	{
		return (MTLHazardTrackingMode)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("hazardTrackingMode"));
	}
}
