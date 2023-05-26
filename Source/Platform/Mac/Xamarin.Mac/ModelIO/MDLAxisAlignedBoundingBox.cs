using OpenTK;

namespace ModelIO;

public struct MDLAxisAlignedBoundingBox
{
    public Vector3 MaxBounds;

    public Vector3 MinBounds;

    public MDLAxisAlignedBoundingBox(Vector3 maxBounds, Vector3 minBounds)
    {
        MaxBounds = maxBounds;
        MinBounds = minBounds;
    }
}
