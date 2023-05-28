using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public static class NSAccessibilityAnnotationAttributeKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationElement;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationLabel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationLocation;

	[Field("NSAccessibilityAnnotationElement", "AppKit")]
	public static NSString AnnotationElement
	{
		get
		{
			if (_AnnotationElement == null)
			{
				_AnnotationElement = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnotationElement");
			}
			return _AnnotationElement;
		}
	}

	[Field("NSAccessibilityAnnotationLabel", "AppKit")]
	public static NSString AnnotationLabel
	{
		get
		{
			if (_AnnotationLabel == null)
			{
				_AnnotationLabel = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnotationLabel");
			}
			return _AnnotationLabel;
		}
	}

	[Field("NSAccessibilityAnnotationLocation", "AppKit")]
	public static NSString AnnotationLocation
	{
		get
		{
			if (_AnnotationLocation == null)
			{
				_AnnotationLocation = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnotationLocation");
			}
			return _AnnotationLocation;
		}
	}
}
