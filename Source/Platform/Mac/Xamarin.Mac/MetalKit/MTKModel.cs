using Foundation;
using ObjCRuntime;

namespace MetalKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class MTKModel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorKey;

	[Field("MTKModelErrorDomain", "MetalKit")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKModelErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("MTKModelErrorKey", "MetalKit")]
	public static NSString ErrorKey
	{
		get
		{
			if (_ErrorKey == null)
			{
				_ErrorKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKModelErrorKey");
			}
			return _ErrorKey;
		}
	}
}
