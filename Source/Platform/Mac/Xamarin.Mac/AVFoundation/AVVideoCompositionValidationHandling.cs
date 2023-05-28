using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVVideoCompositionValidationHandling", false)]
[Model]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVVideoCompositionValidationHandling : NSObject, IAVVideoCompositionValidationHandling, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVVideoCompositionValidationHandling(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVVideoCompositionValidationHandling(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldContinueValidatingAfterFindingEmptyTimeRange(AVVideoComposition videoComposition, CMTimeRange timeRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction(AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction(AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldContinueValidatingAfterFindingInvalidValueForKey(AVVideoComposition videoComposition, string key)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
