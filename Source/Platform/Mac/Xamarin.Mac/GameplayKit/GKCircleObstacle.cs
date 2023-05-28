using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKCircleObstacle", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKCircleObstacle : GKObstacle
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRadius_ = "initWithRadius:";

	private static readonly IntPtr selInitWithRadius_Handle = Selector.GetHandle("initWithRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstacleWithRadius_ = "obstacleWithRadius:";

	private static readonly IntPtr selObstacleWithRadius_Handle = Selector.GetHandle("obstacleWithRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadius = "radius";

	private static readonly IntPtr selRadiusHandle = Selector.GetHandle("radius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRadius_ = "setRadius:";

	private static readonly IntPtr selSetRadius_Handle = Selector.GetHandle("setRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKCircleObstacle");

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
	public virtual float Radius
	{
		[Export("radius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRadiusHandle);
		}
		[Export("setRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKCircleObstacle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKCircleObstacle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRadius:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKCircleObstacle(float radius)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_float(base.Handle, selInitWithRadius_Handle, radius), "initWithRadius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_float(base.SuperHandle, selInitWithRadius_Handle, radius), "initWithRadius:");
		}
	}

	[Export("obstacleWithRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKCircleObstacle FromRadius(float radius)
	{
		return Runtime.GetNSObject<GKCircleObstacle>(Messaging.IntPtr_objc_msgSend_float(class_ptr, selObstacleWithRadius_Handle, radius));
	}
}
