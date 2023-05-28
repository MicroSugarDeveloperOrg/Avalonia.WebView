using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTPropertyKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadWriteStatus;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShouldBeSerialized;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedValueListKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedValueMaximumKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedValueMinimumKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type;

	[Field("kVTPropertyDocumentationKey", "VideoToolbox")]
	public static NSString DocumentationKey
	{
		get
		{
			if (_DocumentationKey == null)
			{
				_DocumentationKey = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyDocumentationKey");
			}
			return _DocumentationKey;
		}
	}

	[Field("kVTPropertyReadWriteStatusKey", "VideoToolbox")]
	public static NSString ReadWriteStatus
	{
		get
		{
			if (_ReadWriteStatus == null)
			{
				_ReadWriteStatus = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyReadWriteStatusKey");
			}
			return _ReadWriteStatus;
		}
	}

	[Field("kVTPropertyShouldBeSerializedKey", "VideoToolbox")]
	public static NSString ShouldBeSerialized
	{
		get
		{
			if (_ShouldBeSerialized == null)
			{
				_ShouldBeSerialized = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyShouldBeSerializedKey");
			}
			return _ShouldBeSerialized;
		}
	}

	[Field("kVTPropertySupportedValueListKey", "VideoToolbox")]
	public static NSString SupportedValueListKey
	{
		get
		{
			if (_SupportedValueListKey == null)
			{
				_SupportedValueListKey = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertySupportedValueListKey");
			}
			return _SupportedValueListKey;
		}
	}

	[Field("kVTPropertySupportedValueMaximumKey", "VideoToolbox")]
	public static NSString SupportedValueMaximumKey
	{
		get
		{
			if (_SupportedValueMaximumKey == null)
			{
				_SupportedValueMaximumKey = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertySupportedValueMaximumKey");
			}
			return _SupportedValueMaximumKey;
		}
	}

	[Field("kVTPropertySupportedValueMinimumKey", "VideoToolbox")]
	public static NSString SupportedValueMinimumKey
	{
		get
		{
			if (_SupportedValueMinimumKey == null)
			{
				_SupportedValueMinimumKey = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertySupportedValueMinimumKey");
			}
			return _SupportedValueMinimumKey;
		}
	}

	[Field("kVTPropertyTypeKey", "VideoToolbox")]
	public static NSString Type
	{
		get
		{
			if (_Type == null)
			{
				_Type = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyTypeKey");
			}
			return _Type;
		}
	}
}
