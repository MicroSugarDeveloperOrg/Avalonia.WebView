using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace MediaLibrary;

[Register("MLMediaObject", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
public class MLMediaObject : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArtworkImage = "artworkImage";

	private static readonly IntPtr selArtworkImageHandle = Selector.GetHandle("artworkImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentType = "contentType";

	private static readonly IntPtr selContentTypeHandle = Selector.GetHandle("contentType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileSize = "fileSize";

	private static readonly IntPtr selFileSizeHandle = Selector.GetHandle("fileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaLibrary = "mediaLibrary";

	private static readonly IntPtr selMediaLibraryHandle = Selector.GetHandle("mediaLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSourceIdentifier = "mediaSourceIdentifier";

	private static readonly IntPtr selMediaSourceIdentifierHandle = Selector.GetHandle("mediaSourceIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModificationDate = "modificationDate";

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOriginalURL = "originalURL";

	private static readonly IntPtr selOriginalURLHandle = Selector.GetHandle("originalURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThumbnailURL = "thumbnailURL";

	private static readonly IntPtr selThumbnailURLHandle = Selector.GetHandle("thumbnailURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLMediaObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_MediaLibrary_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectAlbumKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectArtistKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectBitRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectChannelCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectCommentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectDurationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectGenreKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectKeywordsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectKindKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectProtectedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectResolutionStringKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectSampleRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaObjectTrackNumberKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? ArtworkImage
	{
		[Export("artworkImage", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selArtworkImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArtworkImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject> Attributes
	{
		[Export("attributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ContentType
	{
		[Export("contentType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FileSize
	{
		[Export("fileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFileSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFileSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaLibrary? MediaLibrary
	{
		[Export("mediaLibrary", ArgumentSemantic.Assign)]
		get
		{
			MLMediaLibrary mLMediaLibrary = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLMediaLibrary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaLibraryHandle)) : Runtime.GetNSObject<MLMediaLibrary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaLibraryHandle)));
			MarkDirty();
			__mt_MediaLibrary_var = mLMediaLibrary;
			return mLMediaLibrary;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString MediaSourceIdentifier
	{
		[Export("mediaSourceIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaSourceIdentifierHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaSourceIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaType MediaType
	{
		[Export("mediaType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLMediaType)Messaging.UInt64_objc_msgSend(base.Handle, selMediaTypeHandle);
			}
			return (MLMediaType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? ModificationDate
	{
		[Export("modificationDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selModificationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModificationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? OriginalUrl
	{
		[Export("originalURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selOriginalURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOriginalURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? ThumbnailUrl
	{
		[Export("thumbnailURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selThumbnailURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selThumbnailURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[Field("MLMediaObjectAlbumKey", "MediaLibrary")]
	public static NSString MediaObjectAlbumKey
	{
		get
		{
			if (_MediaObjectAlbumKey == null)
			{
				_MediaObjectAlbumKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectAlbumKey");
			}
			return _MediaObjectAlbumKey;
		}
	}

	[Field("MLMediaObjectArtistKey", "MediaLibrary")]
	public static NSString MediaObjectArtistKey
	{
		get
		{
			if (_MediaObjectArtistKey == null)
			{
				_MediaObjectArtistKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectArtistKey");
			}
			return _MediaObjectArtistKey;
		}
	}

	[Field("MLMediaObjectBitRateKey", "MediaLibrary")]
	public static NSString MediaObjectBitRateKey
	{
		get
		{
			if (_MediaObjectBitRateKey == null)
			{
				_MediaObjectBitRateKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectBitRateKey");
			}
			return _MediaObjectBitRateKey;
		}
	}

	[Field("MLMediaObjectChannelCountKey", "MediaLibrary")]
	public static NSString MediaObjectChannelCountKey
	{
		get
		{
			if (_MediaObjectChannelCountKey == null)
			{
				_MediaObjectChannelCountKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectChannelCountKey");
			}
			return _MediaObjectChannelCountKey;
		}
	}

	[Field("MLMediaObjectCommentsKey", "MediaLibrary")]
	public static NSString MediaObjectCommentsKey
	{
		get
		{
			if (_MediaObjectCommentsKey == null)
			{
				_MediaObjectCommentsKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectCommentsKey");
			}
			return _MediaObjectCommentsKey;
		}
	}

	[Field("MLMediaObjectDurationKey", "MediaLibrary")]
	public static NSString MediaObjectDurationKey
	{
		get
		{
			if (_MediaObjectDurationKey == null)
			{
				_MediaObjectDurationKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectDurationKey");
			}
			return _MediaObjectDurationKey;
		}
	}

	[Field("MLMediaObjectGenreKey", "MediaLibrary")]
	public static NSString MediaObjectGenreKey
	{
		get
		{
			if (_MediaObjectGenreKey == null)
			{
				_MediaObjectGenreKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectGenreKey");
			}
			return _MediaObjectGenreKey;
		}
	}

	[Field("MLMediaObjectKeywordsKey", "MediaLibrary")]
	public static NSString MediaObjectKeywordsKey
	{
		get
		{
			if (_MediaObjectKeywordsKey == null)
			{
				_MediaObjectKeywordsKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectKeywordsKey");
			}
			return _MediaObjectKeywordsKey;
		}
	}

	[Field("MLMediaObjectKindKey", "MediaLibrary")]
	public static NSString MediaObjectKindKey
	{
		get
		{
			if (_MediaObjectKindKey == null)
			{
				_MediaObjectKindKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectKindKey");
			}
			return _MediaObjectKindKey;
		}
	}

	[Field("MLMediaObjectProtectedKey", "MediaLibrary")]
	public static NSString MediaObjectProtectedKey
	{
		get
		{
			if (_MediaObjectProtectedKey == null)
			{
				_MediaObjectProtectedKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectProtectedKey");
			}
			return _MediaObjectProtectedKey;
		}
	}

	[Field("MLMediaObjectResolutionStringKey", "MediaLibrary")]
	public static NSString MediaObjectResolutionStringKey
	{
		get
		{
			if (_MediaObjectResolutionStringKey == null)
			{
				_MediaObjectResolutionStringKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectResolutionStringKey");
			}
			return _MediaObjectResolutionStringKey;
		}
	}

	[Field("MLMediaObjectSampleRateKey", "MediaLibrary")]
	public static NSString MediaObjectSampleRateKey
	{
		get
		{
			if (_MediaObjectSampleRateKey == null)
			{
				_MediaObjectSampleRateKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectSampleRateKey");
			}
			return _MediaObjectSampleRateKey;
		}
	}

	[Field("MLMediaObjectTrackNumberKey", "MediaLibrary")]
	public static NSString MediaObjectTrackNumberKey
	{
		get
		{
			if (_MediaObjectTrackNumberKey == null)
			{
				_MediaObjectTrackNumberKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaObjectTrackNumberKey");
			}
			return _MediaObjectTrackNumberKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLMediaObject(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLMediaObject(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MediaLibrary_var = null;
		}
	}
}
