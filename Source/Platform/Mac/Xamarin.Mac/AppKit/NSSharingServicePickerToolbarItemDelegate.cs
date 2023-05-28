using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("Xamarin_Mac__AppKit_NSSharingServicePickerToolbarItemDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public abstract class NSSharingServicePickerToolbarItemDelegate : NSSharingServicePickerDelegate, INSSharingServicePickerToolbarItemDelegate, INativeObject, IDisposable, INSSharingServicePickerDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSSharingServicePickerToolbarItemDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSharingServicePickerToolbarItemDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSharingServicePickerToolbarItemDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("itemsForSharingServicePickerToolbarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSObject[] GetItems(NSSharingServicePickerToolbarItem pickerToolbarItem);
}
