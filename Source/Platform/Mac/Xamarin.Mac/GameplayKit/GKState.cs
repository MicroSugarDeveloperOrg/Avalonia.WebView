using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKState", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public abstract class GKState : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidEnterWithPreviousState_ = "didEnterWithPreviousState:";

	private static readonly IntPtr selDidEnterWithPreviousState_Handle = Selector.GetHandle("didEnterWithPreviousState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValidNextState_ = "isValidNextState:";

	private static readonly IntPtr selIsValidNextState_Handle = Selector.GetHandle("isValidNextState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateMachine = "stateMachine";

	private static readonly IntPtr selStateMachineHandle = Selector.GetHandle("stateMachine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithDeltaTime_ = "updateWithDeltaTime:";

	private static readonly IntPtr selUpdateWithDeltaTime_Handle = Selector.GetHandle("updateWithDeltaTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillExitWithNextState_ = "willExitWithNextState:";

	private static readonly IntPtr selWillExitWithNextState_Handle = Selector.GetHandle("willExitWithNextState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_StateMachine_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKStateMachine? StateMachine
	{
		[Export("stateMachine", ArgumentSemantic.Weak)]
		get
		{
			GKStateMachine gKStateMachine = ((!base.IsDirectBinding) ? Runtime.GetNSObject<GKStateMachine>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStateMachineHandle)) : Runtime.GetNSObject<GKStateMachine>(Messaging.IntPtr_objc_msgSend(base.Handle, selStateMachineHandle)));
			MarkDirty();
			__mt_StateMachine_var = gKStateMachine;
			return gKStateMachine;
		}
	}

	internal static Class GetClass(Type type, string parameterName)
	{
		if (type == null)
		{
			throw new ArgumentNullException(parameterName);
		}
		Class @class = new Class(type);
		if (@class.Handle == IntPtr.Zero)
		{
			throw new ArgumentException("Not an type exposed to ObjC", parameterName);
		}
		return @class;
	}

	internal static Class GetClass(NSObject instance, string parameterName)
	{
		if (instance == null)
		{
			throw new ArgumentNullException(parameterName);
		}
		Class @class = instance.Class;
		if (@class == null || @class.Handle == IntPtr.Zero)
		{
			throw new ArgumentException("Not an type exposed to ObjC", parameterName);
		}
		return @class;
	}

	public bool IsValidNextState(Type stateType)
	{
		return IsValidNextState(GetClass(stateType, "stateType"));
	}

	public bool IsValidNextState(GKState state)
	{
		return IsValidNextState(GetClass(state, "state"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected GKState()
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

	[Export("didEnterWithPreviousState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEnter(GKState? previousState)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidEnterWithPreviousState_Handle, previousState?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidEnterWithPreviousState_Handle, previousState?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("state")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKState GetState()
	{
		return Runtime.GetNSObject<GKState>(Messaging.IntPtr_objc_msgSend(class_ptr, selStateHandle));
	}

	[Export("isValidNextState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidNextState(Class stateClass)
	{
		if (stateClass == null)
		{
			throw new ArgumentNullException("stateClass");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsValidNextState_Handle, stateClass.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsValidNextState_Handle, stateClass.Handle);
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

	[Export("willExitWithNextState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillExit(GKState nextState)
	{
		if (nextState == null)
		{
			throw new ArgumentNullException("nextState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillExitWithNextState_Handle, nextState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillExitWithNextState_Handle, nextState.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_StateMachine_var = null;
		}
	}
}
