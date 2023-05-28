using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSColorRenderingIntent : long
{
	Default,
	AbsoluteColorimetric,
	RelativeColorimetric,
	Perceptual,
	Saturation
}
