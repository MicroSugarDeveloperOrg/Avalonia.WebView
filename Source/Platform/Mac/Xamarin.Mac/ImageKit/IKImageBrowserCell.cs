using System;
using System.ComponentModel;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageBrowserCell", true)]
public class IKImageBrowserCell : NSObject
{
	private static readonly IntPtr selImageBrowserViewHandle = Selector.GetHandle("imageBrowserView");

	private static readonly IntPtr selRepresentedItemHandle = Selector.GetHandle("representedItem");

	private static readonly IntPtr selIndexOfRepresentedItemHandle = Selector.GetHandle("indexOfRepresentedItem");

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	private static readonly IntPtr selImageContainerFrameHandle = Selector.GetHandle("imageContainerFrame");

	private static readonly IntPtr selImageFrameHandle = Selector.GetHandle("imageFrame");

	private static readonly IntPtr selSelectionFrameHandle = Selector.GetHandle("selectionFrame");

	private static readonly IntPtr selTitleFrameHandle = Selector.GetHandle("titleFrame");

	private static readonly IntPtr selSubtitleFrameHandle = Selector.GetHandle("subtitleFrame");

	private static readonly IntPtr selImageAlignmentHandle = Selector.GetHandle("imageAlignment");

	private static readonly IntPtr selIsSelectedHandle = Selector.GetHandle("isSelected");

	private static readonly IntPtr selCellStateHandle = Selector.GetHandle("cellState");

	private static readonly IntPtr selOpacityHandle = Selector.GetHandle("opacity");

	private static readonly IntPtr selLayerForType_Handle = Selector.GetHandle("layerForType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKImageBrowserCell");

	private object __mt_ImageBrowserView_var;

	private object __mt_RepresentedItem_var;

	private static NSString _BackgroundLayer;

	private static NSString _ForegroundLayer;

	private static NSString _SelectionLayer;

	private static NSString _PlaceHolderLayer;

	public override IntPtr ClassHandle => class_ptr;

	public virtual IKImageBrowserView ImageBrowserView
	{
		[Export("imageBrowserView")]
		get
		{
			return (IKImageBrowserView)(__mt_ImageBrowserView_var = ((!IsDirectBinding) ? ((IKImageBrowserView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageBrowserViewHandle))) : ((IKImageBrowserView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageBrowserViewHandle)))));
		}
	}

	public virtual NSObject RepresentedItem
	{
		[Export("representedItem")]
		get
		{
			return (NSObject)(__mt_RepresentedItem_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedItemHandle))));
		}
	}

	public virtual int IndexOfRepresentedItem
	{
		[Export("indexOfRepresentedItem")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIndexOfRepresentedItemHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIndexOfRepresentedItemHandle);
		}
	}

	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect ImageContainerFrame
	{
		[Export("imageContainerFrame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect ImageFrame
	{
		[Export("imageFrame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect SelectionFrame
	{
		[Export("selectionFrame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect TitleFrame
	{
		[Export("titleFrame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect SubtitleFrame
	{
		[Export("subtitleFrame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual NSImageAlignment ImageAlignment
	{
		[Export("imageAlignment")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSImageAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selImageAlignmentHandle);
			}
			return (NSImageAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageAlignmentHandle);
		}
	}

	public virtual bool IsSelected
	{
		[Export("isSelected")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectedHandle);
		}
	}

	public virtual IKImageBrowserCellState CellState
	{
		[Export("cellState")]
		get
		{
			if (IsDirectBinding)
			{
				return (IKImageBrowserCellState)Messaging.int_objc_msgSend(base.Handle, selCellStateHandle);
			}
			return (IKImageBrowserCellState)Messaging.int_objc_msgSendSuper(base.SuperHandle, selCellStateHandle);
		}
	}

	public virtual double Opacity
	{
		[Export("opacity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selOpacityHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selOpacityHandle);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserCell()
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
	public IKImageBrowserCell(NSCoder coder)
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
	public IKImageBrowserCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageBrowserCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layerForType:")]
	public virtual CALayer Layer(string layerType)
	{
		if (layerType == null)
		{
			throw new ArgumentNullException("layerType");
		}
		IntPtr arg = NSString.CreateNative(layerType);
		CALayer result = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayerForType_Handle, arg))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLayerForType_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ImageBrowserView_var = null;
			__mt_RepresentedItem_var = null;
		}
	}
}
