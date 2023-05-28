using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum SKTileAdjacencyMask : ulong
{
	Up = 1uL,
	UpperRight = 2uL,
	Right = 4uL,
	LowerRight = 8uL,
	Down = 16uL,
	LowerLeft = 32uL,
	Left = 64uL,
	UpperLeft = 128uL,
	All = 255uL,
	HexFlatUp = 1uL,
	HexFlatUpperRight = 2uL,
	HexFlatLowerRight = 4uL,
	HexFlatDown = 8uL,
	HexFlatLowerLeft = 16uL,
	HexFlatUpperLeft = 32uL,
	HexFlatAll = 63uL,
	HexPointyUpperLeft = 1uL,
	HexPointyUpperRight = 2uL,
	HexPointyRight = 4uL,
	HexPointyLowerRight = 8uL,
	HexPointyLowerLeft = 16uL,
	HexPointyLeft = 32uL,
	HexPointyAll = 63uL,
	UpEdge = 124uL,
	UpperRightEdge = 112uL,
	RightEdge = 241uL,
	LowerRightEdge = 193uL,
	DownEdge = 199uL,
	LowerLeftEdge = 7uL,
	LeftEdge = 31uL,
	UpperLeftEdge = 28uL,
	UpperRightCorner = 223uL,
	LowerRightCorner = 127uL,
	LowerLeftCorner = 253uL,
	UpperLeftCorner = 247uL
}
