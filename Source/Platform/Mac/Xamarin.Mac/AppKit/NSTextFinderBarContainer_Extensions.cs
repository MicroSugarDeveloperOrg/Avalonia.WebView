using ObjCRuntime;

namespace AppKit;

public static class NSTextFinderBarContainer_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView GetContentView(this INSTextFinderBarContainer This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("contentView")));
	}
}
