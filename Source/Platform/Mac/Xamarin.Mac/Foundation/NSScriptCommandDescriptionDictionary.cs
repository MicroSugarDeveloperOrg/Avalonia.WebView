using System;

namespace Foundation;

public class NSScriptCommandDescriptionDictionary : DictionaryContainer
{
	public string? CommandClass
	{
		get
		{
			return GetStringValue(NSScriptCommandDescriptionDictionaryKeys.CommandClassKey);
		}
		set
		{
			SetStringValue(NSScriptCommandDescriptionDictionaryKeys.CommandClassKey, value);
		}
	}

	public string? AppleEventCode
	{
		get
		{
			return GetStringValue(NSScriptCommandDescriptionDictionaryKeys.AppleEventCodeKey);
		}
		set
		{
			SetStringValue(NSScriptCommandDescriptionDictionaryKeys.AppleEventCodeKey, value);
		}
	}

	public string? AppleEventClassCode
	{
		get
		{
			return GetStringValue(NSScriptCommandDescriptionDictionaryKeys.AppleEventClassCodeKey);
		}
		set
		{
			SetStringValue(NSScriptCommandDescriptionDictionaryKeys.AppleEventClassCodeKey, value);
		}
	}

	public string? Type
	{
		get
		{
			return GetStringValue(NSScriptCommandDescriptionDictionaryKeys.TypeKey);
		}
		set
		{
			SetStringValue(NSScriptCommandDescriptionDictionaryKeys.TypeKey, value);
		}
	}

	public string? ResultAppleEventCode
	{
		get
		{
			return GetStringValue(NSScriptCommandDescriptionDictionaryKeys.ResultAppleEventCodeKey);
		}
		set
		{
			SetStringValue(NSScriptCommandDescriptionDictionaryKeys.ResultAppleEventCodeKey, value);
		}
	}

	public NSMutableDictionary? Arguments
	{
		get
		{
			return base.Dictionary[NSScriptCommandDescriptionDictionaryKeys.ArgumentsKey] as NSMutableDictionary;
		}
		set
		{
			SetNativeValue(NSScriptCommandDescriptionDictionaryKeys.ArgumentsKey, value);
		}
	}

	public void Add(NSScriptCommandArgumentDescription arg)
	{
		if (arg == null)
		{
			throw new ArgumentNullException("arg");
		}
		if (Arguments == null)
		{
			Arguments = new NSMutableDictionary();
		}
		using NSString key = new NSString(arg.Name);
		Arguments.Add(key, arg.Dictionary);
	}

	public bool Remove(NSScriptCommandArgumentDescription arg)
	{
		if (arg == null)
		{
			throw new ArgumentNullException("arg");
		}
		using NSString key = new NSString(arg.Name);
		return Arguments?.Remove(key) ?? false;
	}

	[Preserve(Conditional = true)]
	public NSScriptCommandDescriptionDictionary()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public NSScriptCommandDescriptionDictionary(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
