namespace CoreGraphics;

public enum CGEventType : uint
{
	Null = 0u,
	LeftMouseDown = 1u,
	LeftMouseUp = 2u,
	RightMouseDown = 3u,
	RightMouseUp = 4u,
	MouseMoved = 5u,
	LeftMouseDragged = 6u,
	RightMouseDragged = 7u,
	KeyDown = 10u,
	KeyUp = 11u,
	FlagsChanged = 12u,
	ScrollWheel = 22u,
	TabletPointer = 23u,
	TabletProximity = 24u,
	OtherMouseDown = 25u,
	OtherMouseUp = 26u,
	OtherMouseDragged = 27u
}
