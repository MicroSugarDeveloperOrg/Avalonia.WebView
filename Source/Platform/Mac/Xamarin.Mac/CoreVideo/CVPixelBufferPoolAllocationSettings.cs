using System;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

public class CVPixelBufferPoolAllocationSettings : DictionaryContainer
{
	private static readonly NSString ThresholdKey;

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

	static CVPixelBufferPoolAllocationSettings()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			ThresholdKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferPoolAllocationThresholdKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
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
