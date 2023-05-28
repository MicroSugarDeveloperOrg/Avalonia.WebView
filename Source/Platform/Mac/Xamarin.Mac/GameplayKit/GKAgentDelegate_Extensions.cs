using System;
using ObjCRuntime;

namespace GameplayKit;

public static class GKAgentDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AgentWillUpdate(this IGKAgentDelegate This, GKAgent agent)
	{
		if (agent == null)
		{
			throw new ArgumentNullException("agent");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("agentWillUpdate:"), agent.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AgentDidUpdate(this IGKAgentDelegate This, GKAgent agent)
	{
		if (agent == null)
		{
			throw new ArgumentNullException("agent");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("agentDidUpdate:"), agent.Handle);
	}
}
