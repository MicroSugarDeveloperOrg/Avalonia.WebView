using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Mac(10, 13)]
[iOS(11, 0)]
[TV(11, 0)]
public class VTSupportedEncoderProperties
{
	public string EncoderId { get; set; }

	public NSDictionary SupportedProperties { get; set; }
}
