using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenGLPixelBuffer", true)]
public class NSOpenGLPixelBuffer : NSObject
{
	private static readonly IntPtr selCGLPBufferObjHandle = Selector.GetHandle("CGLPBufferObj");

	private static readonly IntPtr selPixelsWideHandle = Selector.GetHandle("pixelsWide");

	private static readonly IntPtr selPixelsHighHandle = Selector.GetHandle("pixelsHigh");

	private static readonly IntPtr selTextureTargetHandle = Selector.GetHandle("textureTarget");

	private static readonly IntPtr selTextureInternalFormatHandle = Selector.GetHandle("textureInternalFormat");

	private static readonly IntPtr selTextureMaxMipMapLevelHandle = Selector.GetHandle("textureMaxMipMapLevel");

	private static readonly IntPtr selInitWithTextureTargetTextureInternalFormatTextureMaxMipMapLevelPixelsWidePixelsHigh_Handle = Selector.GetHandle("initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOpenGLPixelBuffer");

	public override IntPtr ClassHandle => class_ptr;

	public virtual IntPtr CGLPBuffer
	{
		[Export("CGLPBufferObj")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selCGLPBufferObjHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGLPBufferObjHandle);
		}
	}

	public virtual int PixelsWide
	{
		[Export("pixelsWide")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelsWideHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelsWideHandle);
		}
	}

	public virtual int PixelsHigh
	{
		[Export("pixelsHigh")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPixelsHighHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPixelsHighHandle);
		}
	}

	public virtual NSGLTextureTarget TextureTarget
	{
		[Export("textureTarget")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSGLTextureTarget)Messaging.int_objc_msgSend(base.Handle, selTextureTargetHandle);
			}
			return (NSGLTextureTarget)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTextureTargetHandle);
		}
	}

	public virtual NSGLFormat TextureInternalFormat
	{
		[Export("textureInternalFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSGLFormat)Messaging.int_objc_msgSend(base.Handle, selTextureInternalFormatHandle);
			}
			return (NSGLFormat)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTextureInternalFormatHandle);
		}
	}

	public virtual int TextureMaxMipMapLevel
	{
		[Export("textureMaxMipMapLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTextureMaxMipMapLevelHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTextureMaxMipMapLevelHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLPixelBuffer()
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
	public NSOpenGLPixelBuffer(NSCoder coder)
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
	public NSOpenGLPixelBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenGLPixelBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:")]
	public NSOpenGLPixelBuffer(NSGLTextureTarget targetGlEnum, NSGLFormat format, int maxLevel, int pixelsWide, int pixelsHigh)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int_int_int_int_int(base.Handle, selInitWithTextureTargetTextureInternalFormatTextureMaxMipMapLevelPixelsWidePixelsHigh_Handle, (int)targetGlEnum, (int)format, maxLevel, pixelsWide, pixelsHigh);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int_int_int_int_int(base.SuperHandle, selInitWithTextureTargetTextureInternalFormatTextureMaxMipMapLevelPixelsWidePixelsHigh_Handle, (int)targetGlEnum, (int)format, maxLevel, pixelsWide, pixelsHigh);
		}
	}
}
