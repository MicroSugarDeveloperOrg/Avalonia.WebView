using System;

namespace OpenTK;

[Serializable]
public struct Matrix3 : IEquatable<Matrix3>
{
	public float R0C0;

	public float R0C1;

	public float R0C2;

	public float R1C0;

	public float R1C1;

	public float R1C2;

	public float R2C0;

	public float R2C1;

	public float R2C2;

	public static readonly Matrix3 Identity = new Matrix3(1f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 1f);

	public static readonly Matrix3 Zero = new Matrix3(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

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
				case 2:
					return R0C2;
				}
				break;
			case 1:
				switch (column)
				{
				case 0:
					return R1C0;
				case 1:
					return R1C1;
				case 2:
					return R1C2;
				}
				break;
			case 2:
				switch (column)
				{
				case 0:
					return R2C0;
				case 1:
					return R2C1;
				case 2:
					return R2C2;
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
				case 2:
					R0C2 = value;
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
				case 2:
					R1C2 = value;
					return;
				}
				break;
			case 2:
				switch (column)
				{
				case 0:
					R2C0 = value;
					return;
				case 1:
					R2C1 = value;
					return;
				case 2:
					R2C2 = value;
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
				2 => R0C2, 
				3 => R1C0, 
				4 => R1C1, 
				5 => R1C2, 
				6 => R2C0, 
				7 => R2C1, 
				8 => R2C2, 
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
				R0C2 = value;
				break;
			case 3:
				R1C0 = value;
				break;
			case 4:
				R1C1 = value;
				break;
			case 5:
				R1C2 = value;
				break;
			case 6:
				R2C0 = value;
				break;
			case 7:
				R2C1 = value;
				break;
			case 8:
				R2C2 = value;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
		}
	}

	public float Determinant => R0C0 * R1C1 * R2C2 - R0C0 * R1C2 * R2C1 - R0C1 * R1C0 * R2C2 + R0C2 * R1C0 * R2C1 + R0C1 * R1C2 * R2C0 - R0C2 * R1C1 * R2C0;

	public unsafe static explicit operator IntPtr(Matrix3 matrix)
	{
		return (IntPtr)(&matrix.R0C0);
	}

	[CLSCompliant(false)]
	public unsafe static explicit operator float*(Matrix3 matrix)
	{
		return &matrix.R0C0;
	}

	public static explicit operator float[](Matrix3 matrix)
	{
		return new float[9] { matrix.R0C0, matrix.R0C1, matrix.R0C2, matrix.R1C0, matrix.R1C1, matrix.R1C2, matrix.R2C0, matrix.R2C1, matrix.R2C2 };
	}

	public Matrix3(ref Matrix3 matrix)
	{
		R0C0 = matrix.R0C0;
		R0C1 = matrix.R0C1;
		R0C2 = matrix.R0C2;
		R1C0 = matrix.R1C0;
		R1C1 = matrix.R1C1;
		R1C2 = matrix.R1C2;
		R2C0 = matrix.R2C0;
		R2C1 = matrix.R2C1;
		R2C2 = matrix.R2C2;
	}

	public Matrix3(float r0c0, float r0c1, float r0c2, float r1c0, float r1c1, float r1c2, float r2c0, float r2c1, float r2c2)
	{
		R0C0 = r0c0;
		R0C1 = r0c1;
		R0C2 = r0c2;
		R1C0 = r1c0;
		R1C1 = r1c1;
		R1C2 = r1c2;
		R2C0 = r2c0;
		R2C1 = r2c1;
		R2C2 = r2c2;
	}

	public Matrix3(float[] floatArray)
	{
		if (floatArray == null || floatArray.GetLength(0) < 9)
		{
			throw new MissingFieldException();
		}
		R0C0 = floatArray[0];
		R0C1 = floatArray[1];
		R0C2 = floatArray[2];
		R1C0 = floatArray[3];
		R1C1 = floatArray[4];
		R1C2 = floatArray[5];
		R2C0 = floatArray[6];
		R2C1 = floatArray[7];
		R2C2 = floatArray[8];
	}

	public Matrix3(Quaterniond quaternion)
	{
		quaternion.Normalize();
		float num = (float)(quaternion.X * quaternion.X);
		float num2 = (float)(quaternion.Y * quaternion.Y);
		float num3 = (float)(quaternion.Z * quaternion.Z);
		float num4 = (float)(quaternion.X * quaternion.Y);
		float num5 = (float)(quaternion.X * quaternion.Z);
		float num6 = (float)(quaternion.Y * quaternion.Z);
		float num7 = (float)(quaternion.W * quaternion.X);
		float num8 = (float)(quaternion.W * quaternion.Y);
		float num9 = (float)(quaternion.W * quaternion.Z);
		R0C0 = 1f - 2f * (num2 + num3);
		R0C1 = 2f * (num4 - num9);
		R0C2 = 2f * (num5 + num8);
		R1C0 = 2f * (num4 + num9);
		R1C1 = 1f - 2f * (num + num3);
		R1C2 = 2f * (num6 - num7);
		R2C0 = 2f * (num5 - num8);
		R2C1 = 2f * (num6 + num7);
		R2C2 = 1f - 2f * (num + num2);
	}

	[CLSCompliant(false)]
	public bool Equals(Matrix3 matrix)
	{
		return R0C0 == matrix.R0C0 && R0C1 == matrix.R0C1 && R0C2 == matrix.R0C2 && R1C0 == matrix.R1C0 && R1C1 == matrix.R1C1 && R1C2 == matrix.R1C2 && R2C0 == matrix.R2C0 && R2C1 == matrix.R2C1 && R2C2 == matrix.R2C2;
	}

	public bool Equals(ref Matrix3 matrix)
	{
		return R0C0 == matrix.R0C0 && R0C1 == matrix.R0C1 && R0C2 == matrix.R0C2 && R1C0 == matrix.R1C0 && R1C1 == matrix.R1C1 && R1C2 == matrix.R1C2 && R2C0 == matrix.R2C0 && R2C1 == matrix.R2C1 && R2C2 == matrix.R2C2;
	}

	public static bool Equals(ref Matrix3 left, ref Matrix3 right)
	{
		return left.R0C0 == right.R0C0 && left.R0C1 == right.R0C1 && left.R0C2 == right.R0C2 && left.R1C0 == right.R1C0 && left.R1C1 == right.R1C1 && left.R1C2 == right.R1C2 && left.R2C0 == right.R2C0 && left.R2C1 == right.R2C1 && left.R2C2 == right.R2C2;
	}

	public bool EqualsApprox(ref Matrix3 matrix, float tolerance)
	{
		return Math.Abs(R0C0 - matrix.R0C0) <= tolerance && Math.Abs(R0C1 - matrix.R0C1) <= tolerance && Math.Abs(R0C2 - matrix.R0C2) <= tolerance && Math.Abs(R1C0 - matrix.R1C0) <= tolerance && Math.Abs(R1C1 - matrix.R1C1) <= tolerance && Math.Abs(R1C2 - matrix.R1C2) <= tolerance && Math.Abs(R2C0 - matrix.R2C0) <= tolerance && Math.Abs(R2C1 - matrix.R2C1) <= tolerance && Math.Abs(R2C2 - matrix.R2C2) <= tolerance;
	}

	public static bool EqualsApprox(ref Matrix3 left, ref Matrix3 right, float tolerance)
	{
		return Math.Abs(left.R0C0 - right.R0C0) <= tolerance && Math.Abs(left.R0C1 - right.R0C1) <= tolerance && Math.Abs(left.R0C2 - right.R0C2) <= tolerance && Math.Abs(left.R1C0 - right.R1C0) <= tolerance && Math.Abs(left.R1C1 - right.R1C1) <= tolerance && Math.Abs(left.R1C2 - right.R1C2) <= tolerance && Math.Abs(left.R2C0 - right.R2C0) <= tolerance && Math.Abs(left.R2C1 - right.R2C1) <= tolerance && Math.Abs(left.R2C2 - right.R2C2) <= tolerance;
	}

	public void Add(ref Matrix3 matrix)
	{
		R0C0 += matrix.R0C0;
		R0C1 += matrix.R0C1;
		R0C2 += matrix.R0C2;
		R1C0 += matrix.R1C0;
		R1C1 += matrix.R1C1;
		R1C2 += matrix.R1C2;
		R2C0 += matrix.R2C0;
		R2C1 += matrix.R2C1;
		R2C2 += matrix.R2C2;
	}

	public void Add(ref Matrix3 matrix, out Matrix3 result)
	{
		result.R0C0 = R0C0 + matrix.R0C0;
		result.R0C1 = R0C1 + matrix.R0C1;
		result.R0C2 = R0C2 + matrix.R0C2;
		result.R1C0 = R1C0 + matrix.R1C0;
		result.R1C1 = R1C1 + matrix.R1C1;
		result.R1C2 = R1C2 + matrix.R1C2;
		result.R2C0 = R2C0 + matrix.R2C0;
		result.R2C1 = R2C1 + matrix.R2C1;
		result.R2C2 = R2C2 + matrix.R2C2;
	}

	public static void Add(ref Matrix3 left, ref Matrix3 right, out Matrix3 result)
	{
		result.R0C0 = left.R0C0 + right.R0C0;
		result.R0C1 = left.R0C1 + right.R0C1;
		result.R0C2 = left.R0C2 + right.R0C2;
		result.R1C0 = left.R1C0 + right.R1C0;
		result.R1C1 = left.R1C1 + right.R1C1;
		result.R1C2 = left.R1C2 + right.R1C2;
		result.R2C0 = left.R2C0 + right.R2C0;
		result.R2C1 = left.R2C1 + right.R2C1;
		result.R2C2 = left.R2C2 + right.R2C2;
	}

	public void Subtract(ref Matrix3 matrix)
	{
		R0C0 += matrix.R0C0;
		R0C1 += matrix.R0C1;
		R0C2 += matrix.R0C2;
		R1C0 += matrix.R1C0;
		R1C1 += matrix.R1C1;
		R1C2 += matrix.R1C2;
		R2C0 += matrix.R2C0;
		R2C1 += matrix.R2C1;
		R2C2 += matrix.R2C2;
	}

	public void Subtract(ref Matrix3 matrix, out Matrix3 result)
	{
		result.R0C0 = R0C0 + matrix.R0C0;
		result.R0C1 = R0C1 + matrix.R0C1;
		result.R0C2 = R0C2 + matrix.R0C2;
		result.R1C0 = R1C0 + matrix.R1C0;
		result.R1C1 = R1C1 + matrix.R1C1;
		result.R1C2 = R1C2 + matrix.R1C2;
		result.R2C0 = R2C0 + matrix.R2C0;
		result.R2C1 = R2C1 + matrix.R2C1;
		result.R2C2 = R2C2 + matrix.R2C2;
	}

	public static void Subtract(ref Matrix3 left, ref Matrix3 right, out Matrix3 result)
	{
		result.R0C0 = left.R0C0 + right.R0C0;
		result.R0C1 = left.R0C1 + right.R0C1;
		result.R0C2 = left.R0C2 + right.R0C2;
		result.R1C0 = left.R1C0 + right.R1C0;
		result.R1C1 = left.R1C1 + right.R1C1;
		result.R1C2 = left.R1C2 + right.R1C2;
		result.R2C0 = left.R2C0 + right.R2C0;
		result.R2C1 = left.R2C1 + right.R2C1;
		result.R2C2 = left.R2C2 + right.R2C2;
	}

	public void Multiply(ref Matrix3 matrix)
	{
		float r0C = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0;
		float r0C2 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1;
		float r0C3 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2;
		float r1C = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0;
		float r1C2 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1;
		float r1C3 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2;
		R2C0 = matrix.R2C0 * R0C0 + matrix.R2C1 * R1C0 + matrix.R2C2 * R2C0;
		R2C1 = matrix.R2C0 * R0C1 + matrix.R2C1 * R1C1 + matrix.R2C2 * R2C1;
		R2C2 = matrix.R2C0 * R0C2 + matrix.R2C1 * R1C2 + matrix.R2C2 * R2C2;
		R0C0 = r0C;
		R0C1 = r0C2;
		R0C2 = r0C3;
		R1C0 = r1C;
		R1C1 = r1C2;
		R1C2 = r1C3;
	}

	public void Multiply(ref Matrix3 matrix, out Matrix3 result)
	{
		result.R0C0 = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0;
		result.R0C1 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1;
		result.R0C2 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2;
		result.R1C0 = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0;
		result.R1C1 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1;
		result.R1C2 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2;
		result.R2C0 = matrix.R2C0 * R0C0 + matrix.R2C1 * R1C0 + matrix.R2C2 * R2C0;
		result.R2C1 = matrix.R2C0 * R0C1 + matrix.R2C1 * R1C1 + matrix.R2C2 * R2C1;
		result.R2C2 = matrix.R2C0 * R0C2 + matrix.R2C1 * R1C2 + matrix.R2C2 * R2C2;
	}

	public static void Multiply(ref Matrix3 left, ref Matrix3 right, out Matrix3 result)
	{
		result.R0C0 = right.R0C0 * left.R0C0 + right.R0C1 * left.R1C0 + right.R0C2 * left.R2C0;
		result.R0C1 = right.R0C0 * left.R0C1 + right.R0C1 * left.R1C1 + right.R0C2 * left.R2C1;
		result.R0C2 = right.R0C0 * left.R0C2 + right.R0C1 * left.R1C2 + right.R0C2 * left.R2C2;
		result.R1C0 = right.R1C0 * left.R0C0 + right.R1C1 * left.R1C0 + right.R1C2 * left.R2C0;
		result.R1C1 = right.R1C0 * left.R0C1 + right.R1C1 * left.R1C1 + right.R1C2 * left.R2C1;
		result.R1C2 = right.R1C0 * left.R0C2 + right.R1C1 * left.R1C2 + right.R1C2 * left.R2C2;
		result.R2C0 = right.R2C0 * left.R0C0 + right.R2C1 * left.R1C0 + right.R2C2 * left.R2C0;
		result.R2C1 = right.R2C0 * left.R0C1 + right.R2C1 * left.R1C1 + right.R2C2 * left.R2C1;
		result.R2C2 = right.R2C0 * left.R0C2 + right.R2C1 * left.R1C2 + right.R2C2 * left.R2C2;
	}

	public void Multiply(float scalar)
	{
		R0C0 = scalar * R0C0;
		R0C1 = scalar * R0C1;
		R0C2 = scalar * R0C2;
		R1C0 = scalar * R1C0;
		R1C1 = scalar * R1C1;
		R1C2 = scalar * R1C2;
		R2C0 = scalar * R2C0;
		R2C1 = scalar * R2C1;
		R2C2 = scalar * R2C2;
	}

	public void Multiply(float scalar, out Matrix3 result)
	{
		result.R0C0 = scalar * R0C0;
		result.R0C1 = scalar * R0C1;
		result.R0C2 = scalar * R0C2;
		result.R1C0 = scalar * R1C0;
		result.R1C1 = scalar * R1C1;
		result.R1C2 = scalar * R1C2;
		result.R2C0 = scalar * R2C0;
		result.R2C1 = scalar * R2C1;
		result.R2C2 = scalar * R2C2;
	}

	public static void Multiply(ref Matrix3 matrix, float scalar, out Matrix3 result)
	{
		result.R0C0 = scalar * matrix.R0C0;
		result.R0C1 = scalar * matrix.R0C1;
		result.R0C2 = scalar * matrix.R0C2;
		result.R1C0 = scalar * matrix.R1C0;
		result.R1C1 = scalar * matrix.R1C1;
		result.R1C2 = scalar * matrix.R1C2;
		result.R2C0 = scalar * matrix.R2C0;
		result.R2C1 = scalar * matrix.R2C1;
		result.R2C2 = scalar * matrix.R2C2;
	}

	public void Transpose()
	{
		MathHelper.Swap(ref R0C1, ref R1C0);
		MathHelper.Swap(ref R0C2, ref R2C0);
		MathHelper.Swap(ref R1C2, ref R2C1);
	}

	public void Transpose(out Matrix3 result)
	{
		result.R0C0 = R0C0;
		result.R0C1 = R1C0;
		result.R0C2 = R2C0;
		result.R1C0 = R0C1;
		result.R1C1 = R1C1;
		result.R1C2 = R2C1;
		result.R2C0 = R0C2;
		result.R2C1 = R1C2;
		result.R2C2 = R2C2;
	}

	public static void Transpose(ref Matrix3 matrix, out Matrix3 result)
	{
		result.R0C0 = matrix.R0C0;
		result.R0C1 = matrix.R1C0;
		result.R0C2 = matrix.R2C0;
		result.R1C0 = matrix.R0C1;
		result.R1C1 = matrix.R1C1;
		result.R1C2 = matrix.R2C1;
		result.R2C0 = matrix.R0C2;
		result.R2C1 = matrix.R1C2;
		result.R2C2 = matrix.R2C2;
	}

	public void Transform(ref Vector3 vector)
	{
		float x = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
		float y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
		vector.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
		vector.X = x;
		vector.Y = y;
	}

	public static void Transform(ref Matrix3 matrix, ref Vector3 vector)
	{
		float x = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
		float y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
		vector.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
		vector.X = x;
		vector.Y = y;
	}

	public void Transform(ref Vector3 vector, out Vector3 result)
	{
		result.X = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
		result.Y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
		result.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
	}

	public static void Transform(ref Matrix3 matrix, ref Vector3 vector, out Vector3 result)
	{
		result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
		result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
		result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
	}

	public void Rotate(float angle)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float num3 = (float)Math.Cos(num);
		float r0C = num3 * R0C0 + num2 * R1C0;
		float r0C2 = num3 * R0C1 + num2 * R1C1;
		float r0C3 = num3 * R0C2 + num2 * R1C2;
		R1C0 = num3 * R1C0 - num2 * R0C0;
		R1C1 = num3 * R1C1 - num2 * R0C1;
		R1C2 = num3 * R1C2 - num2 * R0C2;
		R0C0 = r0C;
		R0C1 = r0C2;
		R0C2 = r0C3;
	}

	public void Rotate(float angle, out Matrix3 result)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float num3 = (float)Math.Cos(num);
		result.R0C0 = num3 * R0C0 + num2 * R1C0;
		result.R0C1 = num3 * R0C1 + num2 * R1C1;
		result.R0C2 = num3 * R0C2 + num2 * R1C2;
		result.R1C0 = num3 * R1C0 - num2 * R0C0;
		result.R1C1 = num3 * R1C1 - num2 * R0C1;
		result.R1C2 = num3 * R1C2 - num2 * R0C2;
		result.R2C0 = R2C0;
		result.R2C1 = R2C1;
		result.R2C2 = R2C2;
	}

	public static void Rotate(ref Matrix3 matrix, float angle, out Matrix3 result)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float num3 = (float)Math.Cos(num);
		result.R0C0 = num3 * matrix.R0C0 + num2 * matrix.R1C0;
		result.R0C1 = num3 * matrix.R0C1 + num2 * matrix.R1C1;
		result.R0C2 = num3 * matrix.R0C2 + num2 * matrix.R1C2;
		result.R1C0 = num3 * matrix.R1C0 - num2 * matrix.R0C0;
		result.R1C1 = num3 * matrix.R1C1 - num2 * matrix.R0C1;
		result.R1C2 = num3 * matrix.R1C2 - num2 * matrix.R0C2;
		result.R2C0 = matrix.R2C0;
		result.R2C1 = matrix.R2C1;
		result.R2C2 = matrix.R2C2;
	}

	public static void RotateMatrix(float angle, out Matrix3 result)
	{
		float num = MathHelper.DegreesToRadians(angle);
		float num2 = (float)Math.Sin(num);
		float r1C = (result.R0C0 = (float)Math.Cos(num));
		result.R0C1 = num2;
		result.R0C2 = 0f;
		result.R1C0 = 0f - num2;
		result.R1C1 = r1C;
		result.R1C2 = 0f;
		result.R2C0 = 0f;
		result.R2C1 = 0f;
		result.R2C2 = 1f;
	}

	public Quaternion ToQuaternion()
	{
		return new Quaternion(ref this);
	}

	public override int GetHashCode()
	{
		return R0C0.GetHashCode() ^ R0C1.GetHashCode() ^ R0C2.GetHashCode() ^ R1C0.GetHashCode() ^ R1C1.GetHashCode() ^ R1C2.GetHashCode() ^ R2C0.GetHashCode() ^ R2C1.GetHashCode() ^ R2C2.GetHashCode();
	}

	public override string ToString()
	{
		return $"|{R0C0}, {R0C1}, {R0C2}|\n|{R1C0}, {R1C1}, {R1C2}|\n|{R2C0}, {R2C1}, {R2C2}|\n";
	}
}
