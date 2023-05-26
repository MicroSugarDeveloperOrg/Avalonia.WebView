using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGraphicsContext", true)]
public class NSGraphicsContext : NSObject
{
	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	private static readonly IntPtr selSetCurrentContext_Handle = Selector.GetHandle("setCurrentContext:");

	private static readonly IntPtr selCurrentContextDrawingToScreenHandle = Selector.GetHandle("currentContextDrawingToScreen");

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	private static readonly IntPtr selIsDrawingToScreenHandle = Selector.GetHandle("isDrawingToScreen");

	private static readonly IntPtr selGraphicsPortHandle = Selector.GetHandle("graphicsPort");

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	private static readonly IntPtr selShouldAntialiasHandle = Selector.GetHandle("shouldAntialias");

	private static readonly IntPtr selSetShouldAntialias_Handle = Selector.GetHandle("setShouldAntialias:");

	private static readonly IntPtr selImageInterpolationHandle = Selector.GetHandle("imageInterpolation");

	private static readonly IntPtr selSetImageInterpolation_Handle = Selector.GetHandle("setImageInterpolation:");

	private static readonly IntPtr selPatternPhaseHandle = Selector.GetHandle("patternPhase");

	private static readonly IntPtr selSetPatternPhase_Handle = Selector.GetHandle("setPatternPhase:");

	private static readonly IntPtr selCompositingOperationHandle = Selector.GetHandle("compositingOperation");

	private static readonly IntPtr selSetCompositingOperation_Handle = Selector.GetHandle("setCompositingOperation:");

	private static readonly IntPtr selColorRenderingIntentHandle = Selector.GetHandle("colorRenderingIntent");

	private static readonly IntPtr selSetColorRenderingIntent_Handle = Selector.GetHandle("setColorRenderingIntent:");

	private static readonly IntPtr selCIContextHandle = Selector.GetHandle("CIContext");

	private static readonly IntPtr selGraphicsContextWithAttributes_Handle = Selector.GetHandle("graphicsContextWithAttributes:");

	private static readonly IntPtr selGraphicsContextWithWindow_Handle = Selector.GetHandle("graphicsContextWithWindow:");

	private static readonly IntPtr selGraphicsContextWithBitmapImageRep_Handle = Selector.GetHandle("graphicsContextWithBitmapImageRep:");

	private static readonly IntPtr selGraphicsContextWithGraphicsPortFlipped_Handle = Selector.GetHandle("graphicsContextWithGraphicsPort:flipped:");

	private static readonly IntPtr selSaveGraphicsStateHandle = Selector.GetHandle("saveGraphicsState");

	private static readonly IntPtr selRestoreGraphicsStateHandle = Selector.GetHandle("restoreGraphicsState");

	private static readonly IntPtr selSetGraphicsState_Handle = Selector.GetHandle("setGraphicsState:");

	private static readonly IntPtr selFlushGraphicsHandle = Selector.GetHandle("flushGraphics");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSGraphicsContext");

	private static object __mt_CurrentContext_var_static;

	private object __mt_Attributes_var;

	private object __mt_CIContext_var;

	public virtual CGContext GraphicsPort => new CGContext(GraphicsPortHandle);

	public override IntPtr ClassHandle => class_ptr;

	public static NSGraphicsContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			return (NSGraphicsContext)(__mt_CurrentContext_var_static = (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle)));
		}
		[Export("setCurrentContext:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCurrentContext_Handle, value.Handle);
		}
	}

	public static bool IsCurrentContextDrawingToScreen
	{
		[Export("currentContextDrawingToScreen")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selCurrentContextDrawingToScreenHandle);
		}
	}

	public virtual NSDictionary Attributes
	{
		[Export("attributes")]
		get
		{
			return (NSDictionary)(__mt_Attributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle)))));
		}
	}

	public virtual bool IsDrawingToScreen
	{
		[Export("isDrawingToScreen")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDrawingToScreenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDrawingToScreenHandle);
		}
	}

	public virtual IntPtr GraphicsPortHandle
	{
		[Export("graphicsPort")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selGraphicsPortHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGraphicsPortHandle);
		}
	}

	public virtual bool IsFlipped
	{
		[Export("isFlipped")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
	}

	public virtual bool ShouldAntialias
	{
		[Export("shouldAntialias")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldAntialiasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldAntialiasHandle);
		}
		[Export("setShouldAntialias:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldAntialias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldAntialias_Handle, value);
			}
		}
	}

	public virtual NSImageInterpolation ImageInterpolation
	{
		[Export("imageInterpolation")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSImageInterpolation)Messaging.UInt64_objc_msgSend(base.Handle, selImageInterpolationHandle);
			}
			return (NSImageInterpolation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageInterpolationHandle);
		}
		[Export("setImageInterpolation:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageInterpolation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageInterpolation_Handle, (ulong)value);
			}
		}
	}

	public virtual CGPoint PatternPhase
	{
		[Export("patternPhase")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPatternPhaseHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPatternPhaseHandle);
		}
		[Export("setPatternPhase:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPatternPhase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPatternPhase_Handle, value);
			}
		}
	}

	public virtual NSComposite CompositingOperation
	{
		[Export("compositingOperation")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSComposite)Messaging.UInt64_objc_msgSend(base.Handle, selCompositingOperationHandle);
			}
			return (NSComposite)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCompositingOperationHandle);
		}
		[Export("setCompositingOperation:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCompositingOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCompositingOperation_Handle, (ulong)value);
			}
		}
	}

	public virtual NSColorRenderingIntent ColorRenderingIntent
	{
		[Export("colorRenderingIntent")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSColorRenderingIntent)Messaging.Int64_objc_msgSend(base.Handle, selColorRenderingIntentHandle);
			}
			return (NSColorRenderingIntent)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selColorRenderingIntentHandle);
		}
		[Export("setColorRenderingIntent:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetColorRenderingIntent_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetColorRenderingIntent_Handle, (long)value);
			}
		}
	}

	public virtual CIContext CIContext
	{
		[Export("CIContext")]
		get
		{
			return (CIContext)(__mt_CIContext_var = ((!IsDirectBinding) ? ((CIContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCIContextHandle))) : ((CIContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCIContextHandle)))));
		}
	}

	public static NSGraphicsContext FromGraphicsPort(CGContext context, bool initialFlippedState)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return FromGraphicsPort(context.Handle, initialFlippedState);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGraphicsContext()
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
	public NSGraphicsContext(NSCoder coder)
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
	public NSGraphicsContext(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSGraphicsContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("graphicsContextWithAttributes:")]
	public static NSGraphicsContext FromAttributes(NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphicsContextWithAttributes_Handle, attributes.Handle));
	}

	[Export("graphicsContextWithWindow:")]
	public static NSGraphicsContext FromWindow(NSWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphicsContextWithWindow_Handle, window.Handle));
	}

	[Export("graphicsContextWithBitmapImageRep:")]
	public static NSGraphicsContext FromBitmap(NSBitmapImageRep bitmapRep)
	{
		if (bitmapRep == null)
		{
			throw new ArgumentNullException("bitmapRep");
		}
		return (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphicsContextWithBitmapImageRep_Handle, bitmapRep.Handle));
	}

	[Export("graphicsContextWithGraphicsPort:flipped:")]
	public static NSGraphicsContext FromGraphicsPort(IntPtr graphicsPort, bool initialFlippedState)
	{
		return (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selGraphicsContextWithGraphicsPortFlipped_Handle, graphicsPort, initialFlippedState));
	}

	[Export("saveGraphicsState")]
	public static void GlobalSaveGraphicsState()
	{
		Messaging.void_objc_msgSend(class_ptr, selSaveGraphicsStateHandle);
	}

	[Export("restoreGraphicsState")]
	public static void GlobalRestoreGraphicsState()
	{
		Messaging.void_objc_msgSend(class_ptr, selRestoreGraphicsStateHandle);
	}

	[Export("setGraphicsState:")]
	public static void SetGraphicsState(long gState)
	{
		Messaging.void_objc_msgSend_Int64(class_ptr, selSetGraphicsState_Handle, gState);
	}

	[Export("saveGraphicsState")]
	public virtual void SaveGraphicsState()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSaveGraphicsStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSaveGraphicsStateHandle);
		}
	}

	[Export("restoreGraphicsState")]
	public virtual void RestoreGraphicsState()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRestoreGraphicsStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRestoreGraphicsStateHandle);
		}
	}

	[Export("flushGraphics")]
	public virtual void FlushGraphics()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushGraphicsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushGraphicsHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Attributes_var = null;
			__mt_CIContext_var = null;
		}
	}
}
