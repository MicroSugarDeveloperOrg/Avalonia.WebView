using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CoreData;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPredicateEditorRowTemplate", true)]
public class NSPredicateEditorRowTemplate : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompoundTypes = "compoundTypes";

	private static readonly IntPtr selCompoundTypesHandle = Selector.GetHandle("compoundTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayableSubpredicatesOfPredicate_ = "displayableSubpredicatesOfPredicate:";

	private static readonly IntPtr selDisplayableSubpredicatesOfPredicate_Handle = Selector.GetHandle("displayableSubpredicatesOfPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompoundTypes_ = "initWithCompoundTypes:";

	private static readonly IntPtr selInitWithCompoundTypes_Handle = Selector.GetHandle("initWithCompoundTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_ = "initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:";

	private static readonly IntPtr selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_Handle = Selector.GetHandle("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_ = "initWithLeftExpressions:rightExpressions:modifier:operators:options:";

	private static readonly IntPtr selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_Handle = Selector.GetHandle("initWithLeftExpressions:rightExpressions:modifier:operators:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftExpressions = "leftExpressions";

	private static readonly IntPtr selLeftExpressionsHandle = Selector.GetHandle("leftExpressions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchForPredicate_ = "matchForPredicate:";

	private static readonly IntPtr selMatchForPredicate_Handle = Selector.GetHandle("matchForPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifier = "modifier";

	private static readonly IntPtr selModifierHandle = Selector.GetHandle("modifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperators = "operators";

	private static readonly IntPtr selOperatorsHandle = Selector.GetHandle("operators");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithSubpredicates_ = "predicateWithSubpredicates:";

	private static readonly IntPtr selPredicateWithSubpredicates_Handle = Selector.GetHandle("predicateWithSubpredicates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightExpressionAttributeType = "rightExpressionAttributeType";

	private static readonly IntPtr selRightExpressionAttributeTypeHandle = Selector.GetHandle("rightExpressionAttributeType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightExpressions = "rightExpressions";

	private static readonly IntPtr selRightExpressionsHandle = Selector.GetHandle("rightExpressions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemplateViews = "templateViews";

	private static readonly IntPtr selTemplateViewsHandle = Selector.GetHandle("templateViews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemplatesWithAttributeKeyPaths_InEntityDescription_ = "templatesWithAttributeKeyPaths:inEntityDescription:";

	private static readonly IntPtr selTemplatesWithAttributeKeyPaths_InEntityDescription_Handle = Selector.GetHandle("templatesWithAttributeKeyPaths:inEntityDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPredicateEditorRowTemplate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] CompoundTypes
	{
		[Export("compoundTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompoundTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompoundTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression[] LeftExpressions
	{
		[Export("leftExpressions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftExpressionsHandle));
			}
			return NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftExpressionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonPredicateModifier Modifier
	{
		[Export("modifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSend(base.Handle, selModifierHandle);
			}
			return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selModifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Operators
	{
		[Export("operators")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selOperatorsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperatorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonPredicateOptions Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributeType RightExpressionAttributeType
	{
		[Export("rightExpressionAttributeType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAttributeType)Messaging.UInt64_objc_msgSend(base.Handle, selRightExpressionAttributeTypeHandle);
			}
			return (NSAttributeType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRightExpressionAttributeTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression[] RightExpressions
	{
		[Export("rightExpressions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightExpressionsHandle));
			}
			return NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightExpressionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] TemplateViews
	{
		[Export("templateViews")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selTemplateViewsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTemplateViewsHandle));
		}
	}

	public NSPredicateEditorRowTemplate(params NSCompoundPredicateType[] compoundTypes)
		: this(compoundTypes.Select((NSCompoundPredicateType t) => NSNumber.FromUInt32((uint)t)).ToArray())
	{
	}

	public NSPredicateEditorRowTemplate(IEnumerable<NSExpression> leftExpressions, IEnumerable<NSExpression> rightExpressions, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(leftExpressions.ToArray(), rightExpressions.ToArray(), modifier, operators.Select((NSPredicateOperatorType o) => NSNumber.FromUInt32((uint)o)).ToArray(), options)
	{
	}

	public NSPredicateEditorRowTemplate(IEnumerable<string> leftExpressionsFromKeyPaths, IEnumerable<string> rightExpressionsFromConstants, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(leftExpressionsFromKeyPaths.Select((string k) => NSExpression.FromKeyPath(k)), rightExpressionsFromConstants.Select((string k) => NSExpression.FromConstant(new NSString(k))), operators, modifier, options)
	{
	}

	public NSPredicateEditorRowTemplate(string leftExpressionFromKeyPath, string rightExpressionFromConstant, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(new string[1] { leftExpressionFromKeyPath }, new string[1] { rightExpressionFromConstant }, operators, modifier, options)
	{
	}

	public NSPredicateEditorRowTemplate(string leftExpressionFromKeyPath, IEnumerable<string> rightExpressionsFromConstants, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(new string[1] { leftExpressionFromKeyPath }, rightExpressionsFromConstants, operators, modifier, options)
	{
	}

	public NSPredicateEditorRowTemplate(IEnumerable<NSExpression> leftExpressions, NSAttributeType attributeType, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(leftExpressions.ToArray(), attributeType, modifier, operators.Select((NSPredicateOperatorType o) => NSNumber.FromUInt32((uint)o)).ToArray(), options)
	{
	}

	public NSPredicateEditorRowTemplate(IEnumerable<string> leftExpressionsFromKeyPaths, NSAttributeType attributeType, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(leftExpressionsFromKeyPaths.Select((string k) => NSExpression.FromKeyPath(k)), attributeType, operators, modifier, options)
	{
	}

	public NSPredicateEditorRowTemplate(string leftExpressionFromKeyPath, NSAttributeType attributeType, IEnumerable<NSPredicateOperatorType> operators, NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct, NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
		: this(new string[1] { leftExpressionFromKeyPath }, attributeType, operators, modifier, options)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPredicateEditorRowTemplate()
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
	public NSPredicateEditorRowTemplate(NSCoder coder)
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
	protected NSPredicateEditorRowTemplate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPredicateEditorRowTemplate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLeftExpressions:rightExpressions:modifier:operators:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_UInt64(base.Handle, selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_Handle, nSArray.Handle, nSArray2.Handle, (ulong)modifier, nSArray3.Handle, (ulong)options), "initWithLeftExpressions:rightExpressions:modifier:operators:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_UInt64(base.SuperHandle, selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_Handle, nSArray.Handle, nSArray2.Handle, (ulong)modifier, nSArray3.Handle, (ulong)options), "initWithLeftExpressions:rightExpressions:modifier:operators:options:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
	}

	[Export("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr_UInt64(base.Handle, selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_Handle, nSArray.Handle, (ulong)attributeType, (ulong)modifier, nSArray2.Handle, (ulong)options), "initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr_UInt64(base.SuperHandle, selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_Handle, nSArray.Handle, (ulong)attributeType, (ulong)modifier, nSArray2.Handle, (ulong)options), "initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("initWithCompoundTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPredicateEditorRowTemplate(NSNumber[] compoundTypes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (compoundTypes == null)
		{
			throw new ArgumentNullException("compoundTypes");
		}
		NSArray nSArray = NSArray.FromNSObjects(compoundTypes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompoundTypes_Handle, nSArray.Handle), "initWithCompoundTypes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompoundTypes_Handle, nSArray.Handle), "initWithCompoundTypes:");
		}
		nSArray.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("displayableSubpredicatesOfPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate[] DisplayableSubpredicatesOfPredicate(NSPredicate predicate)
	{
		NSApplication.EnsureUIThread();
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayableSubpredicatesOfPredicate_Handle, predicate.Handle));
		}
		return NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayableSubpredicatesOfPredicate_Handle, predicate.Handle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("templatesWithAttributeKeyPaths:inEntityDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSPredicateEditorRowTemplate[] result = NSArray.ArrayFromHandle<NSPredicateEditorRowTemplate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemplatesWithAttributeKeyPaths_InEntityDescription_Handle, nSArray.Handle, entityDescription.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("matchForPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MatchForPredicate(NSPredicate predicate)
	{
		NSApplication.EnsureUIThread();
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selMatchForPredicate_Handle, predicate.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchForPredicate_Handle, predicate.Handle);
	}

	[Export("predicateWithSubpredicates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate PredicateWithSubpredicates(NSPredicate[] subpredicates)
	{
		NSApplication.EnsureUIThread();
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		NSPredicate result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredicateWithSubpredicates_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredicateWithSubpredicates_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("setPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPredicate(NSPredicate predicate)
	{
		NSApplication.EnsureUIThread();
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, predicate.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, predicate.Handle);
		}
	}
}
