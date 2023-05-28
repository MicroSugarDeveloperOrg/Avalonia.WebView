using ObjCRuntime;

public sealed class NoTVAttribute : UnavailableAttribute
{
    public NoTVAttribute()
        : base(PlatformName.TvOS)
    {
    }
}
