using System.Collections.Generic;
using Foundation;

namespace CoreImage;

public class CIDetectorOptions
{
	public FaceDetectorAccuracy? Accuracy { get; set; }

	public float? MinFeatureSize { get; set; }

	[iOS(10, 0)]
	[Mac(10, 12)]
	public int? MaxFeatureCount { get; set; }

	public bool? TrackingEnabled { get; set; }

	public bool? EyeBlink { get; set; }

	public bool? Smile { get; set; }

	public float? AspectRatio { get; set; }

	public float? FocalLength { get; set; }

	public float? NumberOfAngles { get; set; }

	public bool? ReturnSubFeatures { get; set; }

	public CIImageOrientation? ImageOrientation { get; set; }

	internal NSDictionary ToDictionary()
	{
		List<NSObject> list = new List<NSObject>(6);
		List<NSObject> list2 = new List<NSObject>(6);
		if (CIDetector.Accuracy != null)
		{
			list.Add(CIDetector.Accuracy);
			list2.Add((Accuracy == FaceDetectorAccuracy.High) ? CIDetector.AccuracyHigh : CIDetector.AccuracyLow);
		}
		if (CIDetector.MinFeatureSize != null && MinFeatureSize.HasValue)
		{
			list.Add(CIDetector.MinFeatureSize);
			list2.Add(new NSNumber(MinFeatureSize.Value));
		}
		if (CIDetector.Tracking != null && TrackingEnabled.HasValue)
		{
			list.Add(CIDetector.Tracking);
			list2.Add(NSObject.FromObject(TrackingEnabled.Value));
		}
		if (CIDetector.EyeBlink != null && EyeBlink.HasValue)
		{
			list.Add(CIDetector.EyeBlink);
			list2.Add(NSObject.FromObject(EyeBlink.Value));
		}
		if (CIDetector.Smile != null && Smile.HasValue)
		{
			list.Add(CIDetector.Smile);
			list2.Add(NSObject.FromObject(Smile.Value));
		}
		if (CIDetector.AspectRatio != null && AspectRatio.HasValue)
		{
			list.Add(CIDetector.AspectRatio);
			list2.Add(new NSNumber(AspectRatio.Value));
		}
		if (CIDetector.FocalLength != null && FocalLength.HasValue)
		{
			list.Add(CIDetector.FocalLength);
			list2.Add(new NSNumber(FocalLength.Value));
		}
		if (CIDetector.NumberOfAngles != null && NumberOfAngles.HasValue)
		{
			list.Add(CIDetector.NumberOfAngles);
			list2.Add(new NSNumber(NumberOfAngles.Value));
		}
		if (CIDetector.ReturnSubFeatures != null && ReturnSubFeatures.HasValue)
		{
			list.Add(CIDetector.ReturnSubFeatures);
			list2.Add(new NSNumber(ReturnSubFeatures.Value));
		}
		if (CIDetector.ImageOrientation != null && ImageOrientation.HasValue)
		{
			list.Add(CIDetector.ImageOrientation);
			list2.Add(new NSNumber((int)ImageOrientation.Value));
		}
		if (CIDetector.MaxFeatureCount != null && MaxFeatureCount.HasValue)
		{
			list.Add(CIDetector.MaxFeatureCount);
			list2.Add(new NSNumber(MaxFeatureCount.Value));
		}
		return NSDictionary.FromObjectsAndKeys(list2.ToArray(), list.ToArray());
	}
}
