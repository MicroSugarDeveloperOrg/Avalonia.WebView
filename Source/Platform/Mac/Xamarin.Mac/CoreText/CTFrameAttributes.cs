using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFrameAttributes
{
	public NSDictionary Dictionary { get; private set; }

	public CTFrameProgression? Progression
	{
		get
		{
			uint? uInt32Value = Adapter.GetUInt32Value(Dictionary, CTFrameAttributeKey.Progression);
			if (uInt32Value.HasValue)
			{
				return (CTFrameProgression)uInt32Value.Value;
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFrameAttributeKey.Progression, value.HasValue ? new uint?((uint)value.Value) : null);
		}
	}

	public CTFrameAttributes()
		: this(new NSMutableDictionary())
	{
	}

	public CTFrameAttributes(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
