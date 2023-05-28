using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNGeometrySourceSemantic
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoneIndices;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoneWeights;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Color;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EdgeCrease;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Normal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Tangent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Texcoord;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Vertex;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VertexCrease;

	[Field("SCNGeometrySourceSemanticBoneIndices", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString BoneIndices
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_BoneIndices == null)
			{
				_BoneIndices = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticBoneIndices");
			}
			return _BoneIndices;
		}
	}

	[Field("SCNGeometrySourceSemanticBoneWeights", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString BoneWeights
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_BoneWeights == null)
			{
				_BoneWeights = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticBoneWeights");
			}
			return _BoneWeights;
		}
	}

	[Field("SCNGeometrySourceSemanticColor", "SceneKit")]
	public static NSString Color
	{
		get
		{
			if (_Color == null)
			{
				_Color = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticColor");
			}
			return _Color;
		}
	}

	[Field("SCNGeometrySourceSemanticEdgeCrease", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString EdgeCrease
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_EdgeCrease == null)
			{
				_EdgeCrease = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticEdgeCrease");
			}
			return _EdgeCrease;
		}
	}

	[Field("SCNGeometrySourceSemanticNormal", "SceneKit")]
	public static NSString Normal
	{
		get
		{
			if (_Normal == null)
			{
				_Normal = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticNormal");
			}
			return _Normal;
		}
	}

	[Field("SCNGeometrySourceSemanticTangent", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString Tangent
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Tangent == null)
			{
				_Tangent = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticTangent");
			}
			return _Tangent;
		}
	}

	[Field("SCNGeometrySourceSemanticTexcoord", "SceneKit")]
	public static NSString Texcoord
	{
		get
		{
			if (_Texcoord == null)
			{
				_Texcoord = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticTexcoord");
			}
			return _Texcoord;
		}
	}

	[Field("SCNGeometrySourceSemanticVertex", "SceneKit")]
	public static NSString Vertex
	{
		get
		{
			if (_Vertex == null)
			{
				_Vertex = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticVertex");
			}
			return _Vertex;
		}
	}

	[Field("SCNGeometrySourceSemanticVertexCrease", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString VertexCrease
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_VertexCrease == null)
			{
				_VertexCrease = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNGeometrySourceSemanticVertexCrease");
			}
			return _VertexCrease;
		}
	}
}
