using System;

namespace ObjCRuntime;

public sealed class WatchAttribute : IntroducedAttribute
{
	public WatchAttribute(byte major, byte minor)
		: base(PlatformName.WatchOS, major, minor)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor)', since watchOS is never 64-bit.")]
	public WatchAttribute(byte major, byte minor, bool onlyOn64 = false)
		: base(PlatformName.WatchOS, major, minor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
	{
	}

	public WatchAttribute(byte major, byte minor, byte subminor)
		: base(PlatformName.WatchOS, major, minor, subminor)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor)', since watchOS is never 64-bit.")]
	public WatchAttribute(byte major, byte minor, byte subminor, bool onlyOn64)
		: base(PlatformName.WatchOS, major, minor, subminor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
	{
	}
}
