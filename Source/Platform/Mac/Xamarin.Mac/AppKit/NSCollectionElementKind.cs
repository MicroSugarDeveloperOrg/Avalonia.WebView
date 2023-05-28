using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSCollectionElementKind
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InterItemGapIndicator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SectionFooter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SectionHeader;

	[Field("NSCollectionElementKindInterItemGapIndicator", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString InterItemGapIndicator
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_InterItemGapIndicator == null)
			{
				_InterItemGapIndicator = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCollectionElementKindInterItemGapIndicator");
			}
			return _InterItemGapIndicator;
		}
	}

	[Field("NSCollectionElementKindSectionFooter", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString SectionFooter
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_SectionFooter == null)
			{
				_SectionFooter = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCollectionElementKindSectionFooter");
			}
			return _SectionFooter;
		}
	}

	[Field("NSCollectionElementKindSectionHeader", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString SectionHeader
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_SectionHeader == null)
			{
				_SectionHeader = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCollectionElementKindSectionHeader");
			}
			return _SectionHeader;
		}
	}
}
