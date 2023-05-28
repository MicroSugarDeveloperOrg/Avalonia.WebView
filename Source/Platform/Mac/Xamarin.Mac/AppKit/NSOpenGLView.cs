using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenGLView", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public class NSOpenGLView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearGLContext = "clearGLContext";

	private static readonly IntPtr selClearGLContextHandle = Selector.GetHandle("clearGLContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultPixelFormat = "defaultPixelFormat";

	private static readonly IntPtr selDefaultPixelFormatHandle = Selector.GetHandle("defaultPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_PixelFormat_ = "initWithFrame:pixelFormat:";

	private static readonly IntPtr selInitWithFrame_PixelFormat_Handle = Selector.GetHandle("initWithFrame:pixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenGLContext = "openGLContext";

	private static readonly IntPtr selOpenGLContextHandle = Selector.GetHandle("openGLContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareOpenGL = "prepareOpenGL";

	private static readonly IntPtr selPrepareOpenGLHandle = Selector.GetHandle("prepareOpenGL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReshape = "reshape";

	private static readonly IntPtr selReshapeHandle = Selector.GetHandle("reshape");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpenGLContext_ = "setOpenGLContext:";

	private static readonly IntPtr selSetOpenGLContext_Handle = Selector.GetHandle("setOpenGLContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelFormat_ = "setPixelFormat:";

	private static readonly IntPtr selSetPixelFormat_Handle = Selector.GetHandle("setPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdate = "update";

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOpenGLView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOpenGLPixelFormat DefaultPixelFormat
	{
		[Export("defaultPixelFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultPixelFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOpenGLContext OpenGLContext
	{
		[Export("openGLContext", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOpenGLContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selOpenGLContextHandle));
			}
			return Runtime.GetNSObject<NSOpenGLContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpenGLContextHandle));
		}
		[Export("setOpenGLContext:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOpenGLContext_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOpenGLContext_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOpenGLPixelFormat PixelFormat
	{
		[Export("pixelFormat", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelFormatHandle));
			}
			return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle));
		}
		[Export("setPixelFormat:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPixelFormat_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPixelFormat_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLView()
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
	public NSOpenGLView(NSCoder coder)
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
	protected NSOpenGLView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenGLView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOpenGLView(CGRect frameRect)
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

	[Export("initWithFrame:pixelFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOpenGLView(CGRect frameRect, NSOpenGLPixelFormat format)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrame_PixelFormat_Handle, frameRect, format.Handle), "initWithFrame:pixelFormat:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrame_PixelFormat_Handle, frameRect, format.Handle), "initWithFrame:pixelFormat:");
		}
	}

	[Export("clearGLContext")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearGLContext()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearGLContextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearGLContextHandle);
		}
	}

	[Export("prepareOpenGL")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void PrepareOpenGL()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareOpenGLHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareOpenGLHandle);
		}
	}

	[Export("reshape")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void Reshape()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReshapeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReshapeHandle);
		}
	}

	[Export("update")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void Update()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
		}
	}
}
