using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGridColumn", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSGridColumn : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellAtIndex_ = "cellAtIndex:";

	private static readonly IntPtr selCellAtIndex_Handle = Selector.GetHandle("cellAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridView = "gridView";

	private static readonly IntPtr selGridViewHandle = Selector.GetHandle("gridView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeadingPadding = "leadingPadding";

	private static readonly IntPtr selLeadingPaddingHandle = Selector.GetHandle("leadingPadding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeCellsInRange_ = "mergeCellsInRange:";

	private static readonly IntPtr selMergeCellsInRange_Handle = Selector.GetHandle("mergeCellsInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfCells = "numberOfCells";

	private static readonly IntPtr selNumberOfCellsHandle = Selector.GetHandle("numberOfCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeadingPadding_ = "setLeadingPadding:";

	private static readonly IntPtr selSetLeadingPadding_Handle = Selector.GetHandle("setLeadingPadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrailingPadding_ = "setTrailingPadding:";

	private static readonly IntPtr selSetTrailingPadding_Handle = Selector.GetHandle("setTrailingPadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_ = "setWidth:";

	private static readonly IntPtr selSetWidth_Handle = Selector.GetHandle("setWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXPlacement_ = "setXPlacement:";

	private static readonly IntPtr selSetXPlacement_Handle = Selector.GetHandle("setXPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrailingPadding = "trailingPadding";

	private static readonly IntPtr selTrailingPaddingHandle = Selector.GetHandle("trailingPadding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXPlacement = "xPlacement";

	private static readonly IntPtr selXPlacementHandle = Selector.GetHandle("xPlacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGridColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_GridView_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint CellCount
	{
		[Export("numberOfCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfCellsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfCellsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridView? GridView
	{
		[Export("gridView", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSGridView nSGridView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSGridView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGridViewHandle)) : Runtime.GetNSObject<NSGridView>(Messaging.IntPtr_objc_msgSend(base.Handle, selGridViewHandle)));
			MarkDirty();
			__mt_GridView_var = nSGridView;
			return nSGridView;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LeadingPadding
	{
		[Export("leadingPadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLeadingPaddingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLeadingPaddingHandle);
		}
		[Export("setLeadingPadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLeadingPadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLeadingPadding_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TrailingPadding
	{
		[Export("trailingPadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTrailingPaddingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTrailingPaddingHandle);
		}
		[Export("setTrailingPadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTrailingPadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTrailingPadding_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Width
	{
		[Export("width")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
		[Export("setWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetWidth_Handle, value);
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSGridColumn(NSCoder coder)
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
	protected NSGridColumn(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGridColumn(IntPtr handle)
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

	[Export("cellAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGridCell GetCell(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGridCell>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selCellAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSGridCell>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selCellAtIndex_Handle, index));
	}

	[Export("mergeCellsInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MergeCells(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selMergeCellsInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selMergeCellsInRange_Handle, range);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_GridView_var = null;
		}
	}
}
