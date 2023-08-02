using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVURLAsset", true)]
public class AVUrlAsset : AVAsset
{
	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selAudiovisualMIMETypesHandle = Selector.GetHandle("audiovisualMIMETypes");

	private static readonly IntPtr selAudiovisualTypesHandle = Selector.GetHandle("audiovisualTypes");

	private static readonly IntPtr selURLAssetWithURLOptions_Handle = Selector.GetHandle("URLAssetWithURL:options:");

	private static readonly IntPtr selInitWithURLOptions_Handle = Selector.GetHandle("initWithURL:options:");

	private static readonly IntPtr selCompatibleTrackForCompositionTrack_Handle = Selector.GetHandle("compatibleTrackForCompositionTrack:");

	private static readonly IntPtr selIsPlayableExtendedMIMEType_Handle = Selector.GetHandle("isPlayableExtendedMIMEType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVURLAsset");

	private object __mt_Url_var;

	private static NSString _PreferPreciseDurationAndTimingKey;

	private static NSString _ReferenceRestrictionsKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
	}

	[Since(5, 0)]
	public static string[] AudiovisualMimeTypes
	{
		[Export("audiovisualMIMETypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAudiovisualMIMETypesHandle));
		}
	}

	[Since(5, 0)]
	public static string[] AudiovisualTypes
	{
		[Export("audiovisualTypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAudiovisualTypesHandle));
		}
	}

	[Field("AVURLAssetPreferPreciseDurationAndTimingKey", "AVFoundation")]
	public static NSString PreferPreciseDurationAndTimingKey
	{
		get
		{
			if (_PreferPreciseDurationAndTimingKey == null)
			{
				_PreferPreciseDurationAndTimingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetPreferPreciseDurationAndTimingKey");
			}
			return _PreferPreciseDurationAndTimingKey;
		}
	}

	[Field("AVURLAssetReferenceRestrictionsKey", "AVFoundation")]
	public static NSString ReferenceRestrictionsKey
	{
		get
		{
			if (_ReferenceRestrictionsKey == null)
			{
				_ReferenceRestrictionsKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetReferenceRestrictionsKey");
			}
			return _ReferenceRestrictionsKey;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVUrlAsset(NSCoder coder)
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
	public AVUrlAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVUrlAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("URLAssetWithURL:options:")]
	public static AVUrlAsset FromUrl(NSUrl URL, NSDictionary options)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		return (AVUrlAsset)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selURLAssetWithURLOptions_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero));
	}

	public static AVUrlAsset Create(NSUrl url, AVUrlAssetOptions options)
	{
		return FromUrl(url, options?.Dictionary);
	}

	[Export("initWithURL:options:")]
	public AVUrlAsset(NSUrl URL, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURLOptions_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURLOptions_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero);
		}
	}

	public AVUrlAsset(NSUrl url, AVUrlAssetOptions options)
		: this(url, options?.Dictionary)
	{
	}

	[Export("compatibleTrackForCompositionTrack:")]
	public virtual AVAssetTrack CompatibleTrack(AVCompositionTrack forCompositionTrack)
	{
		if (forCompositionTrack == null)
		{
			throw new ArgumentNullException("forCompositionTrack");
		}
		if (IsDirectBinding)
		{
			return (AVAssetTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompatibleTrackForCompositionTrack_Handle, forCompositionTrack.Handle));
		}
		return (AVAssetTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompatibleTrackForCompositionTrack_Handle, forCompositionTrack.Handle));
	}

	[Export("isPlayableExtendedMIMEType:")]
	public static bool IsPlayable(string extendedMimeType)
	{
		if (extendedMimeType == null)
		{
			throw new ArgumentNullException("extendedMimeType");
		}
		IntPtr arg = NSString.CreateNative(extendedMimeType);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsPlayableExtendedMIMEType_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
		}
	}
}
