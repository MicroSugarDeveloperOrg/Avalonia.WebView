using System;
using CoreFoundation;
using Foundation;

namespace NaturalLanguage;

public class NLVectorDictionary : DictionaryContainer
{
	public float[] this[NSString key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			IntPtr value = CFDictionary.GetValue(base.Dictionary.Handle, key.Handle);
			return NSArray.ArrayFromHandle(value, (IntPtr input) => new NSNumber(input).FloatValue);
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (value == null)
			{
				RemoveValue(key);
			}
			else
			{
				base.Dictionary[key] = NSArray.From(value, -1L);
			}
		}
	}

	public float[] this[string key]
	{
		get
		{
			return this[(NSString)key];
		}
		set
		{
			this[(NSString)key] = value;
		}
	}

	public NLVectorDictionary()
	{
	}

	public NLVectorDictionary(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
