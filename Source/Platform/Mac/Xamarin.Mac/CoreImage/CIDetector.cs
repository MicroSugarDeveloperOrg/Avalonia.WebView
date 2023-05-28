using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIDetector", true)]
public class CIDetector : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetectorOfType_Context_Options_ = "detectorOfType:context:options:";

	private static readonly IntPtr selDetectorOfType_Context_Options_Handle = Selector.GetHandle("detectorOfType:context:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeaturesInImage_ = "featuresInImage:";

	private static readonly IntPtr selFeaturesInImage_Handle = Selector.GetHandle("featuresInImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeaturesInImage_Options_ = "featuresInImage:options:";

	private static readonly IntPtr selFeaturesInImage_Options_Handle = Selector.GetHandle("featuresInImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIDetector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Accuracy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AccuracyHigh;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AccuracyLow;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AspectRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EyeBlink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocalLength;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageOrientation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxFeatureCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinFeatureSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NumberOfAngles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReturnSubFeatures;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Smile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Tracking;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeFace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeQRCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeRectangle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeText;

	public override IntPtr ClassHandle => class_ptr;

	[Field("CIDetectorAccuracy", "CoreImage")]
	internal static NSString Accuracy
	{
		get
		{
			if (_Accuracy == null)
			{
				_Accuracy = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorAccuracy");
			}
			return _Accuracy;
		}
	}

	[Field("CIDetectorAccuracyHigh", "CoreImage")]
	internal static NSString AccuracyHigh
	{
		get
		{
			if (_AccuracyHigh == null)
			{
				_AccuracyHigh = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorAccuracyHigh");
			}
			return _AccuracyHigh;
		}
	}

	[Field("CIDetectorAccuracyLow", "CoreImage")]
	internal static NSString AccuracyLow
	{
		get
		{
			if (_AccuracyLow == null)
			{
				_AccuracyLow = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorAccuracyLow");
			}
			return _AccuracyLow;
		}
	}

	[Field("CIDetectorAspectRatio", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString AspectRatio
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AspectRatio == null)
			{
				_AspectRatio = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorAspectRatio");
			}
			return _AspectRatio;
		}
	}

	[Field("CIDetectorEyeBlink", "CoreImage")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString EyeBlink
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_EyeBlink == null)
			{
				_EyeBlink = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorEyeBlink");
			}
			return _EyeBlink;
		}
	}

	[Field("CIDetectorFocalLength", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString FocalLength
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_FocalLength == null)
			{
				_FocalLength = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorFocalLength");
			}
			return _FocalLength;
		}
	}

	[Field("CIDetectorImageOrientation", "CoreImage")]
	internal static NSString ImageOrientation
	{
		get
		{
			if (_ImageOrientation == null)
			{
				_ImageOrientation = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorImageOrientation");
			}
			return _ImageOrientation;
		}
	}

	[Field("CIDetectorMaxFeatureCount", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	internal static NSString MaxFeatureCount
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MaxFeatureCount == null)
			{
				_MaxFeatureCount = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorMaxFeatureCount");
			}
			return _MaxFeatureCount;
		}
	}

	[Field("CIDetectorMinFeatureSize", "CoreImage")]
	internal static NSString MinFeatureSize
	{
		get
		{
			if (_MinFeatureSize == null)
			{
				_MinFeatureSize = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorMinFeatureSize");
			}
			return _MinFeatureSize;
		}
	}

	[Field("CIDetectorNumberOfAngles", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString NumberOfAngles
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_NumberOfAngles == null)
			{
				_NumberOfAngles = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorNumberOfAngles");
			}
			return _NumberOfAngles;
		}
	}

	[Field("CIDetectorReturnSubFeatures", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ReturnSubFeatures
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ReturnSubFeatures == null)
			{
				_ReturnSubFeatures = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorReturnSubFeatures");
			}
			return _ReturnSubFeatures;
		}
	}

	[Field("CIDetectorSmile", "CoreImage")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString Smile
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_Smile == null)
			{
				_Smile = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorSmile");
			}
			return _Smile;
		}
	}

	[Field("CIDetectorTracking", "CoreImage")]
	internal static NSString Tracking
	{
		get
		{
			if (_Tracking == null)
			{
				_Tracking = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorTracking");
			}
			return _Tracking;
		}
	}

	[Field("CIDetectorTypeFace", "CoreImage")]
	internal static NSString TypeFace
	{
		get
		{
			if (_TypeFace == null)
			{
				_TypeFace = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorTypeFace");
			}
			return _TypeFace;
		}
	}

	[Field("CIDetectorTypeQRCode", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString TypeQRCode
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeQRCode == null)
			{
				_TypeQRCode = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorTypeQRCode");
			}
			return _TypeQRCode;
		}
	}

	[Field("CIDetectorTypeRectangle", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString TypeRectangle
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeRectangle == null)
			{
				_TypeRectangle = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorTypeRectangle");
			}
			return _TypeRectangle;
		}
	}

	[Field("CIDetectorTypeText", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString TypeText
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeText == null)
			{
				_TypeText = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorTypeText");
			}
			return _TypeText;
		}
	}

	public static CIDetector CreateFaceDetector(CIContext context, bool highAccuracy)
	{
		using NSDictionary options = NSDictionary.FromObjectsAndKeys(new NSObject[1] { highAccuracy ? AccuracyHigh : AccuracyLow }, new NSObject[1] { Accuracy });
		return FromType(TypeFace, context, options);
	}

	public static CIDetector CreateFaceDetector(CIContext context, bool highAccuracy, float minFeatureSize)
	{
		if (MinFeatureSize == null)
		{
			return CreateFaceDetector(context, highAccuracy);
		}
		using NSDictionary options = NSDictionary.FromObjectsAndKeys(new NSObject[2]
		{
			highAccuracy ? AccuracyHigh : AccuracyLow,
			new NSNumber(minFeatureSize)
		}, new NSObject[2] { Accuracy, MinFeatureSize });
		return FromType(TypeFace, context, options);
	}

	public static CIDetector CreateFaceDetector(CIContext context, FaceDetectorAccuracy? accuracy = null, float? minFeatureSize = null, bool? trackingEnabled = null)
	{
		CIDetectorOptions cIDetectorOptions = new CIDetectorOptions
		{
			Accuracy = accuracy,
			MinFeatureSize = minFeatureSize,
			TrackingEnabled = trackingEnabled
		};
		using NSDictionary options = cIDetectorOptions.ToDictionary();
		return FromType(TypeFace, context, options);
	}

	public static CIDetector CreateFaceDetector(CIContext context, CIDetectorOptions detectorOptions)
	{
		using NSDictionary options = detectorOptions?.ToDictionary();
		return FromType(TypeFace, context, options);
	}

	public static CIDetector CreateRectangleDetector(CIContext context, CIDetectorOptions detectorOptions)
	{
		using NSDictionary options = detectorOptions?.ToDictionary();
		return FromType(TypeRectangle, context, options);
	}

	public static CIDetector CreateQRDetector(CIContext context, CIDetectorOptions detectorOptions)
	{
		using NSDictionary options = detectorOptions?.ToDictionary();
		return FromType(TypeQRCode, context, options);
	}

	public static CIDetector CreateTextDetector(CIContext context, CIDetectorOptions detectorOptions)
	{
		using NSDictionary options = detectorOptions?.ToDictionary();
		return FromType(TypeText, context, options);
	}

	public CIFeature[] FeaturesInImage(CIImage image, CIImageOrientation orientation)
	{
		using NSDictionary options = NSDictionary.FromObjectsAndKeys(new NSObject[1]
		{
			new NSNumber((int)orientation)
		}, new NSObject[1] { ImageOrientation });
		return FeaturesInImage(image, options);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIDetector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIDetector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("featuresInImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFeature[] FeaturesInImage(CIImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFeaturesInImage_Handle, image.Handle));
		}
		return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFeaturesInImage_Handle, image.Handle));
	}

	[Export("featuresInImage:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFeature[] FeaturesInImage(CIImage image, NSDictionary? options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFeaturesInImage_Options_Handle, image.Handle, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFeaturesInImage_Options_Handle, image.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("detectorOfType:context:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIDetector FromType(NSString? detectorType, CIContext? context, NSDictionary? options)
	{
		return Runtime.GetNSObject<CIDetector>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDetectorOfType_Context_Options_Handle, (detectorType == null) ? IntPtr.Zero : detectorType.Handle, context?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
	}
}
