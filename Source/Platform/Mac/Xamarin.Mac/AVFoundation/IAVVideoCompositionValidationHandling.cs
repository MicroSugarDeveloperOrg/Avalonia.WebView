using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVVideoCompositionValidationHandling", WrapperType = typeof(AVVideoCompositionValidationHandlingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingInvalidValueForKey", Selector = "videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVVideoComposition),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingEmptyTimeRange", Selector = "videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVVideoComposition),
	typeof(CMTimeRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction", Selector = "videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVVideoComposition),
	typeof(AVVideoCompositionInstruction)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction", Selector = "videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVVideoComposition),
	typeof(AVVideoCompositionInstruction),
	typeof(AVVideoCompositionLayerInstruction),
	typeof(AVAsset)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IAVVideoCompositionValidationHandling : INativeObject, IDisposable
{
}
