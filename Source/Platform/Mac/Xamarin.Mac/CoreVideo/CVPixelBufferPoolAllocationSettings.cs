using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public class CVPixelBufferPoolAllocationSettings : DictionaryContainer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThresholdKey;

	public int? Threshold
	{
		get
		{
			return GetInt32Value(ThresholdKey);
		}
		set
		{
			SetNumberValue(ThresholdKey, value);
		}
	}

	[Field("kCVPixelBufferPoolAllocationThresholdKey", "CoreVideo")]
	internal static NSString ThresholdKey
	{
		get
		{
			if (_ThresholdKey == null)
			{
				_ThresholdKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferPoolAllocationThresholdKey");
			}
			return _ThresholdKey;
		}
	}

	public CVPixelBufferPoolAllocationSettings()
		: base(new NSMutableDictionary())
	{
	}

	public CVPixelBufferPoolAllocationSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
