using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIContextOptions : DictionaryContainer
{
	public CGColorSpace OutputColorSpace
	{
		get
		{
			return GetNativeValue<CGColorSpace>(CIContext.OutputColorSpace);
		}
		set
		{
			SetNativeValue(CIContext.OutputColorSpace, value);
		}
	}

	public CGColorSpace WorkingColorSpace
	{
		get
		{
			return GetNativeValue<CGColorSpace>(CIContext._WorkingColorSpace);
		}
		set
		{
			SetNativeValue(CIContext._WorkingColorSpace, value);
		}
	}

	public bool UseSoftwareRenderer
	{
		get
		{
			bool? boolValue = GetBoolValue(CIContext.UseSoftwareRenderer);
			return boolValue.HasValue && boolValue.Value;
		}
		set
		{
			SetBooleanValue(CIContext.UseSoftwareRenderer, value);
		}
	}

	public int? CIImageFormat
	{
		get
		{
			return GetInt32Value(CIContext.WorkingFormatField);
		}
		set
		{
			SetNumberValue(CIContext.WorkingFormatField, value);
		}
	}

	[Mac(10, 12)]
	public bool? PriorityRequestLow
	{
		get
		{
			return GetBoolValue(CIContext.PriorityRequestLow);
		}
		set
		{
			SetBooleanValue(CIContext.PriorityRequestLow, value);
		}
	}

	public bool? HighQualityDownsample
	{
		get
		{
			return GetBoolValue(CIContext.HighQualityDownsample);
		}
		set
		{
			SetBooleanValue(CIContext.HighQualityDownsample, value);
		}
	}

	[iOS(7, 0)]
	public bool? OutputPremultiplied
	{
		get
		{
			return GetBoolValue(CIContext.OutputPremultiplied);
		}
		set
		{
			SetBooleanValue(CIContext.OutputPremultiplied, value);
		}
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public bool? CacheIntermediates
	{
		get
		{
			return GetBoolValue(CIContext.CacheIntermediates);
		}
		set
		{
			SetBooleanValue(CIContext.CacheIntermediates, value);
		}
	}

	[iOS(13, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	public bool? AllowLowPower
	{
		get
		{
			return GetBoolValue(CIContext.AllowLowPower);
		}
		set
		{
			SetBooleanValue(CIContext.AllowLowPower, value);
		}
	}

	public CIContextOptions()
	{
	}

	public CIContextOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
