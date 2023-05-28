using ObjCRuntime;

namespace Security;

[Watch(6, 0)]
[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
public enum TlsCipherSuiteGroup : ushort
{
	Default,
	Compatibility,
	Legacy,
	Ats,
	AtsCompatibility
}
