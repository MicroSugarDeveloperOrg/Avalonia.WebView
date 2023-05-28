using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVDepthData", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class AVDepthData : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableDepthDataTypes = "availableDepthDataTypes";

	private static readonly IntPtr selAvailableDepthDataTypesHandle = Selector.GetHandle("availableDepthDataTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraCalibrationData = "cameraCalibrationData";

	private static readonly IntPtr selCameraCalibrationDataHandle = Selector.GetHandle("cameraCalibrationData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataAccuracy = "depthDataAccuracy";

	private static readonly IntPtr selDepthDataAccuracyHandle = Selector.GetHandle("depthDataAccuracy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataByApplyingExifOrientation_ = "depthDataByApplyingExifOrientation:";

	private static readonly IntPtr selDepthDataByApplyingExifOrientation_Handle = Selector.GetHandle("depthDataByApplyingExifOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataByConvertingToDepthDataType_ = "depthDataByConvertingToDepthDataType:";

	private static readonly IntPtr selDepthDataByConvertingToDepthDataType_Handle = Selector.GetHandle("depthDataByConvertingToDepthDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataByReplacingDepthDataMapWithPixelBuffer_Error_ = "depthDataByReplacingDepthDataMapWithPixelBuffer:error:";

	private static readonly IntPtr selDepthDataByReplacingDepthDataMapWithPixelBuffer_Error_Handle = Selector.GetHandle("depthDataByReplacingDepthDataMapWithPixelBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataFromDictionaryRepresentation_Error_ = "depthDataFromDictionaryRepresentation:error:";

	private static readonly IntPtr selDepthDataFromDictionaryRepresentation_Error_Handle = Selector.GetHandle("depthDataFromDictionaryRepresentation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataMap = "depthDataMap";

	private static readonly IntPtr selDepthDataMapHandle = Selector.GetHandle("depthDataMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataQuality = "depthDataQuality";

	private static readonly IntPtr selDepthDataQualityHandle = Selector.GetHandle("depthDataQuality");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthDataType = "depthDataType";

	private static readonly IntPtr selDepthDataTypeHandle = Selector.GetHandle("depthDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryRepresentationForAuxiliaryDataType_ = "dictionaryRepresentationForAuxiliaryDataType:";

	private static readonly IntPtr selDictionaryRepresentationForAuxiliaryDataType_Handle = Selector.GetHandle("dictionaryRepresentationForAuxiliaryDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDepthDataFiltered = "isDepthDataFiltered";

	private static readonly IntPtr selIsDepthDataFilteredHandle = Selector.GetHandle("isDepthDataFiltered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVDepthData");

	public CVPixelFormatType[] AvailableDepthDataTypes
	{
		get
		{
			NSNumber[] weakAvailableDepthDataTypes = WeakAvailableDepthDataTypes;
			if (weakAvailableDepthDataTypes == null)
			{
				return null;
			}
			int num = weakAvailableDepthDataTypes.Length;
			CVPixelFormatType[] array = new CVPixelFormatType[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (CVPixelFormatType)weakAvailableDepthDataTypes[i].UInt32Value;
			}
			return array;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCameraCalibrationData? CameraCalibrationData
	{
		[Export("cameraCalibrationData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCameraCalibrationData>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraCalibrationDataHandle));
			}
			return Runtime.GetNSObject<AVCameraCalibrationData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraCalibrationDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVDepthDataAccuracy DepthDataAccuracy
	{
		[Export("depthDataAccuracy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVDepthDataAccuracy)Messaging.Int64_objc_msgSend(base.Handle, selDepthDataAccuracyHandle);
			}
			return (AVDepthDataAccuracy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDepthDataAccuracyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer DepthDataMap
	{
		[Export("depthDataMap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selDepthDataMapHandle), owns: false);
			}
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDepthDataMapHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVDepthDataQuality DepthDataQuality
	{
		[Export("depthDataQuality")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVDepthDataQuality)Messaging.Int64_objc_msgSend(base.Handle, selDepthDataQualityHandle);
			}
			return (AVDepthDataQuality)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDepthDataQualityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelFormatType DepthDataType
	{
		[Export("depthDataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CVPixelFormatType)Messaging.UInt32_objc_msgSend(base.Handle, selDepthDataTypeHandle);
			}
			return (CVPixelFormatType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDepthDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDepthDataFiltered
	{
		[Export("isDepthDataFiltered")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDepthDataFilteredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDepthDataFilteredHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSNumber[] WeakAvailableDepthDataTypes
	{
		[Export("availableDepthDataTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableDepthDataTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableDepthDataTypesHandle));
		}
	}

	public static AVDepthData Create(CGImageAuxiliaryDataInfo dataInfo, out NSError error)
	{
		return Create(dataInfo.Dictionary, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVDepthData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVDepthData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("depthDataByApplyingExifOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVDepthData ApplyExifOrientation(CGImagePropertyOrientation exifOrientation)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selDepthDataByApplyingExifOrientation_Handle, (int)exifOrientation));
		}
		return Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selDepthDataByApplyingExifOrientation_Handle, (int)exifOrientation));
	}

	[Export("depthDataByConvertingToDepthDataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVDepthData ConvertToDepthDataType(CVPixelFormatType depthDataType)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selDepthDataByConvertingToDepthDataType_Handle, (uint)depthDataType));
		}
		return Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selDepthDataByConvertingToDepthDataType_Handle, (uint)depthDataType));
	}

	[Export("depthDataFromDictionaryRepresentation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVDepthData? Create(NSDictionary imageSourceAuxDataInfoDictionary, out NSError? outError)
	{
		if (imageSourceAuxDataInfoDictionary == null)
		{
			throw new ArgumentNullException("imageSourceAuxDataInfoDictionary");
		}
		IntPtr arg = IntPtr.Zero;
		AVDepthData nSObject = Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selDepthDataFromDictionaryRepresentation_Error_Handle, imageSourceAuxDataInfoDictionary.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("dictionaryRepresentationForAuxiliaryDataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? GetDictionaryRepresentation(out string? outAuxDataType)
	{
		IntPtr arg = IntPtr.Zero;
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selDictionaryRepresentationForAuxiliaryDataType_Handle, ref arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selDictionaryRepresentationForAuxiliaryDataType_Handle, ref arg)));
		outAuxDataType = NSString.FromHandle(arg);
		return result;
	}

	[Export("depthDataByReplacingDepthDataMapWithPixelBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVDepthData? ReplaceDepthDataMap(CVPixelBuffer pixelBuffer, out NSError? outError)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		AVDepthData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selDepthDataByReplacingDepthDataMapWithPixelBuffer_Error_Handle, pixelBuffer.Handle, ref arg)) : Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selDepthDataByReplacingDepthDataMapWithPixelBuffer_Error_Handle, pixelBuffer.Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
