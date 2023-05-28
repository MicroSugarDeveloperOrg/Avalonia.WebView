using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSEditorWrapper : BaseWrapper, INSEditor, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSEditorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("discardEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DiscardEditing()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("discardEditing"));
	}

	[Export("commitEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CommitEditing()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("commitEditing"));
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CommitEditing(NSObject? delegateObject, Selector? didCommitSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:"), delegateObject?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
	}

	[Export("commitEditingAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CommitEditing(out NSError? error)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, Selector.GetHandle("commitEditingAndReturnError:"), ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
