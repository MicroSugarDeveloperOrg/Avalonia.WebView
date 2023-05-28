using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenGLPixelBuffer", true)]
[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public class NSOpenGLPixelBuffer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGLPBufferObj = "CGLPBufferObj";

	private static readonly IntPtr selCGLPBufferObjHandle = Selector.GetHandle("CGLPBufferObj");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTextureTarget_TextureInternalFormat_TextureMaxMipMapLevel_PixelsWide_PixelsHigh_ = "initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:";

	private static readonly IntPtr selInitWithTextureTarget_TextureInternalFormat_TextureMaxMipMapLevel_PixelsWide_PixelsHigh_Handle = Selector.GetHandle("initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelsHigh = "pixelsHigh";

	private static readonly IntPtr selPixelsHighHandle = Selector.GetHandle("pixelsHigh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelsWide = "pixelsWide";

	private static readonly IntPtr selPixelsWideHandle = Selector.GetHandle("pixelsWide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureInternalFormat = "textureInternalFormat";

	private static readonly IntPtr selTextureInternalFormatHandle = Selector.GetHandle("textureInternalFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureMaxMipMapLevel = "textureMaxMipMapLevel";

	private static readonly IntPtr selTextureMaxMipMapLevelHandle = Selector.GetHandle("textureMaxMipMapLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureTarget = "textureTarget";

	private static readonly IntPtr selTextureTargetHandle = Selector.GetHandle("textureTarget");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOpenGLPixelBuffer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr CGLPBuffer
	{
		[Export("CGLPBufferObj")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selCGLPBufferObjHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGLPBufferObjHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int PixelsHigh
	{
		[Export("pixelsHigh")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelsHighHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelsHighHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int PixelsWide
	{
		[Export("pixelsWide")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelsWideHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelsWideHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGLFormat TextureInternalFormat
	{
		[Export("textureInternalFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSGLFormat)Messaging.UInt32_objc_msgSend(base.Handle, selTextureInternalFormatHandle);
			}
			return (NSGLFormat)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selTextureInternalFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int TextureMaxMipMapLevel
	{
		[Export("textureMaxMipMapLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTextureMaxMipMapLevelHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTextureMaxMipMapLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGLTextureTarget TextureTarget
	{
		[Export("textureTarget")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSGLTextureTarget)Messaging.UInt32_objc_msgSend(base.Handle, selTextureTargetHandle);
			}
			return (NSGLTextureTarget)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selTextureTargetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLPixelBuffer()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOpenGLPixelBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenGLPixelBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOpenGLPixelBuffer(NSGLTextureTarget targetGlEnum, NSGLFormat format, int maxLevel, int pixelsWide, int pixelsHigh)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32_UInt32_int_int_int(base.Handle, selInitWithTextureTarget_TextureInternalFormat_TextureMaxMipMapLevel_PixelsWide_PixelsHigh_Handle, (uint)targetGlEnum, (uint)format, maxLevel, pixelsWide, pixelsHigh), "initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32_int_int_int(base.SuperHandle, selInitWithTextureTarget_TextureInternalFormat_TextureMaxMipMapLevel_PixelsWide_PixelsHigh_Handle, (uint)targetGlEnum, (uint)format, maxLevel, pixelsWide, pixelsHigh), "initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:");
		}
	}
}
