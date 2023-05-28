using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlCredentialPersistence : ulong
{
	None,
	ForSession,
	Permanent,
	Synchronizable
}
