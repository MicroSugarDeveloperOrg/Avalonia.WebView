using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPathCell", true)]
public class NSPathCell : NSActionCell
{
	[Register]
	private sealed class _NSPathCellDelegate : NSPathCellDelegate
	{
		internal EventHandler<NSPathCellDisplayPanelEventArgs> willDisplayOpenPanel;

		internal EventHandler<NSPathCellMenuEventArgs> willPopupMenu;

		[Preserve(Conditional = true)]
		public override void WillDisplayOpenPanel(NSPathCell pathCell, NSOpenPanel openPanel)
		{
			EventHandler<NSPathCellDisplayPanelEventArgs> eventHandler = willDisplayOpenPanel;
			if (eventHandler != null)
			{
				NSPathCellDisplayPanelEventArgs e = new NSPathCellDisplayPanelEventArgs(openPanel);
				eventHandler(pathCell, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillPopupMenu(NSPathCell pathCell, NSMenu menu)
		{
			EventHandler<NSPathCellMenuEventArgs> eventHandler = willPopupMenu;
			if (eventHandler != null)
			{
				NSPathCellMenuEventArgs e = new NSPathCellMenuEventArgs(menu);
				eventHandler(pathCell, e);
			}
		}
	}

	private static readonly IntPtr selPathStyleHandle = Selector.GetHandle("pathStyle");

	private static readonly IntPtr selSetPathStyle_Handle = Selector.GetHandle("setPathStyle:");

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	private static readonly IntPtr selAllowedTypesHandle = Selector.GetHandle("allowedTypes");

	private static readonly IntPtr selSetAllowedTypes_Handle = Selector.GetHandle("setAllowedTypes:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selPathComponentCellClassHandle = Selector.GetHandle("pathComponentCellClass");

	private static readonly IntPtr selPathComponentCellsHandle = Selector.GetHandle("pathComponentCells");

	private static readonly IntPtr selSetPathComponentCells_Handle = Selector.GetHandle("setPathComponentCells:");

	private static readonly IntPtr selClickedPathComponentCellHandle = Selector.GetHandle("clickedPathComponentCell");

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selPlaceholderStringHandle = Selector.GetHandle("placeholderString");

	private static readonly IntPtr selSetPlaceholderString_Handle = Selector.GetHandle("setPlaceholderString:");

	private static readonly IntPtr selPlaceholderAttributedStringHandle = Selector.GetHandle("placeholderAttributedString");

	private static readonly IntPtr selSetPlaceholderAttributedString_Handle = Selector.GetHandle("setPlaceholderAttributedString:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	private static readonly IntPtr selRectOfPathComponentCellWithFrameInView_Handle = Selector.GetHandle("rectOfPathComponentCell:withFrame:inView:");

	private static readonly IntPtr selPathComponentCellAtPointWithFrameInView_Handle = Selector.GetHandle("pathComponentCellAtPoint:withFrame:inView:");

	private static readonly IntPtr selMouseEnteredWithFrameInView_Handle = Selector.GetHandle("mouseEntered:withFrame:inView:");

	private static readonly IntPtr selMouseExitedWithFrameInView_Handle = Selector.GetHandle("mouseExited:withFrame:inView:");

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPathCell");

	private object __mt_Url_var;

	private object __mt_WeakDelegate_var;

	private object __mt_PathComponentCells_var;

	private object __mt_ClickedPathComponentCell_var;

	private object __mt_BackgroundColor_var;

	private object __mt_PlaceholderAttributedString_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPathStyle PathStyle
	{
		[Export("pathStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPathStyle)Messaging.Int64_objc_msgSend(base.Handle, selPathStyleHandle);
			}
			return (NSPathStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPathStyleHandle);
		}
		[Export("setPathStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPathStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPathStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
		[Export("setURL:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
			}
			__mt_Url_var = value;
		}
	}

	public virtual string[] AllowedTypes
	{
		[Export("allowedTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedTypesHandle));
		}
		[Export("setAllowedTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllowedTypes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllowedTypes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSPathCellDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSPathCellDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public static Class PathComponentCellClass
	{
		[Export("pathComponentCellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			return new Class(Messaging.IntPtr_objc_msgSend(class_ptr, selPathComponentCellClassHandle));
		}
	}

	public virtual NSPathComponentCell[] PathComponentCells
	{
		[Export("pathComponentCells")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPathComponentCell[])(__mt_PathComponentCells_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPathComponentCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathComponentCellsHandle)) : NSArray.ArrayFromHandle<NSPathComponentCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathComponentCellsHandle))));
		}
		[Export("setPathComponentCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPathComponentCells_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPathComponentCells_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_PathComponentCells_var = value;
		}
	}

	public virtual NSPathComponentCell ClickedPathComponentCell
	{
		[Export("clickedPathComponentCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPathComponentCell)(__mt_ClickedPathComponentCell_var = ((!IsDirectBinding) ? ((NSPathComponentCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClickedPathComponentCellHandle))) : ((NSPathComponentCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selClickedPathComponentCellHandle)))));
		}
	}

	public virtual Selector DoubleAction
	{
		[Export("doubleAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDoubleActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDoubleActionHandle));
		}
		[Export("setDoubleAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDoubleAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDoubleAction_Handle, value.Handle);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual string PlaceholderString
	{
		[Export("placeholderString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderStringHandle));
		}
		[Export("setPlaceholderString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSAttributedString PlaceholderAttributedString
	{
		[Export("placeholderAttributedString")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_PlaceholderAttributedString_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderAttributedStringHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderAttributedStringHandle)))));
		}
		[Export("setPlaceholderAttributedString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
			__mt_PlaceholderAttributedString_var = value;
		}
	}

	public event EventHandler DoubleClick
	{
		add
		{
			Target = ActionDispatcher.SetupDoubleAction(Target, value);
			DoubleAction = ActionDispatcher.DoubleAction;
		}
		remove
		{
			ActionDispatcher.RemoveDoubleAction(Target, value);
		}
	}

	public event EventHandler<NSPathCellDisplayPanelEventArgs> WillDisplayOpenPanel
	{
		add
		{
			_NSPathCellDelegate nSPathCellDelegate = EnsureNSPathCellDelegate();
			nSPathCellDelegate.willDisplayOpenPanel = (EventHandler<NSPathCellDisplayPanelEventArgs>)System.Delegate.Combine(nSPathCellDelegate.willDisplayOpenPanel, value);
		}
		remove
		{
			_NSPathCellDelegate nSPathCellDelegate = EnsureNSPathCellDelegate();
			nSPathCellDelegate.willDisplayOpenPanel = (EventHandler<NSPathCellDisplayPanelEventArgs>)System.Delegate.Remove(nSPathCellDelegate.willDisplayOpenPanel, value);
		}
	}

	public event EventHandler<NSPathCellMenuEventArgs> WillPopupMenu
	{
		add
		{
			_NSPathCellDelegate nSPathCellDelegate = EnsureNSPathCellDelegate();
			nSPathCellDelegate.willPopupMenu = (EventHandler<NSPathCellMenuEventArgs>)System.Delegate.Combine(nSPathCellDelegate.willPopupMenu, value);
		}
		remove
		{
			_NSPathCellDelegate nSPathCellDelegate = EnsureNSPathCellDelegate();
			nSPathCellDelegate.willPopupMenu = (EventHandler<NSPathCellMenuEventArgs>)System.Delegate.Remove(nSPathCellDelegate.willPopupMenu, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPathCell()
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
	public NSPathCell(NSCoder coder)
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
	public NSPathCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPathCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSPathCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSPathCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	[Export("setObjectValue:")]
	public virtual void SetObjectValue(NSObject obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, obj.Handle);
		}
	}

	[Export("rectOfPathComponentCell:withFrame:inView:")]
	public virtual CGRect GetRect(NSPathComponentCell componentCell, CGRect withFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (componentCell == null)
		{
			throw new ArgumentNullException("componentCell");
		}
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_IntPtr(out retval, base.Handle, selRectOfPathComponentCellWithFrameInView_Handle, componentCell.Handle, withFrame, inView.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_IntPtr(out retval, base.SuperHandle, selRectOfPathComponentCellWithFrameInView_Handle, componentCell.Handle, withFrame, inView.Handle);
		}
		return retval;
	}

	[Export("pathComponentCellAtPoint:withFrame:inView:")]
	public virtual NSPathComponentCell GetPathComponent(CGPoint point, CGRect frame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			return (NSPathComponentCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint_CGRect_IntPtr(base.Handle, selPathComponentCellAtPointWithFrameInView_Handle, point, frame, view.Handle));
		}
		return (NSPathComponentCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint_CGRect_IntPtr(base.SuperHandle, selPathComponentCellAtPointWithFrameInView_Handle, point, frame, view.Handle));
	}

	[Export("mouseEntered:withFrame:inView:")]
	public virtual void MouseEntered(NSEvent evt, CGRect frame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selMouseEnteredWithFrameInView_Handle, evt.Handle, frame, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selMouseEnteredWithFrameInView_Handle, evt.Handle, frame, view.Handle);
		}
	}

	[Export("mouseExited:withFrame:inView:")]
	public virtual void MouseExited(NSEvent evt, CGRect frame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selMouseExitedWithFrameInView_Handle, evt.Handle, frame, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selMouseExitedWithFrameInView_Handle, evt.Handle, frame, view.Handle);
		}
	}

	[Export("setControlSize:")]
	public virtual void SetControlSize(NSControlSize size)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)size);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)size);
		}
	}

	private _NSPathCellDelegate EnsureNSPathCellDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSPathCellDelegate))
		{
			nSObject = (WeakDelegate = new _NSPathCellDelegate());
		}
		return (_NSPathCellDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
			__mt_WeakDelegate_var = null;
			__mt_PathComponentCells_var = null;
			__mt_ClickedPathComponentCell_var = null;
			__mt_BackgroundColor_var = null;
			__mt_PlaceholderAttributedString_var = null;
		}
	}
}
