using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlSessionAuthChallengeDisposition : long
{
	UseCredential,
	PerformDefaultHandling,
	CancelAuthenticationChallenge,
	RejectProtectionSpace
}
