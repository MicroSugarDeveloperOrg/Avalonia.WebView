using Foundation;
using ObjCRuntime;
namespace AppKit;

[Protocol(Name = "NSValidatedUserInterfaceItem", WrapperType = typeof(NSValidatedUserInterfaceItemWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Action", Selector = "action", PropertyType = typeof(Selector), GetterSelector = "action", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Tag", Selector = "tag", PropertyType = typeof(nint), GetterSelector = "tag", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSValidatedUserInterfaceItem : INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    Selector? Action
    {
        [Export("action")]
        get;
    }

    [Preserve(Conditional = true)]
    long Tag
    {
        [Export("tag")]
        get;
    }
}
