using ObjCRuntime;

namespace Metal;

public static class MTLRenderPipelineState_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetSupportIndirectCommandBuffers(this IMTLRenderPipelineState This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("supportIndirectCommandBuffers"));
	}
}
