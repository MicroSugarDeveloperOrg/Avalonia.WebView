using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSplitView", true)]
public class NSSplitView : NSView
{
	public new static class Notifications
	{
		public static NSObject ObserveNSSplitViewDidResizeSubviews(EventHandler<NSSplitViewDividerIndexEventArgs> handler)
		{
			EventHandler<NSSplitViewDividerIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSSplitViewDidResizeSubviewsNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSSplitViewDividerIndexEventArgs(notification));
			});
		}

		public static NSObject ObserveNSSplitViewDidResizeSubviews(NSObject objectToObserve, EventHandler<NSSplitViewDividerIndexEventArgs> handler)
		{
			EventHandler<NSSplitViewDividerIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSSplitViewDidResizeSubviewsNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSSplitViewDividerIndexEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveNSSplitViewWillResizeSubviews(EventHandler<NSSplitViewDividerIndexEventArgs> handler)
		{
			EventHandler<NSSplitViewDividerIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSSplitViewWillResizeSubviewsNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSSplitViewDividerIndexEventArgs(notification));
			});
		}

		public static NSObject ObserveNSSplitViewWillResizeSubviews(NSObject objectToObserve, EventHandler<NSSplitViewDividerIndexEventArgs> handler)
		{
			EventHandler<NSSplitViewDividerIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSSplitViewWillResizeSubviewsNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSSplitViewDividerIndexEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddArrangedSubview_ = "addArrangedSubview:";

	private static readonly IntPtr selAddArrangedSubview_Handle = Selector.GetHandle("addArrangedSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdjustSubviews = "adjustSubviews";

	private static readonly IntPtr selAdjustSubviewsHandle = Selector.GetHandle("adjustSubviews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrangedSubviews = "arrangedSubviews";

	private static readonly IntPtr selArrangedSubviewsHandle = Selector.GetHandle("arrangedSubviews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrangesAllSubviews = "arrangesAllSubviews";

	private static readonly IntPtr selArrangesAllSubviewsHandle = Selector.GetHandle("arrangesAllSubviews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveName = "autosaveName";

	private static readonly IntPtr selAutosaveNameHandle = Selector.GetHandle("autosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDividerColor = "dividerColor";

	private static readonly IntPtr selDividerColorHandle = Selector.GetHandle("dividerColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDividerStyle = "dividerStyle";

	private static readonly IntPtr selDividerStyleHandle = Selector.GetHandle("dividerStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDividerThickness = "dividerThickness";

	private static readonly IntPtr selDividerThicknessHandle = Selector.GetHandle("dividerThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawDividerInRect_ = "drawDividerInRect:";

	private static readonly IntPtr selDrawDividerInRect_Handle = Selector.GetHandle("drawDividerInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHoldingPriorityForSubviewAtIndex_ = "holdingPriorityForSubviewAtIndex:";

	private static readonly IntPtr selHoldingPriorityForSubviewAtIndex_Handle = Selector.GetHandle("holdingPriorityForSubviewAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertArrangedSubview_AtIndex_ = "insertArrangedSubview:atIndex:";

	private static readonly IntPtr selInsertArrangedSubview_AtIndex_Handle = Selector.GetHandle("insertArrangedSubview:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSubviewCollapsed_ = "isSubviewCollapsed:";

	private static readonly IntPtr selIsSubviewCollapsed_Handle = Selector.GetHandle("isSubviewCollapsed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVertical = "isVertical";

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxPossiblePositionOfDividerAtIndex_ = "maxPossiblePositionOfDividerAtIndex:";

	private static readonly IntPtr selMaxPossiblePositionOfDividerAtIndex_Handle = Selector.GetHandle("maxPossiblePositionOfDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinPossiblePositionOfDividerAtIndex_ = "minPossiblePositionOfDividerAtIndex:";

	private static readonly IntPtr selMinPossiblePositionOfDividerAtIndex_Handle = Selector.GetHandle("minPossiblePositionOfDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveArrangedSubview_ = "removeArrangedSubview:";

	private static readonly IntPtr selRemoveArrangedSubview_Handle = Selector.GetHandle("removeArrangedSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArrangesAllSubviews_ = "setArrangesAllSubviews:";

	private static readonly IntPtr selSetArrangesAllSubviews_Handle = Selector.GetHandle("setArrangesAllSubviews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosaveName_ = "setAutosaveName:";

	private static readonly IntPtr selSetAutosaveName_Handle = Selector.GetHandle("setAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDividerStyle_ = "setDividerStyle:";

	private static readonly IntPtr selSetDividerStyle_Handle = Selector.GetHandle("setDividerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHoldingPriority_ForSubviewAtIndex_ = "setHoldingPriority:forSubviewAtIndex:";

	private static readonly IntPtr selSetHoldingPriority_ForSubviewAtIndex_Handle = Selector.GetHandle("setHoldingPriority:forSubviewAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_OfDividerAtIndex_ = "setPosition:ofDividerAtIndex:";

	private static readonly IntPtr selSetPosition_OfDividerAtIndex_Handle = Selector.GetHandle("setPosition:ofDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertical_ = "setVertical:";

	private static readonly IntPtr selSetVertical_Handle = Selector.GetHandle("setVertical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSplitView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSSplitViewDidResizeSubviewsNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSSplitViewWillResizeSubviewsNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSView[] ArrangedSubviews
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("arrangedSubviews", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedSubviewsHandle));
			}
			return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedSubviewsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool ArrangesAllSubviews
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("arrangesAllSubviews")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selArrangesAllSubviewsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selArrangesAllSubviewsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setArrangesAllSubviews:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetArrangesAllSubviews_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetArrangesAllSubviews_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AutosaveName
	{
		[Export("autosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosaveNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosaveNameHandle));
		}
		[Export("setAutosaveName:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAutosaveName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAutosaveName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSSplitViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSSplitViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor DividerColor
	{
		[Export("dividerColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDividerColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDividerColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSplitViewDividerStyle DividerStyle
	{
		[Export("dividerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSplitViewDividerStyle)Messaging.Int64_objc_msgSend(base.Handle, selDividerStyleHandle);
			}
			return (NSSplitViewDividerStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDividerStyleHandle);
		}
		[Export("setDividerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDividerStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDividerStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat DividerThickness
	{
		[Export("dividerThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDividerThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDividerThicknessHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
		[Export("setVertical:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVertical_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVertical_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSSplitViewDidResizeSubviewsNotification", "AppKit")]
	[Advice("Use NSSplitView.Notifications.ObserveNSSplitViewDidResizeSubviews helper method instead.")]
	public static NSString NSSplitViewDidResizeSubviewsNotification
	{
		get
		{
			if (_NSSplitViewDidResizeSubviewsNotification == null)
			{
				_NSSplitViewDidResizeSubviewsNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSplitViewDidResizeSubviewsNotification");
			}
			return _NSSplitViewDidResizeSubviewsNotification;
		}
	}

	[Field("NSSplitViewWillResizeSubviewsNotification", "AppKit")]
	[Advice("Use NSSplitView.Notifications.ObserveNSSplitViewWillResizeSubviews helper method instead.")]
	public static NSString NSSplitViewWillResizeSubviewsNotification
	{
		get
		{
			if (_NSSplitViewWillResizeSubviewsNotification == null)
			{
				_NSSplitViewWillResizeSubviewsNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSplitViewWillResizeSubviewsNotification");
			}
			return _NSSplitViewWillResizeSubviewsNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSplitView()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSSplitView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSSplitView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSplitView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSplitView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("addArrangedSubview:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddArrangedSubview(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddArrangedSubview_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddArrangedSubview_Handle, view.Handle);
		}
	}

	[Export("adjustSubviews")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AdjustSubviews()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAdjustSubviewsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAdjustSubviewsHandle);
		}
	}

	[Export("drawDividerInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawDivider(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawDividerInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawDividerInRect_Handle, rect);
		}
	}

	[Export("holdingPriorityForSubviewAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float HoldingPriorityForSubview(nint subviewIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_nint(base.Handle, selHoldingPriorityForSubviewAtIndex_Handle, subviewIndex);
		}
		return Messaging.float_objc_msgSendSuper_nint(base.SuperHandle, selHoldingPriorityForSubviewAtIndex_Handle, subviewIndex);
	}

	[Export("insertArrangedSubview:atIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertArrangedSubview(NSView view, nint index)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertArrangedSubview_AtIndex_Handle, view.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertArrangedSubview_AtIndex_Handle, view.Handle, index);
		}
	}

	[Export("isSubviewCollapsed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSubviewCollapsed(NSView subview)
	{
		NSApplication.EnsureUIThread();
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSubviewCollapsed_Handle, subview.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSubviewCollapsed_Handle, subview.Handle);
	}

	[Export("maxPossiblePositionOfDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaxPositionOfDivider(nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nint(base.Handle, selMaxPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_nint(base.SuperHandle, selMaxPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
	}

	[Export("minPossiblePositionOfDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinPositionOfDivider(nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nint(base.Handle, selMinPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_nint(base.SuperHandle, selMinPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
	}

	[Export("removeArrangedSubview:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveArrangedSubview(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveArrangedSubview_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveArrangedSubview_Handle, view.Handle);
		}
	}

	[Export("setHoldingPriority:forSubviewAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetHoldingPriority(float priority, nint subviewIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_nint(base.Handle, selSetHoldingPriority_ForSubviewAtIndex_Handle, priority, subviewIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_nint(base.SuperHandle, selSetHoldingPriority_ForSubviewAtIndex_Handle, priority, subviewIndex);
		}
	}

	[Export("setPosition:ofDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPositionOfDivider(nfloat position, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selSetPosition_OfDividerAtIndex_Handle, position, dividerIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selSetPosition_OfDividerAtIndex_Handle, position, dividerIndex);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
