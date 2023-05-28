using ObjCRuntime;

namespace AVFoundation;

public static class AVFragmentMinding_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAssociatedWithFragmentMinder(this IAVFragmentMinding This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isAssociatedWithFragmentMinder"));
	}
}
