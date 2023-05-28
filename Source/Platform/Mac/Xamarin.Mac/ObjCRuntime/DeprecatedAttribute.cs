using System;

namespace ObjCRuntime;

public sealed class DeprecatedAttribute : AvailabilityBaseAttribute
{
	public DeprecatedAttribute(PlatformName platform, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
		: base(AvailabilityKind.Deprecated, platform, null, architecture, message)
	{
	}

	public DeprecatedAttribute(PlatformName platform, int majorVersion, int minorVersion, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
		: base(AvailabilityKind.Deprecated, platform, new Version(majorVersion, minorVersion), architecture, message)
	{
	}

	public DeprecatedAttribute(PlatformName platform, int majorVersion, int minorVersion, int subminorVersion, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
		: base(AvailabilityKind.Deprecated, platform, new Version(majorVersion, minorVersion, subminorVersion), architecture, message)
	{
	}
}
