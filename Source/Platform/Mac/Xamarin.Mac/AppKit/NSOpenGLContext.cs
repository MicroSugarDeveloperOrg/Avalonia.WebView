using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace AppKit;

[Register("NSOpenGLContext", true)]
public class NSOpenGLContext : NSObject
{
	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	private static readonly IntPtr selCGLContextObjHandle = Selector.GetHandle("CGLContextObj");

	private static readonly IntPtr selPixelBufferHandle = Selector.GetHandle("pixelBuffer");

	private static readonly IntPtr selPixelBufferCubeMapFaceHandle = Selector.GetHandle("pixelBufferCubeMapFace");

	private static readonly IntPtr selPixelBufferMipMapLevelHandle = Selector.GetHandle("pixelBufferMipMapLevel");

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	private static readonly IntPtr selCurrentVirtualScreenHandle = Selector.GetHandle("currentVirtualScreen");

	private static readonly IntPtr selSetCurrentVirtualScreen_Handle = Selector.GetHandle("setCurrentVirtualScreen:");

	private static readonly IntPtr selInitWithFormatShareContext_Handle = Selector.GetHandle("initWithFormat:shareContext:");

	private static readonly IntPtr selSetFullScreenHandle = Selector.GetHandle("setFullScreen");

	private static readonly IntPtr selSetOffScreenWidthHeightRowbytes_Handle = Selector.GetHandle("setOffScreen:width:height:rowbytes:");

	private static readonly IntPtr selClearDrawableHandle = Selector.GetHandle("clearDrawable");

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	private static readonly IntPtr selFlushBufferHandle = Selector.GetHandle("flushBuffer");

	private static readonly IntPtr selMakeCurrentContextHandle = Selector.GetHandle("makeCurrentContext");

	private static readonly IntPtr selClearCurrentContextHandle = Selector.GetHandle("clearCurrentContext");

	private static readonly IntPtr selCopyAttributesFromContextWithMask_Handle = Selector.GetHandle("copyAttributesFromContext:withMask:");

	private static readonly IntPtr selSetValuesForParameter_Handle = Selector.GetHandle("setValues:forParameter:");

	private static readonly IntPtr selGetValuesForParameter_Handle = Selector.GetHandle("getValues:forParameter:");

	private static readonly IntPtr selCreateTextureFromViewInternalFormat_Handle = Selector.GetHandle("createTexture:fromView:internalFormat:");

	private static readonly IntPtr selSetPixelBufferCubeMapFaceMipMapLevelCurrentVirtualScreen_Handle = Selector.GetHandle("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:");

	private static readonly IntPtr selSetTextureImageToPixelBufferColorBuffer_Handle = Selector.GetHandle("setTextureImageToPixelBuffer:colorBuffer:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOpenGLContext");

	private static object __mt_CurrentContext_var_static;

	private object __mt_PixelBuffer_var;

	private object __mt_View_var;

	public bool SwapRectangleEnabled
	{
		get
		{
			return GetValue(NSOpenGLContextParameter.SwapRectangleEnable) != 0;
		}
		set
		{
			SetValue(value ? 1 : 0, NSOpenGLContextParameter.SwapRectangleEnable);
		}
	}

	public bool RasterizationEnabled
	{
		get
		{
			return GetValue(NSOpenGLContextParameter.RasterizationEnable) != 0;
		}
		set
		{
			SetValue(value ? 1 : 0, NSOpenGLContextParameter.RasterizationEnable);
		}
	}

	public bool SwapInterval
	{
		get
		{
			return GetValue(NSOpenGLContextParameter.SwapInterval) != 0;
		}
		set
		{
			SetValue(value ? 1 : 0, NSOpenGLContextParameter.SwapInterval);
		}
	}

	public NSSurfaceOrder SurfaceOrder
	{
		get
		{
			int value = GetValue(NSOpenGLContextParameter.SurfaceOrder);
			if (value == -1)
			{
				return NSSurfaceOrder.BelowWindow;
			}
			return NSSurfaceOrder.AboveWindow;
		}
		set
		{
			SetValue((value != NSSurfaceOrder.BelowWindow) ? 1 : (-1), NSOpenGLContextParameter.SurfaceOrder);
		}
	}

	public bool SurfaceOpaque
	{
		get
		{
			return GetValue(NSOpenGLContextParameter.SurfaceOpacity) != 0;
		}
		set
		{
			SetValue(value ? 1 : 0, NSOpenGLContextParameter.SurfaceOpacity);
		}
	}

	public bool StateValidation
	{
		get
		{
			return GetValue(NSOpenGLContextParameter.StateValidation) != 0;
		}
		set
		{
			SetValue(value ? 1 : 0, NSOpenGLContextParameter.StateValidation);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public static NSOpenGLContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSOpenGLContext)(__mt_CurrentContext_var_static = (NSOpenGLContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle)));
		}
	}

	[ThreadSafe]
	public virtual CGLContext CGLContext
	{
		[Export("CGLContextObj")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGLContext(Messaging.IntPtr_objc_msgSend(base.Handle, selCGLContextObjHandle));
			}
			return new CGLContext(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGLContextObjHandle));
		}
	}

	public virtual NSOpenGLPixelBuffer PixelBuffer
	{
		[Export("pixelBuffer")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSOpenGLPixelBuffer)(__mt_PixelBuffer_var = ((!IsDirectBinding) ? ((NSOpenGLPixelBuffer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferHandle))) : ((NSOpenGLPixelBuffer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferHandle)))));
		}
	}

	public virtual int PixelBufferCubeMapFace
	{
		[Export("pixelBufferCubeMapFace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelBufferCubeMapFaceHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelBufferCubeMapFaceHandle);
		}
	}

	public virtual int PixelBufferMipMapLevel
	{
		[Export("pixelBufferMipMapLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelBufferMipMapLevelHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelBufferMipMapLevelHandle);
		}
	}

	public virtual NSView View
	{
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_View_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle)))));
		}
		[Export("setView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value.Handle);
			}
			__mt_View_var = value;
		}
	}

	public virtual int CurrentVirtualScreen
	{
		[Export("currentVirtualScreen")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCurrentVirtualScreenHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCurrentVirtualScreenHandle);
		}
		[Export("setCurrentVirtualScreen:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetCurrentVirtualScreen_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCurrentVirtualScreen_Handle, value);
			}
		}
	}

	private unsafe void SetValue(int val, NSOpenGLContextParameter par)
	{
		int* ptr = &val;
		SetValues((IntPtr)ptr, par);
	}

	private unsafe int GetValue(NSOpenGLContextParameter par)
	{
		int result = default(int);
		int* ptr = &result;
		GetValues((IntPtr)ptr, par);
		return result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOpenGLContext(NSCoder coder)
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
	public NSOpenGLContext(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenGLContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFormat:shareContext:")]
	public NSOpenGLContext(NSOpenGLPixelFormat format, NSOpenGLContext shareContext)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithFormatShareContext_Handle, format.Handle, shareContext?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithFormatShareContext_Handle, format.Handle, shareContext?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("setFullScreen")]
	public virtual void SetFullScreen()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetFullScreenHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetFullScreenHandle);
		}
	}

	[Export("setOffScreen:width:height:rowbytes:")]
	public virtual void SetOffScreen(IntPtr baseaddr, int width, int height, int rowbytes)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_int_int(base.Handle, selSetOffScreenWidthHeightRowbytes_Handle, baseaddr, width, height, rowbytes);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_int_int(base.SuperHandle, selSetOffScreenWidthHeightRowbytes_Handle, baseaddr, width, height, rowbytes);
		}
	}

	[Export("clearDrawable")]
	public virtual void ClearDrawable()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearDrawableHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearDrawableHandle);
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

	[Export("flushBuffer")]
	[ThreadSafe]
	public virtual void FlushBuffer()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushBufferHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushBufferHandle);
		}
	}

	[Export("makeCurrentContext")]
	[ThreadSafe]
	public virtual void MakeCurrentContext()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeCurrentContextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeCurrentContextHandle);
		}
	}

	[Export("clearCurrentContext")]
	public static void ClearCurrentContext()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selClearCurrentContextHandle);
	}

	[Export("copyAttributesFromContext:withMask:")]
	public virtual void CopyAttributes(NSOpenGLContext context, uint mask)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selCopyAttributesFromContextWithMask_Handle, context.Handle, mask);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selCopyAttributesFromContextWithMask_Handle, context.Handle, mask);
		}
	}

	[Export("setValues:forParameter:")]
	public virtual void SetValues(IntPtr vals, NSOpenGLContextParameter param)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetValuesForParameter_Handle, vals, (long)param);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetValuesForParameter_Handle, vals, (long)param);
		}
	}

	[Export("getValues:forParameter:")]
	public virtual void GetValues(IntPtr vals, NSOpenGLContextParameter param)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selGetValuesForParameter_Handle, vals, (long)param);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selGetValuesForParameter_Handle, vals, (long)param);
		}
	}

	[Export("createTexture:fromView:internalFormat:")]
	public virtual void CreateTexture(int targetIdentifier, NSView view, int format)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr_int(base.Handle, selCreateTextureFromViewInternalFormat_Handle, targetIdentifier, view.Handle, format);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr_int(base.SuperHandle, selCreateTextureFromViewInternalFormat_Handle, targetIdentifier, view.Handle, format);
		}
	}

	[Export("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:")]
	public virtual void SetPixelBuffer(NSOpenGLPixelBuffer pixelBuffer, NSGLTextureCubeMap face, int level, int screen)
	{
		NSApplication.EnsureUIThread();
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_int_int(base.Handle, selSetPixelBufferCubeMapFaceMipMapLevelCurrentVirtualScreen_Handle, pixelBuffer.Handle, (int)face, level, screen);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_int_int(base.SuperHandle, selSetPixelBufferCubeMapFaceMipMapLevelCurrentVirtualScreen_Handle, pixelBuffer.Handle, (int)face, level, screen);
		}
	}

	[Export("setTextureImageToPixelBuffer:colorBuffer:")]
	public virtual void SetTextureImage(NSOpenGLPixelBuffer pixelBuffer, NSGLColorBuffer source)
	{
		NSApplication.EnsureUIThread();
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetTextureImageToPixelBufferColorBuffer_Handle, pixelBuffer.Handle, (int)source);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetTextureImageToPixelBufferColorBuffer_Handle, pixelBuffer.Handle, (int)source);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PixelBuffer_var = null;
			__mt_View_var = null;
		}
	}
}
