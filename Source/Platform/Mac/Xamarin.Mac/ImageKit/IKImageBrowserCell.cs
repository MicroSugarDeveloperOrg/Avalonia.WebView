using System.ComponentModel;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Register("IKImageBrowserCell", true)]
public class IKImageBrowserCell : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellState = "cellState";

	private static readonly IntPtr selCellStateHandle = Selector.GetHandle("cellState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAlignment = "imageAlignment";

	private static readonly IntPtr selImageAlignmentHandle = Selector.GetHandle("imageAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageBrowserView = "imageBrowserView";

	private static readonly IntPtr selImageBrowserViewHandle = Selector.GetHandle("imageBrowserView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageContainerFrame = "imageContainerFrame";

	private static readonly IntPtr selImageContainerFrameHandle = Selector.GetHandle("imageContainerFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageFrame = "imageFrame";

	private static readonly IntPtr selImageFrameHandle = Selector.GetHandle("imageFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfRepresentedItem = "indexOfRepresentedItem";

	private static readonly IntPtr selIndexOfRepresentedItemHandle = Selector.GetHandle("indexOfRepresentedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelected = "isSelected";

	private static readonly IntPtr selIsSelectedHandle = Selector.GetHandle("isSelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerForType_ = "layerForType:";

	private static readonly IntPtr selLayerForType_Handle = Selector.GetHandle("layerForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpacity = "opacity";

	private static readonly IntPtr selOpacityHandle = Selector.GetHandle("opacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedItem = "representedItem";

	private static readonly IntPtr selRepresentedItemHandle = Selector.GetHandle("representedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionFrame = "selectionFrame";

	private static readonly IntPtr selSelectionFrameHandle = Selector.GetHandle("selectionFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtitleFrame = "subtitleFrame";

	private static readonly IntPtr selSubtitleFrameHandle = Selector.GetHandle("subtitleFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleFrame = "titleFrame";

	private static readonly IntPtr selTitleFrameHandle = Selector.GetHandle("titleFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKImageBrowserCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundLayer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ForegroundLayer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaceHolderLayer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionLayer;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKImageBrowserCellState CellState
	{
		[Export("cellState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKImageBrowserCellState)Messaging.int_objc_msgSend(base.Handle, selCellStateHandle);
			}
			return (IKImageBrowserCellState)Messaging.int_objc_msgSendSuper(base.SuperHandle, selCellStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageAlignment ImageAlignment
	{
		[Export("imageAlignment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSImageAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selImageAlignmentHandle);
			}
			return (NSImageAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageAlignmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKImageBrowserView ImageBrowserView
	{
		[Export("imageBrowserView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<IKImageBrowserView>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageBrowserViewHandle));
			}
			return Runtime.GetNSObject<IKImageBrowserView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageBrowserViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ImageContainerFrame
	{
		[Export("imageContainerFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selImageContainerFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selImageContainerFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ImageFrame
	{
		[Export("imageFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selImageFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selImageFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfRepresentedItem
	{
		[Export("indexOfRepresentedItem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIndexOfRepresentedItemHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIndexOfRepresentedItemHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSelected
	{
		[Export("isSelected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Opacity
	{
		[Export("opacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selOpacityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selOpacityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject RepresentedItem
	{
		[Export("representedItem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedItemHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect SelectionFrame
	{
		[Export("selectionFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selSelectionFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSelectionFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect SubtitleFrame
	{
		[Export("subtitleFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selSubtitleFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSubtitleFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect TitleFrame
	{
		[Export("titleFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selTitleFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTitleFrameHandle);
			}
			return retval;
		}
	}

	[Field("IKImageBrowserCellBackgroundLayer", "ImageKit")]
	public static NSString BackgroundLayer
	{
		get
		{
			if (_BackgroundLayer == null)
			{
				_BackgroundLayer = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellBackgroundLayer");
			}
			return _BackgroundLayer;
		}
	}

	[Field("IKImageBrowserCellForegroundLayer", "ImageKit")]
	public static NSString ForegroundLayer
	{
		get
		{
			if (_ForegroundLayer == null)
			{
				_ForegroundLayer = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellForegroundLayer");
			}
			return _ForegroundLayer;
		}
	}

	[Field("IKImageBrowserCellPlaceHolderLayer", "ImageKit")]
	public static NSString PlaceHolderLayer
	{
		get
		{
			if (_PlaceHolderLayer == null)
			{
				_PlaceHolderLayer = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellPlaceHolderLayer");
			}
			return _PlaceHolderLayer;
		}
	}

	[Field("IKImageBrowserCellSelectionLayer", "ImageKit")]
	public static NSString SelectionLayer
	{
		get
		{
			if (_SelectionLayer == null)
			{
				_SelectionLayer = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellSelectionLayer");
			}
			return _SelectionLayer;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserCell()
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
	protected IKImageBrowserCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageBrowserCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layerForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer Layer(string layerType)
	{
		if (layerType == null)
		{
			throw new ArgumentNullException("layerType");
		}
		IntPtr arg = NSString.CreateNative(layerType);
		CALayer result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayerForType_Handle, arg)) : Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLayerForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
