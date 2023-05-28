using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVSampleCursor", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVSampleCursor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComparePositionInDecodeOrderWithPositionOfCursor_ = "comparePositionInDecodeOrderWithPositionOfCursor:";

	private static readonly IntPtr selComparePositionInDecodeOrderWithPositionOfCursor_Handle = Selector.GetHandle("comparePositionInDecodeOrderWithPositionOfCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyCurrentSampleFormatDescription = "copyCurrentSampleFormatDescription";

	private static readonly IntPtr selCopyCurrentSampleFormatDescriptionHandle = Selector.GetHandle("copyCurrentSampleFormatDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentChunkInfo = "currentChunkInfo";

	private static readonly IntPtr selCurrentChunkInfoHandle = Selector.GetHandle("currentChunkInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentChunkStorageRange = "currentChunkStorageRange";

	private static readonly IntPtr selCurrentChunkStorageRangeHandle = Selector.GetHandle("currentChunkStorageRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentChunkStorageURL = "currentChunkStorageURL";

	private static readonly IntPtr selCurrentChunkStorageURLHandle = Selector.GetHandle("currentChunkStorageURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSampleAudioDependencyInfo = "currentSampleAudioDependencyInfo";

	private static readonly IntPtr selCurrentSampleAudioDependencyInfoHandle = Selector.GetHandle("currentSampleAudioDependencyInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSampleDependencyInfo = "currentSampleDependencyInfo";

	private static readonly IntPtr selCurrentSampleDependencyInfoHandle = Selector.GetHandle("currentSampleDependencyInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSampleDuration = "currentSampleDuration";

	private static readonly IntPtr selCurrentSampleDurationHandle = Selector.GetHandle("currentSampleDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSampleIndexInChunk = "currentSampleIndexInChunk";

	private static readonly IntPtr selCurrentSampleIndexInChunkHandle = Selector.GetHandle("currentSampleIndexInChunk");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSampleStorageRange = "currentSampleStorageRange";

	private static readonly IntPtr selCurrentSampleStorageRangeHandle = Selector.GetHandle("currentSampleStorageRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentSampleSyncInfo = "currentSampleSyncInfo";

	private static readonly IntPtr selCurrentSampleSyncInfoHandle = Selector.GetHandle("currentSampleSyncInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeTimeStamp = "decodeTimeStamp";

	private static readonly IntPtr selDecodeTimeStampHandle = Selector.GetHandle("decodeTimeStamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationTimeStamp = "presentationTimeStamp";

	private static readonly IntPtr selPresentationTimeStampHandle = Selector.GetHandle("presentationTimeStamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplesRequiredForDecoderRefresh = "samplesRequiredForDecoderRefresh";

	private static readonly IntPtr selSamplesRequiredForDecoderRefreshHandle = Selector.GetHandle("samplesRequiredForDecoderRefresh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor_ = "samplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor:";

	private static readonly IntPtr selSamplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor_Handle = Selector.GetHandle("samplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor_ = "samplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor:";

	private static readonly IntPtr selSamplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor_Handle = Selector.GetHandle("samplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepByDecodeTime_WasPinned_ = "stepByDecodeTime:wasPinned:";

	private static readonly IntPtr selStepByDecodeTime_WasPinned_Handle = Selector.GetHandle("stepByDecodeTime:wasPinned:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepByPresentationTime_WasPinned_ = "stepByPresentationTime:wasPinned:";

	private static readonly IntPtr selStepByPresentationTime_WasPinned_Handle = Selector.GetHandle("stepByPresentationTime:wasPinned:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepInDecodeOrderByCount_ = "stepInDecodeOrderByCount:";

	private static readonly IntPtr selStepInDecodeOrderByCount_Handle = Selector.GetHandle("stepInDecodeOrderByCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepInPresentationOrderByCount_ = "stepInPresentationOrderByCount:";

	private static readonly IntPtr selStepInPresentationOrderByCount_Handle = Selector.GetHandle("stepInPresentationOrderByCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSampleCursor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursorChunkInfo CurrentChunkInfo
	{
		[Export("currentChunkInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVSampleCursorChunkInfo_objc_msgSend(base.Handle, selCurrentChunkInfoHandle);
			}
			return Messaging.AVSampleCursorChunkInfo_objc_msgSendSuper(base.SuperHandle, selCurrentChunkInfoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursorStorageRange CurrentChunkStorageRange
	{
		[Export("currentChunkStorageRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVSampleCursorStorageRange_objc_msgSend(base.Handle, selCurrentChunkStorageRangeHandle);
			}
			return Messaging.AVSampleCursorStorageRange_objc_msgSendSuper(base.SuperHandle, selCurrentChunkStorageRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? CurrentChunkStorageUrl
	{
		[Export("currentChunkStorageURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentChunkStorageURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentChunkStorageURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual AVSampleCursorAudioDependencyInfo CurrentSampleAudioDependencyInfo
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("currentSampleAudioDependencyInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVSampleCursorAudioDependencyInfo_objc_msgSend(base.Handle, selCurrentSampleAudioDependencyInfoHandle);
			}
			return Messaging.AVSampleCursorAudioDependencyInfo_objc_msgSendSuper(base.SuperHandle, selCurrentSampleAudioDependencyInfoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursorSyncInfo CurrentSampleDependencyInfo
	{
		[Export("currentSampleDependencyInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVSampleCursorSyncInfo_objc_msgSend(base.Handle, selCurrentSampleDependencyInfoHandle);
			}
			return Messaging.AVSampleCursorSyncInfo_objc_msgSendSuper(base.SuperHandle, selCurrentSampleDependencyInfoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime CurrentSampleDuration
	{
		[Export("currentSampleDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCurrentSampleDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCurrentSampleDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long CurrentSampleIndexInChunk
	{
		[Export("currentSampleIndexInChunk")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selCurrentSampleIndexInChunkHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCurrentSampleIndexInChunkHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursorStorageRange CurrentSampleStorageRange
	{
		[Export("currentSampleStorageRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVSampleCursorStorageRange_objc_msgSend(base.Handle, selCurrentSampleStorageRangeHandle);
			}
			return Messaging.AVSampleCursorStorageRange_objc_msgSendSuper(base.SuperHandle, selCurrentSampleStorageRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursorSyncInfo CurrentSampleSyncInfo
	{
		[Export("currentSampleSyncInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVSampleCursorSyncInfo_objc_msgSend(base.Handle, selCurrentSampleSyncInfoHandle);
			}
			return Messaging.AVSampleCursorSyncInfo_objc_msgSendSuper(base.SuperHandle, selCurrentSampleSyncInfoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime DecodeTimeStamp
	{
		[Export("decodeTimeStamp")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDecodeTimeStampHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDecodeTimeStampHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime PresentationTimeStamp
	{
		[Export("presentationTimeStamp")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selPresentationTimeStampHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPresentationTimeStampHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nint SamplesRequiredForDecoderRefresh
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("samplesRequiredForDecoderRefresh")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSamplesRequiredForDecoderRefreshHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSamplesRequiredForDecoderRefreshHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSampleCursor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSampleCursor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("comparePositionInDecodeOrderWithPositionOfCursor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult ComparePositionInDecodeOrder(AVSampleCursor positionOfCursor)
	{
		if (positionOfCursor == null)
		{
			throw new ArgumentNullException("positionOfCursor");
		}
		if (base.IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selComparePositionInDecodeOrderWithPositionOfCursor_Handle, positionOfCursor.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selComparePositionInDecodeOrderWithPositionOfCursor_Handle, positionOfCursor.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("copyCurrentSampleFormatDescription")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual CMFormatDescription CopyCurrentSampleFormatDescription()
	{
		CMFormatDescription cMFormatDescription = ((!base.IsDirectBinding) ? CMFormatDescription.Create(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCopyCurrentSampleFormatDescriptionHandle)) : CMFormatDescription.Create(Messaging.IntPtr_objc_msgSend(base.Handle, selCopyCurrentSampleFormatDescriptionHandle)));
		if (cMFormatDescription != null)
		{
			Messaging.void_objc_msgSend(cMFormatDescription.Handle, Selector.GetHandle("release"));
		}
		return cMFormatDescription;
	}

	[Export("samplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SamplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThan(AVSampleCursor positionOfCursor)
	{
		if (positionOfCursor == null)
		{
			throw new ArgumentNullException("positionOfCursor");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSamplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor_Handle, positionOfCursor.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSamplesWithEarlierDecodeTimeStampsMayHaveLaterPresentationTimeStampsThanCursor_Handle, positionOfCursor.Handle);
	}

	[Export("samplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SamplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThan(AVSampleCursor positionOfCursor)
	{
		if (positionOfCursor == null)
		{
			throw new ArgumentNullException("positionOfCursor");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSamplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor_Handle, positionOfCursor.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSamplesWithLaterDecodeTimeStampsMayHaveEarlierPresentationTimeStampsThanCursor_Handle, positionOfCursor.Handle);
	}

	[Export("stepByDecodeTime:wasPinned:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime StepByDecodeTime(CMTime deltaDecodeTime, out bool wasPinned)
	{
		CMTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_CMTime_out_Boolean(out retval, base.Handle, selStepByDecodeTime_WasPinned_Handle, deltaDecodeTime, out wasPinned);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_CMTime_out_Boolean(out retval, base.SuperHandle, selStepByDecodeTime_WasPinned_Handle, deltaDecodeTime, out wasPinned);
		}
		return retval;
	}

	[Export("stepByPresentationTime:wasPinned:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime StepByPresentationTime(CMTime deltaPresentationTime, out bool wasPinned)
	{
		CMTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_CMTime_out_Boolean(out retval, base.Handle, selStepByPresentationTime_WasPinned_Handle, deltaPresentationTime, out wasPinned);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_CMTime_out_Boolean(out retval, base.SuperHandle, selStepByPresentationTime_WasPinned_Handle, deltaPresentationTime, out wasPinned);
		}
		return retval;
	}

	[Export("stepInDecodeOrderByCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long StepInDecodeOrder(long stepCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selStepInDecodeOrderByCount_Handle, stepCount);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selStepInDecodeOrderByCount_Handle, stepCount);
	}

	[Export("stepInPresentationOrderByCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long StepInPresentationOrder(long stepCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selStepInPresentationOrderByCount_Handle, stepCount);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selStepInPresentationOrderByCount_Handle, stepCount);
	}
}
