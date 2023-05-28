using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
internal static class CGPDFOutlineKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AccessPermissionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationRectKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutlineChildrenKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutlineDestinationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutlineTitleKey;

	[Field("kCGPDFContextAccessPermissions", "CoreGraphics")]
	internal static NSString AccessPermissionsKey
	{
		get
		{
			if (_AccessPermissionsKey == null)
			{
				_AccessPermissionsKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFContextAccessPermissions");
			}
			return _AccessPermissionsKey;
		}
	}

	[Field("kCGPDFOutlineDestinationRect", "CoreGraphics")]
	internal static NSString DestinationRectKey
	{
		get
		{
			if (_DestinationRectKey == null)
			{
				_DestinationRectKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFOutlineDestinationRect");
			}
			return _DestinationRectKey;
		}
	}

	[Field("kCGPDFOutlineChildren", "CoreGraphics")]
	internal static NSString OutlineChildrenKey
	{
		get
		{
			if (_OutlineChildrenKey == null)
			{
				_OutlineChildrenKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFOutlineChildren");
			}
			return _OutlineChildrenKey;
		}
	}

	[Field("kCGPDFOutlineDestination", "CoreGraphics")]
	internal static NSString OutlineDestinationKey
	{
		get
		{
			if (_OutlineDestinationKey == null)
			{
				_OutlineDestinationKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFOutlineDestination");
			}
			return _OutlineDestinationKey;
		}
	}

	[Field("kCGPDFOutlineTitle", "CoreGraphics")]
	internal static NSString OutlineTitleKey
	{
		get
		{
			if (_OutlineTitleKey == null)
			{
				_OutlineTitleKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFOutlineTitle");
			}
			return _OutlineTitleKey;
		}
	}
}
