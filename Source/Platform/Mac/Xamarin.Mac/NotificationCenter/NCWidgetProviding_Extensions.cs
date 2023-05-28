using System;
using AppKit;
using ObjCRuntime;

namespace NotificationCenter;

public static class NCWidgetProviding_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void WidgetPerformUpdate(this INCWidgetProviding This, [BlockProxy(typeof(Trampolines.NIDActionArity1V69))] Action<NCUpdateResult> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V69.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("widgetPerformUpdateWithCompletionHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEdgeInsets GetWidgetMarginInsets(this INCWidgetProviding This, NSEdgeInsets defaultMarginInsets)
	{
		Messaging.NSEdgeInsets_objc_msgSend_stret_NSEdgeInsets(out var retval, This.Handle, Selector.GetHandle("widgetMarginInsetsForProposedMarginInsets:"), defaultMarginInsets);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WidgetDidBeginEditing(this INCWidgetProviding This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("widgetDidBeginEditing"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WidgetDidEndEditing(this INCWidgetProviding This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("widgetDidEndEditing"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetWidgetAllowsEditing(this INCWidgetProviding This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("widgetAllowsEditing"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetWidgetAllowsEditing(this INCWidgetProviding This, bool value)
	{
		Messaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setWidgetAllowsEditing:"), value);
	}
}
