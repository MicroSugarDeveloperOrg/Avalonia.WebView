using System;
using ObjCRuntime;

namespace AppKit;

public static class NSEditorRegistration_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ObjectDidBeginEditing(this INSEditorRegistration This, INSEditor editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("objectDidBeginEditing:"), editor.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ObjectDidEndEditing(this INSEditorRegistration This, INSEditor editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("objectDidEndEditing:"), editor.Handle);
	}
}
