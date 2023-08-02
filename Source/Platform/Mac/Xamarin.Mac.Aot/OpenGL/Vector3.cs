using System;
using System.Runtime.InteropServices;

namespace OpenGL;

public struct Vector3 : IEquatable<Vector3>
{
	public float X;

	public float Y;

	public float Z;

	public static readonly Vector3 UnitX = new Vector3(1f, 0f, 0f);

	public static readonly Vector3 UnitY = new Vector3(0f, 1f, 0f);

	public static readonly Vector3 UnitZ = new Vector3(0f, 0f, 1f);

	public static readonly Vector3 Zero = new Vector3(0f, 0f, 0f);

	public static readonly Vector3 One = new Vector3(1f, 1f, 1f);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector3));

	public float Length => (float)Math.Sqrt(X * X + Y * Y + Z * Z);

	public float LengthFast => 1f / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);

	public float LengthSquared => X * X + Y * Y + Z * Z;

	public Vector2 Xy
	{
		get
		{
			return new Vector2(X, Y);
		}
		set
		{
			X = value.X;
			Y = value.Y;
		}
	}

	public Vector3(float value)
	{
		X = value;
		Y = value;
		Z = value;
	}

	public Vector3(float x, float y, float z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public Vector3(Vector2 v)
	{
		X = v.X;
		Y = v.Y;
		Z = 0f;
	}

	public Vector3(Vector3 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	public Vector3(Vector4 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	[Obsolete("Use static Add() method instead.")]
	public void Add(Vector3 right)
	{
		X += right.X;
		Y += right.Y;
		Z += right.Z;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Add() method instead.")]
	public void Add(ref Vector3 right)
	{
		X += right.X;
		Y += right.Y;
		Z += right.Z;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(Vector3 right)
	{
		X -= right.X;
		Y -= right.Y;
		Z -= right.Z;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(ref Vector3 right)
	{
		X -= right.X;
		Y -= right.Y;
		Z -= right.Z;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Mult(float f)
	{
		X *= f;
		Y *= f;
		Z *= f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public void Div(float f)
	{
		float num = 1f / f;
		X *= num;
		Y *= num;
		Z *= num;
	}

	public void Normalize()
	{
		float num = 1f / Length;
		X *= num;
		Y *= num;
		Z *= num;
	}

	public void NormalizeFast()
	{
		float num = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
		X *= num;
		Y *= num;
		Z *= num;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(float sx, float sy, float sz)
	{
		X *= sx;
		Y *= sy;
		Z *= sz;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(Vector3 scale)
	{
		X *= scale.X;
		Y *= scale.Y;
		Z *= scale.Z;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(ref Vector3 scale)
	{
		X *= scale.X;
		Y *= scale.Y;
		Z *= scale.Z;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static Vector3 Sub(Vector3 a, Vector3 b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		a.Z -= b.Z;
		return a;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static void Sub(ref Vector3 a, ref Vector3 b, out Vector3 result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static Vector3 Mult(Vector3 a, float f)
	{
		a.X *= f;
		a.Y *= f;
		a.Z *= f;
		return a;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static void Mult(ref Vector3 a, float f, out Vector3 result)
	{
		result.X = a.X * f;
		result.Y = a.Y * f;
		result.Z = a.Z * f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static Vector3 Div(Vector3 a, float f)
	{
		float num = 1f / f;
		a.X *= num;
		a.Y *= num;
		a.Z *= num;
		return a;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static void Div(ref Vector3 a, float f, out Vector3 result)
	{
		float num = 1f / f;
		result.X = a.X * num;
		result.Y = a.Y * num;
		result.Z = a.Z * num;
	}

	public static Vector3 Add(Vector3 a, Vector3 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector3 a, ref Vector3 b, out Vector3 result)
	{
		result = new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	public static Vector3 Subtract(Vector3 a, Vector3 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector3 a, ref Vector3 b, out Vector3 result)
	{
		result = new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	}

	public static Vector3 Multiply(Vector3 vector, float scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector3 vector, float scale, out Vector3 result)
	{
		result = new Vector3(vector.X * scale, vector.Y * scale, vector.Z * scale);
	}

	public static Vector3 Multiply(Vector3 vector, Vector3 scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector3 vector, ref Vector3 scale, out Vector3 result)
	{
		result = new Vector3(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z);
	}

	public static Vector3 Divide(Vector3 vector, float scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector3 vector, float scale, out Vector3 result)
	{
		Multiply(ref vector, 1f / scale, out result);
	}

	public static Vector3 Divide(Vector3 vector, Vector3 scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector3 vector, ref Vector3 scale, out Vector3 result)
	{
		result = new Vector3(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z);
	}

	public static Vector3 ComponentMin(Vector3 a, Vector3 b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMin(ref Vector3 a, ref Vector3 b, out Vector3 result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
	}

	public static Vector3 ComponentMax(Vector3 a, Vector3 b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMax(ref Vector3 a, ref Vector3 b, out Vector3 result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
	}

	public static Vector3 Min(Vector3 left, Vector3 right)
	{
		if (!(left.LengthSquared < right.LengthSquared))
		{
			return right;
		}
		return left;
	}

	public static Vector3 Max(Vector3 left, Vector3 right)
	{
		if (!(left.LengthSquared >= right.LengthSquared))
		{
			return right;
		}
		return left;
	}

	public static Vector3 Clamp(Vector3 vec, Vector3 min, Vector3 max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		return vec;
	}

	public static void Clamp(ref Vector3 vec, ref Vector3 min, ref Vector3 max, out Vector3 result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
	}

	public static Vector3 Normalize(Vector3 vec)
	{
		float num = 1f / vec.Length;
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		return vec;
	}

	public static void Normalize(ref Vector3 vec, out Vector3 result)
	{
		float num = 1f / vec.Length;
		result.X = vec.X * num;
		result.Y = vec.Y * num;
		result.Z = vec.Z * num;
	}

	public static Vector3 NormalizeFast(Vector3 vec)
	{
		float num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		return vec;
	}

	public static void NormalizeFast(ref Vector3 vec, out Vector3 result)
	{
		float num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
		result.X = vec.X * num;
		result.Y = vec.Y * num;
		result.Z = vec.Z * num;
	}

	public static float Dot(Vector3 left, Vector3 right)
	{
		return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
	}

	public static void Dot(ref Vector3 left, ref Vector3 right, out float result)
	{
		result = left.X * right.X + left.Y * right.Y + left.Z * right.Z;
	}

	public static Vector3 Cross(Vector3 left, Vector3 right)
	{
		Cross(ref left, ref right, out var result);
		return result;
	}

	public static void Cross(ref Vector3 left, ref Vector3 right, out Vector3 result)
	{
		result = new Vector3(left.Y * right.Z - left.Z * right.Y, left.Z * right.X - left.X * right.Z, left.X * right.Y - left.Y * right.X);
	}

	public static Vector3 Lerp(Vector3 a, Vector3 b, float blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		a.Z = blend * (b.Z - a.Z) + a.Z;
		return a;
	}

	public static void Lerp(ref Vector3 a, ref Vector3 b, float blend, out Vector3 result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
		result.Z = blend * (b.Z - a.Z) + a.Z;
	}

	public static Vector3 BaryCentric(Vector3 a, Vector3 b, Vector3 c, float u, float v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref Vector3 a, ref Vector3 b, ref Vector3 c, float u, float v, out Vector3 result)
	{
		result = a;
		Vector3 a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static Vector3 TransformVector(Vector3 vec, Matrix4 mat)
	{
		Vector3 result = default(Vector3);
		result.X = Dot(vec, new Vector3(mat.Column0));
		result.Y = Dot(vec, new Vector3(mat.Column1));
		result.Z = Dot(vec, new Vector3(mat.Column2));
		return result;
	}

	public static void TransformVector(ref Vector3 vec, ref Matrix4 mat, out Vector3 result)
	{
		result.X = vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X;
		result.Y = vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y;
		result.Z = vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z;
	}

	public static Vector3 TransformNormal(Vector3 norm, Matrix4 mat)
	{
		mat.Invert();
		return TransformNormalInverse(norm, mat);
	}

	public static void TransformNormal(ref Vector3 norm, ref Matrix4 mat, out Vector3 result)
	{
		Matrix4 invMat = Matrix4.Invert(mat);
		TransformNormalInverse(ref norm, ref invMat, out result);
	}

	public static Vector3 TransformNormalInverse(Vector3 norm, Matrix4 invMat)
	{
		Vector3 result = default(Vector3);
		result.X = Dot(norm, new Vector3(invMat.Row0));
		result.Y = Dot(norm, new Vector3(invMat.Row1));
		result.Z = Dot(norm, new Vector3(invMat.Row2));
		return result;
	}

	public static void TransformNormalInverse(ref Vector3 norm, ref Matrix4 invMat, out Vector3 result)
	{
		result.X = norm.X * invMat.Row0.X + norm.Y * invMat.Row0.Y + norm.Z * invMat.Row0.Z;
		result.Y = norm.X * invMat.Row1.X + norm.Y * invMat.Row1.Y + norm.Z * invMat.Row1.Z;
		result.Z = norm.X * invMat.Row2.X + norm.Y * invMat.Row2.Y + norm.Z * invMat.Row2.Z;
	}

	public static Vector3 TransformPosition(Vector3 pos, Matrix4 mat)
	{
		Vector3 result = default(Vector3);
		result.X = Dot(pos, new Vector3(mat.Column0)) + mat.Row3.X;
		result.Y = Dot(pos, new Vector3(mat.Column1)) + mat.Row3.Y;
		result.Z = Dot(pos, new Vector3(mat.Column2)) + mat.Row3.Z;
		return result;
	}

	public static void TransformPosition(ref Vector3 pos, ref Matrix4 mat, out Vector3 result)
	{
		result.X = pos.X * mat.Row0.X + pos.Y * mat.Row1.X + pos.Z * mat.Row2.X + mat.Row3.X;
		result.Y = pos.X * mat.Row0.Y + pos.Y * mat.Row1.Y + pos.Z * mat.Row2.Y + mat.Row3.Y;
		result.Z = pos.X * mat.Row0.Z + pos.Y * mat.Row1.Z + pos.Z * mat.Row2.Z + mat.Row3.Z;
	}

	public static Vector3 Transform(Vector3 vec, Matrix4 mat)
	{
		Transform(ref vec, ref mat, out var result);
		return result;
	}

	public static void Transform(ref Vector3 vec, ref Matrix4 mat, out Vector3 result)
	{
		Vector4 vec2 = new Vector4(vec.X, vec.Y, vec.Z, 1f);
		Vector4.Transform(ref vec2, ref mat, out vec2);
		result = vec2.Xyz;
	}

	public static Vector3 Transform(Vector3 vec, Quaternion quat)
	{
		Transform(ref vec, ref quat, out var result);
		return result;
	}

	public static void Transform(ref Vector3 vec, ref Quaternion quat, out Vector3 result)
	{
		Vector3 left = quat.Xyz;
		Cross(ref left, ref vec, out var result2);
		Multiply(ref vec, quat.W, out var result3);
		Add(ref result2, ref result3, out result2);
		Cross(ref left, ref result2, out result2);
		Multiply(ref result2, 2f, out result2);
		Add(ref vec, ref result2, out result);
	}

	public static Vector3 TransformPerspective(Vector3 vec, Matrix4 mat)
	{
		TransformPerspective(ref vec, ref mat, out var result);
		return result;
	}

	public static void TransformPerspective(ref Vector3 vec, ref Matrix4 mat, out Vector3 result)
	{
		Vector4 vec2 = new Vector4(vec, 1f);
		Vector4.Transform(ref vec2, ref mat, out vec2);
		result.X = vec2.X / vec2.W;
		result.Y = vec2.Y / vec2.W;
		result.Z = vec2.Z / vec2.W;
	}

	public static float CalculateAngle(Vector3 first, Vector3 second)
	{
		return (float)Math.Acos(Dot(first, second) / (first.Length * second.Length));
	}

	public static void CalculateAngle(ref Vector3 first, ref Vector3 second, out float result)
	{
		Dot(ref first, ref second, out var result2);
		result = (float)Math.Acos(result2 / (first.Length * second.Length));
	}

	public static Vector3 operator +(Vector3 left, Vector3 right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		return left;
	}

	public static Vector3 operator -(Vector3 left, Vector3 right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		return left;
	}

	public static Vector3 operator -(Vector3 vec)
	{
		vec.X = 0f - vec.X;
		vec.Y = 0f - vec.Y;
		vec.Z = 0f - vec.Z;
		return vec;
	}

	public static Vector3 operator *(Vector3 vec, float scale)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		return vec;
	}

	public static Vector3 operator *(float scale, Vector3 vec)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		return vec;
	}

	public static Vector3 operator /(Vector3 vec, float scale)
	{
		float num = 1f / scale;
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		return vec;
	}

	public static bool operator ==(Vector3 left, Vector3 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector3 left, Vector3 right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"({X}, {Y}, {Z})";
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Vector3))
		{
			return false;
		}
		return Equals((Vector3)obj);
	}

	public bool Equals(Vector3 other)
	{
		if (X == other.X && Y == other.Y)
		{
			return Z == other.Z;
		}
		return false;
	}
}
