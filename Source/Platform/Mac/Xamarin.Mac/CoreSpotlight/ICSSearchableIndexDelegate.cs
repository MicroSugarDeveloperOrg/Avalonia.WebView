using System;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "CSSearchableIndexDelegate", WrapperType = typeof(CSSearchableIndexDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReindexAllSearchableItems", Selector = "searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:", ParameterType = new Type[]
{
	typeof(CSSearchableIndex),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReindexSearchableItems", Selector = "searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:", ParameterType = new Type[]
{
	typeof(CSSearchableIndex),
	typeof(string[]),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidThrottle", Selector = "searchableIndexDidThrottle:", ParameterType = new Type[] { typeof(CSSearchableIndex) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishThrottle", Selector = "searchableIndexDidFinishThrottle:", ParameterType = new Type[] { typeof(CSSearchableIndex) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetData", Selector = "dataForSearchableIndex:itemIdentifier:typeIdentifier:error:", ReturnType = typeof(NSData), ParameterType = new Type[]
{
	typeof(CSSearchableIndex),
	typeof(string),
	typeof(string),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFileUrl", Selector = "fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:", ReturnType = typeof(NSUrl), ParameterType = new Type[]
{
	typeof(CSSearchableIndex),
	typeof(string),
	typeof(string),
	typeof(bool),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false, true })]
public interface ICSSearchableIndexDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
	[Preserve(Conditional = true)]
	void ReindexAllSearchableItems(CSSearchableIndex searchableIndex, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
	[Preserve(Conditional = true)]
	void ReindexSearchableItems(CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler);
}
