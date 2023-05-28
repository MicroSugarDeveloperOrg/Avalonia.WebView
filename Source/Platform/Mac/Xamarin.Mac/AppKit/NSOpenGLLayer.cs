using System;
using System.ComponentModel;
using CoreAnimation;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenGLLayer", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public class NSOpenGLLayer : CAOpenGLLayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_ = "canDrawInOpenGLContext:pixelFormat:forLayerTime:displayTime:";

	private static readonly IntPtr selCanDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle = Selector.GetHandle("canDrawInOpenGLContext:pixelFormat:forLayerTime:displayTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_ = "drawInOpenGLContext:pixelFormat:forLayerTime:displayTime:";

	private static readonly IntPtr selDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle = Selector.GetHandle("drawInOpenGLContext:pixelFormat:forLayerTime:displayTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenGLContext = "openGLContext";

	private static readonly IntPtr selOpenGLContextHandle = Selector.GetHandle("openGLContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenGLContextForPixelFormat_ = "openGLContextForPixelFormat:";

	private static readonly IntPtr selOpenGLContextForPixelFormat_Handle = Selector.GetHandle("openGLContextForPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenGLPixelFormat = "openGLPixelFormat";

	private static readonly IntPtr selOpenGLPixelFormatHandle = Selector.GetHandle("openGLPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenGLPixelFormatForDisplayMask_ = "openGLPixelFormatForDisplayMask:";

	private static readonly IntPtr selOpenGLPixelFormatForDisplayMask_Handle = Selector.GetHandle("openGLPixelFormatForDisplayMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpenGLContext_ = "setOpenGLContext:";

	private static readonly IntPtr selSetOpenGLContext_Handle = Selector.GetHandle("setOpenGLContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpenGLPixelFormat_ = "setOpenGLPixelFormat:";

	private static readonly IntPtr selSetOpenGLPixelFormat_Handle = Selector.GetHandle("setOpenGLPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetView_ = "setView:";

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOpenGLLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_View_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOpenGLContext? OpenGLContext
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOpenGLContext_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOpenGLContext_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOpenGLPixelFormat? OpenGLPixelFormat
	{
		[Export("openGLPixelFormat", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selOpenGLPixelFormatHandle));
			}
			return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpenGLPixelFormatHandle));
		}
		[Export("setOpenGLPixelFormat:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOpenGLPixelFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOpenGLPixelFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? View
	{
		[Export("view", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSView nSView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle)) : Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle)));
			MarkDirty();
			__mt_View_var = nSView;
			return nSView;
		}
		[Export("setView:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_View_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLLayer()
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
	public NSOpenGLLayer(NSCoder coder)
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
	protected NSOpenGLLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenGLLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canDrawInOpenGLContext:pixelFormat:forLayerTime:displayTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDraw(NSOpenGLContext context, NSOpenGLPixelFormat pixelFormat, double t, ref CVTimeStamp ts)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.Handle, selCanDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, context.Handle, pixelFormat.Handle, t, ref ts);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.SuperHandle, selCanDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, context.Handle, pixelFormat.Handle, t, ref ts);
	}

	[Export("drawInOpenGLContext:pixelFormat:forLayerTime:displayTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(NSOpenGLContext context, NSOpenGLPixelFormat pixelFormat, double t, ref CVTimeStamp ts)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.Handle, selDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, context.Handle, pixelFormat.Handle, t, ref ts);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.SuperHandle, selDrawInOpenGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, context.Handle, pixelFormat.Handle, t, ref ts);
		}
	}

	[Export("openGLContextForPixelFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOpenGLContext GetOpenGLContext(NSOpenGLPixelFormat pixelFormat)
	{
		NSApplication.EnsureUIThread();
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSOpenGLContext>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOpenGLContextForPixelFormat_Handle, pixelFormat.Handle));
		}
		return Runtime.GetNSObject<NSOpenGLContext>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenGLContextForPixelFormat_Handle, pixelFormat.Handle));
	}

	[Export("openGLPixelFormatForDisplayMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOpenGLPixelFormat GetOpenGLPixelFormat(uint mask)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selOpenGLPixelFormatForDisplayMask_Handle, mask));
		}
		return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selOpenGLPixelFormatForDisplayMask_Handle, mask));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_View_var = null;
		}
	}
}
