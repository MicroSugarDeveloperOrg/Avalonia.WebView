using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKRuleSystem", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKRuleSystem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRule_ = "addRule:";

	private static readonly IntPtr selAddRule_Handle = Selector.GetHandle("addRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRulesFromArray_ = "addRulesFromArray:";

	private static readonly IntPtr selAddRulesFromArray_Handle = Selector.GetHandle("addRulesFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAgenda = "agenda";

	private static readonly IntPtr selAgendaHandle = Selector.GetHandle("agenda");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssertFact_ = "assertFact:";

	private static readonly IntPtr selAssertFact_Handle = Selector.GetHandle("assertFact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssertFact_Grade_ = "assertFact:grade:";

	private static readonly IntPtr selAssertFact_Grade_Handle = Selector.GetHandle("assertFact:grade:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluate = "evaluate";

	private static readonly IntPtr selEvaluateHandle = Selector.GetHandle("evaluate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuted = "executed";

	private static readonly IntPtr selExecutedHandle = Selector.GetHandle("executed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFacts = "facts";

	private static readonly IntPtr selFactsHandle = Selector.GetHandle("facts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradeForFact_ = "gradeForFact:";

	private static readonly IntPtr selGradeForFact_Handle = Selector.GetHandle("gradeForFact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumGradeForFacts_ = "maximumGradeForFacts:";

	private static readonly IntPtr selMaximumGradeForFacts_Handle = Selector.GetHandle("maximumGradeForFacts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumGradeForFacts_ = "minimumGradeForFacts:";

	private static readonly IntPtr selMinimumGradeForFacts_Handle = Selector.GetHandle("minimumGradeForFacts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllRules = "removeAllRules";

	private static readonly IntPtr selRemoveAllRulesHandle = Selector.GetHandle("removeAllRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetractFact_ = "retractFact:";

	private static readonly IntPtr selRetractFact_Handle = Selector.GetHandle("retractFact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetractFact_Grade_ = "retractFact:grade:";

	private static readonly IntPtr selRetractFact_Grade_Handle = Selector.GetHandle("retractFact:grade:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRules = "rules";

	private static readonly IntPtr selRulesHandle = Selector.GetHandle("rules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKRuleSystem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKRule[] Agenda
	{
		[Export("agenda", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selAgendaHandle));
			}
			return NSArray.ArrayFromHandle<GKRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAgendaHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKRule[] Executed
	{
		[Export("executed", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutedHandle));
			}
			return NSArray.ArrayFromHandle<GKRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Facts
	{
		[Export("facts", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selFactsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFactsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKRule[] Rules
	{
		[Export("rules", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selRulesHandle));
			}
			return NSArray.ArrayFromHandle<GKRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRulesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary State
	{
		[Export("state", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selStateHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKRuleSystem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKRuleSystem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKRuleSystem()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("addRule:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRule(GKRule rule)
	{
		if (rule == null)
		{
			throw new ArgumentNullException("rule");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRule_Handle, rule.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRule_Handle, rule.Handle);
		}
	}

	[Export("addRulesFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRules(GKRule[] rules)
	{
		if (rules == null)
		{
			throw new ArgumentNullException("rules");
		}
		NSArray nSArray = NSArray.FromNSObjects(rules);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRulesFromArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRulesFromArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("assertFact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AssertFact(NSObject fact)
	{
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAssertFact_Handle, fact.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAssertFact_Handle, fact.Handle);
		}
	}

	[Export("assertFact:grade:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AssertFact(NSObject fact, float grade)
	{
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selAssertFact_Grade_Handle, fact.Handle, grade);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selAssertFact_Grade_Handle, fact.Handle, grade);
		}
	}

	[Export("evaluate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Evaluate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEvaluateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEvaluateHandle);
		}
	}

	[Export("gradeForFact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetGrade(NSObject fact)
	{
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr(base.Handle, selGradeForFact_Handle, fact.Handle);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradeForFact_Handle, fact.Handle);
	}

	[Export("maximumGradeForFacts:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetMaximumGrade(NSObject[] facts)
	{
		if (facts == null)
		{
			throw new ArgumentNullException("facts");
		}
		NSArray nSArray = NSArray.FromNSObjects(facts);
		float result = ((!base.IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selMaximumGradeForFacts_Handle, nSArray.Handle) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selMaximumGradeForFacts_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("minimumGradeForFacts:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetMinimumGrade(NSObject[] facts)
	{
		if (facts == null)
		{
			throw new ArgumentNullException("facts");
		}
		NSArray nSArray = NSArray.FromNSObjects(facts);
		float result = ((!base.IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinimumGradeForFacts_Handle, nSArray.Handle) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selMinimumGradeForFacts_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("removeAllRules")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllRules()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllRulesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllRulesHandle);
		}
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("retractFact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RetractFact(NSObject fact)
	{
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRetractFact_Handle, fact.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRetractFact_Handle, fact.Handle);
		}
	}

	[Export("retractFact:grade:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RetractFact(NSObject fact, float grade)
	{
		if (fact == null)
		{
			throw new ArgumentNullException("fact");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selRetractFact_Grade_Handle, fact.Handle, grade);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selRetractFact_Grade_Handle, fact.Handle, grade);
		}
	}
}
