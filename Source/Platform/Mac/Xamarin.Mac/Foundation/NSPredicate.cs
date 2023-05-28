using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPredicate", true)]
public class NSPredicate : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowEvaluation = "allowEvaluation";

	private static readonly IntPtr selAllowEvaluationHandle = Selector.GetHandle("allowEvaluation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateWithObject_ = "evaluateWithObject:";

	private static readonly IntPtr selEvaluateWithObject_Handle = Selector.GetHandle("evaluateWithObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateWithObject_SubstitutionVariables_ = "evaluateWithObject:substitutionVariables:";

	private static readonly IntPtr selEvaluateWithObject_SubstitutionVariables_Handle = Selector.GetHandle("evaluateWithObject:substitutionVariables:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateFormat = "predicateFormat";

	private static readonly IntPtr selPredicateFormatHandle = Selector.GetHandle("predicateFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateFromMetadataQueryString_ = "predicateFromMetadataQueryString:";

	private static readonly IntPtr selPredicateFromMetadataQueryString_Handle = Selector.GetHandle("predicateFromMetadataQueryString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithBlock_ = "predicateWithBlock:";

	private static readonly IntPtr selPredicateWithBlock_Handle = Selector.GetHandle("predicateWithBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithFormat_ArgumentArray_ = "predicateWithFormat:argumentArray:";

	private static readonly IntPtr selPredicateWithFormat_ArgumentArray_Handle = Selector.GetHandle("predicateWithFormat:argumentArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithSubstitutionVariables_ = "predicateWithSubstitutionVariables:";

	private static readonly IntPtr selPredicateWithSubstitutionVariables_Handle = Selector.GetHandle("predicateWithSubstitutionVariables:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithValue_ = "predicateWithValue:";

	private static readonly IntPtr selPredicateWithValue_Handle = Selector.GetHandle("predicateWithValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPredicate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PredicateFormat
	{
		[Export("predicateFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateFormatHandle));
		}
	}

	public static NSPredicate FromFormat(string predicateFormat)
	{
		return _FromFormat(predicateFormat, null);
	}

	public static NSPredicate FromFormat(string predicateFormat, NSObject argument)
	{
		return _FromFormat(predicateFormat, new NSObject[1] { argument });
	}

	public static NSPredicate FromFormat(string predicateFormat, params NSObject[] arguments)
	{
		return _FromFormat(predicateFormat, arguments);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPredicate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NSPredicate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPredicate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("allowEvaluation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AllowEvaluation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAllowEvaluationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAllowEvaluationHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
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

	[Export("evaluateWithObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EvaluateWithObject(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selEvaluateWithObject_Handle, obj.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selEvaluateWithObject_Handle, obj.Handle);
	}

	[Export("evaluateWithObject:substitutionVariables:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EvaluateWithObject(NSObject obj, NSDictionary substitutionVariables)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (substitutionVariables == null)
		{
			throw new ArgumentNullException("substitutionVariables");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEvaluateWithObject_SubstitutionVariables_Handle, obj.Handle, substitutionVariables.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEvaluateWithObject_SubstitutionVariables_Handle, obj.Handle, substitutionVariables.Handle);
	}

	[Export("predicateWithBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSPredicate FromExpression([BlockProxy(typeof(Trampolines.NIDNSPredicateEvaluator))] NSPredicateEvaluator evaluator)
	{
		if (evaluator == null)
		{
			throw new ArgumentNullException("evaluator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSPredicateEvaluator.Handler, evaluator);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateWithBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("predicateFromMetadataQueryString:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate FromMetadataQueryString(string query)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		IntPtr arg = NSString.CreateNative(query);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateFromMetadataQueryString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("predicateWithValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate FromValue(bool value)
	{
		return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_bool(class_ptr, selPredicateWithValue_Handle, value));
	}

	[Export("predicateWithSubstitutionVariables:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate PredicateWithSubstitutionVariables(NSDictionary substitutionVariables)
	{
		if (substitutionVariables == null)
		{
			throw new ArgumentNullException("substitutionVariables");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredicateWithSubstitutionVariables_Handle, substitutionVariables.Handle));
		}
		return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredicateWithSubstitutionVariables_Handle, substitutionVariables.Handle));
	}

	[Export("predicateWithFormat:argumentArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSPredicate _FromFormat(string predicateFormat, NSObject[]? arguments)
	{
		if (predicateFormat == null)
		{
			throw new ArgumentNullException("predicateFormat");
		}
		IntPtr arg = NSString.CreateNative(predicateFormat);
		NSArray nSArray = ((arguments == null) ? null : NSArray.FromNSObjects(arguments));
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPredicateWithFormat_ArgumentArray_Handle, arg, nSArray?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		nSArray?.Dispose();
		return nSObject;
	}
}
