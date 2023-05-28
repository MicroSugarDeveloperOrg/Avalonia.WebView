namespace ObjCRuntime;

public class UnavailableAttribute : AvailabilityBaseAttribute
{
	public UnavailableAttribute(PlatformName platform, PlatformArchitecture architecture = PlatformArchitecture.All, string message = null)
		: base(AvailabilityKind.Unavailable, platform, null, architecture, message)
	{
	}
}
