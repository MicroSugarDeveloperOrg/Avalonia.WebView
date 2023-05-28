using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFileProviderChangeObserver", WrapperType = typeof(NSFileProviderChangeObserverWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateItems", Selector = "didUpdateItems:", ParameterType = new Type[] { typeof(INSFileProviderItem[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDeleteItems", Selector = "didDeleteItemsWithIdentifiers:", ParameterType = new Type[] { typeof(string[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumeratingChanges", Selector = "finishEnumeratingChangesUpToSyncAnchor:moreComing:", ParameterType = new Type[]
{
	typeof(NSData),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumerating", Selector = "finishEnumeratingWithError:", ParameterType = new Type[] { typeof(NSError) }, ParameterByRef = new bool[] { false })]
public interface INSFileProviderChangeObserver : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("didUpdateItems:")]
	[Preserve(Conditional = true)]
	void DidUpdateItems(INSFileProviderItem[] updatedItems);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("didDeleteItemsWithIdentifiers:")]
	[Preserve(Conditional = true)]
	void DidDeleteItems(string[] deletedItemIdentifiers);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishEnumeratingChangesUpToSyncAnchor:moreComing:")]
	[Preserve(Conditional = true)]
	void FinishEnumeratingChanges(NSData anchor, bool moreComing);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishEnumeratingWithError:")]
	[Preserve(Conditional = true)]
	void FinishEnumerating(NSError error);
}
