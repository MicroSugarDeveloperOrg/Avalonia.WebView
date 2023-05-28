using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreVideo;

[Watch(4, 0)]
public class CVPixelBufferAttributes : DictionaryContainer
{
	public CVPixelFormatType? PixelFormatType
	{
		get
		{
			return (CVPixelFormatType?)GetUIntValue(CVPixelBuffer.PixelFormatTypeKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.PixelFormatTypeKey, (uint?)value);
		}
	}

	public CFAllocator MemoryAllocator
	{
		get
		{
			return GetNativeValue<CFAllocator>(CVPixelBuffer.MemoryAllocatorKey);
		}
		set
		{
			SetNativeValue(CVPixelBuffer.MemoryAllocatorKey, value);
		}
	}

	public nint? Width
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.WidthKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.WidthKey, value);
		}
	}

	public nint? Height
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.HeightKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.HeightKey, value);
		}
	}

	public int? ExtendedPixelsLeft
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.ExtendedPixelsLeftKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.ExtendedPixelsLeftKey, value);
		}
	}

	public int? ExtendedPixelsTop
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.ExtendedPixelsTopKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.ExtendedPixelsTopKey, value);
		}
	}

	public int? ExtendedPixelsRight
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.ExtendedPixelsRightKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.ExtendedPixelsRightKey, value);
		}
	}

	public int? ExtendedPixelsBottom
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.ExtendedPixelsBottomKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.ExtendedPixelsBottomKey, value);
		}
	}

	public int? BytesPerRowAlignment
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.BytesPerRowAlignmentKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.BytesPerRowAlignmentKey, value);
		}
	}

	public bool? CGBitmapContextCompatibility
	{
		get
		{
			return GetBoolValue(CVPixelBuffer.CGBitmapContextCompatibilityKey);
		}
		set
		{
			SetBooleanValue(CVPixelBuffer.CGBitmapContextCompatibilityKey, value);
		}
	}

	public bool? CGImageCompatibility
	{
		get
		{
			return GetBoolValue(CVPixelBuffer.CGImageCompatibilityKey);
		}
		set
		{
			SetBooleanValue(CVPixelBuffer.CGImageCompatibilityKey, value);
		}
	}

	public bool? OpenGLCompatibility
	{
		get
		{
			return GetBoolValue(CVPixelBuffer.OpenGLCompatibilityKey);
		}
		set
		{
			SetBooleanValue(CVPixelBuffer.OpenGLCompatibilityKey, value);
		}
	}

	public int? PlaneAlignment
	{
		get
		{
			return GetInt32Value(CVPixelBuffer.PlaneAlignmentKey);
		}
		set
		{
			SetNumberValue(CVPixelBuffer.PlaneAlignmentKey, value);
		}
	}

	public CVPixelBufferAttributes()
		: base(new NSMutableDictionary())
	{
	}

	public CVPixelBufferAttributes(NSDictionary dictionary)
		: base(dictionary)
	{
	}

	public CVPixelBufferAttributes(CVPixelFormatType pixelFormatType, nint width, nint height)
		: this()
	{
		PixelFormatType = pixelFormatType;
		Width = width;
		Height = height;
	}
}
