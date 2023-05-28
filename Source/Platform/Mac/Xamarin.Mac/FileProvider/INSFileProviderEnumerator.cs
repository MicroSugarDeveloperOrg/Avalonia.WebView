using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFileProviderEnumerator", WrapperType = typeof(NSFileProviderEnumeratorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidate")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateItems", Selector = "enumerateItemsForObserver:startingAtPage:", ParameterType = new Type[]
{
	typeof(INSFileProviderEnumerationObserver),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EnumerateChanges", Selector = "enumerateChangesForObserver:fromSyncAnchor:", ParameterType = new Type[]
{
	typeof(INSFileProviderChangeObserver),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CurrentSyncAnchor", Selector = "currentSyncAnchorWithCompletionHandler:", ParameterType = new Type[] { typeof(Action<NSData>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V28) })]
public interface INSFileProviderEnumerator : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("invalidate")]
	[Preserve(Conditional = true)]
	void Invalidate();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("enumerateItemsForObserver:startingAtPage:")]
	[Preserve(Conditional = true)]
	void EnumerateItems(INSFileProviderEnumerationObserver observer, NSData startPage);
}
