using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSharingServicePickerToolbarItemDelegateWrapper : BaseWrapper, INSSharingServicePickerToolbarItemDelegate, INativeObject, IDisposable, INSSharingServicePickerDelegate
{
	[Preserve(Conditional = true)]
	public NSSharingServicePickerToolbarItemDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("itemsForSharingServicePickerToolbarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject[] GetItems(NSSharingServicePickerToolbarItem pickerToolbarItem)
	{
		NSApplication.EnsureUIThread();
		if (pickerToolbarItem == null)
		{
			throw new ArgumentNullException("pickerToolbarItem");
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("itemsForSharingServicePickerToolbarItem:"), pickerToolbarItem.Handle));
	}
}
