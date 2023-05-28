using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using PrintCore;

namespace AppKit;

[Register("NSPrintInfo", true)]
public class NSPrintInfo : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPMPageFormat = "PMPageFormat";

	private static readonly IntPtr selPMPageFormatHandle = Selector.GetHandle("PMPageFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPMPrintSession = "PMPrintSession";

	private static readonly IntPtr selPMPrintSessionHandle = Selector.GetHandle("PMPrintSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPMPrintSettings = "PMPrintSettings";

	private static readonly IntPtr selPMPrintSettingsHandle = Selector.GetHandle("PMPrintSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottomMargin = "bottomMargin";

	private static readonly IntPtr selBottomMarginHandle = Selector.GetHandle("bottomMargin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultPrinter = "defaultPrinter";

	private static readonly IntPtr selDefaultPrinterHandle = Selector.GetHandle("defaultPrinter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionary = "dictionary";

	private static readonly IntPtr selDictionaryHandle = Selector.GetHandle("dictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalPagination = "horizontalPagination";

	private static readonly IntPtr selHorizontalPaginationHandle = Selector.GetHandle("horizontalPagination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageablePageBounds = "imageablePageBounds";

	private static readonly IntPtr selImageablePageBoundsHandle = Selector.GetHandle("imageablePageBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDictionary_ = "initWithDictionary:";

	private static readonly IntPtr selInitWithDictionary_Handle = Selector.GetHandle("initWithDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHorizontallyCentered = "isHorizontallyCentered";

	private static readonly IntPtr selIsHorizontallyCenteredHandle = Selector.GetHandle("isHorizontallyCentered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectionOnly = "isSelectionOnly";

	private static readonly IntPtr selIsSelectionOnlyHandle = Selector.GetHandle("isSelectionOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVerticallyCentered = "isVerticallyCentered";

	private static readonly IntPtr selIsVerticallyCenteredHandle = Selector.GetHandle("isVerticallyCentered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJobDisposition = "jobDisposition";

	private static readonly IntPtr selJobDispositionHandle = Selector.GetHandle("jobDisposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftMargin = "leftMargin";

	private static readonly IntPtr selLeftMarginHandle = Selector.GetHandle("leftMargin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedPaperName = "localizedPaperName";

	private static readonly IntPtr selLocalizedPaperNameHandle = Selector.GetHandle("localizedPaperName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientation = "orientation";

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaperName = "paperName";

	private static readonly IntPtr selPaperNameHandle = Selector.GetHandle("paperName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaperSize = "paperSize";

	private static readonly IntPtr selPaperSizeHandle = Selector.GetHandle("paperSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintSettings = "printSettings";

	private static readonly IntPtr selPrintSettingsHandle = Selector.GetHandle("printSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrinter = "printer";

	private static readonly IntPtr selPrinterHandle = Selector.GetHandle("printer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMargin = "rightMargin";

	private static readonly IntPtr selRightMarginHandle = Selector.GetHandle("rightMargin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScalingFactor = "scalingFactor";

	private static readonly IntPtr selScalingFactorHandle = Selector.GetHandle("scalingFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBottomMargin_ = "setBottomMargin:";

	private static readonly IntPtr selSetBottomMargin_Handle = Selector.GetHandle("setBottomMargin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalPagination_ = "setHorizontalPagination:";

	private static readonly IntPtr selSetHorizontalPagination_Handle = Selector.GetHandle("setHorizontalPagination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontallyCentered_ = "setHorizontallyCentered:";

	private static readonly IntPtr selSetHorizontallyCentered_Handle = Selector.GetHandle("setHorizontallyCentered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJobDisposition_ = "setJobDisposition:";

	private static readonly IntPtr selSetJobDisposition_Handle = Selector.GetHandle("setJobDisposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeftMargin_ = "setLeftMargin:";

	private static readonly IntPtr selSetLeftMargin_Handle = Selector.GetHandle("setLeftMargin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientation_ = "setOrientation:";

	private static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle("setOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaperName_ = "setPaperName:";

	private static readonly IntPtr selSetPaperName_Handle = Selector.GetHandle("setPaperName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaperSize_ = "setPaperSize:";

	private static readonly IntPtr selSetPaperSize_Handle = Selector.GetHandle("setPaperSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrinter_ = "setPrinter:";

	private static readonly IntPtr selSetPrinter_Handle = Selector.GetHandle("setPrinter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRightMargin_ = "setRightMargin:";

	private static readonly IntPtr selSetRightMargin_Handle = Selector.GetHandle("setRightMargin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScalingFactor_ = "setScalingFactor:";

	private static readonly IntPtr selSetScalingFactor_Handle = Selector.GetHandle("setScalingFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionOnly_ = "setSelectionOnly:";

	private static readonly IntPtr selSetSelectionOnly_Handle = Selector.GetHandle("setSelectionOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSharedPrintInfo_ = "setSharedPrintInfo:";

	private static readonly IntPtr selSetSharedPrintInfo_Handle = Selector.GetHandle("setSharedPrintInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTopMargin_ = "setTopMargin:";

	private static readonly IntPtr selSetTopMargin_Handle = Selector.GetHandle("setTopMargin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpPrintOperationDefaultValues = "setUpPrintOperationDefaultValues";

	private static readonly IntPtr selSetUpPrintOperationDefaultValuesHandle = Selector.GetHandle("setUpPrintOperationDefaultValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalPagination_ = "setVerticalPagination:";

	private static readonly IntPtr selSetVerticalPagination_Handle = Selector.GetHandle("setVerticalPagination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticallyCentered_ = "setVerticallyCentered:";

	private static readonly IntPtr selSetVerticallyCentered_Handle = Selector.GetHandle("setVerticallyCentered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedPrintInfo = "sharedPrintInfo";

	private static readonly IntPtr selSharedPrintInfoHandle = Selector.GetHandle("sharedPrintInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopMargin = "topMargin";

	private static readonly IntPtr selTopMarginHandle = Selector.GetHandle("topMargin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateFromPMPageFormat = "updateFromPMPageFormat";

	private static readonly IntPtr selUpdateFromPMPageFormatHandle = Selector.GetHandle("updateFromPMPageFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateFromPMPrintSettings = "updateFromPMPrintSettings";

	private static readonly IntPtr selUpdateFromPMPrintSettingsHandle = Selector.GetHandle("updateFromPMPrintSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalPagination = "verticalPagination";

	private static readonly IntPtr selVerticalPaginationHandle = Selector.GetHandle("verticalPagination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPrintInfo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BottomMargin
	{
		[Export("bottomMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBottomMarginHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBottomMarginHandle);
		}
		[Export("setBottomMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetBottomMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetBottomMargin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrinter DefaultPrinter
	{
		[Export("defaultPrinter")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSPrinter>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultPrinterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary Dictionary
	{
		[Export("dictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintingPaginationMode HorizontalPagination
	{
		[Export("horizontalPagination")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSend(base.Handle, selHorizontalPaginationHandle);
			}
			return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHorizontalPaginationHandle);
		}
		[Export("setHorizontalPagination:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetHorizontalPagination_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetHorizontalPagination_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HorizontallyCentered
	{
		[Export("isHorizontallyCentered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontallyCenteredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontallyCenteredHandle);
		}
		[Export("setHorizontallyCentered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontallyCentered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontallyCentered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ImageablePageBounds
	{
		[Export("imageablePageBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string JobDisposition
	{
		[Export("jobDisposition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LeftMargin
	{
		[Export("leftMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLeftMarginHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLeftMarginHandle);
		}
		[Export("setLeftMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLeftMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLeftMargin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedPaperName
	{
		[Export("localizedPaperName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedPaperNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedPaperNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintingOrientation Orientation
	{
		[Export("orientation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPrintingOrientation)Messaging.UInt64_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (NSPrintingOrientation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
		[Export("setOrientation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOrientation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PaperName
	{
		[Export("paperName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize PaperSize
	{
		[Export("paperSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPaperSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPaperSizeHandle);
		}
		[Export("setPaperSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetPaperSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetPaperSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary PrintSettings
	{
		[Export("printSettings")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintSettingsHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrinter Printer
	{
		[Export("printer", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPrinter>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrinterHandle));
			}
			return Runtime.GetNSObject<NSPrinter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrinterHandle));
		}
		[Export("setPrinter:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrinter_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrinter_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RightMargin
	{
		[Export("rightMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRightMarginHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRightMarginHandle);
		}
		[Export("setRightMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRightMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRightMargin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ScalingFactor
	{
		[Export("scalingFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScalingFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScalingFactorHandle);
		}
		[Export("setScalingFactor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetScalingFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetScalingFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectionOnly
	{
		[Export("isSelectionOnly")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectionOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectionOnlyHandle);
		}
		[Export("setSelectionOnly:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectionOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectionOnly_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrintInfo SharedPrintInfo
	{
		[Export("sharedPrintInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedPrintInfoHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TopMargin
	{
		[Export("topMargin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTopMarginHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTopMarginHandle);
		}
		[Export("setTopMargin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTopMargin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTopMargin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintingPaginationMode VerticalPagination
	{
		[Export("verticalPagination")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSend(base.Handle, selVerticalPaginationHandle);
			}
			return (NSPrintingPaginationMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVerticalPaginationHandle);
		}
		[Export("setVerticalPagination:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetVerticalPagination_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetVerticalPagination_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool VerticallyCentered
	{
		[Export("isVerticallyCentered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticallyCenteredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticallyCenteredHandle);
		}
		[Export("setVerticallyCentered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticallyCentered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticallyCentered_Handle, value);
			}
		}
	}

	public PMPrintSession GetPrintSession()
	{
		IntPtr pMPrintSession = GetPMPrintSession();
		return new PMPrintSession(pMPrintSession, owns: false);
	}

	public PMPageFormat GetPageFormat()
	{
		IntPtr pMPageFormat = GetPMPageFormat();
		return new PMPageFormat(pMPageFormat, owns: false);
	}

	public PMPrintSettings GetPrintSettings()
	{
		IntPtr pMPrintSettings = GetPMPrintSettings();
		return new PMPrintSettings(pMPrintSettings, owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrintInfo()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPrintInfo(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSPrintInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPrintInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDictionary:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPrintInfo(NSDictionary attributes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDictionary_Handle, attributes.Handle), "initWithDictionary:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDictionary_Handle, attributes.Handle), "initWithDictionary:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("PMPageFormat")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GetPMPageFormat()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selPMPageFormatHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMPageFormatHandle);
	}

	[Export("PMPrintSession")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GetPMPrintSession()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selPMPrintSessionHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMPrintSessionHandle);
	}

	[Export("PMPrintSettings")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GetPMPrintSettings()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selPMPrintSettingsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMPrintSettingsHandle);
	}

	[Export("setUpPrintOperationDefaultValues")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetUpPrintOperationDefaultValues()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetUpPrintOperationDefaultValuesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetUpPrintOperationDefaultValuesHandle);
		}
	}

	[Export("updateFromPMPageFormat")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateFromPMPageFormat()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateFromPMPageFormatHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateFromPMPageFormatHandle);
		}
	}

	[Export("updateFromPMPrintSettings")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateFromPMPrintSettings()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateFromPMPrintSettingsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateFromPMPrintSettingsHandle);
		}
	}
}
