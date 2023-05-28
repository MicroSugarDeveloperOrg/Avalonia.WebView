using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMovie", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class AVMovie : AVAsset, INSCopying, INativeObject, IDisposable, INSMutableCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanContainMovieFragments = "canContainMovieFragments";

	private static readonly IntPtr selCanContainMovieFragmentsHandle = Selector.GetHandle("canContainMovieFragments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsMovieFragments = "containsMovieFragments";

	private static readonly IntPtr selContainsMovieFragmentsHandle = Selector.GetHandle("containsMovieFragments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultMediaDataStorage = "defaultMediaDataStorage";

	private static readonly IntPtr selDefaultMediaDataStorageHandle = Selector.GetHandle("defaultMediaDataStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_ = "initWithData:options:";

	private static readonly IntPtr selInitWithData_Options_Handle = Selector.GetHandle("initWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_ = "initWithURL:options:";

	private static readonly IntPtr selInitWithURL_Options_Handle = Selector.GetHandle("initWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieTypes = "movieTypes";

	private static readonly IntPtr selMovieTypesHandle = Selector.GetHandle("movieTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithData_Options_ = "movieWithData:options:";

	private static readonly IntPtr selMovieWithData_Options_Handle = Selector.GetHandle("movieWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithURL_Options_ = "movieWithURL:options:";

	private static readonly IntPtr selMovieWithURL_Options_Handle = Selector.GetHandle("movieWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMovie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceRestrictionsKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanContainMovieFragments
	{
		[Export("canContainMovieFragments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanContainMovieFragmentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanContainMovieFragmentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool ContainsMovieFragments
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("containsMovieFragments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selContainsMovieFragmentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selContainsMovieFragmentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSData? Data
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual AVMediaDataStorage? DefaultMediaDataStorage
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("defaultMediaDataStorage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMediaDataStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultMediaDataStorageHandle));
			}
			return Runtime.GetNSObject<AVMediaDataStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultMediaDataStorageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] MovieTypes
	{
		[Export("movieTypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMovieTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMovieTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVMovieTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? URL
	{
		[Export("URL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[Field("AVMovieReferenceRestrictionsKey", "AVFoundation")]
	public static NSString ReferenceRestrictionsKey
	{
		get
		{
			if (_ReferenceRestrictionsKey == null)
			{
				_ReferenceRestrictionsKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMovieReferenceRestrictionsKey");
			}
			return _ReferenceRestrictionsKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMovie(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMovie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMovie(NSUrl URL, NSDictionary<NSString, NSObject>? options)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Options_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Options_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
	}

	[Export("initWithData:options:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMovie(NSData data, NSDictionary<NSString, NSObject>? options)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("movieWithData:options:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMovie FromData(NSData data, NSDictionary<NSString, NSObject>? options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<AVMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("movieWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMovie FromUrl(NSUrl URL, NSDictionary<NSString, NSObject>? options)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		return Runtime.GetNSObject<AVMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithURL_Options_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
