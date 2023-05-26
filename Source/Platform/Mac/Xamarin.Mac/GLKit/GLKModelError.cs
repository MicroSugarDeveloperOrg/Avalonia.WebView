using Foundation;
using ObjCRuntime;

namespace GLKit;

[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class GLKModelError
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Domain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Key;

	[Field("kGLKModelErrorDomain", "GLKit")]
	public static NSString Domain
	{
		get
		{
			if (_Domain == null)
			{
				_Domain = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "kGLKModelErrorDomain");
			}
			return _Domain;
		}
	}

	[Field("kGLKModelErrorKey", "GLKit")]
	public static NSString Key
	{
		get
		{
			if (_Key == null)
			{
				_Key = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "kGLKModelErrorKey");
			}
			return _Key;
		}
	}
}
