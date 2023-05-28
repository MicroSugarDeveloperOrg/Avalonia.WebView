using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNPhysicsTestKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackfaceCullingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CollisionBitMaskKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SearchModeKey;

	[Field("SCNPhysicsTestBackfaceCullingKey", "SceneKit")]
	public static NSString BackfaceCullingKey
	{
		get
		{
			if (_BackfaceCullingKey == null)
			{
				_BackfaceCullingKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsTestBackfaceCullingKey");
			}
			return _BackfaceCullingKey;
		}
	}

	[Field("SCNPhysicsTestCollisionBitMaskKey", "SceneKit")]
	public static NSString CollisionBitMaskKey
	{
		get
		{
			if (_CollisionBitMaskKey == null)
			{
				_CollisionBitMaskKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsTestCollisionBitMaskKey");
			}
			return _CollisionBitMaskKey;
		}
	}

	[Field("SCNPhysicsTestSearchModeKey", "SceneKit")]
	public static NSString SearchModeKey
	{
		get
		{
			if (_SearchModeKey == null)
			{
				_SearchModeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeKey");
			}
			return _SearchModeKey;
		}
	}
}
