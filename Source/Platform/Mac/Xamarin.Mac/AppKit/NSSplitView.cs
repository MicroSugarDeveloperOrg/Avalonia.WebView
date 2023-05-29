using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSplitView", true)]
public class NSSplitView : NSView
{
	private static readonly IntPtr selDividerColorHandle = Selector.GetHandle("dividerColor");

	private static readonly IntPtr selDividerThicknessHandle = Selector.GetHandle("dividerThickness");

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	private static readonly IntPtr selSetVertical_Handle = Selector.GetHandle("setVertical:");

	private static readonly IntPtr selDividerStyleHandle = Selector.GetHandle("dividerStyle");

	private static readonly IntPtr selSetDividerStyle_Handle = Selector.GetHandle("setDividerStyle:");

	private static readonly IntPtr selAutosaveNameHandle = Selector.GetHandle("autosaveName");

	private static readonly IntPtr selSetAutosaveName_Handle = Selector.GetHandle("setAutosaveName:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selDrawDividerInRect_Handle = Selector.GetHandle("drawDividerInRect:");

	private static readonly IntPtr selAdjustSubviewsHandle = Selector.GetHandle("adjustSubviews");

	private static readonly IntPtr selIsSubviewCollapsed_Handle = Selector.GetHandle("isSubviewCollapsed:");

	private static readonly IntPtr selMinPossiblePositionOfDividerAtIndex_Handle = Selector.GetHandle("minPossiblePositionOfDividerAtIndex:");

	private static readonly IntPtr selMaxPossiblePositionOfDividerAtIndex_Handle = Selector.GetHandle("maxPossiblePositionOfDividerAtIndex:");

	private static readonly IntPtr selSetPositionOfDividerAtIndex_Handle = Selector.GetHandle("setPosition:ofDividerAtIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSplitView");

	private object __mt_DividerColor_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSColor DividerColor
	{
		[Export("dividerColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_DividerColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDividerColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDividerColorHandle)))));
		}
	}

	public virtual double DividerThickness
	{
		[Export("dividerThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDividerThicknessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDividerThicknessHandle);
		}
	}

	public virtual bool IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
		[Export("setVertical:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVertical_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVertical_Handle, value);
			}
		}
	}

	public virtual NSSplitViewDividerStyle DividerStyle
	{
		[Export("dividerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSSplitViewDividerStyle)Messaging.Int64_objc_msgSend(base.Handle, selDividerStyleHandle);
			}
			return (NSSplitViewDividerStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDividerStyleHandle);
		}
		[Export("setDividerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDividerStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDividerStyle_Handle, (long)value);
			}
		}
	}

	public virtual string AutosaveName
	{
		[Export("autosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public NSSplitViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSSplitViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSplitView()
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
	public NSSplitView(NSCoder coder)
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
	public NSSplitView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSplitView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSSplitView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("drawDividerInRect:")]
	public virtual void DrawDivider(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawDividerInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawDividerInRect_Handle, rect);
		}
	}

	[Export("adjustSubviews")]
	public virtual void AdjustSubviews()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAdjustSubviewsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAdjustSubviewsHandle);
		}
	}

	[Export("isSubviewCollapsed:")]
	public virtual bool IsSubviewCollapsed(NSView subview)
	{
		NSApplication.EnsureUIThread();
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSubviewCollapsed_Handle, subview.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSubviewCollapsed_Handle, subview.Handle);
	}

	[Export("minPossiblePositionOfDividerAtIndex:")]
	public virtual double MinPositionOfDivider(long dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selMinPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selMinPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
	}

	[Export("maxPossiblePositionOfDividerAtIndex:")]
	public virtual double MaxPositionOfDivider(long dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selMaxPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selMaxPossiblePositionOfDividerAtIndex_Handle, dividerIndex);
	}

	[Export("setPosition:ofDividerAtIndex:")]
	public virtual void SetPositionOfDivider(double position, long dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Int64(base.Handle, selSetPositionOfDividerAtIndex_Handle, position, dividerIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Int64(base.SuperHandle, selSetPositionOfDividerAtIndex_Handle, position, dividerIndex);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DividerColor_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
