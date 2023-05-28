using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNActionable_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetActionKeys(this ISCNActionable This)
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("actionKeys")));
	}
}
