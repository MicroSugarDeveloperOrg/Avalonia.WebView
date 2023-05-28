using OpenTK;

namespace ModelIO;

public struct MDLVoxelIndexExtent2
{
	public Vector4i MinimumExtent { get; private set; }

	public Vector4i MaximumExtent { get; private set; }

	public MDLVoxelIndexExtent2(Vector4i minimumExtent, Vector4i maximumExtent)
	{
		MinimumExtent = minimumExtent;
		MaximumExtent = maximumExtent;
	}
}
