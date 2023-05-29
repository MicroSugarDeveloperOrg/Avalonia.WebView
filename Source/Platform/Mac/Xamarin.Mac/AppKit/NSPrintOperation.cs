using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPrintOperation", true)]
public class NSPrintOperation : NSObject
{
	private static readonly IntPtr selIsCopyingOperationHandle = Selector.GetHandle("isCopyingOperation");

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	private static readonly IntPtr selPageRangeHandle = Selector.GetHandle("pageRange");

	private static readonly IntPtr selCurrentPageHandle = Selector.GetHandle("currentPage");

	private static readonly IntPtr selCurrentOperationHandle = Selector.GetHandle("currentOperation");

	private static readonly IntPtr selSetCurrentOperation_Handle = Selector.GetHandle("setCurrentOperation:");

	private static readonly IntPtr selJobTitleHandle = Selector.GetHandle("jobTitle");

	private static readonly IntPtr selSetJobTitle_Handle = Selector.GetHandle("setJobTitle:");

	private static readonly IntPtr selShowsPrintPanelHandle = Selector.GetHandle("showsPrintPanel");

	private static readonly IntPtr selSetShowsPrintPanel_Handle = Selector.GetHandle("setShowsPrintPanel:");

	private static readonly IntPtr selShowsProgressPanelHandle = Selector.GetHandle("showsProgressPanel");

	private static readonly IntPtr selSetShowsProgressPanel_Handle = Selector.GetHandle("setShowsProgressPanel:");

	private static readonly IntPtr selPrintPanelHandle = Selector.GetHandle("printPanel");

	private static readonly IntPtr selSetPrintPanel_Handle = Selector.GetHandle("setPrintPanel:");

	private static readonly IntPtr selCanSpawnSeparateThreadHandle = Selector.GetHandle("canSpawnSeparateThread");

	private static readonly IntPtr selSetCanSpawnSeparateThread_Handle = Selector.GetHandle("setCanSpawnSeparateThread:");

	private static readonly IntPtr selPageOrderHandle = Selector.GetHandle("pageOrder");

	private static readonly IntPtr selSetPageOrder_Handle = Selector.GetHandle("setPageOrder:");

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	private static readonly IntPtr selSetPrintInfo_Handle = Selector.GetHandle("setPrintInfo:");

	private static readonly IntPtr selPrintOperationWithViewPrintInfo_Handle = Selector.GetHandle("printOperationWithView:printInfo:");

	private static readonly IntPtr selPDFOperationWithViewInsideRectToDataPrintInfo_Handle = Selector.GetHandle("PDFOperationWithView:insideRect:toData:printInfo:");

	private static readonly IntPtr selPDFOperationWithViewInsideRectToPathPrintInfo_Handle = Selector.GetHandle("PDFOperationWithView:insideRect:toPath:printInfo:");

	private static readonly IntPtr selEPSOperationWithViewInsideRectToDataPrintInfo_Handle = Selector.GetHandle("EPSOperationWithView:insideRect:toData:printInfo:");

	private static readonly IntPtr selEPSOperationWithViewInsideRectToPathPrintInfo_Handle = Selector.GetHandle("EPSOperationWithView:insideRect:toPath:printInfo:");

	private static readonly IntPtr selPrintOperationWithView_Handle = Selector.GetHandle("printOperationWithView:");

	private static readonly IntPtr selPDFOperationWithViewInsideRectToData_Handle = Selector.GetHandle("PDFOperationWithView:insideRect:toData:");

	private static readonly IntPtr selEPSOperationWithViewInsideRectToData_Handle = Selector.GetHandle("EPSOperationWithView:insideRect:toData:");

	private static readonly IntPtr selRunOperationModalForWindowDelegateDidRunSelectorContextInfo_Handle = Selector.GetHandle("runOperationModalForWindow:delegate:didRunSelector:contextInfo:");

	private static readonly IntPtr selRunOperationHandle = Selector.GetHandle("runOperation");

	private static readonly IntPtr selCreateContextHandle = Selector.GetHandle("createContext");

	private static readonly IntPtr selDestroyContextHandle = Selector.GetHandle("destroyContext");

	private static readonly IntPtr selDeliverResultHandle = Selector.GetHandle("deliverResult");

	private static readonly IntPtr selCleanUpOperationHandle = Selector.GetHandle("cleanUpOperation");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPrintOperation");

	private object __mt_View_var;

	private object __mt_Context_var;

	private static object __mt_CurrentOperation_var_static;

	private object __mt_PrintPanel_var;

	private object __mt_PrintInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsCopyingOperation
	{
		[Export("isCopyingOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCopyingOperationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCopyingOperationHandle);
		}
	}

	public virtual NSView View
	{
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_View_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle)))));
		}
	}

	public virtual NSGraphicsContext Context
	{
		[Export("context")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSGraphicsContext)(__mt_Context_var = ((!IsDirectBinding) ? ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextHandle))) : ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContextHandle)))));
		}
	}

	public virtual NSRange PageRange
	{
		[Export("pageRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selPageRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selPageRangeHandle);
		}
	}

	public virtual long CurrentPage
	{
		[Export("currentPage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selCurrentPageHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCurrentPageHandle);
		}
	}

	public static NSPrintOperation CurrentOperation
	{
		[Export("currentOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintOperation)(__mt_CurrentOperation_var_static = (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentOperationHandle)));
		}
		[Export("setCurrentOperation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCurrentOperation_Handle, value.Handle);
		}
	}

	public virtual string JobTitle
	{
		[Export("jobTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selJobTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJobTitleHandle));
		}
		[Export("setJobTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetJobTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetJobTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool ShowsPrintPanel
	{
		[Export("showsPrintPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsPrintPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsPrintPanelHandle);
		}
		[Export("setShowsPrintPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsPrintPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsPrintPanel_Handle, value);
			}
		}
	}

	public virtual bool ShowsProgressPanel
	{
		[Export("showsProgressPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsProgressPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsProgressPanelHandle);
		}
		[Export("setShowsProgressPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsProgressPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsProgressPanel_Handle, value);
			}
		}
	}

	public virtual NSPrintPanel PrintPanel
	{
		[Export("printPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintPanel)(__mt_PrintPanel_var = ((!IsDirectBinding) ? ((NSPrintPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintPanelHandle))) : ((NSPrintPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintPanelHandle)))));
		}
		[Export("setPrintPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrintPanel_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrintPanel_Handle, value.Handle);
			}
			__mt_PrintPanel_var = value;
		}
	}

	public virtual bool CanSpawnSeparateThread
	{
		[Export("canSpawnSeparateThread")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanSpawnSeparateThreadHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSpawnSeparateThreadHandle);
		}
		[Export("setCanSpawnSeparateThread:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanSpawnSeparateThread_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanSpawnSeparateThread_Handle, value);
			}
		}
	}

	public virtual NSPrintingPageOrder PageOrder
	{
		[Export("pageOrder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPrintingPageOrder)Messaging.Int64_objc_msgSend(base.Handle, selPageOrderHandle);
			}
			return (NSPrintingPageOrder)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPageOrderHandle);
		}
		[Export("setPageOrder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPageOrder_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPageOrder_Handle, (long)value);
			}
		}
	}

	public virtual NSPrintInfo PrintInfo
	{
		[Export("printInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintInfo)(__mt_PrintInfo_var = ((!IsDirectBinding) ? ((NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintInfoHandle))) : ((NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintInfoHandle)))));
		}
		[Export("setPrintInfo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrintInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrintInfo_Handle, value.Handle);
			}
			__mt_PrintInfo_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrintOperation()
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
	public NSPrintOperation(NSCoder coder)
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
	public NSPrintOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPrintOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("printOperationWithView:printInfo:")]
	public static NSPrintOperation FromView(NSView view, NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPrintOperationWithViewPrintInfo_Handle, view.Handle, printInfo.Handle));
	}

	[Export("PDFOperationWithView:insideRect:toData:printInfo:")]
	public static NSPrintOperation PdfFromView(NSView view, CGRect rect, NSMutableData data, NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selPDFOperationWithViewInsideRectToDataPrintInfo_Handle, view.Handle, rect, data.Handle, printInfo.Handle));
	}

	[Export("PDFOperationWithView:insideRect:toPath:printInfo:")]
	public static NSPrintOperation PdfFromView(NSView view, CGRect rect, string path, NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSPrintOperation result = (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selPDFOperationWithViewInsideRectToPathPrintInfo_Handle, view.Handle, rect, arg, printInfo.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("EPSOperationWithView:insideRect:toData:printInfo:")]
	public static NSPrintOperation EpsFromView(NSView view, CGRect rect, NSMutableData data, NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selEPSOperationWithViewInsideRectToDataPrintInfo_Handle, view.Handle, rect, data.Handle, printInfo.Handle));
	}

	[Export("EPSOperationWithView:insideRect:toPath:printInfo:")]
	public static NSPrintOperation EpsFromView(NSView view, CGRect rect, string path, NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSPrintOperation result = (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selEPSOperationWithViewInsideRectToPathPrintInfo_Handle, view.Handle, rect, arg, printInfo.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("printOperationWithView:")]
	public static NSPrintOperation FromView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPrintOperationWithView_Handle, view.Handle));
	}

	[Export("PDFOperationWithView:insideRect:toData:")]
	public static NSPrintOperation PdfFromView(NSView view, CGRect rect, NSMutableData data)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr(class_ptr, selPDFOperationWithViewInsideRectToData_Handle, view.Handle, rect, data.Handle));
	}

	[Export("EPSOperationWithView:insideRect:toData:")]
	public static NSPrintOperation EpsFromView(NSView view, CGRect rect, NSMutableData data)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr(class_ptr, selEPSOperationWithViewInsideRectToData_Handle, view.Handle, rect, data.Handle));
	}

	[Export("runOperationModalForWindow:delegate:didRunSelector:contextInfo:")]
	public virtual void RunOperationModal(NSWindow docWindow, NSObject del, Selector didRunSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (docWindow == null)
		{
			throw new ArgumentNullException("docWindow");
		}
		if (del == null)
		{
			throw new ArgumentNullException("del");
		}
		if (didRunSelector == null)
		{
			throw new ArgumentNullException("didRunSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRunOperationModalForWindowDelegateDidRunSelectorContextInfo_Handle, docWindow.Handle, del.Handle, didRunSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunOperationModalForWindowDelegateDidRunSelectorContextInfo_Handle, docWindow.Handle, del.Handle, didRunSelector.Handle, contextInfo);
		}
	}

	[Export("runOperation")]
	public virtual bool RunOperation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRunOperationHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRunOperationHandle);
	}

	[Export("createContext")]
	public virtual NSGraphicsContext CreateContext()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateContextHandle));
		}
		return (NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateContextHandle));
	}

	[Export("destroyContext")]
	public virtual void DestroyContext()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDestroyContextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDestroyContextHandle);
		}
	}

	[Export("deliverResult")]
	public virtual bool DeliverResult()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDeliverResultHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeliverResultHandle);
	}

	[Export("cleanUpOperation")]
	public virtual void CleanUpOperation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCleanUpOperationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCleanUpOperationHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_View_var = null;
			__mt_Context_var = null;
			__mt_PrintPanel_var = null;
			__mt_PrintInfo_var = null;
		}
	}
}
