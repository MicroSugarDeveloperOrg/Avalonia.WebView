using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageBrowserItem", true)]
[Model]
public abstract class IKImageBrowserItem : NSObject
{
	private static NSString _PathRepresentationType;

	private static NSString _NSURLRepresentationType;

	private static NSString _NSImageRepresentationType;

	private static NSString _CGImageRepresentationType;

	private static NSString _CGImageSourceRepresentationType;

	private static NSString _NSDataRepresentationType;

	private static NSString _NSBitmapImageRepresentationType;

	private static NSString _QTMovieRepresentationType;

	private static NSString _QTMoviePathRepresentationType;

	private static NSString _QCCompositionRepresentationType;

	private static NSString _QCCompositionPathRepresentationType;

	private static NSString _QuickLookPathRepresentationType;

	private static NSString _IconRefPathRepresentationType;

	private static NSString _IconRefRepresentationType;

	private static NSString _PDFPageRepresentationType;

	public abstract string ImageUID
	{
		[Export("imageUID")]
		get;
	}

	public abstract NSString ImageRepresentationType
	{
		[Export("imageRepresentationType")]
		get;
	}

	public abstract NSObject ImageRepresentation
	{
		[Export("imageRepresentation")]
		get;
	}

	public virtual int ImageVersion
	{
		[Export("imageVersion")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	public virtual string ImageTitle
	{
		[Export("imageTitle")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	public virtual string ImageSubtitle
	{
		[Export("imageSubtitle")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	public virtual bool IsSelectable
	{
		[Export("isSelectable")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[Field("IKImageBrowserPathRepresentationType", "ImageKit")]
	public static NSString PathRepresentationType
	{
		get
		{
			if (_PathRepresentationType == null)
			{
				_PathRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserPathRepresentationType");
			}
			return _PathRepresentationType;
		}
	}

	[Field("IKImageBrowserNSURLRepresentationType", "ImageKit")]
	public static NSString NSURLRepresentationType
	{
		get
		{
			if (_NSURLRepresentationType == null)
			{
				_NSURLRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserNSURLRepresentationType");
			}
			return _NSURLRepresentationType;
		}
	}

	[Field("IKImageBrowserNSImageRepresentationType", "ImageKit")]
	public static NSString NSImageRepresentationType
	{
		get
		{
			if (_NSImageRepresentationType == null)
			{
				_NSImageRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserNSImageRepresentationType");
			}
			return _NSImageRepresentationType;
		}
	}

	[Field("IKImageBrowserCGImageRepresentationType", "ImageKit")]
	public static NSString CGImageRepresentationType
	{
		get
		{
			if (_CGImageRepresentationType == null)
			{
				_CGImageRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCGImageRepresentationType");
			}
			return _CGImageRepresentationType;
		}
	}

	[Field("IKImageBrowserCGImageSourceRepresentationType", "ImageKit")]
	public static NSString CGImageSourceRepresentationType
	{
		get
		{
			if (_CGImageSourceRepresentationType == null)
			{
				_CGImageSourceRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCGImageSourceRepresentationType");
			}
			return _CGImageSourceRepresentationType;
		}
	}

	[Field("IKImageBrowserNSDataRepresentationType", "ImageKit")]
	public static NSString NSDataRepresentationType
	{
		get
		{
			if (_NSDataRepresentationType == null)
			{
				_NSDataRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserNSDataRepresentationType");
			}
			return _NSDataRepresentationType;
		}
	}

	[Field("IKImageBrowserNSBitmapImageRepresentationType", "ImageKit")]
	public static NSString NSBitmapImageRepresentationType
	{
		get
		{
			if (_NSBitmapImageRepresentationType == null)
			{
				_NSBitmapImageRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserNSBitmapImageRepresentationType");
			}
			return _NSBitmapImageRepresentationType;
		}
	}

	[Field("IKImageBrowserQTMovieRepresentationType", "ImageKit")]
	public static NSString QTMovieRepresentationType
	{
		get
		{
			if (_QTMovieRepresentationType == null)
			{
				_QTMovieRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserQTMovieRepresentationType");
			}
			return _QTMovieRepresentationType;
		}
	}

	[Field("IKImageBrowserQTMoviePathRepresentationType", "ImageKit")]
	public static NSString QTMoviePathRepresentationType
	{
		get
		{
			if (_QTMoviePathRepresentationType == null)
			{
				_QTMoviePathRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserQTMoviePathRepresentationType");
			}
			return _QTMoviePathRepresentationType;
		}
	}

	[Field("IKImageBrowserQCCompositionRepresentationType", "ImageKit")]
	public static NSString QCCompositionRepresentationType
	{
		get
		{
			if (_QCCompositionRepresentationType == null)
			{
				_QCCompositionRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserQCCompositionRepresentationType");
			}
			return _QCCompositionRepresentationType;
		}
	}

	[Field("IKImageBrowserQCCompositionPathRepresentationType", "ImageKit")]
	public static NSString QCCompositionPathRepresentationType
	{
		get
		{
			if (_QCCompositionPathRepresentationType == null)
			{
				_QCCompositionPathRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserQCCompositionPathRepresentationType");
			}
			return _QCCompositionPathRepresentationType;
		}
	}

	[Field("IKImageBrowserQuickLookPathRepresentationType", "ImageKit")]
	public static NSString QuickLookPathRepresentationType
	{
		get
		{
			if (_QuickLookPathRepresentationType == null)
			{
				_QuickLookPathRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserQuickLookPathRepresentationType");
			}
			return _QuickLookPathRepresentationType;
		}
	}

	[Field("IKImageBrowserIconRefPathRepresentationType", "ImageKit")]
	public static NSString IconRefPathRepresentationType
	{
		get
		{
			if (_IconRefPathRepresentationType == null)
			{
				_IconRefPathRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserIconRefPathRepresentationType");
			}
			return _IconRefPathRepresentationType;
		}
	}

	[Field("IKImageBrowserIconRefRepresentationType", "ImageKit")]
	public static NSString IconRefRepresentationType
	{
		get
		{
			if (_IconRefRepresentationType == null)
			{
				_IconRefRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserIconRefRepresentationType");
			}
			return _IconRefRepresentationType;
		}
	}

	[Field("IKImageBrowserPDFPageRepresentationType", "ImageKit")]
	public static NSString PDFPageRepresentationType
	{
		get
		{
			if (_PDFPageRepresentationType == null)
			{
				_PDFPageRepresentationType = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserPDFPageRepresentationType");
			}
			return _PDFPageRepresentationType;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserItem()
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
	public IKImageBrowserItem(NSCoder coder)
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
	public IKImageBrowserItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageBrowserItem(IntPtr handle)
		: base(handle)
	{
	}
}
