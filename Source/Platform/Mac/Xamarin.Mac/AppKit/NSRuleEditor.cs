using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRuleEditor", true)]
public class NSRuleEditor : NSControl
{
	[Register]
	internal class _NSRuleEditorDelegate : NSObject, INSRuleEditorDelegate, INativeObject, IDisposable
	{
		internal EventHandler? changed;

		internal NSRulerEditorChildCriterion? childForCriterion;

		internal NSRulerEditorDisplayValue? displayValue;

		internal EventHandler? editingBegan;

		internal EventHandler? editingEnded;

		internal NSRuleEditorNumberOfChildren? numberOfChildren;

		internal NSRulerEditorPredicateParts? predicateParts;

		internal EventHandler? rowsDidChange;

		public _NSRuleEditorDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("controlTextDidChange:")]
		public void Changed(NSNotification notification)
		{
			changed?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("ruleEditor:child:forCriterion:withRowType:")]
		public NSObject ChildForCriterion(NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType)
		{
			return childForCriterion?.Invoke(editor, index, criterion, rowType);
		}

		[Preserve(Conditional = true)]
		[Export("ruleEditor:displayValueForCriterion:inRow:")]
		public NSObject DisplayValue(NSRuleEditor editor, NSObject criterion, nint row)
		{
			return displayValue?.Invoke(editor, criterion, row);
		}

		[Preserve(Conditional = true)]
		[Export("controlTextDidBeginEditing:")]
		public void EditingBegan(NSNotification notification)
		{
			editingBegan?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("controlTextDidEndEditing:")]
		public void EditingEnded(NSNotification notification)
		{
			editingEnded?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
		public nint NumberOfChildren(NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
		{
			return numberOfChildren?.Invoke(editor, criterion, rowType) ?? ((nint)0);
		}

		[Preserve(Conditional = true)]
		[Export("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
		public NSDictionary PredicateParts(NSRuleEditor editor, NSObject criterion, NSObject value, nint row)
		{
			return predicateParts?.Invoke(editor, criterion, value, row);
		}

		[Preserve(Conditional = true)]
		[Export("ruleEditorRowsDidChange:")]
		public void RowsDidChange(NSNotification notification)
		{
			rowsDidChange?.Invoke(notification, EventArgs.Empty);
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveRowsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRow_ = "addRow:";

	private static readonly IntPtr selAddRow_Handle = Selector.GetHandle("addRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanRemoveAllRows = "canRemoveAllRows";

	private static readonly IntPtr selCanRemoveAllRowsHandle = Selector.GetHandle("canRemoveAllRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCriteriaForRow_ = "criteriaForRow:";

	private static readonly IntPtr selCriteriaForRow_Handle = Selector.GetHandle("criteriaForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCriteriaKeyPath = "criteriaKeyPath";

	private static readonly IntPtr selCriteriaKeyPathHandle = Selector.GetHandle("criteriaKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayValuesForRow_ = "displayValuesForRow:";

	private static readonly IntPtr selDisplayValuesForRow_Handle = Selector.GetHandle("displayValuesForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayValuesKeyPath = "displayValuesKeyPath";

	private static readonly IntPtr selDisplayValuesKeyPathHandle = Selector.GetHandle("displayValuesKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattingDictionary = "formattingDictionary";

	private static readonly IntPtr selFormattingDictionaryHandle = Selector.GetHandle("formattingDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattingStringsFilename = "formattingStringsFilename";

	private static readonly IntPtr selFormattingStringsFilenameHandle = Selector.GetHandle("formattingStringsFilename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRowAtIndex_WithType_AsSubrowOfRow_Animate_ = "insertRowAtIndex:withType:asSubrowOfRow:animate:";

	private static readonly IntPtr selInsertRowAtIndex_WithType_AsSubrowOfRow_Animate_Handle = Selector.GetHandle("insertRowAtIndex:withType:asSubrowOfRow:animate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNestingMode = "nestingMode";

	private static readonly IntPtr selNestingModeHandle = Selector.GetHandle("nestingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentRowForRow_ = "parentRowForRow:";

	private static readonly IntPtr selParentRowForRow_Handle = Selector.GetHandle("parentRowForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForRow_ = "predicateForRow:";

	private static readonly IntPtr selPredicateForRow_Handle = Selector.GetHandle("predicateForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadCriteria = "reloadCriteria";

	private static readonly IntPtr selReloadCriteriaHandle = Selector.GetHandle("reloadCriteria");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadPredicate = "reloadPredicate";

	private static readonly IntPtr selReloadPredicateHandle = Selector.GetHandle("reloadPredicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRowAtIndex_ = "removeRowAtIndex:";

	private static readonly IntPtr selRemoveRowAtIndex_Handle = Selector.GetHandle("removeRowAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRowsAtIndexes_IncludeSubrows_ = "removeRowsAtIndexes:includeSubrows:";

	private static readonly IntPtr selRemoveRowsAtIndexes_IncludeSubrows_Handle = Selector.GetHandle("removeRowsAtIndexes:includeSubrows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowClass = "rowClass";

	private static readonly IntPtr selRowClassHandle = Selector.GetHandle("rowClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowForDisplayValue_ = "rowForDisplayValue:";

	private static readonly IntPtr selRowForDisplayValue_Handle = Selector.GetHandle("rowForDisplayValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowHeight = "rowHeight";

	private static readonly IntPtr selRowHeightHandle = Selector.GetHandle("rowHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowTypeForRow_ = "rowTypeForRow:";

	private static readonly IntPtr selRowTypeForRow_Handle = Selector.GetHandle("rowTypeForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowTypeKeyPath = "rowTypeKeyPath";

	private static readonly IntPtr selRowTypeKeyPathHandle = Selector.GetHandle("rowTypeKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectRowIndexes_ByExtendingSelection_ = "selectRowIndexes:byExtendingSelection:";

	private static readonly IntPtr selSelectRowIndexes_ByExtendingSelection_Handle = Selector.GetHandle("selectRowIndexes:byExtendingSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRowIndexes = "selectedRowIndexes";

	private static readonly IntPtr selSelectedRowIndexesHandle = Selector.GetHandle("selectedRowIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanRemoveAllRows_ = "setCanRemoveAllRows:";

	private static readonly IntPtr selSetCanRemoveAllRows_Handle = Selector.GetHandle("setCanRemoveAllRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCriteria_AndDisplayValues_ForRowAtIndex_ = "setCriteria:andDisplayValues:forRowAtIndex:";

	private static readonly IntPtr selSetCriteria_AndDisplayValues_ForRowAtIndex_Handle = Selector.GetHandle("setCriteria:andDisplayValues:forRowAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCriteriaKeyPath_ = "setCriteriaKeyPath:";

	private static readonly IntPtr selSetCriteriaKeyPath_Handle = Selector.GetHandle("setCriteriaKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayValuesKeyPath_ = "setDisplayValuesKeyPath:";

	private static readonly IntPtr selSetDisplayValuesKeyPath_Handle = Selector.GetHandle("setDisplayValuesKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormattingDictionary_ = "setFormattingDictionary:";

	private static readonly IntPtr selSetFormattingDictionary_Handle = Selector.GetHandle("setFormattingDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormattingStringsFilename_ = "setFormattingStringsFilename:";

	private static readonly IntPtr selSetFormattingStringsFilename_Handle = Selector.GetHandle("setFormattingStringsFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNestingMode_ = "setNestingMode:";

	private static readonly IntPtr selSetNestingMode_Handle = Selector.GetHandle("setNestingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowClass_ = "setRowClass:";

	private static readonly IntPtr selSetRowClass_Handle = Selector.GetHandle("setRowClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowHeight_ = "setRowHeight:";

	private static readonly IntPtr selSetRowHeight_Handle = Selector.GetHandle("setRowHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowTypeKeyPath_ = "setRowTypeKeyPath:";

	private static readonly IntPtr selSetRowTypeKeyPath_Handle = Selector.GetHandle("setRowTypeKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubrowsKeyPath_ = "setSubrowsKeyPath:";

	private static readonly IntPtr selSetSubrowsKeyPath_Handle = Selector.GetHandle("setSubrowsKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubrowIndexesForRow_ = "subrowIndexesForRow:";

	private static readonly IntPtr selSubrowIndexesForRow_Handle = Selector.GetHandle("subrowIndexesForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubrowsKeyPath = "subrowsKeyPath";

	private static readonly IntPtr selSubrowsKeyPathHandle = Selector.GetHandle("subrowsKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRuleEditor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowsDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanRemoveAllRows
	{
		[Export("canRemoveAllRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRemoveAllRowsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRemoveAllRowsHandle);
		}
		[Export("setCanRemoveAllRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanRemoveAllRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanRemoveAllRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CriteriaKeyPath
	{
		[Export("criteriaKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSRuleEditorDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSRuleEditorDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayValuesKeyPath
	{
		[Export("displayValuesKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FormattingDictionary
	{
		[Export("formattingDictionary", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormattingDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormattingDictionaryHandle));
		}
		[Export("setFormattingDictionary:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFormattingDictionary_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFormattingDictionary_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FormattingStringsFilename
	{
		[Export("formattingStringsFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRuleEditorNestingMode NestingMode
	{
		[Export("nestingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSRuleEditorNestingMode)Messaging.UInt64_objc_msgSend(base.Handle, selNestingModeHandle);
			}
			return (NSRuleEditorNestingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNestingModeHandle);
		}
		[Export("setNestingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetNestingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetNestingMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfRows
	{
		[Export("numberOfRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate Predicate
	{
		[Export("predicate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class RowClass
	{
		[Export("rowClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRowClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRowClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Export("setRowClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRowClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRowClass_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RowHeight
	{
		[Export("rowHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRowHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRowHeightHandle);
		}
		[Export("setRowHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRowHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRowHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RowTypeKeyPath
	{
		[Export("rowTypeKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectedRows
	{
		[Export("selectedRowIndexes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedRowIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedRowIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SubrowsKeyPath
	{
		[Export("subrowsKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSRuleEditorRowsDidChangeNotification", "AppKit")]
	[Advice("Use NSRuleEditor.Notifications.ObserveRowsDidChange helper method instead.")]
	public static NSString RowsDidChangeNotification
	{
		get
		{
			if (_RowsDidChangeNotification == null)
			{
				_RowsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRuleEditorRowsDidChangeNotification");
			}
			return _RowsDidChangeNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSRuleEditorDelegate);

	public NSRulerEditorChildCriterion? ChildForCriterion
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

	public NSRulerEditorDisplayValue? DisplayValue
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

	public NSRuleEditorNumberOfChildren? NumberOfChildren
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

	public NSRulerEditorPredicateParts? PredicateParts
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRuleEditor()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSRuleEditor(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSRuleEditor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRuleEditor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRuleEditor(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("addRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRow(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRow_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRow_Handle, sender.Handle);
		}
	}

	[Export("criteriaForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray Criteria(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selCriteriaForRow_Handle, row));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selCriteriaForRow_Handle, row));
	}

	[Export("displayValuesForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] DisplayValues(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selDisplayValuesForRow_Handle, row));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selDisplayValuesForRow_Handle, row));
	}

	[Export("predicateForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate GetPredicate(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selPredicateForRow_Handle, row));
		}
		return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selPredicateForRow_Handle, row));
	}

	[Export("insertRowAtIndex:withType:asSubrowOfRow:animate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertRowAtIndex(nint rowIndex, NSRuleEditorRowType rowType, nint parentRow, bool shouldAnimate)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_UInt64_nint_bool(base.Handle, selInsertRowAtIndex_WithType_AsSubrowOfRow_Animate_Handle, rowIndex, (ulong)rowType, parentRow, shouldAnimate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_UInt64_nint_bool(base.SuperHandle, selInsertRowAtIndex_WithType_AsSubrowOfRow_Animate_Handle, rowIndex, (ulong)rowType, parentRow, shouldAnimate);
		}
	}

	[Export("parentRowForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ParentRow(nint rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selParentRowForRow_Handle, rowIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selParentRowForRow_Handle, rowIndex);
	}

	[Export("reloadCriteria")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadCriteria()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadCriteriaHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadCriteriaHandle);
		}
	}

	[Export("reloadPredicate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadPredicate()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadPredicateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadPredicateHandle);
		}
	}

	[Export("removeRowAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRowAtIndex(nint rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveRowAtIndex_Handle, rowIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveRowAtIndex_Handle, rowIndex);
		}
	}

	[Export("removeRowsAtIndexes:includeSubrows:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRowsAtIndexes(NSIndexSet rowIndexes, bool includeSubrows)
	{
		NSApplication.EnsureUIThread();
		if (rowIndexes == null)
		{
			throw new ArgumentNullException("rowIndexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selRemoveRowsAtIndexes_IncludeSubrows_Handle, rowIndexes.Handle, includeSubrows);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selRemoveRowsAtIndexes_IncludeSubrows_Handle, rowIndexes.Handle, includeSubrows);
		}
	}

	[Export("rowForDisplayValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Row(NSObject displayValue)
	{
		NSApplication.EnsureUIThread();
		if (displayValue == null)
		{
			throw new ArgumentNullException("displayValue");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selRowForDisplayValue_Handle, displayValue.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForDisplayValue_Handle, displayValue.Handle);
	}

	[Export("rowTypeForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRuleEditorRowType RowType(nint rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSRuleEditorRowType)Messaging.UInt64_objc_msgSend_nint(base.Handle, selRowTypeForRow_Handle, rowIndex);
		}
		return (NSRuleEditorRowType)Messaging.UInt64_objc_msgSendSuper_nint(base.SuperHandle, selRowTypeForRow_Handle, rowIndex);
	}

	[Export("selectRowIndexes:byExtendingSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectRows(NSIndexSet indexes, bool extend)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectRowIndexes_ByExtendingSelection_Handle, indexes.Handle, extend);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectRowIndexes_ByExtendingSelection_Handle, indexes.Handle, extend);
		}
	}

	[Export("setCriteria:andDisplayValues:forRowAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCriteria(NSArray criteria, NSArray values, nint rowIndex)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nint(base.Handle, selSetCriteria_AndDisplayValues_ForRowAtIndex_Handle, criteria.Handle, values.Handle, rowIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nint(base.SuperHandle, selSetCriteria_AndDisplayValues_ForRowAtIndex_Handle, criteria.Handle, values.Handle, rowIndex);
		}
	}

	[Export("subrowIndexesForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SubrowIndexes(nint rowIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selSubrowIndexesForRow_Handle, rowIndex));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selSubrowIndexesForRow_Handle, rowIndex));
	}

	internal virtual _NSRuleEditorDelegate CreateInternalEventDelegateType()
	{
		return new _NSRuleEditorDelegate();
	}

	internal _NSRuleEditorDelegate EnsureNSRuleEditorDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSRuleEditorDelegate nSRuleEditorDelegate = Delegate as _NSRuleEditorDelegate;
		if (nSRuleEditorDelegate == null)
		{
			nSRuleEditorDelegate = (_NSRuleEditorDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSRuleEditorDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
