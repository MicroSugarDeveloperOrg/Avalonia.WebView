using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public static class NSJavaScriptExtension
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FinalizeArgumentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreprocessingResultsKey;

	[Field("NSExtensionJavaScriptFinalizeArgumentKey", "Foundation")]
	public static NSString FinalizeArgumentKey
	{
		get
		{
			if (_FinalizeArgumentKey == null)
			{
				_FinalizeArgumentKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSExtensionJavaScriptFinalizeArgumentKey");
			}
			return _FinalizeArgumentKey;
		}
	}

	[Field("NSExtensionJavaScriptPreprocessingResultsKey", "Foundation")]
	public static NSString PreprocessingResultsKey
	{
		get
		{
			if (_PreprocessingResultsKey == null)
			{
				_PreprocessingResultsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSExtensionJavaScriptPreprocessingResultsKey");
			}
			return _PreprocessingResultsKey;
		}
	}
}
