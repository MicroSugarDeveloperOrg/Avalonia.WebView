using ObjCRuntime;

namespace ModelIO;

[Native]
public enum MDLMaterialPropertyType : ulong
{
	None,
	String,
	Url,
	Texture,
	Color,
	Float,
	Float2,
	Float3,
	Float4,
	Matrix44
}
