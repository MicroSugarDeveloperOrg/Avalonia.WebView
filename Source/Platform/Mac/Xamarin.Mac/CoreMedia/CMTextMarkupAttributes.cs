using System;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Since(6, 0)]
public class CMTextMarkupAttributes : DictionaryContainer
{
	private static class Keys
	{
		public static readonly NSString ForegroundColorARGB;

		public static readonly NSString BackgroundColorARGB;

		public static readonly NSString BoldStyle;

		public static readonly NSString ItalicStyle;

		public static readonly NSString UnderlineStyle;

		public static readonly NSString FontFamilyName;

		public static readonly NSString RelativeFontSize;

		static Keys()
		{
			IntPtr intPtr = Dlfcn.dlopen("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia", 0);
			if (intPtr == IntPtr.Zero)
			{
				return;
			}
			try
			{
				ForegroundColorARGB = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_ForegroundColorARGB");
				BackgroundColorARGB = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_BackgroundColorARGB");
				BoldStyle = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_BoldStyle");
				ItalicStyle = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_ItalicStyle");
				UnderlineStyle = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_UnderlineStyle");
				FontFamilyName = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_FontFamilyName");
				RelativeFontSize = Dlfcn.GetStringConstant(intPtr, "kCMTextMarkupAttribute_RelativeFontSize");
			}
			finally
			{
				Dlfcn.dlclose(intPtr);
			}
		}
	}

	public TextMarkupColor? ForegroundColor
	{
		get
		{
			NSNumber[] array = GetArray<NSNumber>(Keys.ForegroundColorARGB);
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
				SetArrayValue(Keys.ForegroundColorARGB, new NSNumber[4]
				{
					NSNumber.FromFloat(value2.Alpha),
					NSNumber.FromFloat(value2.Red),
					NSNumber.FromFloat(value2.Green),
					NSNumber.FromFloat(value2.Blue)
				});
			}
			else
			{
				RemoveValue(Keys.ForegroundColorARGB);
			}
		}
	}

	public TextMarkupColor? BackgroundColor
	{
		get
		{
			NSNumber[] array = GetArray<NSNumber>(Keys.BackgroundColorARGB);
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
				SetArrayValue(Keys.BackgroundColorARGB, new NSNumber[4]
				{
					NSNumber.FromFloat(value2.Alpha),
					NSNumber.FromFloat(value2.Red),
					NSNumber.FromFloat(value2.Green),
					NSNumber.FromFloat(value2.Blue)
				});
			}
			else
			{
				RemoveValue(Keys.BackgroundColorARGB);
			}
		}
	}

	public bool? Bold
	{
		get
		{
			return GetBoolValue(Keys.BoldStyle);
		}
		set
		{
			SetBooleanValue(Keys.BoldStyle, value);
		}
	}

	public bool? Italic
	{
		get
		{
			return GetBoolValue(Keys.ItalicStyle);
		}
		set
		{
			SetBooleanValue(Keys.ItalicStyle, value);
		}
	}

	public bool? Underline
	{
		get
		{
			return GetBoolValue(Keys.UnderlineStyle);
		}
		set
		{
			SetBooleanValue(Keys.UnderlineStyle, value);
		}
	}

	public string FontFamilyName
	{
		get
		{
			return GetStringValue(Keys.FontFamilyName);
		}
		set
		{
			SetStringValue(Keys.FontFamilyName, value);
		}
	}

	public int? RelativeFontSize
	{
		get
		{
			return GetInt32Value(Keys.RelativeFontSize);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetNumberValue(Keys.RelativeFontSize, value);
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
