using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFileProviderEnumerationObserver", WrapperType = typeof(NSFileProviderEnumerationObserverWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidEnumerateItems", Selector = "didEnumerateItems:", ParameterType = new Type[] { typeof(INSFileProviderItem[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumerating", Selector = "finishEnumeratingUpToPage:", ParameterType = new Type[] { typeof(NSData) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumerating", Selector = "finishEnumeratingWithError:", ParameterType = new Type[] { typeof(NSError) }, ParameterByRef = new bool[] { false })]
public interface INSFileProviderEnumerationObserver : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("didEnumerateItems:")]
	[Preserve(Conditional = true)]
	void DidEnumerateItems(INSFileProviderItem[] updatedItems);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishEnumeratingUpToPage:")]
	[Preserve(Conditional = true)]
	void FinishEnumerating(NSData? upToPage);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishEnumeratingWithError:")]
	[Preserve(Conditional = true)]
	void FinishEnumerating(NSError error);
}
