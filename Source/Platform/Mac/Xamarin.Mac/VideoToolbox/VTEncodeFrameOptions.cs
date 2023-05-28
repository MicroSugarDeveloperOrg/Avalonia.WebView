using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTEncodeFrameOptions : DictionaryContainer
{
	public bool? ForceKeyFrame
	{
		get
		{
			return GetBoolValue(VTEncodeFrameOptionKey.ForceKeyFrame);
		}
		set
		{
			SetBooleanValue(VTEncodeFrameOptionKey.ForceKeyFrame, value);
		}
	}

	[Preserve(Conditional = true)]
	public VTEncodeFrameOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTEncodeFrameOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
