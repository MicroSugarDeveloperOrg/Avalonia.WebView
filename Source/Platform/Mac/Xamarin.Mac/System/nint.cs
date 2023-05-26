using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System;

[Serializable]
[DebuggerDisplay("{v,nq}")]
public struct nint : IFormattable, IConvertible, IComparable, IComparable<nint>, IEquatable<nint>
{
    public static readonly int Size = 8;

    public static readonly nint MaxValue = (nint)long.MaxValue;

    public static readonly nint MinValue = (nint)long.MinValue;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal long v;

    internal nint(nint v)
    {
        this.v = v.v;
    }

    public nint(int v)
    {
        this.v = v;
    }

    public nint(long v)
    {
        this.v = v;
    }

    public static explicit operator nint(nuint v)
    {
        return new nint((long)v.v);
    }

    public static explicit operator nuint(nint v)
    {
        return new nuint((ulong)v.v);
    }

    public static explicit operator nint(nfloat v)
    {
        return new nint((long)v.v);
    }

    public static implicit operator nfloat(nint v)
    {
        return new nfloat((double)v.v);
    }

    public unsafe static explicit operator nint(IntPtr v)
    {
        return new nint(*(long*)(&v));
    }

    public unsafe static explicit operator IntPtr(nint v)
    {
        return *(IntPtr*)(&v.v);
    }

    public static implicit operator nint(sbyte v)
    {
        return new nint((long)v);
    }

    public static explicit operator sbyte(nint v)
    {
        return (sbyte)v.v;
    }

    public static implicit operator nint(byte v)
    {
        return new nint((long)v);
    }

    public static explicit operator byte(nint v)
    {
        return (byte)v.v;
    }

    public static implicit operator nint(char v)
    {
        return new nint((long)v);
    }

    public static explicit operator char(nint v)
    {
        return (char)v.v;
    }

    public static implicit operator nint(short v)
    {
        return new nint((long)v);
    }

    public static explicit operator short(nint v)
    {
        return (short)v.v;
    }

    public static explicit operator nint(ushort v)
    {
        return new nint((long)v);
    }

    public static explicit operator ushort(nint v)
    {
        return (ushort)v.v;
    }

    public static implicit operator nint(int v)
    {
        return new nint((long)v);
    }

    public static explicit operator int(nint v)
    {
        return (int)v.v;
    }

    public static explicit operator nint(uint v)
    {
        return new nint(v);
    }

    public static explicit operator uint(nint v)
    {
        return (uint)v.v;
    }

    public static explicit operator nint(long v)
    {
        return new nint(v);
    }

    public static implicit operator long(nint v)
    {
        return v.v;
    }

    public static explicit operator nint(ulong v)
    {
        return new nint((long)v);
    }

    public static explicit operator ulong(nint v)
    {
        return (ulong)v.v;
    }

    public static explicit operator nint(float v)
    {
        return new nint((long)v);
    }

    public static implicit operator float(nint v)
    {
        return v.v;
    }

    public static explicit operator nint(double v)
    {
        return new nint((long)v);
    }

    public static implicit operator double(nint v)
    {
        return v.v;
    }

    public static explicit operator nint(decimal v)
    {
        return new nint((long)v);
    }

    public static implicit operator decimal(nint v)
    {
        return v.v;
    }

    public static nint operator +(nint v)
    {
        return new nint(v.v);
    }

    public static nint operator -(nint v)
    {
        return new nint(-v.v);
    }

    public static nint operator ~(nint v)
    {
        return new nint(~v.v);
    }

    public static nint operator ++(nint v)
    {
        return new nint(v.v + 1);
    }

    public static nint operator --(nint v)
    {
        return new nint(v.v - 1);
    }

    public static nint operator +(nint l, nint r)
    {
        return new nint(l.v + r.v);
    }

    public static nint operator -(nint l, nint r)
    {
        return new nint(l.v - r.v);
    }

    public static nint operator *(nint l, nint r)
    {
        return new nint(l.v * r.v);
    }

    public static nint operator /(nint l, nint r)
    {
        return new nint(l.v / r.v);
    }

    public static nint operator %(nint l, nint r)
    {
        return new nint(l.v % r.v);
    }

    public static nint operator &(nint l, nint r)
    {
        return new nint(l.v & r.v);
    }

    public static nint operator |(nint l, nint r)
    {
        return new nint(l.v | r.v);
    }

    public static nint operator ^(nint l, nint r)
    {
        return new nint(l.v ^ r.v);
    }

    public static nint operator <<(nint l, int r)
    {
        return new nint(l.v << r);
    }

    public static nint operator >>(nint l, int r)
    {
        return new nint(l.v >> r);
    }

    public static bool operator ==(nint l, nint r)
    {
        return l.v == r.v;
    }

    public static bool operator !=(nint l, nint r)
    {
        return l.v != r.v;
    }

    public static bool operator <(nint l, nint r)
    {
        return l.v < r.v;
    }

    public static bool operator >(nint l, nint r)
    {
        return l.v > r.v;
    }

    public static bool operator <=(nint l, nint r)
    {
        return l.v <= r.v;
    }

    public static bool operator >=(nint l, nint r)
    {
        return l.v >= r.v;
    }

    public int CompareTo(nint value)
    {
        return v.CompareTo(value.v);
    }

    public int CompareTo(object value)
    {
        if (value is nint)
        {
            return v.CompareTo(((nint)value).v);
        }
        return v.CompareTo(value);
    }

    public bool Equals(nint obj)
    {
        return v.Equals(obj.v);
    }

    public override bool Equals(object obj)
    {
        if (obj is nint)
        {
            return v.Equals(((nint)obj).v);
        }
        return v.Equals(obj);
    }

    public override int GetHashCode()
    {
        return v.GetHashCode();
    }

    public static nint Parse(string s, IFormatProvider provider)
    {
        return (nint)long.Parse(s, provider);
    }

    public static nint Parse(string s, NumberStyles style)
    {
        return (nint)long.Parse(s, style);
    }

    public static nint Parse(string s)
    {
        return (nint)long.Parse(s);
    }

    public static nint Parse(string s, NumberStyles style, IFormatProvider provider)
    {
        return (nint)long.Parse(s, style, provider);
    }

    public static bool TryParse(string s, out nint result)
    {
        long result2;
        bool result3 = long.TryParse(s, out result2);
        result = (nint)result2;
        return result3;
    }

    public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out nint result)
    {
        long result2;
        bool result3 = long.TryParse(s, style, provider, out result2);
        result = (nint)result2;
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

    public static void CopyArray(IntPtr source, nint[] destination, int startIndex, int length)
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
            destination[i + startIndex] = (nint)Marshal.ReadIntPtr(source, i * Size);
        }
    }

    public static void CopyArray(nint[] source, int startIndex, IntPtr destination, int length)
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
