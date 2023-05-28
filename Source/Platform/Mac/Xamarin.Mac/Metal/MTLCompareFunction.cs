using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLCompareFunction : ulong
{
	Never,
	Less,
	Equal,
	LessEqual,
	Greater,
	NotEqual,
	GreaterEqual,
	Always
}
