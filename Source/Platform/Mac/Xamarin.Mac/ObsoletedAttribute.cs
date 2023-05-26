using ObjCRuntime;

public sealed class ObsoletedAttribute : AvailabilityBaseAttribute
{
    public ObsoletedAttribute(PlatformName platform, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
        : base(AvailabilityKind.Obsoleted, platform, null, architecture, message)
    {
    }

    public ObsoletedAttribute(PlatformName platform, int majorVersion, int minorVersion, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
        : base(AvailabilityKind.Obsoleted, platform, new Version(majorVersion, minorVersion), architecture, message)
    {
    }

    public ObsoletedAttribute(PlatformName platform, int majorVersion, int minorVersion, int subminorVersion, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
        : base(AvailabilityKind.Obsoleted, platform, new Version(majorVersion, minorVersion, subminorVersion), architecture, message)
    {
    }
}
