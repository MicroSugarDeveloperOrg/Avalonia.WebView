using System;

namespace OpenTK;

[Serializable]
public struct Matrix2 : IEquatable<Matrix2>
{
	public float R0C0;

	public float R0C1;

	public float R1C0;

	public float R1C1;

	public static readonly Matrix2 Identity = new Matrix2(1f, 0f, 0f, 1f);

	public static readonly Matrix2 Zero = new Matrix2(0f, 0f, 0f, 0f);

	public float this[int row, int column]
	{
		get
		{
			switch (row)
			{
			case 0:
				switch (column)
				{
				case 0:
					return R0C0;
				case 1:
					return R0C1;
				}
				break;
			case 1:
				switch (column)
				{
				case 0:
					return R1C0;
				case 1:
					return R1C1;
				}
				break;
			}
			throw new IndexOutOfRangeException();
		}
		set
		{
			switch (row)
			{
			case 0:
				switch (column)
				{
				case 0:
					R0C0 = value;
					return;
				case 1:
					R0C1 = value;
					return;
				}
				break;
			case 1:
				switch (column)
				{
				case 0:
					R1C0 = value;
					return;
				case 1:
					R1C1 = value;
					return;
				}
				break;
			}
			throw new IndexOutOfRangeException();
		}
	}

	public float this[int index]
	{
		get
		{
			return index switch
			{
				0 => R0C0, 
				1 => R0C1, 
				2 => R1C0, 
				3 => R1C1, 
				_ => throw new IndexOutOfRangeException(), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				R0C0 = value;
				break;
			case 1:
				R0C1 = value;
				break;
			case 2:
				R1C0 = value;
				break;
			case 3:
				R1C1 = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}

	public float Determinant => R0C0 * R1C1 - R0C1 * R1C0;

	public unsafe static explicit operator IntPtr(Matrix2 matrix)
	{
		return (IntPtr)(&matrix.R0C0);
	}

	[CLSCompliant(false)]
	public unsafe static explicit operator float*(Matrix2 matrix)
	{
		return &matrix.R0C0;
	}

	public static explicit operator float[](Matrix2 matrix)
	{
		return new float[4] { matrix.R0C0, matrix.R0C1, matrix.R1C0, matrix.R1C1 };
	}

	public Matrix2(ref Matrix2 matrix)
	{
		R0C0 = matrix.R0C0;
		R0C1 = matrix.R0C1;
		R1C0 = matrix.R1C0;
		R1C1 = matrix.R1C1;
	}

	public Matrix2(float r0c0, float r0c1, float r1c0, float r1c1)
	{
		R0C0 = r0c0;
		R0C1 = r0c1;
		R1C0 = r1c0;
		R1C1 = r1c1;
	}

	public Matrix2(float[] floatArray)
	{
		if (floatArray == null || floatArray.GetLength(0) < 9)
		{
			throw new MissingFieldException();
		}
		R0C0 = floatArray[0];
		R0C1 = floatArray[1];
		R1C0 = floatArray[2];
		R1C1 = floatArray[3];
	}

	[CLSCompliant(false)]
	public bool Equals(Matrix2 matrix)
	{
		return R0C0 == matrix.R0C0 && R0C1 == matrix.R0C1 && R1C0 == matrix.R1C0 && R1C1 == matrix.R1C1;
	}

	public bool Equals(ref Matrix2 matrix)
	{
		return R0C0 == matrix.R0C0 && R0C1 == matrix.R0C1 && R1C0 == matrix.R1C0 && R1C1 == matrix.R1C1;
	}

	public static bool Equals(ref Matrix2 left, ref Matrix2 right)
	{
		return left.R0C0 == right.R0C0 && left.R0C1 == right.R0C1 && left.R1C0 == right.R1C0 && left.R1C1 == right.R1C1;
	}

	public bool EqualsApprox(ref Matrix2 matrix, float tolerance)
	{
		return Math.Abs(R0C0 - matrix.R0C0) <= tolerance && Math.Abs(R0C1 - matrix.R0C1) <= tolerance && Math.Abs(R1C0 - matrix.R1C0) <= tolerance && Math.Abs(R1C1 - matrix.R1C1) <= tolerance;
	}

	public static bool EqualsApprox(ref Matrix2 left, ref Matrix2 right, float tolerance)
	{
		return Math.Abs(left.R0C0 - right.R0C0) <= tolerance && Math.Abs(left.R0C1 - right.R0C1) <= tolerance && Math.Abs(left.R1C0 - right.R1C0) <= tolerance && Math.Abs(left.R1C1 - right.R1C1) <= tolerance;
	}

	public void Add(ref Matrix2 matrix)
	{
		R0C0 += matrix.R0C0;
		R0C1 += matrix.R0C1;
		R1C0 += matrix.R1C0;
		R1C1 += matrix.R1C1;
	}

	public void Add(ref Matrix2 matrix, out Matrix2 result)
	{
		result.R0C0 = R0C0 + matrix.R0C0;
		result.R0C1 = R0C1 + matrix.R0C1;
		result.R1C0 = R1C0 + matrix.R1C0;
		result.R1C1 = R1C1 + matrix.R1C1;
	}

	public static void Add(ref Matrix2 left, ref Matrix2 right, out Matrix2 result)
	{
		result.R0C0 = left.R0C0 + right.R0C0;
		result.R0C1 = left.R0C1 + right.R0C1;
		result.R1C0 = left.R1C0 + right.R1C0;
		result.R1C1 = left.R1C1 + right.R1C1;
	}

	public void Subtract(ref Matrix2 matrix)
	{
		R0C0 -= matrix.R0C0;
		R0C1 -= matrix.R0C1;
		R1C0 -= matrix.R1C0;
		R1C1 -= matrix.R1C1;
	}

	public void Subtract(ref Matrix2 matrix, out Matrix2 result)
	{
		result.R0C0 = R0C0 - matrix.R0C0;
		result.R0C1 = R0C1 - matrix.R0C1;
		result.R1C0 = R1C0 - matrix.R1C0;
		result.R1C1 = R1C1 - matrix.R1C1;
	}

	public static void Subtract(ref Matrix2 left, ref Matrix2 right, out Matrix2 result)
	{
		result.R0C0 = left.R0C0 - right.R0C0;
		result.R0C1 = left.R0C1 - right.R0C1;
		result.R1C0 = left.R1C0 - right.R1C0;
		result.R1C1 = left.R1C1 - right.R1C1;
	}

	public void Multiply(ref Matrix2 matrix)
	{
		float r0C = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0;
		float r0C2 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1;
		float r1C = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0;
		float r1C2 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1;
		R0C0 = r0C;
		R0C1 = r0C2;
		R1C0 = r1C;
		R1C1 = r1C2;
	}

	public void Multiply(ref Matrix2 matrix, out Matrix2 result)
	{
		result.R0C0 = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0;
		result.R0C1 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1;
		result.R1C0 = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0;
		result.R1C1 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1;
	}

	public static void Multiply(ref Matrix2 left, ref Matrix2 right, out Matrix2 result)
	{
		result.R0C0 = right.R0C0 * left.R0C0 + right.R0C1 * left.R1C0;
		result.R0C1 = right.R0C0 * left.R0C1 + right.R0C1 * left.R1C1;
		result.R1C0 = right.R1C0 * left.R0C0 + right.R1C1 * left.R1C0;
		result.R1C1 = right.R1C0 * left.R0C1 + right.R1C1 * left.R1C1;
	}

	public void Multiply(float scalar)
	{
		R0C0 = scalar * R0C0;
		R0C1 = scalar * R0C1;
		R1C0 = scalar * R1C0;
		R1C1 = scalar * R1C1;
	}

	public void Multiply(float scalar, out Matrix2 result)
	{
		result.R0C0 = scalar * R0C0;
		result.R0C1 = scalar * R0C1;
		result.R1C0 = scalar * R1C0;
		result.R1C1 = scalar * R1C1;
	}

	public static void Multiply(ref Matrix2 matrix, float scalar, out Matrix2 result)
	{
		result.R0C0 = scalar * matrix.R0C0;
		result.R0C1 = scalar * matrix.R0C1;
		result.R1C0 = scalar * matrix.R1C0;
		result.R1C1 = scalar * matrix.R1C1;
	}

	public void Transpose()
	{
		MathHelper.Swap(ref R0C1, ref R1C0);
	}

	public void Transpose(out Matrix2 result)
	{
		result.R0C0 = R0C0;
		result.R0C1 = R1C0;
		result.R1C0 = R0C1;
		result.R1C1 = R1C1;
	}

	public static void Transpose(ref Matrix2 matrix, out Matrix2 result)
	{
		result.R0C0 = matrix.R0C0;
		result.R0C1 = matrix.R1C0;
		result.R1C0 = matrix.R0C1;
		result.R1C1 = matrix.R1C1;
	}

	public void Transform(ref Vector2 vector)
	{
		float x = R0C0 * vector.X + R0C1 * vector.Y;
		vector.Y = R1C0 * vector.X + R1C1 * vector.Y;
		vector.X = x;
	}

	public static void Transform(ref Matrix2 matrix, ref Vector2 vector)
	{
		float x = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y;
		vector.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y;
		vector.X = x;
	}

	public void Transform(ref Vector2 vector, out Vector2 result)
	{
		result.X = R0C0 * vector.X + R0C1 * vector.Y;
		result.Y = R1C0 * vector.X + R1C1 * vector.Y;
	}

	public static void Transform(ref Matrix2 matrix, ref Vector2 vector, out Vector2 result)
	{
		result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y;
		result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y;
	}

	public void Rotate(float angle)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float num3 = (float)Math.Cos(num);
		float r0C = num3 * R0C0 - num2 * R1C0;
		float r0C2 = num3 * R0C1 - num2 * R1C1;
		R1C0 = num3 * R1C0 + num2 * R0C0;
		R1C1 = num3 * R1C1 + num2 * R0C1;
		R0C0 = r0C;
		R0C1 = r0C2;
	}

	public void Rotate(float angle, out Matrix2 result)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float num3 = (float)Math.Cos(num);
		result.R0C0 = num3 * R0C0 - num2 * R1C0;
		result.R0C1 = num3 * R0C1 - num2 * R1C1;
		result.R1C0 = num3 * R1C0 + num2 * R0C0;
		result.R1C1 = num3 * R1C1 + num2 * R0C1;
	}

	public static void Rotate(ref Matrix2 matrix, float angle, out Matrix2 result)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float num3 = (float)Math.Cos(num);
		result.R0C0 = num3 * matrix.R0C0 - num2 * matrix.R1C0;
		result.R0C1 = num3 * matrix.R0C1 - num2 * matrix.R1C1;
		result.R1C0 = num3 * matrix.R1C0 + num2 * matrix.R0C0;
		result.R1C1 = num3 * matrix.R1C1 + num2 * matrix.R0C1;
	}

	public static void RotateMatrix(float angle, out Matrix2 result)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float r1C = (result.R0C0 = (float)Math.Cos(num));
		result.R0C1 = 0f - num2;
		result.R1C0 = num2;
		result.R1C1 = r1C;
	}

	public override int GetHashCode()
	{
		return R0C0.GetHashCode() ^ R0C1.GetHashCode() ^ R1C0.GetHashCode() ^ R1C1.GetHashCode();
	}

	public override string ToString()
	{
		return $"|{R0C0}, {R0C1}|\n|{R1C0}, {R1C1}|\n";
	}
}
