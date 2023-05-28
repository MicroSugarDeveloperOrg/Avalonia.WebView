using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNImageOptions : DictionaryContainer
{
	public NSDictionary? WeakProperties
	{
		get
		{
			return GetNSDictionary(VNImageOptionKeys.PropertiesKey);
		}
		set
		{
			SetNativeValue(VNImageOptionKeys.PropertiesKey, value);
		}
	}

	public CGImageProperties? Properties
	{
		get
		{
			return GetStrongDictionary<CGImageProperties>(VNImageOptionKeys.PropertiesKey);
		}
		set
		{
			SetNativeValue(VNImageOptionKeys.PropertiesKey, value.GetDictionary());
		}
	}

	public NSData? CameraIntrinsics
	{
		get
		{
			return base.Dictionary[VNImageOptionKeys.CameraIntrinsicsKey] as NSData;
		}
		set
		{
			SetNativeValue(VNImageOptionKeys.CameraIntrinsicsKey, value);
		}
	}

	public CIContext? CIContext
	{
		get
		{
			return base.Dictionary[VNImageOptionKeys.CIContextKey] as CIContext;
		}
		set
		{
			SetNativeValue(VNImageOptionKeys.CIContextKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public VNImageOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VNImageOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
