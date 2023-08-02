using CoreFoundation;
using Foundation;

namespace CoreImage;

public class CIAutoAdjustmentFilterOptions
{
	public bool? Enhance;

	public bool? RedEye;

	public CIFeature[] Features;

	public CIImageOrientation? ImageOrientation;

	internal NSDictionary ToDictionary()
	{
		int num = 0;
		if (Enhance.HasValue && !Enhance.Value)
		{
			num++;
		}
		if (RedEye.HasValue && !RedEye.Value)
		{
			num++;
		}
		if (ImageOrientation.HasValue)
		{
			num++;
		}
		if (Features != null && Features.Length != 0)
		{
			num++;
		}
		if (num == 0)
		{
			return null;
		}
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (Enhance.HasValue && !Enhance.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.False.Handle, CIImage.AutoAdjustEnhanceKey.Handle);
		}
		if (RedEye.HasValue && !RedEye.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.False.Handle, CIImage.AutoAdjustRedEyeKey.Handle);
		}
		if (Features != null && Features.Length != 0)
		{
			nSMutableDictionary.LowlevelSetObject(NSArray.FromObjects(Features), CIImage.AutoAdjustFeaturesKey.Handle);
		}
		if (ImageOrientation.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(new NSNumber((int)ImageOrientation.Value), CIImage.ImagePropertyOrientation.Handle);
		}
		return nSMutableDictionary;
	}
}
