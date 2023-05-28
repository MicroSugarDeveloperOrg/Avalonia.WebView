using Foundation;
using Xamarin.Mac.System.Mac;

namespace IOSurface;

public class IOSurfaceOptions : DictionaryContainer
{
	public nint? AllocSize
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.AllocSizeKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.AllocSizeKey, value);
		}
	}

	public nint? Width
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.WidthKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.WidthKey, value);
		}
	}

	public nint? Height
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.HeightKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.HeightKey, value);
		}
	}

	public nint? BytesPerRow
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.BytesPerRowKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.BytesPerRowKey, value);
		}
	}

	public nint? BytesPerElement
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.BytesPerElementKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.BytesPerElementKey, value);
		}
	}

	public nint? ElementWidth
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.ElementWidthKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.ElementWidthKey, value);
		}
	}

	public nint? ElementHeight
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.ElementHeightKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.ElementHeightKey, value);
		}
	}

	public nint? Offset
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.OffsetKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.OffsetKey, value);
		}
	}

	public NSDictionary[]? PlaneInfo
	{
		get
		{
			return GetArray<NSDictionary>(IOSurfacePropertyKey.PlaneInfoKey);
		}
		set
		{
			SetArrayValue(IOSurfacePropertyKey.PlaneInfoKey, value);
		}
	}

	public nint? PlaneWidth
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneWidthKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneWidthKey, value);
		}
	}

	public nint? PlaneHeight
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneHeightKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneHeightKey, value);
		}
	}

	public nint? PlaneBytesPerRow
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneBytesPerRowKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneBytesPerRowKey, value);
		}
	}

	public nint? PlaneOffset
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneOffsetKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneOffsetKey, value);
		}
	}

	public nint? PlaneSize
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneSizeKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneSizeKey, value);
		}
	}

	public nint? PlaneBase
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneBaseKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneBaseKey, value);
		}
	}

	public nint? PlaneBytesPerElement
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneBytesPerElementKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneBytesPerElementKey, value);
		}
	}

	public nint? PlaneElementWidth
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneElementWidthKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneElementWidthKey, value);
		}
	}

	public nint? PlaneElementHeight
	{
		get
		{
			return GetNIntValue(IOSurfacePropertyKey.PlaneElementHeightKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PlaneElementHeightKey, value);
		}
	}

	public IOSurfaceMemoryMap? CacheMode
	{
		get
		{
			return (IOSurfaceMemoryMap?)GetInt32Value(IOSurfacePropertyKey.CacheModeKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.CacheModeKey, (int?)value);
		}
	}

	public uint? PixelFormat
	{
		get
		{
			return GetUInt32Value(IOSurfacePropertyKey.PixelFormatKey);
		}
		set
		{
			SetNumberValue(IOSurfacePropertyKey.PixelFormatKey, value);
		}
	}

	public bool? PixelSizeCastingAllowed
	{
		get
		{
			return GetBoolValue(IOSurfacePropertyKey.PixelSizeCastingAllowedKey);
		}
		set
		{
			SetBooleanValue(IOSurfacePropertyKey.PixelSizeCastingAllowedKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public IOSurfaceOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public IOSurfaceOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
