using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableRowView", true)]
public class NSTableRowView : NSView, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilityGroup, INSAccessibilityRow
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosureLevel = "accessibilityDisclosureLevel";

	private static readonly IntPtr selAccessibilityDisclosureLevelHandle = Selector.GetHandle("accessibilityDisclosureLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIndex = "accessibilityIndex";

	private static readonly IntPtr selAccessibilityIndexHandle = Selector.GetHandle("accessibilityIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingDestinationFeedbackStyle = "draggingDestinationFeedbackStyle";

	private static readonly IntPtr selDraggingDestinationFeedbackStyleHandle = Selector.GetHandle("draggingDestinationFeedbackStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBackgroundInRect_ = "drawBackgroundInRect:";

	private static readonly IntPtr selDrawBackgroundInRect_Handle = Selector.GetHandle("drawBackgroundInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawDraggingDestinationFeedbackInRect_ = "drawDraggingDestinationFeedbackInRect:";

	private static readonly IntPtr selDrawDraggingDestinationFeedbackInRect_Handle = Selector.GetHandle("drawDraggingDestinationFeedbackInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSelectionInRect_ = "drawSelectionInRect:";

	private static readonly IntPtr selDrawSelectionInRect_Handle = Selector.GetHandle("drawSelectionInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSeparatorInRect_ = "drawSeparatorInRect:";

	private static readonly IntPtr selDrawSeparatorInRect_Handle = Selector.GetHandle("drawSeparatorInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndentationForDropOperation = "indentationForDropOperation";

	private static readonly IntPtr selIndentationForDropOperationHandle = Selector.GetHandle("indentationForDropOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteriorBackgroundStyle = "interiorBackgroundStyle";

	private static readonly IntPtr selInteriorBackgroundStyleHandle = Selector.GetHandle("interiorBackgroundStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEmphasized = "isEmphasized";

	private static readonly IntPtr selIsEmphasizedHandle = Selector.GetHandle("isEmphasized");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFloating = "isFloating";

	private static readonly IntPtr selIsFloatingHandle = Selector.GetHandle("isFloating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGroupRowStyle = "isGroupRowStyle";

	private static readonly IntPtr selIsGroupRowStyleHandle = Selector.GetHandle("isGroupRowStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNextRowSelected = "isNextRowSelected";

	private static readonly IntPtr selIsNextRowSelectedHandle = Selector.GetHandle("isNextRowSelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPreviousRowSelected = "isPreviousRowSelected";

	private static readonly IntPtr selIsPreviousRowSelectedHandle = Selector.GetHandle("isPreviousRowSelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelected = "isSelected";

	private static readonly IntPtr selIsSelectedHandle = Selector.GetHandle("isSelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTargetForDropOperation = "isTargetForDropOperation";

	private static readonly IntPtr selIsTargetForDropOperationHandle = Selector.GetHandle("isTargetForDropOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionHighlightStyle = "selectionHighlightStyle";

	private static readonly IntPtr selSelectionHighlightStyleHandle = Selector.GetHandle("selectionHighlightStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingDestinationFeedbackStyle_ = "setDraggingDestinationFeedbackStyle:";

	private static readonly IntPtr selSetDraggingDestinationFeedbackStyle_Handle = Selector.GetHandle("setDraggingDestinationFeedbackStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmphasized_ = "setEmphasized:";

	private static readonly IntPtr selSetEmphasized_Handle = Selector.GetHandle("setEmphasized:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloating_ = "setFloating:";

	private static readonly IntPtr selSetFloating_Handle = Selector.GetHandle("setFloating:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupRowStyle_ = "setGroupRowStyle:";

	private static readonly IntPtr selSetGroupRowStyle_Handle = Selector.GetHandle("setGroupRowStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndentationForDropOperation_ = "setIndentationForDropOperation:";

	private static readonly IntPtr selSetIndentationForDropOperation_Handle = Selector.GetHandle("setIndentationForDropOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNextRowSelected_ = "setNextRowSelected:";

	private static readonly IntPtr selSetNextRowSelected_Handle = Selector.GetHandle("setNextRowSelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviousRowSelected_ = "setPreviousRowSelected:";

	private static readonly IntPtr selSetPreviousRowSelected_Handle = Selector.GetHandle("setPreviousRowSelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelected_ = "setSelected:";

	private static readonly IntPtr selSetSelected_Handle = Selector.GetHandle("setSelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionHighlightStyle_ = "setSelectionHighlightStyle:";

	private static readonly IntPtr selSetSelectionHighlightStyle_Handle = Selector.GetHandle("setSelectionHighlightStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTargetForDropOperation_ = "setTargetForDropOperation:";

	private static readonly IntPtr selSetTargetForDropOperation_Handle = Selector.GetHandle("setTargetForDropOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewAtColumn_ = "viewAtColumn:";

	private static readonly IntPtr selViewAtColumn_Handle = Selector.GetHandle("viewAtColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTableRowView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual nint AccessibilityDisclosureLevel
	{
		[Export("accessibilityDisclosureLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityDisclosureLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosureLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual nint AccessibilityIndex
	{
		[Export("accessibilityIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
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
	public virtual NSTableViewDraggingDestinationFeedbackStyle DraggingDestinationFeedbackStyle
	{
		[Export("draggingDestinationFeedbackStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSend(base.Handle, selDraggingDestinationFeedbackStyleHandle);
			}
			return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationFeedbackStyleHandle);
		}
		[Export("setDraggingDestinationFeedbackStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Emphasized
	{
		[Export("isEmphasized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmphasizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmphasizedHandle);
		}
		[Export("setEmphasized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEmphasized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEmphasized_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Floating
	{
		[Export("isFloating")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFloatingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFloatingHandle);
		}
		[Export("setFloating:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloating_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloating_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GroupRowStyle
	{
		[Export("isGroupRowStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGroupRowStyleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGroupRowStyleHandle);
		}
		[Export("setGroupRowStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGroupRowStyle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGroupRowStyle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat IndentationForDropOperation
	{
		[Export("indentationForDropOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selIndentationForDropOperationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selIndentationForDropOperationHandle);
		}
		[Export("setIndentationForDropOperation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetIndentationForDropOperation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetIndentationForDropOperation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBackgroundStyle InteriorBackgroundStyle
	{
		[Export("interiorBackgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selInteriorBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInteriorBackgroundStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool NextRowSelected
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isNextRowSelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsNextRowSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsNextRowSelectedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setNextRowSelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNextRowSelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNextRowSelected_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfColumns
	{
		[Export("numberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool PreviousRowSelected
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isPreviousRowSelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPreviousRowSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPreviousRowSelectedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPreviousRowSelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreviousRowSelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreviousRowSelected_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Selected
	{
		[Export("isSelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectedHandle);
		}
		[Export("setSelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelected_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewSelectionHighlightStyle SelectionHighlightStyle
	{
		[Export("selectionHighlightStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSend(base.Handle, selSelectionHighlightStyleHandle);
			}
			return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectionHighlightStyleHandle);
		}
		[Export("setSelectionHighlightStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TargetForDropOperation
	{
		[Export("isTargetForDropOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTargetForDropOperationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTargetForDropOperationHandle);
		}
		[Export("setTargetForDropOperation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTargetForDropOperation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTargetForDropOperation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableRowView()
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
	public NSTableRowView(NSCoder coder)
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
	protected NSTableRowView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableRowView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTableRowView(CGRect frameRect)
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

	[Export("drawBackgroundInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawBackground(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawBackgroundInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawBackgroundInRect_Handle, dirtyRect);
		}
	}

	[Export("drawDraggingDestinationFeedbackInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawDraggingDestinationFeedback(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawDraggingDestinationFeedbackInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawDraggingDestinationFeedbackInRect_Handle, dirtyRect);
		}
	}

	[Export("drawSelectionInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSelection(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawSelectionInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawSelectionInRect_Handle, dirtyRect);
		}
	}

	[Export("drawSeparatorInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSeparator(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawSeparatorInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawSeparatorInRect_Handle, dirtyRect);
		}
	}

	[Export("viewAtColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView ViewAtColumn(nint column)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selViewAtColumn_Handle, column));
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selViewAtColumn_Handle, column));
	}
}
