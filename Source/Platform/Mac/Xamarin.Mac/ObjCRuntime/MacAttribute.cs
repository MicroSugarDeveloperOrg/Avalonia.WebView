using System;

namespace ObjCRuntime;

[Obsolete("Use [Introduced|Deprecated|Obsoleted|Unavailable] attributes with PlatformName.")]
public sealed class MacAttribute : AvailabilityAttribute
{
	public MacAttribute(byte major, byte minor)
		: this(major, minor, 0, onlyOn64: false)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor, subminor)', since macOS is always 64-bit.")]
	public MacAttribute(byte major, byte minor, bool onlyOn64 = false)
		: this(major, minor, 0, onlyOn64)
	{
	}

	public MacAttribute(byte major, byte minor, PlatformArchitecture arch)
		: this(major, minor, 0, arch)
	{
	}

	public MacAttribute(byte major, byte minor, byte subminor)
		: this(major, minor, subminor, onlyOn64: false)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor, subminor)', since macOS is always 64-bit.")]
	public MacAttribute(byte major, byte minor, byte subminor, bool onlyOn64)
		: base((Platform)(((ulong)major << 48) | ((ulong)minor << 40) | ((ulong)subminor << 32) | (ulong)(onlyOn64 ? Platform.Mac_Arch64 : Platform.None)), Platform.None, Platform.None, Platform.None)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor, subminor)', since macOS is always 64-bit.")]
	public MacAttribute(byte major, byte minor, byte subminor, PlatformArchitecture arch)
		: base((Platform)(((ulong)major << 48) | ((ulong)minor << 40) | ((ulong)subminor << 32) | (ulong)((arch == PlatformArchitecture.Arch64) ? Platform.Mac_Arch64 : Platform.None)), Platform.None, Platform.None, Platform.None)
	{
	}
}
