using System;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVQueuedSampleBufferRendering", WrapperType = typeof(AVQueuedSampleBufferRenderingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Enqueue", Selector = "enqueueSampleBuffer:", ParameterType = new Type[] { typeof(CMSampleBuffer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Flush", Selector = "flush")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestMediaData", Selector = "requestMediaDataWhenReadyOnQueue:usingBlock:", ParameterType = new Type[]
{
	typeof(DispatchQueue),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopRequestingMediaData", Selector = "stopRequestingMediaData")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Timebase", Selector = "timebase", PropertyType = typeof(CMTimebase), GetterSelector = "timebase", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReadyForMoreMediaData", Selector = "readyForMoreMediaData", PropertyType = typeof(bool), GetterSelector = "isReadyForMoreMediaData", ArgumentSemantic = ArgumentSemantic.None)]
public interface IAVQueuedSampleBufferRendering : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CMTimebase Timebase
	{
		[Export("timebase", ArgumentSemantic.Retain)]
		get;
	}

	[Preserve(Conditional = true)]
	bool ReadyForMoreMediaData
	{
		[Export("isReadyForMoreMediaData")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("enqueueSampleBuffer:")]
	[Preserve(Conditional = true)]
	void Enqueue(CMSampleBuffer sampleBuffer);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("flush")]
	[Preserve(Conditional = true)]
	void Flush();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("requestMediaDataWhenReadyOnQueue:usingBlock:")]
	[Preserve(Conditional = true)]
	void RequestMediaData(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("stopRequestingMediaData")]
	[Preserve(Conditional = true)]
	void StopRequestingMediaData();
}
