using System;
using CoreFoundation;
using Foundation;

namespace NaturalLanguage;

public class NLStrongDictionary : DictionaryContainer
{
	public string[] this[NSString key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			IntPtr value = CFDictionary.GetValue(base.Dictionary.Handle, key.Handle);
			return NSArray.StringArrayFromHandle(value);
		}
		set
		{
			SetArrayValue(key, value);
		}
	}

	public string[] this[string key]
	{
		get
		{
			return this[(NSString)key];
		}
		set
		{
			SetArrayValue((NSString)key, value);
		}
	}

	public NLStrongDictionary()
	{
	}

	public NLStrongDictionary(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
