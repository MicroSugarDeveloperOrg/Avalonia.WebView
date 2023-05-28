using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPasteboardItemDataProviderWrapper : BaseWrapper, INSPasteboardItemDataProvider, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPasteboardItemDataProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("pasteboard:item:provideDataForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ProvideDataForType(NSPasteboard pasteboard, NSPasteboardItem item, string type)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("pasteboard:item:provideDataForType:"), pasteboard.Handle, item.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("pasteboardFinishedWithDataProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishedWithDataProvider(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("pasteboardFinishedWithDataProvider:"), pasteboard.Handle);
	}
}
