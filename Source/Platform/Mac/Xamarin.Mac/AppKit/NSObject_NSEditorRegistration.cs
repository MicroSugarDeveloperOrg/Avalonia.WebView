using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public static class NSObject_NSEditorRegistration
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidBeginEditing_ = "objectDidBeginEditing:";

	private static readonly IntPtr selObjectDidBeginEditing_Handle = Selector.GetHandle("objectDidBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidEndEditing_ = "objectDidEndEditing:";

	private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSObject");

	[Export("objectDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ObjectDidBeginEditing(this NSObject This, INSEditor editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selObjectDidBeginEditing_Handle, editor.Handle);
	}

	[Export("objectDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ObjectDidEndEditing(this NSObject This, INSEditor editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selObjectDidEndEditing_Handle, editor.Handle);
	}
}
