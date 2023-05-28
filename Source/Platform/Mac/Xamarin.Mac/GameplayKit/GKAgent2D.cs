using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKAgent2D", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKAgent2D : GKAgent, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotation = "rotation";

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKAgent2D");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 Position
	{
		[Export("position", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selPositionHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
		[Export("setPosition:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Rotation
	{
		[Export("rotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRotationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
		[Export("setRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 Velocity
	{
		[Export("velocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selVelocityHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selVelocityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKAgent2D()
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
	public GKAgent2D(NSCoder coder)
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
	protected GKAgent2D(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKAgent2D(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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
