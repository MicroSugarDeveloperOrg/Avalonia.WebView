using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageCaptureCore;

[Register("ICScannerFunctionalUnit", true)]
public abstract class ICScannerFunctionalUnit : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsThresholdForBlackAndWhiteScanning = "acceptsThresholdForBlackAndWhiteScanning";

	private static readonly IntPtr selAcceptsThresholdForBlackAndWhiteScanningHandle = Selector.GetHandle("acceptsThresholdForBlackAndWhiteScanning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitDepth = "bitDepth";

	private static readonly IntPtr selBitDepthHandle = Selector.GetHandle("bitDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformOverviewScan = "canPerformOverviewScan";

	private static readonly IntPtr selCanPerformOverviewScanHandle = Selector.GetHandle("canPerformOverviewScan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultThresholdForBlackAndWhiteScanning = "defaultThresholdForBlackAndWhiteScanning";

	private static readonly IntPtr selDefaultThresholdForBlackAndWhiteScanningHandle = Selector.GetHandle("defaultThresholdForBlackAndWhiteScanning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeasurementUnit = "measurementUnit";

	private static readonly IntPtr selMeasurementUnitHandle = Selector.GetHandle("measurementUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNativeXResolution = "nativeXResolution";

	private static readonly IntPtr selNativeXResolutionHandle = Selector.GetHandle("nativeXResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNativeYResolution = "nativeYResolution";

	private static readonly IntPtr selNativeYResolutionHandle = Selector.GetHandle("nativeYResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverviewImage = "overviewImage";

	private static readonly IntPtr selOverviewImageHandle = Selector.GetHandle("overviewImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverviewResolution = "overviewResolution";

	private static readonly IntPtr selOverviewResolutionHandle = Selector.GetHandle("overviewResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverviewScanInProgress = "overviewScanInProgress";

	private static readonly IntPtr selOverviewScanInProgressHandle = Selector.GetHandle("overviewScanInProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhysicalSize = "physicalSize";

	private static readonly IntPtr selPhysicalSizeHandle = Selector.GetHandle("physicalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelDataType = "pixelDataType";

	private static readonly IntPtr selPixelDataTypeHandle = Selector.GetHandle("pixelDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredResolutions = "preferredResolutions";

	private static readonly IntPtr selPreferredResolutionsHandle = Selector.GetHandle("preferredResolutions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredScaleFactors = "preferredScaleFactors";

	private static readonly IntPtr selPreferredScaleFactorsHandle = Selector.GetHandle("preferredScaleFactors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolution = "resolution";

	private static readonly IntPtr selResolutionHandle = Selector.GetHandle("resolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactor = "scaleFactor";

	private static readonly IntPtr selScaleFactorHandle = Selector.GetHandle("scaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanArea = "scanArea";

	private static readonly IntPtr selScanAreaHandle = Selector.GetHandle("scanArea");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanAreaOrientation = "scanAreaOrientation";

	private static readonly IntPtr selScanAreaOrientationHandle = Selector.GetHandle("scanAreaOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanInProgress = "scanInProgress";

	private static readonly IntPtr selScanInProgressHandle = Selector.GetHandle("scanInProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanProgressPercentDone = "scanProgressPercentDone";

	private static readonly IntPtr selScanProgressPercentDoneHandle = Selector.GetHandle("scanProgressPercentDone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBitDepth_ = "setBitDepth:";

	private static readonly IntPtr selSetBitDepth_Handle = Selector.GetHandle("setBitDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMeasurementUnit_ = "setMeasurementUnit:";

	private static readonly IntPtr selSetMeasurementUnit_Handle = Selector.GetHandle("setMeasurementUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverviewResolution_ = "setOverviewResolution:";

	private static readonly IntPtr selSetOverviewResolution_Handle = Selector.GetHandle("setOverviewResolution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelDataType_ = "setPixelDataType:";

	private static readonly IntPtr selSetPixelDataType_Handle = Selector.GetHandle("setPixelDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolution_ = "setResolution:";

	private static readonly IntPtr selSetResolution_Handle = Selector.GetHandle("setResolution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleFactor_ = "setScaleFactor:";

	private static readonly IntPtr selSetScaleFactor_Handle = Selector.GetHandle("setScaleFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScanArea_ = "setScanArea:";

	private static readonly IntPtr selSetScanArea_Handle = Selector.GetHandle("setScanArea:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScanAreaOrientation_ = "setScanAreaOrientation:";

	private static readonly IntPtr selSetScanAreaOrientation_Handle = Selector.GetHandle("setScanAreaOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetThresholdForBlackAndWhiteScanning_ = "setThresholdForBlackAndWhiteScanning:";

	private static readonly IntPtr selSetThresholdForBlackAndWhiteScanning_Handle = Selector.GetHandle("setThresholdForBlackAndWhiteScanning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesThresholdForBlackAndWhiteScanning_ = "setUsesThresholdForBlackAndWhiteScanning:";

	private static readonly IntPtr selSetUsesThresholdForBlackAndWhiteScanning_Handle = Selector.GetHandle("setUsesThresholdForBlackAndWhiteScanning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedBitDepths = "supportedBitDepths";

	private static readonly IntPtr selSupportedBitDepthsHandle = Selector.GetHandle("supportedBitDepths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedMeasurementUnits = "supportedMeasurementUnits";

	private static readonly IntPtr selSupportedMeasurementUnitsHandle = Selector.GetHandle("supportedMeasurementUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedResolutions = "supportedResolutions";

	private static readonly IntPtr selSupportedResolutionsHandle = Selector.GetHandle("supportedResolutions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedScaleFactors = "supportedScaleFactors";

	private static readonly IntPtr selSupportedScaleFactorsHandle = Selector.GetHandle("supportedScaleFactors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemplates = "templates";

	private static readonly IntPtr selTemplatesHandle = Selector.GetHandle("templates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThresholdForBlackAndWhiteScanning = "thresholdForBlackAndWhiteScanning";

	private static readonly IntPtr selThresholdForBlackAndWhiteScanningHandle = Selector.GetHandle("thresholdForBlackAndWhiteScanning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesThresholdForBlackAndWhiteScanning = "usesThresholdForBlackAndWhiteScanning";

	private static readonly IntPtr selUsesThresholdForBlackAndWhiteScanningHandle = Selector.GetHandle("usesThresholdForBlackAndWhiteScanning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVendorFeatures = "vendorFeatures";

	private static readonly IntPtr selVendorFeaturesHandle = Selector.GetHandle("vendorFeatures");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerFunctionalUnit");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptsThresholdForBlackAndWhiteScanning
	{
		[Export("acceptsThresholdForBlackAndWhiteScanning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsThresholdForBlackAndWhiteScanningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsThresholdForBlackAndWhiteScanningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerBitDepth BitDepth
	{
		[Export("bitDepth", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerBitDepth)Messaging.UInt64_objc_msgSend(base.Handle, selBitDepthHandle);
			}
			return (ICScannerBitDepth)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBitDepthHandle);
		}
		[Export("setBitDepth:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBitDepth_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBitDepth_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPerformOverviewScan
	{
		[Export("canPerformOverviewScan")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPerformOverviewScanHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPerformOverviewScanHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual byte DefaultThresholdForBlackAndWhiteScanning
	{
		[Export("defaultThresholdForBlackAndWhiteScanning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.byte_objc_msgSend(base.Handle, selDefaultThresholdForBlackAndWhiteScanningHandle);
			}
			return Messaging.byte_objc_msgSendSuper(base.SuperHandle, selDefaultThresholdForBlackAndWhiteScanningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerMeasurementUnit MeasurementUnit
	{
		[Export("measurementUnit", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerMeasurementUnit)Messaging.UInt64_objc_msgSend(base.Handle, selMeasurementUnitHandle);
			}
			return (ICScannerMeasurementUnit)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMeasurementUnitHandle);
		}
		[Export("setMeasurementUnit:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMeasurementUnit_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMeasurementUnit_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NativeXResolution
	{
		[Export("nativeXResolution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNativeXResolutionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNativeXResolutionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NativeYResolution
	{
		[Export("nativeYResolution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNativeYResolutionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNativeYResolutionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage? OverviewImage
	{
		[Export("overviewImage")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOverviewImageHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selOverviewImageHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint OverviewResolution
	{
		[Export("overviewResolution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selOverviewResolutionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selOverviewResolutionHandle);
		}
		[Export("setOverviewResolution:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetOverviewResolution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetOverviewResolution_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OverviewScanInProgress
	{
		[Export("overviewScanInProgress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selOverviewScanInProgressHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selOverviewScanInProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize PhysicalSize
	{
		[Export("physicalSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPhysicalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPhysicalSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerPixelDataType PixelDataType
	{
		[Export("pixelDataType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerPixelDataType)Messaging.UInt64_objc_msgSend(base.Handle, selPixelDataTypeHandle);
			}
			return (ICScannerPixelDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPixelDataTypeHandle);
		}
		[Export("setPixelDataType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPixelDataType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPixelDataType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet PreferredResolutions
	{
		[Export("preferredResolutions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredResolutionsHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredResolutionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet PreferredScaleFactors
	{
		[Export("preferredScaleFactors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredScaleFactorsHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredScaleFactorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Resolution
	{
		[Export("resolution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResolutionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResolutionHandle);
		}
		[Export("setResolution:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetResolution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetResolution_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ScaleFactor
	{
		[Export("scaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selScaleFactorHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selScaleFactorHandle);
		}
		[Export("setScaleFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetScaleFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ScanArea
	{
		[Export("scanArea", ArgumentSemantic.Assign)]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selScanAreaHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selScanAreaHandle);
			}
			return retval;
		}
		[Export("setScanArea:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetScanArea_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetScanArea_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICExifOrientationType ScanAreaOrientation
	{
		[Export("scanAreaOrientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICExifOrientationType)Messaging.UInt64_objc_msgSend(base.Handle, selScanAreaOrientationHandle);
			}
			return (ICExifOrientationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selScanAreaOrientationHandle);
		}
		[Export("setScanAreaOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetScanAreaOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetScanAreaOrientation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ScanInProgress
	{
		[Export("scanInProgress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selScanInProgressHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selScanInProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ScanProgressPercentDone
	{
		[Export("scanProgressPercentDone")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScanProgressPercentDoneHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScanProgressPercentDoneHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerFunctionalUnitState State
	{
		[Export("state")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerFunctionalUnitState)Messaging.UInt32_objc_msgSend(base.Handle, selStateHandle);
			}
			return (ICScannerFunctionalUnitState)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SupportedBitDepths
	{
		[Export("supportedBitDepths")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedBitDepthsHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedBitDepthsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SupportedMeasurementUnits
	{
		[Export("supportedMeasurementUnits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedMeasurementUnitsHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedMeasurementUnitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SupportedResolutions
	{
		[Export("supportedResolutions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedResolutionsHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedResolutionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SupportedScaleFactors
	{
		[Export("supportedScaleFactors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedScaleFactorsHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedScaleFactorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerFeatureTemplate[] Templates
	{
		[Export("templates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ICScannerFeatureTemplate>(Messaging.IntPtr_objc_msgSend(base.Handle, selTemplatesHandle));
			}
			return NSArray.ArrayFromHandle<ICScannerFeatureTemplate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTemplatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual byte ThresholdForBlackAndWhiteScanning
	{
		[Export("thresholdForBlackAndWhiteScanning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.byte_objc_msgSend(base.Handle, selThresholdForBlackAndWhiteScanningHandle);
			}
			return Messaging.byte_objc_msgSendSuper(base.SuperHandle, selThresholdForBlackAndWhiteScanningHandle);
		}
		[Export("setThresholdForBlackAndWhiteScanning:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_byte(base.Handle, selSetThresholdForBlackAndWhiteScanning_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_byte(base.SuperHandle, selSetThresholdForBlackAndWhiteScanning_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerFunctionalUnitType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerFunctionalUnitType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (ICScannerFunctionalUnitType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesThresholdForBlackAndWhiteScanning
	{
		[Export("usesThresholdForBlackAndWhiteScanning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesThresholdForBlackAndWhiteScanningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesThresholdForBlackAndWhiteScanningHandle);
		}
		[Export("setUsesThresholdForBlackAndWhiteScanning:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesThresholdForBlackAndWhiteScanning_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesThresholdForBlackAndWhiteScanning_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerFeature[]? VendorFeatures
	{
		[Export("vendorFeatures")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ICScannerFeature>(Messaging.IntPtr_objc_msgSend(base.Handle, selVendorFeaturesHandle));
			}
			return NSArray.ArrayFromHandle<ICScannerFeature>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVendorFeaturesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerFunctionalUnit(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerFunctionalUnit(IntPtr handle)
		: base(handle)
	{
	}
}
