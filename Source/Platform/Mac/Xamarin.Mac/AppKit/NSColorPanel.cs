using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorPanel", true)]
public class NSColorPanel : NSPanel
{
	public new static class Notifications
	{
		public static NSObject ObserveColorChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColorChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveColorChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColorChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryView = "accessoryView";

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachColorList_ = "attachColorList:";

	private static readonly IntPtr selAttachColorList_Handle = Selector.GetHandle("attachColorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachColorList_ = "detachColorList:";

	private static readonly IntPtr selDetachColorList_Handle = Selector.GetHandle("detachColorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragColor_WithEvent_FromView_ = "dragColor:withEvent:fromView:";

	private static readonly IntPtr selDragColor_WithEvent_FromView_Handle = Selector.GetHandle("dragColor:withEvent:fromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContinuous = "isContinuous";

	private static readonly IntPtr selIsContinuousHandle = Selector.GetHandle("isContinuous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessoryView_ = "setAccessoryView:";

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuous_ = "setContinuous:";

	private static readonly IntPtr selSetContinuous_Handle = Selector.GetHandle("setContinuous:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPickerMask_ = "setPickerMask:";

	private static readonly IntPtr selSetPickerMask_Handle = Selector.GetHandle("setPickerMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPickerMode_ = "setPickerMode:";

	private static readonly IntPtr selSetPickerMode_Handle = Selector.GetHandle("setPickerMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsAlpha_ = "setShowsAlpha:";

	private static readonly IntPtr selSetShowsAlpha_Handle = Selector.GetHandle("setShowsAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedColorPanel = "sharedColorPanel";

	private static readonly IntPtr selSharedColorPanelHandle = Selector.GetHandle("sharedColorPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedColorPanelExists = "sharedColorPanelExists";

	private static readonly IntPtr selSharedColorPanelExistsHandle = Selector.GetHandle("sharedColorPanelExists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsAlpha = "showsAlpha";

	private static readonly IntPtr selShowsAlphaHandle = Selector.GetHandle("showsAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSColorPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? AccessoryView
	{
		[Export("accessoryView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle));
		}
		[Export("setAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Alpha
	{
		[Export("alpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor Color
	{
		[Export("color", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Continuous
	{
		[Export("isContinuous")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousHandle);
		}
		[Export("setContinuous:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuous_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorPanelMode Mode
	{
		[Export("mode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSColorPanelMode)Messaging.Int64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (NSColorPanelMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorPanel SharedColorPanel
	{
		[Export("sharedColorPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSColorPanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedColorPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SharedColorPanelExists
	{
		[Export("sharedColorPanelExists")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selSharedColorPanelExistsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsAlpha
	{
		[Export("showsAlpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsAlphaHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsAlphaHandle);
		}
		[Export("setShowsAlpha:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsAlpha_Handle, value);
			}
		}
	}

	[Field("NSColorPanelColorDidChangeNotification", "AppKit")]
	[Advice("Use NSColorPanel.Notifications.ObserveColorChanged helper method instead.")]
	public static NSString ColorChangedNotification
	{
		get
		{
			if (_ColorChangedNotification == null)
			{
				_ColorChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSColorPanelColorDidChangeNotification");
			}
			return _ColorChangedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorPanel()
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
	public NSColorPanel(NSCoder coder)
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
	protected NSColorPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSColorPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attachColorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AttachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAttachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttachColorList_Handle, colorList.Handle);
		}
	}

	[Export("detachColorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DetachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetachColorList_Handle, colorList.Handle);
		}
	}

	[Export("dragColor:withEvent:fromView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DragColor(NSColor color, NSEvent theEvent, NSView sourceView)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (sourceView == null)
		{
			throw new ArgumentNullException("sourceView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDragColor_WithEvent_FromView_Handle, color.Handle, theEvent.Handle, sourceView.Handle);
	}

	[Export("setAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAction(Selector? aSelector)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (aSelector == null) ? IntPtr.Zero : aSelector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (aSelector == null) ? IntPtr.Zero : aSelector.Handle);
		}
	}

	[Export("setPickerMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetPickerMode(NSColorPanelMode mode)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(class_ptr, selSetPickerMode_Handle, (long)mode);
	}

	[Export("setPickerMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetPickerStyle(NSColorPanelFlags mask)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_UInt64(class_ptr, selSetPickerMask_Handle, (ulong)mask);
	}

	[Export("setTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTarget(NSObject? anObject)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
	}
}
