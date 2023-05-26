using System;

namespace OpenTK;

public struct NMatrix2 : IEquatable<NMatrix2>
{
	public float R0C0;

	public float R1C0;

	public float R0C1;

	public float R1C1;

	public static readonly NMatrix2 Identity = new NMatrix2(1f, 0f, 0f, 1f);

	public float Determinant => R0C0 * R1C1 - R1C0 * R0C1;

	public NMatrix2(float r0c0, float r0c1, float r1c0, float r1c1)
	{
		R0C0 = r0c0;
		R1C0 = r1c0;
		R0C1 = r0c1;
		R1C1 = r1c1;
	}

	public void Transpose()
	{
		this = Transpose(this);
	}

	public static NMatrix2 Transpose(NMatrix2 mat)
	{
		return new NMatrix2(mat.R0C0, mat.R1C0, mat.R0C1, mat.R1C1);
	}

	public static void Transpose(ref NMatrix2 mat, out NMatrix2 result)
	{
		result.R0C0 = mat.R0C0;
		result.R0C1 = mat.R1C0;
		result.R1C0 = mat.R0C1;
		result.R1C1 = mat.R1C1;
	}

	public static NMatrix2 Multiply(NMatrix2 left, NMatrix2 right)
	{
		Multiply(ref left, ref right, out var result);
		return result;
	}

	public static void Multiply(ref NMatrix2 left, ref NMatrix2 right, out NMatrix2 result)
	{
		result.R0C0 = left.R0C0 * right.R0C0 + left.R0C1 * right.R1C0;
		result.R0C1 = left.R0C0 * right.R0C1 + left.R0C1 * right.R1C1;
		result.R1C0 = left.R1C0 * right.R0C0 + left.R1C1 * right.R1C0;
		result.R1C1 = left.R1C0 * right.R0C1 + left.R1C1 * right.R1C1;
	}

	public static NMatrix2 operator *(NMatrix2 left, NMatrix2 right)
	{
		return Multiply(left, right);
	}

	public static bool operator ==(NMatrix2 left, NMatrix2 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(NMatrix2 left, NMatrix2 right)
	{
		return !left.Equals(right);
	}

	public static explicit operator Matrix2(NMatrix2 value)
	{
		return new Matrix2(value.R0C0, value.R0C1, value.R1C0, value.R1C1);
	}

	public static explicit operator NMatrix2(Matrix2 value)
	{
		return new NMatrix2(value.R0C0, value.R0C1, value.R1C0, value.R1C1);
	}

	public override string ToString()
	{
		return $"({R0C0}, {R0C1})\n({R1C0}, {R1C1})";
	}

	public override int GetHashCode()
	{
		return R0C0.GetHashCode() ^ R0C1.GetHashCode() ^ R1C0.GetHashCode() ^ R1C1.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is NMatrix2))
		{
			return false;
		}
		return Equals((NMatrix2)obj);
	}

	public bool Equals(NMatrix2 other)
	{
		return R0C0 == other.R0C0 && R0C1 == other.R0C1 && R1C0 == other.R1C0 && R1C1 == other.R1C1;
	}
}
