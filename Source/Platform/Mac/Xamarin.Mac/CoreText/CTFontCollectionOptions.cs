using System;
using Foundation;

namespace CoreText;

public class CTFontCollectionOptions
{
	public NSDictionary Dictionary { get; private set; }

	public bool RemoveDuplicates
	{
		get
		{
			int? int32Value = Adapter.GetInt32Value(Dictionary, CTFontCollectionOptionKey.RemoveDuplicates);
			return int32Value.HasValue && int32Value.Value != 0;
		}
		set
		{
			int? value2 = (value ? new int?(1) : null);
			Adapter.SetValue(Dictionary, CTFontCollectionOptionKey.RemoveDuplicates, value2);
		}
	}

	public CTFontCollectionOptions()
		: this(new NSMutableDictionary())
	{
	}

	public CTFontCollectionOptions(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
