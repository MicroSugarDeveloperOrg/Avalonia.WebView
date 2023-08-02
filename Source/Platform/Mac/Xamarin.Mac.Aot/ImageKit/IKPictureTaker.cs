using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKPictureTaker", true)]
public class IKPictureTaker : NSPanel
{
	private static readonly IntPtr selPictureTakerHandle = Selector.GetHandle("pictureTaker");

	private static readonly IntPtr selInputImageHandle = Selector.GetHandle("inputImage");

	private static readonly IntPtr selSetInputImage_Handle = Selector.GetHandle("setInputImage:");

	private static readonly IntPtr selMirroringHandle = Selector.GetHandle("mirroring");

	private static readonly IntPtr selSetMirroring_Handle = Selector.GetHandle("setMirroring:");

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	private static readonly IntPtr selBeginPictureTakerWithDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginPictureTakerWithDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selBeginPictureTakerSheetForWindowWithDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selPopUpRecentsMenuForViewWithDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selOutputImageHandle = Selector.GetHandle("outputImage");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKPictureTaker");

	private static object __mt_SharedPictureTaker_var_static;

	private object __mt_InputImage_var;

	private static NSString _AllowsVideoCaptureKey;

	private static NSString _AllowsFileChoosingKey;

	private static NSString _ShowRecentPictureKey;

	private static NSString _UpdateRecentPictureKey;

	private static NSString _AllowsEditingKey;

	private static NSString _ShowEffectsKey;

	private static NSString _InformationalTextKey;

	private static NSString _ImageTransformsKey;

	private static NSString _OutputImageMaxSizeKey;

	private static NSString _CropAreaSizeKey;

	private static NSString _ShowAddressBookPictureKey;

	private static NSString _ShowEmptyPictureKey;

	private static NSString _RemainOpenAfterValidateKey;

	public override IntPtr ClassHandle => class_ptr;

	public static IKPictureTaker SharedPictureTaker
	{
		[Export("pictureTaker")]
		get
		{
			return (IKPictureTaker)(__mt_SharedPictureTaker_var_static = (IKPictureTaker)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPictureTakerHandle)));
		}
	}

	public virtual NSImage InputImage
	{
		[Export("inputImage")]
		get
		{
			return (NSImage)(__mt_InputImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInputImageHandle)))));
		}
		[Export("setInputImage:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputImage_Handle, value.Handle);
			}
			__mt_InputImage_var = value;
		}
	}

	public virtual bool Mirroring
	{
		[Export("mirroring")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMirroringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMirroringHandle);
		}
		[Export("setMirroring:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMirroring_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMirroring_Handle, value);
			}
		}
	}

	[Field("IKPictureTakerAllowsVideoCaptureKey", "ImageKit")]
	public static NSString AllowsVideoCaptureKey
	{
		get
		{
			if (_AllowsVideoCaptureKey == null)
			{
				_AllowsVideoCaptureKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerAllowsVideoCaptureKey");
			}
			return _AllowsVideoCaptureKey;
		}
	}

	[Field("IKPictureTakerAllowsFileChoosingKey", "ImageKit")]
	public static NSString AllowsFileChoosingKey
	{
		get
		{
			if (_AllowsFileChoosingKey == null)
			{
				_AllowsFileChoosingKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerAllowsFileChoosingKey");
			}
			return _AllowsFileChoosingKey;
		}
	}

	[Field("IKPictureTakerShowRecentPictureKey", "ImageKit")]
	public static NSString ShowRecentPictureKey
	{
		get
		{
			if (_ShowRecentPictureKey == null)
			{
				_ShowRecentPictureKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerShowRecentPictureKey");
			}
			return _ShowRecentPictureKey;
		}
	}

	[Field("IKPictureTakerUpdateRecentPictureKey", "ImageKit")]
	public static NSString UpdateRecentPictureKey
	{
		get
		{
			if (_UpdateRecentPictureKey == null)
			{
				_UpdateRecentPictureKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerUpdateRecentPictureKey");
			}
			return _UpdateRecentPictureKey;
		}
	}

	[Field("IKPictureTakerAllowsEditingKey", "ImageKit")]
	public static NSString AllowsEditingKey
	{
		get
		{
			if (_AllowsEditingKey == null)
			{
				_AllowsEditingKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerAllowsEditingKey");
			}
			return _AllowsEditingKey;
		}
	}

	[Field("IKPictureTakerShowEffectsKey", "ImageKit")]
	public static NSString ShowEffectsKey
	{
		get
		{
			if (_ShowEffectsKey == null)
			{
				_ShowEffectsKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerShowEffectsKey");
			}
			return _ShowEffectsKey;
		}
	}

	[Field("IKPictureTakerInformationalTextKey", "ImageKit")]
	public static NSString InformationalTextKey
	{
		get
		{
			if (_InformationalTextKey == null)
			{
				_InformationalTextKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerInformationalTextKey");
			}
			return _InformationalTextKey;
		}
	}

	[Field("IKPictureTakerImageTransformsKey", "ImageKit")]
	public static NSString ImageTransformsKey
	{
		get
		{
			if (_ImageTransformsKey == null)
			{
				_ImageTransformsKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerImageTransformsKey");
			}
			return _ImageTransformsKey;
		}
	}

	[Field("IKPictureTakerOutputImageMaxSizeKey", "ImageKit")]
	public static NSString OutputImageMaxSizeKey
	{
		get
		{
			if (_OutputImageMaxSizeKey == null)
			{
				_OutputImageMaxSizeKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerOutputImageMaxSizeKey");
			}
			return _OutputImageMaxSizeKey;
		}
	}

	[Field("IKPictureTakerCropAreaSizeKey", "ImageKit")]
	public static NSString CropAreaSizeKey
	{
		get
		{
			if (_CropAreaSizeKey == null)
			{
				_CropAreaSizeKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerCropAreaSizeKey");
			}
			return _CropAreaSizeKey;
		}
	}

	[Field("IKPictureTakerShowAddressBookPictureKey", "ImageKit")]
	public static NSString ShowAddressBookPictureKey
	{
		get
		{
			if (_ShowAddressBookPictureKey == null)
			{
				_ShowAddressBookPictureKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerShowAddressBookPictureKey");
			}
			return _ShowAddressBookPictureKey;
		}
	}

	[Field("IKPictureTakerShowEmptyPictureKey", "ImageKit")]
	public static NSString ShowEmptyPictureKey
	{
		get
		{
			if (_ShowEmptyPictureKey == null)
			{
				_ShowEmptyPictureKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerShowEmptyPictureKey");
			}
			return _ShowEmptyPictureKey;
		}
	}

	[Field("IKPictureTakerRemainOpenAfterValidateKey", "ImageKit")]
	public static NSString RemainOpenAfterValidateKey
	{
		get
		{
			if (_RemainOpenAfterValidateKey == null)
			{
				_RemainOpenAfterValidateKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKPictureTakerRemainOpenAfterValidateKey");
			}
			return _RemainOpenAfterValidateKey;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKPictureTaker()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKPictureTaker(NSCoder coder)
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
	public IKPictureTaker(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKPictureTaker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("runModal")]
	public virtual int RunModal()
	{
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend(base.Handle, selRunModalHandle);
		}
		return Messaging.int_objc_msgSendSuper(base.SuperHandle, selRunModalHandle);
	}

	[Export("beginPictureTakerWithDelegate:didEndSelector:contextInfo:")]
	public virtual void BeginPictureTaker(NSObject aDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		if (aDelegate == null)
		{
			throw new ArgumentNullException("aDelegate");
		}
		if (didEndSelector == null)
		{
			throw new ArgumentNullException("didEndSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBeginPictureTakerWithDelegateDidEndSelectorContextInfo_Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginPictureTakerWithDelegateDidEndSelectorContextInfo_Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:")]
	public virtual void BeginPictureTakerSheet(NSWindow aWindow, NSObject aDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		if (aWindow == null)
		{
			throw new ArgumentNullException("aWindow");
		}
		if (aDelegate == null)
		{
			throw new ArgumentNullException("aDelegate");
		}
		if (didEndSelector == null)
		{
			throw new ArgumentNullException("didEndSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginPictureTakerSheetForWindowWithDelegateDidEndSelectorContextInfo_Handle, aWindow.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginPictureTakerSheetForWindowWithDelegateDidEndSelectorContextInfo_Handle, aWindow.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:")]
	public virtual void PopUpRecentsMenu(NSView aView, NSObject aDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (aDelegate == null)
		{
			throw new ArgumentNullException("aDelegate");
		}
		if (didEndSelector == null)
		{
			throw new ArgumentNullException("didEndSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPopUpRecentsMenuForViewWithDelegateDidEndSelectorContextInfo_Handle, aView.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPopUpRecentsMenuForViewWithDelegateDidEndSelectorContextInfo_Handle, aView.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("outputImage")]
	public virtual NSImage GetOutputImage()
	{
		if (IsDirectBinding)
		{
			return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputImageHandle));
		}
		return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputImageHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_InputImage_var = null;
		}
	}
}
