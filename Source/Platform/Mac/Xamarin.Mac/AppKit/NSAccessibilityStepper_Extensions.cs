using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityStepper_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetAccessibilityValue(this INSAccessibilityStepper This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityValue")));
	}
}
