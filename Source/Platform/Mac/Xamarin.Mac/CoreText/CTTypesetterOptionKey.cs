using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTTypesetterOptionKey
{
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	public static readonly NSString DisableBidiProcessing = _DisableBidiProcessing;

	public static readonly NSString ForceEmbeddingLevel = _ForceEmbeddingLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowUnboundedLayout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __DisableBidiProcessing;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __ForceEmbeddingLevel;

	[Field("kCTTypesetterOptionAllowUnboundedLayout", "CoreText")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString AllowUnboundedLayout
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowUnboundedLayout == null)
			{
				_AllowUnboundedLayout = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTTypesetterOptionAllowUnboundedLayout");
			}
			return _AllowUnboundedLayout;
		}
	}

	[Field("kCTTypesetterOptionDisableBidiProcessing", "CoreText")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	internal static NSString _DisableBidiProcessing
	{
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
		get
		{
			if (__DisableBidiProcessing == null)
			{
				__DisableBidiProcessing = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTTypesetterOptionDisableBidiProcessing");
			}
			return __DisableBidiProcessing;
		}
	}

	[Field("kCTTypesetterOptionForcedEmbeddingLevel", "CoreText")]
	internal static NSString _ForceEmbeddingLevel
	{
		get
		{
			if (__ForceEmbeddingLevel == null)
			{
				__ForceEmbeddingLevel = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTTypesetterOptionForcedEmbeddingLevel");
			}
			return __ForceEmbeddingLevel;
		}
	}
}
