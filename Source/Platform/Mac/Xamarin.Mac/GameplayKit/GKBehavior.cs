using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKBehavior", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKBehavior : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithGoal_Weight_ = "behaviorWithGoal:weight:";

	private static readonly IntPtr selBehaviorWithGoal_Weight_Handle = Selector.GetHandle("behaviorWithGoal:weight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithGoals_ = "behaviorWithGoals:";

	private static readonly IntPtr selBehaviorWithGoals_Handle = Selector.GetHandle("behaviorWithGoals:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithGoals_AndWeights_ = "behaviorWithGoals:andWeights:";

	private static readonly IntPtr selBehaviorWithGoals_AndWeights_Handle = Selector.GetHandle("behaviorWithGoals:andWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithWeightedGoals_ = "behaviorWithWeightedGoals:";

	private static readonly IntPtr selBehaviorWithWeightedGoals_Handle = Selector.GetHandle("behaviorWithWeightedGoals:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalCount = "goalCount";

	private static readonly IntPtr selGoalCountHandle = Selector.GetHandle("goalCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllGoals = "removeAllGoals";

	private static readonly IntPtr selRemoveAllGoalsHandle = Selector.GetHandle("removeAllGoals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveGoal_ = "removeGoal:";

	private static readonly IntPtr selRemoveGoal_Handle = Selector.GetHandle("removeGoal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKeyedSubscript_ = "setObject:forKeyedSubscript:";

	private static readonly IntPtr selSetObject_ForKeyedSubscript_Handle = Selector.GetHandle("setObject:forKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeight_ForGoal_ = "setWeight:forGoal:";

	private static readonly IntPtr selSetWeight_ForGoal_Handle = Selector.GetHandle("setWeight:forGoal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeightForGoal_ = "weightForGoal:";

	private static readonly IntPtr selWeightForGoal_Handle = Selector.GetHandle("weightForGoal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKBehavior");

	public GKGoal this[nuint index] => ObjectAtIndexedSubscript(index);

	public NSNumber this[GKGoal goal]
	{
		get
		{
			return ObjectForKeyedSubscript(goal);
		}
		set
		{
			SetObject(value, goal);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GoalCount
	{
		[Export("goalCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selGoalCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selGoalCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKBehavior()
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
	protected GKBehavior(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKBehavior(IntPtr handle)
		: base(handle)
	{
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

	[Export("behaviorWithGoal:weight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKBehavior FromGoal(GKGoal goal, float weight)
	{
		if (goal == null)
		{
			throw new ArgumentNullException("goal");
		}
		return Runtime.GetNSObject<GKBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selBehaviorWithGoal_Weight_Handle, goal.Handle, weight));
	}

	[Export("behaviorWithGoals:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKBehavior FromGoals(GKGoal[] goals)
	{
		if (goals == null)
		{
			throw new ArgumentNullException("goals");
		}
		NSArray nSArray = NSArray.FromNSObjects(goals);
		GKBehavior nSObject = Runtime.GetNSObject<GKBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBehaviorWithGoals_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("behaviorWithGoals:andWeights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKBehavior FromGoals(GKGoal[] goals, NSNumber[] weights)
	{
		if (goals == null)
		{
			throw new ArgumentNullException("goals");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		NSArray nSArray = NSArray.FromNSObjects(goals);
		NSArray nSArray2 = NSArray.FromNSObjects(weights);
		GKBehavior nSObject = Runtime.GetNSObject<GKBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selBehaviorWithGoals_AndWeights_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("behaviorWithWeightedGoals:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKBehavior FromGoals(NSDictionary<GKGoal, NSNumber> weightedGoals)
	{
		if (weightedGoals == null)
		{
			throw new ArgumentNullException("weightedGoals");
		}
		return Runtime.GetNSObject<GKBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBehaviorWithWeightedGoals_Handle, weightedGoals.Handle));
	}

	[Export("weightForGoal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetWeight(GKGoal goal)
	{
		if (goal == null)
		{
			throw new ArgumentNullException("goal");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr(base.Handle, selWeightForGoal_Handle, goal.Handle);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selWeightForGoal_Handle, goal.Handle);
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual GKGoal ObjectAtIndexedSubscript(nuint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, idx));
		}
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, idx));
	}

	[Export("objectForKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSNumber? ObjectForKeyedSubscript(GKGoal goal)
	{
		if (goal == null)
		{
			throw new ArgumentNullException("goal");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, goal.Handle));
		}
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, goal.Handle));
	}

	[Export("removeAllGoals")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllGoals()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllGoalsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllGoalsHandle);
		}
	}

	[Export("removeGoal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveGoal(GKGoal goal)
	{
		if (goal == null)
		{
			throw new ArgumentNullException("goal");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveGoal_Handle, goal.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveGoal_Handle, goal.Handle);
		}
	}

	[Export("setObject:forKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void SetObject(NSNumber weight, GKGoal goal)
	{
		if (weight == null)
		{
			throw new ArgumentNullException("weight");
		}
		if (goal == null)
		{
			throw new ArgumentNullException("goal");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKeyedSubscript_Handle, weight.Handle, goal.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKeyedSubscript_Handle, weight.Handle, goal.Handle);
		}
	}

	[Export("setWeight:forGoal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWeight(float weight, GKGoal goal)
	{
		if (goal == null)
		{
			throw new ArgumentNullException("goal");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selSetWeight_ForGoal_Handle, weight, goal.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selSetWeight_ForGoal_Handle, weight, goal.Handle);
		}
	}
}
