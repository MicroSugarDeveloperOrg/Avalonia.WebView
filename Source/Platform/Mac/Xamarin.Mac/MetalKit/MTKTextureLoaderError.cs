using Foundation;
using ObjCRuntime;

namespace MetalKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class MTKTextureLoaderError
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Domain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Key;

	[Field("MTKTextureLoaderErrorDomain", "MetalKit")]
	public static NSString Domain
	{
		get
		{
			if (_Domain == null)
			{
				_Domain = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderErrorDomain");
			}
			return _Domain;
		}
	}

	[Field("MTKTextureLoaderErrorKey", "MetalKit")]
	public static NSString Key
	{
		get
		{
			if (_Key == null)
			{
				_Key = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderErrorKey");
			}
			return _Key;
		}
	}
}
