using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsVehicle", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsVehicle : SCNPhysicsBehavior
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyBrakingForce_ForWheelAtIndex_ = "applyBrakingForce:forWheelAtIndex:";

	private static readonly IntPtr selApplyBrakingForce_ForWheelAtIndex_Handle = Selector.GetHandle("applyBrakingForce:forWheelAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyEngineForce_ForWheelAtIndex_ = "applyEngineForce:forWheelAtIndex:";

	private static readonly IntPtr selApplyEngineForce_ForWheelAtIndex_Handle = Selector.GetHandle("applyEngineForce:forWheelAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChassisBody = "chassisBody";

	private static readonly IntPtr selChassisBodyHandle = Selector.GetHandle("chassisBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSteeringAngle_ForWheelAtIndex_ = "setSteeringAngle:forWheelAtIndex:";

	private static readonly IntPtr selSetSteeringAngle_ForWheelAtIndex_Handle = Selector.GetHandle("setSteeringAngle:forWheelAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeedInKilometersPerHour = "speedInKilometersPerHour";

	private static readonly IntPtr selSpeedInKilometersPerHourHandle = Selector.GetHandle("speedInKilometersPerHour");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVehicleWithChassisBody_Wheels_ = "vehicleWithChassisBody:wheels:";

	private static readonly IntPtr selVehicleWithChassisBody_Wheels_Handle = Selector.GetHandle("vehicleWithChassisBody:wheels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWheels = "wheels";

	private static readonly IntPtr selWheelsHandle = Selector.GetHandle("wheels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsVehicle");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBody ChassisBody
	{
		[Export("chassisBody")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selChassisBodyHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChassisBodyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SpeedInKilometersPerHour
	{
		[Export("speedInKilometersPerHour")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpeedInKilometersPerHourHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpeedInKilometersPerHourHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsVehicleWheel[] Wheels
	{
		[Export("wheels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNPhysicsVehicleWheel>(Messaging.IntPtr_objc_msgSend(base.Handle, selWheelsHandle));
			}
			return NSArray.ArrayFromHandle<SCNPhysicsVehicleWheel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWheelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsVehicle(NSCoder coder)
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
	protected SCNPhysicsVehicle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsVehicle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyBrakingForce:forWheelAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyBrakingForce(nfloat value, nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selApplyBrakingForce_ForWheelAtIndex_Handle, value, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selApplyBrakingForce_ForWheelAtIndex_Handle, value, index);
		}
	}

	[Export("applyEngineForce:forWheelAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyEngineForce(nfloat value, nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selApplyEngineForce_ForWheelAtIndex_Handle, value, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selApplyEngineForce_ForWheelAtIndex_Handle, value, index);
		}
	}

	[Export("vehicleWithChassisBody:wheels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsVehicle Create(SCNPhysicsBody chassisBody, SCNPhysicsVehicleWheel[] wheels)
	{
		if (chassisBody == null)
		{
			throw new ArgumentNullException("chassisBody");
		}
		if (wheels == null)
		{
			throw new ArgumentNullException("wheels");
		}
		NSArray nSArray = NSArray.FromNSObjects(wheels);
		SCNPhysicsVehicle nSObject = Runtime.GetNSObject<SCNPhysicsVehicle>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVehicleWithChassisBody_Wheels_Handle, chassisBody.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("setSteeringAngle:forWheelAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSteeringAngle(nfloat value, nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selSetSteeringAngle_ForWheelAtIndex_Handle, value, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selSetSteeringAngle_ForWheelAtIndex_Handle, value, index);
		}
	}
}
