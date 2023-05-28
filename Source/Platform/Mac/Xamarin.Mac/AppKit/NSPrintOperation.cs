using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSPrintOperation", true)]
public class NSPrintOperation : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEPSOperationWithView_InsideRect_ToData_ = "EPSOperationWithView:insideRect:toData:";

	private static readonly IntPtr selEPSOperationWithView_InsideRect_ToData_Handle = Selector.GetHandle("EPSOperationWithView:insideRect:toData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEPSOperationWithView_InsideRect_ToData_PrintInfo_ = "EPSOperationWithView:insideRect:toData:printInfo:";

	private static readonly IntPtr selEPSOperationWithView_InsideRect_ToData_PrintInfo_Handle = Selector.GetHandle("EPSOperationWithView:insideRect:toData:printInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEPSOperationWithView_InsideRect_ToPath_PrintInfo_ = "EPSOperationWithView:insideRect:toPath:printInfo:";

	private static readonly IntPtr selEPSOperationWithView_InsideRect_ToPath_PrintInfo_Handle = Selector.GetHandle("EPSOperationWithView:insideRect:toPath:printInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPDFOperationWithView_InsideRect_ToData_ = "PDFOperationWithView:insideRect:toData:";

	private static readonly IntPtr selPDFOperationWithView_InsideRect_ToData_Handle = Selector.GetHandle("PDFOperationWithView:insideRect:toData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPDFOperationWithView_InsideRect_ToData_PrintInfo_ = "PDFOperationWithView:insideRect:toData:printInfo:";

	private static readonly IntPtr selPDFOperationWithView_InsideRect_ToData_PrintInfo_Handle = Selector.GetHandle("PDFOperationWithView:insideRect:toData:printInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPDFOperationWithView_InsideRect_ToPath_PrintInfo_ = "PDFOperationWithView:insideRect:toPath:printInfo:";

	private static readonly IntPtr selPDFOperationWithView_InsideRect_ToPath_PrintInfo_Handle = Selector.GetHandle("PDFOperationWithView:insideRect:toPath:printInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanSpawnSeparateThread = "canSpawnSeparateThread";

	private static readonly IntPtr selCanSpawnSeparateThreadHandle = Selector.GetHandle("canSpawnSeparateThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCleanUpOperation = "cleanUpOperation";

	private static readonly IntPtr selCleanUpOperationHandle = Selector.GetHandle("cleanUpOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContext = "context";

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateContext = "createContext";

	private static readonly IntPtr selCreateContextHandle = Selector.GetHandle("createContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentOperation = "currentOperation";

	private static readonly IntPtr selCurrentOperationHandle = Selector.GetHandle("currentOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPage = "currentPage";

	private static readonly IntPtr selCurrentPageHandle = Selector.GetHandle("currentPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeliverResult = "deliverResult";

	private static readonly IntPtr selDeliverResultHandle = Selector.GetHandle("deliverResult");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestroyContext = "destroyContext";

	private static readonly IntPtr selDestroyContextHandle = Selector.GetHandle("destroyContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCopyingOperation = "isCopyingOperation";

	private static readonly IntPtr selIsCopyingOperationHandle = Selector.GetHandle("isCopyingOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJobTitle = "jobTitle";

	private static readonly IntPtr selJobTitleHandle = Selector.GetHandle("jobTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageOrder = "pageOrder";

	private static readonly IntPtr selPageOrderHandle = Selector.GetHandle("pageOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageRange = "pageRange";

	private static readonly IntPtr selPageRangeHandle = Selector.GetHandle("pageRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredRenderingQuality = "preferredRenderingQuality";

	private static readonly IntPtr selPreferredRenderingQualityHandle = Selector.GetHandle("preferredRenderingQuality");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintInfo = "printInfo";

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintOperationWithView_ = "printOperationWithView:";

	private static readonly IntPtr selPrintOperationWithView_Handle = Selector.GetHandle("printOperationWithView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintOperationWithView_PrintInfo_ = "printOperationWithView:printInfo:";

	private static readonly IntPtr selPrintOperationWithView_PrintInfo_Handle = Selector.GetHandle("printOperationWithView:printInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintPanel = "printPanel";

	private static readonly IntPtr selPrintPanelHandle = Selector.GetHandle("printPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunOperation = "runOperation";

	private static readonly IntPtr selRunOperationHandle = Selector.GetHandle("runOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_ = "runOperationModalForWindow:delegate:didRunSelector:contextInfo:";

	private static readonly IntPtr selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_Handle = Selector.GetHandle("runOperationModalForWindow:delegate:didRunSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanSpawnSeparateThread_ = "setCanSpawnSeparateThread:";

	private static readonly IntPtr selSetCanSpawnSeparateThread_Handle = Selector.GetHandle("setCanSpawnSeparateThread:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentOperation_ = "setCurrentOperation:";

	private static readonly IntPtr selSetCurrentOperation_Handle = Selector.GetHandle("setCurrentOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJobTitle_ = "setJobTitle:";

	private static readonly IntPtr selSetJobTitle_Handle = Selector.GetHandle("setJobTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPageOrder_ = "setPageOrder:";

	private static readonly IntPtr selSetPageOrder_Handle = Selector.GetHandle("setPageOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrintInfo_ = "setPrintInfo:";

	private static readonly IntPtr selSetPrintInfo_Handle = Selector.GetHandle("setPrintInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrintPanel_ = "setPrintPanel:";

	private static readonly IntPtr selSetPrintPanel_Handle = Selector.GetHandle("setPrintPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsPrintPanel_ = "setShowsPrintPanel:";

	private static readonly IntPtr selSetShowsPrintPanel_Handle = Selector.GetHandle("setShowsPrintPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsProgressPanel_ = "setShowsProgressPanel:";

	private static readonly IntPtr selSetShowsProgressPanel_Handle = Selector.GetHandle("setShowsProgressPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsPrintPanel = "showsPrintPanel";

	private static readonly IntPtr selShowsPrintPanelHandle = Selector.GetHandle("showsPrintPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsProgressPanel = "showsProgressPanel";

	private static readonly IntPtr selShowsProgressPanelHandle = Selector.GetHandle("showsProgressPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPrintOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanSpawnSeparateThread
	{
		[Export("canSpawnSeparateThread")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanSpawnSeparateThreadHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSpawnSeparateThreadHandle);
		}
		[Export("setCanSpawnSeparateThread:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanSpawnSeparateThread_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanSpawnSeparateThread_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGraphicsContext Context
	{
		[Export("context")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selContextHandle));
			}
			return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrintOperation CurrentOperation
	{
		[Export("currentOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentOperationHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint CurrentPage
	{
		[Export("currentPage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCurrentPageHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCurrentPageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCopyingOperation
	{
		[Export("isCopyingOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCopyingOperationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCopyingOperationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string JobTitle
	{
		[Export("jobTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintingPageOrder PageOrder
	{
		[Export("pageOrder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPrintingPageOrder)Messaging.Int64_objc_msgSend(base.Handle, selPageOrderHandle);
			}
			return (NSPrintingPageOrder)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPageOrderHandle);
		}
		[Export("setPageOrder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPageOrder_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPageOrder_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange PageRange
	{
		[Export("pageRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selPageRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selPageRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintRenderingQuality PreferredRenderingQuality
	{
		[Export("preferredRenderingQuality")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPrintRenderingQuality)Messaging.Int64_objc_msgSend(base.Handle, selPreferredRenderingQualityHandle);
			}
			return (NSPrintRenderingQuality)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPreferredRenderingQualityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintInfo PrintInfo
	{
		[Export("printInfo", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintInfoHandle));
			}
			return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintInfoHandle));
		}
		[Export("setPrintInfo:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrintInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrintInfo_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintPanel PrintPanel
	{
		[Export("printPanel", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPrintPanel>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintPanelHandle));
			}
			return Runtime.GetNSObject<NSPrintPanel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintPanelHandle));
		}
		[Export("setPrintPanel:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrintPanel_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrintPanel_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsPrintPanel
	{
		[Export("showsPrintPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsPrintPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsPrintPanelHandle);
		}
		[Export("setShowsPrintPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsPrintPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsPrintPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsProgressPanel
	{
		[Export("showsProgressPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsProgressPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsProgressPanelHandle);
		}
		[Export("setShowsProgressPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsProgressPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsProgressPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView View
	{
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrintOperation()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSPrintOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPrintOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cleanUpOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CleanUpOperation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCleanUpOperationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCleanUpOperationHandle);
		}
	}

	[Export("createContext")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGraphicsContext CreateContext()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateContextHandle));
		}
		return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateContextHandle));
	}

	[Export("deliverResult")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeliverResult()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDeliverResultHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeliverResultHandle);
	}

	[Export("destroyContext")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DestroyContext()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDestroyContextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDestroyContextHandle);
		}
	}

	[Export("EPSOperationWithView:insideRect:toData:printInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selEPSOperationWithView_InsideRect_ToData_PrintInfo_Handle, view.Handle, rect, data.Handle, printInfo.Handle));
	}

	[Export("EPSOperationWithView:insideRect:toPath:printInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSPrintOperation nSObject = Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selEPSOperationWithView_InsideRect_ToPath_PrintInfo_Handle, view.Handle, rect, arg, printInfo.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("EPSOperationWithView:insideRect:toData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr(class_ptr, selEPSOperationWithView_InsideRect_ToData_Handle, view.Handle, rect, data.Handle));
	}

	[Export("printOperationWithView:printInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPrintOperationWithView_PrintInfo_Handle, view.Handle, printInfo.Handle));
	}

	[Export("printOperationWithView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrintOperation FromView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPrintOperationWithView_Handle, view.Handle));
	}

	[Export("PDFOperationWithView:insideRect:toData:printInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selPDFOperationWithView_InsideRect_ToData_PrintInfo_Handle, view.Handle, rect, data.Handle, printInfo.Handle));
	}

	[Export("PDFOperationWithView:insideRect:toPath:printInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSPrintOperation nSObject = Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selPDFOperationWithView_InsideRect_ToPath_PrintInfo_Handle, view.Handle, rect, arg, printInfo.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("PDFOperationWithView:insideRect:toData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr(class_ptr, selPDFOperationWithView_InsideRect_ToData_Handle, view.Handle, rect, data.Handle));
	}

	[Export("runOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RunOperation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRunOperationHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRunOperationHandle);
	}

	[Export("runOperationModalForWindow:delegate:didRunSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_Handle, docWindow.Handle, del.Handle, didRunSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_Handle, docWindow.Handle, del.Handle, didRunSelector.Handle, contextInfo);
		}
	}
}
