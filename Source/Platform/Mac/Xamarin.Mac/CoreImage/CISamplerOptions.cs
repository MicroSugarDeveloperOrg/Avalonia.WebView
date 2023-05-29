using CoreGraphics;
using Foundation;

namespace CoreImage;

public class CISamplerOptions
{
	public CGAffineTransform? AffineMatrix { get; set; }

	public CIWrapMode? WrapMode { get; set; }

	public CIFilterMode? FilterMode { get; set; }

	internal NSDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (AffineMatrix.HasValue)
		{
			CGAffineTransform value = AffineMatrix.Value;
			nSMutableDictionary.SetObject(NSArray.FromNSObjects(NSNumber.FromDouble(value.xx), NSNumber.FromDouble(value.yx), NSNumber.FromDouble(value.xy), NSNumber.FromDouble(value.yy), NSNumber.FromDouble(value.x0), NSNumber.FromDouble(value.y0)), CISampler.AffineMatrix);
		}
		if (WrapMode.HasValue)
		{
			NSString obj = ((WrapMode.Value == CIWrapMode.Black) ? CISampler.WrapBlack : CISampler.FilterNearest);
			nSMutableDictionary.SetObject(obj, CISampler.WrapMode);
		}
		if (FilterMode.HasValue)
		{
			NSString obj2 = ((FilterMode.Value == CIFilterMode.Nearest) ? CISampler.FilterNearest : CISampler.FilterLinear);
			nSMutableDictionary.SetObject(obj2, CISampler.FilterMode);
		}
		return nSMutableDictionary;
	}
}
