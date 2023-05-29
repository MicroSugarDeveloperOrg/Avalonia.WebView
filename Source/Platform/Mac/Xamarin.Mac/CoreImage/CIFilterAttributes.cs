using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterAttributes
{
	private static NSString _FilterName;

	private static NSString _FilterDisplayName;

	private static NSString _Description;

	private static NSString _ReferenceDocumentation;

	private static NSString _FilterCategories;

	private static NSString _Class;

	private static NSString _Type;

	private static NSString _Min;

	private static NSString _Max;

	private static NSString _SliderMin;

	private static NSString _SliderMax;

	private static NSString _Default;

	private static NSString _Identity;

	private static NSString _Name;

	private static NSString _DisplayName;

	private static NSString _UIParameterSet;

	private static NSString _TypeTime;

	private static NSString _TypeScalar;

	private static NSString _TypeDistance;

	private static NSString _TypeAngle;

	private static NSString _TypeBoolean;

	private static NSString _TypeInteger;

	private static NSString _TypeCount;

	private static NSString _TypePosition;

	private static NSString _TypeOffset;

	private static NSString _TypePosition3;

	private static NSString _TypeRectangle;

	private static NSString _TypeOpaqueColor;

	private static NSString _TypeGradient;

	[Field("kCIAttributeFilterName", "Quartz")]
	public static NSString FilterName
	{
		get
		{
			if (_FilterName == null)
			{
				_FilterName = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeFilterName");
			}
			return _FilterName;
		}
	}

	[Field("kCIAttributeFilterDisplayName", "Quartz")]
	public static NSString FilterDisplayName
	{
		get
		{
			if (_FilterDisplayName == null)
			{
				_FilterDisplayName = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeFilterDisplayName");
			}
			return _FilterDisplayName;
		}
	}

	[Field("kCIAttributeDescription", "Quartz")]
	public static NSString Description
	{
		get
		{
			if (_Description == null)
			{
				_Description = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeDescription");
			}
			return _Description;
		}
	}

	[Field("kCIAttributeReferenceDocumentation", "Quartz")]
	public static NSString ReferenceDocumentation
	{
		get
		{
			if (_ReferenceDocumentation == null)
			{
				_ReferenceDocumentation = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeReferenceDocumentation");
			}
			return _ReferenceDocumentation;
		}
	}

	[Field("kCIAttributeFilterCategories", "Quartz")]
	public static NSString FilterCategories
	{
		get
		{
			if (_FilterCategories == null)
			{
				_FilterCategories = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeFilterCategories");
			}
			return _FilterCategories;
		}
	}

	[Field("kCIAttributeClass", "Quartz")]
	public static NSString Class
	{
		get
		{
			if (_Class == null)
			{
				_Class = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeClass");
			}
			return _Class;
		}
	}

	[Field("kCIAttributeType", "Quartz")]
	public static NSString Type
	{
		get
		{
			if (_Type == null)
			{
				_Type = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeType");
			}
			return _Type;
		}
	}

	[Field("kCIAttributeMin", "Quartz")]
	public static NSString Min
	{
		get
		{
			if (_Min == null)
			{
				_Min = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeMin");
			}
			return _Min;
		}
	}

	[Field("kCIAttributeMax", "Quartz")]
	public static NSString Max
	{
		get
		{
			if (_Max == null)
			{
				_Max = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeMax");
			}
			return _Max;
		}
	}

	[Field("kCIAttributeSliderMin", "Quartz")]
	public static NSString SliderMin
	{
		get
		{
			if (_SliderMin == null)
			{
				_SliderMin = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeSliderMin");
			}
			return _SliderMin;
		}
	}

	[Field("kCIAttributeSliderMax", "Quartz")]
	public static NSString SliderMax
	{
		get
		{
			if (_SliderMax == null)
			{
				_SliderMax = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeSliderMax");
			}
			return _SliderMax;
		}
	}

	[Field("kCIAttributeDefault", "Quartz")]
	public static NSString Default
	{
		get
		{
			if (_Default == null)
			{
				_Default = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeDefault");
			}
			return _Default;
		}
	}

	[Field("kCIAttributeIdentity", "Quartz")]
	public static NSString Identity
	{
		get
		{
			if (_Identity == null)
			{
				_Identity = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeIdentity");
			}
			return _Identity;
		}
	}

	[Field("kCIAttributeName", "Quartz")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeName");
			}
			return _Name;
		}
	}

	[Field("kCIAttributeDisplayName", "Quartz")]
	public static NSString DisplayName
	{
		get
		{
			if (_DisplayName == null)
			{
				_DisplayName = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeDisplayName");
			}
			return _DisplayName;
		}
	}

	[Field("kCIUIParameterSet", "Quartz")]
	public static NSString UIParameterSet
	{
		get
		{
			if (_UIParameterSet == null)
			{
				_UIParameterSet = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIUIParameterSet");
			}
			return _UIParameterSet;
		}
	}

	[Field("kCIAttributeTypeTime", "Quartz")]
	public static NSString TypeTime
	{
		get
		{
			if (_TypeTime == null)
			{
				_TypeTime = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeTime");
			}
			return _TypeTime;
		}
	}

	[Field("kCIAttributeTypeScalar", "Quartz")]
	public static NSString TypeScalar
	{
		get
		{
			if (_TypeScalar == null)
			{
				_TypeScalar = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeScalar");
			}
			return _TypeScalar;
		}
	}

	[Field("kCIAttributeTypeDistance", "Quartz")]
	public static NSString TypeDistance
	{
		get
		{
			if (_TypeDistance == null)
			{
				_TypeDistance = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeDistance");
			}
			return _TypeDistance;
		}
	}

	[Field("kCIAttributeTypeAngle", "Quartz")]
	public static NSString TypeAngle
	{
		get
		{
			if (_TypeAngle == null)
			{
				_TypeAngle = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeAngle");
			}
			return _TypeAngle;
		}
	}

	[Field("kCIAttributeTypeBoolean", "Quartz")]
	public static NSString TypeBoolean
	{
		get
		{
			if (_TypeBoolean == null)
			{
				_TypeBoolean = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeBoolean");
			}
			return _TypeBoolean;
		}
	}

	[Field("kCIAttributeTypeInteger", "Quartz")]
	public static NSString TypeInteger
	{
		get
		{
			if (_TypeInteger == null)
			{
				_TypeInteger = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeInteger");
			}
			return _TypeInteger;
		}
	}

	[Field("kCIAttributeTypeCount", "Quartz")]
	public static NSString TypeCount
	{
		get
		{
			if (_TypeCount == null)
			{
				_TypeCount = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeCount");
			}
			return _TypeCount;
		}
	}

	[Field("kCIAttributeTypePosition", "Quartz")]
	public static NSString TypePosition
	{
		get
		{
			if (_TypePosition == null)
			{
				_TypePosition = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypePosition");
			}
			return _TypePosition;
		}
	}

	[Field("kCIAttributeTypeOffset", "Quartz")]
	public static NSString TypeOffset
	{
		get
		{
			if (_TypeOffset == null)
			{
				_TypeOffset = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeOffset");
			}
			return _TypeOffset;
		}
	}

	[Field("kCIAttributeTypePosition3", "Quartz")]
	public static NSString TypePosition3
	{
		get
		{
			if (_TypePosition3 == null)
			{
				_TypePosition3 = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypePosition3");
			}
			return _TypePosition3;
		}
	}

	[Field("kCIAttributeTypeRectangle", "Quartz")]
	public static NSString TypeRectangle
	{
		get
		{
			if (_TypeRectangle == null)
			{
				_TypeRectangle = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeRectangle");
			}
			return _TypeRectangle;
		}
	}

	[Field("kCIAttributeTypeOpaqueColor", "Quartz")]
	public static NSString TypeOpaqueColor
	{
		get
		{
			if (_TypeOpaqueColor == null)
			{
				_TypeOpaqueColor = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeOpaqueColor");
			}
			return _TypeOpaqueColor;
		}
	}

	[Field("kCIAttributeTypeGradient", "Quartz")]
	public static NSString TypeGradient
	{
		get
		{
			if (_TypeGradient == null)
			{
				_TypeGradient = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeGradient");
			}
			return _TypeGradient;
		}
	}
}
