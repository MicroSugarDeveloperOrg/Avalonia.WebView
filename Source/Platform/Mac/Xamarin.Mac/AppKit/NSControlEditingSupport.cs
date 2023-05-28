using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSControlEditingSupport
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateProposedFirstResponder_ForEvent_ = "validateProposedFirstResponder:forEvent:";

	private static readonly IntPtr selValidateProposedFirstResponder_ForEvent_Handle = Selector.GetHandle("validateProposedFirstResponder:forEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSResponder");

	[Export("validateProposedFirstResponder:forEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ValidateProposedFirstResponder(this NSResponder This, NSResponder responder, NSEvent? forEvent)
	{
		NSApplication.EnsureUIThread();
		if (responder == null)
		{
			throw new ArgumentNullException("responder");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, selValidateProposedFirstResponder_ForEvent_Handle, responder.Handle, forEvent?.Handle ?? IntPtr.Zero);
	}
}
