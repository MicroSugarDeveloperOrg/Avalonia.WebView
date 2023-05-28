using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSemanticSegmentationMatte", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class AVSemanticSegmentationMatte : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryRepresentationForAuxiliaryDataType_ = "dictionaryRepresentationForAuxiliaryDataType:";

	private static readonly IntPtr selDictionaryRepresentationForAuxiliaryDataType_Handle = Selector.GetHandle("dictionaryRepresentationForAuxiliaryDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatteType = "matteType";

	private static readonly IntPtr selMatteTypeHandle = Selector.GetHandle("matteType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMattingImage = "mattingImage";

	private static readonly IntPtr selMattingImageHandle = Selector.GetHandle("mattingImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormatType = "pixelFormatType";

	private static readonly IntPtr selPixelFormatTypeHandle = Selector.GetHandle("pixelFormatType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemanticSegmentationMatteByApplyingExifOrientation_ = "semanticSegmentationMatteByApplyingExifOrientation:";

	private static readonly IntPtr selSemanticSegmentationMatteByApplyingExifOrientation_Handle = Selector.GetHandle("semanticSegmentationMatteByApplyingExifOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_ = "semanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer:error:";

	private static readonly IntPtr selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_Handle = Selector.GetHandle("semanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemanticSegmentationMatteFromImageSourceAuxiliaryDataType_DictionaryRepresentation_Error_ = "semanticSegmentationMatteFromImageSourceAuxiliaryDataType:dictionaryRepresentation:error:";

	private static readonly IntPtr selSemanticSegmentationMatteFromImageSourceAuxiliaryDataType_DictionaryRepresentation_Error_Handle = Selector.GetHandle("semanticSegmentationMatteFromImageSourceAuxiliaryDataType:dictionaryRepresentation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSemanticSegmentationMatte");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[BindAs(typeof(AVSemanticSegmentationMatteType), OriginalType = typeof(NSString))]
	public virtual AVSemanticSegmentationMatteType MatteType
	{
		[Export("matteType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return AVSemanticSegmentationMatteTypeExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatteTypeHandle)));
			}
			return AVSemanticSegmentationMatteTypeExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatteTypeHandle)));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer MattingImage
	{
		[Export("mattingImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selMattingImageHandle), owns: false);
			}
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMattingImageHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelFormatType PixelFormatType
	{
		[Export("pixelFormatType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CVPixelFormatType)Messaging.UInt32_objc_msgSend(base.Handle, selPixelFormatTypeHandle);
			}
			return (CVPixelFormatType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selPixelFormatTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSemanticSegmentationMatte(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSemanticSegmentationMatte(IntPtr handle)
		: base(handle)
	{
	}

	[Export("semanticSegmentationMatteByApplyingExifOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSemanticSegmentationMatte ApplyExifOrientation(CGImagePropertyOrientation exifOrientation)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selSemanticSegmentationMatteByApplyingExifOrientation_Handle, (int)exifOrientation));
		}
		return Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selSemanticSegmentationMatteByApplyingExifOrientation_Handle, (int)exifOrientation));
	}

	[Export("semanticSegmentationMatteFromImageSourceAuxiliaryDataType:dictionaryRepresentation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVSemanticSegmentationMatte? Create(NSString imageSourceAuxiliaryDataType, NSDictionary imageSourceAuxiliaryDataInfoDictionary, out NSError outError)
	{
		if (imageSourceAuxiliaryDataType == null)
		{
			throw new ArgumentNullException("imageSourceAuxiliaryDataType");
		}
		if (imageSourceAuxiliaryDataInfoDictionary == null)
		{
			throw new ArgumentNullException("imageSourceAuxiliaryDataInfoDictionary");
		}
		IntPtr arg = IntPtr.Zero;
		AVSemanticSegmentationMatte nSObject = Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selSemanticSegmentationMatteFromImageSourceAuxiliaryDataType_DictionaryRepresentation_Error_Handle, imageSourceAuxiliaryDataType.Handle, imageSourceAuxiliaryDataInfoDictionary.Handle, ref arg));
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

	[Export("semanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSemanticSegmentationMatte? ReplaceSemanticSegmentationMatte(CVPixelBuffer pixelBuffer, out NSError outError)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		AVSemanticSegmentationMatte result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_Handle, pixelBuffer.Handle, ref arg)) : Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_Handle, pixelBuffer.Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
