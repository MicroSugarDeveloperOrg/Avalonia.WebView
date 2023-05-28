using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreAnimation;

public class CARendererOptions : DictionaryContainer
{
	public CGColorSpace? ColorSpace
	{
		get
		{
			return GetNativeValue<CGColorSpace>(CARendererOptionKeys.ColorSpace);
		}
		set
		{
			SetNativeValue(CARendererOptionKeys.ColorSpace, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public IMTLCommandQueue? MetalCommandQueue
	{
		get
		{
			return base.Dictionary[CARendererOptionKeys.MetalCommandQueue] as IMTLCommandQueue;
		}
		set
		{
			SetNativeValue(CARendererOptionKeys.MetalCommandQueue, value);
		}
	}

	[Preserve(Conditional = true)]
	public CARendererOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CARendererOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
