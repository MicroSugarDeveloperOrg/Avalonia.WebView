using ObjCRuntime;

internal sealed class MacAttribute : IntroducedAttribute
{
    public MacAttribute(byte major, byte minor)
        : base(PlatformName.MacOSX, major, minor)
    {
    }

    [Obsolete("Use the overload that takes '(major, minor)', since macOS is always 64-bit.")]
    public MacAttribute(byte major, byte minor, bool onlyOn64 = false)
        : base(PlatformName.MacOSX, major, minor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
    {
    }

    public MacAttribute(byte major, byte minor, byte subminor)
        : base(PlatformName.MacOSX, major, minor, subminor)
    {
    }

    [Obsolete("Use the overload that takes '(major, minor, subminor)', since macOS is always 64-bit.")]
    public MacAttribute(byte major, byte minor, byte subminor, bool onlyOn64)
        : base(PlatformName.MacOSX, major, minor, subminor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
    {
    }

    public MacAttribute(byte major, byte minor, byte subminor, PlatformArchitecture arch)
        : base(PlatformName.MacOSX, major, minor, subminor, arch)
    {
    }
}
