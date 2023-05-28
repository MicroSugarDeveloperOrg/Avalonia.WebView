using System;
using Foundation;
using ObjCRuntime;

namespace Contacts;

internal sealed class CNChangeHistoryEventVisitorWrapper : BaseWrapper, ICNChangeHistoryEventVisitor, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CNChangeHistoryEventVisitorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("visitDropEverythingEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DropEverything(CNChangeHistoryDropEverythingEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("visitDropEverythingEvent:"), @event.Handle);
	}

	[Export("visitAddContactEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddContact(CNChangeHistoryAddContactEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("visitAddContactEvent:"), @event.Handle);
	}

	[Export("visitUpdateContactEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void UpdateContact(CNChangeHistoryUpdateContactEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("visitUpdateContactEvent:"), @event.Handle);
	}

	[Export("visitDeleteContactEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DeleteContact(CNChangeHistoryDeleteContactEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("visitDeleteContactEvent:"), @event.Handle);
	}
}
