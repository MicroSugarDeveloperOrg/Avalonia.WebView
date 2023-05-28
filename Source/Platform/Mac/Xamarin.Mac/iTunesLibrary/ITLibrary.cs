using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace iTunesLibrary;

[Register("ITLibrary", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class ITLibrary : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllMediaItems = "allMediaItems";

	private static readonly IntPtr selAllMediaItemsHandle = Selector.GetHandle("allMediaItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllPlaylists = "allPlaylists";

	private static readonly IntPtr selAllPlaylistsHandle = Selector.GetHandle("allPlaylists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApiMajorVersion = "apiMajorVersion";

	private static readonly IntPtr selApiMajorVersionHandle = Selector.GetHandle("apiMajorVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApiMinorVersion = "apiMinorVersion";

	private static readonly IntPtr selApiMinorVersionHandle = Selector.GetHandle("apiMinorVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationVersion = "applicationVersion";

	private static readonly IntPtr selApplicationVersionHandle = Selector.GetHandle("applicationVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArtworkForMediaFile_ = "artworkForMediaFile:";

	private static readonly IntPtr selArtworkForMediaFile_Handle = Selector.GetHandle("artworkForMediaFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatures = "features";

	private static readonly IntPtr selFeaturesHandle = Selector.GetHandle("features");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAPIVersion_Error_ = "initWithAPIVersion:error:";

	private static readonly IntPtr selInitWithAPIVersion_Error_Handle = Selector.GetHandle("initWithAPIVersion:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAPIVersion_Options_Error_ = "initWithAPIVersion:options:error:";

	private static readonly IntPtr selInitWithAPIVersion_Options_Error_Handle = Selector.GetHandle("initWithAPIVersion:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLibraryWithAPIVersion_Error_ = "libraryWithAPIVersion:error:";

	private static readonly IntPtr selLibraryWithAPIVersion_Error_Handle = Selector.GetHandle("libraryWithAPIVersion:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLibraryWithAPIVersion_Options_Error_ = "libraryWithAPIVersion:options:error:";

	private static readonly IntPtr selLibraryWithAPIVersion_Options_Error_Handle = Selector.GetHandle("libraryWithAPIVersion:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaFolderLocation = "mediaFolderLocation";

	private static readonly IntPtr selMediaFolderLocationHandle = Selector.GetHandle("mediaFolderLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMusicFolderLocation = "musicFolderLocation";

	private static readonly IntPtr selMusicFolderLocationHandle = Selector.GetHandle("musicFolderLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldShowContentRating = "shouldShowContentRating";

	private static readonly IntPtr selShouldShowContentRatingHandle = Selector.GetHandle("shouldShowContentRating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnloadData = "unloadData";

	private static readonly IntPtr selUnloadDataHandle = Selector.GetHandle("unloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ITLibrary");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItem[] AllMediaItems
	{
		[Export("allMediaItems", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ITLibMediaItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllMediaItemsHandle));
			}
			return NSArray.ArrayFromHandle<ITLibMediaItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllMediaItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibPlaylist[] AllPlaylists
	{
		[Export("allPlaylists", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ITLibPlaylist>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllPlaylistsHandle));
			}
			return NSArray.ArrayFromHandle<ITLibPlaylist>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllPlaylistsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ApiMajorVersion
	{
		[Export("apiMajorVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selApiMajorVersionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selApiMajorVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ApiMinorVersion
	{
		[Export("apiMinorVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selApiMinorVersionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selApiMinorVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ApplicationVersion
	{
		[Export("applicationVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicationVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicationVersionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibExportFeature Features
	{
		[Export("features", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibExportFeature)Messaging.UInt64_objc_msgSend(base.Handle, selFeaturesHandle);
			}
			return (ITLibExportFeature)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFeaturesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? MediaFolderLocation
	{
		[Export("mediaFolderLocation", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaFolderLocationHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaFolderLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? MusicFolderLocation
	{
		[Export("musicFolderLocation", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selMusicFolderLocationHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMusicFolderLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowContentRating
	{
		[Export("shouldShowContentRating")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldShowContentRatingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldShowContentRatingHandle);
		}
	}

	[Obsolete("This constructor does not create a valid instance of the type.")]
	public ITLibrary()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ITLibrary(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ITLibrary(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAPIVersion:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ITLibrary(string requestedAPIVersion, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (requestedAPIVersion == null)
		{
			throw new ArgumentNullException("requestedAPIVersion");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(requestedAPIVersion);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithAPIVersion_Error_Handle, arg2, ref arg), "initWithAPIVersion:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithAPIVersion_Error_Handle, arg2, ref arg), "initWithAPIVersion:error:");
		}
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithAPIVersion:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ITLibrary(string requestedAPIVersion, ITLibInitOptions options, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (requestedAPIVersion == null)
		{
			throw new ArgumentNullException("requestedAPIVersion");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(requestedAPIVersion);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selInitWithAPIVersion_Options_Error_Handle, arg2, (ulong)options, ref arg), "initWithAPIVersion:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selInitWithAPIVersion_Options_Error_Handle, arg2, (ulong)options, ref arg), "initWithAPIVersion:options:error:");
		}
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("artworkForMediaFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibArtwork? GetArtwork(NSUrl mediaFileUrl)
	{
		if (mediaFileUrl == null)
		{
			throw new ArgumentNullException("mediaFileUrl");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<ITLibArtwork>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArtworkForMediaFile_Handle, mediaFileUrl.Handle));
		}
		return Runtime.GetNSObject<ITLibArtwork>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArtworkForMediaFile_Handle, mediaFileUrl.Handle));
	}

	[Export("libraryWithAPIVersion:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ITLibrary? GetLibrary(string requestedAPIVersion, out NSError? error)
	{
		if (requestedAPIVersion == null)
		{
			throw new ArgumentNullException("requestedAPIVersion");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(requestedAPIVersion);
		ITLibrary nSObject = Runtime.GetNSObject<ITLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selLibraryWithAPIVersion_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("libraryWithAPIVersion:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ITLibrary? GetLibrary(string requestedAPIVersion, ITLibInitOptions options, out NSError? error)
	{
		if (requestedAPIVersion == null)
		{
			throw new ArgumentNullException("requestedAPIVersion");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(requestedAPIVersion);
		ITLibrary nSObject = Runtime.GetNSObject<ITLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selLibraryWithAPIVersion_Options_Error_Handle, arg2, (ulong)options, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReloadData()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
	}

	[Export("unloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnloadData()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnloadDataHandle);
		}
	}
}
