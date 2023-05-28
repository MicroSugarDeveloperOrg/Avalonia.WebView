using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNPhysicsShapeOptionsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CollisionMargin;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeepAsCompound;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Scale;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type;

	[Field("SCNPhysicsShapeOptionCollisionMargin", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString CollisionMargin
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CollisionMargin == null)
			{
				_CollisionMargin = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeOptionCollisionMargin");
			}
			return _CollisionMargin;
		}
	}

	[Field("SCNPhysicsShapeKeepAsCompoundKey", "SceneKit")]
	public static NSString KeepAsCompound
	{
		get
		{
			if (_KeepAsCompound == null)
			{
				_KeepAsCompound = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeKeepAsCompoundKey");
			}
			return _KeepAsCompound;
		}
	}

	[Field("SCNPhysicsShapeScaleKey", "SceneKit")]
	public static NSString Scale
	{
		get
		{
			if (_Scale == null)
			{
				_Scale = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeScaleKey");
			}
			return _Scale;
		}
	}

	[Field("SCNPhysicsShapeTypeKey", "SceneKit")]
	public static NSString Type
	{
		get
		{
			if (_Type == null)
			{
				_Type = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeKey");
			}
			return _Type;
		}
	}
}
