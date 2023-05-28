using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionRemoteGoTo", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfActionRemoteGoTo : PdfAction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPageIndex_AtPoint_FileURL_ = "initWithPageIndex:atPoint:fileURL:";

	private static readonly IntPtr selInitWithPageIndex_AtPoint_FileURL_Handle = Selector.GetHandle("initWithPageIndex:atPoint:fileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageIndex = "pageIndex";

	private static readonly IntPtr selPageIndexHandle = Selector.GetHandle("pageIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPoint = "point";

	private static readonly IntPtr selPointHandle = Selector.GetHandle("point");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPageIndex_ = "setPageIndex:";

	private static readonly IntPtr selSetPageIndex_Handle = Selector.GetHandle("setPageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPoint_ = "setPoint:";

	private static readonly IntPtr selSetPoint_Handle = Selector.GetHandle("setPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ = "setURL:";

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFActionRemoteGoTo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PageIndex
	{
		[Export("pageIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPageIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPageIndexHandle);
		}
		[Export("setPageIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPageIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPageIndex_Handle, value);
			}
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
		[Export("setPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
		[Export("setURL:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfActionRemoteGoTo()
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
	protected PdfActionRemoteGoTo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfActionRemoteGoTo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPageIndex:atPoint:fileURL:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfActionRemoteGoTo(nint pageIndex, CGPoint point, NSUrl fileUrl)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint_CGPoint_IntPtr(base.Handle, selInitWithPageIndex_AtPoint_FileURL_Handle, pageIndex, point, fileUrl.Handle), "initWithPageIndex:atPoint:fileURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint_CGPoint_IntPtr(base.SuperHandle, selInitWithPageIndex_AtPoint_FileURL_Handle, pageIndex, point, fileUrl.Handle), "initWithPageIndex:atPoint:fileURL:");
		}
	}
}
