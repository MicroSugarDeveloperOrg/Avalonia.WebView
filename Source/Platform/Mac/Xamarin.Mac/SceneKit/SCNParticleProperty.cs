using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public static class SCNParticleProperty
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Angle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AngularVelocity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Bounce;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Charge;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Color;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContactNormal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContactPoint;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Frame;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Friction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Life;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Opacity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Position;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotationAxis;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Size;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Velocity;

	[Field("SCNParticlePropertyAngle", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Angle
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Angle == null)
			{
				_Angle = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyAngle");
			}
			return _Angle;
		}
	}

	[Field("SCNParticlePropertyAngularVelocity", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AngularVelocity
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AngularVelocity == null)
			{
				_AngularVelocity = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyAngularVelocity");
			}
			return _AngularVelocity;
		}
	}

	[Field("SCNParticlePropertyBounce", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Bounce
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Bounce == null)
			{
				_Bounce = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyBounce");
			}
			return _Bounce;
		}
	}

	[Field("SCNParticlePropertyCharge", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Charge
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Charge == null)
			{
				_Charge = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyCharge");
			}
			return _Charge;
		}
	}

	[Field("SCNParticlePropertyColor", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Color
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Color == null)
			{
				_Color = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyColor");
			}
			return _Color;
		}
	}

	[Field("SCNParticlePropertyContactNormal", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ContactNormal
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContactNormal == null)
			{
				_ContactNormal = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyContactNormal");
			}
			return _ContactNormal;
		}
	}

	[Field("SCNParticlePropertyContactPoint", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ContactPoint
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContactPoint == null)
			{
				_ContactPoint = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyContactPoint");
			}
			return _ContactPoint;
		}
	}

	[Field("SCNParticlePropertyFrame", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Frame
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Frame == null)
			{
				_Frame = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyFrame");
			}
			return _Frame;
		}
	}

	[Field("SCNParticlePropertyFrameRate", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString FrameRate
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FrameRate == null)
			{
				_FrameRate = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyFrameRate");
			}
			return _FrameRate;
		}
	}

	[Field("SCNParticlePropertyFriction", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Friction
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Friction == null)
			{
				_Friction = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyFriction");
			}
			return _Friction;
		}
	}

	[Field("SCNParticlePropertyLife", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Life
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Life == null)
			{
				_Life = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyLife");
			}
			return _Life;
		}
	}

	[Field("SCNParticlePropertyOpacity", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Opacity
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Opacity == null)
			{
				_Opacity = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyOpacity");
			}
			return _Opacity;
		}
	}

	[Field("SCNParticlePropertyPosition", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Position
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Position == null)
			{
				_Position = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyPosition");
			}
			return _Position;
		}
	}

	[Field("SCNParticlePropertyRotationAxis", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString RotationAxis
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RotationAxis == null)
			{
				_RotationAxis = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyRotationAxis");
			}
			return _RotationAxis;
		}
	}

	[Field("SCNParticlePropertySize", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Size
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Size == null)
			{
				_Size = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertySize");
			}
			return _Size;
		}
	}

	[Field("SCNParticlePropertyVelocity", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Velocity
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Velocity == null)
			{
				_Velocity = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNParticlePropertyVelocity");
			}
			return _Velocity;
		}
	}
}
