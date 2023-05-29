using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPrintInfo", true)]
public class NSPrintInfo : NSObject
{
	private static readonly IntPtr selDictionaryHandle = Selector.GetHandle("dictionary");

	private static readonly IntPtr selImageablePageBoundsHandle = Selector.GetHandle("imageablePageBounds");

	private static readonly IntPtr selLocalizedPaperNameHandle = Selector.GetHandle("localizedPaperName");

	private static readonly IntPtr selDefaultPrinterHandle = Selector.GetHandle("defaultPrinter");

	private static readonly IntPtr selPrintSettingsHandle = Selector.GetHandle("printSettings");

	private static readonly IntPtr selSharedPrintInfoHandle = Selector.GetHandle("sharedPrintInfo");

	private static readonly IntPtr selSetSharedPrintInfo_Handle = Selector.GetHandle("setSharedPrintInfo:");

	private static readonly IntPtr selPaperNameHandle = Selector.GetHandle("paperName");

	private static readonly IntPtr selSetPaperName_Handle = Selector.GetHandle("setPaperName:");

	private static readonly IntPtr selPaperSizeHandle = Selector.GetHandle("paperSize");

	private static readonly IntPtr selSetPaperSize_Handle = Selector.GetHandle("setPaperSize:");

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	private static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle("setOrientation:");

	private static readonly IntPtr selScalingFactorHandle = Selector.GetHandle("scalingFactor");

	private static readonly IntPtr selSetScalingFactor_Handle = Selector.GetHandle("setScalingFactor:");

	private static readonly IntPtr selLeftMarginHandle = Selector.GetHandle("leftMargin");

	private static readonly IntPtr selSetLeftMargin_Handle = Selector.GetHandle("setLeftMargin:");

	private static readonly IntPtr selRightMarginHandle = Selector.GetHandle("rightMargin");

	private static readonly IntPtr selSetRightMargin_Handle = Selector.GetHandle("setRightMargin:");

	private static readonly IntPtr selTopMarginHandle = Selector.GetHandle("topMargin");

	private static readonly IntPtr selSetTopMargin_Handle = Selector.GetHandle("setTopMargin:");

	private static readonly IntPtr selBottomMarginHandle = Selector.GetHandle("bottomMargin");

	private static readonly IntPtr selSetBottomMargin_Handle = Selector.GetHandle("setBottomMargin:");

	private static readonly IntPtr selIsHorizontallyCenteredHandle = Selector.GetHandle("isHorizontallyCentered");

	private static readonly IntPtr selSetHorizontallyCentered_Handle = Selector.GetHandle("setHorizontallyCentered:");

	private static readonly IntPtr selIsVerticallyCenteredHandle = Selector.GetHandle("isVerticallyCentered");

	private static readonly IntPtr selSetVerticallyCentered_Handle = Selector.GetHandle("setVerticallyCentered:");

	private static readonly IntPtr selHorizontalPaginationHandle = Selector.GetHandle("horizontalPagination");

	private static readonly IntPtr selSetHorizontalPagination_Handle = Selector.GetHandle("setHorizontalPagination:");

	private static readonly IntPtr selVerticalPaginationHandle = Selector.GetHandle("verticalPagination");

	private static readonly IntPtr selSetVerticalPagination_Handle = Selector.GetHandle("setVerticalPagination:");

	private static readonly IntPtr selJobDispositionHandle = Selector.GetHandle("jobDisposition");

	private static readonly IntPtr selSetJobDisposition_Handle = Selector.GetHandle("setJobDisposition:");

	private static readonly IntPtr selPrinterHandle = Selector.GetHandle("printer");

	private static readonly IntPtr selSetPrinter_Handle = Selector.GetHandle("setPrinter:");

	private static readonly IntPtr selIsSelectionOnlyHandle = Selector.GetHandle("isSelectionOnly");

	private static readonly IntPtr selSetSelectionOnly_Handle = Selector.GetHandle("setSelectionOnly:");

	private static readonly IntPtr selInitWithDictionary_Handle = Selector.GetHandle("initWithDictionary:");

	private static readonly IntPtr selSetUpPrintOperationDefaultValuesHandle = Selector.GetHandle("setUpPrintOperationDefaultValues");

	private static readonly IntPtr selPMPrintSessionHandle = Selector.GetHandle("PMPrintSession");

	private static readonly IntPtr selPMPageFormatHandle = Selector.GetHandle("PMPageFormat");

	private static readonly IntPtr selPMPrintSettingsHandle = Selector.GetHandle("PMPrintSettings");

	private static readonly IntPtr selUpdateFromPMPageFormatHandle = Selector.GetHandle("updateFromPMPageFormat");

	private static readonly IntPtr selUpdateFromPMPrintSettingsHandle = Selector.GetHandle("updateFromPMPrintSettings");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPrintInfo");

	private object __mt_Dictionary_var;

	private static object __mt_DefaultPrinter_var_static;

	private object __mt_PrintSettings_var;

	private static object __mt_SharedPrintInfo_var_static;

	private object __mt_Printer_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSMutableDictionary Dictionary
	{
		[Export("dictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMutableDictionary)(__mt_Dictionary_var = ((!IsDirectBinding) ? ((NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryHandle))) : ((NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryHandle)))));
		}
	}

	public virtual CGRect ImageablePageBounds
	{
		[Export("imageablePageBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selImageablePageBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selImageablePageBoundsHandle);
			}
			return retval;
		}
	}

	public virtual string LocalizedPaperName
	{
		[Export("localizedPaperName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedPaperNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedPaperNameHandle));
		}
	}

	public static NSPrinter DefaultPrinter
	{
		[Export("defaultPrinter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrinter)(__mt_DefaultPrinter_var_static = (NSPrinter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultPrinterHandle)));
		}
	}

	public virtual NSMutableDictionary PrintSettings
	{
		[Export("printSettings")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMutableDictionary)(__mt_PrintSettings_var = ((!IsDirectBinding) ? ((NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintSettingsHandle))) : ((NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintSettingsHandle)))));
		}
	}

	public static NSPrintInfo SharedPrintInfo
	{
		[Export("sharedPrintInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintInfo)(__mt_SharedPrintInfo_var_static = (NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedPrintInfoHandle)));
		}
		[Export("setSharedPrintInfo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetSharedPrintInfo_Handle, value.Handle);
		}
	}

	public virtual string PaperName
	{
		[Export("paperName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPaperNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaperNameHandle));
		}
		[Export("setPaperName:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPaperName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPaperName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual CGSize PaperSize
	{
		[Export("paperSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPaperSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPaperSizeHandle);
		}
		[Export("setPaperSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetPaperSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetPaperSize_Handle, value);
			}
		}
	}

	public virtual NSPrintingOrientation Orientation
	{
		[Export("orientation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPrintingOrientation)Messaging.UInt64_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (NSPrintingOrientation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
		[Export("setOrientation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOrientation_Handle, (ulong)value);
			}
		}
	}

	public virtual double ScalingFactor
	{
		[Export("scalingFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScalingFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScalingFactorHandle);
		}
		[Export("setScalingFactor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetScalingFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetScalingFactor_Handle, value);
			}
		}
	}

	public virtual double LeftMargin
	{
		[Export("leftMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLeftMarginHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLeftMarginHandle);
		}
		[Export("setLeftMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLeftMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLeftMargin_Handle, value);
			}
		}
	}

	public virtual double RightMargin
	{
		[Export("rightMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRightMarginHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRightMarginHandle);
		}
		[Export("setRightMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRightMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRightMargin_Handle, value);
			}
		}
	}

	public virtual double TopMargin
	{
		[Export("topMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTopMarginHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTopMarginHandle);
		}
		[Export("setTopMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTopMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTopMargin_Handle, value);
			}
		}
	}

	public virtual double BottomMargin
	{
		[Export("bottomMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBottomMarginHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBottomMarginHandle);
		}
		[Export("setBottomMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBottomMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBottomMargin_Handle, value);
			}
		}
	}

	public virtual bool HorizontallyCentered
	{
		[Export("isHorizontallyCentered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontallyCenteredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontallyCenteredHandle);
		}
		[Export("setHorizontallyCentered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontallyCentered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontallyCentered_Handle, value);
			}
		}
	}

	public virtual bool VerticallyCentered
	{
		[Export("isVerticallyCentered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticallyCenteredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticallyCenteredHandle);
		}
		[Export("setVerticallyCentered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticallyCentered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticallyCentered_Handle, value);
			}
		}
	}

	public virtual NSPrintingPaginationMode HorizontalPagination
	{
		[Export("horizontalPagination")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSend(base.Handle, selHorizontalPaginationHandle);
			}
			return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHorizontalPaginationHandle);
		}
		[Export("setHorizontalPagination:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetHorizontalPagination_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetHorizontalPagination_Handle, (ulong)value);
			}
		}
	}

	public virtual NSPrintingPaginationMode VerticalPagination
	{
		[Export("verticalPagination")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSend(base.Handle, selVerticalPaginationHandle);
			}
			return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVerticalPaginationHandle);
		}
		[Export("setVerticalPagination:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetVerticalPagination_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetVerticalPagination_Handle, (ulong)value);
			}
		}
	}

	public virtual string JobDisposition
	{
		[Export("jobDisposition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selJobDispositionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJobDispositionHandle));
		}
		[Export("setJobDisposition:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetJobDisposition_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetJobDisposition_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSPrinter Printer
	{
		[Export("printer")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrinter)(__mt_Printer_var = ((!IsDirectBinding) ? ((NSPrinter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrinterHandle))) : ((NSPrinter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrinterHandle)))));
		}
		[Export("setPrinter:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrinter_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrinter_Handle, value.Handle);
			}
			__mt_Printer_var = value;
		}
	}

	public virtual bool SelectionOnly
	{
		[Export("isSelectionOnly")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectionOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectionOnlyHandle);
		}
		[Export("setSelectionOnly:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectionOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectionOnly_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrintInfo()
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
	public NSPrintInfo(NSCoder coder)
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
	public NSPrintInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPrintInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDictionary:")]
	public NSPrintInfo(NSDictionary attributes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDictionary_Handle, attributes.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDictionary_Handle, attributes.Handle);
		}
	}

	[Export("setUpPrintOperationDefaultValues")]
	public virtual void SetUpPrintOperationDefaultValues()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetUpPrintOperationDefaultValuesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetUpPrintOperationDefaultValuesHandle);
		}
	}

	[Export("PMPrintSession")]
	public virtual IntPtr GetPMPrintSession()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selPMPrintSessionHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMPrintSessionHandle);
	}

	[Export("PMPageFormat")]
	public virtual IntPtr GetPMPageFormat()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selPMPageFormatHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMPageFormatHandle);
	}

	[Export("PMPrintSettings")]
	public virtual IntPtr GetPMPrintSettings()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selPMPrintSettingsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMPrintSettingsHandle);
	}

	[Export("updateFromPMPageFormat")]
	public virtual void UpdateFromPMPageFormat()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateFromPMPageFormatHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateFromPMPageFormatHandle);
		}
	}

	[Export("updateFromPMPrintSettings")]
	public virtual void UpdateFromPMPrintSettings()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateFromPMPrintSettingsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateFromPMPrintSettingsHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Dictionary_var = null;
			__mt_PrintSettings_var = null;
			__mt_Printer_var = null;
		}
	}
}
