using System;
using ObjCRuntime;

namespace ModelIO;

public static class MDLMeshBufferZone_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCapacity(this IMDLMeshBufferZone This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("capacity"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMDLMeshBufferAllocator GetAllocator(this IMDLMeshBufferZone This)
	{
		return Runtime.GetINativeObject<IMDLMeshBufferAllocator>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("allocator")), owns: false);
	}
}
