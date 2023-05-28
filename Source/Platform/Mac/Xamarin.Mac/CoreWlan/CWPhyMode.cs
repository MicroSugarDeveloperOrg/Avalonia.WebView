using ObjCRuntime;

namespace CoreWlan;

[Native]
public enum CWPhyMode : ulong
{
	None,
	A,
	B,
	G,
	N,
	AC
}
