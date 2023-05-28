using ObjCRuntime;

namespace Foundation;

public static class NSProgressReporting_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSProgress GetProgress(this INSProgressReporting This)
	{
		return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("progress")));
	}
}
