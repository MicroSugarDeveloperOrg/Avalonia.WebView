using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPathControl", true)]
public class NSPathControl : NSControl
{
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
	private const string selClickedPathItem = "clickedPathItem";

	private static readonly IntPtr selClickedPathItemHandle = Selector.GetHandle("clickedPathItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAction = "doubleAction";

	private static readonly IntPtr selDoubleActionHandle = Selector.GetHandle("doubleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu = "menu";

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathComponentCells = "pathComponentCells";

	private static readonly IntPtr selPathComponentCellsHandle = Selector.GetHandle("pathComponentCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathItems = "pathItems";

	private static readonly IntPtr selPathItemsHandle = Selector.GetHandle("pathItems");

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
	private const string selSetAllowedTypes_ = "setAllowedTypes:";

	private static readonly IntPtr selSetAllowedTypes_Handle = Selector.GetHandle("setAllowedTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleAction_ = "setDoubleAction:";

	private static readonly IntPtr selSetDoubleAction_Handle = Selector.GetHandle("setDoubleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingSourceOperationMask_ForLocal_ = "setDraggingSourceOperationMask:forLocal:";

	private static readonly IntPtr selSetDraggingSourceOperationMask_ForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ = "setMenu:";

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPathComponentCells_ = "setPathComponentCells:";

	private static readonly IntPtr selSetPathComponentCells_Handle = Selector.GetHandle("setPathComponentCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPathItems_ = "setPathItems:";

	private static readonly IntPtr selSetPathItems_Handle = Selector.GetHandle("setPathItems:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPathControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSString[] AllowedTypes
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("allowedTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedTypesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAllowedTypes:", ArgumentSemantic.Copy)]
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
	public virtual NSColor? BackgroundColor
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Please use ClickedPathItem instead.")]
	public virtual NSPathComponentCell ClickedPathComponentCell
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Please use ClickedPathItem instead.")]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSPathControlItem ClickedPathItem
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("clickedPathItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPathControlItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selClickedPathItemHandle));
			}
			return Runtime.GetNSObject<NSPathControlItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClickedPathItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSPathControlDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSPathControlDelegate;
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool Editable
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSMenu? Menu
	{
		[Export("menu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle));
		}
		[Export("setMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Please use PathItems instead.")]
	public virtual NSPathComponentCell[] PathComponentCells
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Please use PathItems instead.")]
		[Export("pathComponentCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPathComponentCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathComponentCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSPathComponentCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathComponentCellsHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Please use PathItems instead.")]
		[Export("setPathComponentCells:")]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSPathControlItem[] PathItems
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("pathItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPathControlItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSPathControlItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathItemsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPathItems:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPathItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPathItems_Handle, nSArray.Handle);
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAttributedString PlaceholderAttributedString
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string PlaceholderString
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPathControl()
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
	public NSPathControl(NSCoder coder)
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
	protected NSPathControl(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPathControl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPathControl(CGRect frameRect)
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

	[Export("setDraggingSourceOperationMask:forLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDraggingSource(NSDragOperation operationMask, bool isLocal)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selSetDraggingSourceOperationMask_ForLocal_Handle, (ulong)operationMask, isLocal);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selSetDraggingSourceOperationMask_ForLocal_Handle, (ulong)operationMask, isLocal);
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
