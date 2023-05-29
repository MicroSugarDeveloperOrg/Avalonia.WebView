using System;
using System.Collections.Generic;
using System.Linq;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontFeatures
{
	public NSDictionary Dictionary { get; private set; }

	[Advice("Use FeatureGroup property instead")]
	public NSNumber Identifier
	{
		get
		{
			return (NSNumber)Dictionary[CTFontFeatureKey.Identifier];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontFeatureKey.Identifier, value);
		}
	}

	public string Name
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontFeatureKey.Name);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontFeatureKey.Name, value);
		}
	}

	public FontFeatureGroup FeatureGroup => (FontFeatureGroup)(int)(NSNumber)Dictionary[CTFontFeatureKey.Identifier];

	public bool Exclusive
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTFontFeatureKey.Exclusive.Handle);
		}
		set
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, CTFontFeatureKey.Exclusive.Handle, value);
		}
	}

	public IEnumerable<CTFontFeatureSelectors> Selectors
	{
		get
		{
			return Adapter.GetNativeArray(Dictionary, CTFontFeatureKey.Selectors, (IntPtr d) => CTFontFeatureSelectors.Create(FeatureGroup, (NSDictionary)Runtime.GetNSObject(d)));
		}
		set
		{
			List<CTFontFeatureSelectors> source;
			if (value == null || (source = new List<CTFontFeatureSelectors>(value)).Count == 0)
			{
				Adapter.SetValue((IDictionary<NSObject, NSObject>)Dictionary, (NSObject)CTFontFeatureKey.Selectors, (NSObject)null);
				return;
			}
			Adapter.SetValue(Dictionary, CTFontFeatureKey.Selectors, NSArray.FromNSObjects(((IEnumerable<CTFontFeatureSelectors>)source).Select((Func<CTFontFeatureSelectors, NSObject>)((CTFontFeatureSelectors e) => e.Dictionary)).ToList()));
		}
	}

	public CTFontFeatures()
		: this(new NSMutableDictionary())
	{
	}

	public CTFontFeatures(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
