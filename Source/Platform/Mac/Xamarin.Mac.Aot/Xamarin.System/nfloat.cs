using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Xamarin.System;


[Serializable]
[DebuggerDisplay("{v,nq}")]
public struct nfloat : IFormattable, IConvertible, IComparable, IComparable<nfloat>, IEquatable<nfloat>
{
    public static readonly int Size = 8;

    public static readonly nfloat MaxValue = (nfloat)double.MaxValue;

    public static readonly nfloat MinValue = (nfloat)double.MinValue;

    public static readonly nfloat Epsilon = (nfloat)double.Epsilon;

    public static readonly nfloat NaN = (nfloat)double.NaN;

    public static readonly nfloat NegativeInfinity = (nfloat)double.NegativeInfinity;

    public static readonly nfloat PositiveInfinity = (nfloat)double.PositiveInfinity;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal double v;

    internal nfloat(nfloat v)
    {
        this.v = v.v;
    }

    public nfloat(float v)
    {
        this.v = v;
    }

    public nfloat(double v)
    {
        this.v = v;
    }

    public unsafe static explicit operator nfloat(IntPtr v)
    {
        return new nfloat(*(double*)(&v));
    }

    public unsafe static explicit operator IntPtr(nfloat v)
    {
        return *(IntPtr*)(&v.v);
    }

    public static implicit operator nfloat(sbyte v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator sbyte(nfloat v)
    {
        return (sbyte)v.v;
    }

    public static implicit operator nfloat(byte v)
    {
        return new nfloat((double)(int)v);
    }

    public static explicit operator byte(nfloat v)
    {
        return (byte)v.v;
    }

    public static implicit operator nfloat(char v)
    {
        return new nfloat((double)(int)v);
    }

    public static explicit operator char(nfloat v)
    {
        return (char)v.v;
    }

    public static implicit operator nfloat(short v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator short(nfloat v)
    {
        return (short)v.v;
    }

    public static implicit operator nfloat(ushort v)
    {
        return new nfloat((double)(int)v);
    }

    public static explicit operator ushort(nfloat v)
    {
        return (ushort)v.v;
    }

    public static implicit operator nfloat(int v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator int(nfloat v)
    {
        return (int)v.v;
    }

    public static implicit operator nfloat(uint v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator uint(nfloat v)
    {
        return (uint)v.v;
    }

    public static implicit operator nfloat(long v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator long(nfloat v)
    {
        return (long)v.v;
    }

    public static implicit operator nfloat(ulong v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator ulong(nfloat v)
    {
        return (ulong)v.v;
    }

    public static implicit operator nfloat(float v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator float(nfloat v)
    {
        return (float)v.v;
    }

    public static explicit operator nfloat(double v)
    {
        return new nfloat(v);
    }

    public static implicit operator double(nfloat v)
    {
        return v.v;
    }

    public static explicit operator nfloat(decimal v)
    {
        return new nfloat((double)v);
    }

    public static explicit operator decimal(nfloat v)
    {
        return (decimal)v.v;
    }

    public static nfloat operator +(nfloat v)
    {
        return new nfloat(v.v);
    }

    public static nfloat operator -(nfloat v)
    {
        return new nfloat(0.0 - v.v);
    }

    public static nfloat operator ++(nfloat v)
    {
        return new nfloat(v.v + 1.0);
    }

    public static nfloat operator --(nfloat v)
    {
        return new nfloat(v.v - 1.0);
    }

    public static nfloat operator +(nfloat l, nfloat r)
    {
        return new nfloat(l.v + r.v);
    }

    public static nfloat operator -(nfloat l, nfloat r)
    {
        return new nfloat(l.v - r.v);
    }

    public static nfloat operator *(nfloat l, nfloat r)
    {
        return new nfloat(l.v * r.v);
    }

    public static nfloat operator /(nfloat l, nfloat r)
    {
        return new nfloat(l.v / r.v);
    }

    public static nfloat operator %(nfloat l, nfloat r)
    {
        return new nfloat(l.v % r.v);
    }

    public static bool operator ==(nfloat l, nfloat r)
    {
        return l.v == r.v;
    }

    public static bool operator !=(nfloat l, nfloat r)
    {
        return l.v != r.v;
    }

    public static bool operator <(nfloat l, nfloat r)
    {
        return l.v < r.v;
    }

    public static bool operator >(nfloat l, nfloat r)
    {
        return l.v > r.v;
    }

    public static bool operator <=(nfloat l, nfloat r)
    {
        return l.v <= r.v;
    }

    public static bool operator >=(nfloat l, nfloat r)
    {
        return l.v >= r.v;
    }

    public int CompareTo(nfloat value)
    {
        return v.CompareTo(value.v);
    }

    public int CompareTo(object value)
    {
        if (value is nfloat)
        {
            return v.CompareTo(((nfloat)value).v);
        }
        return v.CompareTo(value);
    }

    public bool Equals(nfloat obj)
    {
        return v.Equals(obj.v);
    }

    public override bool Equals(object obj)
    {
        if (obj is nfloat)
        {
            return v.Equals(((nfloat)obj).v);
        }
        return v.Equals(obj);
    }

    public override int GetHashCode()
    {
        return v.GetHashCode();
    }

    public static bool IsNaN(nfloat f)
    {
        return double.IsNaN(f);
    }

    public static bool IsInfinity(nfloat f)
    {
        return double.IsInfinity(f);
    }

    public static bool IsPositiveInfinity(nfloat f)
    {
        return double.IsPositiveInfinity(f);
    }

    public static bool IsNegativeInfinity(nfloat f)
    {
        return double.IsNegativeInfinity(f);
    }

    public static nfloat Parse(string s, IFormatProvider provider)
    {
        return (nfloat)double.Parse(s, provider);
    }

    public static nfloat Parse(string s, NumberStyles style)
    {
        return (nfloat)double.Parse(s, style);
    }

    public static nfloat Parse(string s)
    {
        return (nfloat)double.Parse(s);
    }

    public static nfloat Parse(string s, NumberStyles style, IFormatProvider provider)
    {
        return (nfloat)double.Parse(s, style, provider);
    }

    public static bool TryParse(string s, out nfloat result)
    {
        double result2;
        bool result3 = double.TryParse(s, out result2);
        result = (nfloat)result2;
        return result3;
    }

    public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out nfloat result)
    {
        double result2;
        bool result3 = double.TryParse(s, style, provider, out result2);
        result = (nfloat)result2;
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

    public static void CopyArray(IntPtr source, nfloat[] destination, int startIndex, int length)
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
            destination[i + startIndex] = (nfloat)Marshal.ReadIntPtr(source, i * Size);
        }
    }

    public static void CopyArray(nfloat[] source, int startIndex, IntPtr destination, int length)
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
