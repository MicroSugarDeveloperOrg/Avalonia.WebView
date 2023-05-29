using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBox", true)]
public class NSBox : NSView
{
	private static readonly IntPtr selBorderTypeHandle = Selector.GetHandle("borderType");

	private static readonly IntPtr selSetBorderType_Handle = Selector.GetHandle("setBorderType:");

	private static readonly IntPtr selTitlePositionHandle = Selector.GetHandle("titlePosition");

	private static readonly IntPtr selSetTitlePosition_Handle = Selector.GetHandle("setTitlePosition:");

	private static readonly IntPtr selBoxTypeHandle = Selector.GetHandle("boxType");

	private static readonly IntPtr selSetBoxType_Handle = Selector.GetHandle("setBoxType:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selTitleFontHandle = Selector.GetHandle("titleFont");

	private static readonly IntPtr selSetTitleFont_Handle = Selector.GetHandle("setTitleFont:");

	private static readonly IntPtr selBorderRectHandle = Selector.GetHandle("borderRect");

	private static readonly IntPtr selTitleRectHandle = Selector.GetHandle("titleRect");

	private static readonly IntPtr selTitleCellHandle = Selector.GetHandle("titleCell");

	private static readonly IntPtr selContentViewMarginsHandle = Selector.GetHandle("contentViewMargins");

	private static readonly IntPtr selSetContentViewMargins_Handle = Selector.GetHandle("setContentViewMargins:");

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	private static readonly IntPtr selIsTransparentHandle = Selector.GetHandle("isTransparent");

	private static readonly IntPtr selSetTransparent_Handle = Selector.GetHandle("setTransparent:");

	private static readonly IntPtr selBorderWidthHandle = Selector.GetHandle("borderWidth");

	private static readonly IntPtr selSetBorderWidth_Handle = Selector.GetHandle("setBorderWidth:");

	private static readonly IntPtr selCornerRadiusHandle = Selector.GetHandle("cornerRadius");

	private static readonly IntPtr selSetCornerRadius_Handle = Selector.GetHandle("setCornerRadius:");

	private static readonly IntPtr selBorderColorHandle = Selector.GetHandle("borderColor");

	private static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle("setBorderColor:");

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr selSetFrameFromContentFrame_Handle = Selector.GetHandle("setFrameFromContentFrame:");

	private static readonly IntPtr selSetTitleWithMnemonic_Handle = Selector.GetHandle("setTitleWithMnemonic:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBox");

	private object __mt_TitleFont_var;

	private object __mt_TitleCell_var;

	private object __mt_ContentView_var;

	private object __mt_BorderColor_var;

	private object __mt_FillColor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSBorderType BorderType
	{
		[Export("borderType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBorderType)Messaging.UInt64_objc_msgSend(base.Handle, selBorderTypeHandle);
			}
			return (NSBorderType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBorderTypeHandle);
		}
		[Export("setBorderType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBorderType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBorderType_Handle, (ulong)value);
			}
		}
	}

	public virtual NSTitlePosition TitlePosition
	{
		[Export("titlePosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTitlePosition)Messaging.int_objc_msgSend(base.Handle, selTitlePositionHandle);
			}
			return (NSTitlePosition)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTitlePositionHandle);
		}
		[Export("setTitlePosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTitlePosition_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTitlePosition_Handle, (int)value);
			}
		}
	}

	public virtual NSBoxType BoxType
	{
		[Export("boxType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBoxType)Messaging.int_objc_msgSend(base.Handle, selBoxTypeHandle);
			}
			return (NSBoxType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selBoxTypeHandle);
		}
		[Export("setBoxType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetBoxType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetBoxType_Handle, (int)value);
			}
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSFont TitleFont
	{
		[Export("titleFont")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_TitleFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleFontHandle)))));
		}
		[Export("setTitleFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleFont_Handle, value.Handle);
			}
			__mt_TitleFont_var = value;
		}
	}

	public virtual CGRect BorderRect
	{
		[Export("borderRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBorderRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBorderRectHandle);
			}
			return retval;
		}
	}

	public virtual CGRect TitleRect
	{
		[Export("titleRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selTitleRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTitleRectHandle);
			}
			return retval;
		}
	}

	public virtual NSObject TitleCell
	{
		[Export("titleCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_TitleCell_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleCellHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleCellHandle))));
		}
	}

	public virtual CGSize ContentViewMargins
	{
		[Export("contentViewMargins")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentViewMarginsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentViewMarginsHandle);
		}
		[Export("setContentViewMargins:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentViewMargins_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentViewMargins_Handle, value);
			}
		}
	}

	public virtual NSObject ContentView
	{
		[Export("contentView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_ContentView_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle))));
		}
		[Export("setContentView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentView_Handle, value.Handle);
			}
			__mt_ContentView_var = value;
		}
	}

	public virtual bool Transparent
	{
		[Export("isTransparent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTransparentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTransparentHandle);
		}
		[Export("setTransparent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTransparent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTransparent_Handle, value);
			}
		}
	}

	public virtual double BorderWidth
	{
		[Export("borderWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBorderWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBorderWidthHandle);
		}
		[Export("setBorderWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBorderWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBorderWidth_Handle, value);
			}
		}
	}

	public virtual double CornerRadius
	{
		[Export("cornerRadius")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCornerRadiusHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCornerRadiusHandle);
		}
		[Export("setCornerRadius:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCornerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCornerRadius_Handle, value);
			}
		}
	}

	public virtual NSColor BorderColor
	{
		[Export("borderColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BorderColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBorderColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBorderColorHandle)))));
		}
		[Export("setBorderColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBorderColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBorderColor_Handle, value.Handle);
			}
			__mt_BorderColor_var = value;
		}
	}

	public virtual NSColor FillColor
	{
		[Export("fillColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_FillColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle)))));
		}
		[Export("setFillColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value.Handle);
			}
			__mt_FillColor_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBox()
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
	public NSBox(NSCoder coder)
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
	public NSBox(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBox(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSBox(CGRect frameRect)
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

	[Export("sizeToFit")]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("setFrameFromContentFrame:")]
	public virtual void SetFrameFromContentFrame(CGRect contentFrame)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetFrameFromContentFrame_Handle, contentFrame);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetFrameFromContentFrame_Handle, contentFrame);
		}
	}

	[Export("setTitleWithMnemonic:")]
	public virtual void SetTitleWithMnemonic(string stringWithMnemonic)
	{
		NSApplication.EnsureUIThread();
		if (stringWithMnemonic == null)
		{
			throw new ArgumentNullException("stringWithMnemonic");
		}
		IntPtr arg = NSString.CreateNative(stringWithMnemonic);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithMnemonic_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithMnemonic_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TitleFont_var = null;
			__mt_TitleCell_var = null;
			__mt_ContentView_var = null;
			__mt_BorderColor_var = null;
			__mt_FillColor_var = null;
		}
	}
}
