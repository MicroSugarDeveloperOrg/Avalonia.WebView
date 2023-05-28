using ObjCRuntime;

namespace Foundation;

public static class NSObjectProtocol_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetDebugDescription(this INSObjectProtocol This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("debugDescription")));
	}
}
