using Foundation;
using System.Globalization;
using System.Runtime.InteropServices;

namespace CoreGraphics;

[Serializable]
public struct CGPoint : IEquatable<CGPoint>
{
    public static readonly CGPoint Empty;

    private nfloat x;

    private nfloat y;

    public nfloat X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }

    public nfloat Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }

    public bool IsEmpty => (double)x == 0.0 && (double)y == 0.0;

    public static bool operator ==(CGPoint l, CGPoint r)
    {
        return l.x == r.x && l.y == r.y;
    }

    public static bool operator !=(CGPoint l, CGPoint r)
    {
        return l.x != r.x || l.y != r.y;
    }

    public static CGPoint operator +(CGPoint l, CGSize r)
    {
        return new CGPoint(l.x + r.Width, l.y + r.Height);
    }

    public static CGPoint operator -(CGPoint l, CGSize r)
    {
        return new CGPoint(l.x - r.Width, l.y - r.Height);
    }

    public static CGPoint Add(CGPoint point, CGSize size)
    {
        return point + size;
    }

    public static CGPoint Subtract(CGPoint point, CGSize size)
    {
        return point - size;
    }

    public CGPoint(nfloat x, nfloat y)
    {
        this.x = x;
        this.y = y;
    }

    public CGPoint(double x, double y)
    {
        this.x = (nfloat)x;
        this.y = (nfloat)y;
    }

    public CGPoint(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public CGPoint(CGPoint point)
    {
        x = point.x;
        y = point.y;
    }

    public static bool TryParse(NSDictionary dictionaryRepresentation, out CGPoint point)
    {
        if (dictionaryRepresentation == null)
        {
            point = Empty;
            return false;
        }
        return NativeDrawingMethods.CGPointMakeWithDictionaryRepresentation(dictionaryRepresentation.Handle, out point);
    }

    public NSDictionary ToDictionary()
    {
        return new NSDictionary(NativeDrawingMethods.CGPointCreateDictionaryRepresentation(this));
    }

    public override bool Equals(object obj)
    {
        if (obj is CGPoint)
        {
            return this == (CGPoint)obj;
        }
        return false;
    }

    public bool Equals(CGPoint point)
    {
        return this == point;
    }

    public override int GetHashCode()
    {
        int num = 23;
        num = num * 31 + x.GetHashCode();
        return num * 31 + y.GetHashCode();
    }

    public override string ToString()
    {
        return $"{{X={x.ToString(CultureInfo.CurrentCulture)}, Y={y.ToString(CultureInfo.CurrentCulture)}}}";
    }
}
