using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKGoal", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKGoal : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToAlignWithAgents_MaxDistance_MaxAngle_ = "goalToAlignWithAgents:maxDistance:maxAngle:";

	private static readonly IntPtr selGoalToAlignWithAgents_MaxDistance_MaxAngle_Handle = Selector.GetHandle("goalToAlignWithAgents:maxDistance:maxAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToAvoidAgents_MaxPredictionTime_ = "goalToAvoidAgents:maxPredictionTime:";

	private static readonly IntPtr selGoalToAvoidAgents_MaxPredictionTime_Handle = Selector.GetHandle("goalToAvoidAgents:maxPredictionTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToAvoidObstacles_MaxPredictionTime_ = "goalToAvoidObstacles:maxPredictionTime:";

	private static readonly IntPtr selGoalToAvoidObstacles_MaxPredictionTime_Handle = Selector.GetHandle("goalToAvoidObstacles:maxPredictionTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToCohereWithAgents_MaxDistance_MaxAngle_ = "goalToCohereWithAgents:maxDistance:maxAngle:";

	private static readonly IntPtr selGoalToCohereWithAgents_MaxDistance_MaxAngle_Handle = Selector.GetHandle("goalToCohereWithAgents:maxDistance:maxAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToFleeAgent_ = "goalToFleeAgent:";

	private static readonly IntPtr selGoalToFleeAgent_Handle = Selector.GetHandle("goalToFleeAgent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToFollowPath_MaxPredictionTime_Forward_ = "goalToFollowPath:maxPredictionTime:forward:";

	private static readonly IntPtr selGoalToFollowPath_MaxPredictionTime_Forward_Handle = Selector.GetHandle("goalToFollowPath:maxPredictionTime:forward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToInterceptAgent_MaxPredictionTime_ = "goalToInterceptAgent:maxPredictionTime:";

	private static readonly IntPtr selGoalToInterceptAgent_MaxPredictionTime_Handle = Selector.GetHandle("goalToInterceptAgent:maxPredictionTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToReachTargetSpeed_ = "goalToReachTargetSpeed:";

	private static readonly IntPtr selGoalToReachTargetSpeed_Handle = Selector.GetHandle("goalToReachTargetSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToSeekAgent_ = "goalToSeekAgent:";

	private static readonly IntPtr selGoalToSeekAgent_Handle = Selector.GetHandle("goalToSeekAgent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToSeparateFromAgents_MaxDistance_MaxAngle_ = "goalToSeparateFromAgents:maxDistance:maxAngle:";

	private static readonly IntPtr selGoalToSeparateFromAgents_MaxDistance_MaxAngle_Handle = Selector.GetHandle("goalToSeparateFromAgents:maxDistance:maxAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToStayOnPath_MaxPredictionTime_ = "goalToStayOnPath:maxPredictionTime:";

	private static readonly IntPtr selGoalToStayOnPath_MaxPredictionTime_Handle = Selector.GetHandle("goalToStayOnPath:maxPredictionTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGoalToWander_ = "goalToWander:";

	private static readonly IntPtr selGoalToWander_Handle = Selector.GetHandle("goalToWander:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGoal");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKGoal()
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
	protected GKGoal(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGoal(IntPtr handle)
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

	[Export("goalToAlignWithAgents:maxDistance:maxAngle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToAlign(GKAgent[] agents, float maxDistance, float maxAngle)
	{
		if (agents == null)
		{
			throw new ArgumentNullException("agents");
		}
		NSArray nSArray = NSArray.FromNSObjects(agents);
		GKGoal nSObject = Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_float_float(class_ptr, selGoalToAlignWithAgents_MaxDistance_MaxAngle_Handle, nSArray.Handle, maxDistance, maxAngle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("goalToAvoidAgents:maxPredictionTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToAvoidAgents(GKAgent[] agents, double maxPredictionTime)
	{
		if (agents == null)
		{
			throw new ArgumentNullException("agents");
		}
		NSArray nSArray = NSArray.FromNSObjects(agents);
		GKGoal nSObject = Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selGoalToAvoidAgents_MaxPredictionTime_Handle, nSArray.Handle, maxPredictionTime));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("goalToAvoidObstacles:maxPredictionTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToAvoidObstacles(GKObstacle[] obstacles, double maxPredictionTime)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		GKGoal nSObject = Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selGoalToAvoidObstacles_MaxPredictionTime_Handle, nSArray.Handle, maxPredictionTime));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("goalToCohereWithAgents:maxDistance:maxAngle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToCohere(GKAgent[] agents, float maxDistance, float maxAngle)
	{
		if (agents == null)
		{
			throw new ArgumentNullException("agents");
		}
		NSArray nSArray = NSArray.FromNSObjects(agents);
		GKGoal nSObject = Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_float_float(class_ptr, selGoalToCohereWithAgents_MaxDistance_MaxAngle_Handle, nSArray.Handle, maxDistance, maxAngle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("goalToFleeAgent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToFleeAgent(GKAgent agent)
	{
		if (agent == null)
		{
			throw new ArgumentNullException("agent");
		}
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGoalToFleeAgent_Handle, agent.Handle));
	}

	[Export("goalToFollowPath:maxPredictionTime:forward:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToFollowPath(GKPath path, double maxPredictionTime, bool forward)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_Double_bool(class_ptr, selGoalToFollowPath_MaxPredictionTime_Forward_Handle, path.Handle, maxPredictionTime, forward));
	}

	[Export("goalToInterceptAgent:maxPredictionTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToInterceptAgent(GKAgent target, double maxPredictionTime)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selGoalToInterceptAgent_MaxPredictionTime_Handle, target.Handle, maxPredictionTime));
	}

	[Export("goalToReachTargetSpeed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToReachTargetSpeed(float targetSpeed)
	{
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_float(class_ptr, selGoalToReachTargetSpeed_Handle, targetSpeed));
	}

	[Export("goalToSeekAgent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToSeekAgent(GKAgent agent)
	{
		if (agent == null)
		{
			throw new ArgumentNullException("agent");
		}
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGoalToSeekAgent_Handle, agent.Handle));
	}

	[Export("goalToSeparateFromAgents:maxDistance:maxAngle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToSeparate(GKAgent[] agents, float maxDistance, float maxAngle)
	{
		if (agents == null)
		{
			throw new ArgumentNullException("agents");
		}
		NSArray nSArray = NSArray.FromNSObjects(agents);
		GKGoal nSObject = Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_float_float(class_ptr, selGoalToSeparateFromAgents_MaxDistance_MaxAngle_Handle, nSArray.Handle, maxDistance, maxAngle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("goalToStayOnPath:maxPredictionTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToStayOnPath(GKPath path, double maxPredictionTime)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selGoalToStayOnPath_MaxPredictionTime_Handle, path.Handle, maxPredictionTime));
	}

	[Export("goalToWander:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGoal GetGoalToWander(float speed)
	{
		return Runtime.GetNSObject<GKGoal>(Messaging.IntPtr_objc_msgSend_float(class_ptr, selGoalToWander_Handle, speed));
	}
}
