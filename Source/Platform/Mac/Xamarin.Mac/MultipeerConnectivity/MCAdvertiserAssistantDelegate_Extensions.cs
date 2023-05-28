using System;
using ObjCRuntime;

namespace MultipeerConnectivity;

public static class MCAdvertiserAssistantDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDismissInvitation(this IMCAdvertiserAssistantDelegate This, MCAdvertiserAssistant advertiserAssistant)
	{
		if (advertiserAssistant == null)
		{
			throw new ArgumentNullException("advertiserAssistant");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("advertiserAssistantDidDismissInvitation:"), advertiserAssistant.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillPresentInvitation(this IMCAdvertiserAssistantDelegate This, MCAdvertiserAssistant advertiserAssistant)
	{
		if (advertiserAssistant == null)
		{
			throw new ArgumentNullException("advertiserAssistant");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("advertiserAssistantWillPresentInvitation:"), advertiserAssistant.Handle);
	}
}
