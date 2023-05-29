using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextTab", true)]
public class NSTextTab : NSObject
{
	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	private static readonly IntPtr selTabStopTypeHandle = Selector.GetHandle("tabStopType");

	private static readonly IntPtr selInitWithTextAlignmentLocationOptions_Handle = Selector.GetHandle("initWithTextAlignment:location:options:");

	private static readonly IntPtr selInitWithTypeLocation_Handle = Selector.GetHandle("initWithType:location:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextTab");

	private object __mt_Options_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTextAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
	}

	public virtual NSDictionary Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_Options_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle)))));
		}
	}

	public virtual double Location
	{
		[Export("location")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLocationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLocationHandle);
		}
	}

	public virtual NSTextTabType TabStopType
	{
		[Export("tabStopType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextTabType)Messaging.UInt64_objc_msgSend(base.Handle, selTabStopTypeHandle);
			}
			return (NSTextTabType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabStopTypeHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextTab()
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
	public NSTextTab(NSCoder coder)
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
	public NSTextTab(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextTab(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTextAlignment:location:options:")]
	public NSTextTab(NSTextAlignment alignment, double loc, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64_Double_IntPtr(base.Handle, selInitWithTextAlignmentLocationOptions_Handle, (ulong)alignment, loc, options.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64_Double_IntPtr(base.SuperHandle, selInitWithTextAlignmentLocationOptions_Handle, (ulong)alignment, loc, options.Handle);
		}
	}

	[Export("initWithType:location:")]
	public NSTextTab(NSTextTabType type, double loc)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64_Double(base.Handle, selInitWithTypeLocation_Handle, (ulong)type, loc);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64_Double(base.SuperHandle, selInitWithTypeLocation_Handle, (ulong)type, loc);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Options_var = null;
		}
	}
}
