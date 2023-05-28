using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
internal static class MLModelMetadataKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreatorDefinedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LicenseKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VersionStringKey;

	[Field("MLModelAuthorKey", "CoreML")]
	public static NSString AuthorKey
	{
		get
		{
			if (_AuthorKey == null)
			{
				_AuthorKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLModelAuthorKey");
			}
			return _AuthorKey;
		}
	}

	[Field("MLModelCreatorDefinedKey", "CoreML")]
	public static NSString CreatorDefinedKey
	{
		get
		{
			if (_CreatorDefinedKey == null)
			{
				_CreatorDefinedKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLModelCreatorDefinedKey");
			}
			return _CreatorDefinedKey;
		}
	}

	[Field("MLModelDescriptionKey", "CoreML")]
	public static NSString DescriptionKey
	{
		get
		{
			if (_DescriptionKey == null)
			{
				_DescriptionKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLModelDescriptionKey");
			}
			return _DescriptionKey;
		}
	}

	[Field("MLModelLicenseKey", "CoreML")]
	public static NSString LicenseKey
	{
		get
		{
			if (_LicenseKey == null)
			{
				_LicenseKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLModelLicenseKey");
			}
			return _LicenseKey;
		}
	}

	[Field("MLModelVersionStringKey", "CoreML")]
	public static NSString VersionStringKey
	{
		get
		{
			if (_VersionStringKey == null)
			{
				_VersionStringKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLModelVersionStringKey");
			}
			return _VersionStringKey;
		}
	}
}
