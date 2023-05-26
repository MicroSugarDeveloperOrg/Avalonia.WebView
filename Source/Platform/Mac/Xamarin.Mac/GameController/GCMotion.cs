using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameController;

[Register("GCMotion", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class GCMotion : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttitude = "attitude";

	private static readonly IntPtr selAttitudeHandle = Selector.GetHandle("attitude");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selController = "controller";

	private static readonly IntPtr selControllerHandle = Selector.GetHandle("controller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGravity = "gravity";

	private static readonly IntPtr selGravityHandle = Selector.GetHandle("gravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAttitudeAndRotationRate = "hasAttitudeAndRotationRate";

	private static readonly IntPtr selHasAttitudeAndRotationRateHandle = Selector.GetHandle("hasAttitudeAndRotationRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationRate = "rotationRate";

	private static readonly IntPtr selRotationRateHandle = Selector.GetHandle("rotationRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttitude_ = "setAttitude:";

	private static readonly IntPtr selSetAttitude_Handle = Selector.GetHandle("setAttitude:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGravity_ = "setGravity:";

	private static readonly IntPtr selSetGravity_Handle = Selector.GetHandle("setGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationRate_ = "setRotationRate:";

	private static readonly IntPtr selSetRotationRate_Handle = Selector.GetHandle("setRotationRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStateFromMotion_ = "setStateFromMotion:";

	private static readonly IntPtr selSetStateFromMotion_Handle = Selector.GetHandle("setStateFromMotion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserAcceleration_ = "setUserAcceleration:";

	private static readonly IntPtr selSetUserAcceleration_Handle = Selector.GetHandle("setUserAcceleration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueChangedHandler_ = "setValueChangedHandler:";

	private static readonly IntPtr selSetValueChangedHandler_Handle = Selector.GetHandle("setValueChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserAcceleration = "userAcceleration";

	private static readonly IntPtr selUserAccelerationHandle = Selector.GetHandle("userAcceleration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueChangedHandler = "valueChangedHandler";

	private static readonly IntPtr selValueChangedHandlerHandle = Selector.GetHandle("valueChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCMotion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Controller_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual Quaterniond Attitude
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("attitude", ArgumentSemantic.Assign)]
		get
		{
			Quaterniond retval;
			if (base.IsDirectBinding)
			{
				Messaging.Quaterniond_objc_msgSend_stret(out retval, base.Handle, selAttitudeHandle);
			}
			else
			{
				Messaging.Quaterniond_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAttitudeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCController Controller
	{
		[Export("controller", ArgumentSemantic.Assign)]
		get
		{
			GCController gCController = ((!base.IsDirectBinding) ? Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selControllerHandle)) : Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSend(base.Handle, selControllerHandle)));
			MarkDirty();
			__mt_Controller_var = gCController;
			return gCController;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3d Gravity
	{
		[Export("gravity", ArgumentSemantic.Assign)]
		get
		{
			Vector3d retval;
			if (base.IsDirectBinding)
			{
				Messaging.Vector3d_objc_msgSend_stret(out retval, base.Handle, selGravityHandle);
			}
			else
			{
				Messaging.Vector3d_objc_msgSendSuper_stret(out retval, base.SuperHandle, selGravityHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool HasAttitudeAndRotationRate
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("hasAttitudeAndRotationRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAttitudeAndRotationRateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAttitudeAndRotationRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual Vector3d RotationRate
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("rotationRate", ArgumentSemantic.Assign)]
		get
		{
			Vector3d retval;
			if (base.IsDirectBinding)
			{
				Messaging.Vector3d_objc_msgSend_stret(out retval, base.Handle, selRotationRateHandle);
			}
			else
			{
				Messaging.Vector3d_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRotationRateHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3d UserAcceleration
	{
		[Export("userAcceleration", ArgumentSemantic.Assign)]
		get
		{
			Vector3d retval;
			if (base.IsDirectBinding)
			{
				Messaging.Vector3d_objc_msgSend_stret(out retval, base.Handle, selUserAccelerationHandle);
			}
			else
			{
				Messaging.Vector3d_objc_msgSendSuper_stret(out retval, base.SuperHandle, selUserAccelerationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<GCMotion>? ValueChangedHandler
	{
		[Export("valueChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V43))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selValueChangedHandlerHandle));
			return Trampolines.NIDActionArity1V43.Create(block);
		}
		[Export("setValueChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V43))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V43.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueChangedHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueChangedHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GCMotion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCMotion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setAttitude:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttitude(GCQuaternion attitude)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_GCQuaternion(base.Handle, selSetAttitude_Handle, attitude);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_GCQuaternion(base.SuperHandle, selSetAttitude_Handle, attitude);
		}
	}

	[Export("setGravity:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetGravity(GCAcceleration gravity)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_GCAcceleration(base.Handle, selSetGravity_Handle, gravity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_GCAcceleration(base.SuperHandle, selSetGravity_Handle, gravity);
		}
	}

	[Export("setRotationRate:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRotationRate(GCRotationRate rotationRate)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_GCRotationRate(base.Handle, selSetRotationRate_Handle, rotationRate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_GCRotationRate(base.SuperHandle, selSetRotationRate_Handle, rotationRate);
		}
	}

	[Export("setStateFromMotion:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetState(GCMotion motion)
	{
		if (motion == null)
		{
			throw new ArgumentNullException("motion");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStateFromMotion_Handle, motion.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStateFromMotion_Handle, motion.Handle);
		}
	}

	[Export("setUserAcceleration:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetUserAcceleration(GCAcceleration userAcceleration)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_GCAcceleration(base.Handle, selSetUserAcceleration_Handle, userAcceleration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_GCAcceleration(base.SuperHandle, selSetUserAcceleration_Handle, userAcceleration);
		}
	}

	[Obsolete("Use the 'ValueChangedHandler' property.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValueChangedHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V43))] Action<GCMotion> handler)
	{
		ValueChangedHandler = handler;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Controller_var = null;
		}
	}
}
