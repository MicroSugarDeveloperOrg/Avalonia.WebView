using ObjCRuntime;

namespace WebKit;

public static class WebPolicyDecisionListener_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Use(this IWebPolicyDecisionListener This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("use"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Download(this IWebPolicyDecisionListener This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("download"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Ignore(this IWebPolicyDecisionListener This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("ignore"));
	}
}
