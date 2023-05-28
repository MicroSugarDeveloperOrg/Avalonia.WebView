using System;

namespace ObjCRuntime;

[Obsolete("Use [Introduced|Deprecated|Obsoleted|Unavailable] attributes with PlatformName.")]
public sealed class iOSAttribute : AvailabilityAttribute
{
	public iOSAttribute(byte major, byte minor)
		: this(major, minor, 0)
	{
	}

	public iOSAttribute(byte major, byte minor, byte subminor)
		: base((Platform)(((ulong)major << 16) | ((ulong)minor << 8) | subminor), Platform.None, Platform.None, Platform.None)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor)', since iOS is always 64-bit.")]
	public iOSAttribute(byte major, byte minor, bool onlyOn64 = false)
		: this(major, minor, 0, onlyOn64)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor, subminor)', since iOS is always 64-bit.")]
	public iOSAttribute(byte major, byte minor, byte subminor, bool onlyOn64)
		: base((Platform)(((ulong)major << 48) | ((ulong)minor << 40) | ((ulong)subminor << 32) | (ulong)(onlyOn64 ? 33554432 : 0)), Platform.None, Platform.None, Platform.None)
	{
	}
}
