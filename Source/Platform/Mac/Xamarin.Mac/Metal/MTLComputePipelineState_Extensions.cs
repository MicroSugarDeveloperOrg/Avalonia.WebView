using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

public static class MTLComputePipelineState_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetLabel(this IMTLComputePipelineState This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("label")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetStaticThreadgroupMemoryLength(this IMTLComputePipelineState This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("staticThreadgroupMemoryLength"));
	}
}
