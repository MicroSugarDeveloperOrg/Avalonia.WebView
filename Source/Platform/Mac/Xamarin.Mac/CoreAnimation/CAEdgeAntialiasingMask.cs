using System;

namespace CoreAnimation;

[Flags]
public enum CAEdgeAntialiasingMask : uint
{
	LeftEdge = 1u,
	RightEdge = 2u,
	BottomEdge = 4u,
	TopEdge = 8u,
	All = 0xFu,
	LeftRightEdges = 3u,
	TopBottomEdges = 0xCu
}
