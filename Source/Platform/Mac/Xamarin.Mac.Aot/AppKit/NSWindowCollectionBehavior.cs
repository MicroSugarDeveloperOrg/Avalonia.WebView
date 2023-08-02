using Xamarin.Utiles;

namespace AppKit;

[Flags]
public enum NSWindowCollectionBehavior : ulong
{
    Default = 0uL,
    CanJoinAllSpaces = 1uL,
    MoveToActiveSpace = 2uL,
    Managed = 4uL,
    Transient = 8uL,
    Stationary = 0x10uL,
    ParticipatesInCycle = 0x20uL,
    IgnoresCycle = 0x40uL,
    FullScreenPrimary = 0x80uL,
    FullScreenAuxiliary = 0x100uL,
    [ElCapitan]
    FullScreenAllowsTiling = 0x800uL,
    [ElCapitan]
    FullScreenDisallowsTiling = 0x1000uL
}
