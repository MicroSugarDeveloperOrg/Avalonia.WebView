using ObjCRuntime;

namespace ModelIO;

[Native]
public enum MDLGeometryType : long
{
	Points,
	Lines,
	Triangles,
	TriangleStrips,
	Quads,
	VariableTopology
}
