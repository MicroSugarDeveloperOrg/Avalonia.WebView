using System;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "QLPreviewingController", WrapperType = typeof(QLPreviewingControllerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PreparePreviewOfSearchableItem", Selector = "preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:", ParameterType = new Type[]
{
	typeof(string),
	typeof(string),
	typeof(Action<NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity1V11)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreparePreviewOfFile", Selector = "preparePreviewOfFileAtURL:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(Action<NSError>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V11)
})]
public interface IQLPreviewingController : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:")]
	[Preserve(Conditional = true)]
	void PreparePreviewOfSearchableItem(string identifier, string queryString, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> ItemLoadingHandler);
}
