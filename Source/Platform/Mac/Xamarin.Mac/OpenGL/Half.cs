using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace OpenGL;

[Serializable]
public struct Half : ISerializable, IComparable<Half>, IFormattable, IEquatable<Half>
{
	private ushort bits;

	public static readonly int SizeInBytes = 2;

	public static readonly float MinValue = 5.9604645E-08f;

	public static readonly float MinNormalizedValue = 6.1035156E-05f;

	public static readonly float MaxValue = 65504f;

	public static readonly float Epsilon = 0.00097656f;

	private const int maxUlps = 1;

	public bool IsZero
	{
		get
		{
			if (bits != 0)
			{
				return bits == 32768;
			}
			return true;
		}
	}

	public bool IsNaN
	{
		get
		{
			if ((bits & 0x7C00) == 31744)
			{
				return (bits & 0x3FF) != 0;
			}
			return false;
		}
	}

	public bool IsPositiveInfinity => bits == 31744;

	public bool IsNegativeInfinity => bits == 64512;

	public unsafe Half(float f)
	{
		this = default(Half);
		bits = SingleToHalf(*(int*)(&f));
	}

	public Half(float f, bool throwOnError)
		: this(f)
	{
		if (throwOnError)
		{
			if (f > MaxValue)
			{
				throw new ArithmeticException("Half: Positive maximum value exceeded.");
			}
			if (f < 0f - MaxValue)
			{
				throw new ArithmeticException("Half: Negative minimum value exceeded.");
			}
			if (float.IsNaN(f))
			{
				throw new ArithmeticException("Half: Input is not a number (NaN).");
			}
			if (float.IsPositiveInfinity(f))
			{
				throw new ArithmeticException("Half: Input is positive infinity.");
			}
			if (float.IsNegativeInfinity(f))
			{
				throw new ArithmeticException("Half: Input is negative infinity.");
			}
		}
	}

	public Half(double d)
		: this((float)d)
	{
	}

	public Half(double d, bool throwOnError)
		: this((float)d, throwOnError)
	{
	}

	private ushort SingleToHalf(int si32)
	{
		int num = (si32 >> 16) & 0x8000;
		int num2 = ((si32 >> 23) & 0xFF) - 112;
		int num3 = si32 & 0x7FFFFF;
		if (num2 <= 0)
		{
			if (num2 < -10)
			{
				return (ushort)num;
			}
			num3 |= 0x800000;
			int num4 = 14 - num2;
			int num5 = (1 << num4 - 1) - 1;
			int num6 = (num3 >> num4) & 1;
			num3 = num3 + num5 + num6 >> num4;
			return (ushort)(num | num3);
		}
		if (num2 == 143)
		{
			if (num3 == 0)
			{
				return (ushort)((uint)num | 0x7C00u);
			}
			num3 >>= 13;
			return (ushort)((uint)num | 0x7C00u | (uint)num3 | ((num3 == 0) ? 1u : 0u));
		}
		num3 = num3 + 4095 + ((num3 >> 13) & 1);
		if ((num3 & 0x800000) == 1)
		{
			num3 = 0;
			num2++;
		}
		if (num2 > 30)
		{
			throw new ArithmeticException("Half: Hardware floating-point overflow.");
		}
		return (ushort)(num | (num2 << 10) | (num3 >> 13));
	}

	public unsafe float ToSingle()
	{
		int num = HalfToFloat(bits);
		return *(float*)(&num);
	}

	private int HalfToFloat(ushort ui16)
	{
		int num = (ui16 >> 15) & 1;
		int num2 = (ui16 >> 10) & 0x1F;
		int num3 = ui16 & 0x3FF;
		switch (num2)
		{
		case 0:
			if (num3 == 0)
			{
				return num << 31;
			}
			while ((num3 & 0x400) == 0)
			{
				num3 <<= 1;
				num2--;
			}
			num2++;
			num3 &= -1025;
			break;
		case 31:
			if (num3 == 0)
			{
				return (num << 31) | 0x7F800000;
			}
			return (num << 31) | 0x7F800000 | (num3 << 13);
		}
		num2 += 112;
		num3 <<= 13;
		return (num << 31) | (num2 << 23) | num3;
	}

	public static explicit operator Half(float f)
	{
		return new Half(f);
	}

	public static explicit operator Half(double d)
	{
		return new Half(d);
	}

	public static implicit operator float(Half h)
	{
		return h.ToSingle();
	}

	public static implicit operator double(Half h)
	{
		return h.ToSingle();
	}

	public Half(SerializationInfo info, StreamingContext context)
	{
		bits = (ushort)info.GetValue("bits", typeof(ushort));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("bits", bits);
	}

	public void FromBinaryStream(BinaryReader bin)
	{
		bits = bin.ReadUInt16();
	}

	public void ToBinaryStream(BinaryWriter bin)
	{
		bin.Write(bits);
	}

	public bool Equals(Half other)
	{
		short num = (short)other.bits;
		short num2 = (short)bits;
		if (num < 0)
		{
			num = (short)(32768 - num);
		}
		if (num2 < 0)
		{
			num2 = (short)(32768 - num2);
		}
		if (Math.Abs((short)(num - num2)) <= 1)
		{
			return true;
		}
		return false;
	}

	public int CompareTo(Half other)
	{
		return ((float)this).CompareTo(other);
	}

	public override string ToString()
	{
		return ToSingle().ToString();
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return ToSingle().ToString(format, formatProvider);
	}

	public static Half Parse(string s)
	{
		return (Half)float.Parse(s);
	}

	public static Half Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return (Half)float.Parse(s, style, provider);
	}

	public static bool TryParse(string s, out Half result)
	{
		float result2;
		bool result3 = float.TryParse(s, out result2);
		result = (Half)result2;
		return result3;
	}

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Half result)
	{
		float result2;
		bool result3 = float.TryParse(s, style, provider, out result2);
		result = (Half)result2;
		return result3;
	}

	public static byte[] GetBytes(Half h)
	{
		return BitConverter.GetBytes(h.bits);
	}

	public static Half FromBytes(byte[] value, int startIndex)
	{
		Half result = default(Half);
		result.bits = BitConverter.ToUInt16(value, startIndex);
		return result;
	}
}
