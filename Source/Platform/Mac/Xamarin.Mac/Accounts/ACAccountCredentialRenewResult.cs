using ObjCRuntime;

namespace Accounts;

[Native]
public enum ACAccountCredentialRenewResult : long
{
	Renewed,
	Rejected,
	Failed
}
