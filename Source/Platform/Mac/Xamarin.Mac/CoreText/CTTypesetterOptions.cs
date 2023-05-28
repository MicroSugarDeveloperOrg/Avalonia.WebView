using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

public class CTTypesetterOptions
{
	public NSDictionary Dictionary { get; private set; }

	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
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

	[Watch(5, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	public bool AllowUnboundedLayout
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTTypesetterOptionKey.AllowUnboundedLayout.Handle);
		}
		set
		{
			Adapter.AssertWritable(Dictionary);
			CFMutableDictionary.SetValue(Dictionary.Handle, CTTypesetterOptionKey.AllowUnboundedLayout.Handle, value);
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
