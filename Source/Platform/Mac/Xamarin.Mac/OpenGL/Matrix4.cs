using System;

namespace OpenGL;

public struct Matrix4 : IEquatable<Matrix4>
{
	public Vector4 Row0;

	public Vector4 Row1;

	public Vector4 Row2;

	public Vector4 Row3;

	public static Matrix4 Identity = new Matrix4(Vector4.UnitX, Vector4.UnitY, Vector4.UnitZ, Vector4.UnitW);

	public float Determinant => Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;

	public Vector4 Column0 => new Vector4(Row0.X, Row1.X, Row2.X, Row3.X);

	public Vector4 Column1 => new Vector4(Row0.Y, Row1.Y, Row2.Y, Row3.Y);

	public Vector4 Column2 => new Vector4(Row0.Z, Row1.Z, Row2.Z, Row3.Z);

	public Vector4 Column3 => new Vector4(Row0.W, Row1.W, Row2.W, Row3.W);

	public float M11
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

	public float M12
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

	public float M13
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

	public float M14
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

	public float M21
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

	public float M22
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

	public float M23
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

	public float M24
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

	public float M31
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

	public float M32
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

	public float M33
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

	public float M34
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

	public float M41
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

	public float M42
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

	public float M43
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

	public float M44
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

	public Matrix4(Vector4 row0, Vector4 row1, Vector4 row2, Vector4 row3)
	{
		Row0 = row0;
		Row1 = row1;
		Row2 = row2;
		Row3 = row3;
	}

	public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
	{
		Row0 = new Vector4(m00, m01, m02, m03);
		Row1 = new Vector4(m10, m11, m12, m13);
		Row2 = new Vector4(m20, m21, m22, m23);
		Row3 = new Vector4(m30, m31, m32, m33);
	}

	public void Invert()
	{
		this = Invert(this);
	}

	public void Transpose()
	{
		this = Transpose(this);
	}

	public static void CreateFromAxisAngle(Vector3 axis, float angle, out Matrix4 result)
	{
		float num = (float)Math.Cos(0f - angle);
		float num2 = (float)Math.Sin(0f - angle);
		float num3 = 1f - num;
		axis.Normalize();
		result = new Matrix4(num3 * axis.X * axis.X + num, num3 * axis.X * axis.Y - num2 * axis.Z, num3 * axis.X * axis.Z + num2 * axis.Y, 0f, num3 * axis.X * axis.Y + num2 * axis.Z, num3 * axis.Y * axis.Y + num, num3 * axis.Y * axis.Z - num2 * axis.X, 0f, num3 * axis.X * axis.Z - num2 * axis.Y, num3 * axis.Y * axis.Z + num2 * axis.X, num3 * axis.Z * axis.Z + num, 0f, 0f, 0f, 0f, 1f);
	}

	public static Matrix4 CreateFromAxisAngle(Vector3 axis, float angle)
	{
		CreateFromAxisAngle(axis, angle, out var result);
		return result;
	}

	public static void CreateRotationX(float angle, out Matrix4 result)
	{
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		result.Row0 = Vector4.UnitX;
		result.Row1 = new Vector4(0f, num, num2, 0f);
		result.Row2 = new Vector4(0f, 0f - num2, num, 0f);
		result.Row3 = Vector4.UnitW;
	}

	public static Matrix4 CreateRotationX(float angle)
	{
		CreateRotationX(angle, out var result);
		return result;
	}

	public static void CreateRotationY(float angle, out Matrix4 result)
	{
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		result.Row0 = new Vector4(num, 0f, 0f - num2, 0f);
		result.Row1 = Vector4.UnitY;
		result.Row2 = new Vector4(num2, 0f, num, 0f);
		result.Row3 = Vector4.UnitW;
	}

	public static Matrix4 CreateRotationY(float angle)
	{
		CreateRotationY(angle, out var result);
		return result;
	}

	public static void CreateRotationZ(float angle, out Matrix4 result)
	{
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		result.Row0 = new Vector4(num, num2, 0f, 0f);
		result.Row1 = new Vector4(0f - num2, num, 0f, 0f);
		result.Row2 = Vector4.UnitZ;
		result.Row3 = Vector4.UnitW;
	}

	public static Matrix4 CreateRotationZ(float angle)
	{
		CreateRotationZ(angle, out var result);
		return result;
	}

	public static void CreateTranslation(float x, float y, float z, out Matrix4 result)
	{
		result = Identity;
		result.Row3 = new Vector4(x, y, z, 1f);
	}

	public static void CreateTranslation(ref Vector3 vector, out Matrix4 result)
	{
		result = Identity;
		result.Row3 = new Vector4(vector.X, vector.Y, vector.Z, 1f);
	}

	public static Matrix4 CreateTranslation(float x, float y, float z)
	{
		CreateTranslation(x, y, z, out var result);
		return result;
	}

	public static Matrix4 CreateTranslation(Vector3 vector)
	{
		CreateTranslation(vector.X, vector.Y, vector.Z, out var result);
		return result;
	}

	public static void CreateOrthographic(float width, float height, float zNear, float zFar, out Matrix4 result)
	{
		CreateOrthographicOffCenter((0f - width) / 2f, width / 2f, (0f - height) / 2f, height / 2f, zNear, zFar, out result);
	}

	public static Matrix4 CreateOrthographic(float width, float height, float zNear, float zFar)
	{
		CreateOrthographicOffCenter((0f - width) / 2f, width / 2f, (0f - height) / 2f, height / 2f, zNear, zFar, out var result);
		return result;
	}

	public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4 result)
	{
		result = default(Matrix4);
		float num = 1f / (right - left);
		float num2 = 1f / (top - bottom);
		float num3 = 1f / (zFar - zNear);
		result.M11 = 2f * num;
		result.M22 = 2f * num2;
		result.M33 = -2f * num3;
		result.M41 = (0f - (right + left)) * num;
		result.M42 = (0f - (top + bottom)) * num2;
		result.M43 = (0f - (zFar + zNear)) * num3;
		result.M44 = 1f;
	}

	public static Matrix4 CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNear, float zFar)
	{
		CreateOrthographicOffCenter(left, right, bottom, top, zNear, zFar, out var result);
		return result;
	}

	public static void CreatePerspectiveFieldOfView(float fovy, float aspect, float zNear, float zFar, out Matrix4 result)
	{
		if (fovy <= 0f || (double)fovy > Math.PI)
		{
			throw new ArgumentOutOfRangeException("fovy");
		}
		if (aspect <= 0f)
		{
			throw new ArgumentOutOfRangeException("aspect");
		}
		if (zNear <= 0f)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		if (zFar <= 0f)
		{
			throw new ArgumentOutOfRangeException("zFar");
		}
		float num = zNear * (float)Math.Tan(0.5f * fovy);
		float num2 = 0f - num;
		float left = num2 * aspect;
		float right = num * aspect;
		CreatePerspectiveOffCenter(left, right, num2, num, zNear, zFar, out result);
	}

	public static Matrix4 CreatePerspectiveFieldOfView(float fovy, float aspect, float zNear, float zFar)
	{
		CreatePerspectiveFieldOfView(fovy, aspect, zNear, zFar, out var result);
		return result;
	}

	public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4 result)
	{
		if (zNear <= 0f)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		if (zFar <= 0f)
		{
			throw new ArgumentOutOfRangeException("zFar");
		}
		if (zNear >= zFar)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		float m = 2f * zNear / (right - left);
		float m2 = 2f * zNear / (top - bottom);
		float m3 = (right + left) / (right - left);
		float m4 = (top + bottom) / (top - bottom);
		float m5 = (0f - (zFar + zNear)) / (zFar - zNear);
		float m6 = (0f - 2f * zFar * zNear) / (zFar - zNear);
		result = new Matrix4(m, 0f, 0f, 0f, 0f, m2, 0f, 0f, m3, m4, m5, -1f, 0f, 0f, m6, 0f);
	}

	public static Matrix4 CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float zNear, float zFar)
	{
		CreatePerspectiveOffCenter(left, right, bottom, top, zNear, zFar, out var result);
		return result;
	}

	[Obsolete("Use CreateTranslation instead.")]
	public static Matrix4 Translation(Vector3 trans)
	{
		return Translation(trans.X, trans.Y, trans.Z);
	}

	[Obsolete("Use CreateTranslation instead.")]
	public static Matrix4 Translation(float x, float y, float z)
	{
		Matrix4 identity = Identity;
		identity.Row3 = new Vector4(x, y, z, 1f);
		return identity;
	}

	public static Matrix4 Scale(float scale)
	{
		return Scale(scale, scale, scale);
	}

	public static Matrix4 Scale(Vector3 scale)
	{
		return Scale(scale.X, scale.Y, scale.Z);
	}

	public static Matrix4 Scale(float x, float y, float z)
	{
		Matrix4 result = default(Matrix4);
		result.Row0 = Vector4.UnitX * x;
		result.Row1 = Vector4.UnitY * y;
		result.Row2 = Vector4.UnitZ * z;
		result.Row3 = Vector4.UnitW;
		return result;
	}

	[Obsolete("Use CreateRotationX instead.")]
	public static Matrix4 RotateX(float angle)
	{
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		Matrix4 result = default(Matrix4);
		result.Row0 = Vector4.UnitX;
		result.Row1 = new Vector4(0f, num, num2, 0f);
		result.Row2 = new Vector4(0f, 0f - num2, num, 0f);
		result.Row3 = Vector4.UnitW;
		return result;
	}

	[Obsolete("Use CreateRotationY instead.")]
	public static Matrix4 RotateY(float angle)
	{
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		Matrix4 result = default(Matrix4);
		result.Row0 = new Vector4(num, 0f, 0f - num2, 0f);
		result.Row1 = Vector4.UnitY;
		result.Row2 = new Vector4(num2, 0f, num, 0f);
		result.Row3 = Vector4.UnitW;
		return result;
	}

	[Obsolete("Use CreateRotationZ instead.")]
	public static Matrix4 RotateZ(float angle)
	{
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		Matrix4 result = default(Matrix4);
		result.Row0 = new Vector4(num, num2, 0f, 0f);
		result.Row1 = new Vector4(0f - num2, num, 0f, 0f);
		result.Row2 = Vector4.UnitZ;
		result.Row3 = Vector4.UnitW;
		return result;
	}

	[Obsolete("Use CreateFromAxisAngle instead.")]
	public static Matrix4 Rotate(Vector3 axis, float angle)
	{
		float num = (float)Math.Cos(0f - angle);
		float num2 = (float)Math.Sin(0f - angle);
		float num3 = 1f - num;
		axis.Normalize();
		Matrix4 result = default(Matrix4);
		result.Row0 = new Vector4(num3 * axis.X * axis.X + num, num3 * axis.X * axis.Y - num2 * axis.Z, num3 * axis.X * axis.Z + num2 * axis.Y, 0f);
		result.Row1 = new Vector4(num3 * axis.X * axis.Y + num2 * axis.Z, num3 * axis.Y * axis.Y + num, num3 * axis.Y * axis.Z - num2 * axis.X, 0f);
		result.Row2 = new Vector4(num3 * axis.X * axis.Z - num2 * axis.Y, num3 * axis.Y * axis.Z + num2 * axis.X, num3 * axis.Z * axis.Z + num, 0f);
		result.Row3 = Vector4.UnitW;
		return result;
	}

	public static Matrix4 Rotate(Quaternion q)
	{
		q.ToAxisAngle(out var axis, out var angle);
		return CreateFromAxisAngle(axis, angle);
	}

	public static Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
	{
		Vector3 vector = Vector3.Normalize(eye - target);
		Vector3 right = Vector3.Normalize(Vector3.Cross(up, vector));
		Vector3 vector2 = Vector3.Normalize(Vector3.Cross(vector, right));
		Matrix4 matrix = new Matrix4(new Vector4(right.X, vector2.X, vector.X, 0f), new Vector4(right.Y, vector2.Y, vector.Y, 0f), new Vector4(right.Z, vector2.Z, vector.Z, 0f), Vector4.UnitW);
		return CreateTranslation(-eye) * matrix;
	}

	public static Matrix4 LookAt(float eyeX, float eyeY, float eyeZ, float targetX, float targetY, float targetZ, float upX, float upY, float upZ)
	{
		return LookAt(new Vector3(eyeX, eyeY, eyeZ), new Vector3(targetX, targetY, targetZ), new Vector3(upX, upY, upZ));
	}

	[Obsolete("Use CreatePerspectiveOffCenter instead.")]
	public static Matrix4 Frustum(float left, float right, float bottom, float top, float near, float far)
	{
		float num = 1f / (right - left);
		float num2 = 1f / (top - bottom);
		float num3 = 1f / (far - near);
		return new Matrix4(new Vector4(2f * near * num, 0f, 0f, 0f), new Vector4(0f, 2f * near * num2, 0f, 0f), new Vector4((right + left) * num, (top + bottom) * num2, (0f - (far + near)) * num3, -1f), new Vector4(0f, 0f, -2f * far * near * num3, 0f));
	}

	[Obsolete("Use CreatePerspectiveFieldOfView instead.")]
	public static Matrix4 Perspective(float fovy, float aspect, float near, float far)
	{
		float num = near * (float)Math.Tan(0.5f * fovy);
		float num2 = 0f - num;
		float left = num2 * aspect;
		float right = num * aspect;
		return Frustum(left, right, num2, num, near, far);
	}

	public static Matrix4 Mult(Matrix4 left, Matrix4 right)
	{
		Mult(ref left, ref right, out var result);
		return result;
	}

	public static void Mult(ref Matrix4 left, ref Matrix4 right, out Matrix4 result)
	{
		result = new Matrix4(left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41, left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42, left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43, left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44, left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41, left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42, left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43, left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44, left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41, left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42, left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43, left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44, left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41, left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42, left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43, left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44);
	}

	public static Matrix4 Invert(Matrix4 mat)
	{
		int[] array = new int[4];
		int[] array2 = new int[4];
		int[] array3 = new int[4] { -1, -1, -1, -1 };
		float[,] array4 = new float[4, 4]
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
			float num3 = 0f;
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
						float num4 = Math.Abs(array4[j, k]);
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
					float num5 = array4[num2, l];
					array4[num2, l] = array4[num, l];
					array4[num, l] = num5;
				}
			}
			array2[i] = num2;
			array[i] = num;
			float num6 = array4[num, num];
			if (num6 == 0f)
			{
				throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
			}
			float num7 = 1f / num6;
			array4[num, num] = 1f;
			for (int m = 0; m < 4; m++)
			{
				array4[num, m] *= num7;
			}
			for (int n = 0; n < 4; n++)
			{
				if (num != n)
				{
					float num8 = array4[n, num];
					array4[n, num] = 0f;
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
				float num14 = array4[num13, num11];
				array4[num13, num11] = array4[num13, num12];
				array4[num13, num12] = num14;
			}
		}
		mat.Row0 = new Vector4(array4[0, 0], array4[0, 1], array4[0, 2], array4[0, 3]);
		mat.Row1 = new Vector4(array4[1, 0], array4[1, 1], array4[1, 2], array4[1, 3]);
		mat.Row2 = new Vector4(array4[2, 0], array4[2, 1], array4[2, 2], array4[2, 3]);
		mat.Row3 = new Vector4(array4[3, 0], array4[3, 1], array4[3, 2], array4[3, 3]);
		return mat;
	}

	public static Matrix4 Transpose(Matrix4 mat)
	{
		return new Matrix4(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
	}

	public static void Transpose(ref Matrix4 mat, out Matrix4 result)
	{
		result.Row0 = mat.Column0;
		result.Row1 = mat.Column1;
		result.Row2 = mat.Column2;
		result.Row3 = mat.Column3;
	}

	public static Matrix4 operator *(Matrix4 left, Matrix4 right)
	{
		return Mult(left, right);
	}

	public static bool operator ==(Matrix4 left, Matrix4 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Matrix4 left, Matrix4 right)
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
		if (!(obj is Matrix4))
		{
			return false;
		}
		return Equals((Matrix4)obj);
	}

	public bool Equals(Matrix4 other)
	{
		if (Row0 == other.Row0 && Row1 == other.Row1 && Row2 == other.Row2)
		{
			return Row3 == other.Row3;
		}
		return false;
	}
}
