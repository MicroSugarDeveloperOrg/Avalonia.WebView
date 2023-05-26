using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;
public class IntroducedAttribute : AvailabilityBaseAttribute
{
    public IntroducedAttribute(PlatformName platform, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
        : base(AvailabilityKind.Introduced, platform, null, architecture, message)
    {
    }

    public IntroducedAttribute(PlatformName platform, int majorVersion, int minorVersion, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
        : base(AvailabilityKind.Introduced, platform, new Version(majorVersion, minorVersion), architecture, message)
    {
    }

    public IntroducedAttribute(PlatformName platform, int majorVersion, int minorVersion, int subminorVersion, PlatformArchitecture architecture = PlatformArchitecture.None, string message = null)
        : base(AvailabilityKind.Introduced, platform, new Version(majorVersion, minorVersion, subminorVersion), architecture, message)
    {
    }
}