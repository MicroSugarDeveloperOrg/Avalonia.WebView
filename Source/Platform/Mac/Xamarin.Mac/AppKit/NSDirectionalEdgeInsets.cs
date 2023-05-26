using Foundation;
using ObjCRuntime;

namespace AppKit;

[Watch(4, 0)]
[TV(11, 0)]
[iOS(11, 0)]
public struct NSDirectionalEdgeInsets
{
    [Field("NSDirectionalEdgeInsetsZero")]
    public static readonly NSDirectionalEdgeInsets Zero;

    public nfloat Top;

    public nfloat Leading;

    public nfloat Bottom;

    public nfloat Trailing;

    public NSDirectionalEdgeInsets(nfloat top, nfloat leading, nfloat bottom, nfloat trailing)
    {
        Top = top;
        Leading = leading;
        Bottom = bottom;
        Trailing = trailing;
    }

    public bool Equals(NSDirectionalEdgeInsets other)
    {
        if (Leading != other.Leading)
        {
            return false;
        }
        if (Trailing != other.Trailing)
        {
            return false;
        }
        if (Top != other.Top)
        {
            return false;
        }
        return Bottom == other.Bottom;
    }

    public override bool Equals(object obj)
    {
        if (obj is NSDirectionalEdgeInsets)
        {
            return Equals((NSDirectionalEdgeInsets)obj);
        }
        return false;
    }

    public static bool operator ==(NSDirectionalEdgeInsets insets1, NSDirectionalEdgeInsets insets2)
    {
        return insets1.Equals(insets2);
    }

    public static bool operator !=(NSDirectionalEdgeInsets insets1, NSDirectionalEdgeInsets insets2)
    {
        return !insets1.Equals(insets2);
    }

    public override int GetHashCode()
    {
        return Top.GetHashCode() ^ Leading.GetHashCode() ^ Trailing.GetHashCode() ^ Bottom.GetHashCode();
    }
}