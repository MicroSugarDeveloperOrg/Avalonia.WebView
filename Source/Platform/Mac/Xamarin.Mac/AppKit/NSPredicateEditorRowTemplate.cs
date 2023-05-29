using System;
using System.ComponentModel;
using CoreData;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPredicateEditorRowTemplate", true)]
public class NSPredicateEditorRowTemplate : NSObject
{
	private static readonly IntPtr selTemplateViewsHandle = Selector.GetHandle("templateViews");

	private static readonly IntPtr selLeftExpressionsHandle = Selector.GetHandle("leftExpressions");

	private static readonly IntPtr selRightExpressionsHandle = Selector.GetHandle("rightExpressions");

	private static readonly IntPtr selRightExpressionAttributeTypeHandle = Selector.GetHandle("rightExpressionAttributeType");

	private static readonly IntPtr selModifierHandle = Selector.GetHandle("modifier");

	private static readonly IntPtr selOperatorsHandle = Selector.GetHandle("operators");

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	private static readonly IntPtr selCompoundTypesHandle = Selector.GetHandle("compoundTypes");

	private static readonly IntPtr selMatchForPredicate_Handle = Selector.GetHandle("matchForPredicate:");

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	private static readonly IntPtr selPredicateWithSubpredicates_Handle = Selector.GetHandle("predicateWithSubpredicates:");

	private static readonly IntPtr selDisplayableSubpredicatesOfPredicate_Handle = Selector.GetHandle("displayableSubpredicatesOfPredicate:");

	private static readonly IntPtr selInitWithLeftExpressionsRightExpressionsModifierOperatorsOptions_Handle = Selector.GetHandle("initWithLeftExpressions:rightExpressions:modifier:operators:options:");

	private static readonly IntPtr selInitWithLeftExpressionsRightExpressionAttributeTypeModifierOperatorsOptions_Handle = Selector.GetHandle("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");

	private static readonly IntPtr selInitWithCompoundTypes_Handle = Selector.GetHandle("initWithCompoundTypes:");

	private static readonly IntPtr selTemplatesWithAttributeKeyPathsInEntityDescription_Handle = Selector.GetHandle("templatesWithAttributeKeyPaths:inEntityDescription:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPredicateEditorRowTemplate");

	private object __mt_TemplateViews_var;

	private object __mt_LeftExpressions_var;

	private object __mt_RightExpressions_var;

	private object __mt_Operators_var;

	private object __mt_CompoundTypes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject[] TemplateViews
	{
		[Export("templateViews")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_TemplateViews_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTemplateViewsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selTemplateViewsHandle))));
		}
	}

	public virtual NSExpression[] LeftExpressions
	{
		[Export("leftExpressions")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSExpression[])(__mt_LeftExpressions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftExpressionsHandle)) : NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftExpressionsHandle))));
		}
	}

	public virtual NSExpression[] RightExpressions
	{
		[Export("rightExpressions")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSExpression[])(__mt_RightExpressions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightExpressionsHandle)) : NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightExpressionsHandle))));
		}
	}

	public virtual NSAttributeType RightExpressionAttributeType
	{
		[Export("rightExpressionAttributeType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSAttributeType)Messaging.UInt64_objc_msgSend(base.Handle, selRightExpressionAttributeTypeHandle);
			}
			return (NSAttributeType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRightExpressionAttributeTypeHandle);
		}
	}

	public virtual NSComparisonPredicateModifier Modifier
	{
		[Export("modifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSend(base.Handle, selModifierHandle);
			}
			return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selModifierHandle);
		}
	}

	public virtual NSObject[] Operators
	{
		[Export("operators")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_Operators_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperatorsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selOperatorsHandle))));
		}
	}

	public virtual NSComparisonPredicateOptions Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	public virtual NSNumber[] CompoundTypes
	{
		[Export("compoundTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSNumber[])(__mt_CompoundTypes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompoundTypesHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompoundTypesHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPredicateEditorRowTemplate()
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
	public NSPredicateEditorRowTemplate(NSCoder coder)
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
	public NSPredicateEditorRowTemplate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPredicateEditorRowTemplate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("matchForPredicate:")]
	public virtual double MatchForPredicate(NSPredicate predicate)
	{
		NSApplication.EnsureUIThread();
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selMatchForPredicate_Handle, predicate.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchForPredicate_Handle, predicate.Handle);
	}

	[Export("setPredicate:")]
	public virtual void SetPredicate(NSPredicate predicate)
	{
		NSApplication.EnsureUIThread();
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, predicate.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, predicate.Handle);
		}
	}

	[Export("predicateWithSubpredicates:")]
	public virtual NSPredicate PredicateWithSubpredicates(NSPredicate[] subpredicates)
	{
		NSApplication.EnsureUIThread();
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		NSPredicate result = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredicateWithSubpredicates_Handle, nSArray.Handle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredicateWithSubpredicates_Handle, nSArray.Handle))));
		nSArray.Dispose();
		return result;
	}

	[Export("displayableSubpredicatesOfPredicate:")]
	public virtual NSPredicate[] DisplayableSubpredicatesOfPredicate(NSPredicate predicate)
	{
		NSApplication.EnsureUIThread();
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayableSubpredicatesOfPredicate_Handle, predicate.Handle));
		}
		return NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayableSubpredicatesOfPredicate_Handle, predicate.Handle));
	}

	[Export("initWithLeftExpressions:rightExpressions:modifier:operators:options:")]
	public NSPredicateEditorRowTemplate(NSExpression[] leftExpressions, NSExpression[] rightExpressions, NSComparisonPredicateModifier modifier, NSObject[] operators, NSComparisonPredicateOptions options)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (leftExpressions == null)
		{
			throw new ArgumentNullException("leftExpressions");
		}
		if (rightExpressions == null)
		{
			throw new ArgumentNullException("rightExpressions");
		}
		if (operators == null)
		{
			throw new ArgumentNullException("operators");
		}
		NSArray nSArray = NSArray.FromNSObjects(leftExpressions);
		NSArray nSArray2 = NSArray.FromNSObjects(rightExpressions);
		NSArray nSArray3 = NSArray.FromNSObjects(operators);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_UInt64(base.Handle, selInitWithLeftExpressionsRightExpressionsModifierOperatorsOptions_Handle, nSArray.Handle, nSArray2.Handle, (ulong)modifier, nSArray3.Handle, (ulong)options);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_UInt64(base.SuperHandle, selInitWithLeftExpressionsRightExpressionsModifierOperatorsOptions_Handle, nSArray.Handle, nSArray2.Handle, (ulong)modifier, nSArray3.Handle, (ulong)options);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
	}

	[Export("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:")]
	public NSPredicateEditorRowTemplate(NSExpression[] leftExpressions, NSAttributeType attributeType, NSComparisonPredicateModifier modifier, NSObject[] operators, NSComparisonPredicateOptions options)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (leftExpressions == null)
		{
			throw new ArgumentNullException("leftExpressions");
		}
		if (operators == null)
		{
			throw new ArgumentNullException("operators");
		}
		NSArray nSArray = NSArray.FromNSObjects(leftExpressions);
		NSArray nSArray2 = NSArray.FromNSObjects(operators);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr_UInt64(base.Handle, selInitWithLeftExpressionsRightExpressionAttributeTypeModifierOperatorsOptions_Handle, nSArray.Handle, (ulong)attributeType, (ulong)modifier, nSArray2.Handle, (ulong)options);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr_UInt64(base.SuperHandle, selInitWithLeftExpressionsRightExpressionAttributeTypeModifierOperatorsOptions_Handle, nSArray.Handle, (ulong)attributeType, (ulong)modifier, nSArray2.Handle, (ulong)options);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("initWithCompoundTypes:")]
	public NSPredicateEditorRowTemplate(NSNumber[] compoundTypes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (compoundTypes == null)
		{
			throw new ArgumentNullException("compoundTypes");
		}
		NSArray nSArray = NSArray.FromNSObjects(compoundTypes);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompoundTypes_Handle, nSArray.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompoundTypes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("templatesWithAttributeKeyPaths:inEntityDescription:")]
	public static NSPredicateEditorRowTemplate[] GetTemplates(string[] keyPaths, NSEntityDescription entityDescription)
	{
		NSApplication.EnsureUIThread();
		if (keyPaths == null)
		{
			throw new ArgumentNullException("keyPaths");
		}
		if (entityDescription == null)
		{
			throw new ArgumentNullException("entityDescription");
		}
		NSArray nSArray = NSArray.FromStrings(keyPaths);
		NSPredicateEditorRowTemplate[] result = NSArray.ArrayFromHandle<NSPredicateEditorRowTemplate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemplatesWithAttributeKeyPathsInEntityDescription_Handle, nSArray.Handle, entityDescription.Handle));
		nSArray.Dispose();
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TemplateViews_var = null;
			__mt_LeftExpressions_var = null;
			__mt_RightExpressions_var = null;
			__mt_Operators_var = null;
			__mt_CompoundTypes_var = null;
		}
	}
}
