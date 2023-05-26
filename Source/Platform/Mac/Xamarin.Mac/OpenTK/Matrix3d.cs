using System;

namespace OpenTK;

[Serializable]
public struct Matrix3d : IEquatable<Matrix3d>
{
	public double R0C0;

	public double R0C1;

	public double R0C2;

	public double R1C0;

	public double R1C1;

	public double R1C2;

	public double R2C0;

	public double R2C1;

	public double R2C2;

	public static readonly Matrix3d Identity = new Matrix3d(1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0);

	public static readonly Matrix3d Zero = new Matrix3d(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

	public double this[int row, int column]
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

	public double this[int index]
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

	public double Determinant => R0C0 * R1C1 * R2C2 - R0C0 * R1C2 * R2C1 - R0C1 * R1C0 * R2C2 + R0C2 * R1C0 * R2C1 + R0C1 * R1C2 * R2C0 - R0C2 * R1C1 * R2C0;

	public unsafe static explicit operator IntPtr(Matrix3d matrix)
	{
		return (IntPtr)(&matrix.R0C0);
	}

	[CLSCompliant(false)]
	public unsafe static explicit operator double*(Matrix3d matrix)
	{
		return &matrix.R0C0;
	}

	public static explicit operator double[](Matrix3d matrix)
	{
		return new double[9] { matrix.R0C0, matrix.R0C1, matrix.R0C2, matrix.R1C0, matrix.R1C1, matrix.R1C2, matrix.R2C0, matrix.R2C1, matrix.R2C2 };
	}

	public Matrix3d(ref Matrix3d matrix)
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

	public Matrix3d(double r0c0, double r0c1, double r0c2, double r1c0, double r1c1, double r1c2, double r2c0, double r2c1, double r2c2)
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

	public Matrix3d(double[] doubleArray)
	{
		if (doubleArray == null || doubleArray.GetLength(0) < 9)
		{
			throw new MissingFieldException();
		}
		R0C0 = doubleArray[0];
		R0C1 = doubleArray[1];
		R0C2 = doubleArray[2];
		R1C0 = doubleArray[3];
		R1C1 = doubleArray[4];
		R1C2 = doubleArray[5];
		R2C0 = doubleArray[6];
		R2C1 = doubleArray[7];
		R2C2 = doubleArray[8];
	}

	public Matrix3d(Quaterniond quaternion)
	{
		quaternion.Normalize();
		double num = quaternion.X * quaternion.X;
		double num2 = quaternion.Y * quaternion.Y;
		double num3 = quaternion.Z * quaternion.Z;
		double num4 = quaternion.X * quaternion.Y;
		double num5 = quaternion.X * quaternion.Z;
		double num6 = quaternion.Y * quaternion.Z;
		double num7 = quaternion.W * quaternion.X;
		double num8 = quaternion.W * quaternion.Y;
		double num9 = quaternion.W * quaternion.Z;
		R0C0 = 1.0 - 2.0 * (num2 + num3);
		R0C1 = 2.0 * (num4 - num9);
		R0C2 = 2.0 * (num5 + num8);
		R1C0 = 2.0 * (num4 + num9);
		R1C1 = 1.0 - 2.0 * (num + num3);
		R1C2 = 2.0 * (num6 - num7);
		R2C0 = 2.0 * (num5 - num8);
		R2C1 = 2.0 * (num6 + num7);
		R2C2 = 1.0 - 2.0 * (num + num2);
	}

	[CLSCompliant(false)]
	public bool Equals(Matrix3d matrix)
	{
		return R0C0 == matrix.R0C0 && R0C1 == matrix.R0C1 && R0C2 == matrix.R0C2 && R1C0 == matrix.R1C0 && R1C1 == matrix.R1C1 && R1C2 == matrix.R1C2 && R2C0 == matrix.R2C0 && R2C1 == matrix.R2C1 && R2C2 == matrix.R2C2;
	}

	public bool Equals(ref Matrix3d matrix)
	{
		return R0C0 == matrix.R0C0 && R0C1 == matrix.R0C1 && R0C2 == matrix.R0C2 && R1C0 == matrix.R1C0 && R1C1 == matrix.R1C1 && R1C2 == matrix.R1C2 && R2C0 == matrix.R2C0 && R2C1 == matrix.R2C1 && R2C2 == matrix.R2C2;
	}

	public static bool Equals(ref Matrix3d left, ref Matrix3d right)
	{
		return left.R0C0 == right.R0C0 && left.R0C1 == right.R0C1 && left.R0C2 == right.R0C2 && left.R1C0 == right.R1C0 && left.R1C1 == right.R1C1 && left.R1C2 == right.R1C2 && left.R2C0 == right.R2C0 && left.R2C1 == right.R2C1 && left.R2C2 == right.R2C2;
	}

	public bool EqualsApprox(ref Matrix3d matrix, double tolerance)
	{
		return Math.Abs(R0C0 - matrix.R0C0) <= tolerance && Math.Abs(R0C1 - matrix.R0C1) <= tolerance && Math.Abs(R0C2 - matrix.R0C2) <= tolerance && Math.Abs(R1C0 - matrix.R1C0) <= tolerance && Math.Abs(R1C1 - matrix.R1C1) <= tolerance && Math.Abs(R1C2 - matrix.R1C2) <= tolerance && Math.Abs(R2C0 - matrix.R2C0) <= tolerance && Math.Abs(R2C1 - matrix.R2C1) <= tolerance && Math.Abs(R2C2 - matrix.R2C2) <= tolerance;
	}

	public static bool EqualsApprox(ref Matrix3d left, ref Matrix3d right, double tolerance)
	{
		return Math.Abs(left.R0C0 - right.R0C0) <= tolerance && Math.Abs(left.R0C1 - right.R0C1) <= tolerance && Math.Abs(left.R0C2 - right.R0C2) <= tolerance && Math.Abs(left.R1C0 - right.R1C0) <= tolerance && Math.Abs(left.R1C1 - right.R1C1) <= tolerance && Math.Abs(left.R1C2 - right.R1C2) <= tolerance && Math.Abs(left.R2C0 - right.R2C0) <= tolerance && Math.Abs(left.R2C1 - right.R2C1) <= tolerance && Math.Abs(left.R2C2 - right.R2C2) <= tolerance;
	}

	public void Add(ref Matrix3d matrix)
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

	public void Add(ref Matrix3d matrix, out Matrix3d result)
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

	public static void Add(ref Matrix3d left, ref Matrix3d right, out Matrix3d result)
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

	public void Subtract(ref Matrix3d matrix)
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

	public void Subtract(ref Matrix3d matrix, out Matrix3d result)
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

	public static void Subtract(ref Matrix3d left, ref Matrix3d right, out Matrix3d result)
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

	public void Multiply(ref Matrix3d matrix)
	{
		double r0C = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0;
		double r0C2 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1;
		double r0C3 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2;
		double r1C = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0;
		double r1C2 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1;
		double r1C3 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2;
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

	public void Multiply(ref Matrix3d matrix, out Matrix3d result)
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

	public static void Multiply(ref Matrix3d left, ref Matrix3d right, out Matrix3d result)
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

	public void Multiply(double scalar)
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

	public void Multiply(double scalar, out Matrix3d result)
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

	public static void Multiply(ref Matrix3d matrix, double scalar, out Matrix3d result)
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

	public void Transpose(out Matrix3d result)
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

	public static void Transpose(ref Matrix3d matrix, out Matrix3d result)
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

	public void Transform(ref Vector3d vector)
	{
		double x = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
		double y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
		vector.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
		vector.X = x;
		vector.Y = y;
	}

	public static void Transform(ref Matrix3d matrix, ref Vector3d vector)
	{
		double x = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
		double y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
		vector.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
		vector.X = x;
		vector.Y = y;
	}

	public void Transform(ref Vector3d vector, out Vector3d result)
	{
		result.X = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
		result.Y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
		result.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
	}

	public static void Transform(ref Matrix3d matrix, ref Vector3d vector, out Vector3d result)
	{
		result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
		result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
		result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
	}

	public void Rotate(double angle)
	{
		double num = MathHelper.DTOR * angle;
		double num2 = Math.Sin(num);
		double num3 = Math.Cos(num);
		double r0C = num3 * R0C0 + num2 * R1C0;
		double r0C2 = num3 * R0C1 + num2 * R1C1;
		double r0C3 = num3 * R0C2 + num2 * R1C2;
		R1C0 = num3 * R1C0 - num2 * R0C0;
		R1C1 = num3 * R1C1 - num2 * R0C1;
		R1C2 = num3 * R1C2 - num2 * R0C2;
		R0C0 = r0C;
		R0C1 = r0C2;
		R0C2 = r0C3;
	}

	public void Rotate(double angle, out Matrix3d result)
	{
		double num = MathHelper.DTOR * angle;
		double num2 = Math.Sin(num);
		double num3 = Math.Cos(num);
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

	public static void Rotate(ref Matrix3d matrix, double angle, out Matrix3d result)
	{
		double num = MathHelper.DTOR * angle;
		double num2 = Math.Sin(num);
		double num3 = Math.Cos(num);
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

	public static void RotateMatrix(double angle, out Matrix3d result)
	{
		double num = MathHelper.DTOR * angle;
		double num2 = Math.Sin(num);
		double r1C = (result.R0C0 = Math.Cos(num));
		result.R0C1 = num2;
		result.R0C2 = 0.0;
		result.R1C0 = 0.0 - num2;
		result.R1C1 = r1C;
		result.R1C2 = 0.0;
		result.R2C0 = 0.0;
		result.R2C1 = 0.0;
		result.R2C2 = 1.0;
	}

	public override int GetHashCode()
	{
		return R0C0.GetHashCode() ^ R0C1.GetHashCode() ^ R0C2.GetHashCode() ^ R1C0.GetHashCode() ^ R1C1.GetHashCode() ^ R1C2.GetHashCode() ^ R2C0.GetHashCode() ^ R2C1.GetHashCode() ^ R2C2.GetHashCode();
	}

	public override string ToString()
	{
		return string.Format("|{00}, {01}, {02}|\n|{03}, {04}, {05}|\n|{06}, {07}, {08}|\n" + R0C0, R0C1, R0C2, R1C0, R1C1, R1C2, R2C0, R2C1, R2C2);
	}
}
