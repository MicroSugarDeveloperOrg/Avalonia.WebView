using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBrowserCell", true)]
public class NSBrowserCell : NSCell
{
	private static readonly IntPtr selBranchImageHandle = Selector.GetHandle("branchImage");

	private static readonly IntPtr selHighlightedBranchImageHandle = Selector.GetHandle("highlightedBranchImage");

	private static readonly IntPtr selIsLeafHandle = Selector.GetHandle("isLeaf");

	private static readonly IntPtr selSetLeaf_Handle = Selector.GetHandle("setLeaf:");

	private static readonly IntPtr selIsLoadedHandle = Selector.GetHandle("isLoaded");

	private static readonly IntPtr selSetLoaded_Handle = Selector.GetHandle("setLoaded:");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	private static readonly IntPtr selSetAlternateImage_Handle = Selector.GetHandle("setAlternateImage:");

	private static readonly IntPtr selHighlightColorInView_Handle = Selector.GetHandle("highlightColorInView:");

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBrowserCell");

	private static object __mt_BranchImage_var_static;

	private static object __mt_HighlightedBranchImage_var_static;

	private object __mt_Image_var;

	private object __mt_AlternateImage_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSImage BranchImage
	{
		[Export("branchImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_BranchImage_var_static = (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selBranchImageHandle)));
		}
	}

	public static NSImage HighlightedBranchImage
	{
		[Export("highlightedBranchImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_HighlightedBranchImage_var_static = (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selHighlightedBranchImageHandle)));
		}
	}

	public virtual bool Leaf
	{
		[Export("isLeaf")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLeafHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLeafHandle);
		}
		[Export("setLeaf:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLeaf_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLeaf_Handle, value);
			}
		}
	}

	public virtual bool Loaded
	{
		[Export("isLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadedHandle);
		}
		[Export("setLoaded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoaded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoaded_Handle, value);
			}
		}
	}

	public new virtual NSImage Image
	{
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Image_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle)))));
		}
		[Export("setImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
			__mt_Image_var = value;
		}
	}

	public virtual NSImage AlternateImage
	{
		[Export("alternateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_AlternateImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle)))));
		}
		[Export("setAlternateImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateImage_Handle, value.Handle);
			}
			__mt_AlternateImage_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBrowserCell()
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
	public NSBrowserCell(NSCoder coder)
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
	public NSBrowserCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBrowserCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("highlightColorInView:")]
	public virtual NSColor HighlightColorInView(NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selHighlightColorInView_Handle, controlView.Handle));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selHighlightColorInView_Handle, controlView.Handle));
	}

	[Export("reset")]
	public virtual void Reset()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("set")]
	public virtual void Set()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Image_var = null;
			__mt_AlternateImage_var = null;
		}
	}
}
