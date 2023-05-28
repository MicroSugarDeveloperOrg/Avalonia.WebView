using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLPrimitiveType : ulong
{
	Point,
	Line,
	LineStrip,
	Triangle,
	TriangleStrip
}
