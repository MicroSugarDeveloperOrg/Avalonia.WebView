using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterAttributes
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Available_Mac;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Available_iOS;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Class;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Default;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Description;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterCategories;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterDisplayName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Max;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Min;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceDocumentation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SliderMax;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SliderMin;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeAngle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeBoolean;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeDistance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeGradient;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeInteger;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeOffset;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeOpaqueColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypePosition;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypePosition3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeRectangle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeScalar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeTransform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIParameterSet;

	[Field("kCIAttributeFilterAvailable_Mac", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString Available_Mac
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_Available_Mac == null)
			{
				_Available_Mac = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeFilterAvailable_Mac");
			}
			return _Available_Mac;
		}
	}

	[Field("kCIAttributeFilterAvailable_iOS", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString Available_iOS
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_Available_iOS == null)
			{
				_Available_iOS = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeFilterAvailable_iOS");
			}
			return _Available_iOS;
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

	[Field("kCIAttributeDescription", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString Description
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Description == null)
			{
				_Description = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeDescription");
			}
			return _Description;
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

	[Field("kCIAttributeReferenceDocumentation", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString ReferenceDocumentation
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ReferenceDocumentation == null)
			{
				_ReferenceDocumentation = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeReferenceDocumentation");
			}
			return _ReferenceDocumentation;
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

	[Field("kCIAttributeTypeColor", "Quartz")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString TypeColor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeColor == null)
			{
				_TypeColor = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeColor");
			}
			return _TypeColor;
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

	[Field("kCIAttributeTypeGradient", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString TypeGradient
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeGradient == null)
			{
				_TypeGradient = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeGradient");
			}
			return _TypeGradient;
		}
	}

	[Field("kCIAttributeTypeImage", "Quartz")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString TypeImage
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeImage == null)
			{
				_TypeImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeImage");
			}
			return _TypeImage;
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

	[Field("kCIAttributeTypeOpaqueColor", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString TypeOpaqueColor
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeOpaqueColor == null)
			{
				_TypeOpaqueColor = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeOpaqueColor");
			}
			return _TypeOpaqueColor;
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

	[Field("kCIAttributeTypeTransform", "Quartz")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString TypeTransform
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeTransform == null)
			{
				_TypeTransform = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIAttributeTypeTransform");
			}
			return _TypeTransform;
		}
	}

	[Field("kCIUIParameterSet", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString UIParameterSet
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UIParameterSet == null)
			{
				_UIParameterSet = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIUIParameterSet");
			}
			return _UIParameterSet;
		}
	}
}
