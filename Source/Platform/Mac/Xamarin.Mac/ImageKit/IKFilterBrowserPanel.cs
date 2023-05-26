using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKFilterBrowserPanel", true)]
public class IKFilterBrowserPanel : NSPanel
{
	private static readonly IntPtr selFilterNameHandle = Selector.GetHandle("filterName");

	private static readonly IntPtr selFilterBrowserPanelWithStyleMask_Handle = Selector.GetHandle("filterBrowserPanelWithStyleMask:");

	private static readonly IntPtr selBeginWithOptionsModelessDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selBeginSheetWithOptionsModalForWindowModalDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selRunModalWithOptions_Handle = Selector.GetHandle("runModalWithOptions:");

	private static readonly IntPtr selFilterBrowserViewWithOptions_Handle = Selector.GetHandle("filterBrowserViewWithOptions:");

	private static readonly IntPtr selFinish_Handle = Selector.GetHandle("finish:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKFilterBrowserPanel");

	private static NSString _FilterSelectedNotification;

	private static NSString _FilterDoubleClickNotification;

	private static NSString _WillPreviewFilterNotification;

	private static NSString _ShowCategories;

	private static NSString _ShowPreview;

	private static NSString _ExcludeCategories;

	private static NSString _ExcludeFilters;

	private static NSString _DefaultInputImage;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string FilterName
	{
		[Export("filterName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterNameHandle));
		}
	}

	[Field("IKFilterBrowserFilterSelectedNotification", "ImageKit")]
	public static NSString FilterSelectedNotification
	{
		get
		{
			if (_FilterSelectedNotification == null)
			{
				_FilterSelectedNotification = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserFilterSelectedNotification");
			}
			return _FilterSelectedNotification;
		}
	}

	[Field("IKFilterBrowserFilterDoubleClickNotification", "ImageKit")]
	public static NSString FilterDoubleClickNotification
	{
		get
		{
			if (_FilterDoubleClickNotification == null)
			{
				_FilterDoubleClickNotification = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserFilterDoubleClickNotification");
			}
			return _FilterDoubleClickNotification;
		}
	}

	[Field("IKFilterBrowserWillPreviewFilterNotification", "ImageKit")]
	public static NSString WillPreviewFilterNotification
	{
		get
		{
			if (_WillPreviewFilterNotification == null)
			{
				_WillPreviewFilterNotification = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserWillPreviewFilterNotification");
			}
			return _WillPreviewFilterNotification;
		}
	}

	[Field("IKFilterBrowserShowCategories", "ImageKit")]
	public static NSString ShowCategories
	{
		get
		{
			if (_ShowCategories == null)
			{
				_ShowCategories = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserShowCategories");
			}
			return _ShowCategories;
		}
	}

	[Field("IKFilterBrowserShowPreview", "ImageKit")]
	public static NSString ShowPreview
	{
		get
		{
			if (_ShowPreview == null)
			{
				_ShowPreview = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserShowPreview");
			}
			return _ShowPreview;
		}
	}

	[Field("IKFilterBrowserExcludeCategories", "ImageKit")]
	public static NSString ExcludeCategories
	{
		get
		{
			if (_ExcludeCategories == null)
			{
				_ExcludeCategories = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserExcludeCategories");
			}
			return _ExcludeCategories;
		}
	}

	[Field("IKFilterBrowserExcludeFilters", "ImageKit")]
	public static NSString ExcludeFilters
	{
		get
		{
			if (_ExcludeFilters == null)
			{
				_ExcludeFilters = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserExcludeFilters");
			}
			return _ExcludeFilters;
		}
	}

	[Field("IKFilterBrowserDefaultInputImage", "ImageKit")]
	public static NSString DefaultInputImage
	{
		get
		{
			if (_DefaultInputImage == null)
			{
				_DefaultInputImage = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKFilterBrowserDefaultInputImage");
			}
			return _DefaultInputImage;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKFilterBrowserPanel()
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
	public IKFilterBrowserPanel(NSCoder coder)
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
	public IKFilterBrowserPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKFilterBrowserPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("filterBrowserPanelWithStyleMask:")]
	public IKFilterBrowserPanel(IKFilterBrowserPanelStyleMask styleMask)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int(base.Handle, selFilterBrowserPanelWithStyleMask_Handle, (int)styleMask);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selFilterBrowserPanelWithStyleMask_Handle, (int)styleMask);
		}
	}

	[Export("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:")]
	public virtual void Begin(NSDictionary options, NSObject modelessDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (modelessDelegate == null)
		{
			throw new ArgumentNullException("modelessDelegate");
		}
		if (didEndSelector == null)
		{
			throw new ArgumentNullException("didEndSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginWithOptionsModelessDelegateDidEndSelectorContextInfo_Handle, options.Handle, modelessDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginWithOptionsModelessDelegateDidEndSelectorContextInfo_Handle, options.Handle, modelessDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	public virtual void BeginSheet(NSDictionary options, NSWindow docWindow, NSObject modalDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (docWindow == null)
		{
			throw new ArgumentNullException("docWindow");
		}
		if (modalDelegate == null)
		{
			throw new ArgumentNullException("modalDelegate");
		}
		if (didEndSelector == null)
		{
			throw new ArgumentNullException("didEndSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetWithOptionsModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, options.Handle, docWindow.Handle, modalDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetWithOptionsModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, options.Handle, docWindow.Handle, modalDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("runModalWithOptions:")]
	public virtual int RunModal(NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_IntPtr(base.Handle, selRunModalWithOptions_Handle, options.Handle);
		}
		return Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunModalWithOptions_Handle, options.Handle);
	}

	[Export("filterBrowserViewWithOptions:")]
	public virtual IKFilterBrowserView FilterBrowserView(NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return (IKFilterBrowserView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFilterBrowserViewWithOptions_Handle, options.Handle));
		}
		return (IKFilterBrowserView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFilterBrowserViewWithOptions_Handle, options.Handle));
	}

	[Export("finish:")]
	public virtual void Finish(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinish_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinish_Handle, sender.Handle);
		}
	}
}
