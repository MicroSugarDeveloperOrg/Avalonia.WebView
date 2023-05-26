namespace ObjCRuntime;

public sealed class TVAttribute : IntroducedAttribute
{
    public TVAttribute(byte major, byte minor)
        : base(PlatformName.TvOS, major, minor)
    {
    }

    [Obsolete("Use the overload that takes '(major, minor)', since tvOS is always 64-bit.")]
    public TVAttribute(byte major, byte minor, bool onlyOn64 = false)
        : base(PlatformName.TvOS, major, minor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
    {
    }

    public TVAttribute(byte major, byte minor, byte subminor)
        : base(PlatformName.TvOS, major, minor, subminor)
    {
    }

    [Obsolete("Use the overload that takes '(major, minor, subminor)', since tvOS is always 64-bit.")]
    public TVAttribute(byte major, byte minor, byte subminor, bool onlyOn64)
        : base(PlatformName.TvOS, major, minor, subminor, onlyOn64 ? PlatformArchitecture.Arch64 : PlatformArchitecture.All)
    {
    }
}
