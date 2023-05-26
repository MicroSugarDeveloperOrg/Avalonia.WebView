namespace MapKit;

public struct MKMapSize
{
    public double Width;

    public double Height;

    [TV(9, 2)]
    public static MKMapSize World => new MKMapSize(268435456.0, 268435456.0);

    public MKMapSize(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public static bool operator ==(MKMapSize a, MKMapSize b)
    {
        return a.Width == b.Width && a.Height == b.Height;
    }

    public static bool operator !=(MKMapSize a, MKMapSize b)
    {
        return a.Width != b.Width || a.Height != b.Height;
    }

    public override bool Equals(object other)
    {
        if (other is MKMapSize mKMapSize)
        {
            return mKMapSize.Width == Width && mKMapSize.Height == Height;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (int)(Width + Height);
    }

    public override string ToString()
    {
        return $"{{{Width}, {Height}}}";
    }
}