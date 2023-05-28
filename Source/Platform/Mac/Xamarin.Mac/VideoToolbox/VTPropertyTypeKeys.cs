using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTPropertyTypeKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Boolean;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Enumeration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Number;

	[Field("kVTPropertyType_Boolean", "VideoToolbox")]
	public static NSString Boolean
	{
		get
		{
			if (_Boolean == null)
			{
				_Boolean = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyType_Boolean");
			}
			return _Boolean;
		}
	}

	[Field("kVTPropertyType_Enumeration", "VideoToolbox")]
	public static NSString Enumeration
	{
		get
		{
			if (_Enumeration == null)
			{
				_Enumeration = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyType_Enumeration");
			}
			return _Enumeration;
		}
	}

	[Field("kVTPropertyType_Number", "VideoToolbox")]
	public static NSString Number
	{
		get
		{
			if (_Number == null)
			{
				_Number = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyType_Number");
			}
			return _Number;
		}
	}
}
