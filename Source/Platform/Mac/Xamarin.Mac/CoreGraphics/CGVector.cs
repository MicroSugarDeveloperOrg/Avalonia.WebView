namespace CoreGraphics;

public struct CGVector
{
    public nfloat dx;

    public nfloat dy;

    public CGVector(nfloat dx, nfloat dy)
    {
        this.dx = dx;
        this.dy = dy;
    }

    public static bool operator ==(CGVector left, CGVector right)
    {
        return left.dx == right.dx && left.dy == right.dy;
    }

    public static bool operator !=(CGVector left, CGVector right)
    {
        return left.dx != right.dx || left.dy != right.dy;
    }

    public override int GetHashCode()
    {
        return (int)dx ^ (int)dy;
    }

    public override bool Equals(object other)
    {
        if (other == null || !(other is CGVector))
        {
            return false;
        }
        CGVector cGVector = (CGVector)other;
        return cGVector.dx == dx && cGVector.dy == dy;
    }
}
