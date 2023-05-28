using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSRequestUserAttentionType : ulong
{
	CriticalRequest = 0uL,
	InformationalRequest = 10uL
}
