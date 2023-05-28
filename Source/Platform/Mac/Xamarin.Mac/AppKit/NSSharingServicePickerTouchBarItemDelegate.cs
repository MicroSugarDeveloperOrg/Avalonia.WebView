using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSharingServicePickerTouchBarItemDelegate", false)]
[Model]
public abstract class NSSharingServicePickerTouchBarItemDelegate : NSObject, INSSharingServicePickerTouchBarItemDelegate, INativeObject, IDisposable, INSSharingServicePickerDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSSharingServicePickerTouchBarItemDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSharingServicePickerTouchBarItemDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSharingServicePickerTouchBarItemDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("sharingServicePicker:delegateForSharingService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSSharingServiceDelegate DelegateForSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingServicePicker:didChooseSharingService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChooseSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService service)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("itemsForSharingServicePickerTouchBarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract INSPasteboardWriting[] ItemsForSharingServicePickerTouchBarItem(NSSharingServicePickerTouchBarItem pickerTouchBarItem);

	[Export("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSharingService[] SharingServicesForItems(NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
