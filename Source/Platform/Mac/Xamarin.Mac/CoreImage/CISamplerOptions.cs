using CoreGraphics;
using Foundation;

namespace CoreImage;

public class CISamplerOptions
{
	public CGAffineTransform? AffineMatrix { get; set; }

	public CIWrapMode? WrapMode { get; set; }

	public CIFilterMode? FilterMode { get; set; }

	public CGColorSpace ColorSpace { get; set; }

	internal NSDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (AffineMatrix.HasValue)
		{
			CGAffineTransform value = AffineMatrix.Value;
			using NSArray obj = NSArray.FromObjects(value.xx, value.yx, value.xy, value.yy, value.x0, value.y0);
			nSMutableDictionary.SetObject(obj, CISampler.AffineMatrix);
		}
		if (WrapMode.HasValue)
		{
			NSString obj2 = ((WrapMode.Value == CIWrapMode.Black) ? CISampler.WrapBlack : CISampler.FilterNearest);
			nSMutableDictionary.SetObject(obj2, CISampler.WrapMode);
		}
		if (FilterMode.HasValue)
		{
			NSString obj3 = ((FilterMode.Value == CIFilterMode.Nearest) ? CISampler.FilterNearest : CISampler.FilterLinear);
			nSMutableDictionary.SetObject(obj3, CISampler.FilterMode);
		}
		if (ColorSpace != null)
		{
			nSMutableDictionary.LowlevelSetObject(ColorSpace.Handle, CISampler.ColorSpace.Handle);
		}
		return nSMutableDictionary;
	}
}
