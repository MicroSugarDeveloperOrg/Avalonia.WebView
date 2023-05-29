using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontVariationAxes
{
	public NSDictionary Dictionary { get; private set; }

	public NSNumber Identifier
	{
		get
		{
			return (NSNumber)Dictionary[CTFontVariationAxisKey.Identifier];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontVariationAxisKey.Identifier, value);
		}
	}

	public NSNumber MinimumValue
	{
		get
		{
			return (NSNumber)Dictionary[CTFontVariationAxisKey.MinimumValue];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontVariationAxisKey.MinimumValue, value);
		}
	}

	public NSNumber MaximumValue
	{
		get
		{
			return (NSNumber)Dictionary[CTFontVariationAxisKey.MaximumValue];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontVariationAxisKey.MaximumValue, value);
		}
	}

	public NSNumber DefaultValue
	{
		get
		{
			return (NSNumber)Dictionary[CTFontVariationAxisKey.DefaultValue];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontVariationAxisKey.DefaultValue, value);
		}
	}

	public string Name
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontVariationAxisKey.Name);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontVariationAxisKey.Name, value);
		}
	}

	public CTFontVariationAxes()
		: this(new NSMutableDictionary())
	{
	}

	public CTFontVariationAxes(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
