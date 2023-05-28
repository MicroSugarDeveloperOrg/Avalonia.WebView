using System;
using ObjCRuntime;

namespace NotificationCenter;

public static class NCWidgetListViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformAddAction(this INCWidgetListViewDelegate This, NCWidgetListViewController list)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("widgetListPerformAddAction:"), list.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReorderRow(this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("widgetList:shouldReorderRow:"), list.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReorderRow(this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row, nuint newIndex)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint(This.Handle, Selector.GetHandle("widgetList:didReorderRow:toRow:"), list.Handle, row, newIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldRemoveRow(this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("widgetList:shouldRemoveRow:"), list.Handle, row);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRemoveRow(this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("widgetList:didRemoveRow:"), list.Handle, row);
	}
}
