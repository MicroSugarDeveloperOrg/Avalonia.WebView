using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SceneKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class SCNProgramSemanticOptions : DictionaryContainer
{
	public nuint? MappingChannel
	{
		get
		{
			return GetNUIntValue(SCNProgram.MappingChannelKey);
		}
		set
		{
			SetNumberValue(SCNProgram.MappingChannelKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNProgramSemanticOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SCNProgramSemanticOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
