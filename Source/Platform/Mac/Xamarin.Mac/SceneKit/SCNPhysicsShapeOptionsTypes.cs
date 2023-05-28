using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNPhysicsShapeOptionsTypes
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoundingBox;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConcavePolyhedron;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConvexHull;

	[Field("SCNPhysicsShapeTypeBoundingBox", "SceneKit")]
	public static NSString BoundingBox
	{
		get
		{
			if (_BoundingBox == null)
			{
				_BoundingBox = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeBoundingBox");
			}
			return _BoundingBox;
		}
	}

	[Field("SCNPhysicsShapeTypeConcavePolyhedron", "SceneKit")]
	public static NSString ConcavePolyhedron
	{
		get
		{
			if (_ConcavePolyhedron == null)
			{
				_ConcavePolyhedron = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeConcavePolyhedron");
			}
			return _ConcavePolyhedron;
		}
	}

	[Field("SCNPhysicsShapeTypeConvexHull", "SceneKit")]
	public static NSString ConvexHull
	{
		get
		{
			if (_ConvexHull == null)
			{
				_ConvexHull = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPhysicsShapeTypeConvexHull");
			}
			return _ConvexHull;
		}
	}
}
