using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace CoreAnimation;

[Register("CAOpenGLLayer", true)]
public class CAOpenGLLayer : CALayer
{
	private static readonly IntPtr selIsAsynchronousHandle = Selector.GetHandle("isAsynchronous");

	private static readonly IntPtr selSetAsynchronous_Handle = Selector.GetHandle("setAsynchronous:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr selCanDrawInCGLContextPixelFormatForLayerTimeDisplayTime_Handle = Selector.GetHandle("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:");

	private static readonly IntPtr selDrawInCGLContextPixelFormatForLayerTimeDisplayTime_Handle = Selector.GetHandle("drawInCGLContext:pixelFormat:forLayerTime:displayTime:");

	private static readonly IntPtr selCopyCGLPixelFormatForDisplayMask_Handle = Selector.GetHandle("copyCGLPixelFormatForDisplayMask:");

	private static readonly IntPtr selReleaseCGLPixelFormat_Handle = Selector.GetHandle("releaseCGLPixelFormat:");

	private static readonly IntPtr selCopyCGLContextForPixelFormat_Handle = Selector.GetHandle("copyCGLContextForPixelFormat:");

	private static readonly IntPtr selReleaseCGLContext_Handle = Selector.GetHandle("releaseCGLContext:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAOpenGLLayer");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool Asynchronous
	{
		[Export("isAsynchronous")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAsynchronousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAsynchronousHandle);
		}
		[Export("setAsynchronous:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAsynchronous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAsynchronous_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAOpenGLLayer()
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
	public CAOpenGLLayer(NSCoder coder)
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
	public CAOpenGLLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAOpenGLLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	[Export("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
	public virtual bool CanDrawInCGLContext(CGLContext glContext, CGLPixelFormat pixelFormat, double timeInterval, ref CVTimeStamp timeStamp)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_Double_out_CVTimeStamp(base.Handle, selCanDrawInCGLContextPixelFormatForLayerTimeDisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, out timeStamp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_Double_out_CVTimeStamp(base.SuperHandle, selCanDrawInCGLContextPixelFormatForLayerTimeDisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, out timeStamp);
	}

	[Export("drawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
	public virtual void DrawInCGLContext(CGLContext glContext, CGLPixelFormat pixelFormat, double timeInterval, ref CVTimeStamp timeStamp)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_out_CVTimeStamp(base.Handle, selDrawInCGLContextPixelFormatForLayerTimeDisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, out timeStamp);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Double_out_CVTimeStamp(base.SuperHandle, selDrawInCGLContextPixelFormatForLayerTimeDisplayTime_Handle, glContext.Handle, pixelFormat.Handle, timeInterval, out timeStamp);
		}
	}

	[Export("copyCGLPixelFormatForDisplayMask:")]
	public virtual CGLPixelFormat CopyCGLPixelFormatForDisplayMask(uint mask)
	{
		if (IsDirectBinding)
		{
			return new CGLPixelFormat(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selCopyCGLPixelFormatForDisplayMask_Handle, mask));
		}
		return new CGLPixelFormat(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selCopyCGLPixelFormatForDisplayMask_Handle, mask));
	}

	[Export("releaseCGLPixelFormat:")]
	public virtual void Release(CGLPixelFormat pixelFormat)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReleaseCGLPixelFormat_Handle, pixelFormat.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReleaseCGLPixelFormat_Handle, pixelFormat.Handle);
		}
	}

	[Export("copyCGLContextForPixelFormat:")]
	public virtual CGLContext CopyContext(CGLPixelFormat pixelFormat)
	{
		if (IsDirectBinding)
		{
			return new CGLContext(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyCGLContextForPixelFormat_Handle, pixelFormat.Handle));
		}
		return new CGLContext(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyCGLContextForPixelFormat_Handle, pixelFormat.Handle));
	}

	[Export("releaseCGLContext:")]
	public virtual void Release(CGLContext glContext)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReleaseCGLContext_Handle, glContext.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReleaseCGLContext_Handle, glContext.Handle);
		}
	}
}
