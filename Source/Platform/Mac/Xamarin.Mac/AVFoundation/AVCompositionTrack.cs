using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCompositionTrack", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVCompositionTrack : AVAssetTrack
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescriptionReplacements = "formatDescriptionReplacements";

	private static readonly IntPtr selFormatDescriptionReplacementsHandle = Selector.GetHandle("formatDescriptionReplacements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegments = "segments";

	private static readonly IntPtr selSegmentsHandle = Selector.GetHandle("segments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCompositionTrack");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual AVCompositionTrackFormatDescriptionReplacement[] FormatDescriptionReplacements
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("formatDescriptionReplacements")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCompositionTrackFormatDescriptionReplacement>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionReplacementsHandle));
			}
			return NSArray.ArrayFromHandle<AVCompositionTrackFormatDescriptionReplacement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionReplacementsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVCompositionTrackSegment[] Segments
	{
		[Export("segments", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentsHandle));
			}
			return NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCompositionTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCompositionTrack(IntPtr handle)
		: base(handle)
	{
	}
}
