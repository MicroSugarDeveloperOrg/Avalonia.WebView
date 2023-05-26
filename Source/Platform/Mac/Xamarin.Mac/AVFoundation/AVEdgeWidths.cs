namespace AVFoundation;

public struct AVEdgeWidths
{
    public nfloat Left;

    public nfloat Top;

    public nfloat Right;

    public nfloat Bottom;

    public AVEdgeWidths(nfloat left, nfloat top, nfloat right, nfloat bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    public override string ToString()
    {
        return $"(left={Left},top={Top},right={Right},bottom={Bottom})";
    }

    public static bool operator ==(AVEdgeWidths left, AVEdgeWidths right)
    {
        return left.Left == right.Left && left.Top == right.Top && left.Right == right.Right && left.Bottom == right.Bottom;
    }

    public static bool operator !=(AVEdgeWidths left, AVEdgeWidths right)
    {
        return left.Left != right.Left || left.Top != right.Top || left.Right != right.Right || left.Bottom != right.Bottom;
    }

    public override int GetHashCode()
    {
        return (int)Left ^ (int)Top ^ (int)Right ^ (int)Bottom;
    }

    public override bool Equals(object other)
    {
        if (other is AVEdgeWidths aVEdgeWidths)
        {
            return this == aVEdgeWidths;
        }
        return false;
    }
}