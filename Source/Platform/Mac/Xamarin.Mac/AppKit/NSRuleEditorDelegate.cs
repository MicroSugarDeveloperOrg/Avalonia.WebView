using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRuleEditorDelegate", true)]
[Model]
public abstract class NSRuleEditorDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRuleEditorDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSRuleEditorDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRuleEditorDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRuleEditorDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
	public abstract long NumberOfChildren(NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType);

	[Export("ruleEditor:child:forCriterion:withRowType:")]
	public abstract NSObject ChildForCriterion(NSRuleEditor editor, long index, NSObject criterion, NSRuleEditorRowType rowType);

	[Export("ruleEditor:displayValueForCriterion:inRow:")]
	public abstract NSObject DisplayValue(NSRuleEditor editor, NSObject criterion, long row);

	[Export("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
	public abstract NSDictionary PredicateParts(NSRuleEditor editor, NSObject criterion, NSObject value, long row);

	[Export("ruleEditorRowsDidChange:")]
	public abstract void RowsDidChange(NSNotification notification);

	[Export("controlTextDidEndEditing:")]
	public virtual void EditingEnded(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidChange:")]
	public virtual void Changed(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidBeginEditing:")]
	public virtual void EditingBegan(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
