using ObjCRuntime;

namespace CoreGraphics;

[iOS(10, 0)]
[TV(10, 0)]
[Watch(3, 0)]
[Mac(10, 12)]
public struct GColorConversionInfoTriple
{
	public CGColorSpace Space;

	public CGColorConversionInfoTransformType Transform;

	public CGColorRenderingIntent Intent;
}
