using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "NSItemProviderReading", WrapperType = typeof(NSItemProviderReadingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = true, Name = "GetObject", Selector = "objectWithItemProviderData:typeIdentifier:error:", ReturnType = typeof(INSItemProviderReading), ParameterType = new Type[]
{
    typeof(NSData),
    typeof(string),
    typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = true, Name = "ReadableTypeIdentifiers", Selector = "readableTypeIdentifiersForItemProvider", PropertyType = typeof(string[]), GetterSelector = "readableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface INSItemProviderReading : INativeObject, IDisposable
{
}

