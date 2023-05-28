using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableMovie", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class AVMutableMovie : AVMovie
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultMediaDataStorage = "defaultMediaDataStorage";

	private static readonly IntPtr selDefaultMediaDataStorageHandle = Selector.GetHandle("defaultMediaDataStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_Error_ = "initWithData:options:error:";

	private static readonly IntPtr selInitWithData_Options_Error_Handle = Selector.GetHandle("initWithData:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSettingsFromMovie_Options_Error_ = "initWithSettingsFromMovie:options:error:";

	private static readonly IntPtr selInitWithSettingsFromMovie_Options_Error_Handle = Selector.GetHandle("initWithSettingsFromMovie:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_Error_ = "initWithURL:options:error:";

	private static readonly IntPtr selInitWithURL_Options_Error_Handle = Selector.GetHandle("initWithURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterleavingPeriod = "interleavingPeriod";

	private static readonly IntPtr selInterleavingPeriodHandle = Selector.GetHandle("interleavingPeriod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsModified = "isModified";

	private static readonly IntPtr selIsModifiedHandle = Selector.GetHandle("isModified");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithData_Options_Error_ = "movieWithData:options:error:";

	private static readonly IntPtr selMovieWithData_Options_Error_Handle = Selector.GetHandle("movieWithData:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithSettingsFromMovie_Options_Error_ = "movieWithSettingsFromMovie:options:error:";

	private static readonly IntPtr selMovieWithSettingsFromMovie_Options_Error_Handle = Selector.GetHandle("movieWithSettingsFromMovie:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithURL_Options_Error_ = "movieWithURL:options:error:";

	private static readonly IntPtr selMovieWithURL_Options_Error_Handle = Selector.GetHandle("movieWithURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredRate = "preferredRate";

	private static readonly IntPtr selPreferredRateHandle = Selector.GetHandle("preferredRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredTransform = "preferredTransform";

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVolume = "preferredVolume";

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultMediaDataStorage_ = "setDefaultMediaDataStorage:";

	private static readonly IntPtr selSetDefaultMediaDataStorage_Handle = Selector.GetHandle("setDefaultMediaDataStorage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterleavingPeriod_ = "setInterleavingPeriod:";

	private static readonly IntPtr selSetInterleavingPeriod_Handle = Selector.GetHandle("setInterleavingPeriod:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModified_ = "setModified:";

	private static readonly IntPtr selSetModified_Handle = Selector.GetHandle("setModified:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredRate_ = "setPreferredRate:";

	private static readonly IntPtr selSetPreferredRate_Handle = Selector.GetHandle("setPreferredRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredTransform_ = "setPreferredTransform:";

	private static readonly IntPtr selSetPreferredTransform_Handle = Selector.GetHandle("setPreferredTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredVolume_ = "setPreferredVolume:";

	private static readonly IntPtr selSetPreferredVolume_Handle = Selector.GetHandle("setPreferredVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimescale_ = "setTimescale:";

	private static readonly IntPtr selSetTimescale_Handle = Selector.GetHandle("setTimescale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimescale = "timescale";

	private static readonly IntPtr selTimescaleHandle = Selector.GetHandle("timescale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableMovie");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMediaDataStorage? DefaultMediaDataStorage
	{
		[Export("defaultMediaDataStorage", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMediaDataStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultMediaDataStorageHandle));
			}
			return Runtime.GetNSObject<AVMediaDataStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultMediaDataStorageHandle));
		}
		[Export("setDefaultMediaDataStorage:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultMediaDataStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultMediaDataStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime InterleavingPeriod
	{
		[Export("interleavingPeriod", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selInterleavingPeriodHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selInterleavingPeriodHandle);
			}
			return retval;
		}
		[Export("setInterleavingPeriod:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetInterleavingPeriod_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetInterleavingPeriod_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMetadataItem[] Metadata
	{
		[Export("metadata", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
		[Export("setMetadata:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Modified
	{
		[Export("isModified")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsModifiedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsModifiedHandle);
		}
		[Export("setModified:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetModified_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetModified_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual float PreferredRate
	{
		[Export("preferredRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredRateHandle);
		}
		[Export("setPreferredRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPreferredRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPreferredRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGAffineTransform PreferredTransform
	{
		[Export("preferredTransform", ArgumentSemantic.Assign)]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selPreferredTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreferredTransformHandle);
			}
			return retval;
		}
		[Export("setPreferredTransform:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetPreferredTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetPreferredTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual float PreferredVolume
	{
		[Export("preferredVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
		[Export("setPreferredVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPreferredVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPreferredVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Timescale
	{
		[Export("timescale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTimescaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTimescaleHandle);
		}
		[Export("setTimescale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTimescale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTimescale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMutableMovieTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMutableMovieTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVMutableMovieTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableMovie()
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
	protected AVMutableMovie(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableMovie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMutableMovie(NSUrl URL, NSDictionary<NSString, NSObject>? options, out NSError? outError)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_Options_Error_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero, ref arg), "initWithURL:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_Options_Error_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero, ref arg), "initWithURL:options:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithData:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMutableMovie(NSData data, NSDictionary<NSString, NSObject>? options, out NSError? outError)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithData_Options_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg), "initWithData:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithData_Options_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg), "initWithData:options:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithSettingsFromMovie:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMutableMovie(AVMovie? movie, NSDictionary<NSString, NSObject>? options, out NSError? outError)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithSettingsFromMovie_Options_Error_Handle, movie?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg), "initWithSettingsFromMovie:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithSettingsFromMovie_Options_Error_Handle, movie?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg), "initWithSettingsFromMovie:options:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("movieWithData:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableMovie? FromData(NSData data, NSDictionary<NSString, NSObject>? options, out NSError? outError)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		AVMutableMovie nSObject = Runtime.GetNSObject<AVMutableMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selMovieWithData_Options_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieWithSettingsFromMovie:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableMovie? FromMovie(AVMovie? movie, NSDictionary<NSString, NSObject>? options, out NSError? outError)
	{
		IntPtr arg = IntPtr.Zero;
		AVMutableMovie nSObject = Runtime.GetNSObject<AVMutableMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selMovieWithSettingsFromMovie_Options_Error_Handle, movie?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieWithURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableMovie? FromUrl(NSUrl URL, NSDictionary<NSString, NSObject>? options, out NSError? outError)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		IntPtr arg = IntPtr.Zero;
		AVMutableMovie nSObject = Runtime.GetNSObject<AVMutableMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selMovieWithURL_Options_Error_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}
