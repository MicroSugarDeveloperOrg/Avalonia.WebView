using Foundation;

namespace QTKit;

public class QTImageAttributes
{
	public string CodecType { get; set; }

	public QTCodecQuality? Quality { get; set; }

	public int? TimeScale { get; set; }

	public NSDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (CodecType != null)
		{
			nSMutableDictionary.SetObject(new NSString(CodecType), QTMovie.ImageCodecType);
		}
		if (Quality.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromInt32((int)Quality.Value), QTMovie.ImageCodecQuality);
		}
		if (TimeScale.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromInt32(TimeScale.Value), QTTrack.TimeScaleAttribute);
		}
		return nSMutableDictionary;
	}
}
