using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Register("IKPictureTaker", true)]
public class IKPictureTaker : NSPanel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_ = "beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_ = "beginPictureTakerWithDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginPictureTakerWithDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputImage = "inputImage";

	private static readonly IntPtr selInputImageHandle = Selector.GetHandle("inputImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMirroring = "mirroring";

	private static readonly IntPtr selMirroringHandle = Selector.GetHandle("mirroring");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputImage = "outputImage";

	private static readonly IntPtr selOutputImageHandle = Selector.GetHandle("outputImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPictureTaker = "pictureTaker";

	private static readonly IntPtr selPictureTakerHandle = Selector.GetHandle("pictureTaker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_ = "popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModal = "runModal";

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputImage_ = "setInputImage:";

	private static readonly IntPtr selSetInputImage_Handle = Selector.GetHandle("setInputImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMirroring_ = "setMirroring:";

	private static readonly IntPtr selSetMirroring_Handle = Selector.GetHandle("setMirroring:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKPictureTaker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowsEditingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowsFileChoosingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowsVideoCaptureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CropAreaSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageTransformsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InformationalTextKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputImageMaxSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemainOpenAfterValidateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowAddressBookPictureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowEffectsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowEmptyPictureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowRecentPictureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UpdateRecentPictureKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage InputImage
	{
		[Export("inputImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputImageHandle));
		}
		[Export("setInputImage:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Mirroring
	{
		[Export("mirroring")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMirroringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMirroringHandle);
		}
		[Export("setMirroring:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMirroring_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMirroring_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IKPictureTaker SharedPictureTaker
	{
		[Export("pictureTaker")]
		get
		{
			return Runtime.GetNSObject<IKPictureTaker>(Messaging.IntPtr_objc_msgSend(class_ptr, selPictureTakerHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKPictureTaker()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKPictureTaker(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKPictureTaker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKPictureTaker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginPictureTakerWithDelegate:didEndSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_Handle, aWindow.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_Handle, aWindow.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("outputImage")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetOutputImage()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputImageHandle));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputImageHandle));
	}

	[Export("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_Handle, aView.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_Handle, aView.Handle, aDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("runModal")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModal()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selRunModalHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRunModalHandle);
	}
}
