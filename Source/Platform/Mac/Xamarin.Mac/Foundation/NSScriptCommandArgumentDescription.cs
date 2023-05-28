using System;

namespace Foundation;

public class NSScriptCommandArgumentDescription : DictionaryContainer
{
	public string Name { get; set; }

	public bool IsOptional
	{
		get
		{
			return Optional != null && Optional == "Yes";
		}
		set
		{
			Optional = (value ? "Yes" : "No");
		}
	}

	public string? AppleEventCode
	{
		get
		{
			return GetStringValue(NSScriptCommandArgumentDescriptionKeys.AppleEventCodeKey);
		}
		set
		{
			SetStringValue(NSScriptCommandArgumentDescriptionKeys.AppleEventCodeKey, value);
		}
	}

	public string? Type
	{
		get
		{
			return GetStringValue(NSScriptCommandArgumentDescriptionKeys.TypeKey);
		}
		set
		{
			SetStringValue(NSScriptCommandArgumentDescriptionKeys.TypeKey, value);
		}
	}

	public string? Optional
	{
		get
		{
			return GetStringValue(NSScriptCommandArgumentDescriptionKeys.OptionalKey);
		}
		set
		{
			SetStringValue(NSScriptCommandArgumentDescriptionKeys.OptionalKey, value);
		}
	}

	public NSScriptCommandArgumentDescription(string name, string eventCode, string type, bool isOptional = false)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name cannot be null or empty.");
		}
		if (string.IsNullOrEmpty(eventCode))
		{
			throw new ArgumentException("eventCode cannot be null or empty");
		}
		if (string.IsNullOrEmpty(type))
		{
			throw new ArgumentException("type cannot be null or empty.");
		}
		if (eventCode.Length != 4)
		{
			throw new ArgumentException("eventCode must be a four char string");
		}
		Name = name;
		AppleEventCode = eventCode;
		Type = type;
		IsOptional = isOptional;
	}

	[Preserve(Conditional = true)]
	public NSScriptCommandArgumentDescription()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public NSScriptCommandArgumentDescription(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
