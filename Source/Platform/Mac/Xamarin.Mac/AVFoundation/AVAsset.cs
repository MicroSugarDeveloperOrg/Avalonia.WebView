using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAsset", true)]
public class AVAsset : NSObject
{
	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selPreferredRateHandle = Selector.GetHandle("preferredRate");

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	private static readonly IntPtr selProvidesPreciseDurationAndTimingHandle = Selector.GetHandle("providesPreciseDurationAndTiming");

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	private static readonly IntPtr selLyricsHandle = Selector.GetHandle("lyrics");

	private static readonly IntPtr selCommonMetadataHandle = Selector.GetHandle("commonMetadata");

	private static readonly IntPtr selAvailableMetadataFormatsHandle = Selector.GetHandle("availableMetadataFormats");

	private static readonly IntPtr selHasProtectedContentHandle = Selector.GetHandle("hasProtectedContent");

	private static readonly IntPtr selAvailableChapterLocalesHandle = Selector.GetHandle("availableChapterLocales");

	private static readonly IntPtr selIsPlayableHandle = Selector.GetHandle("isPlayable");

	private static readonly IntPtr selIsExportableHandle = Selector.GetHandle("isExportable");

	private static readonly IntPtr selIsReadableHandle = Selector.GetHandle("isReadable");

	private static readonly IntPtr selIsComposableHandle = Selector.GetHandle("isComposable");

	private static readonly IntPtr selReferenceRestrictionsHandle = Selector.GetHandle("referenceRestrictions");

	private static readonly IntPtr selCancelLoadingHandle = Selector.GetHandle("cancelLoading");

	private static readonly IntPtr selTrackWithTrackID_Handle = Selector.GetHandle("trackWithTrackID:");

	private static readonly IntPtr selTracksWithMediaType_Handle = Selector.GetHandle("tracksWithMediaType:");

	private static readonly IntPtr selTracksWithMediaCharacteristic_Handle = Selector.GetHandle("tracksWithMediaCharacteristic:");

	private static readonly IntPtr selMetadataForFormat_Handle = Selector.GetHandle("metadataForFormat:");

	private static readonly IntPtr selChapterMetadataGroupsWithTitleLocaleContainingItemsWithCommonKeys_Handle = Selector.GetHandle("chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:");

	private static readonly IntPtr selAssetWithURL_Handle = Selector.GetHandle("assetWithURL:");

	private static readonly IntPtr selStatusOfValueForKeyError_Handle = Selector.GetHandle("statusOfValueForKey:error:");

	private static readonly IntPtr selLoadValuesAsynchronouslyForKeysCompletionHandler_Handle = Selector.GetHandle("loadValuesAsynchronouslyForKeys:completionHandler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAsset");

	private object __mt_Tracks_var;

	private object __mt_CommonMetadata_var;

	private object __mt_AvailableChapterLocales_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
	}

	public virtual float PreferredRate
	{
		[Export("preferredRate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredRateHandle);
		}
	}

	public virtual float PreferredVolume
	{
		[Export("preferredVolume")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
	}

	public virtual CGAffineTransform PreferredTransform
	{
		[Export("preferredTransform")]
		get
		{
			CGAffineTransform retval;
			if (IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selPreferredTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreferredTransformHandle);
			}
			return retval;
		}
	}

	[Obsolete("Deprecated in iOS 5.0. Use NaturalSize/PreferredTransform as appropriate on the video track", false)]
	public virtual CGSize NaturalSize
	{
		[Export("naturalSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
	}

	public virtual bool ProvidesPreciseDurationAndTiming
	{
		[Export("providesPreciseDurationAndTiming")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selProvidesPreciseDurationAndTimingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selProvidesPreciseDurationAndTimingHandle);
		}
	}

	public virtual AVAssetTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			return (AVAssetTrack[])(__mt_Tracks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle))));
		}
	}

	public virtual string Lyrics
	{
		[Export("lyrics")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLyricsHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLyricsHandle));
		}
	}

	public virtual AVMetadataItem[] CommonMetadata
	{
		[Export("commonMetadata")]
		get
		{
			return (AVMetadataItem[])(__mt_CommonMetadata_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonMetadataHandle)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonMetadataHandle))));
		}
	}

	public virtual string[] AvailableMetadataFormats
	{
		[Export("availableMetadataFormats")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableMetadataFormatsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableMetadataFormatsHandle));
		}
	}

	[Since(4, 2)]
	public virtual bool ProtectedContent
	{
		[Export("hasProtectedContent")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasProtectedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasProtectedContentHandle);
		}
	}

	[Since(4, 3)]
	public virtual NSLocale[] AvailableChapterLocales
	{
		[Export("availableChapterLocales")]
		get
		{
			return (NSLocale[])(__mt_AvailableChapterLocales_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableChapterLocalesHandle)) : NSArray.ArrayFromHandle<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableChapterLocalesHandle))));
		}
	}

	[Since(4, 3)]
	public virtual bool Playable
	{
		[Export("isPlayable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayableHandle);
		}
	}

	[Since(4, 3)]
	public virtual bool Exportable
	{
		[Export("isExportable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExportableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExportableHandle);
		}
	}

	[Since(4, 3)]
	public virtual bool Readable
	{
		[Export("isReadable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadableHandle);
		}
	}

	[Since(4, 3)]
	public virtual bool Composable
	{
		[Export("isComposable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsComposableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsComposableHandle);
		}
	}

	[Since(5, 0)]
	public virtual AVAssetReferenceRestrictions ReferenceRestrictions
	{
		[Export("referenceRestrictions")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVAssetReferenceRestrictions)Messaging.int_objc_msgSend(base.Handle, selReferenceRestrictionsHandle);
			}
			return (AVAssetReferenceRestrictions)Messaging.int_objc_msgSendSuper(base.SuperHandle, selReferenceRestrictionsHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAsset(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelLoading")]
	public virtual void CancelLoading()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelLoadingHandle);
		}
	}

	[Export("trackWithTrackID:")]
	public virtual AVAssetTrack TrackWithTrackID(int trackID)
	{
		if (IsDirectBinding)
		{
			return (AVAssetTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selTrackWithTrackID_Handle, trackID));
		}
		return (AVAssetTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selTrackWithTrackID_Handle, trackID));
	}

	[Export("tracksWithMediaType:")]
	public virtual AVAssetTrack[] TracksWithMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVAssetTrack[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTracksWithMediaType_Handle, arg)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTracksWithMediaType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("tracksWithMediaCharacteristic:")]
	public virtual AVAssetTrack[] TracksWithMediaCharacteristic(string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr arg = NSString.CreateNative(mediaCharacteristic);
		AVAssetTrack[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTracksWithMediaCharacteristic_Handle, arg)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTracksWithMediaCharacteristic_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("metadataForFormat:")]
	public virtual AVMetadataItem[] MetadataForFormat(string format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		IntPtr arg = NSString.CreateNative(format);
		AVMetadataItem[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForFormat_Handle, arg)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForFormat_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:")]
	public virtual AVMetadataItem[] ChapterMetadataGroups(NSLocale forLocale, AVMetadataItem[] commonKeys)
	{
		if (forLocale == null)
		{
			throw new ArgumentNullException("forLocale");
		}
		NSArray nSArray = ((commonKeys == null) ? null : NSArray.FromNSObjects(commonKeys));
		AVMetadataItem[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selChapterMetadataGroupsWithTitleLocaleContainingItemsWithCommonKeys_Handle, forLocale.Handle, nSArray?.Handle ?? IntPtr.Zero)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selChapterMetadataGroupsWithTitleLocaleContainingItemsWithCommonKeys_Handle, forLocale.Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("assetWithURL:")]
	public static AVAsset FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (AVAsset)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetWithURL_Handle, url.Handle));
	}

	[Export("statusOfValueForKey:error:")]
	public virtual AVKeyValueStatus StatusOfValue(string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(key);
		AVKeyValueStatus result = (AVKeyValueStatus)((!IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStatusOfValueForKeyError_Handle, arg, intPtr) : Messaging.int_objc_msgSend_IntPtr_IntPtr(base.Handle, selStatusOfValueForKeyError_Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	public unsafe virtual void LoadValuesAsynchronously(string[] keys, NSAction handler)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromStrings(keys);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, handler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadValuesAsynchronouslyForKeysCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadValuesAsynchronouslyForKeysCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	public virtual Task LoadValuesTaskAsync(string[] keys)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		LoadValuesAsynchronously(keys, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Tracks_var = null;
			__mt_CommonMetadata_var = null;
			__mt_AvailableChapterLocales_var = null;
		}
	}
}
