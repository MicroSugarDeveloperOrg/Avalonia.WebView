using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKSlideshow", true)]
public class IKSlideshow : NSObject
{
	private static readonly IntPtr selSharedSlideshowHandle = Selector.GetHandle("sharedSlideshow");

	private static readonly IntPtr selAutoPlayDelayHandle = Selector.GetHandle("autoPlayDelay");

	private static readonly IntPtr selSetAutoPlayDelay_Handle = Selector.GetHandle("setAutoPlayDelay:");

	private static readonly IntPtr selIndexOfCurrentSlideshowItemHandle = Selector.GetHandle("indexOfCurrentSlideshowItem");

	private static readonly IntPtr selRunSlideshowWithDataSourceInModeOptions_Handle = Selector.GetHandle("runSlideshowWithDataSource:inMode:options:");

	private static readonly IntPtr selStopSlideshow_Handle = Selector.GetHandle("stopSlideshow:");

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	private static readonly IntPtr selReloadSlideshowItemAtIndex_Handle = Selector.GetHandle("reloadSlideshowItemAtIndex:");

	private static readonly IntPtr selCanExportToApplication_Handle = Selector.GetHandle("canExportToApplication:");

	private static readonly IntPtr selExportSlideshowItemToApplication_Handle = Selector.GetHandle("exportSlideshowItem:toApplication:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKSlideshow");

	private static object __mt_SharedSlideshow_var_static;

	private static NSString _ModeImages;

	private static NSString _ModePDF;

	private static NSString _ModeOther;

	private static NSString _WrapAround;

	private static NSString _StartPaused;

	private static NSString _StartIndex;

	private static NSString _Screen;

	private static NSString _AudioFile;

	private static NSString _PDFDisplayBox;

	private static NSString _PDFDisplayMode;

	private static NSString _PDFDisplaysAsBook;

	private static NSString _IPhotoBundleIdentifier;

	private static NSString _ApertureBundleIdentifier;

	private static NSString _MailBundleIdentifier;

	public override IntPtr ClassHandle => class_ptr;

	public static IKSlideshow SharedSlideshow
	{
		[Export("sharedSlideshow")]
		get
		{
			return (IKSlideshow)(__mt_SharedSlideshow_var_static = (IKSlideshow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedSlideshowHandle)));
		}
	}

	public virtual double autoPlayDelay
	{
		[Export("autoPlayDelay")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAutoPlayDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAutoPlayDelayHandle);
		}
		[Export("setAutoPlayDelay:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAutoPlayDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAutoPlayDelay_Handle, value);
			}
		}
	}

	public virtual int IndexOfCurrentSlideshowItem
	{
		[Export("indexOfCurrentSlideshowItem")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIndexOfCurrentSlideshowItemHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIndexOfCurrentSlideshowItemHandle);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKSlideshow()
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
	public IKSlideshow(NSCoder coder)
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
	public IKSlideshow(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKSlideshow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("runSlideshowWithDataSource:inMode:options:")]
	public virtual void RunSlideshow(IKSlideshowDataSource dataSource, string slideshowMode, NSDictionary slideshowOptions)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRunSlideshowWithDataSourceInModeOptions_Handle, dataSource.Handle, arg, slideshowOptions.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunSlideshowWithDataSourceInModeOptions_Handle, dataSource.Handle, arg, slideshowOptions.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("stopSlideshow:")]
	public virtual void StopSlideshow(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopSlideshow_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopSlideshow_Handle, sender.Handle);
		}
	}

	[Export("reloadData")]
	public virtual void ReloadData()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("reloadSlideshowItemAtIndex:")]
	public virtual void ReloadSlideshowItem(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selReloadSlideshowItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selReloadSlideshowItemAtIndex_Handle, index);
		}
	}

	[Export("canExportToApplication:")]
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selExportSlideshowItemToApplication_Handle, item.Handle, arg);
		NSString.ReleaseNative(arg);
	}
}
