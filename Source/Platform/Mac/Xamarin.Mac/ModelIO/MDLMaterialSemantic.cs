using ObjCRuntime;

namespace ModelIO;

[Native]
public enum MDLMaterialSemantic : ulong
{
	BaseColor = 0uL,
	Subsurface = 1uL,
	Metallic = 2uL,
	Specular = 3uL,
	SpecularExponent = 4uL,
	SpecularTint = 5uL,
	Roughness = 6uL,
	Anisotropic = 7uL,
	AnisotropicRotation = 8uL,
	Sheen = 9uL,
	SheenTint = 10uL,
	Clearcoat = 11uL,
	ClearcoatGloss = 12uL,
	Emission = 13uL,
	Bump = 14uL,
	Opacity = 15uL,
	InterfaceIndexOfRefraction = 16uL,
	MaterialIndexOfRefraction = 17uL,
	ObjectSpaceNormal = 18uL,
	TangentSpaceNormal = 19uL,
	Displacement = 20uL,
	DisplacementScale = 21uL,
	AmbientOcclusion = 22uL,
	AmbientOcclusionScale = 23uL,
	None = 32768uL,
	UserDefined = 32769uL
}
