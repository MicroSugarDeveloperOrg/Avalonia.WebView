namespace Registrar;

internal enum Trampoline
{
    None,
    Normal,
    Stret,
    Single,
    Double,
    Release,
    Retain,
    Static,
    StaticStret,
    StaticSingle,
    StaticDouble,
    Constructor,
    Long,
    StaticLong,
    X86_DoubleABI_StaticStretTrampoline,
    X86_DoubleABI_StretTrampoline,
    CopyWithZone1,
    CopyWithZone2,
    GetGCHandle,
    SetGCHandle,
    GetFlags,
    SetFlags
}