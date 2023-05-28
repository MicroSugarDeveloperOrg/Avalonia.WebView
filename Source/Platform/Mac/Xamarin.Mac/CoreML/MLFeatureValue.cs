using System;
using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace CoreML;

[Register("MLFeatureValue", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MLFeatureValue : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryValue = "dictionaryValue";

	private static readonly IntPtr selDictionaryValueHandle = Selector.GetHandle("dictionaryValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithCGImage_Constraint_Options_Error_ = "featureValueWithCGImage:constraint:options:error:";

	private static readonly IntPtr selFeatureValueWithCGImage_Constraint_Options_Error_Handle = Selector.GetHandle("featureValueWithCGImage:constraint:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithCGImage_Orientation_Constraint_Options_Error_ = "featureValueWithCGImage:orientation:constraint:options:error:";

	private static readonly IntPtr selFeatureValueWithCGImage_Orientation_Constraint_Options_Error_Handle = Selector.GetHandle("featureValueWithCGImage:orientation:constraint:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithCGImage_Orientation_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_ = "featureValueWithCGImage:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:";

	private static readonly IntPtr selFeatureValueWithCGImage_Orientation_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle = Selector.GetHandle("featureValueWithCGImage:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithCGImage_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_ = "featureValueWithCGImage:pixelsWide:pixelsHigh:pixelFormatType:options:error:";

	private static readonly IntPtr selFeatureValueWithCGImage_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle = Selector.GetHandle("featureValueWithCGImage:pixelsWide:pixelsHigh:pixelFormatType:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithDictionary_Error_ = "featureValueWithDictionary:error:";

	private static readonly IntPtr selFeatureValueWithDictionary_Error_Handle = Selector.GetHandle("featureValueWithDictionary:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithDouble_ = "featureValueWithDouble:";

	private static readonly IntPtr selFeatureValueWithDouble_Handle = Selector.GetHandle("featureValueWithDouble:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithImageAtURL_Constraint_Options_Error_ = "featureValueWithImageAtURL:constraint:options:error:";

	private static readonly IntPtr selFeatureValueWithImageAtURL_Constraint_Options_Error_Handle = Selector.GetHandle("featureValueWithImageAtURL:constraint:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithImageAtURL_Orientation_Constraint_Options_Error_ = "featureValueWithImageAtURL:orientation:constraint:options:error:";

	private static readonly IntPtr selFeatureValueWithImageAtURL_Orientation_Constraint_Options_Error_Handle = Selector.GetHandle("featureValueWithImageAtURL:orientation:constraint:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithImageAtURL_Orientation_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_ = "featureValueWithImageAtURL:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:";

	private static readonly IntPtr selFeatureValueWithImageAtURL_Orientation_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle = Selector.GetHandle("featureValueWithImageAtURL:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithImageAtURL_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_ = "featureValueWithImageAtURL:pixelsWide:pixelsHigh:pixelFormatType:options:error:";

	private static readonly IntPtr selFeatureValueWithImageAtURL_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle = Selector.GetHandle("featureValueWithImageAtURL:pixelsWide:pixelsHigh:pixelFormatType:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithInt64_ = "featureValueWithInt64:";

	private static readonly IntPtr selFeatureValueWithInt64_Handle = Selector.GetHandle("featureValueWithInt64:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithMultiArray_ = "featureValueWithMultiArray:";

	private static readonly IntPtr selFeatureValueWithMultiArray_Handle = Selector.GetHandle("featureValueWithMultiArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithPixelBuffer_ = "featureValueWithPixelBuffer:";

	private static readonly IntPtr selFeatureValueWithPixelBuffer_Handle = Selector.GetHandle("featureValueWithPixelBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithSequence_ = "featureValueWithSequence:";

	private static readonly IntPtr selFeatureValueWithSequence_Handle = Selector.GetHandle("featureValueWithSequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueWithString_ = "featureValueWithString:";

	private static readonly IntPtr selFeatureValueWithString_Handle = Selector.GetHandle("featureValueWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageBufferValue = "imageBufferValue";

	private static readonly IntPtr selImageBufferValueHandle = Selector.GetHandle("imageBufferValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInt64Value = "int64Value";

	private static readonly IntPtr selInt64ValueHandle = Selector.GetHandle("int64Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToFeatureValue_ = "isEqualToFeatureValue:";

	private static readonly IntPtr selIsEqualToFeatureValue_Handle = Selector.GetHandle("isEqualToFeatureValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUndefined = "isUndefined";

	private static readonly IntPtr selIsUndefinedHandle = Selector.GetHandle("isUndefined");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiArrayValue = "multiArrayValue";

	private static readonly IntPtr selMultiArrayValueHandle = Selector.GetHandle("multiArrayValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSequenceValue = "sequenceValue";

	private static readonly IntPtr selSequenceValueHandle = Selector.GetHandle("sequenceValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndefinedFeatureValueWithType_ = "undefinedFeatureValueWithType:";

	private static readonly IntPtr selUndefinedFeatureValueWithType_Handle = Selector.GetHandle("undefinedFeatureValueWithType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLFeatureValue");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSObject, NSNumber> DictionaryValue
	{
		[Export("dictionaryValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSObject, NSNumber>>(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryValueHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSObject, NSNumber>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer? ImageBufferValue
	{
		[Export("imageBufferValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageBufferValueHandle), owns: false);
			}
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageBufferValueHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long Int64Value
	{
		[Export("int64Value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selInt64ValueHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInt64ValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMultiArray? MultiArrayValue
	{
		[Export("multiArrayValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLMultiArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiArrayValueHandle));
			}
			return Runtime.GetNSObject<MLMultiArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiArrayValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MLSequence? SequenceValue
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("sequenceValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLSequence>(Messaging.IntPtr_objc_msgSend(base.Handle, selSequenceValueHandle));
			}
			return Runtime.GetNSObject<MLSequence>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSequenceValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLFeatureType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLFeatureType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (MLFeatureType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Undefined
	{
		[Export("isUndefined")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUndefinedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUndefinedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MLFeatureValue()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLFeatureValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLFeatureValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("featureValueWithPixelBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue Create(CVPixelBuffer value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFeatureValueWithPixelBuffer_Handle, value.Handle));
	}

	[Export("featureValueWithSequence:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue Create(MLSequence sequence)
	{
		if (sequence == null)
		{
			throw new ArgumentNullException("sequence");
		}
		return Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFeatureValueWithSequence_Handle, sequence.Handle));
	}

	[Export("featureValueWithInt64:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue Create(long value)
	{
		return Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selFeatureValueWithInt64_Handle, value));
	}

	[Export("featureValueWithDouble:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue Create(double value)
	{
		return Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFeatureValueWithDouble_Handle, value));
	}

	[Export("featureValueWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue Create(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(value);
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFeatureValueWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("featureValueWithMultiArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue Create(MLMultiArray value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFeatureValueWithMultiArray_Handle, value.Handle));
	}

	[Export("featureValueWithDictionary:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSDictionary<NSObject, NSNumber> value, out NSError error)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithDictionary_Error_Handle, value.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("featureValueWithImageAtURL:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_UInt32_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithImageAtURL_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle, url.Handle, pixelsWide, pixelsHigh, (uint)pixelFormatType, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(url, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithImageAtURL:constraint:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithImageAtURL_Constraint_Options_Error_Handle, url.Handle, constraint.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(url, constraint, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithCGImage:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_UInt32_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithCGImage_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle, image.Handle, pixelsWide, pixelsHigh, (uint)pixelFormatType, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(image, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithCGImage:constraint:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithCGImage_Constraint_Options_Error_Handle, image.Handle, constraint.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(image, constraint, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithImageAtURL:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_int_nint_nint_UInt32_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithImageAtURL_Orientation_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle, url.Handle, (int)orientation, pixelsWide, pixelsHigh, (uint)pixelFormatType, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(url, orientation, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithImageAtURL:orientation:constraint:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, CGImagePropertyOrientation orientation, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithImageAtURL_Orientation_Constraint_Options_Error_Handle, url.Handle, (int)orientation, constraint.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(NSUrl url, CGImagePropertyOrientation orientation, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(url, orientation, constraint, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithCGImage:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_int_nint_nint_UInt32_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithCGImage_Orientation_PixelsWide_PixelsHigh_PixelFormatType_Options_Error_Handle, image.Handle, (int)orientation, pixelsWide, pixelsHigh, (uint)pixelFormatType, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(image, orientation, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary(), out error);
	}

	[Export("featureValueWithCGImage:orientation:constraint:options:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, CGImagePropertyOrientation orientation, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		IntPtr arg = IntPtr.Zero;
		MLFeatureValue nSObject = Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr_ref_IntPtr(class_ptr, selFeatureValueWithCGImage_Orientation_Constraint_Options_Error_Handle, image.Handle, (int)orientation, constraint.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue? Create(CGImage image, CGImagePropertyOrientation orientation, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
	{
		return Create(image, orientation, constraint, imageOptions.GetDictionary(), out error);
	}

	[Export("undefinedFeatureValueWithType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLFeatureValue CreateUndefined(MLFeatureType type)
	{
		return Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selUndefinedFeatureValueWithType_Handle, (long)type));
	}

	[Export("isEqualToFeatureValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqual(MLFeatureValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToFeatureValue_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToFeatureValue_Handle, value.Handle);
	}
}
