using System;
using System.ComponentModel;
using Contacts;
using Foundation;
using ObjCRuntime;

namespace ContactsUI;

[Protocol]
[Register("CNContactPickerDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactPickerDelegate : NSObject, ICNContactPickerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContactPickerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CNContactPickerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactPickerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("contactPicker:didSelectContactProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContactPropertySelected(CNContactPicker picker, CNContactProperty contactProperty)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contactPicker:didSelectContact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContactSelected(CNContactPicker picker, CNContact contact)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contactPickerDidClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidClose(CNContactPicker picker)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("contactPickerWillClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillClose(CNContactPicker picker)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
