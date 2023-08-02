using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true)]
public abstract class AvailabilityBaseAttribute : Attribute
{
    public AvailabilityKind AvailabilityKind { get; private set; }

    public PlatformName Platform { get; private set; }

    public Version Version { get; private set; }

    public PlatformArchitecture Architecture { get; private set; }

    public string Message { get; private set; }

    internal AvailabilityBaseAttribute()
    {
    }

    internal AvailabilityBaseAttribute(AvailabilityKind availabilityKind, PlatformName platform, Version version, PlatformArchitecture architecture, string message)
    {
        AvailabilityKind = availabilityKind;
        Platform = platform;
        Version = version;
        Architecture = architecture;
        Message = message;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendFormat("[{0} ({1}.{2}", AvailabilityKind, "PlatformName", Platform);
        if (Version != null)
        {
            stringBuilder.AppendFormat(", {0},{1}", Version.Major, Version.Minor);
            if (Version.Build >= 0)
            {
                stringBuilder.AppendFormat(",{0}", Version.Build);
            }
        }
        if (Architecture != 0)
        {
            stringBuilder.AppendFormat(", {0}.{1}", "PlatformArchitecture", Architecture);
        }
        if (Message != null)
        {
            stringBuilder.AppendFormat(", message: \"{0}\"", Message.Replace("\"", "\"\""));
        }
        stringBuilder.Append(")]");
        return stringBuilder.ToString();
    }
}
