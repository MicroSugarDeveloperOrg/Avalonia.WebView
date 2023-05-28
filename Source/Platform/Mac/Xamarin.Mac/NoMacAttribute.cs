using ObjCRuntime;

public sealed class NoMacAttribute : UnavailableAttribute
{
    public NoMacAttribute()
        : base(PlatformName.MacOSX)
    {
    }
}
