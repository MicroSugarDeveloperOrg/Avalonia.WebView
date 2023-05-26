using System;
using System.Runtime.InteropServices;

namespace OpenGL;

public struct Vector4 : IEquatable<Vector4>
{
	public float X;

	public float Y;

	public float Z;

	public float W;

	public static Vector4 UnitX = new Vector4(1f, 0f, 0f, 0f);

	public static Vector4 UnitY = new Vector4(0f, 1f, 0f, 0f);

	public static Vector4 UnitZ = new Vector4(0f, 0f, 1f, 0f);

	public static Vector4 UnitW = new Vector4(0f, 0f, 0f, 1f);

	public static Vector4 Zero = new Vector4(0f, 0f, 0f, 0f);

	public static readonly Vector4 One = new Vector4(1f, 1f, 1f, 1f);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector4));

	public float Length => (float)Math.Sqrt(X * X + Y * Y + Z * Z + W * W);

	public float LengthFast => 1f / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);

	public float LengthSquared => X * X + Y * Y + Z * Z + W * W;

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

	public Vector3 Xyz
	{
		get
		{
			return new Vector3(X, Y, Z);
		}
		set
		{
			X = value.X;
			Y = value.Y;
			Z = value.Z;
		}
	}

	public Vector4(float value)
	{
		X = value;
		Y = value;
		Z = value;
		W = value;
	}

	public Vector4(float x, float y, float z, float w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public Vector4(Vector2 v)
	{
		X = v.X;
		Y = v.Y;
		Z = 0f;
		W = 0f;
	}

	public Vector4(Vector3 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = 0f;
	}

	public Vector4(Vector3 v, float w)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = w;
	}

	public Vector4(Vector4 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = v.W;
	}

	[Obsolete("Use static Add() method instead.")]
	public void Add(Vector4 right)
	{
		X += right.X;
		Y += right.Y;
		Z += right.Z;
		W += right.W;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Add() method instead.")]
	public void Add(ref Vector4 right)
	{
		X += right.X;
		Y += right.Y;
		Z += right.Z;
		W += right.W;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(Vector4 right)
	{
		X -= right.X;
		Y -= right.Y;
		Z -= right.Z;
		W -= right.W;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(ref Vector4 right)
	{
		X -= right.X;
		Y -= right.Y;
		Z -= right.Z;
		W -= right.W;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Mult(float f)
	{
		X *= f;
		Y *= f;
		Z *= f;
		W *= f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public void Div(float f)
	{
		float num = 1f / f;
		X *= num;
		Y *= num;
		Z *= num;
		W *= num;
	}

	public void Normalize()
	{
		float num = 1f / Length;
		X *= num;
		Y *= num;
		Z *= num;
		W *= num;
	}

	public void NormalizeFast()
	{
		float num = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
		X *= num;
		Y *= num;
		Z *= num;
		W *= num;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(float sx, float sy, float sz, float sw)
	{
		X *= sx;
		Y *= sy;
		Z *= sz;
		W *= sw;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(Vector4 scale)
	{
		X *= scale.X;
		Y *= scale.Y;
		Z *= scale.Z;
		W *= scale.W;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(ref Vector4 scale)
	{
		X *= scale.X;
		Y *= scale.Y;
		Z *= scale.Z;
		W *= scale.W;
	}

	public static Vector4 Sub(Vector4 a, Vector4 b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		a.Z -= b.Z;
		a.W -= b.W;
		return a;
	}

	public static void Sub(ref Vector4 a, ref Vector4 b, out Vector4 result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
		result.W = a.W - b.W;
	}

	public static Vector4 Mult(Vector4 a, float f)
	{
		a.X *= f;
		a.Y *= f;
		a.Z *= f;
		a.W *= f;
		return a;
	}

	public static void Mult(ref Vector4 a, float f, out Vector4 result)
	{
		result.X = a.X * f;
		result.Y = a.Y * f;
		result.Z = a.Z * f;
		result.W = a.W * f;
	}

	public static Vector4 Div(Vector4 a, float f)
	{
		float num = 1f / f;
		a.X *= num;
		a.Y *= num;
		a.Z *= num;
		a.W *= num;
		return a;
	}

	public static void Div(ref Vector4 a, float f, out Vector4 result)
	{
		float num = 1f / f;
		result.X = a.X * num;
		result.Y = a.Y * num;
		result.Z = a.Z * num;
		result.W = a.W * num;
	}

	public static Vector4 Add(Vector4 a, Vector4 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector4 a, ref Vector4 b, out Vector4 result)
	{
		result = new Vector4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
	}

	public static Vector4 Subtract(Vector4 a, Vector4 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector4 a, ref Vector4 b, out Vector4 result)
	{
		result = new Vector4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
	}

	public static Vector4 Multiply(Vector4 vector, float scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector4 vector, float scale, out Vector4 result)
	{
		result = new Vector4(vector.X * scale, vector.Y * scale, vector.Z * scale, vector.W * scale);
	}

	public static Vector4 Multiply(Vector4 vector, Vector4 scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector4 vector, ref Vector4 scale, out Vector4 result)
	{
		result = new Vector4(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z, vector.W * scale.W);
	}

	public static Vector4 Divide(Vector4 vector, float scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector4 vector, float scale, out Vector4 result)
	{
		Multiply(ref vector, 1f / scale, out result);
	}

	public static Vector4 Divide(Vector4 vector, Vector4 scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector4 vector, ref Vector4 scale, out Vector4 result)
	{
		result = new Vector4(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z, vector.W / scale.W);
	}

	public static Vector4 Min(Vector4 a, Vector4 b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		a.W = ((a.W < b.W) ? a.W : b.W);
		return a;
	}

	public static void Min(ref Vector4 a, ref Vector4 b, out Vector4 result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		result.W = ((a.W < b.W) ? a.W : b.W);
	}

	public static Vector4 Max(Vector4 a, Vector4 b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		a.W = ((a.W > b.W) ? a.W : b.W);
		return a;
	}

	public static void Max(ref Vector4 a, ref Vector4 b, out Vector4 result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		result.W = ((a.W > b.W) ? a.W : b.W);
	}

	public static Vector4 Clamp(Vector4 vec, Vector4 min, Vector4 max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.X < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		vec.W = ((vec.Y < min.W) ? min.W : ((vec.W > max.W) ? max.W : vec.W));
		return vec;
	}

	public static void Clamp(ref Vector4 vec, ref Vector4 min, ref Vector4 max, out Vector4 result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.X < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		result.W = ((vec.Y < min.W) ? min.W : ((vec.W > max.W) ? max.W : vec.W));
	}

	public static Vector4 Normalize(Vector4 vec)
	{
		float num = 1f / vec.Length;
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		vec.W *= num;
		return vec;
	}

	public static void Normalize(ref Vector4 vec, out Vector4 result)
	{
		float num = 1f / vec.Length;
		result.X = vec.X * num;
		result.Y = vec.Y * num;
		result.Z = vec.Z * num;
		result.W = vec.W * num;
	}

	public static Vector4 NormalizeFast(Vector4 vec)
	{
		float num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z + vec.W * vec.W);
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		vec.W *= num;
		return vec;
	}

	public static void NormalizeFast(ref Vector4 vec, out Vector4 result)
	{
		float num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z + vec.W * vec.W);
		result.X = vec.X * num;
		result.Y = vec.Y * num;
		result.Z = vec.Z * num;
		result.W = vec.W * num;
	}

	public static float Dot(Vector4 left, Vector4 right)
	{
		return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
	}

	public static void Dot(ref Vector4 left, ref Vector4 right, out float result)
	{
		result = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
	}

	public static Vector4 Lerp(Vector4 a, Vector4 b, float blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		a.Z = blend * (b.Z - a.Z) + a.Z;
		a.W = blend * (b.W - a.W) + a.W;
		return a;
	}

	public static void Lerp(ref Vector4 a, ref Vector4 b, float blend, out Vector4 result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
		result.Z = blend * (b.Z - a.Z) + a.Z;
		result.W = blend * (b.W - a.W) + a.W;
	}

	public static Vector4 BaryCentric(Vector4 a, Vector4 b, Vector4 c, float u, float v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref Vector4 a, ref Vector4 b, ref Vector4 c, float u, float v, out Vector4 result)
	{
		result = a;
		Vector4 a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static Vector4 Transform(Vector4 vec, Matrix4 mat)
	{
		Transform(ref vec, ref mat, out var result);
		return result;
	}

	public static void Transform(ref Vector4 vec, ref Matrix4 mat, out Vector4 result)
	{
		result = new Vector4(vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X + vec.W * mat.Row3.X, vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y + vec.W * mat.Row3.Y, vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z + vec.W * mat.Row3.Z, vec.X * mat.Row0.W + vec.Y * mat.Row1.W + vec.Z * mat.Row2.W + vec.W * mat.Row3.W);
	}

	public static Vector4 Transform(Vector4 vec, Quaternion quat)
	{
		Transform(ref vec, ref quat, out var result);
		return result;
	}

	public static void Transform(ref Vector4 vec, ref Quaternion quat, out Vector4 result)
	{
		Quaternion right = new Quaternion(vec.X, vec.Y, vec.Z, vec.W);
		Quaternion.Invert(ref quat, out var result2);
		Quaternion.Multiply(ref quat, ref right, out var result3);
		Quaternion.Multiply(ref result3, ref result2, out right);
		result = new Vector4(right.X, right.Y, right.Z, right.W);
	}

	public static Vector4 operator +(Vector4 left, Vector4 right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		left.W += right.W;
		return left;
	}

	public static Vector4 operator -(Vector4 left, Vector4 right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		left.W -= right.W;
		return left;
	}

	public static Vector4 operator -(Vector4 vec)
	{
		vec.X = 0f - vec.X;
		vec.Y = 0f - vec.Y;
		vec.Z = 0f - vec.Z;
		vec.W = 0f - vec.W;
		return vec;
	}

	public static Vector4 operator *(Vector4 vec, float scale)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		vec.W *= scale;
		return vec;
	}

	public static Vector4 operator *(float scale, Vector4 vec)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		vec.W *= scale;
		return vec;
	}

	public static Vector4 operator /(Vector4 vec, float scale)
	{
		float num = 1f / scale;
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		vec.W *= num;
		return vec;
	}

	public static bool operator ==(Vector4 left, Vector4 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector4 left, Vector4 right)
	{
		return !left.Equals(right);
	}

	[CLSCompliant(false)]
	public unsafe static explicit operator float*(Vector4 v)
	{
		return &v.X;
	}

	public unsafe static explicit operator IntPtr(Vector4 v)
	{
		return (IntPtr)(&v.X);
	}

	public override string ToString()
	{
		return $"({X}, {Y}, {Z}, {W})";
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Vector4))
		{
			return false;
		}
		return Equals((Vector4)obj);
	}

	public bool Equals(Vector4 other)
	{
		if (X == other.X && Y == other.Y && Z == other.Z)
		{
			return W == other.W;
		}
		return false;
	}
}
