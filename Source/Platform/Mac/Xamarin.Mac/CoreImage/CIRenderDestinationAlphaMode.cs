using ObjCRuntime;

namespace CoreImage;

[iOS(11, 0)]
[Mac(10, 13)]
[TV(11, 0)]
[Native]
public enum CIRenderDestinationAlphaMode : ulong
{
	None,
	Premultiplied,
	Unpremultiplied
}
