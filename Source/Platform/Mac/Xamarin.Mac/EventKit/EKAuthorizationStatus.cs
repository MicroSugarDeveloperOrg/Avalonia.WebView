using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKAuthorizationStatus : long
{
	NotDetermined,
	Restricted,
	Denied,
	Authorized
}
