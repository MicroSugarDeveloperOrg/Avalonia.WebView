using System;
using System.Runtime.InteropServices;

namespace OpenGL;

public struct Vector2 : IEquatable<Vector2>
{
	public float X;

	public float Y;

	public static readonly Vector2 UnitX = new Vector2(1f, 0f);

	public static readonly Vector2 UnitY = new Vector2(0f, 1f);

	public static readonly Vector2 Zero = new Vector2(0f, 0f);

	public static readonly Vector2 One = new Vector2(1f, 1f);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector2));

	public float Length => (float)Math.Sqrt(X * X + Y * Y);

	public float LengthFast => 1f / MathHelper.InverseSqrtFast(X * X + Y * Y);

	public float LengthSquared => X * X + Y * Y;

	public Vector2 PerpendicularRight => new Vector2(Y, 0f - X);

	public Vector2 PerpendicularLeft => new Vector2(0f - Y, X);

	public Vector2(float value)
	{
		X = value;
		Y = value;
	}

	public Vector2(float x, float y)
	{
		X = x;
		Y = y;
	}

	[Obsolete]
	public Vector2(Vector2 v)
	{
		X = v.X;
		Y = v.Y;
	}

	[Obsolete]
	public Vector2(Vector3 v)
	{
		X = v.X;
		Y = v.Y;
	}

	[Obsolete]
	public Vector2(Vector4 v)
	{
		X = v.X;
		Y = v.Y;
	}

	[Obsolete("Use static Add() method instead.")]
	public void Add(Vector2 right)
	{
		X += right.X;
		Y += right.Y;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Add() method instead.")]
	public void Add(ref Vector2 right)
	{
		X += right.X;
		Y += right.Y;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(Vector2 right)
	{
		X -= right.X;
		Y -= right.Y;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(ref Vector2 right)
	{
		X -= right.X;
		Y -= right.Y;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Mult(float f)
	{
		X *= f;
		Y *= f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public void Div(float f)
	{
		float num = 1f / f;
		X *= num;
		Y *= num;
	}

	public void Normalize()
	{
		float num = 1f / Length;
		X *= num;
		Y *= num;
	}

	public void NormalizeFast()
	{
		float num = MathHelper.InverseSqrtFast(X * X + Y * Y);
		X *= num;
		Y *= num;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(float sx, float sy)
	{
		X *= sx;
		Y *= sy;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(Vector2 scale)
	{
		X *= scale.X;
		Y *= scale.Y;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(ref Vector2 scale)
	{
		X *= scale.X;
		Y *= scale.Y;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static Vector2 Sub(Vector2 a, Vector2 b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		return a;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static void Sub(ref Vector2 a, ref Vector2 b, out Vector2 result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static Vector2 Mult(Vector2 a, float f)
	{
		a.X *= f;
		a.Y *= f;
		return a;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static void Mult(ref Vector2 a, float f, out Vector2 result)
	{
		result.X = a.X * f;
		result.Y = a.Y * f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static Vector2 Div(Vector2 a, float f)
	{
		float num = 1f / f;
		a.X *= num;
		a.Y *= num;
		return a;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static void Div(ref Vector2 a, float f, out Vector2 result)
	{
		float num = 1f / f;
		result.X = a.X * num;
		result.Y = a.Y * num;
	}

	public static Vector2 Add(Vector2 a, Vector2 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector2 a, ref Vector2 b, out Vector2 result)
	{
		result = new Vector2(a.X + b.X, a.Y + b.Y);
	}

	public static Vector2 Subtract(Vector2 a, Vector2 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector2 a, ref Vector2 b, out Vector2 result)
	{
		result = new Vector2(a.X - b.X, a.Y - b.Y);
	}

	public static Vector2 Multiply(Vector2 vector, float scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector2 vector, float scale, out Vector2 result)
	{
		result = new Vector2(vector.X * scale, vector.Y * scale);
	}

	public static Vector2 Multiply(Vector2 vector, Vector2 scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector2 vector, ref Vector2 scale, out Vector2 result)
	{
		result = new Vector2(vector.X * scale.X, vector.Y * scale.Y);
	}

	public static Vector2 Divide(Vector2 vector, float scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector2 vector, float scale, out Vector2 result)
	{
		Multiply(ref vector, 1f / scale, out result);
	}

	public static Vector2 Divide(Vector2 vector, Vector2 scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector2 vector, ref Vector2 scale, out Vector2 result)
	{
		result = new Vector2(vector.X / scale.X, vector.Y / scale.Y);
	}

	public static Vector2 ComponentMin(Vector2 a, Vector2 b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		return a;
	}

	public static void ComponentMin(ref Vector2 a, ref Vector2 b, out Vector2 result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
	}

	public static Vector2 ComponentMax(Vector2 a, Vector2 b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		return a;
	}

	public static void ComponentMax(ref Vector2 a, ref Vector2 b, out Vector2 result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
	}

	public static Vector2 Min(Vector2 left, Vector2 right)
	{
		if (!(left.LengthSquared < right.LengthSquared))
		{
			return right;
		}
		return left;
	}

	public static Vector2 Max(Vector2 left, Vector2 right)
	{
		if (!(left.LengthSquared >= right.LengthSquared))
		{
			return right;
		}
		return left;
	}

	public static Vector2 Clamp(Vector2 vec, Vector2 min, Vector2 max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		return vec;
	}

	public static void Clamp(ref Vector2 vec, ref Vector2 min, ref Vector2 max, out Vector2 result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
	}

	public static Vector2 Normalize(Vector2 vec)
	{
		float num = 1f / vec.Length;
		vec.X *= num;
		vec.Y *= num;
		return vec;
	}

	public static void Normalize(ref Vector2 vec, out Vector2 result)
	{
		float num = 1f / vec.Length;
		result.X = vec.X * num;
		result.Y = vec.Y * num;
	}

	public static Vector2 NormalizeFast(Vector2 vec)
	{
		float num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
		vec.X *= num;
		vec.Y *= num;
		return vec;
	}

	public static void NormalizeFast(ref Vector2 vec, out Vector2 result)
	{
		float num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
		result.X = vec.X * num;
		result.Y = vec.Y * num;
	}

	public static float Dot(Vector2 left, Vector2 right)
	{
		return left.X * right.X + left.Y * right.Y;
	}

	public static void Dot(ref Vector2 left, ref Vector2 right, out float result)
	{
		result = left.X * right.X + left.Y * right.Y;
	}

	public static Vector2 Lerp(Vector2 a, Vector2 b, float blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		return a;
	}

	public static void Lerp(ref Vector2 a, ref Vector2 b, float blend, out Vector2 result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
	}

	public static Vector2 BaryCentric(Vector2 a, Vector2 b, Vector2 c, float u, float v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref Vector2 a, ref Vector2 b, ref Vector2 c, float u, float v, out Vector2 result)
	{
		result = a;
		Vector2 a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static Vector2 Transform(Vector2 vec, Quaternion quat)
	{
		Transform(ref vec, ref quat, out var result);
		return result;
	}

	public static void Transform(ref Vector2 vec, ref Quaternion quat, out Vector2 result)
	{
		Quaternion right = new Quaternion(vec.X, vec.Y, 0f, 0f);
		Quaternion.Invert(ref quat, out var result2);
		Quaternion.Multiply(ref quat, ref right, out var result3);
		Quaternion.Multiply(ref result3, ref result2, out right);
		result = new Vector2(right.X, right.Y);
	}

	public static Vector2 operator +(Vector2 left, Vector2 right)
	{
		left.X += right.X;
		left.Y += right.Y;
		return left;
	}

	public static Vector2 operator -(Vector2 left, Vector2 right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		return left;
	}

	public static Vector2 operator -(Vector2 vec)
	{
		vec.X = 0f - vec.X;
		vec.Y = 0f - vec.Y;
		return vec;
	}

	public static Vector2 operator *(Vector2 vec, float scale)
	{
		vec.X *= scale;
		vec.Y *= scale;
		return vec;
	}

	public static Vector2 operator *(float scale, Vector2 vec)
	{
		vec.X *= scale;
		vec.Y *= scale;
		return vec;
	}

	public static Vector2 operator /(Vector2 vec, float scale)
	{
		float num = 1f / scale;
		vec.X *= num;
		vec.Y *= num;
		return vec;
	}

	public static bool operator ==(Vector2 left, Vector2 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector2 left, Vector2 right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"({X}, {Y})";
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Vector2))
		{
			return false;
		}
		return Equals((Vector2)obj);
	}

	public bool Equals(Vector2 other)
	{
		if (X == other.X)
		{
			return Y == other.Y;
		}
		return false;
	}
}
