using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTTextTabOptions
{
	public NSDictionary Dictionary { get; private set; }

	public NSCharacterSet ColumnTerminators
	{
		get
		{
			return (NSCharacterSet)Dictionary[CTTextTabOptionKey.ColumnTerminators];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTTextTabOptionKey.ColumnTerminators, value);
		}
	}

	public CTTextTabOptions()
		: this(new NSMutableDictionary())
	{
	}

	public CTTextTabOptions(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
