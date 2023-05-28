using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKSlideshow", true)]
public class IKSlideshow : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoPlayDelay = "autoPlayDelay";

	private static readonly IntPtr selAutoPlayDelayHandle = Selector.GetHandle("autoPlayDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanExportToApplication_ = "canExportToApplication:";

	private static readonly IntPtr selCanExportToApplication_Handle = Selector.GetHandle("canExportToApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportSlideshowItem_ToApplication_ = "exportSlideshowItem:toApplication:";

	private static readonly IntPtr selExportSlideshowItem_ToApplication_Handle = Selector.GetHandle("exportSlideshowItem:toApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfCurrentSlideshowItem = "indexOfCurrentSlideshowItem";

	private static readonly IntPtr selIndexOfCurrentSlideshowItemHandle = Selector.GetHandle("indexOfCurrentSlideshowItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadSlideshowItemAtIndex_ = "reloadSlideshowItemAtIndex:";

	private static readonly IntPtr selReloadSlideshowItemAtIndex_Handle = Selector.GetHandle("reloadSlideshowItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunSlideshowWithDataSource_InMode_Options_ = "runSlideshowWithDataSource:inMode:options:";

	private static readonly IntPtr selRunSlideshowWithDataSource_InMode_Options_Handle = Selector.GetHandle("runSlideshowWithDataSource:inMode:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoPlayDelay_ = "setAutoPlayDelay:";

	private static readonly IntPtr selSetAutoPlayDelay_Handle = Selector.GetHandle("setAutoPlayDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSlideshow = "sharedSlideshow";

	private static readonly IntPtr selSharedSlideshowHandle = Selector.GetHandle("sharedSlideshow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSlideshow_ = "stopSlideshow:";

	private static readonly IntPtr selStopSlideshow_Handle = Selector.GetHandle("stopSlideshow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKSlideshow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureBundleIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPhotoBundleIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MailBundleIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeImages;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeOther;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModePDF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PDFDisplayBox;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PDFDisplayMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PDFDisplaysAsBook;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhotosBundleIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Screen;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StartIndex;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StartPaused;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WrapAround;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfCurrentSlideshowItem
	{
		[Export("indexOfCurrentSlideshowItem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIndexOfCurrentSlideshowItemHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIndexOfCurrentSlideshowItemHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IKSlideshow SharedSlideshow
	{
		[Export("sharedSlideshow")]
		get
		{
			return Runtime.GetNSObject<IKSlideshow>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedSlideshowHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double autoPlayDelay
	{
		[Export("autoPlayDelay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAutoPlayDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAutoPlayDelayHandle);
		}
		[Export("setAutoPlayDelay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAutoPlayDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAutoPlayDelay_Handle, value);
			}
		}
	}

	[Field("IK_ApertureBundleIdentifier", "ImageKit")]
	public static NSString ApertureBundleIdentifier
	{
		get
		{
			if (_ApertureBundleIdentifier == null)
			{
				_ApertureBundleIdentifier = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IK_ApertureBundleIdentifier");
			}
			return _ApertureBundleIdentifier;
		}
	}

	[Field("IKSlideshowAudioFile", "ImageKit")]
	public static NSString AudioFile
	{
		get
		{
			if (_AudioFile == null)
			{
				_AudioFile = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowAudioFile");
			}
			return _AudioFile;
		}
	}

	[Field("IK_iPhotoBundleIdentifier", "ImageKit")]
	public static NSString IPhotoBundleIdentifier
	{
		get
		{
			if (_IPhotoBundleIdentifier == null)
			{
				_IPhotoBundleIdentifier = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IK_iPhotoBundleIdentifier");
			}
			return _IPhotoBundleIdentifier;
		}
	}

	[Field("IK_MailBundleIdentifier", "ImageKit")]
	public static NSString MailBundleIdentifier
	{
		get
		{
			if (_MailBundleIdentifier == null)
			{
				_MailBundleIdentifier = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IK_MailBundleIdentifier");
			}
			return _MailBundleIdentifier;
		}
	}

	[Field("IKSlideshowModeImages", "ImageKit")]
	public static NSString ModeImages
	{
		get
		{
			if (_ModeImages == null)
			{
				_ModeImages = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowModeImages");
			}
			return _ModeImages;
		}
	}

	[Field("IKSlideshowModeOther", "ImageKit")]
	public static NSString ModeOther
	{
		get
		{
			if (_ModeOther == null)
			{
				_ModeOther = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowModeOther");
			}
			return _ModeOther;
		}
	}

	[Field("IKSlideshowModePDF", "ImageKit")]
	public static NSString ModePDF
	{
		get
		{
			if (_ModePDF == null)
			{
				_ModePDF = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowModePDF");
			}
			return _ModePDF;
		}
	}

	[Field("IKSlideshowPDFDisplayBox", "ImageKit")]
	public static NSString PDFDisplayBox
	{
		get
		{
			if (_PDFDisplayBox == null)
			{
				_PDFDisplayBox = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowPDFDisplayBox");
			}
			return _PDFDisplayBox;
		}
	}

	[Field("IKSlideshowPDFDisplayMode", "ImageKit")]
	public static NSString PDFDisplayMode
	{
		get
		{
			if (_PDFDisplayMode == null)
			{
				_PDFDisplayMode = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowPDFDisplayMode");
			}
			return _PDFDisplayMode;
		}
	}

	[Field("IKSlideshowPDFDisplaysAsBook", "ImageKit")]
	public static NSString PDFDisplaysAsBook
	{
		get
		{
			if (_PDFDisplaysAsBook == null)
			{
				_PDFDisplaysAsBook = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowPDFDisplaysAsBook");
			}
			return _PDFDisplaysAsBook;
		}
	}

	[Field("IK_PhotosBundleIdentifier", "ImageKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	public static NSString PhotosBundleIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_PhotosBundleIdentifier == null)
			{
				_PhotosBundleIdentifier = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IK_PhotosBundleIdentifier");
			}
			return _PhotosBundleIdentifier;
		}
	}

	[Field("IKSlideshowScreen", "ImageKit")]
	public static NSString Screen
	{
		get
		{
			if (_Screen == null)
			{
				_Screen = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowScreen");
			}
			return _Screen;
		}
	}

	[Field("IKSlideshowStartIndex", "ImageKit")]
	public static NSString StartIndex
	{
		get
		{
			if (_StartIndex == null)
			{
				_StartIndex = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowStartIndex");
			}
			return _StartIndex;
		}
	}

	[Field("IKSlideshowStartPaused", "ImageKit")]
	public static NSString StartPaused
	{
		get
		{
			if (_StartPaused == null)
			{
				_StartPaused = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowStartPaused");
			}
			return _StartPaused;
		}
	}

	[Field("IKSlideshowWrapAround", "ImageKit")]
	public static NSString WrapAround
	{
		get
		{
			if (_WrapAround == null)
			{
				_WrapAround = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKSlideshowWrapAround");
			}
			return _WrapAround;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKSlideshow()
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
	protected IKSlideshow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKSlideshow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canExportToApplication:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanExportToApplication(string applicationBundleIdentifier)
	{
		if (applicationBundleIdentifier == null)
		{
			throw new ArgumentNullException("applicationBundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(applicationBundleIdentifier);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanExportToApplication_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("exportSlideshowItem:toApplication:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ExportSlideshowItemtoApplication(NSObject item, string applicationBundleIdentifier)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (applicationBundleIdentifier == null)
		{
			throw new ArgumentNullException("applicationBundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(applicationBundleIdentifier);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selExportSlideshowItem_ToApplication_Handle, item.Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("reloadSlideshowItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadSlideshowItem(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selReloadSlideshowItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selReloadSlideshowItemAtIndex_Handle, index);
		}
	}

	[Export("runSlideshowWithDataSource:inMode:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunSlideshow(IIKSlideshowDataSource dataSource, string slideshowMode, NSDictionary slideshowOptions)
	{
		if (dataSource != null)
		{
			if (!(dataSource is NSObject))
			{
				throw new ArgumentException("The object passed of type " + dataSource.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (slideshowMode == null)
			{
				throw new ArgumentNullException("slideshowMode");
			}
			if (slideshowOptions == null)
			{
				throw new ArgumentNullException("slideshowOptions");
			}
			IntPtr arg = NSString.CreateNative(slideshowMode);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRunSlideshowWithDataSource_InMode_Options_Handle, dataSource.Handle, arg, slideshowOptions.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunSlideshowWithDataSource_InMode_Options_Handle, dataSource.Handle, arg, slideshowOptions.Handle);
			}
			NSString.ReleaseNative(arg);
			return;
		}
		throw new ArgumentNullException("dataSource");
	}

	[Export("stopSlideshow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopSlideshow(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopSlideshow_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopSlideshow_Handle, sender.Handle);
		}
	}
}
