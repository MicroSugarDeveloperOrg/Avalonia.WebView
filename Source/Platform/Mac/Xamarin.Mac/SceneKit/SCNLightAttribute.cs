using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public static class SCNLightAttribute
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttenuationEndKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttenuationFalloffExponentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttenuationStartKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadowFarClippingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadowNearClippingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SpotInnerAngleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SpotOuterAngleKey;

	[Field("SCNLightAttenuationEndKey", "SceneKit")]
	public static NSString AttenuationEndKey
	{
		get
		{
			if (_AttenuationEndKey == null)
			{
				_AttenuationEndKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightAttenuationEndKey");
			}
			return _AttenuationEndKey;
		}
	}

	[Field("SCNLightAttenuationFalloffExponentKey", "SceneKit")]
	public static NSString AttenuationFalloffExponentKey
	{
		get
		{
			if (_AttenuationFalloffExponentKey == null)
			{
				_AttenuationFalloffExponentKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightAttenuationFalloffExponentKey");
			}
			return _AttenuationFalloffExponentKey;
		}
	}

	[Field("SCNLightAttenuationStartKey", "SceneKit")]
	public static NSString AttenuationStartKey
	{
		get
		{
			if (_AttenuationStartKey == null)
			{
				_AttenuationStartKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightAttenuationStartKey");
			}
			return _AttenuationStartKey;
		}
	}

	[Field("SCNLightShadowFarClippingKey", "SceneKit")]
	public static NSString ShadowFarClippingKey
	{
		get
		{
			if (_ShadowFarClippingKey == null)
			{
				_ShadowFarClippingKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightShadowFarClippingKey");
			}
			return _ShadowFarClippingKey;
		}
	}

	[Field("SCNLightShadowNearClippingKey", "SceneKit")]
	public static NSString ShadowNearClippingKey
	{
		get
		{
			if (_ShadowNearClippingKey == null)
			{
				_ShadowNearClippingKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightShadowNearClippingKey");
			}
			return _ShadowNearClippingKey;
		}
	}

	[Field("SCNLightSpotInnerAngleKey", "SceneKit")]
	public static NSString SpotInnerAngleKey
	{
		get
		{
			if (_SpotInnerAngleKey == null)
			{
				_SpotInnerAngleKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightSpotInnerAngleKey");
			}
			return _SpotInnerAngleKey;
		}
	}

	[Field("SCNLightSpotOuterAngleKey", "SceneKit")]
	public static NSString SpotOuterAngleKey
	{
		get
		{
			if (_SpotOuterAngleKey == null)
			{
				_SpotOuterAngleKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightSpotOuterAngleKey");
			}
			return _SpotOuterAngleKey;
		}
	}
}
