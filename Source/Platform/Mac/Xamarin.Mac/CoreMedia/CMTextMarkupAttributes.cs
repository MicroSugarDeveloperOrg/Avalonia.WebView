using System;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public class CMTextMarkupAttributes : DictionaryContainer
{
	public TextMarkupColor? ForegroundColor
	{
		get
		{
			NSNumber[] array = GetArray<NSNumber>(CMTextMarkupAttributesKeys.ForegroundColorARGB);
			if (array == null)
			{
				return null;
			}
			return new TextMarkupColor(array[1].FloatValue, array[2].FloatValue, array[3].FloatValue, array[0].FloatValue);
		}
		set
		{
			if (value.HasValue)
			{
				TextMarkupColor value2 = value.Value;
				SetArrayValue(CMTextMarkupAttributesKeys.ForegroundColorARGB, new NSNumber[4]
				{
					NSNumber.FromFloat(value2.Alpha),
					NSNumber.FromFloat(value2.Red),
					NSNumber.FromFloat(value2.Green),
					NSNumber.FromFloat(value2.Blue)
				});
			}
			else
			{
				RemoveValue(CMTextMarkupAttributesKeys.ForegroundColorARGB);
			}
		}
	}

	public TextMarkupColor? BackgroundColor
	{
		get
		{
			NSNumber[] array = GetArray<NSNumber>(CMTextMarkupAttributesKeys.BackgroundColorARGB);
			if (array == null)
			{
				return null;
			}
			return new TextMarkupColor(array[1].FloatValue, array[2].FloatValue, array[3].FloatValue, array[0].FloatValue);
		}
		set
		{
			if (value.HasValue)
			{
				TextMarkupColor value2 = value.Value;
				SetArrayValue(CMTextMarkupAttributesKeys.BackgroundColorARGB, new NSNumber[4]
				{
					NSNumber.FromFloat(value2.Alpha),
					NSNumber.FromFloat(value2.Red),
					NSNumber.FromFloat(value2.Green),
					NSNumber.FromFloat(value2.Blue)
				});
			}
			else
			{
				RemoveValue(CMTextMarkupAttributesKeys.BackgroundColorARGB);
			}
		}
	}

	public bool? Bold
	{
		get
		{
			return GetBoolValue(CMTextMarkupAttributesKeys.BoldStyle);
		}
		set
		{
			SetBooleanValue(CMTextMarkupAttributesKeys.BoldStyle, value);
		}
	}

	public bool? Italic
	{
		get
		{
			return GetBoolValue(CMTextMarkupAttributesKeys.ItalicStyle);
		}
		set
		{
			SetBooleanValue(CMTextMarkupAttributesKeys.ItalicStyle, value);
		}
	}

	public bool? Underline
	{
		get
		{
			return GetBoolValue(CMTextMarkupAttributesKeys.UnderlineStyle);
		}
		set
		{
			SetBooleanValue(CMTextMarkupAttributesKeys.UnderlineStyle, value);
		}
	}

	public string FontFamilyName
	{
		get
		{
			return GetStringValue(CMTextMarkupAttributesKeys.FontFamilyName);
		}
		set
		{
			SetStringValue(CMTextMarkupAttributesKeys.FontFamilyName, value);
		}
	}

	public int? RelativeFontSize
	{
		get
		{
			return GetInt32Value(CMTextMarkupAttributesKeys.RelativeFontSize);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetNumberValue(CMTextMarkupAttributesKeys.RelativeFontSize, value);
		}
	}

	public float? BaseFontSizePercentageRelativeToVideoHeight
	{
		get
		{
			return GetFloatValue(CMTextMarkupAttributesKeys.BaseFontSizePercentageRelativeToVideoHeight);
		}
		set
		{
			if (value < 0f)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetNumberValue(CMTextMarkupAttributesKeys.BaseFontSizePercentageRelativeToVideoHeight, value);
		}
	}

	public CMTextMarkupAttributes()
	{
	}

	public CMTextMarkupAttributes(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
