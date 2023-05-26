using ObjCRuntime;

public sealed class NoWatchAttribute : UnavailableAttribute
{
    public NoWatchAttribute()
        : base(PlatformName.WatchOS)
    {
    }
}