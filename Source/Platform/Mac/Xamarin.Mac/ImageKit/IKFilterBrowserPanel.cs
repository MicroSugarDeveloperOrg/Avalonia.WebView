using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKFilterBrowserPanel", true)]
public class IKFilterBrowserPanel : NSPanel
{
	public new static class Notifications
	{
		public static NSObject ObserveFilterDoubleClick(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FilterDoubleClickNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFilterDoubleClick(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FilterDoubleClickNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFilterSelected(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FilterSelectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFilterSelected(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FilterSelectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillPreviewFilter(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillPreviewFilterNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillPreviewFilter(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillPreviewFilterNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_ = "beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_ = "beginWithOptions:modelessDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterBrowserPanelWithStyleMask_ = "filterBrowserPanelWithStyleMask:";

	private static readonly IntPtr selFilterBrowserPanelWithStyleMask_Handle = Selector.GetHandle("filterBrowserPanelWithStyleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterBrowserViewWithOptions_ = "filterBrowserViewWithOptions:";

	private static readonly IntPtr selFilterBrowserViewWithOptions_Handle = Selector.GetHandle("filterBrowserViewWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterName = "filterName";

	private static readonly IntPtr selFilterNameHandle = Selector.GetHandle("filterName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinish_ = "finish:";

	private static readonly IntPtr selFinish_Handle = Selector.GetHandle("finish:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalWithOptions_ = "runModalWithOptions:";

	private static readonly IntPtr selRunModalWithOptions_Handle = Selector.GetHandle("runModalWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKFilterBrowserPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DefaultInputImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExcludeCategories;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExcludeFilters;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterDoubleClickNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterSelectedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowCategories;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowPreview;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillPreviewFilterNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FilterName
	{
		[Export("filterName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterNameHandle));
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

	[Field("IKFilterBrowserFilterDoubleClickNotification", "ImageKit")]
	[Advice("Use IKFilterBrowserPanel.Notifications.ObserveFilterDoubleClick helper method instead.")]
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

	[Field("IKFilterBrowserFilterSelectedNotification", "ImageKit")]
	[Advice("Use IKFilterBrowserPanel.Notifications.ObserveFilterSelected helper method instead.")]
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

	[Field("IKFilterBrowserWillPreviewFilterNotification", "ImageKit")]
	[Advice("Use IKFilterBrowserPanel.Notifications.ObserveWillPreviewFilter helper method instead.")]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKFilterBrowserPanel()
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
	public IKFilterBrowserPanel(NSCoder coder)
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
	protected IKFilterBrowserPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKFilterBrowserPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_Handle, options.Handle, modelessDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginWithOptions_ModelessDelegate_DidEndSelector_ContextInfo_Handle, options.Handle, modelessDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, options.Handle, docWindow.Handle, modalDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetWithOptions_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, options.Handle, docWindow.Handle, modalDelegate.Handle, didEndSelector.Handle, contextInfo);
		}
	}

	[Export("filterBrowserPanelWithStyleMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IKFilterBrowserPanel Create(IKFilterBrowserPanelStyleMask styleMask)
	{
		return Runtime.GetNSObject<IKFilterBrowserPanel>(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selFilterBrowserPanelWithStyleMask_Handle, (uint)styleMask));
	}

	[Export("filterBrowserViewWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKFilterBrowserView FilterBrowserView(NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<IKFilterBrowserView>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFilterBrowserViewWithOptions_Handle, options.Handle));
		}
		return Runtime.GetNSObject<IKFilterBrowserView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFilterBrowserViewWithOptions_Handle, options.Handle));
	}

	[Export("finish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finish(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinish_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinish_Handle, sender.Handle);
		}
	}

	[Export("runModalWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int RunModal(NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_IntPtr(base.Handle, selRunModalWithOptions_Handle, options.Handle);
		}
		return Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunModalWithOptions_Handle, options.Handle);
	}
}
