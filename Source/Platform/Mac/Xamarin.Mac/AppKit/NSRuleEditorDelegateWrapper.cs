using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSRuleEditorDelegateWrapper : BaseWrapper, INSRuleEditorDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSRuleEditorDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint NumberOfChildren(NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (criterion == null)
		{
			throw new ArgumentNullException("criterion");
		}
		return Messaging.nint_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, Selector.GetHandle("ruleEditor:numberOfChildrenForCriterion:withRowType:"), editor.Handle, criterion.Handle, (ulong)rowType);
	}

	[Export("ruleEditor:child:forCriterion:withRowType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject ChildForCriterion(NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (criterion == null)
		{
			throw new ArgumentNullException("criterion");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr_UInt64(base.Handle, Selector.GetHandle("ruleEditor:child:forCriterion:withRowType:"), editor.Handle, index, criterion.Handle, (ulong)rowType));
	}

	[Export("ruleEditor:displayValueForCriterion:inRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject DisplayValue(NSRuleEditor editor, NSObject criterion, nint row)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (criterion == null)
		{
			throw new ArgumentNullException("criterion");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(base.Handle, Selector.GetHandle("ruleEditor:displayValueForCriterion:inRow:"), editor.Handle, criterion.Handle, row));
	}

	[Export("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary PredicateParts(NSRuleEditor editor, NSObject criterion, NSObject value, nint row)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (criterion == null)
		{
			throw new ArgumentNullException("criterion");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(base.Handle, Selector.GetHandle("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:"), editor.Handle, criterion.Handle, value.Handle, row));
	}

	[Export("ruleEditorRowsDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RowsDidChange(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("ruleEditorRowsDidChange:"), notification.Handle);
	}
}
