using System;
using CoreAnimation;
using Foundation;
using OpenTK;

namespace SceneKit;

[Serializable]
[Advice("This is a row major matrix representation.")]
public struct SCNMatrix4 : IEquatable<SCNMatrix4>
{
	public SCNVector4 Row0;

	public SCNVector4 Row1;

	public SCNVector4 Row2;

	public SCNVector4 Row3;

	public static readonly SCNMatrix4 Identity = new SCNMatrix4(SCNVector4.UnitX, SCNVector4.UnitY, SCNVector4.UnitZ, SCNVector4.UnitW);

	public nfloat Determinant => Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;

	public SCNVector4 Column0 => new SCNVector4(Row0.X, Row1.X, Row2.X, Row3.X);

	public SCNVector4 Column1 => new SCNVector4(Row0.Y, Row1.Y, Row2.Y, Row3.Y);

	public SCNVector4 Column2 => new SCNVector4(Row0.Z, Row1.Z, Row2.Z, Row3.Z);

	public SCNVector4 Column3 => new SCNVector4(Row0.W, Row1.W, Row2.W, Row3.W);

	public nfloat M11
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

	public nfloat M12
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

	public nfloat M13
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

	public nfloat M14
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

	public nfloat M21
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

	public nfloat M22
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

	public nfloat M23
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

	public nfloat M24
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

	public nfloat M31
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

	public nfloat M32
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

	public nfloat M33
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

	public nfloat M34
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

	public nfloat M41
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

	public nfloat M42
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

	public nfloat M43
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

	public nfloat M44
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

	public SCNMatrix4(SCNVector4 row0, SCNVector4 row1, SCNVector4 row2, SCNVector4 row3)
	{
		Row0 = row0;
		Row1 = row1;
		Row2 = row2;
		Row3 = row3;
	}

	public SCNMatrix4(nfloat m00, nfloat m01, nfloat m02, nfloat m03, nfloat m10, nfloat m11, nfloat m12, nfloat m13, nfloat m20, nfloat m21, nfloat m22, nfloat m23, nfloat m30, nfloat m31, nfloat m32, nfloat m33)
	{
		Row0 = new SCNVector4(m00, m01, m02, m03);
		Row1 = new SCNVector4(m10, m11, m12, m13);
		Row2 = new SCNVector4(m20, m21, m22, m23);
		Row3 = new SCNVector4(m30, m31, m32, m33);
	}

	public SCNMatrix4(CATransform3D transform)
	{
		Row0 = new SCNVector4(transform.m11, transform.m12, transform.m13, transform.m14);
		Row1 = new SCNVector4(transform.m21, transform.m22, transform.m23, transform.m24);
		Row2 = new SCNVector4(transform.m31, transform.m32, transform.m33, transform.m34);
		Row3 = new SCNVector4(transform.m41, transform.m42, transform.m43, transform.m44);
	}

	public void Invert()
	{
		this = Invert(this);
	}

	public void Transpose()
	{
		this = Transpose(this);
	}

	public static void CreateFromAxisAngle(SCNVector3 axis, nfloat angle, out SCNMatrix4 result)
	{
		nfloat nfloat = (float)Math.Cos(-angle);
		nfloat nfloat2 = (float)Math.Sin(-angle);
		nfloat nfloat3 = 1f - nfloat;
		axis.Normalize();
		result = new SCNMatrix4(nfloat3 * axis.X * axis.X + nfloat, nfloat3 * axis.X * axis.Y - nfloat2 * axis.Z, nfloat3 * axis.X * axis.Z + nfloat2 * axis.Y, 0f, nfloat3 * axis.X * axis.Y + nfloat2 * axis.Z, nfloat3 * axis.Y * axis.Y + nfloat, nfloat3 * axis.Y * axis.Z - nfloat2 * axis.X, 0f, nfloat3 * axis.X * axis.Z - nfloat2 * axis.Y, nfloat3 * axis.Y * axis.Z + nfloat2 * axis.X, nfloat3 * axis.Z * axis.Z + nfloat, 0f, 0, 0, 0, 1);
	}

	public static void CreateFromAxisAngle(Vector3 axis, float angle, out SCNMatrix4 result)
	{
		nfloat nfloat = (float)Math.Cos(0f - angle);
		nfloat nfloat2 = (float)Math.Sin(0f - angle);
		nfloat nfloat3 = 1f - nfloat;
		axis.Normalize();
		result = new SCNMatrix4(nfloat3 * axis.X * axis.X + nfloat, nfloat3 * axis.X * axis.Y - nfloat2 * axis.Z, nfloat3 * axis.X * axis.Z + nfloat2 * axis.Y, 0f, nfloat3 * axis.X * axis.Y + nfloat2 * axis.Z, nfloat3 * axis.Y * axis.Y + nfloat, nfloat3 * axis.Y * axis.Z - nfloat2 * axis.X, 0f, nfloat3 * axis.X * axis.Z - nfloat2 * axis.Y, nfloat3 * axis.Y * axis.Z + nfloat2 * axis.X, nfloat3 * axis.Z * axis.Z + nfloat, 0f, 0, 0, 0, 1);
	}

	public static void CreateFromAxisAngle(Vector3d axis, double angle, out SCNMatrix4 result)
	{
		double num = Math.Cos(0.0 - angle);
		double num2 = Math.Sin(0.0 - angle);
		double num3 = 1.0 - num;
		axis.Normalize();
		result = new SCNMatrix4((nfloat)(num3 * axis.X * axis.X + num), (nfloat)(num3 * axis.X * axis.Y - num2 * axis.Z), (nfloat)(num3 * axis.X * axis.Z + num2 * axis.Y), 0f, (nfloat)(num3 * axis.X * axis.Y + num2 * axis.Z), (nfloat)(num3 * axis.Y * axis.Y + num), (nfloat)(num3 * axis.Y * axis.Z - num2 * axis.X), 0f, (nfloat)(num3 * axis.X * axis.Z - num2 * axis.Y), (nfloat)(num3 * axis.Y * axis.Z + num2 * axis.X), (nfloat)(num3 * axis.Z * axis.Z + num), 0f, 0, 0, 0, 1);
	}

	public static SCNMatrix4 CreateFromAxisAngle(SCNVector3 axis, nfloat angle)
	{
		CreateFromAxisAngle(axis, angle, out var result);
		return result;
	}

	public static void CreateRotationX(nfloat angle, out SCNMatrix4 result)
	{
		nfloat nfloat = (nfloat)Math.Cos(angle);
		nfloat nfloat2 = (nfloat)Math.Sin(angle);
		result.Row0 = SCNVector4.UnitX;
		result.Row1 = new SCNVector4(0f, nfloat, nfloat2, 0f);
		result.Row2 = new SCNVector4(0f, -nfloat2, nfloat, 0f);
		result.Row3 = SCNVector4.UnitW;
	}

	public static SCNMatrix4 CreateRotationX(nfloat angle)
	{
		CreateRotationX(angle, out var result);
		return result;
	}

	public static void CreateRotationY(nfloat angle, out SCNMatrix4 result)
	{
		nfloat nfloat = (nfloat)Math.Cos(angle);
		nfloat nfloat2 = (nfloat)Math.Sin(angle);
		result.Row0 = new SCNVector4(nfloat, 0f, -nfloat2, 0f);
		result.Row1 = SCNVector4.UnitY;
		result.Row2 = new SCNVector4(nfloat2, 0f, nfloat, 0f);
		result.Row3 = SCNVector4.UnitW;
	}

	public static SCNMatrix4 CreateRotationY(nfloat angle)
	{
		CreateRotationY(angle, out var result);
		return result;
	}

	public static void CreateRotationZ(nfloat angle, out SCNMatrix4 result)
	{
		nfloat nfloat = (nfloat)Math.Cos(angle);
		nfloat nfloat2 = (nfloat)Math.Sin(angle);
		result.Row0 = new SCNVector4(nfloat, nfloat2, 0f, 0f);
		result.Row1 = new SCNVector4(-nfloat2, nfloat, 0f, 0f);
		result.Row2 = SCNVector4.UnitZ;
		result.Row3 = SCNVector4.UnitW;
	}

	public static SCNMatrix4 CreateRotationZ(nfloat angle)
	{
		CreateRotationZ(angle, out var result);
		return result;
	}

	public static void CreateTranslation(nfloat x, nfloat y, nfloat z, out SCNMatrix4 result)
	{
		result = Identity;
		result.Row3 = new SCNVector4(x, y, z, 1);
	}

	public static void CreateTranslation(ref SCNVector3 vector, out SCNMatrix4 result)
	{
		result = Identity;
		result.Row3 = new SCNVector4(vector.X, vector.Y, vector.Z, 1);
	}

	public static SCNMatrix4 CreateTranslation(nfloat x, nfloat y, nfloat z)
	{
		CreateTranslation(x, y, z, out var result);
		return result;
	}

	public static SCNMatrix4 CreateTranslation(SCNVector3 vector)
	{
		CreateTranslation(vector.X, vector.Y, vector.Z, out var result);
		return result;
	}

	public static void CreateOrthographic(nfloat width, nfloat height, nfloat zNear, nfloat zFar, out SCNMatrix4 result)
	{
		CreateOrthographicOffCenter(-width / 2, width / 2, -height / 2, height / 2, zNear, zFar, out result);
	}

	public static SCNMatrix4 CreateOrthographic(nfloat width, nfloat height, nfloat zNear, nfloat zFar)
	{
		CreateOrthographicOffCenter(-width / 2, width / 2, -height / 2, height / 2, zNear, zFar, out var result);
		return result;
	}

	public static void CreateOrthographicOffCenter(nfloat left, nfloat right, nfloat bottom, nfloat top, nfloat zNear, nfloat zFar, out SCNMatrix4 result)
	{
		result = default(SCNMatrix4);
		nfloat nfloat = 1 / (right - left);
		nfloat nfloat2 = 1 / (top - bottom);
		nfloat nfloat3 = 1 / (zFar - zNear);
		result.M11 = 2 * nfloat;
		result.M22 = 2 * nfloat2;
		result.M33 = -2 * nfloat3;
		result.M41 = -(right + left) * nfloat;
		result.M42 = -(top + bottom) * nfloat2;
		result.M43 = -(zFar + zNear) * nfloat3;
		result.M44 = 1;
	}

	public static SCNMatrix4 CreateOrthographicOffCenter(nfloat left, nfloat right, nfloat bottom, nfloat top, nfloat zNear, nfloat zFar)
	{
		CreateOrthographicOffCenter(left, right, bottom, top, zNear, zFar, out var result);
		return result;
	}

	public static void CreatePerspectiveFieldOfView(nfloat fovy, nfloat aspect, nfloat zNear, nfloat zFar, out SCNMatrix4 result)
	{
		if (fovy <= 0 || (double)fovy > Math.PI)
		{
			throw new ArgumentOutOfRangeException("fovy");
		}
		if (aspect <= 0)
		{
			throw new ArgumentOutOfRangeException("aspect");
		}
		if (zNear <= 0)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		if (zFar <= 0)
		{
			throw new ArgumentOutOfRangeException("zFar");
		}
		if (zNear >= zFar)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		nfloat nfloat = zNear * (float)Math.Tan(0.5f * fovy);
		nfloat nfloat2 = -nfloat;
		nfloat left = nfloat2 * aspect;
		nfloat right = nfloat * aspect;
		CreatePerspectiveOffCenter(left, right, nfloat2, nfloat, zNear, zFar, out result);
	}

	public static SCNMatrix4 CreatePerspectiveFieldOfView(nfloat fovy, nfloat aspect, nfloat zNear, nfloat zFar)
	{
		CreatePerspectiveFieldOfView(fovy, aspect, zNear, zFar, out var result);
		return result;
	}

	public static void CreatePerspectiveOffCenter(nfloat left, nfloat right, nfloat bottom, nfloat top, nfloat zNear, nfloat zFar, out SCNMatrix4 result)
	{
		if (zNear <= 0)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		if (zFar <= 0)
		{
			throw new ArgumentOutOfRangeException("zFar");
		}
		if (zNear >= zFar)
		{
			throw new ArgumentOutOfRangeException("zNear");
		}
		nfloat m = 2f * zNear / (right - left);
		nfloat m2 = 2f * zNear / (top - bottom);
		nfloat m3 = (right + left) / (right - left);
		nfloat m4 = (top + bottom) / (top - bottom);
		nfloat m5 = -(zFar + zNear) / (zFar - zNear);
		nfloat m6 = -(2f * zFar * zNear) / (zFar - zNear);
		result = new SCNMatrix4(m, 0, 0, 0, 0, m2, 0, 0, m3, m4, m5, -1, 0, 0, m6, 0);
	}

	public static SCNMatrix4 CreatePerspectiveOffCenter(nfloat left, nfloat right, nfloat bottom, nfloat top, nfloat zNear, nfloat zFar)
	{
		CreatePerspectiveOffCenter(left, right, bottom, top, zNear, zFar, out var result);
		return result;
	}

	public static SCNMatrix4 Scale(nfloat scale)
	{
		return Scale(scale, scale, scale);
	}

	public static SCNMatrix4 Scale(SCNVector3 scale)
	{
		return Scale(scale.X, scale.Y, scale.Z);
	}

	public static SCNMatrix4 Scale(nfloat x, nfloat y, nfloat z)
	{
		SCNMatrix4 result = default(SCNMatrix4);
		result.Row0 = SCNVector4.UnitX * x;
		result.Row1 = SCNVector4.UnitY * y;
		result.Row2 = SCNVector4.UnitZ * z;
		result.Row3 = SCNVector4.UnitW;
		return result;
	}

	public static SCNMatrix4 Rotate(Quaternion q)
	{
		q.ToAxisAngle(out var axis, out var angle);
		CreateFromAxisAngle(axis, angle, out var result);
		return result;
	}

	public static SCNMatrix4 Rotate(Quaterniond q)
	{
		q.ToAxisAngle(out var axis, out var angle);
		CreateFromAxisAngle(axis, angle, out var result);
		return result;
	}

	public static SCNMatrix4 LookAt(SCNVector3 eye, SCNVector3 target, SCNVector3 up)
	{
		SCNVector3 sCNVector = SCNVector3.Normalize(eye - target);
		SCNVector3 right = SCNVector3.Normalize(SCNVector3.Cross(up, sCNVector));
		SCNVector3 sCNVector2 = SCNVector3.Normalize(SCNVector3.Cross(sCNVector, right));
		SCNMatrix4 sCNMatrix = new SCNMatrix4(new SCNVector4(right.X, sCNVector2.X, sCNVector.X, 0f), new SCNVector4(right.Y, sCNVector2.Y, sCNVector.Y, 0f), new SCNVector4(right.Z, sCNVector2.Z, sCNVector.Z, 0f), SCNVector4.UnitW);
		SCNMatrix4 sCNMatrix2 = CreateTranslation(-eye);
		return sCNMatrix2 * sCNMatrix;
	}

	public static SCNMatrix4 LookAt(nfloat eyeX, nfloat eyeY, nfloat eyeZ, nfloat targetX, nfloat targetY, nfloat targetZ, nfloat upX, nfloat upY, nfloat upZ)
	{
		return LookAt(new SCNVector3(eyeX, eyeY, eyeZ), new SCNVector3(targetX, targetY, targetZ), new SCNVector3(upX, upY, upZ));
	}

	public static SCNMatrix4 Mult(SCNMatrix4 left, SCNMatrix4 right)
	{
		Mult(ref left, ref right, out var result);
		return result;
	}

	public static void Mult(ref SCNMatrix4 left, ref SCNMatrix4 right, out SCNMatrix4 result)
	{
		result = new SCNMatrix4(left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41, left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42, left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43, left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44, left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41, left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42, left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43, left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44, left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41, left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42, left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43, left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44, left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41, left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42, left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43, left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44);
	}

	public static SCNMatrix4 Invert(SCNMatrix4 mat)
	{
		int[] array = new int[4];
		int[] array2 = new int[4];
		int[] array3 = new int[4] { -1, -1, -1, -1 };
		nfloat[,] array4 = new nfloat[4, 4]
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
			nfloat nfloat = 0f;
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
						nfloat nfloat2 = (nfloat)Math.Abs(array4[j, k]);
						if (nfloat2 > nfloat)
						{
							nfloat = nfloat2;
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
					nfloat nfloat3 = array4[num2, l];
					array4[num2, l] = array4[num, l];
					array4[num, l] = nfloat3;
				}
			}
			array2[i] = num2;
			array[i] = num;
			nfloat nfloat4 = array4[num, num];
			if (nfloat4 == 0f)
			{
				throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
			}
			nfloat nfloat5 = 1f / nfloat4;
			array4[num, num] = 1f;
			for (int m = 0; m < 4; m++)
			{
				array4[num, m] *= nfloat5;
			}
			for (int n = 0; n < 4; n++)
			{
				if (num != n)
				{
					nfloat nfloat6 = array4[n, num];
					array4[n, num] = 0f;
					for (int num3 = 0; num3 < 4; num3++)
					{
						array4[n, num3] -= array4[num, num3] * nfloat6;
					}
				}
			}
		}
		for (int num4 = 3; num4 >= 0; num4--)
		{
			int num5 = array2[num4];
			int num6 = array[num4];
			for (int num7 = 0; num7 < 4; num7++)
			{
				nfloat nfloat7 = array4[num7, num5];
				array4[num7, num5] = array4[num7, num6];
				array4[num7, num6] = nfloat7;
			}
		}
		mat.Row0 = new SCNVector4(array4[0, 0], array4[0, 1], array4[0, 2], array4[0, 3]);
		mat.Row1 = new SCNVector4(array4[1, 0], array4[1, 1], array4[1, 2], array4[1, 3]);
		mat.Row2 = new SCNVector4(array4[2, 0], array4[2, 1], array4[2, 2], array4[2, 3]);
		mat.Row3 = new SCNVector4(array4[3, 0], array4[3, 1], array4[3, 2], array4[3, 3]);
		return mat;
	}

	public static SCNMatrix4 Transpose(SCNMatrix4 mat)
	{
		return new SCNMatrix4(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
	}

	public static void Transpose(ref SCNMatrix4 mat, out SCNMatrix4 result)
	{
		result.Row0 = mat.Column0;
		result.Row1 = mat.Column1;
		result.Row2 = mat.Column2;
		result.Row3 = mat.Column3;
	}

	public static SCNMatrix4 operator *(SCNMatrix4 left, SCNMatrix4 right)
	{
		return Mult(left, right);
	}

	public static bool operator ==(SCNMatrix4 left, SCNMatrix4 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(SCNMatrix4 left, SCNMatrix4 right)
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
		if (!(obj is SCNMatrix4))
		{
			return false;
		}
		return Equals((SCNMatrix4)obj);
	}

	public bool Equals(SCNMatrix4 other)
	{
		return Row0 == other.Row0 && Row1 == other.Row1 && Row2 == other.Row2 && Row3 == other.Row3;
	}
}
