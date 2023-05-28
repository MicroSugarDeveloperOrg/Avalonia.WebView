using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSharingServicePickerTouchBarItemDelegateWrapper : BaseWrapper, INSSharingServicePickerTouchBarItemDelegate, INativeObject, IDisposable, INSSharingServicePickerDelegate
{
	[Preserve(Conditional = true)]
	public NSSharingServicePickerTouchBarItemDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("itemsForSharingServicePickerTouchBarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSPasteboardWriting[] ItemsForSharingServicePickerTouchBarItem(NSSharingServicePickerTouchBarItem pickerTouchBarItem)
	{
		NSApplication.EnsureUIThread();
		if (pickerTouchBarItem == null)
		{
			throw new ArgumentNullException("pickerTouchBarItem");
		}
		return NSArray.ArrayFromHandle<INSPasteboardWriting>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("itemsForSharingServicePickerTouchBarItem:"), pickerTouchBarItem.Handle));
	}
}
