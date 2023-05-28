using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Xamarin.Mac.System.Mac;

[Serializable]
[DebuggerDisplay("{v,nq}")]
public struct nuint : IFormattable, IConvertible, IComparable, IComparable<nuint>, IEquatable<nuint>
{
    public static readonly int Size = 8;

    public static readonly nuint MaxValue = (nuint)ulong.MaxValue;

    public static readonly nuint MinValue = (nuint)0uL;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal ulong v;

    internal nuint(nuint v)
    {
        this.v = v.v;
    }

    public nuint(uint v)
    {
        this.v = v;
    }

    public nuint(ulong v)
    {
        this.v = v;
    }

    public static explicit operator nuint(nfloat v)
    {
        return new nuint((ulong)v.v);
    }

    public static implicit operator nfloat(nuint v)
    {
        return new nfloat((double)v.v);
    }

    public unsafe static explicit operator nuint(IntPtr v)
    {
        return new nuint(*(ulong*)&v);
    }

    public unsafe static explicit operator IntPtr(nuint v)
    {
        return *(IntPtr*)&v.v;
    }

    public static explicit operator nuint(sbyte v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator sbyte(nuint v)
    {
        return (sbyte)v.v;
    }

    public static implicit operator nuint(byte v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator byte(nuint v)
    {
        return (byte)v.v;
    }

    public static implicit operator nuint(char v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator char(nuint v)
    {
        return (char)v.v;
    }

    public static explicit operator nuint(short v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator short(nuint v)
    {
        return (short)v.v;
    }

    public static implicit operator nuint(ushort v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator ushort(nuint v)
    {
        return (ushort)v.v;
    }

    public static explicit operator nuint(int v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator int(nuint v)
    {
        return (int)v.v;
    }

    public static implicit operator nuint(uint v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator uint(nuint v)
    {
        return (uint)v.v;
    }

    public static explicit operator nuint(long v)
    {
        return new nuint((ulong)v);
    }

    public static explicit operator long(nuint v)
    {
        return (long)v.v;
    }

    public static explicit operator nuint(ulong v)
    {
        return new nuint(v);
    }

    public static implicit operator ulong(nuint v)
    {
        return v.v;
    }

    public static explicit operator nuint(float v)
    {
        return new nuint((ulong)v);
    }

    public static implicit operator float(nuint v)
    {
        return v.v;
    }

    public static explicit operator nuint(double v)
    {
        return new nuint((ulong)v);
    }

    public static implicit operator double(nuint v)
    {
        return v.v;
    }

    public static explicit operator nuint(decimal v)
    {
        return new nuint((ulong)v);
    }

    public static implicit operator decimal(nuint v)
    {
        return v.v;
    }

    public static nuint operator +(nuint v)
    {
        return new nuint(v.v);
    }

    public static nuint operator ~(nuint v)
    {
        return new nuint(~v.v);
    }

    public static nuint operator ++(nuint v)
    {
        return new nuint(v.v + 1);
    }

    public static nuint operator --(nuint v)
    {
        return new nuint(v.v - 1);
    }

    public static nuint operator +(nuint l, nuint r)
    {
        return new nuint(l.v + r.v);
    }

    public static nuint operator -(nuint l, nuint r)
    {
        return new nuint(l.v - r.v);
    }

    public static nuint operator *(nuint l, nuint r)
    {
        return new nuint(l.v * r.v);
    }

    public static nuint operator /(nuint l, nuint r)
    {
        return new nuint(l.v / r.v);
    }

    public static nuint operator %(nuint l, nuint r)
    {
        return new nuint(l.v % r.v);
    }

    public static nuint operator &(nuint l, nuint r)
    {
        return new nuint(l.v & r.v);
    }

    public static nuint operator |(nuint l, nuint r)
    {
        return new nuint(l.v | r.v);
    }

    public static nuint operator ^(nuint l, nuint r)
    {
        return new nuint(l.v ^ r.v);
    }

    public static nuint operator <<(nuint l, int r)
    {
        return new nuint(l.v << r);
    }

    public static nuint operator >>(nuint l, int r)
    {
        return new nuint(l.v >> r);
    }

    public static bool operator ==(nuint l, nuint r)
    {
        return l.v == r.v;
    }

    public static bool operator !=(nuint l, nuint r)
    {
        return l.v != r.v;
    }

    public static bool operator <(nuint l, nuint r)
    {
        return l.v < r.v;
    }

    public static bool operator >(nuint l, nuint r)
    {
        return l.v > r.v;
    }

    public static bool operator <=(nuint l, nuint r)
    {
        return l.v <= r.v;
    }

    public static bool operator >=(nuint l, nuint r)
    {
        return l.v >= r.v;
    }

    public int CompareTo(nuint value)
    {
        return v.CompareTo(value.v);
    }

    public int CompareTo(object value)
    {
        if (value is nuint)
        {
            return v.CompareTo(((nuint)value).v);
        }
        return v.CompareTo(value);
    }

    public bool Equals(nuint obj)
    {
        return v.Equals(obj.v);
    }

    public override bool Equals(object obj)
    {
        if (obj is nuint)
        {
            return v.Equals(((nuint)obj).v);
        }
        return v.Equals(obj);
    }

    public override int GetHashCode()
    {
        return v.GetHashCode();
    }

    public static nuint Parse(string s, IFormatProvider provider)
    {
        return (nuint)ulong.Parse(s, provider);
    }

    public static nuint Parse(string s, NumberStyles style)
    {
        return (nuint)ulong.Parse(s, style);
    }

    public static nuint Parse(string s)
    {
        return (nuint)ulong.Parse(s);
    }

    public static nuint Parse(string s, NumberStyles style, IFormatProvider provider)
    {
        return (nuint)ulong.Parse(s, style, provider);
    }

    public static bool TryParse(string s, out nuint result)
    {
        ulong result2;
        bool result3 = ulong.TryParse(s, out result2);
        result = (nuint)result2;
        return result3;
    }

    public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out nuint result)
    {
        ulong result2;
        bool result3 = ulong.TryParse(s, style, provider, out result2);
        result = (nuint)result2;
        return result3;
    }

    public override string ToString()
    {
        return v.ToString();
    }

    public string ToString(IFormatProvider provider)
    {
        return v.ToString(provider);
    }

    public string ToString(string format)
    {
        return v.ToString(format);
    }

    public string ToString(string format, IFormatProvider provider)
    {
        return v.ToString(format, provider);
    }

    public TypeCode GetTypeCode()
    {
        return v.GetTypeCode();
    }

    bool IConvertible.ToBoolean(IFormatProvider provider)
    {
        return ((IConvertible)v).ToBoolean(provider);
    }

    byte IConvertible.ToByte(IFormatProvider provider)
    {
        return ((IConvertible)v).ToByte(provider);
    }

    char IConvertible.ToChar(IFormatProvider provider)
    {
        return ((IConvertible)v).ToChar(provider);
    }

    DateTime IConvertible.ToDateTime(IFormatProvider provider)
    {
        return ((IConvertible)v).ToDateTime(provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
    {
        return ((IConvertible)v).ToDecimal(provider);
    }

    double IConvertible.ToDouble(IFormatProvider provider)
    {
        return ((IConvertible)v).ToDouble(provider);
    }

    short IConvertible.ToInt16(IFormatProvider provider)
    {
        return ((IConvertible)v).ToInt16(provider);
    }

    int IConvertible.ToInt32(IFormatProvider provider)
    {
        return ((IConvertible)v).ToInt32(provider);
    }

    long IConvertible.ToInt64(IFormatProvider provider)
    {
        return ((IConvertible)v).ToInt64(provider);
    }

    sbyte IConvertible.ToSByte(IFormatProvider provider)
    {
        return ((IConvertible)v).ToSByte(provider);
    }

    float IConvertible.ToSingle(IFormatProvider provider)
    {
        return ((IConvertible)v).ToSingle(provider);
    }

    ushort IConvertible.ToUInt16(IFormatProvider provider)
    {
        return ((IConvertible)v).ToUInt16(provider);
    }

    uint IConvertible.ToUInt32(IFormatProvider provider)
    {
        return ((IConvertible)v).ToUInt32(provider);
    }

    ulong IConvertible.ToUInt64(IFormatProvider provider)
    {
        return ((IConvertible)v).ToUInt64(provider);
    }

    object IConvertible.ToType(Type targetType, IFormatProvider provider)
    {
        return ((IConvertible)v).ToType(targetType, provider);
    }

    public static void CopyArray(IntPtr source, nuint[] destination, int startIndex, int length)
    {
        if (source == IntPtr.Zero)
        {
            throw new ArgumentNullException("source");
        }
        if (destination == null)
        {
            throw new ArgumentNullException("destination");
        }
        if (destination.Rank != 1)
        {
            throw new ArgumentException("destination", "array is multi-dimensional");
        }
        if (startIndex < 0)
        {
            throw new ArgumentException("startIndex", "must be >= 0");
        }
        if (length < 0)
        {
            throw new ArgumentException("length", "must be >= 0");
        }
        if (startIndex + length > destination.Length)
        {
            throw new ArgumentException("length", "startIndex + length > destination.Length");
        }
        for (int i = 0; i < length; i++)
        {
            destination[i + startIndex] = (nuint)Marshal.ReadIntPtr(source, i * Size);
        }
    }

    public static void CopyArray(nuint[] source, int startIndex, IntPtr destination, int length)
    {
        if (source == null)
        {
            throw new ArgumentNullException("source");
        }
        if (destination == IntPtr.Zero)
        {
            throw new ArgumentNullException("destination");
        }
        if (source.Rank != 1)
        {
            throw new ArgumentException("source", "array is multi-dimensional");
        }
        if (startIndex < 0)
        {
            throw new ArgumentException("startIndex", "must be >= 0");
        }
        if (length < 0)
        {
            throw new ArgumentException("length", "must be >= 0");
        }
        if (startIndex + length > source.Length)
        {
            throw new ArgumentException("length", "startIndex + length > source.Length");
        }
        for (int i = 0; i < length; i++)
        {
            Marshal.WriteIntPtr(destination, i * Size, (IntPtr)source[i + startIndex]);
        }
    }
}
