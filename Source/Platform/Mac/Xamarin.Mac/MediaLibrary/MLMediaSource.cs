using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaLibrary;

[Register("MLMediaSource", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
public class MLMediaSource : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaGroupForIdentifier_ = "mediaGroupForIdentifier:";

	private static readonly IntPtr selMediaGroupForIdentifier_Handle = Selector.GetHandle("mediaGroupForIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaGroupsForIdentifiers_ = "mediaGroupsForIdentifiers:";

	private static readonly IntPtr selMediaGroupsForIdentifiers_Handle = Selector.GetHandle("mediaGroupsForIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaLibrary = "mediaLibrary";

	private static readonly IntPtr selMediaLibraryHandle = Selector.GetHandle("mediaLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaObjectForIdentifier_ = "mediaObjectForIdentifier:";

	private static readonly IntPtr selMediaObjectForIdentifier_Handle = Selector.GetHandle("mediaObjectForIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaObjectsForIdentifiers_ = "mediaObjectsForIdentifiers:";

	private static readonly IntPtr selMediaObjectsForIdentifiers_Handle = Selector.GetHandle("mediaObjectsForIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSourceIdentifier = "mediaSourceIdentifier";

	private static readonly IntPtr selMediaSourceIdentifierHandle = Selector.GetHandle("mediaSourceIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootMediaGroup = "rootMediaGroup";

	private static readonly IntPtr selRootMediaGroupHandle = Selector.GetHandle("rootMediaGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLMediaSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_MediaLibrary_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceApertureIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceAppDefinedFoldersIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceCustomFoldersIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceFinalCutIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceGarageBandIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceLogicIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceMoviesFolderIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourcePhotoBoothIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourcePhotosIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceiMovieIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceiPhotoIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSourceiTunesIdentifier;

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual MLMediaGroup? RootMediaGroup
	{
		[Export("rootMediaGroup", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLMediaGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selRootMediaGroupHandle));
			}
			return Runtime.GetNSObject<MLMediaGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootMediaGroupHandle));
		}
	}

	[Field("MLMediaSourceApertureIdentifier", "MediaLibrary")]
	public static NSString MediaSourceApertureIdentifier
	{
		get
		{
			if (_MediaSourceApertureIdentifier == null)
			{
				_MediaSourceApertureIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceApertureIdentifier");
			}
			return _MediaSourceApertureIdentifier;
		}
	}

	[Field("MLMediaSourceAppDefinedFoldersIdentifier", "MediaLibrary")]
	public static NSString MediaSourceAppDefinedFoldersIdentifier
	{
		get
		{
			if (_MediaSourceAppDefinedFoldersIdentifier == null)
			{
				_MediaSourceAppDefinedFoldersIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceAppDefinedFoldersIdentifier");
			}
			return _MediaSourceAppDefinedFoldersIdentifier;
		}
	}

	[Field("MLMediaSourceCustomFoldersIdentifier", "MediaLibrary")]
	public static NSString MediaSourceCustomFoldersIdentifier
	{
		get
		{
			if (_MediaSourceCustomFoldersIdentifier == null)
			{
				_MediaSourceCustomFoldersIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceCustomFoldersIdentifier");
			}
			return _MediaSourceCustomFoldersIdentifier;
		}
	}

	[Field("MLMediaSourceFinalCutIdentifier", "MediaLibrary")]
	public static NSString MediaSourceFinalCutIdentifier
	{
		get
		{
			if (_MediaSourceFinalCutIdentifier == null)
			{
				_MediaSourceFinalCutIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceFinalCutIdentifier");
			}
			return _MediaSourceFinalCutIdentifier;
		}
	}

	[Field("MLMediaSourceGarageBandIdentifier", "MediaLibrary")]
	public static NSString MediaSourceGarageBandIdentifier
	{
		get
		{
			if (_MediaSourceGarageBandIdentifier == null)
			{
				_MediaSourceGarageBandIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceGarageBandIdentifier");
			}
			return _MediaSourceGarageBandIdentifier;
		}
	}

	[Field("MLMediaSourceLogicIdentifier", "MediaLibrary")]
	public static NSString MediaSourceLogicIdentifier
	{
		get
		{
			if (_MediaSourceLogicIdentifier == null)
			{
				_MediaSourceLogicIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceLogicIdentifier");
			}
			return _MediaSourceLogicIdentifier;
		}
	}

	[Field("MLMediaSourceMoviesFolderIdentifier", "MediaLibrary")]
	public static NSString MediaSourceMoviesFolderIdentifier
	{
		get
		{
			if (_MediaSourceMoviesFolderIdentifier == null)
			{
				_MediaSourceMoviesFolderIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceMoviesFolderIdentifier");
			}
			return _MediaSourceMoviesFolderIdentifier;
		}
	}

	[Field("MLMediaSourcePhotoBoothIdentifier", "MediaLibrary")]
	public static NSString MediaSourcePhotoBoothIdentifier
	{
		get
		{
			if (_MediaSourcePhotoBoothIdentifier == null)
			{
				_MediaSourcePhotoBoothIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourcePhotoBoothIdentifier");
			}
			return _MediaSourcePhotoBoothIdentifier;
		}
	}

	[Field("MLMediaSourcePhotosIdentifier", "MediaLibrary")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MediaSourcePhotosIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MediaSourcePhotosIdentifier == null)
			{
				_MediaSourcePhotosIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourcePhotosIdentifier");
			}
			return _MediaSourcePhotosIdentifier;
		}
	}

	[Field("MLMediaSourceiMovieIdentifier", "MediaLibrary")]
	public static NSString MediaSourceiMovieIdentifier
	{
		get
		{
			if (_MediaSourceiMovieIdentifier == null)
			{
				_MediaSourceiMovieIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceiMovieIdentifier");
			}
			return _MediaSourceiMovieIdentifier;
		}
	}

	[Field("MLMediaSourceiPhotoIdentifier", "MediaLibrary")]
	public static NSString MediaSourceiPhotoIdentifier
	{
		get
		{
			if (_MediaSourceiPhotoIdentifier == null)
			{
				_MediaSourceiPhotoIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceiPhotoIdentifier");
			}
			return _MediaSourceiPhotoIdentifier;
		}
	}

	[Field("MLMediaSourceiTunesIdentifier", "MediaLibrary")]
	public static NSString MediaSourceiTunesIdentifier
	{
		get
		{
			if (_MediaSourceiTunesIdentifier == null)
			{
				_MediaSourceiTunesIdentifier = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaSourceiTunesIdentifier");
			}
			return _MediaSourceiTunesIdentifier;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLMediaSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLMediaSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("mediaGroupForIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaGroup? MediaGroupForIdentifier(NSString mediaGroupIdentifier)
	{
		if (mediaGroupIdentifier == null)
		{
			throw new ArgumentNullException("mediaGroupIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MLMediaGroup>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaGroupForIdentifier_Handle, mediaGroupIdentifier.Handle));
		}
		return Runtime.GetNSObject<MLMediaGroup>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaGroupForIdentifier_Handle, mediaGroupIdentifier.Handle));
	}

	[Export("mediaGroupsForIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, MLMediaGroup> MediaGroupsForIdentifiers(NSString[] mediaGroupIdentifiers)
	{
		if (mediaGroupIdentifiers == null)
		{
			throw new ArgumentNullException("mediaGroupIdentifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(mediaGroupIdentifiers);
		NSDictionary<NSString, MLMediaGroup> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary<NSString, MLMediaGroup>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaGroupsForIdentifiers_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSDictionary<NSString, MLMediaGroup>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaGroupsForIdentifiers_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("mediaObjectForIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaObject? MediaObjectForIdentifier(NSString mediaObjectIdentifier)
	{
		if (mediaObjectIdentifier == null)
		{
			throw new ArgumentNullException("mediaObjectIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MLMediaObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaObjectForIdentifier_Handle, mediaObjectIdentifier.Handle));
		}
		return Runtime.GetNSObject<MLMediaObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaObjectForIdentifier_Handle, mediaObjectIdentifier.Handle));
	}

	[Export("mediaObjectsForIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, MLMediaObject> MediaObjectsForIdentifiers(NSString[] mediaObjectIdentifiers)
	{
		if (mediaObjectIdentifiers == null)
		{
			throw new ArgumentNullException("mediaObjectIdentifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(mediaObjectIdentifiers);
		NSDictionary<NSString, MLMediaObject> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary<NSString, MLMediaObject>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaObjectsForIdentifiers_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSDictionary<NSString, MLMediaObject>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaObjectsForIdentifiers_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
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
