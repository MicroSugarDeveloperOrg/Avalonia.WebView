using ObjCRuntime;

namespace GameKit;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public enum GKTurnBasedExchangeStatus : sbyte
{
	Unknown,
	Active,
	Complete,
	Resolved,
	Canceled
}
