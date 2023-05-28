using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSHttpCookieAcceptPolicy : ulong
{
	Always,
	Never,
	OnlyFromMainDocumentDomain
}
