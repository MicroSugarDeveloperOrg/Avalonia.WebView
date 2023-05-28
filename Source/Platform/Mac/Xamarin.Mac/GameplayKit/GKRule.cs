using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKRule", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKRule : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluatePredicateWithSystem_ = "evaluatePredicateWithSystem:";

	private static readonly IntPtr selEvaluatePredicateWithSystem_Handle = Selector.GetHandle("evaluatePredicateWithSystem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformActionWithSystem_ = "performActionWithSystem:";

	private static readonly IntPtr selPerformActionWithSystem_Handle = Selector.GetHandle("performActionWithSystem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRuleWithBlockPredicate_Action_ = "ruleWithBlockPredicate:action:";

	private static readonly IntPtr selRuleWithBlockPredicate_Action_Handle = Selector.GetHandle("ruleWithBlockPredicate:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRuleWithPredicate_AssertingFact_Grade_ = "ruleWithPredicate:assertingFact:grade:";

	private static readonly IntPtr selRuleWithPredicate_AssertingFact_Grade_Handle = Selector.GetHandle("ruleWithPredicate:assertingFact:grade:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRuleWithPredicate_RetractingFact_Grade_ = "ruleWithPredicate:retractingFact:grade:";

	private static readonly IntPtr selRuleWithPredicate_RetractingFact_Grade_Handle = Selector.GetHandle("ruleWithPredicate:retractingFact:grade:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSalience = "salience";

	private static readonly IntPtr selSalienceHandle = Selector.GetHandle("salience");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSalience_ = "setSalience:";

	private static readonly IntPtr selSetSalience_Handle = Selector.GetHandle("setSalience:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKRule");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Salience
	{
		[Export("salience", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSalienceHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSalienceHandle);
		}
		[Export("setSalience:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSalience_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSalience_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKRule()
		: base(NSObjectFlag.Empty)
	{
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKRule(IntPtr handle)
		: base(handle)
	{
	}

	[Export("evaluatePredicateWithSystem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EvaluatePredicate(GKRuleSystem system)
	{
		if (system == null)
		{
			throw new ArgumentNullException("system");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selEvaluatePredicateWithSystem_Handle, system.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selEvaluatePredicateWithSystem_Handle, system.Handle);
	}

	[Export("ruleWithBlockPredicate:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static GKRule FromPredicate([BlockProxy(typeof(Trampolines.NIDFuncArity2V1))] Func<GKRuleSystem, bool> predicate, [BlockProxy(typeof(Trampolines.NIDActionArity1V46))] Action<GKRuleSystem> action)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity2V1.Handler, predicate);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr2 = &blockLiteral2;
		blockLiteral2.SetupBlockUnsafe(Trampolines.SDActionArity1V46.Handler, action);
		GKRule nSObject = Runtime.GetNSObject<GKRule>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRuleWithBlockPredicate_Action_Handle, (IntPtr)ptr, (IntPtr)ptr2));
		ptr->CleanupBlock();
		ptr2->CleanupBlock();
		return nSObject;
	}

	[Export("ruleWithPredicate:assertingFact:grade:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRule FromPredicateAssertingFact(NSPredicate predicate, NSObject fact, float grade)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		return Runtime.GetNSObject<GKRule>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float(class_ptr, selRuleWithPredicate_AssertingFact_Grade_Handle, predicate.Handle, fact.Handle, grade));
	}

	[Export("ruleWithPredicate:retractingFact:grade:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRule FromPredicateRetractingFact(NSPredicate predicate, NSObject fact, float grade)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		return Runtime.GetNSObject<GKRule>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float(class_ptr, selRuleWithPredicate_RetractingFact_Grade_Handle, predicate.Handle, fact.Handle, grade));
	}

	[Export("performActionWithSystem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformAction(GKRuleSystem system)
	{
		if (system == null)
		{
			throw new ArgumentNullException("system");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformActionWithSystem_Handle, system.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformActionWithSystem_Handle, system.Handle);
		}
	}
}
