using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTTypesetterOptions
{
	public NSDictionary Dictionary { get; private set; }

	[Obsolete("Deprecated in iOS 6.0")]
	public bool DisableBidiProcessing
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTTypesetterOptionKey.DisableBidiProcessing.Handle);
		}
		set
		{
			Adapter.AssertWritable(Dictionary);
			CFMutableDictionary.SetValue(Dictionary.Handle, CTTypesetterOptionKey.DisableBidiProcessing.Handle, value);
		}
	}

	public int? ForceEmbeddingLevel
	{
		get
		{
			return Adapter.GetInt32Value(Dictionary, CTTypesetterOptionKey.ForceEmbeddingLevel);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTTypesetterOptionKey.ForceEmbeddingLevel, value);
		}
	}

	public CTTypesetterOptions()
		: this(new NSMutableDictionary())
	{
	}

	public CTTypesetterOptions(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
