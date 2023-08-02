namespace Xamarin.Utiles;
[Flags]
public enum PlatformArchitecture : byte
{
    None = 0,
    Arch32 = 1,
    Arch64 = 2,
    All = byte.MaxValue
}
