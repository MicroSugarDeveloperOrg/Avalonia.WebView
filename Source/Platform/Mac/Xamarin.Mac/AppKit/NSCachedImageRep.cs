using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCachedImageRep", true)]
public class NSCachedImageRep : NSImageRep
{
	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	private static readonly IntPtr selRectHandle = Selector.GetHandle("rect");

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	private static readonly IntPtr selInitWithSizeDepthSeparateAlpha_Handle = Selector.GetHandle("initWithSize:depth:separate:alpha:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCachedImageRep");

	private object __mt_Window_var;

	public override IntPtr ClassHandle => class_ptr;

	[Obsolete("Deprecated in OSX 10.6", false)]
	public virtual NSWindow Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_Window_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle)))));
		}
	}

	[Obsolete("Deprecated in OSX 10.6", false)]
	public virtual CGRect Rectangle
	{
		[Export("rect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectHandle);
			}
			return retval;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCachedImageRep(NSCoder coder)
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
	public NSCachedImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCachedImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[Obsolete("Deprecated in OSX 10.6", false)]
	public NSCachedImageRep(NSWindow win, CGRect rect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (win == null)
		{
			throw new ArgumentNullException("win");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_CGRect(base.Handle, selInitWithIdentifier_Handle, win.Handle, rect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selInitWithIdentifier_Handle, win.Handle, rect);
		}
	}

	[Export("initWithSize:depth:separate:alpha:")]
	[Obsolete("Deprecated in OSX 10.6", false)]
	public NSCachedImageRep(CGSize size, NSWindowDepth depth, bool separate, bool alpha)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGSize_Int64_bool_bool(base.Handle, selInitWithSizeDepthSeparateAlpha_Handle, size, (long)depth, separate, alpha);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGSize_Int64_bool_bool(base.SuperHandle, selInitWithSizeDepthSeparateAlpha_Handle, size, (long)depth, separate, alpha);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Window_var = null;
		}
	}
}
