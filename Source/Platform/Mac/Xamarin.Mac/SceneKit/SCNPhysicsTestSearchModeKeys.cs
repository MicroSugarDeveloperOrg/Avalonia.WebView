using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNPhysicsTestSearchModeKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _All;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Any;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Closest;

	[Field("SCNPhysicsTestSearchModeAll", "SceneKit")]
	public static NSString All
	{
		get
		{
			if (_All == null)
			{
				_All = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeAll");
			}
			return _All;
		}
	}

	[Field("SCNPhysicsTestSearchModeAny", "SceneKit")]
	public static NSString Any
	{
		get
		{
			if (_Any == null)
			{
				_Any = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeAny");
			}
			return _Any;
		}
	}

	[Field("SCNPhysicsTestSearchModeClosest", "SceneKit")]
	public static NSString Closest
	{
		get
		{
			if (_Closest == null)
			{
				_Closest = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeClosest");
			}
			return _Closest;
		}
	}
}
