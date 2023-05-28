using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGridCell", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSGridCell : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumn = "column";

	private static readonly IntPtr selColumnHandle = Selector.GetHandle("column");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentView = "contentView";

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomPlacementConstraints = "customPlacementConstraints";

	private static readonly IntPtr selCustomPlacementConstraintsHandle = Selector.GetHandle("customPlacementConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmptyContentView = "emptyContentView";

	private static readonly IntPtr selEmptyContentViewHandle = Selector.GetHandle("emptyContentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRow = "row";

	private static readonly IntPtr selRowHandle = Selector.GetHandle("row");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowAlignment = "rowAlignment";

	private static readonly IntPtr selRowAlignmentHandle = Selector.GetHandle("rowAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentView_ = "setContentView:";

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomPlacementConstraints_ = "setCustomPlacementConstraints:";

	private static readonly IntPtr selSetCustomPlacementConstraints_Handle = Selector.GetHandle("setCustomPlacementConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowAlignment_ = "setRowAlignment:";

	private static readonly IntPtr selSetRowAlignment_Handle = Selector.GetHandle("setRowAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXPlacement_ = "setXPlacement:";

	private static readonly IntPtr selSetXPlacement_Handle = Selector.GetHandle("setXPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYPlacement_ = "setYPlacement:";

	private static readonly IntPtr selSetYPlacement_Handle = Selector.GetHandle("setYPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXPlacement = "xPlacement";

	private static readonly IntPtr selXPlacementHandle = Selector.GetHandle("xPlacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYPlacement = "yPlacement";

	private static readonly IntPtr selYPlacementHandle = Selector.GetHandle("yPlacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGridCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Column_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Row_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridColumn? Column
	{
		[Export("column", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSGridColumn nSGridColumn = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColumnHandle)) : Runtime.GetNSObject<NSGridColumn>(Messaging.IntPtr_objc_msgSend(base.Handle, selColumnHandle)));
			MarkDirty();
			__mt_Column_var = nSGridColumn;
			return nSGridColumn;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? ContentView
	{
		[Export("contentView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle));
		}
		[Export("setContentView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint[] CustomPlacementConstraints
	{
		[Export("customPlacementConstraints", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomPlacementConstraintsHandle));
			}
			return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomPlacementConstraintsHandle));
		}
		[Export("setCustomPlacementConstraints:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomPlacementConstraints_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomPlacementConstraints_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView EmptyContentView
	{
		[Export("emptyContentView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(class_ptr, selEmptyContentViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridRow? Row
	{
		[Export("row", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSGridRow nSGridRow = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRowHandle)) : Runtime.GetNSObject<NSGridRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selRowHandle)));
			MarkDirty();
			__mt_Row_var = nSGridRow;
			return nSGridRow;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridRowAlignment RowAlignment
	{
		[Export("rowAlignment", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGridRowAlignment)Messaging.Int64_objc_msgSend(base.Handle, selRowAlignmentHandle);
			}
			return (NSGridRowAlignment)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowAlignmentHandle);
		}
		[Export("setRowAlignment:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRowAlignment_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRowAlignment_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCellPlacement X
	{
		[Export("xPlacement", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGridCellPlacement)Messaging.Int64_objc_msgSend(base.Handle, selXPlacementHandle);
			}
			return (NSGridCellPlacement)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selXPlacementHandle);
		}
		[Export("setXPlacement:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetXPlacement_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetXPlacement_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCellPlacement Y
	{
		[Export("yPlacement", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGridCellPlacement)Messaging.Int64_objc_msgSend(base.Handle, selYPlacementHandle);
			}
			return (NSGridCellPlacement)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selYPlacementHandle);
		}
		[Export("setYPlacement:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetYPlacement_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetYPlacement_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSGridCell(NSCoder coder)
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
	protected NSGridCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGridCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Column_var = null;
			__mt_Row_var = null;
		}
	}
}
