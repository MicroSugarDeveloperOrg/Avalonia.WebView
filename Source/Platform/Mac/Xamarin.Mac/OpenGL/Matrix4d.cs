using System;

namespace OpenGL;

[Serializable]
public struct Matrix4d : IEquatable<Matrix4d>
{
	public Vector4d Row0;

	public Vector4d Row1;

	public Vector4d Row2;

	public Vector4d Row3;

	public static Matrix4d Identity = new Matrix4d(Vector4d.UnitX, Vector4d.UnitY, Vector4d.UnitZ, Vector4d.UnitW);

	public double Determinant => Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;

	public Vector4d Column0 => new Vector4d(Row0.X, Row1.X, Row2.X, Row3.X);

	public Vector4d Column1 => new Vector4d(Row0.Y, Row1.Y, Row2.Y, Row3.Y);

	public Vector4d Column2 => new Vector4d(Row0.Z, Row1.Z, Row2.Z, Row3.Z);

	public Vector4d Column3 => new Vector4d(Row0.W, Row1.W, Row2.W, Row3.W);

	public double M11
	{
		get
		{
			return Row0.X;
		}
		set
		{
			Row0.X = value;
		}
	}

	public double M12
	{
		get
		{
			return Row0.Y;
		}
		set
		{
			Row0.Y = value;
		}
	}

	public double M13
	{
		get
		{
			return Row0.Z;
		}
		set
		{
			Row0.Z = value;
		}
	}

	public double M14
	{
		get
		{
			return Row0.W;
		}
		set
		{
			Row0.W = value;
		}
	}

	public double M21
	{
		get
		{
			return Row1.X;
		}
		set
		{
			Row1.X = value;
		}
	}

	public double M22
	{
		get
		{
			return Row1.Y;
		}
		set
		{
			Row1.Y = value;
		}
	}

	public double M23
	{
		get
		{
			return Row1.Z;
		}
		set
		{
			Row1.Z = value;
		}
	}

	public double M24
	{
		get
		{
			return Row1.W;
		}
		set
		{
			Row1.W = value;
		}
	}

	public double M31
	{
		get
		{
			return Row2.X;
		}
		set
		{
			Row2.X = value;
		}
	}

	public double M32
	{
		get
		{
			return Row2.Y;
		}
		set
		{
			Row2.Y = value;
		}
	}

	public double M33
	{
		get
		{
			return Row2.Z;
		}
		set
		{
			Row2.Z = value;
		}
	}

	public double M34
	{
		get
		{
			return Row2.W;
		}
		set
		{
			Row2.W = value;
		}
	}

	public double M41
	{
		get
		{
			return Row3.X;
		}
		set
		{
			Row3.X = value;
		}
	}

	public double M42
	{
		get
		{
			return Row3.Y;
		}
		set
		{
			Row3.Y = value;
		}
	}

	public double M43
	{
		get
		{
			return Row3.Z;
		}
		set
		{
			Row3.Z = value;
		}
	}

	public double M44
	{
		get
		{
			return Row3.W;
		}
		set
		{
			Row3.W = value;
		}
	}

	public Matrix4d(Vector4d row0, Vector4d row1, Vector4d row2, Vector4d row3)
	{
		Row0 = row0;
		Row1 = row1;
		Row2 = row2;
		Row3 = row3;
	}

	public Matrix4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
	{
		Row0 = new Vector4d(m00, m01, m02, m03);
		Row1 = new Vector4d(m10, m11, m12, m13);
		Row2 = new Vector4d(m20, m21, m22, m23);
		Row3 = new Vector4d(m30, m31, m32, m33);
	}

	public void Invert()
	{
		this = Invert(this);
	}

	public void Transpose()
	{
		this = Transpose(this);
	}

	public static void CreateFromAxisAngle(Vector3d axis, double angle, out Matrix4d result)
	{
		double num = Math.Cos(0.0 - angle);
		double num2 = Math.Sin(0.0 - angle);
		double num3 = 1.0 - num;
		axis.Normalize();
		result = new Matrix4d(num3 * axis.X * axis.X + num, num3 * axis.X * axis.Y - num2 * axis.Z, num3 * axis.X * axis.Z + num2 * axis.Y, 0.0, num3 * axis.X * axis.Y + num2 * axis.Z, num3 * axis.Y * axis.Y + num, num3 * axis.Y * axis.Z - num2 * axis.X, 0.0, num3 * axis.X * axis.Z - num2 * axis.Y, num3 * axis.Y * axis.Z + num2 * axis.X, num3 * axis.Z * axis.Z + num, 0.0, 0.0, 0.0, 0.0, 1.0);
	}

	public static Matrix4d CreateFromAxisAngle(Vector3d axis, double angle)
	{
		CreateFromAxisAngle(axis, angle, out var result);
		return result;
	}

	public static void CreateRotationX(double angle, out Matrix4d result)
	{
		double num = Math.Cos(angle);
		double num2 = Math.Sin(angle);
		result.Row0 = Vector4d.UnitX;
		result.Row1 = new Vector4d(0.0, num, num2, 0.0);
		result.Row2 = new Vector4d(0.0, 0.0 - num2, num, 0.0);
		result.Row3 = Vector4d.UnitW;
	}

	public static Matrix4d CreateRotationX(double angle)
	{
		CreateRotationX(angle, out var result);
		return result;
	}

	public static void CreateRotationY(double angle, out Matrix4d result)
	{
		double num = Math.Cos(angle);
		double num2 = Math.Sin(angle);
		result.Row0 = new Vector4d(num, 0.0, 0.0 - num2, 0.0);
		result.Row1 = Vector4d.UnitY;
		result.Row2 = new Vector4d(num2, 0.0, num, 0.0);
		result.Row3 = Vector4d.UnitW;
	}

	public static Matrix4d CreateRotationY(double angle)
	{
		CreateRotationY(angle, out var result);
		return result;
	}

	public static void CreateRotationZ(double angle, out Matrix4d result)
	{
		double num = Math.Cos(angle);
		double num2 = Math.Sin(angle);
		result.Row0 = new Vector4d(num, num2, 0.0, 0.0);
		result.Row1 = new Vector4d(0.0 - num2, num, 0.0, 0.0);
		result.Row2 = Vector4d.UnitZ;
		result.Row3 = Vector4d.UnitW;
	}

	public static Matrix4d CreateRotationZ(double angle)
	{
		CreateRotationZ(angle, out var result);
		return result;
	}

	public static void CreateTranslation(double x, double y, double z, out Matrix4d result)
	{
		result = Identity;
		result.Row3 = new Vector4d(x, y, z, 1.0);
	}

	public static void CreateTranslation(ref Vector3d vector, out Matrix4d result)
	{
		result = Identity;
		result.Row3 = new Vector4d(vector.X, vector.Y, vector.Z, 1.0);
	}

	public static Matrix4d CreateTranslation(double x, double y, double z)
	{
		CreateTranslation(x, y, z, out var result);
		return result;
	}

	public static Matrix4d CreateTranslation(Vector3d vector)
	{
		CreateTranslation(vector.X, vector.Y, vector.Z, out var result);
		return result;
	}

	public static void CreateOrthographic(double width, double height, double zNear, double zFar, out Matrix4d result)
	{
		CreateOrthographicOffCenter((0.0 - width) / 2.0, width / 2.0, (0.0 - height) / 2.0, height / 2.0, zNear, zFar, out result);
	}

	public static Matrix4d CreateOrthographic(double width, double height, double zNear, double zFar)
	{
		CreateOrthographicOffCenter((0.0 - width) / 2.0, width / 2.0, (0.0 - height) / 2.0, height / 2.0, zNear, zFar, out var result);
		return result;
	}

	public static void CreateOrthographicOffCenter(double left, double right, double bottom, double top, double zNear, double zFar, out Matrix4d result)
	{
		result = default(Matrix4d);
		double num = 1.0 / (right - left);
		double num2 = 1.0 / (top - bottom);
		double num3 = 1.0 / (zFar - zNear);
		result.M11 = 2.0 * num;
		result.M22 = 2.0 * num2;
		result.M33 = -2.0 * num3;
		result.M41 = (0.0 - (right + left)) * num;
		result.M42 = (0.0 - (top + bottom)) * num2;
		result.M43 = (0.0 - (zFar + zNear)) * num3;
		result.M44 = 1.0;
	}

	public static Matrix4d CreateOrthographicOffCenter(double left, double right, double bottom, double top, double zNear, double zFar)
	{
		CreateOrthographicOffCenter(left, right, bottom, top, zNear, zFar, out var result);
		return result;
	}

	public static void CreatePerspectiveFieldOfView(double fovy, double aspect, double zNear, double zFar, out Matrix4d result)
	{
		if (fovy <= 0.0 || fovy > Math.PI)
		{
			throw new ArgumentOutOfRangeException("fovy");
		}
		if (aspect <= 0.0)
		{
			throw new ArgumentOutOfRangeException("aspect");
		}
		if (zNear <= 0.0)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		if (zFar <= 0.0)
		{
			throw new ArgumentOutOfRangeException("zFar");
		}
		double num = zNear * Math.Tan(0.5 * fovy);
		double num2 = 0.0 - num;
		double left = num2 * aspect;
		double right = num * aspect;
		CreatePerspectiveOffCenter(left, right, num2, num, zNear, zFar, out result);
	}

	public static Matrix4d CreatePerspectiveFieldOfView(double fovy, double aspect, double zNear, double zFar)
	{
		CreatePerspectiveFieldOfView(fovy, aspect, zNear, zFar, out var result);
		return result;
	}

	public static void CreatePerspectiveOffCenter(double left, double right, double bottom, double top, double zNear, double zFar, out Matrix4d result)
	{
		if (zNear <= 0.0)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		if (zFar <= 0.0)
		{
			throw new ArgumentOutOfRangeException("zFar");
		}
		if (zNear >= zFar)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		double m = 2.0 * zNear / (right - left);
		double m2 = 2.0 * zNear / (top - bottom);
		double m3 = (right + left) / (right - left);
		double m4 = (top + bottom) / (top - bottom);
		double m5 = (0.0 - (zFar + zNear)) / (zFar - zNear);
		double m6 = (0.0 - 2.0 * zFar * zNear) / (zFar - zNear);
		result = new Matrix4d(m, 0.0, 0.0, 0.0, 0.0, m2, 0.0, 0.0, m3, m4, m5, -1.0, 0.0, 0.0, m6, 0.0);
	}

	public static Matrix4d CreatePerspectiveOffCenter(double left, double right, double bottom, double top, double zNear, double zFar)
	{
		CreatePerspectiveOffCenter(left, right, bottom, top, zNear, zFar, out var result);
		return result;
	}

	[Obsolete("Use CreateTranslation instead.")]
	public static Matrix4d Translation(Vector3d trans)
	{
		return Translation(trans.X, trans.Y, trans.Z);
	}

	[Obsolete("Use CreateTranslation instead.")]
	public static Matrix4d Translation(double x, double y, double z)
	{
		Matrix4d identity = Identity;
		identity.Row3 = new Vector4d(x, y, z, 1.0);
		return identity;
	}

	public static Matrix4d Scale(double scale)
	{
		return Scale(scale, scale, scale);
	}

	public static Matrix4d Scale(Vector3d scale)
	{
		return Scale(scale.X, scale.Y, scale.Z);
	}

	public static Matrix4d Scale(double x, double y, double z)
	{
		Matrix4d result = default(Matrix4d);
		result.Row0 = Vector4d.UnitX * x;
		result.Row1 = Vector4d.UnitY * y;
		result.Row2 = Vector4d.UnitZ * z;
		result.Row3 = Vector4d.UnitW;
		return result;
	}

	public static Matrix4d RotateX(double angle)
	{
		double num = Math.Cos(angle);
		double num2 = Math.Sin(angle);
		Matrix4d result = default(Matrix4d);
		result.Row0 = Vector4d.UnitX;
		result.Row1 = new Vector4d(0.0, num, num2, 0.0);
		result.Row2 = new Vector4d(0.0, 0.0 - num2, num, 0.0);
		result.Row3 = Vector4d.UnitW;
		return result;
	}

	public static Matrix4d RotateY(double angle)
	{
		double num = Math.Cos(angle);
		double num2 = Math.Sin(angle);
		Matrix4d result = default(Matrix4d);
		result.Row0 = new Vector4d(num, 0.0, 0.0 - num2, 0.0);
		result.Row1 = Vector4d.UnitY;
		result.Row2 = new Vector4d(num2, 0.0, num, 0.0);
		result.Row3 = Vector4d.UnitW;
		return result;
	}

	public static Matrix4d RotateZ(double angle)
	{
		double num = Math.Cos(angle);
		double num2 = Math.Sin(angle);
		Matrix4d result = default(Matrix4d);
		result.Row0 = new Vector4d(num, num2, 0.0, 0.0);
		result.Row1 = new Vector4d(0.0 - num2, num, 0.0, 0.0);
		result.Row2 = Vector4d.UnitZ;
		result.Row3 = Vector4d.UnitW;
		return result;
	}

	public static Matrix4d Rotate(Vector3d axis, double angle)
	{
		double num = Math.Cos(0.0 - angle);
		double num2 = Math.Sin(0.0 - angle);
		double num3 = 1.0 - num;
		axis.Normalize();
		Matrix4d result = default(Matrix4d);
		result.Row0 = new Vector4d(num3 * axis.X * axis.X + num, num3 * axis.X * axis.Y - num2 * axis.Z, num3 * axis.X * axis.Z + num2 * axis.Y, 0.0);
		result.Row1 = new Vector4d(num3 * axis.X * axis.Y + num2 * axis.Z, num3 * axis.Y * axis.Y + num, num3 * axis.Y * axis.Z - num2 * axis.X, 0.0);
		result.Row2 = new Vector4d(num3 * axis.X * axis.Z - num2 * axis.Y, num3 * axis.Y * axis.Z + num2 * axis.X, num3 * axis.Z * axis.Z + num, 0.0);
		result.Row3 = Vector4d.UnitW;
		return result;
	}

	public static Matrix4d Rotate(Quaterniond q)
	{
		q.ToAxisAngle(out var axis, out var angle);
		return Rotate(axis, angle);
	}

	public static Matrix4d LookAt(Vector3d eye, Vector3d target, Vector3d up)
	{
		Vector3d vector3d = Vector3d.Normalize(eye - target);
		Vector3d right = Vector3d.Normalize(Vector3d.Cross(up, vector3d));
		Vector3d vector3d2 = Vector3d.Normalize(Vector3d.Cross(vector3d, right));
		Matrix4d matrix4d = new Matrix4d(new Vector4d(right.X, vector3d2.X, vector3d.X, 0.0), new Vector4d(right.Y, vector3d2.Y, vector3d.Y, 0.0), new Vector4d(right.Z, vector3d2.Z, vector3d.Z, 0.0), Vector4d.UnitW);
		return CreateTranslation(-eye) * matrix4d;
	}

	public static Matrix4d LookAt(double eyeX, double eyeY, double eyeZ, double targetX, double targetY, double targetZ, double upX, double upY, double upZ)
	{
		return LookAt(new Vector3d(eyeX, eyeY, eyeZ), new Vector3d(targetX, targetY, targetZ), new Vector3d(upX, upY, upZ));
	}

	public static Matrix4d Frustum(double left, double right, double bottom, double top, double near, double far)
	{
		double num = 1.0 / (right - left);
		double num2 = 1.0 / (top - bottom);
		double num3 = 1.0 / (far - near);
		return new Matrix4d(new Vector4d(2.0 * near * num, 0.0, 0.0, 0.0), new Vector4d(0.0, 2.0 * near * num2, 0.0, 0.0), new Vector4d((right + left) * num, (top + bottom) * num2, (0.0 - (far + near)) * num3, -1.0), new Vector4d(0.0, 0.0, -2.0 * far * near * num3, 0.0));
	}

	public static Matrix4d Perspective(double fovy, double aspect, double near, double far)
	{
		double num = near * Math.Tan(0.5 * fovy);
		double num2 = 0.0 - num;
		double left = num2 * aspect;
		double right = num * aspect;
		return Frustum(left, right, num2, num, near, far);
	}

	public static Matrix4d Mult(Matrix4d left, Matrix4d right)
	{
		Mult(ref left, ref right, out var result);
		return result;
	}

	public static void Mult(ref Matrix4d left, ref Matrix4d right, out Matrix4d result)
	{
		result = default(Matrix4d);
		result.M11 = left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41;
		result.M12 = left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42;
		result.M13 = left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43;
		result.M14 = left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44;
		result.M21 = left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41;
		result.M22 = left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42;
		result.M23 = left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43;
		result.M24 = left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44;
		result.M31 = left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41;
		result.M32 = left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42;
		result.M33 = left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43;
		result.M34 = left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44;
		result.M41 = left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41;
		result.M42 = left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42;
		result.M43 = left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43;
		result.M44 = left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44;
	}

	public static Matrix4d Invert(Matrix4d mat)
	{
		int[] array = new int[4];
		int[] array2 = new int[4];
		int[] array3 = new int[4] { -1, -1, -1, -1 };
		double[,] array4 = new double[4, 4]
		{
			{
				mat.Row0.X,
				mat.Row0.Y,
				mat.Row0.Z,
				mat.Row0.W
			},
			{
				mat.Row1.X,
				mat.Row1.Y,
				mat.Row1.Z,
				mat.Row1.W
			},
			{
				mat.Row2.X,
				mat.Row2.Y,
				mat.Row2.Z,
				mat.Row2.W
			},
			{
				mat.Row3.X,
				mat.Row3.Y,
				mat.Row3.Z,
				mat.Row3.W
			}
		};
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 4; i++)
		{
			double num3 = 0.0;
			for (int j = 0; j < 4; j++)
			{
				if (array3[j] == 0)
				{
					continue;
				}
				for (int k = 0; k < 4; k++)
				{
					if (array3[k] == -1)
					{
						double num4 = Math.Abs(array4[j, k]);
						if (num4 > num3)
						{
							num3 = num4;
							num2 = j;
							num = k;
						}
					}
					else if (array3[k] > 0)
					{
						return mat;
					}
				}
			}
			array3[num]++;
			if (num2 != num)
			{
				for (int l = 0; l < 4; l++)
				{
					double num5 = array4[num2, l];
					array4[num2, l] = array4[num, l];
					array4[num, l] = num5;
				}
			}
			array2[i] = num2;
			array[i] = num;
			double num6 = array4[num, num];
			if (num6 == 0.0)
			{
				throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
			}
			double num7 = 1.0 / num6;
			array4[num, num] = 1.0;
			for (int m = 0; m < 4; m++)
			{
				array4[num, m] *= num7;
			}
			for (int n = 0; n < 4; n++)
			{
				if (num != n)
				{
					double num8 = array4[n, num];
					array4[n, num] = 0.0;
					for (int num9 = 0; num9 < 4; num9++)
					{
						array4[n, num9] -= array4[num, num9] * num8;
					}
				}
			}
		}
		for (int num10 = 3; num10 >= 0; num10--)
		{
			int num11 = array2[num10];
			int num12 = array[num10];
			for (int num13 = 0; num13 < 4; num13++)
			{
				double num14 = array4[num13, num11];
				array4[num13, num11] = array4[num13, num12];
				array4[num13, num12] = num14;
			}
		}
		mat.Row0 = new Vector4d(array4[0, 0], array4[0, 1], array4[0, 2], array4[0, 3]);
		mat.Row1 = new Vector4d(array4[1, 0], array4[1, 1], array4[1, 2], array4[1, 3]);
		mat.Row2 = new Vector4d(array4[2, 0], array4[2, 1], array4[2, 2], array4[2, 3]);
		mat.Row3 = new Vector4d(array4[3, 0], array4[3, 1], array4[3, 2], array4[3, 3]);
		return mat;
	}

	public static Matrix4d Transpose(Matrix4d mat)
	{
		return new Matrix4d(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
	}

	public static void Transpose(ref Matrix4d mat, out Matrix4d result)
	{
		result.Row0 = mat.Column0;
		result.Row1 = mat.Column1;
		result.Row2 = mat.Column2;
		result.Row3 = mat.Column3;
	}

	public static Matrix4d operator *(Matrix4d left, Matrix4d right)
	{
		return Mult(left, right);
	}

	public static bool operator ==(Matrix4d left, Matrix4d right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Matrix4d left, Matrix4d right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"{Row0}\n{Row1}\n{Row2}\n{Row3}";
	}

	public override int GetHashCode()
	{
		return Row0.GetHashCode() ^ Row1.GetHashCode() ^ Row2.GetHashCode() ^ Row3.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Matrix4d))
		{
			return false;
		}
		return Equals((Matrix4d)obj);
	}

	public bool Equals(Matrix4d other)
	{
		if (Row0 == other.Row0 && Row1 == other.Row1 && Row2 == other.Row2)
		{
			return Row3 == other.Row3;
		}
		return false;
	}
}
