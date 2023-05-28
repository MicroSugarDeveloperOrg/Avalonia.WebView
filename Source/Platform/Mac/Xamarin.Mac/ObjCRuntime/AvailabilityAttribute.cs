using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
[Obsolete("Use [Introduced|Deprecated|Obsoleted|Unavailable] attributes with PlatformName.")]
public class AvailabilityAttribute : Attribute
{
	private Platform introduced;

	private Platform deprecated;

	private Platform obsoleted;

	private Platform unavailable;

	public Platform Introduced
	{
		get
		{
			return introduced;
		}
		set
		{
			Check("Introduced", introduced, value);
			introduced = value;
		}
	}

	public Platform Deprecated
	{
		get
		{
			return deprecated;
		}
		set
		{
			Check("Deprecated", deprecated, value);
			deprecated = value;
		}
	}

	public Platform Obsoleted
	{
		get
		{
			return obsoleted;
		}
		set
		{
			Check("Obsoleted", obsoleted, value);
			obsoleted = value;
		}
	}

	public Platform Unavailable
	{
		get
		{
			return unavailable;
		}
		set
		{
			switch (value)
			{
			case Platform.None:
			case Platform.iOS_Version:
			case Platform.Mac_Version:
			case Platform.iOS_Version | Platform.Mac_Version:
				unavailable = value;
				break;
			default:
				throw new Exception("Unavailable applies to all platform versions; it should be one of Platform.None, Platform.Mac_Version, or Platform.iOS_Version");
			}
		}
	}

	public Platform IntroducedVersion => Introduced.ToVersion();

	public Platform IntroducedArchitecture => Introduced.ToArch();

	public Platform DeprecatedVersion => Deprecated.ToVersion();

	public Platform DeprecatedArchitecture => Deprecated.ToArch();

	public Platform ObsoletedVersion => Obsoleted.ToVersion();

	public Platform ObsoletedArchitecture => Obsoleted.ToArch();

	public string Message { get; set; }

	public bool AlwaysAvailable => introduced == Platform.None && deprecated == Platform.None && obsoleted == Platform.None && unavailable == Platform.None;

	public static AvailabilityAttribute Merge(IEnumerable<object> attrs)
	{
		AvailabilityAttribute availabilityAttribute = null;
		foreach (object attr in attrs)
		{
			if (!(attr is AvailabilityAttribute availabilityAttribute2))
			{
				continue;
			}
			if (availabilityAttribute == null)
			{
				availabilityAttribute = new AvailabilityAttribute();
			}
			availabilityAttribute.Introduced |= availabilityAttribute2.Introduced;
			availabilityAttribute.Obsoleted |= availabilityAttribute2.Obsoleted;
			availabilityAttribute.Deprecated |= availabilityAttribute2.Deprecated;
			availabilityAttribute.Unavailable |= availabilityAttribute2.Unavailable;
			if (!string.IsNullOrEmpty(availabilityAttribute2.Message))
			{
				if (!string.IsNullOrEmpty(availabilityAttribute.Message))
				{
					availabilityAttribute.Message += "; ";
				}
				availabilityAttribute.Message += availabilityAttribute2.Message;
			}
		}
		return availabilityAttribute;
	}

	public static AvailabilityAttribute Get(MemberInfo member)
	{
		return Merge(member.GetCustomAttributes(typeof(AvailabilityAttribute), inherit: true));
	}

	private static void Check(string property, Platform existing, Platform updated)
	{
		if (!updated.IsValid())
		{
			throw new Exception($"Platform setting deteremined invalid, cannot set '{property}' to '{updated}' as it is already set for the same platform to '{existing}'");
		}
	}

	public AvailabilityAttribute()
	{
	}

	public AvailabilityAttribute(Platform introduced, Platform deprecated = Platform.None, Platform obsoleted = Platform.None, Platform unavailable = Platform.None)
	{
		Introduced = introduced;
		Deprecated = deprecated;
		Obsoleted = obsoleted;
		Unavailable = unavailable;
	}

	public override string ToString()
	{
		if (AlwaysAvailable)
		{
			return "[Availability]";
		}
		StringBuilder builder = new StringBuilder();
		bool haveVersion = false;
		builder.Append("[Availability (");
		Action<string, Platform> action = delegate(string name, Platform platform)
		{
			if (platform != Platform.None)
			{
				if (haveVersion)
				{
					builder.Append(", ");
				}
				builder.AppendFormat("{0} = Platform.{1}", name, platform.ToString().Replace(", ", " | Platform."));
				haveVersion = true;
			}
		};
		action("Introduced", introduced);
		action("Deprecated", deprecated);
		action("Obsoleted", obsoleted);
		action("Unavailable", unavailable);
		if (Message != null)
		{
			builder.AppendFormat(", Message = \"{0}\"", Message.Replace("\"", "\\\""));
		}
		builder.Append(")]");
		return builder.ToString();
	}
}
