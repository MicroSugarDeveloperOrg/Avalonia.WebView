using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSViewLayerContentsRedrawPolicy : long
{
	Never,
	OnSetNeedsDisplay,
	DuringViewResize,
	BeforeViewResize
}
