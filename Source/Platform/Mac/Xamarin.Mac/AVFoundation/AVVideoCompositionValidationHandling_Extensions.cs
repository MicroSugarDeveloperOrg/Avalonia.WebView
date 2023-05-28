using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVVideoCompositionValidationHandling_Extensions
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldContinueValidatingAfterFindingInvalidValueForKey(this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, string key)
	{
		if (videoComposition == null)
		{
			throw new ArgumentNullException("videoComposition");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:"), videoComposition.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldContinueValidatingAfterFindingEmptyTimeRange(this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, CMTimeRange timeRange)
	{
		if (videoComposition == null)
		{
			throw new ArgumentNullException("videoComposition");
		}
		return Messaging.bool_objc_msgSend_IntPtr_CMTimeRange(This.Handle, Selector.GetHandle("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:"), videoComposition.Handle, timeRange);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction(this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
	{
		if (videoComposition == null)
		{
			throw new ArgumentNullException("videoComposition");
		}
		if (videoCompositionInstruction == null)
		{
			throw new ArgumentNullException("videoCompositionInstruction");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:"), videoComposition.Handle, videoCompositionInstruction.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction(this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
	{
		if (videoComposition == null)
		{
			throw new ArgumentNullException("videoComposition");
		}
		if (videoCompositionInstruction == null)
		{
			throw new ArgumentNullException("videoCompositionInstruction");
		}
		if (layerInstruction == null)
		{
			throw new ArgumentNullException("layerInstruction");
		}
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:"), videoComposition.Handle, videoCompositionInstruction.Handle, layerInstruction.Handle, asset.Handle);
	}
}
