using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace AppKit;

[Register("NSOpenGLContext", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public class NSOpenGLContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGLContextObj = "CGLContextObj";

	private static readonly IntPtr selCGLContextObjHandle = Selector.GetHandle("CGLContextObj");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearCurrentContext = "clearCurrentContext";

	private static readonly IntPtr selClearCurrentContextHandle = Selector.GetHandle("clearCurrentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearDrawable = "clearDrawable";

	private static readonly IntPtr selClearDrawableHandle = Selector.GetHandle("clearDrawable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyAttributesFromContext_WithMask_ = "copyAttributesFromContext:withMask:";

	private static readonly IntPtr selCopyAttributesFromContext_WithMask_Handle = Selector.GetHandle("copyAttributesFromContext:withMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateTexture_FromView_InternalFormat_ = "createTexture:fromView:internalFormat:";

	private static readonly IntPtr selCreateTexture_FromView_InternalFormat_Handle = Selector.GetHandle("createTexture:fromView:internalFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentContext = "currentContext";

	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentVirtualScreen = "currentVirtualScreen";

	private static readonly IntPtr selCurrentVirtualScreenHandle = Selector.GetHandle("currentVirtualScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushBuffer = "flushBuffer";

	private static readonly IntPtr selFlushBufferHandle = Selector.GetHandle("flushBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetValues_ForParameter_ = "getValues:forParameter:";

	private static readonly IntPtr selGetValues_ForParameter_Handle = Selector.GetHandle("getValues:forParameter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFormat_ShareContext_ = "initWithFormat:shareContext:";

	private static readonly IntPtr selInitWithFormat_ShareContext_Handle = Selector.GetHandle("initWithFormat:shareContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeCurrentContext = "makeCurrentContext";

	private static readonly IntPtr selMakeCurrentContextHandle = Selector.GetHandle("makeCurrentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBuffer = "pixelBuffer";

	private static readonly IntPtr selPixelBufferHandle = Selector.GetHandle("pixelBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBufferCubeMapFace = "pixelBufferCubeMapFace";

	private static readonly IntPtr selPixelBufferCubeMapFaceHandle = Selector.GetHandle("pixelBufferCubeMapFace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBufferMipMapLevel = "pixelBufferMipMapLevel";

	private static readonly IntPtr selPixelBufferMipMapLevelHandle = Selector.GetHandle("pixelBufferMipMapLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentVirtualScreen_ = "setCurrentVirtualScreen:";

	private static readonly IntPtr selSetCurrentVirtualScreen_Handle = Selector.GetHandle("setCurrentVirtualScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFullScreen = "setFullScreen";

	private static readonly IntPtr selSetFullScreenHandle = Selector.GetHandle("setFullScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOffScreen_Width_Height_Rowbytes_ = "setOffScreen:width:height:rowbytes:";

	private static readonly IntPtr selSetOffScreen_Width_Height_Rowbytes_Handle = Selector.GetHandle("setOffScreen:width:height:rowbytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_ = "setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:";

	private static readonly IntPtr selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_Handle = Selector.GetHandle("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextureImageToPixelBuffer_ColorBuffer_ = "setTextureImageToPixelBuffer:colorBuffer:";

	private static readonly IntPtr selSetTextureImageToPixelBuffer_ColorBuffer_Handle = Selector.GetHandle("setTextureImageToPixelBuffer:colorBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValues_ForParameter_ = "setValues:forParameter:";

	private static readonly IntPtr selSetValues_ForParameter_Handle = Selector.GetHandle("setValues:forParameter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetView_ = "setView:";

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdate = "update";

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOpenGLContext");

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
			int num = value;
			if (num == -1)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGLContext CGLContext
	{
		[Export("CGLContextObj")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGLContextObjHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGLContextObjHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGLContext(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOpenGLContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			return Runtime.GetNSObject<NSOpenGLContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int CurrentVirtualScreen
	{
		[Export("currentVirtualScreen")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCurrentVirtualScreenHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCurrentVirtualScreenHandle);
		}
		[Export("setCurrentVirtualScreen:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetCurrentVirtualScreen_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCurrentVirtualScreen_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual NSOpenGLPixelBuffer PixelBuffer
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("pixelBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOpenGLPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferHandle));
			}
			return Runtime.GetNSObject<NSOpenGLPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual int PixelBufferCubeMapFace
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("pixelBufferCubeMapFace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelBufferCubeMapFaceHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelBufferCubeMapFaceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual int PixelBufferMipMapLevel
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("pixelBufferMipMapLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelBufferMipMapLevelHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelBufferMipMapLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSOpenGLPixelFormat PixelFormat
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("pixelFormat", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelFormatHandle));
			}
			return Runtime.GetNSObject<NSOpenGLPixelFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	public virtual NSView View
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
		[Export("view")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
		[Export("setView:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value.Handle);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOpenGLContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenGLContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFormat:shareContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOpenGLContext(NSOpenGLPixelFormat format, NSOpenGLContext? shareContext)
		: base(NSObjectFlag.Empty)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithFormat_ShareContext_Handle, format.Handle, shareContext?.Handle ?? IntPtr.Zero), "initWithFormat:shareContext:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithFormat_ShareContext_Handle, format.Handle, shareContext?.Handle ?? IntPtr.Zero), "initWithFormat:shareContext:");
		}
	}

	[Export("clearCurrentContext")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ClearCurrentContext()
	{
		Messaging.void_objc_msgSend(class_ptr, selClearCurrentContextHandle);
	}

	[Export("clearDrawable")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearDrawable()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearDrawableHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearDrawableHandle);
		}
	}

	[Export("copyAttributesFromContext:withMask:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CopyAttributes(NSOpenGLContext context, uint mask)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selCopyAttributesFromContext_WithMask_Handle, context.Handle, mask);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selCopyAttributesFromContext_WithMask_Handle, context.Handle, mask);
		}
	}

	[Export("createTexture:fromView:internalFormat:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreateTexture(int targetIdentifier, NSView view, int format)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr_int(base.Handle, selCreateTexture_FromView_InternalFormat_Handle, targetIdentifier, view.Handle, format);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr_int(base.SuperHandle, selCreateTexture_FromView_InternalFormat_Handle, targetIdentifier, view.Handle, format);
		}
	}

	[Export("flushBuffer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlushBuffer()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushBufferHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushBufferHandle);
		}
	}

	[Export("getValues:forParameter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetValues(IntPtr vals, NSOpenGLContextParameter param)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selGetValues_ForParameter_Handle, vals, (ulong)param);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selGetValues_ForParameter_Handle, vals, (ulong)param);
		}
	}

	[Export("makeCurrentContext")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeCurrentContext()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeCurrentContextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeCurrentContextHandle);
		}
	}

	[Export("setFullScreen")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFullScreen()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetFullScreenHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetFullScreenHandle);
		}
	}

	[Export("setOffScreen:width:height:rowbytes:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOffScreen(IntPtr baseaddr, int width, int height, int rowbytes)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_int_int(base.Handle, selSetOffScreen_Width_Height_Rowbytes_Handle, baseaddr, width, height, rowbytes);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_int_int(base.SuperHandle, selSetOffScreen_Width_Height_Rowbytes_Handle, baseaddr, width, height, rowbytes);
		}
	}

	[Export("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPixelBuffer(NSOpenGLPixelBuffer pixelBuffer, NSGLTextureCubeMap face, int level, int screen)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32_int_int(base.Handle, selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_Handle, pixelBuffer.Handle, (uint)face, level, screen);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32_int_int(base.SuperHandle, selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_Handle, pixelBuffer.Handle, (uint)face, level, screen);
		}
	}

	[Export("setTextureImageToPixelBuffer:colorBuffer:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextureImage(NSOpenGLPixelBuffer pixelBuffer, NSGLColorBuffer source)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetTextureImageToPixelBuffer_ColorBuffer_Handle, pixelBuffer.Handle, (uint)source);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetTextureImageToPixelBuffer_ColorBuffer_Handle, pixelBuffer.Handle, (uint)source);
		}
	}

	[Export("setValues:forParameter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValues(IntPtr vals, NSOpenGLContextParameter param)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selSetValues_ForParameter_Handle, vals, (ulong)param);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selSetValues_ForParameter_Handle, vals, (ulong)param);
		}
	}

	[Export("update")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update()
	{
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
