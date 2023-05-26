using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCollectionLayoutEnvironment", WrapperType = typeof(NSCollectionLayoutEnvironmentWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Container", Selector = "container", PropertyType = typeof(INSCollectionLayoutContainer), GetterSelector = "container", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSCollectionLayoutEnvironment : INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    INSCollectionLayoutContainer Container
    {
        [Export("container")]
        get;
    }
}
