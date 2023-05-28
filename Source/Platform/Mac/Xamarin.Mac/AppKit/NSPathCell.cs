using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPathCell", true)]
public class NSPathCell : NSActionCell, INSMenuItemValidation, INativeObject, IDisposable
{
	[Register]
	internal class _NSPathCellDelegate : NSObject, INSPathCellDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSPathCellDisplayPanelEventArgs>? willDisplayOpenPanel;

		internal EventHandler<NSPathCellMenuEventArgs>? willPopupMenu;

		public _NSPathCellDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("pathCell:willDisplayOpenPanel:")]
		public void WillDisplayOpenPanel(NSPathCell pathCell, NSOpenPanel openPanel)
		{
			EventHandler<NSPathCellDisplayPanelEventArgs> eventHandler = willDisplayOpenPanel;
			if (eventHandler != null)
			{
				NSPathCellDisplayPanelEventArgs e = new NSPathCellDisplayPanelEventArgs(openPanel);
				eventHandler(pathCell, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("pathCell:willPopUpMenu:")]
		public void WillPopupMenu(NSPathCell pathCell, NSMenu menu)
		{
			EventHandler<NSPathCellMenuEventArgs> eventHandler = willPopupMenu;
			if (eventHandler != null)
			{
				NSPathCellMenuEventArgs e = new NSPathCellMenuEventArgs(menu);
				eventHandler(pathCell, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedTypes = "allowedTypes";

	private static readonly IntPtr selAllowedTypesHandle = Selector.GetHandle("allowedTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClickedPathComponentCell = "clickedPathComponentCell";

	private static readonly IntPtr selClickedPathComponentCellHandle = Selector.GetHandle("clickedPathComponentCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAction = "doubleAction";

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseEntered_WithFrame_InView_ = "mouseEntered:withFrame:inView:";

	private static readonly IntPtr selMouseEntered_WithFrame_InView_Handle = Selector.GetHandle("mouseEntered:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseExited_WithFrame_InView_ = "mouseExited:withFrame:inView:";

	private static readonly IntPtr selMouseExited_WithFrame_InView_Handle = Selector.GetHandle("mouseExited:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathComponentCellAtPoint_WithFrame_InView_ = "pathComponentCellAtPoint:withFrame:inView:";

	private static readonly IntPtr selPathComponentCellAtPoint_WithFrame_InView_Handle = Selector.GetHandle("pathComponentCellAtPoint:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathComponentCellClass = "pathComponentCellClass";

	private static readonly IntPtr selPathComponentCellClassHandle = Selector.GetHandle("pathComponentCellClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathComponentCells = "pathComponentCells";

	private static readonly IntPtr selPathComponentCellsHandle = Selector.GetHandle("pathComponentCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathStyle = "pathStyle";

	private static readonly IntPtr selPathStyleHandle = Selector.GetHandle("pathStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderAttributedString = "placeholderAttributedString";

	private static readonly IntPtr selPlaceholderAttributedStringHandle = Selector.GetHandle("placeholderAttributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderString = "placeholderString";

	private static readonly IntPtr selPlaceholderStringHandle = Selector.GetHandle("placeholderString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfPathComponentCell_WithFrame_InView_ = "rectOfPathComponentCell:withFrame:inView:";

	private static readonly IntPtr selRectOfPathComponentCell_WithFrame_InView_Handle = Selector.GetHandle("rectOfPathComponentCell:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedTypes_ = "setAllowedTypes:";

	private static readonly IntPtr selSetAllowedTypes_Handle = Selector.GetHandle("setAllowedTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlSize_ = "setControlSize:";

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleAction_ = "setDoubleAction:";

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObjectValue_ = "setObjectValue:";

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPathComponentCells_ = "setPathComponentCells:";

	private static readonly IntPtr selSetPathComponentCells_Handle = Selector.GetHandle("setPathComponentCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPathStyle_ = "setPathStyle:";

	private static readonly IntPtr selSetPathStyle_Handle = Selector.GetHandle("setPathStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaceholderAttributedString_ = "setPlaceholderAttributedString:";

	private static readonly IntPtr selSetPlaceholderAttributedString_Handle = Selector.GetHandle("setPlaceholderAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaceholderString_ = "setPlaceholderString:";

	private static readonly IntPtr selSetPlaceholderString_Handle = Selector.GetHandle("setPlaceholderString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ = "setURL:";

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateMenuItem_ = "validateMenuItem:";

	private static readonly IntPtr selValidateMenuItem_Handle = Selector.GetHandle("validateMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPathCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AllowedTypes
	{
		[Export("allowedTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ClickedPathItem' instead.")]
	public virtual NSPathComponentCell ClickedPathComponentCell
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ClickedPathItem' instead.")]
		[Export("clickedPathComponentCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPathComponentCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selClickedPathComponentCellHandle));
			}
			return Runtime.GetNSObject<NSPathComponentCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClickedPathComponentCellHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSPathCellDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSPathCellDelegate;
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
	public virtual Selector DoubleAction
	{
		[Export("doubleAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDoubleAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDoubleAction_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class PathComponentCellClass
	{
		[Export("pathComponentCellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selPathComponentCellClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPathComponentCell[] PathComponentCells
	{
		[Export("pathComponentCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPathComponentCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathComponentCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSPathComponentCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathComponentCellsHandle));
		}
		[Export("setPathComponentCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPathComponentCells_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPathComponentCells_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPathStyle PathStyle
	{
		[Export("pathStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPathStyle)Messaging.Int64_objc_msgSend(base.Handle, selPathStyleHandle);
			}
			return (NSPathStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPathStyleHandle);
		}
		[Export("setPathStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPathStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPathStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString PlaceholderAttributedString
	{
		[Export("placeholderAttributedString", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderAttributedStringHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderAttributedStringHandle));
		}
		[Export("setPlaceholderAttributedString:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PlaceholderString
	{
		[Export("placeholderString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
		[Export("setURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
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
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSPathCellDelegate);

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPathCell()
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
	public NSPathCell(NSCoder coder)
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
	protected NSPathCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPathCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPathCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPathCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	[Export("pathComponentCellAtPoint:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPathComponentCell GetPathComponent(CGPoint point, CGRect frame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSPathComponentCell>(Messaging.IntPtr_objc_msgSend_CGPoint_CGRect_IntPtr(base.Handle, selPathComponentCellAtPoint_WithFrame_InView_Handle, point, frame, view.Handle));
		}
		return Runtime.GetNSObject<NSPathComponentCell>(Messaging.IntPtr_objc_msgSendSuper_CGPoint_CGRect_IntPtr(base.SuperHandle, selPathComponentCellAtPoint_WithFrame_InView_Handle, point, frame, view.Handle));
	}

	[Export("rectOfPathComponentCell:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_IntPtr(out retval, base.Handle, selRectOfPathComponentCell_WithFrame_InView_Handle, componentCell.Handle, withFrame, inView.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_IntPtr(out retval, base.SuperHandle, selRectOfPathComponentCell_WithFrame_InView_Handle, componentCell.Handle, withFrame, inView.Handle);
		}
		return retval;
	}

	[Export("mouseEntered:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selMouseEntered_WithFrame_InView_Handle, evt.Handle, frame, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selMouseEntered_WithFrame_InView_Handle, evt.Handle, frame, view.Handle);
		}
	}

	[Export("mouseExited:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selMouseExited_WithFrame_InView_Handle, evt.Handle, frame, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selMouseExited_WithFrame_InView_Handle, evt.Handle, frame, view.Handle);
		}
	}

	[Export("setControlSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetControlSize(NSControlSize size)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)size);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)size);
		}
	}

	[Export("setObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObjectValue(NSObject obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, obj.Handle);
		}
	}

	[Export("validateMenuItem:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateMenuItem(NSMenuItem menuItem)
	{
		NSApplication.EnsureUIThread();
		if (menuItem == null)
		{
			throw new ArgumentNullException("menuItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateMenuItem_Handle, menuItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateMenuItem_Handle, menuItem.Handle);
	}

	internal virtual _NSPathCellDelegate CreateInternalEventDelegateType()
	{
		return new _NSPathCellDelegate();
	}

	internal _NSPathCellDelegate EnsureNSPathCellDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSPathCellDelegate nSPathCellDelegate = Delegate as _NSPathCellDelegate;
		if (nSPathCellDelegate == null)
		{
			nSPathCellDelegate = (_NSPathCellDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSPathCellDelegate;
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
