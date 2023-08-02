using Foundation;

namespace CoreVideo;

public class CVPixelBufferPoolSettings : DictionaryContainer
{
	public int? MinimumBufferCount
	{
		get
		{
			return GetInt32Value(CVPixelBufferPool.MinimumBufferCountKey);
		}
		set
		{
			SetNumberValue(CVPixelBufferPool.MinimumBufferCountKey, value);
		}
	}

	public double? MaximumBufferAgeInSeconds
	{
		get
		{
			return GetDoubleValue(CVPixelBufferPool.MaximumBufferAgeKey);
		}
		set
		{
			SetNumberValue(CVPixelBufferPool.MaximumBufferAgeKey, value);
		}
	}

	public CVPixelBufferPoolSettings()
		: base(new NSMutableDictionary())
	{
	}

	public CVPixelBufferPoolSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
