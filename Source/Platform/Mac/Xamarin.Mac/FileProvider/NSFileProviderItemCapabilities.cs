using ObjCRuntime;

namespace FileProvider;


[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum NSFileProviderItemCapabilities : ulong
{
    Reading = 1uL,
    Writing = 2uL,
    Reparenting = 4uL,
    Renaming = 8uL,
    Trashing = 0x10uL,
    Deleting = 0x20uL,
    AddingSubItems = 2uL,
    ContentEnumerating = 1uL,
    All = 0x3FuL
}
