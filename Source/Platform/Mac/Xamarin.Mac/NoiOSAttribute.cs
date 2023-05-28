using ObjCRuntime;

public sealed class NoiOSAttribute : UnavailableAttribute
{
    public NoiOSAttribute()
        : base(PlatformName.iOS)
    {
    }
}
