using System;
using ObjCRuntime;

namespace Contacts;

public static class CNChangeHistoryEventVisitor_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryAddGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitAddGroupEvent:"), @event.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdateGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryUpdateGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitUpdateGroupEvent:"), @event.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryDeleteGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitDeleteGroupEvent:"), @event.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddMemberToGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryAddMemberToGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitAddMemberToGroupEvent:"), @event.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveMemberFromGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryRemoveMemberFromGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitRemoveMemberFromGroupEvent:"), @event.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddSubgroupToGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryAddSubgroupToGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitAddSubgroupToGroupEvent:"), @event.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveSubgroupFromGroup(this ICNChangeHistoryEventVisitor This, CNChangeHistoryRemoveSubgroupFromGroupEvent @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("visitRemoveSubgroupFromGroupEvent:"), @event.Handle);
	}
}
