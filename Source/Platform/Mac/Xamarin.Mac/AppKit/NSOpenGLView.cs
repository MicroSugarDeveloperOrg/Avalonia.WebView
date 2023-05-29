using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenGLView", true)]
public class NSOpenGLView : NSView
{
	private static readonly IntPtr selDefaultPixelFormatHandle = Selector.GetHandle("defaultPixelFormat");

	private static readonly IntPtr selOpenGLContextHandle = Selector.GetHandle("openGLContext");

	private static readonly IntPtr selSetOpenGLContext_Handle = Selector.GetHandle("setOpenGLContext:");

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	private static readonly IntPtr selSetPixelFormat_Handle = Selector.GetHandle("setPixelFormat:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selInitWithFramePixelFormat_Handle = Selector.GetHandle("initWithFrame:pixelFormat:");

	private static readonly IntPtr selClearGLContextHandle = Selector.GetHandle("clearGLContext");

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	private static readonly IntPtr selReshapeHandle = Selector.GetHandle("reshape");

	private static readonly IntPtr selPrepareOpenGLHandle = Selector.GetHandle("prepareOpenGL");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOpenGLView");

	private static object __mt_DefaultPixelFormat_var_static;

	private object __mt_OpenGLContext_var;

	private object __mt_PixelFormat_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSOpenGLPixelFormat DefaultPixelFormat
	{
		[Export("defaultPixelFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSOpenGLPixelFormat)(__mt_DefaultPixelFormat_var_static = (NSOpenGLPixelFormat)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultPixelFormatHandle)));
		}
	}

	public virtual NSOpenGLContext OpenGLContext
	{
		[Export("openGLContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSOpenGLContext)(__mt_OpenGLContext_var = ((!IsDirectBinding) ? ((NSOpenGLContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpenGLContextHandle))) : ((NSOpenGLContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOpenGLContextHandle)))));
		}
		[Export("setOpenGLContext:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOpenGLContext_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOpenGLContext_Handle, value.Handle);
			}
			__mt_OpenGLContext_var = value;
		}
	}

	public virtual NSOpenGLPixelFormat PixelFormat
	{
		[Export("pixelFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSOpenGLPixelFormat)(__mt_PixelFormat_var = ((!IsDirectBinding) ? ((NSOpenGLPixelFormat)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle))) : ((NSOpenGLPixelFormat)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelFormatHandle)))));
		}
		[Export("setPixelFormat:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPixelFormat_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPixelFormat_Handle, value.Handle);
			}
			__mt_PixelFormat_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLView()
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
	public NSOpenGLView(NSCoder coder)
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
	public NSOpenGLView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenGLView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSOpenGLView(CGRect frameRect)
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

	[Export("initWithFrame:pixelFormat:")]
	public NSOpenGLView(CGRect frameRect, NSOpenGLPixelFormat format)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFramePixelFormat_Handle, frameRect, format.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFramePixelFormat_Handle, frameRect, format.Handle);
		}
	}

	[Export("clearGLContext")]
	public virtual void ClearGLContext()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearGLContextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearGLContextHandle);
		}
	}

	[Export("update")]
	public virtual void Update()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
		}
	}

	[Export("reshape")]
	public virtual void Reshape()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReshapeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReshapeHandle);
		}
	}

	[Export("prepareOpenGL")]
	public virtual void PrepareOpenGL()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareOpenGLHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareOpenGLHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OpenGLContext_var = null;
			__mt_PixelFormat_var = null;
		}
	}
}
