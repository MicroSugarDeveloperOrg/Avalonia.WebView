using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPlayerItemMetadataCollectorPushDelegate", WrapperType = typeof(AVPlayerItemMetadataCollectorPushDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCollectDateRange", Selector = "metadataCollector:didCollectDateRangeMetadataGroups:indexesOfNewGroups:indexesOfModifiedGroups:", ParameterType = new Type[]
{
	typeof(AVPlayerItemMetadataCollector),
	typeof(AVDateRangeMetadataGroup[]),
	typeof(NSIndexSet),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IAVPlayerItemMetadataCollectorPushDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("metadataCollector:didCollectDateRangeMetadataGroups:indexesOfNewGroups:indexesOfModifiedGroups:")]
	[Preserve(Conditional = true)]
	void DidCollectDateRange(AVPlayerItemMetadataCollector metadataCollector, AVDateRangeMetadataGroup[] metadataGroups, NSIndexSet indexesOfNewGroups, NSIndexSet indexesOfModifiedGroups);
}
