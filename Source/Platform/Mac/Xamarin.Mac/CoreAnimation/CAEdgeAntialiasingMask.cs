using System;

namespace CoreAnimation;

[Flags]
public enum CAEdgeAntialiasingMask
{
	LeftEdge = 1,
	RightEdge = 2,
	BottomEdge = 4,
	TopEdge = 8,
	All = 0xF,
	LeftRightEdges = 3,
	TopBottomEdges = 0xC
}
