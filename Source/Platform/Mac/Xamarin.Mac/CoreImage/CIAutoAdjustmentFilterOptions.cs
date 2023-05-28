using CoreFoundation;
using Foundation;
using ImageIO;

namespace CoreImage;

public class CIAutoAdjustmentFilterOptions
{
	public bool? Enhance;

	public bool? RedEye;

	public CIFeature[] Features;

	public CIImageOrientation? ImageOrientation;

	[iOS(8, 0)]
	public bool? AutoAdjustCrop;

	[iOS(8, 0)]
	public bool? AutoAdjustLevel;

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
		if (AutoAdjustCrop.HasValue && AutoAdjustCrop.Value)
		{
			num++;
		}
		if (AutoAdjustLevel.HasValue && AutoAdjustLevel.Value)
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
			nSMutableDictionary.LowlevelSetObject(CFBoolean.FalseHandle, CIImage.AutoAdjustEnhanceKey.Handle);
		}
		if (RedEye.HasValue && !RedEye.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.FalseHandle, CIImage.AutoAdjustRedEyeKey.Handle);
		}
		if (Features != null && Features.Length != 0)
		{
			object[] features = Features;
			nSMutableDictionary.LowlevelSetObject(NSArray.FromObjects(features), CIImage.AutoAdjustFeaturesKey.Handle);
		}
		if (ImageOrientation.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(new NSNumber((int)ImageOrientation.Value), CGImageProperties.Orientation.Handle);
		}
		if (AutoAdjustCrop.HasValue && AutoAdjustCrop.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, CIImage.AutoAdjustCrop.Handle);
		}
		if (AutoAdjustLevel.HasValue && AutoAdjustLevel.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, CIImage.AutoAdjustLevel.Handle);
		}
		return nSMutableDictionary;
	}
}
