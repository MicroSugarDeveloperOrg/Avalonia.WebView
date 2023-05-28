using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPasteboardTypeOwnerWrapper : BaseWrapper, INSPasteboardTypeOwner, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPasteboardTypeOwnerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("pasteboard:provideDataForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ProvideData(NSPasteboard sender, string type)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("pasteboard:provideDataForType:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}
