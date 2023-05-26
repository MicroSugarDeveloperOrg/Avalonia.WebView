namespace AVFoundation;

public struct AVPixelAspectRatio
{
    public nint HorizontalSpacing;

    public nint VerticalSpacing;

    public AVPixelAspectRatio(nint horizontalSpacing, nint verticalSpacing)
    {
        HorizontalSpacing = horizontalSpacing;
        VerticalSpacing = verticalSpacing;
    }

    public override string ToString()
    {
        return $"(horizontalSpacing={HorizontalSpacing}, verticalSpacing={VerticalSpacing})";
    }

    public static bool operator ==(AVPixelAspectRatio left, AVPixelAspectRatio right)
    {
        return left.HorizontalSpacing == right.HorizontalSpacing && left.VerticalSpacing == right.VerticalSpacing;
    }

    public static bool operator !=(AVPixelAspectRatio left, AVPixelAspectRatio right)
    {
        return left.HorizontalSpacing != right.HorizontalSpacing || left.VerticalSpacing != right.VerticalSpacing;
    }

    public override int GetHashCode()
    {
        return (int)HorizontalSpacing ^ (int)VerticalSpacing;
    }

    public override bool Equals(object other)
    {
        if (other is AVPixelAspectRatio aVPixelAspectRatio)
        {
            return aVPixelAspectRatio.HorizontalSpacing == HorizontalSpacing && aVPixelAspectRatio.VerticalSpacing == VerticalSpacing;
        }
        return false;
    }
}