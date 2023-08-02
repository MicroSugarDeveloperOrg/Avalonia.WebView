namespace WebKit;

[Flags]
public enum WKAudiovisualMediaTypes : ulong
{
    None = 0uL,
    Audio = 1uL,
    Video = 2uL,
    All = ulong.MaxValue
}