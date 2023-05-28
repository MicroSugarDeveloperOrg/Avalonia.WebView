using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFilePromiseProviderDelegate", WrapperType = typeof(NSFilePromiseProviderDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFileNameForDestination", Selector = "filePromiseProvider:fileNameForType:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSFilePromiseProvider),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WritePromiseToUrl", Selector = "filePromiseProvider:writePromiseToURL:completionHandler:", ParameterType = new Type[]
{
	typeof(NSFilePromiseProvider),
	typeof(NSUrl),
	typeof(Action<NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity1V11)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOperationQueue", Selector = "operationQueueForFilePromiseProvider:", ReturnType = typeof(NSOperationQueue), ParameterType = new Type[] { typeof(NSFilePromiseProvider) }, ParameterByRef = new bool[] { false })]
public interface INSFilePromiseProviderDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("filePromiseProvider:fileNameForType:")]
	[Preserve(Conditional = true)]
	string GetFileNameForDestination(NSFilePromiseProvider filePromiseProvider, string fileType);
}
