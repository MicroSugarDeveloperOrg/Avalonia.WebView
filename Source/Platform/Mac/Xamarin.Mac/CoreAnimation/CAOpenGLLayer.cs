using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace CoreAnimation;

[Register("CAOpenGLLayer", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'CAMetalLayer' instead.")]
public class CAOpenGLLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_ = "canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:";

	private static readonly IntPtr selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle = Selector.GetHandle("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyCGLContextForPixelFormat_ = "copyCGLContextForPixelFormat:";

	private static readonly IntPtr selCopyCGLContextForPixelFormat_Handle = Selector.GetHandle("copyCGLContextForPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyCGLPixelFormatForDisplayMask_ = "copyCGLPixelFormatForDisplayMask:";

	private static readonly IntPtr selCopyCGLPixelFormatForDisplayMask_Handle = Selector.GetHandle("copyCGLPixelFormatForDisplayMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_ = "drawInCGLContext:pixelFormat:forLayerTime:displayTime:";

	private static readonly IntPtr selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle = Selector.GetHandle("drawInCGLContext:pixelFormat:forLayerTime:displayTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAsynchronous = "isAsynchronous";

	private static readonly IntPtr selIsAsynchronousHandle = Selector.GetHandle("isAsynchronous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReleaseCGLContext_ = "releaseCGLContext:";

	private static readonly IntPtr selReleaseCGLContext_Handle = Selector.GetHandle("releaseCGLContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReleaseCGLPixelFormat_ = "releaseCGLPixelFormat:";

	private static readonly IntPtr selReleaseCGLPixelFormat_Handle = Selector.GetHandle("releaseCGLPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAsynchronous_ = "setAsynchronous:";

	private static readonly IntPtr selSetAsynchronous_Handle = Selector.GetHandle("setAsynchronous:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAOpenGLLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Asynchronous
	{
		[Export("isAsynchronous")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAsynchronousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAsynchronousHandle);
		}
		[Export("setAsynchronous:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAsynchronous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAsynchronous_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAOpenGLLayer()
		: base(NSObjectFlag.Empty)
	{
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
	public CAOpenGLLayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected CAOpenGLLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAOpenGLLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDrawInCGLContext(CGLContext glContext, CGLPixelFormat pixelFormat, double timeInterval, ref CVTimeStamp timeStamp)
	{
		if (glContext == null)
		{
			throw new ArgumentNullException("glContext");
		}
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.Handle, selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, ref timeStamp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.SuperHandle, selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, ref timeStamp);
	}

	[Export("copyCGLPixelFormatForDisplayMask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGLPixelFormat CopyCGLPixelFormatForDisplayMask(uint mask)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selCopyCGLPixelFormatForDisplayMask_Handle, mask) : Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selCopyCGLPixelFormatForDisplayMask_Handle, mask));
		return (intPtr == IntPtr.Zero) ? null : new CGLPixelFormat(intPtr);
	}

	[Export("copyCGLContextForPixelFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGLContext CopyContext(CGLPixelFormat pixelFormat)
	{
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyCGLContextForPixelFormat_Handle, pixelFormat.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyCGLContextForPixelFormat_Handle, pixelFormat.Handle));
		return (intPtr == IntPtr.Zero) ? null : new CGLContext(intPtr);
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	[Export("drawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInCGLContext(CGLContext glContext, CGLPixelFormat pixelFormat, double timeInterval, ref CVTimeStamp timeStamp)
	{
		if (glContext == null)
		{
			throw new ArgumentNullException("glContext");
		}
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.Handle, selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, ref timeStamp);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Double_ref_CVTimeStamp(base.SuperHandle, selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, ref timeStamp);
		}
	}

	[Export("releaseCGLPixelFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Release(CGLPixelFormat pixelFormat)
	{
		if (pixelFormat == null)
		{
			throw new ArgumentNullException("pixelFormat");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReleaseCGLPixelFormat_Handle, pixelFormat.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReleaseCGLPixelFormat_Handle, pixelFormat.Handle);
		}
	}

	[Export("releaseCGLContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Release(CGLContext glContext)
	{
		if (glContext == null)
		{
			throw new ArgumentNullException("glContext");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReleaseCGLContext_Handle, glContext.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReleaseCGLContext_Handle, glContext.Handle);
		}
	}
}
