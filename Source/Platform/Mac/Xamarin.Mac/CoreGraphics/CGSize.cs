using Foundation;
using System.Globalization;
using System.Runtime.InteropServices;

namespace CoreGraphics;

[Serializable]
public struct CGSize : IEquatable<CGSize>
{
    public static readonly CGSize Empty;

    private nfloat width;

    private nfloat height;

    public nfloat Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }

    public nfloat Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public bool IsEmpty => (double)width == 0.0 && (double)height == 0.0;

    public static bool operator ==(CGSize l, CGSize r)
    {
        return l.width == r.width && l.height == r.height;
    }

    public static bool operator !=(CGSize l, CGSize r)
    {
        return l.width != r.width || l.height != r.height;
    }

    public static CGSize operator +(CGSize l, CGSize r)
    {
        return new CGSize(l.width + r.Width, l.height + r.Height);
    }

    public static CGSize operator -(CGSize l, CGSize r)
    {
        return new CGSize(l.width - r.Width, l.height - r.Height);
    }

    public static explicit operator CGPoint(CGSize size)
    {
        return new CGPoint(size.Width, size.Height);
    }

    public static CGSize Add(CGSize size1, CGSize size2)
    {
        return size1 + size2;
    }

    public static CGSize Subtract(CGSize size1, CGSize size2)
    {
        return size1 - size2;
    }

    public CGSize(nfloat width, nfloat height)
    {
        this.width = width;
        this.height = height;
    }

    public CGSize(double width, double height)
    {
        this.width = (nfloat)width;
        this.height = (nfloat)height;
    }

    public CGSize(float width, float height)
    {
        this.width = width;
        this.height = height;
    }

    public CGSize(CGSize size)
    {
        width = size.width;
        height = size.height;
    }

    public static bool TryParse(NSDictionary dictionaryRepresentation, out CGSize size)
    {
        if (dictionaryRepresentation == null)
        {
            size = Empty;
            return false;
        }
        return NativeDrawingMethods.CGSizeMakeWithDictionaryRepresentation(dictionaryRepresentation.Handle, out size);
    }

    public NSDictionary ToDictionary()
    {
        return new NSDictionary(NativeDrawingMethods.CGSizeCreateDictionaryRepresentation(this));
    }

    public CGSize(CGPoint point)
    {
        width = point.X;
        height = point.Y;
    }

    public override bool Equals(object obj)
    {
        if (obj is CGSize)
        {
            return this == (CGSize)obj;
        }
        return false;
    }

    public bool Equals(CGSize size)
    {
        return this == size;
    }

    public override int GetHashCode()
    {
        int num = 23;
        num = num * 31 + width.GetHashCode();
        return num * 31 + height.GetHashCode();
    }

    public CGSize ToRoundedCGSize()
    {
        return new CGSize((nfloat)Math.Round(width), (nfloat)Math.Round(height));
    }

    [Obsolete("Use 'ToRoundedCGSize' instead.")]
    public CGSize ToSize()
    {
        return ToRoundedCGSize();
    }

    [Obsolete("Use 'ToCGPoint' instead.")]
    public CGPoint ToPointF()
    {
        return (CGPoint)this;
    }

    public CGPoint ToCGPoint()
    {
        return (CGPoint)this;
    }

    public override string ToString()
    {
        return $"{{Width={width.ToString(CultureInfo.CurrentCulture)}, Height={height.ToString(CultureInfo.CurrentCulture)}}}";
    }
}
