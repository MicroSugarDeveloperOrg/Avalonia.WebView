namespace AppKit;

public enum NSViewLayerContentsRedrawPolicy : long
{
	Never,
	OnSetNeedsDisplay,
	DuringViewResize,
	BeforeViewResize
}
