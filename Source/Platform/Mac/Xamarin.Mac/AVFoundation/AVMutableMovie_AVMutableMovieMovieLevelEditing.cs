using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public static class AVMutableMovie_AVMutableMovieMovieLevelEditing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertEmptyTimeRange_ = "insertEmptyTimeRange:";

	private static readonly IntPtr selInsertEmptyTimeRange_Handle = Selector.GetHandle("insertEmptyTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTimeRange_OfAsset_AtTime_CopySampleData_Error_ = "insertTimeRange:ofAsset:atTime:copySampleData:error:";

	private static readonly IntPtr selInsertTimeRange_OfAsset_AtTime_CopySampleData_Error_Handle = Selector.GetHandle("insertTimeRange:ofAsset:atTime:copySampleData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTimeRange_ = "removeTimeRange:";

	private static readonly IntPtr selRemoveTimeRange_Handle = Selector.GetHandle("removeTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleTimeRange_ToDuration_ = "scaleTimeRange:toDuration:";

	private static readonly IntPtr selScaleTimeRange_ToDuration_Handle = Selector.GetHandle("scaleTimeRange:toDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableMovie");

	[Export("insertEmptyTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertEmptyTimeRange(this AVMutableMovie This, CMTimeRange timeRange)
	{
		Messaging.void_objc_msgSend_CMTimeRange(This.Handle, selInsertEmptyTimeRange_Handle, timeRange);
	}

	[Export("insertTimeRange:ofAsset:atTime:copySampleData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool InsertTimeRange(this AVMutableMovie This, CMTimeRange timeRange, AVAsset asset, CMTime startTime, bool copySampleData, out NSError? outError)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_bool_ref_IntPtr(This.Handle, selInsertTimeRange_OfAsset_AtTime_CopySampleData_Error_Handle, timeRange, asset.Handle, startTime, copySampleData, ref arg);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveTimeRange(this AVMutableMovie This, CMTimeRange timeRange)
	{
		Messaging.void_objc_msgSend_CMTimeRange(This.Handle, selRemoveTimeRange_Handle, timeRange);
	}

	[Export("scaleTimeRange:toDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScaleTimeRange(this AVMutableMovie This, CMTimeRange timeRange, CMTime duration)
	{
		Messaging.void_objc_msgSend_CMTimeRange_CMTime(This.Handle, selScaleTimeRange_ToDuration_Handle, timeRange, duration);
	}
}
