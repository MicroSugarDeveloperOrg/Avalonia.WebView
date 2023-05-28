using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableComposition", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMutableComposition : AVComposition
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMutableTrackWithMediaType_PreferredTrackID_ = "addMutableTrackWithMediaType:preferredTrackID:";

	private static readonly IntPtr selAddMutableTrackWithMediaType_PreferredTrackID_Handle = Selector.GetHandle("addMutableTrackWithMediaType:preferredTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComposition = "composition";

	private static readonly IntPtr selCompositionHandle = Selector.GetHandle("composition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionWithURLAssetInitializationOptions_ = "compositionWithURLAssetInitializationOptions:";

	private static readonly IntPtr selCompositionWithURLAssetInitializationOptions_Handle = Selector.GetHandle("compositionWithURLAssetInitializationOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertEmptyTimeRange_ = "insertEmptyTimeRange:";

	private static readonly IntPtr selInsertEmptyTimeRange_Handle = Selector.GetHandle("insertEmptyTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTimeRange_OfAsset_AtTime_Error_ = "insertTimeRange:ofAsset:atTime:error:";

	private static readonly IntPtr selInsertTimeRange_OfAsset_AtTime_Error_Handle = Selector.GetHandle("insertTimeRange:ofAsset:atTime:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableTrackCompatibleWithTrack_ = "mutableTrackCompatibleWithTrack:";

	private static readonly IntPtr selMutableTrackCompatibleWithTrack_Handle = Selector.GetHandle("mutableTrackCompatibleWithTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalSize = "naturalSize";

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTimeRange_ = "removeTimeRange:";

	private static readonly IntPtr selRemoveTimeRange_Handle = Selector.GetHandle("removeTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrack_ = "removeTrack:";

	private static readonly IntPtr selRemoveTrack_Handle = Selector.GetHandle("removeTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleTimeRange_ToDuration_ = "scaleTimeRange:toDuration:";

	private static readonly IntPtr selScaleTimeRange_ToDuration_Handle = Selector.GetHandle("scaleTimeRange:toDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNaturalSize_ = "setNaturalSize:";

	private static readonly IntPtr selSetNaturalSize_Handle = Selector.GetHandle("setNaturalSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableComposition");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CGSize NaturalSize
	{
		[Export("naturalSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
		[Export("setNaturalSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetNaturalSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetNaturalSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableComposition()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addMutableTrackWithMediaType:preferredTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMutableCompositionTrack? AddMutableTrack(string mediaType, int preferredTrackId)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVMutableCompositionTrack result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selAddMutableTrackWithMediaType_PreferredTrackID_Handle, arg, preferredTrackId)) : Runtime.GetNSObject<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSend_IntPtr_int(base.Handle, selAddMutableTrackWithMediaType_PreferredTrackID_Handle, arg, preferredTrackId)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("composition")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableComposition Create()
	{
		return Runtime.GetNSObject<AVMutableComposition>(Messaging.IntPtr_objc_msgSend(class_ptr, selCompositionHandle));
	}

	[Export("mutableTrackCompatibleWithTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMutableCompositionTrack? CreateMutableTrack(AVAssetTrack referenceTrack)
	{
		if (referenceTrack == null)
		{
			throw new ArgumentNullException("referenceTrack");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableTrackCompatibleWithTrack_Handle, referenceTrack.Handle));
		}
		return Runtime.GetNSObject<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableTrackCompatibleWithTrack_Handle, referenceTrack.Handle));
	}

	[Export("compositionWithURLAssetInitializationOptions:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableComposition FromOptions(NSDictionary<NSString, NSObject>? urlAssetInitializationOptions)
	{
		return Runtime.GetNSObject<AVMutableComposition>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionWithURLAssetInitializationOptions_Handle, urlAssetInitializationOptions?.Handle ?? IntPtr.Zero));
	}

	[Export("insertEmptyTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InserEmptyTimeRange(CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selInsertEmptyTimeRange_Handle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selInsertEmptyTimeRange_Handle, timeRange);
		}
	}

	[Export("insertTimeRange:ofAsset:atTime:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Insert(CMTimeRange insertTimeRange, AVAsset sourceAsset, CMTime atTime, out NSError error)
	{
		if (sourceAsset == null)
		{
			throw new ArgumentNullException("sourceAsset");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_ref_IntPtr(base.SuperHandle, selInsertTimeRange_OfAsset_AtTime_Error_Handle, insertTimeRange, sourceAsset.Handle, atTime, ref arg) : Messaging.bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_ref_IntPtr(base.Handle, selInsertTimeRange_OfAsset_AtTime_Error_Handle, insertTimeRange, sourceAsset.Handle, atTime, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTimeRange(CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selRemoveTimeRange_Handle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selRemoveTimeRange_Handle, timeRange);
		}
	}

	[Export("removeTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTrack(AVCompositionTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTrack_Handle, track.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTrack_Handle, track.Handle);
		}
	}

	[Export("scaleTimeRange:toDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScaleTimeRange(CMTimeRange timeRange, CMTime duration)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange_CMTime(base.Handle, selScaleTimeRange_ToDuration_Handle, timeRange, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange_CMTime(base.SuperHandle, selScaleTimeRange_ToDuration_Handle, timeRange, duration);
		}
	}
}
