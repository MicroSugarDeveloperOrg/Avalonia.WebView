namespace OpenGL;

public enum PgiVertexHints
{
	Vertex23BitPgi = 4,
	Vertex4BitPgi = 8,
	Color3BitPgi = 65536,
	Color4BitPgi = 131072,
	EdgeflagBitPgi = 262144,
	IndexBitPgi = 524288,
	MatAmbientBitPgi = 1048576,
	MatAmbientAndDiffuseBitPgi = 2097152,
	MatDiffuseBitPgi = 4194304,
	MatEmissionBitPgi = 8388608,
	MatColorIndexesBitPgi = 16777216,
	MatShininessBitPgi = 33554432,
	MatSpecularBitPgi = 67108864,
	NormalBitPgi = 134217728,
	Texcoord1BitPgi = 268435456,
	VertexDataHintPgi = 107050,
	VertexConsistentHintPgi = 107051,
	MaterialSideHintPgi = 107052,
	MaxVertexHintPgi = 107053,
	Texcoord2BitPgi = 536870912,
	Texcoord3BitPgi = 1073741824,
	Texcoord4BitPgi = int.MinValue
}
