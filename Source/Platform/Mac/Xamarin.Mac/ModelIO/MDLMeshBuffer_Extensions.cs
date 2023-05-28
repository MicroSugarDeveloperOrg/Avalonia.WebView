using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

public static class MDLMeshBuffer_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetLength(this IMDLMeshBuffer This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("length"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMDLMeshBufferAllocator GetAllocator(this IMDLMeshBuffer This)
	{
		return Runtime.GetINativeObject<IMDLMeshBufferAllocator>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("allocator")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMDLMeshBufferZone GetZone(this IMDLMeshBuffer This)
	{
		return Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("zone")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMeshBufferType GetType(this IMDLMeshBuffer This)
	{
		return (MDLMeshBufferType)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("type"));
	}
}
