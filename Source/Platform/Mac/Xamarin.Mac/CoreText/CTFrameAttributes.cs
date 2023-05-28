using System;
using Foundation;

namespace CoreText;

public class CTFrameAttributes
{
	public NSDictionary Dictionary { get; private set; }

	public CTFrameProgression? Progression
	{
		get
		{
			uint? uInt32Value = Adapter.GetUInt32Value(Dictionary, CTFrameAttributeKey.Progression);
			return (!uInt32Value.HasValue) ? null : new CTFrameProgression?((CTFrameProgression)uInt32Value.Value);
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
