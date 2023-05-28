using System;
using System.ComponentModel;
using AppKit;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHAssetChangeRequest", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHAssetChangeRequest : PHChangeRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeRequestForAsset_ = "changeRequestForAsset:";

	private static readonly IntPtr selChangeRequestForAsset_Handle = Selector.GetHandle("changeRequestForAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentEditingOutput = "contentEditingOutput";

	private static readonly IntPtr selContentEditingOutputHandle = Selector.GetHandle("contentEditingOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationDate = "creationDate";

	private static readonly IntPtr selCreationDateHandle = Selector.GetHandle("creationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationRequestForAssetFromImage_ = "creationRequestForAssetFromImage:";

	private static readonly IntPtr selCreationRequestForAssetFromImage_Handle = Selector.GetHandle("creationRequestForAssetFromImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationRequestForAssetFromImageAtFileURL_ = "creationRequestForAssetFromImageAtFileURL:";

	private static readonly IntPtr selCreationRequestForAssetFromImageAtFileURL_Handle = Selector.GetHandle("creationRequestForAssetFromImageAtFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationRequestForAssetFromVideoAtFileURL_ = "creationRequestForAssetFromVideoAtFileURL:";

	private static readonly IntPtr selCreationRequestForAssetFromVideoAtFileURL_Handle = Selector.GetHandle("creationRequestForAssetFromVideoAtFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteAssets_ = "deleteAssets:";

	private static readonly IntPtr selDeleteAssets_Handle = Selector.GetHandle("deleteAssets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFavorite = "isFavorite";

	private static readonly IntPtr selIsFavoriteHandle = Selector.GetHandle("isFavorite");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocation = "location";

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderForCreatedAsset = "placeholderForCreatedAsset";

	private static readonly IntPtr selPlaceholderForCreatedAssetHandle = Selector.GetHandle("placeholderForCreatedAsset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevertAssetContentToOriginal = "revertAssetContentToOriginal";

	private static readonly IntPtr selRevertAssetContentToOriginalHandle = Selector.GetHandle("revertAssetContentToOriginal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentEditingOutput_ = "setContentEditingOutput:";

	private static readonly IntPtr selSetContentEditingOutput_Handle = Selector.GetHandle("setContentEditingOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCreationDate_ = "setCreationDate:";

	private static readonly IntPtr selSetCreationDate_Handle = Selector.GetHandle("setCreationDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFavorite_ = "setFavorite:";

	private static readonly IntPtr selSetFavorite_Handle = Selector.GetHandle("setFavorite:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocation_ = "setLocation:";

	private static readonly IntPtr selSetLocation_Handle = Selector.GetHandle("setLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAssetChangeRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHContentEditingOutput? ContentEditingOutput
	{
		[Export("contentEditingOutput", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHContentEditingOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentEditingOutputHandle));
			}
			return Runtime.GetNSObject<PHContentEditingOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentEditingOutputHandle));
		}
		[Export("setContentEditingOutput:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentEditingOutput_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentEditingOutput_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate CreationDate
	{
		[Export("creationDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreationDateHandle));
		}
		[Export("setCreationDate:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCreationDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCreationDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Favorite
	{
		[Export("isFavorite")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFavoriteHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFavoriteHandle);
		}
		[Export("setFavorite:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFavorite_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFavorite_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocation Location
	{
		[Export("location", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationHandle));
			}
			return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationHandle));
		}
		[Export("setLocation:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocation_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocation_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObjectPlaceholder PlaceholderForCreatedAsset
	{
		[Export("placeholderForCreatedAsset", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHObjectPlaceholder>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderForCreatedAssetHandle));
			}
			return Runtime.GetNSObject<PHObjectPlaceholder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderForCreatedAssetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHAssetChangeRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAssetChangeRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("changeRequestForAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetChangeRequest ChangeRequest(PHAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<PHAssetChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selChangeRequestForAsset_Handle, asset.Handle));
	}

	[Export("deleteAssets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteAssets(PHAsset[] assets)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selDeleteAssets_Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("creationRequestForAssetFromImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetChangeRequest FromImage(NSImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<PHAssetChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreationRequestForAssetFromImage_Handle, image.Handle));
	}

	[Export("creationRequestForAssetFromImageAtFileURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetChangeRequest FromImage(NSUrl fileUrl)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		return Runtime.GetNSObject<PHAssetChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreationRequestForAssetFromImageAtFileURL_Handle, fileUrl.Handle));
	}

	[Export("creationRequestForAssetFromVideoAtFileURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetChangeRequest FromVideo(NSUrl fileUrl)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		return Runtime.GetNSObject<PHAssetChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreationRequestForAssetFromVideoAtFileURL_Handle, fileUrl.Handle));
	}

	[Export("revertAssetContentToOriginal")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RevertAssetContentToOriginal()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRevertAssetContentToOriginalHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRevertAssetContentToOriginalHandle);
		}
	}
}
