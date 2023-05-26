using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlSessionResponseDisposition : long
{
	Cancel,
	Allow,
	BecomeDownload,
	BecomeStream
}
