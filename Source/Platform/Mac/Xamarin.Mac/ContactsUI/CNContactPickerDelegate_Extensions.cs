using System;
using Contacts;
using ObjCRuntime;

namespace ContactsUI;

public static class CNContactPickerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ContactSelected(this ICNContactPickerDelegate This, CNContactPicker picker, CNContact contact)
	{
		if (picker == null)
		{
			throw new ArgumentNullException("picker");
		}
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contactPicker:didSelectContact:"), picker.Handle, contact.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ContactPropertySelected(this ICNContactPickerDelegate This, CNContactPicker picker, CNContactProperty contactProperty)
	{
		if (picker == null)
		{
			throw new ArgumentNullException("picker");
		}
		if (contactProperty == null)
		{
			throw new ArgumentNullException("contactProperty");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contactPicker:didSelectContactProperty:"), picker.Handle, contactProperty.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillClose(this ICNContactPickerDelegate This, CNContactPicker picker)
	{
		if (picker == null)
		{
			throw new ArgumentNullException("picker");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("contactPickerWillClose:"), picker.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidClose(this ICNContactPickerDelegate This, CNContactPicker picker)
	{
		if (picker == null)
		{
			throw new ArgumentNullException("picker");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("contactPickerDidClose:"), picker.Handle);
	}
}
