using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRuleEditor", true)]
public class NSRuleEditor : NSControl
{
	[Register]
	private sealed class _NSRuleEditorDelegate : NSRuleEditorDelegate
	{
		internal NSRuleEditorNumberOfChildren numberOfChildren;

		internal NSRulerEditorChildCriterion childForCriterion;

		internal NSRulerEditorDisplayValue displayValue;

		internal NSRulerEditorPredicateParts predicateParts;

		internal EventHandler rowsDidChange;

		internal EventHandler editingEnded;

		internal EventHandler changed;

		internal EventHandler editingBegan;

		[Preserve(Conditional = true)]
		public override long NumberOfChildren(NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
		{
			return numberOfChildren?.Invoke(editor, criterion, rowType) ?? 0;
		}

		[Preserve(Conditional = true)]
		public override NSObject ChildForCriterion(NSRuleEditor editor, long index, NSObject criterion, NSRuleEditorRowType rowType)
		{
			return childForCriterion?.Invoke(editor, index, criterion, rowType);
		}

		[Preserve(Conditional = true)]
		public override NSObject DisplayValue(NSRuleEditor editor, NSObject criterion, long row)
		{
			return displayValue?.Invoke(editor, criterion, row);
		}

		[Preserve(Conditional = true)]
		public override NSDictionary PredicateParts(NSRuleEditor editor, NSObject criterion, NSObject value, long row)
		{
			return predicateParts?.Invoke(editor, criterion, value, row);
		}

		[Preserve(Conditional = true)]
		public override void RowsDidChange(NSNotification notification)
		{
			rowsDidChange?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void EditingEnded(NSNotification notification)
		{
			editingEnded?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void Changed(NSNotification notification)
		{
			changed?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void EditingBegan(NSNotification notification)
		{
			editingBegan?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	private static readonly IntPtr selSelectedRowIndexesHandle = Selector.GetHandle("selectedRowIndexes");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selFormattingStringsFilenameHandle = Selector.GetHandle("formattingStringsFilename");

	private static readonly IntPtr selSetFormattingStringsFilename_Handle = Selector.GetHandle("setFormattingStringsFilename:");

	private static readonly IntPtr selFormattingDictionaryHandle = Selector.GetHandle("formattingDictionary");

	private static readonly IntPtr selSetFormattingDictionary_Handle = Selector.GetHandle("setFormattingDictionary:");

	private static readonly IntPtr selNestingModeHandle = Selector.GetHandle("nestingMode");

	private static readonly IntPtr selSetNestingMode_Handle = Selector.GetHandle("setNestingMode:");

	private static readonly IntPtr selRowHeightHandle = Selector.GetHandle("rowHeight");

	private static readonly IntPtr selSetRowHeight_Handle = Selector.GetHandle("setRowHeight:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selCanRemoveAllRowsHandle = Selector.GetHandle("canRemoveAllRows");

	private static readonly IntPtr selSetCanRemoveAllRows_Handle = Selector.GetHandle("setCanRemoveAllRows:");

	private static readonly IntPtr selRowClassHandle = Selector.GetHandle("rowClass");

	private static readonly IntPtr selSetRowClass_Handle = Selector.GetHandle("setRowClass:");

	private static readonly IntPtr selRowTypeKeyPathHandle = Selector.GetHandle("rowTypeKeyPath");

	private static readonly IntPtr selSetRowTypeKeyPath_Handle = Selector.GetHandle("setRowTypeKeyPath:");

	private static readonly IntPtr selSubrowsKeyPathHandle = Selector.GetHandle("subrowsKeyPath");

	private static readonly IntPtr selSetSubrowsKeyPath_Handle = Selector.GetHandle("setSubrowsKeyPath:");

	private static readonly IntPtr selCriteriaKeyPathHandle = Selector.GetHandle("criteriaKeyPath");

	private static readonly IntPtr selSetCriteriaKeyPath_Handle = Selector.GetHandle("setCriteriaKeyPath:");

	private static readonly IntPtr selDisplayValuesKeyPathHandle = Selector.GetHandle("displayValuesKeyPath");

	private static readonly IntPtr selSetDisplayValuesKeyPath_Handle = Selector.GetHandle("setDisplayValuesKeyPath:");

	private static readonly IntPtr selReloadCriteriaHandle = Selector.GetHandle("reloadCriteria");

	private static readonly IntPtr selReloadPredicateHandle = Selector.GetHandle("reloadPredicate");

	private static readonly IntPtr selPredicateForRow_Handle = Selector.GetHandle("predicateForRow:");

	private static readonly IntPtr selSubrowIndexesForRow_Handle = Selector.GetHandle("subrowIndexesForRow:");

	private static readonly IntPtr selCriteriaForRow_Handle = Selector.GetHandle("criteriaForRow:");

	private static readonly IntPtr selDisplayValuesForRow_Handle = Selector.GetHandle("displayValuesForRow:");

	private static readonly IntPtr selRowForDisplayValue_Handle = Selector.GetHandle("rowForDisplayValue:");

	private static readonly IntPtr selRowTypeForRow_Handle = Selector.GetHandle("rowTypeForRow:");

	private static readonly IntPtr selParentRowForRow_Handle = Selector.GetHandle("parentRowForRow:");

	private static readonly IntPtr selAddRow_Handle = Selector.GetHandle("addRow:");

	private static readonly IntPtr selInsertRowAtIndexWithTypeAsSubrowOfRowAnimate_Handle = Selector.GetHandle("insertRowAtIndex:withType:asSubrowOfRow:animate:");

	private static readonly IntPtr selSetCriteriaAndDisplayValuesForRowAtIndex_Handle = Selector.GetHandle("setCriteria:andDisplayValues:forRowAtIndex:");

	private static readonly IntPtr selRemoveRowAtIndex_Handle = Selector.GetHandle("removeRowAtIndex:");

	private static readonly IntPtr selRemoveRowsAtIndexesIncludeSubrows_Handle = Selector.GetHandle("removeRowsAtIndexes:includeSubrows:");

	private static readonly IntPtr selSelectRowIndexesByExtendingSelection_Handle = Selector.GetHandle("selectRowIndexes:byExtendingSelection:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSRuleEditor");

	private object __mt_Predicate_var;

	private object __mt_SelectedRows_var;

	private object __mt_WeakDelegate_var;

	private object __mt_FormattingDictionary_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPredicate Predicate
	{
		[Export("predicate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPredicate)(__mt_Predicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle)))));
		}
	}

	public virtual long NumberOfRows
	{
		[Export("numberOfRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	public virtual NSIndexSet SelectedRows
	{
		[Export("selectedRowIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexSet)(__mt_SelectedRows_var = ((!IsDirectBinding) ? ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedRowIndexesHandle))) : ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedRowIndexesHandle)))));
		}
	}

	public virtual NSRuleEditorDelegate WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRuleEditorDelegate)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? ((NSRuleEditorDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle))) : ((NSRuleEditorDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSRuleEditorDelegate Delegate
	{
		get
		{
			return WeakDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual string FormattingStringsFilename
	{
		[Export("formattingStringsFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFormattingStringsFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormattingStringsFilenameHandle));
		}
		[Export("setFormattingStringsFilename:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFormattingStringsFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFormattingStringsFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary FormattingDictionary
	{
		[Export("formattingDictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_FormattingDictionary_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormattingDictionaryHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormattingDictionaryHandle)))));
		}
		[Export("setFormattingDictionary:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFormattingDictionary_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFormattingDictionary_Handle, value.Handle);
			}
			__mt_FormattingDictionary_var = value;
		}
	}

	public virtual NSRuleEditorNestingMode NestingMode
	{
		[Export("nestingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSRuleEditorNestingMode)Messaging.UInt64_objc_msgSend(base.Handle, selNestingModeHandle);
			}
			return (NSRuleEditorNestingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNestingModeHandle);
		}
		[Export("setNestingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetNestingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetNestingMode_Handle, (ulong)value);
			}
		}
	}

	public virtual double RowHeight
	{
		[Export("rowHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRowHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRowHeightHandle);
		}
		[Export("setRowHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRowHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRowHeight_Handle, value);
			}
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual bool CanRemoveAllRows
	{
		[Export("canRemoveAllRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRemoveAllRowsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRemoveAllRowsHandle);
		}
		[Export("setCanRemoveAllRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanRemoveAllRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanRemoveAllRows_Handle, value);
			}
		}
	}

	public virtual Class RowClass
	{
		[Export("rowClass")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selRowClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRowClassHandle));
		}
		[Export("setRowClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRowClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRowClass_Handle, value.Handle);
			}
		}
	}

	public virtual string RowTypeKeyPath
	{
		[Export("rowTypeKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRowTypeKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRowTypeKeyPathHandle));
		}
		[Export("setRowTypeKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRowTypeKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRowTypeKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string SubrowsKeyPath
	{
		[Export("subrowsKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubrowsKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubrowsKeyPathHandle));
		}
		[Export("setSubrowsKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubrowsKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubrowsKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string CriteriaKeyPath
	{
		[Export("criteriaKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCriteriaKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCriteriaKeyPathHandle));
		}
		[Export("setCriteriaKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCriteriaKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCriteriaKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string DisplayValuesKeyPath
	{
		[Export("displayValuesKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayValuesKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayValuesKeyPathHandle));
		}
		[Export("setDisplayValuesKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDisplayValuesKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDisplayValuesKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public NSRuleEditorNumberOfChildren NumberOfChildren
	{
		get
		{
			return EnsureNSRuleEditorDelegate().numberOfChildren;
		}
		set
		{
			EnsureNSRuleEditorDelegate().numberOfChildren = value;
		}
	}

	public NSRulerEditorChildCriterion ChildForCriterion
	{
		get
		{
			return EnsureNSRuleEditorDelegate().childForCriterion;
		}
		set
		{
			EnsureNSRuleEditorDelegate().childForCriterion = value;
		}
	}

	public NSRulerEditorDisplayValue DisplayValue
	{
		get
		{
			return EnsureNSRuleEditorDelegate().displayValue;
		}
		set
		{
			EnsureNSRuleEditorDelegate().displayValue = value;
		}
	}

	public NSRulerEditorPredicateParts PredicateParts
	{
		get
		{
			return EnsureNSRuleEditorDelegate().predicateParts;
		}
		set
		{
			EnsureNSRuleEditorDelegate().predicateParts = value;
		}
	}

	public event EventHandler RowsDidChange
	{
		add
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.rowsDidChange = (EventHandler)System.Delegate.Combine(nSRuleEditorDelegate.rowsDidChange, value);
		}
		remove
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.rowsDidChange = (EventHandler)System.Delegate.Remove(nSRuleEditorDelegate.rowsDidChange, value);
		}
	}

	public event EventHandler EditingEnded
	{
		add
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.editingEnded = (EventHandler)System.Delegate.Combine(nSRuleEditorDelegate.editingEnded, value);
		}
		remove
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.editingEnded = (EventHandler)System.Delegate.Remove(nSRuleEditorDelegate.editingEnded, value);
		}
	}

	public event EventHandler Changed
	{
		add
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.changed = (EventHandler)System.Delegate.Combine(nSRuleEditorDelegate.changed, value);
		}
		remove
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.changed = (EventHandler)System.Delegate.Remove(nSRuleEditorDelegate.changed, value);
		}
	}

	public event EventHandler EditingBegan
	{
		add
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.editingBegan = (EventHandler)System.Delegate.Combine(nSRuleEditorDelegate.editingBegan, value);
		}
		remove
		{
			_NSRuleEditorDelegate nSRuleEditorDelegate = EnsureNSRuleEditorDelegate();
			nSRuleEditorDelegate.editingBegan = (EventHandler)System.Delegate.Remove(nSRuleEditorDelegate.editingBegan, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRuleEditor()
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
	public NSRuleEditor(NSCoder coder)
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
	public NSRuleEditor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRuleEditor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("reloadCriteria")]
	public virtual void ReloadCriteria()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadCriteriaHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadCriteriaHandle);
		}
	}

	[Export("reloadPredicate")]
	public virtual void ReloadPredicate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadPredicateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadPredicateHandle);
		}
	}

	[Export("predicateForRow:")]
	public virtual NSPredicate GetPredicate(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selPredicateForRow_Handle, row));
		}
		return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selPredicateForRow_Handle, row));
	}

	[Export("subrowIndexesForRow:")]
	public virtual NSIndexSet SubrowIndexes(long rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selSubrowIndexesForRow_Handle, rowIndex));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selSubrowIndexesForRow_Handle, rowIndex));
	}

	[Export("criteriaForRow:")]
	public virtual NSArray Criteria(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selCriteriaForRow_Handle, row));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selCriteriaForRow_Handle, row));
	}

	[Export("displayValuesForRow:")]
	public virtual NSObject[] DisplayValues(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selDisplayValuesForRow_Handle, row));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selDisplayValuesForRow_Handle, row));
	}

	[Export("rowForDisplayValue:")]
	public virtual long Row(NSObject displayValue)
	{
		NSApplication.EnsureUIThread();
		if (displayValue == null)
		{
			throw new ArgumentNullException("displayValue");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selRowForDisplayValue_Handle, displayValue.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForDisplayValue_Handle, displayValue.Handle);
	}

	[Export("rowTypeForRow:")]
	public virtual NSRuleEditorRowType RowType(long rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSRuleEditorRowType)Messaging.UInt64_objc_msgSend_Int64(base.Handle, selRowTypeForRow_Handle, rowIndex);
		}
		return (NSRuleEditorRowType)Messaging.UInt64_objc_msgSendSuper_Int64(base.SuperHandle, selRowTypeForRow_Handle, rowIndex);
	}

	[Export("parentRowForRow:")]
	public virtual long ParentRow(long rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selParentRowForRow_Handle, rowIndex);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selParentRowForRow_Handle, rowIndex);
	}

	[Export("addRow:")]
	public virtual void AddRow(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRow_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRow_Handle, sender.Handle);
		}
	}

	[Export("insertRowAtIndex:withType:asSubrowOfRow:animate:")]
	public virtual void InsertRowAtIndex(long rowIndex, NSRuleEditorRowType rowType, long parentRow, bool shouldAnimate)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_UInt64_Int64_bool(base.Handle, selInsertRowAtIndexWithTypeAsSubrowOfRowAnimate_Handle, rowIndex, (ulong)rowType, parentRow, shouldAnimate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_UInt64_Int64_bool(base.SuperHandle, selInsertRowAtIndexWithTypeAsSubrowOfRowAnimate_Handle, rowIndex, (ulong)rowType, parentRow, shouldAnimate);
		}
	}

	[Export("setCriteria:andDisplayValues:forRowAtIndex:")]
	public virtual void SetCriteria(NSArray criteria, NSArray values, long rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (criteria == null)
		{
			throw new ArgumentNullException("criteria");
		}
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, selSetCriteriaAndDisplayValuesForRowAtIndex_Handle, criteria.Handle, values.Handle, rowIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64(base.SuperHandle, selSetCriteriaAndDisplayValuesForRowAtIndex_Handle, criteria.Handle, values.Handle, rowIndex);
		}
	}

	[Export("removeRowAtIndex:")]
	public virtual void RemoveRowAtIndex(long rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveRowAtIndex_Handle, rowIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveRowAtIndex_Handle, rowIndex);
		}
	}

	[Export("removeRowsAtIndexes:includeSubrows:")]
	public virtual void RemoveRowsAtIndexes(NSIndexSet rowIndexes, bool includeSubrows)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selRemoveRowsAtIndexesIncludeSubrows_Handle, rowIndexes.Handle, includeSubrows);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selRemoveRowsAtIndexesIncludeSubrows_Handle, rowIndexes.Handle, includeSubrows);
		}
	}

	[Export("selectRowIndexes:byExtendingSelection:")]
	public virtual void SelectRows(NSIndexSet indexes, bool extend)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectRowIndexesByExtendingSelection_Handle, indexes.Handle, extend);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectRowIndexesByExtendingSelection_Handle, indexes.Handle, extend);
		}
	}

	private _NSRuleEditorDelegate EnsureNSRuleEditorDelegate()
	{
		NSRuleEditorDelegate nSRuleEditorDelegate = Delegate;
		if (nSRuleEditorDelegate == null || !(nSRuleEditorDelegate is _NSRuleEditorDelegate))
		{
			nSRuleEditorDelegate = (Delegate = new _NSRuleEditorDelegate());
		}
		return (_NSRuleEditorDelegate)nSRuleEditorDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Predicate_var = null;
			__mt_SelectedRows_var = null;
			__mt_WeakDelegate_var = null;
			__mt_FormattingDictionary_var = null;
		}
	}
}
