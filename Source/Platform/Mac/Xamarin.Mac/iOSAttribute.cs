using System;
using ObjCRuntime;

internal sealed class iOSAttribute : IntroducedAttribute
{
	public iOSAttribute(byte major, byte minor)
		: base(PlatformName.iOS, major, minor)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor)', since iOS is always 64-bit.")]
	public iOSAttribute(byte major, byte minor, bool onlyOn64 = false)
		: base(PlatformName.iOS, major, minor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
	{
	}

	public iOSAttribute(byte major, byte minor, byte subminor)
		: base(PlatformName.iOS, major, minor, subminor)
	{
	}

	[Obsolete("Use the overload that takes '(major, minor, subminor)', since iOS is always 64-bit.")]
	public iOSAttribute(byte major, byte minor, byte subminor, bool onlyOn64)
		: base(PlatformName.iOS, major, minor, subminor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
	{
	}
}
