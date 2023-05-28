using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAppearanceCustomizationWrapper : BaseWrapper, INSAppearanceCustomization, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSAppearanceCustomizationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
