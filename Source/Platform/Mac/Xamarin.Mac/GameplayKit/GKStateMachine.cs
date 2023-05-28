using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKStateMachine", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKStateMachine : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanEnterState_ = "canEnterState:";

	private static readonly IntPtr selCanEnterState_Handle = Selector.GetHandle("canEnterState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentState = "currentState";

	private static readonly IntPtr selCurrentStateHandle = Selector.GetHandle("currentState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnterState_ = "enterState:";

	private static readonly IntPtr selEnterState_Handle = Selector.GetHandle("enterState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStates_ = "initWithStates:";

	private static readonly IntPtr selInitWithStates_Handle = Selector.GetHandle("initWithStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateForClass_ = "stateForClass:";

	private static readonly IntPtr selStateForClass_Handle = Selector.GetHandle("stateForClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateMachineWithStates_ = "stateMachineWithStates:";

	private static readonly IntPtr selStateMachineWithStates_Handle = Selector.GetHandle("stateMachineWithStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithDeltaTime_ = "updateWithDeltaTime:";

	private static readonly IntPtr selUpdateWithDeltaTime_Handle = Selector.GetHandle("updateWithDeltaTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKStateMachine");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKState? CurrentState
	{
		[Export("currentState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKState>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentStateHandle));
			}
			return Runtime.GetNSObject<GKState>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentStateHandle));
		}
	}

	public GKState GetState(Type stateType)
	{
		return GetState(GKState.GetClass(stateType, "stateType"));
	}

	public GKState GetState(GKState state)
	{
		return GetState(GKState.GetClass(state, "state"));
	}

	public bool CanEnterState(Type stateType)
	{
		return CanEnterState(GKState.GetClass(stateType, "stateType"));
	}

	public bool CanEnterState(GKState state)
	{
		return CanEnterState(GKState.GetClass(state, "state"));
	}

	public virtual bool EnterState(Type stateType)
	{
		return EnterState(GKState.GetClass(stateType, "stateType"));
	}

	public virtual bool EnterState(GKState state)
	{
		return EnterState(GKState.GetClass(state, "state"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKStateMachine(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKStateMachine(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStates:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKStateMachine(GKState[] states)
		: base(NSObjectFlag.Empty)
	{
		if (states == null)
		{
			throw new ArgumentNullException("states");
		}
		NSArray nSArray = NSArray.FromNSObjects(states);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithStates_Handle, nSArray.Handle), "initWithStates:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithStates_Handle, nSArray.Handle), "initWithStates:");
		}
		nSArray.Dispose();
	}

	[Export("canEnterState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool CanEnterState(Class stateClass)
	{
		if (stateClass == null)
		{
			throw new ArgumentNullException("stateClass");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanEnterState_Handle, stateClass.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanEnterState_Handle, stateClass.Handle);
	}

	[Export("enterState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool EnterState(Class stateClass)
	{
		if (stateClass == null)
		{
			throw new ArgumentNullException("stateClass");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selEnterState_Handle, stateClass.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnterState_Handle, stateClass.Handle);
	}

	[Export("stateMachineWithStates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKStateMachine FromStates(GKState[] states)
	{
		if (states == null)
		{
			throw new ArgumentNullException("states");
		}
		NSArray nSArray = NSArray.FromNSObjects(states);
		GKStateMachine nSObject = Runtime.GetNSObject<GKStateMachine>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selStateMachineWithStates_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("stateForClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual GKState? GetState(Class stateClass)
	{
		if (stateClass == null)
		{
			throw new ArgumentNullException("stateClass");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKState>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStateForClass_Handle, stateClass.Handle));
		}
		return Runtime.GetNSObject<GKState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStateForClass_Handle, stateClass.Handle));
	}

	[Export("updateWithDeltaTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(double deltaTimeInSeconds)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selUpdateWithDeltaTime_Handle, deltaTimeInSeconds);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selUpdateWithDeltaTime_Handle, deltaTimeInSeconds);
		}
	}
}
