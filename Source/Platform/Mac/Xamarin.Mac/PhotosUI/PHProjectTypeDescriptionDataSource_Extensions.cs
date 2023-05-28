using AppKit;
using ObjCRuntime;

namespace PhotosUI;

public static class PHProjectTypeDescriptionDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDiscardDataSource(this IPHProjectTypeDescriptionDataSource This)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("extensionWillDiscardDataSource"));
	}
}
