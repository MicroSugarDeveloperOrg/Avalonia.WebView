using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol(IsInformal = true)]
[Register("IKImageBrowserItem", false)]
[Model]
public abstract class IKImageBrowserItem : NSObject, IIKImageBrowserItem, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CGImageRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CGImageSourceRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IconRefPathRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IconRefRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSBitmapImageRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSDataRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSImageRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSURLRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PDFPageRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PathRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QCCompositionPathRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QCCompositionRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QTMoviePathRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QTMovieRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QuickLookPathRepresentationType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSObject ImageRepresentation
	{
		[Export("imageRepresentation")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSString ImageRepresentationType
	{
		[Export("imageRepresentationType")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ImageSubtitle
	{
		[Export("imageSubtitle")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ImageTitle
	{
		[Export("imageTitle")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string ImageUID
	{
		[Export("imageUID")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ImageVersion
	{
		[Export("imageVersion")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSelectable
	{
		[Export("isSelectable")]
		get
		{
			throw new ModelNotImplementedException();
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected IKImageBrowserItem()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKImageBrowserItem(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageBrowserItem(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}
}
