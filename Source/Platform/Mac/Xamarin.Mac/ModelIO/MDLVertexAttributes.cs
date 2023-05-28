using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public static class MDLVertexAttributes
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Anisotropy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Binormal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Bitangent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Color;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EdgeCrease;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JointIndices;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JointWeights;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Normal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OcclusionValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Position;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadingBasisU;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadingBasisV;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubdivisionStencil;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Tangent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextureCoordinate;

	[Field("MDLVertexAttributeAnisotropy", "ModelIO")]
	public static NSString Anisotropy
	{
		get
		{
			if (_Anisotropy == null)
			{
				_Anisotropy = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeAnisotropy");
			}
			return _Anisotropy;
		}
	}

	[Field("MDLVertexAttributeBinormal", "ModelIO")]
	public static NSString Binormal
	{
		get
		{
			if (_Binormal == null)
			{
				_Binormal = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeBinormal");
			}
			return _Binormal;
		}
	}

	[Field("MDLVertexAttributeBitangent", "ModelIO")]
	public static NSString Bitangent
	{
		get
		{
			if (_Bitangent == null)
			{
				_Bitangent = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeBitangent");
			}
			return _Bitangent;
		}
	}

	[Field("MDLVertexAttributeColor", "ModelIO")]
	public static NSString Color
	{
		get
		{
			if (_Color == null)
			{
				_Color = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeColor");
			}
			return _Color;
		}
	}

	[Field("MDLVertexAttributeEdgeCrease", "ModelIO")]
	public static NSString EdgeCrease
	{
		get
		{
			if (_EdgeCrease == null)
			{
				_EdgeCrease = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeEdgeCrease");
			}
			return _EdgeCrease;
		}
	}

	[Field("MDLVertexAttributeJointIndices", "ModelIO")]
	public static NSString JointIndices
	{
		get
		{
			if (_JointIndices == null)
			{
				_JointIndices = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeJointIndices");
			}
			return _JointIndices;
		}
	}

	[Field("MDLVertexAttributeJointWeights", "ModelIO")]
	public static NSString JointWeights
	{
		get
		{
			if (_JointWeights == null)
			{
				_JointWeights = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeJointWeights");
			}
			return _JointWeights;
		}
	}

	[Field("MDLVertexAttributeNormal", "ModelIO")]
	public static NSString Normal
	{
		get
		{
			if (_Normal == null)
			{
				_Normal = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeNormal");
			}
			return _Normal;
		}
	}

	[Field("MDLVertexAttributeOcclusionValue", "ModelIO")]
	public static NSString OcclusionValue
	{
		get
		{
			if (_OcclusionValue == null)
			{
				_OcclusionValue = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeOcclusionValue");
			}
			return _OcclusionValue;
		}
	}

	[Field("MDLVertexAttributePosition", "ModelIO")]
	public static NSString Position
	{
		get
		{
			if (_Position == null)
			{
				_Position = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributePosition");
			}
			return _Position;
		}
	}

	[Field("MDLVertexAttributeShadingBasisU", "ModelIO")]
	public static NSString ShadingBasisU
	{
		get
		{
			if (_ShadingBasisU == null)
			{
				_ShadingBasisU = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeShadingBasisU");
			}
			return _ShadingBasisU;
		}
	}

	[Field("MDLVertexAttributeShadingBasisV", "ModelIO")]
	public static NSString ShadingBasisV
	{
		get
		{
			if (_ShadingBasisV == null)
			{
				_ShadingBasisV = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeShadingBasisV");
			}
			return _ShadingBasisV;
		}
	}

	[Field("MDLVertexAttributeSubdivisionStencil", "ModelIO")]
	public static NSString SubdivisionStencil
	{
		get
		{
			if (_SubdivisionStencil == null)
			{
				_SubdivisionStencil = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeSubdivisionStencil");
			}
			return _SubdivisionStencil;
		}
	}

	[Field("MDLVertexAttributeTangent", "ModelIO")]
	public static NSString Tangent
	{
		get
		{
			if (_Tangent == null)
			{
				_Tangent = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeTangent");
			}
			return _Tangent;
		}
	}

	[Field("MDLVertexAttributeTextureCoordinate", "ModelIO")]
	public static NSString TextureCoordinate
	{
		get
		{
			if (_TextureCoordinate == null)
			{
				_TextureCoordinate = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "MDLVertexAttributeTextureCoordinate");
			}
			return _TextureCoordinate;
		}
	}
}
