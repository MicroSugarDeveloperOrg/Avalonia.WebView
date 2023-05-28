using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSRuleEditorDelegate", false)]
[Model]
public abstract class NSRuleEditorDelegate : NSObject, INSRuleEditorDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSRuleEditorDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSRuleEditorDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRuleEditorDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("controlTextDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Changed(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("ruleEditor:child:forCriterion:withRowType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSObject ChildForCriterion(NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType);

	[Export("ruleEditor:displayValueForCriterion:inRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSObject DisplayValue(NSRuleEditor editor, NSObject criterion, nint row);

	[Export("controlTextDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditingBegan(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditingEnded(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nint NumberOfChildren(NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType);

	[Export("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSDictionary PredicateParts(NSRuleEditor editor, NSObject criterion, NSObject value, nint row);

	[Export("ruleEditorRowsDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void RowsDidChange(NSNotification notification);
}
