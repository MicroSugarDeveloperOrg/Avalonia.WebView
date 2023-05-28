using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationLine", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
public class PdfAnnotationLine : PdfAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndLineStyle = "endLineStyle";

	private static readonly IntPtr selEndLineStyleHandle = Selector.GetHandle("endLineStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndPoint = "endPoint";

	private static readonly IntPtr selEndPointHandle = Selector.GetHandle("endPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteriorColor = "interiorColor";

	private static readonly IntPtr selInteriorColorHandle = Selector.GetHandle("interiorColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndLineStyle_ = "setEndLineStyle:";

	private static readonly IntPtr selSetEndLineStyle_Handle = Selector.GetHandle("setEndLineStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndPoint_ = "setEndPoint:";

	private static readonly IntPtr selSetEndPoint_Handle = Selector.GetHandle("setEndPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInteriorColor_ = "setInteriorColor:";

	private static readonly IntPtr selSetInteriorColor_Handle = Selector.GetHandle("setInteriorColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartLineStyle_ = "setStartLineStyle:";

	private static readonly IntPtr selSetStartLineStyle_Handle = Selector.GetHandle("setStartLineStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartPoint_ = "setStartPoint:";

	private static readonly IntPtr selSetStartPoint_Handle = Selector.GetHandle("setStartPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartLineStyle = "startLineStyle";

	private static readonly IntPtr selStartLineStyleHandle = Selector.GetHandle("startLineStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartPoint = "startPoint";

	private static readonly IntPtr selStartPointHandle = Selector.GetHandle("startPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFAnnotationLine");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual PdfLineStyle EndLineStyle
	{
		[Export("endLineStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfLineStyle)Messaging.Int64_objc_msgSend(base.Handle, selEndLineStyleHandle);
			}
			return (PdfLineStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEndLineStyleHandle);
		}
		[Export("setEndLineStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetEndLineStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetEndLineStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGPoint EndPoint
	{
		[Export("endPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selEndPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selEndPointHandle);
		}
		[Export("setEndPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetEndPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetEndPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSColor InteriorColor
	{
		[Export("interiorColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selInteriorColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInteriorColorHandle));
		}
		[Export("setInteriorColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInteriorColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInteriorColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual PdfLineStyle StartLineStyle
	{
		[Export("startLineStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfLineStyle)Messaging.Int64_objc_msgSend(base.Handle, selStartLineStyleHandle);
			}
			return (PdfLineStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStartLineStyleHandle);
		}
		[Export("setStartLineStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetStartLineStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetStartLineStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGPoint StartPoint
	{
		[Export("startPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selStartPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selStartPointHandle);
		}
		[Export("setStartPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetStartPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetStartPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationLine()
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
	public PdfAnnotationLine(NSCoder coder)
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
	protected PdfAnnotationLine(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfAnnotationLine(IntPtr handle)
		: base(handle)
	{
	}
}
