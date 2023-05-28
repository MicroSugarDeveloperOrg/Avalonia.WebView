using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebFrameView", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebFrameView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsScrolling = "allowsScrolling";

	private static readonly IntPtr selAllowsScrollingHandle = Selector.GetHandle("allowsScrolling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPrintHeadersAndFooters = "canPrintHeadersAndFooters";

	private static readonly IntPtr selCanPrintHeadersAndFootersHandle = Selector.GetHandle("canPrintHeadersAndFooters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentView = "documentView";

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentViewShouldHandlePrint = "documentViewShouldHandlePrint";

	private static readonly IntPtr selDocumentViewShouldHandlePrintHandle = Selector.GetHandle("documentViewShouldHandlePrint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintDocumentView = "printDocumentView";

	private static readonly IntPtr selPrintDocumentViewHandle = Selector.GetHandle("printDocumentView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintOperationWithPrintInfo_ = "printOperationWithPrintInfo:";

	private static readonly IntPtr selPrintOperationWithPrintInfo_Handle = Selector.GetHandle("printOperationWithPrintInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsScrolling_ = "setAllowsScrolling:";

	private static readonly IntPtr selSetAllowsScrolling_Handle = Selector.GetHandle("setAllowsScrolling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebFrame = "webFrame";

	private static readonly IntPtr selWebFrameHandle = Selector.GetHandle("webFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebFrameView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsScrolling
	{
		[Export("allowsScrolling")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsScrollingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsScrollingHandle);
		}
		[Export("setAllowsScrolling:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsScrolling_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsScrolling_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPrintHeadersAndFooters
	{
		[Export("canPrintHeadersAndFooters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPrintHeadersAndFootersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPrintHeadersAndFootersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView DocumentView
	{
		[Export("documentView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DocumentViewShouldHandlePrint
	{
		[Export("documentViewShouldHandlePrint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDocumentViewShouldHandlePrintHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDocumentViewShouldHandlePrintHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame WebFrame
	{
		[Export("webFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selWebFrameHandle));
			}
			return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebFrameView()
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
	public WebFrameView(NSCoder coder)
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
	protected WebFrameView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebFrameView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WebFrameView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("printOperationWithPrintInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintOperation GetPrintOperation(NSPrintInfo printInfo)
	{
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPrintOperationWithPrintInfo_Handle, printInfo.Handle));
		}
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrintOperationWithPrintInfo_Handle, printInfo.Handle));
	}

	[Export("printDocumentView")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrintDocumentView()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrintDocumentViewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrintDocumentViewHandle);
		}
	}
}
