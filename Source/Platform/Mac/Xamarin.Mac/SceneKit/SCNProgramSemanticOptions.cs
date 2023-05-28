using System;
using Foundation;
using ObjCRuntime;

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
