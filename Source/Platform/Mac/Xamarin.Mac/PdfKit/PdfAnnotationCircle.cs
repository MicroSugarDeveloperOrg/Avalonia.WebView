using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationCircle", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
public class PdfAnnotationCircle : PdfAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteriorColor = "interiorColor";

	private static readonly IntPtr selInteriorColorHandle = Selector.GetHandle("interiorColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInteriorColor_ = "setInteriorColor:";

	private static readonly IntPtr selSetInteriorColor_Handle = Selector.GetHandle("setInteriorColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFAnnotationCircle");

	public override IntPtr ClassHandle => class_ptr;

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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationCircle()
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
	public PdfAnnotationCircle(NSCoder coder)
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
	protected PdfAnnotationCircle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfAnnotationCircle(IntPtr handle)
		: base(handle)
	{
	}
}
