using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSGraphicsContext", true)]
public class NSGraphicsContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGContext = "CGContext";

	private static readonly IntPtr selCGContextHandle = Selector.GetHandle("CGContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCIContext = "CIContext";

	private static readonly IntPtr selCIContextHandle = Selector.GetHandle("CIContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorRenderingIntent = "colorRenderingIntent";

	private static readonly IntPtr selColorRenderingIntentHandle = Selector.GetHandle("colorRenderingIntent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositingOperation = "compositingOperation";

	private static readonly IntPtr selCompositingOperationHandle = Selector.GetHandle("compositingOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentContext = "currentContext";

	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentContextDrawingToScreen = "currentContextDrawingToScreen";

	private static readonly IntPtr selCurrentContextDrawingToScreenHandle = Selector.GetHandle("currentContextDrawingToScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushGraphics = "flushGraphics";

	private static readonly IntPtr selFlushGraphicsHandle = Selector.GetHandle("flushGraphics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsContextWithAttributes_ = "graphicsContextWithAttributes:";

	private static readonly IntPtr selGraphicsContextWithAttributes_Handle = Selector.GetHandle("graphicsContextWithAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsContextWithBitmapImageRep_ = "graphicsContextWithBitmapImageRep:";

	private static readonly IntPtr selGraphicsContextWithBitmapImageRep_Handle = Selector.GetHandle("graphicsContextWithBitmapImageRep:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsContextWithCGContext_Flipped_ = "graphicsContextWithCGContext:flipped:";

	private static readonly IntPtr selGraphicsContextWithCGContext_Flipped_Handle = Selector.GetHandle("graphicsContextWithCGContext:flipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsContextWithGraphicsPort_Flipped_ = "graphicsContextWithGraphicsPort:flipped:";

	private static readonly IntPtr selGraphicsContextWithGraphicsPort_Flipped_Handle = Selector.GetHandle("graphicsContextWithGraphicsPort:flipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsContextWithWindow_ = "graphicsContextWithWindow:";

	private static readonly IntPtr selGraphicsContextWithWindow_Handle = Selector.GetHandle("graphicsContextWithWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphicsPort = "graphicsPort";

	private static readonly IntPtr selGraphicsPortHandle = Selector.GetHandle("graphicsPort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageInterpolation = "imageInterpolation";

	private static readonly IntPtr selImageInterpolationHandle = Selector.GetHandle("imageInterpolation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDrawingToScreen = "isDrawingToScreen";

	private static readonly IntPtr selIsDrawingToScreenHandle = Selector.GetHandle("isDrawingToScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlipped = "isFlipped";

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPatternPhase = "patternPhase";

	private static readonly IntPtr selPatternPhaseHandle = Selector.GetHandle("patternPhase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreGraphicsState = "restoreGraphicsState";

	private static readonly IntPtr selRestoreGraphicsStateHandle = Selector.GetHandle("restoreGraphicsState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveGraphicsState = "saveGraphicsState";

	private static readonly IntPtr selSaveGraphicsStateHandle = Selector.GetHandle("saveGraphicsState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorRenderingIntent_ = "setColorRenderingIntent:";

	private static readonly IntPtr selSetColorRenderingIntent_Handle = Selector.GetHandle("setColorRenderingIntent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompositingOperation_ = "setCompositingOperation:";

	private static readonly IntPtr selSetCompositingOperation_Handle = Selector.GetHandle("setCompositingOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentContext_ = "setCurrentContext:";

	private static readonly IntPtr selSetCurrentContext_Handle = Selector.GetHandle("setCurrentContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGraphicsState_ = "setGraphicsState:";

	private static readonly IntPtr selSetGraphicsState_Handle = Selector.GetHandle("setGraphicsState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageInterpolation_ = "setImageInterpolation:";

	private static readonly IntPtr selSetImageInterpolation_Handle = Selector.GetHandle("setImageInterpolation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPatternPhase_ = "setPatternPhase:";

	private static readonly IntPtr selSetPatternPhase_Handle = Selector.GetHandle("setPatternPhase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldAntialias_ = "setShouldAntialias:";

	private static readonly IntPtr selSetShouldAntialias_Handle = Selector.GetHandle("setShouldAntialias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldAntialias = "shouldAntialias";

	private static readonly IntPtr selShouldAntialiasHandle = Selector.GetHandle("shouldAntialias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGraphicsContext");

	public virtual CGContext GraphicsPort => new CGContext(GraphicsPortHandle);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Attributes
	{
		[Export("attributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGContext CGContext
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("CGContext")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGContextHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGContextHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGContext(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIContext CIContext
	{
		[Export("CIContext")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selCIContextHandle));
			}
			return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCIContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorRenderingIntent ColorRenderingIntent
	{
		[Export("colorRenderingIntent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSColorRenderingIntent)Messaging.Int64_objc_msgSend(base.Handle, selColorRenderingIntentHandle);
			}
			return (NSColorRenderingIntent)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selColorRenderingIntentHandle);
		}
		[Export("setColorRenderingIntent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetColorRenderingIntent_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetColorRenderingIntent_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComposite CompositingOperation
	{
		[Export("compositingOperation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSComposite)Messaging.UInt64_objc_msgSend(base.Handle, selCompositingOperationHandle);
			}
			return (NSComposite)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCompositingOperationHandle);
		}
		[Export("setCompositingOperation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCompositingOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCompositingOperation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGraphicsContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'CGContext' instead.")]
	public virtual IntPtr GraphicsPortHandle
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'CGContext' instead.")]
		[Export("graphicsPort")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selGraphicsPortHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGraphicsPortHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageInterpolation ImageInterpolation
	{
		[Export("imageInterpolation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSImageInterpolation)Messaging.UInt64_objc_msgSend(base.Handle, selImageInterpolationHandle);
			}
			return (NSImageInterpolation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageInterpolationHandle);
		}
		[Export("setImageInterpolation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageInterpolation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageInterpolation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsCurrentContextDrawingToScreen
	{
		[Export("currentContextDrawingToScreen")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selCurrentContextDrawingToScreenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDrawingToScreen
	{
		[Export("isDrawingToScreen")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDrawingToScreenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDrawingToScreenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFlipped
	{
		[Export("isFlipped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint PatternPhase
	{
		[Export("patternPhase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPatternPhaseHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPatternPhaseHandle);
		}
		[Export("setPatternPhase:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPatternPhase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPatternPhase_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldAntialias
	{
		[Export("shouldAntialias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldAntialiasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldAntialiasHandle);
		}
		[Export("setShouldAntialias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldAntialias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldAntialias_Handle, value);
			}
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGraphicsContext()
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
	protected NSGraphicsContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGraphicsContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("flushGraphics")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlushGraphics()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushGraphicsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushGraphicsHandle);
		}
	}

	[Export("graphicsContextWithAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGraphicsContext FromAttributes(NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphicsContextWithAttributes_Handle, attributes.Handle));
	}

	[Export("graphicsContextWithBitmapImageRep:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGraphicsContext FromBitmap(NSBitmapImageRep bitmapRep)
	{
		if (bitmapRep == null)
		{
			throw new ArgumentNullException("bitmapRep");
		}
		return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphicsContextWithBitmapImageRep_Handle, bitmapRep.Handle));
	}

	[Export("graphicsContextWithCGContext:flipped:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGraphicsContext FromCGContext(CGContext graphicsPort, bool initialFlippedState)
	{
		if (graphicsPort == null)
		{
			throw new ArgumentNullException("graphicsPort");
		}
		return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selGraphicsContextWithCGContext_Flipped_Handle, graphicsPort.Handle, initialFlippedState));
	}

	[Export("graphicsContextWithGraphicsPort:flipped:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FromCGContext' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGraphicsContext FromGraphicsPort(IntPtr graphicsPort, bool initialFlippedState)
	{
		return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selGraphicsContextWithGraphicsPort_Flipped_Handle, graphicsPort, initialFlippedState));
	}

	[Export("graphicsContextWithWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGraphicsContext FromWindow(NSWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphicsContextWithWindow_Handle, window.Handle));
	}

	[Export("restoreGraphicsState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void GlobalRestoreGraphicsState()
	{
		Messaging.void_objc_msgSend(class_ptr, selRestoreGraphicsStateHandle);
	}

	[Export("saveGraphicsState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void GlobalSaveGraphicsState()
	{
		Messaging.void_objc_msgSend(class_ptr, selSaveGraphicsStateHandle);
	}

	[Export("restoreGraphicsState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreGraphicsState()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRestoreGraphicsStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRestoreGraphicsStateHandle);
		}
	}

	[Export("saveGraphicsState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveGraphicsState()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSaveGraphicsStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSaveGraphicsStateHandle);
		}
	}

	[Export("setGraphicsState:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "This method has no effect.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetGraphicsState(nint gState)
	{
		Messaging.void_objc_msgSend_nint(class_ptr, selSetGraphicsState_Handle, gState);
	}
}
