using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSExtensionRequestHandling", WrapperType = typeof(NSExtensionRequestHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginRequestWithExtensionContext", Selector = "beginRequestWithExtensionContext:", ParameterType = new Type[] { typeof(NSExtensionContext) }, ParameterByRef = new bool[] { false })]
public interface INSExtensionRequestHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("beginRequestWithExtensionContext:")]
	[Preserve(Conditional = true)]
	void BeginRequestWithExtensionContext(NSExtensionContext context);
}
