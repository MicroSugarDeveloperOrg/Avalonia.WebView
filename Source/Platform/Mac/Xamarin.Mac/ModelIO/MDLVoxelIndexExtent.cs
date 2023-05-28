using System;
using OpenTK;

namespace ModelIO;

[Obsolete("Use 'MDLVoxelIndexExtent2' instead.")]
public struct MDLVoxelIndexExtent
{
	public Vector4 MinimumExtent;

	public Vector4 MaximumExtent;

	public MDLVoxelIndexExtent(Vector4 minimumExtent, Vector4 maximumExtent)
	{
		MinimumExtent = minimumExtent;
		MaximumExtent = maximumExtent;
	}
}
