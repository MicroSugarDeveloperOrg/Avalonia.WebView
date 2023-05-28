using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFDestination", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfDestination : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompare_ = "compare:";

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPage_AtPoint_ = "initWithPage:atPoint:";

	private static readonly IntPtr selInitWithPage_AtPoint_Handle = Selector.GetHandle("initWithPage:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPage = "page";

	private static readonly IntPtr selPageHandle = Selector.GetHandle("page");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPoint = "point";

	private static readonly IntPtr selPointHandle = Selector.GetHandle("point");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoom_ = "setZoom:";

	private static readonly IntPtr selSetZoom_Handle = Selector.GetHandle("setZoom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoom = "zoom";

	private static readonly IntPtr selZoomHandle = Selector.GetHandle("zoom");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFDestination");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfPage Page
	{
		[Export("page")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selPageHandle));
			}
			return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint Point
	{
		[Export("point")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPointHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Zoom
	{
		[Export("zoom")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selZoomHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selZoomHandle);
		}
		[Export("setZoom:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetZoom_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetZoom_Handle, value);
			}
		}
	}

	[Field("kPDFDestinationUnspecifiedValue", "PdfKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static nfloat UnspecifiedValue
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetNFloat(Libraries.PdfKit.Handle, "kPDFDestinationUnspecifiedValue");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfDestination()
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
	protected PdfDestination(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfDestination(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPage:atPoint:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfDestination(PdfPage page, CGPoint point)
		: base(NSObjectFlag.Empty)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint(base.Handle, selInitWithPage_AtPoint_Handle, page.Handle, point), "initWithPage:atPoint:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selInitWithPage_AtPoint_Handle, page.Handle, point), "initWithPage:atPoint:");
		}
	}

	[Export("compare:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult Compare(PdfDestination destination)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (base.IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, destination.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, destination.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
