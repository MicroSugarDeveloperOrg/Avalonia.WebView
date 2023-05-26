using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "NSItemProviderWriting", WrapperType = typeof(NSItemProviderWritingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemProviderVisibilityForTypeIdentifier", Selector = "itemProviderVisibilityForRepresentationWithTypeIdentifier:", ReturnType = typeof(NSItemProviderRepresentationVisibility), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadData", Selector = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:", ReturnType = typeof(NSProgress), ParameterType = new Type[]
{
    typeof(string),
    typeof(Action<NSData, NSError>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
    null,
    typeof(Trampolines.NIDActionArity2V3)
})]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = true, Name = "WritableTypeIdentifiers", Selector = "writableTypeIdentifiersForItemProvider", PropertyType = typeof(string[]), GetterSelector = "writableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "WritableTypeIdentifiersForItemProvider", Selector = "writableTypeIdentifiersForItemProvider", PropertyType = typeof(string[]), GetterSelector = "writableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface INSItemProviderWriting : INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
    [Preserve(Conditional = true)]
    NSProgress? LoadData(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler);
}
