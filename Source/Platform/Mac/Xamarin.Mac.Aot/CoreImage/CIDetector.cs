using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIDetector", true)]
public class CIDetector : NSObject
{
	private static readonly IntPtr selDetectorOfTypeContextOptions_Handle = Selector.GetHandle("detectorOfType:context:options:");

	private static readonly IntPtr selFeaturesInImage_Handle = Selector.GetHandle("featuresInImage:");

	private static readonly IntPtr selFeaturesInImageOptions_Handle = Selector.GetHandle("featuresInImage:options:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIDetector");

	private static NSString _TypeFace;

	private static NSString _ImageOrientation;

	private static NSString _Accuracy;

	private static NSString _AccuracyLow;

	private static NSString _AccuracyHigh;

	private static NSString _Tracking;

	private static NSString _MinFeatureSize;

	public override IntPtr ClassHandle => class_ptr;

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

	[Field("CIDetectorImageOrientation", "CoreImage")]
	[MountainLion]
	internal static NSString ImageOrientation
	{
		[MountainLion]
		get
		{
			if (_ImageOrientation == null)
			{
				_ImageOrientation = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIDetectorImageOrientation");
			}
			return _ImageOrientation;
		}
	}

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
		List<NSObject> list = new List<NSObject>(3);
		List<NSObject> list2 = new List<NSObject>(3);
		if (accuracy.HasValue)
		{
			list.Add(Accuracy);
			list2.Add((accuracy == FaceDetectorAccuracy.High) ? AccuracyHigh : AccuracyLow);
		}
		if (MinFeatureSize != null && minFeatureSize.HasValue)
		{
			list.Add(MinFeatureSize);
			list2.Add(new NSNumber(minFeatureSize.Value));
		}
		if (Tracking != null && trackingEnabled.HasValue)
		{
			list.Add(Tracking);
			list2.Add(NSObject.FromObject(true));
		}
		using NSDictionary options = NSDictionary.FromObjectsAndKeys(list2.ToArray(), list.ToArray());
		return FromType(TypeFace, context, options);
	}

	public CIFeature[] FeaturesInImage(CIImage image, CIImageOrientation orientation)
	{
		using NSDictionary options = NSDictionary.FromObjectsAndKeys(new NSObject[1]
		{
			new NSNumber((int)orientation)
		}, new NSObject[1] { ImageOrientation });
		return FeaturesInImage(image, options);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIDetector(NSCoder coder)
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
	public CIDetector(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIDetector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("detectorOfType:context:options:")]
	internal static CIDetector FromType(NSString detectorType, CIContext context, NSDictionary options)
	{
		return (CIDetector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDetectorOfTypeContextOptions_Handle, (detectorType == null) ? IntPtr.Zero : detectorType.Handle, context?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
	}

	[Export("featuresInImage:")]
	public virtual CIFeature[] FeaturesInImage(CIImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFeaturesInImage_Handle, image.Handle));
		}
		return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFeaturesInImage_Handle, image.Handle));
	}

	[Export("featuresInImage:options:")]
	public virtual CIFeature[] FeaturesInImage(CIImage image, NSDictionary options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFeaturesInImageOptions_Handle, image.Handle, options.Handle));
		}
		return NSArray.ArrayFromHandle<CIFeature>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFeaturesInImageOptions_Handle, image.Handle, options.Handle));
	}
}
