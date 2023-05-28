using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKAgent3D", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKAgent3D : GKAgent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightHanded = "rightHanded";

	private static readonly IntPtr selRightHandedHandle = Selector.GetHandle("rightHanded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotation = "rotation";

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRightHanded_ = "setRightHanded:";

	private static readonly IntPtr selSetRightHanded_Handle = Selector.GetHandle("setRightHanded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotation_ = "setRotation:";

	private static readonly IntPtr selSetRotation_Handle = Selector.GetHandle("setRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithDeltaTime_ = "updateWithDeltaTime:";

	private static readonly IntPtr selUpdateWithDeltaTime_Handle = Selector.GetHandle("updateWithDeltaTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocity = "velocity";

	private static readonly IntPtr selVelocityHandle = Selector.GetHandle("velocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKAgent3D");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Position
	{
		[Export("position", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selPositionHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
		[Export("setPosition:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RightHanded
	{
		[Export("rightHanded")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRightHandedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRightHandedHandle);
		}
		[Export("setRightHanded:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRightHanded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRightHanded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'Rotation3x3' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix3 Rotation
	{
		[Export("rotation", ArgumentSemantic.Assign)]
		get
		{
			Matrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix3_objc_msgSend_stret(out retval, base.Handle, selRotationHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRotationHandle);
			}
			return retval;
		}
		[Export("setRotation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Matrix3(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Matrix3(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix3 Rotation3x3
	{
		get
		{
			NMatrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSend_stret(out retval, base.Handle, selRotationHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRotationHandle);
			}
			return retval;
		}
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix3(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix3(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Velocity
	{
		[Export("velocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selVelocityHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selVelocityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKAgent3D()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKAgent3D(NSCoder coder)
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
	protected GKAgent3D(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKAgent3D(IntPtr handle)
		: base(handle)
	{
	}

	[Export("updateWithDeltaTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void Update(double deltaTimeInSeconds)
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
