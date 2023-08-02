using System;
using System.Runtime.InteropServices;

namespace OpenGL;

[Serializable]
public struct Vector2d : IEquatable<Vector2d>
{
	public double X;

	public double Y;

	public static Vector2d UnitX = new Vector2d(1.0, 0.0);

	public static Vector2d UnitY = new Vector2d(0.0, 1.0);

	public static Vector2d Zero = new Vector2d(0.0, 0.0);

	public static readonly Vector2d One = new Vector2d(1.0, 1.0);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector2d));

	public double Length => Math.Sqrt(X * X + Y * Y);

	public double LengthSquared => X * X + Y * Y;

	public Vector2d PerpendicularRight => new Vector2d(Y, 0.0 - X);

	public Vector2d PerpendicularLeft => new Vector2d(0.0 - Y, X);

	public Vector2d(double value)
	{
		X = value;
		Y = value;
	}

	public Vector2d(double x, double y)
	{
		X = x;
		Y = y;
	}

	[Obsolete("Use static Add() method instead.")]
	public void Add(Vector2d right)
	{
		X += right.X;
		Y += right.Y;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Add() method instead.")]
	public void Add(ref Vector2d right)
	{
		X += right.X;
		Y += right.Y;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(Vector2d right)
	{
		X -= right.X;
		Y -= right.Y;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(ref Vector2d right)
	{
		X -= right.X;
		Y -= right.Y;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Mult(double f)
	{
		X *= f;
		Y *= f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public void Div(double f)
	{
		double num = 1.0 / f;
		X *= num;
		Y *= num;
	}

	public void Normalize()
	{
		double num = 1.0 / Length;
		X *= num;
		Y *= num;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(double sx, double sy)
	{
		X *= sx;
		Y *= sy;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(Vector2d scale)
	{
		X *= scale.X;
		Y *= scale.Y;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(ref Vector2d scale)
	{
		X *= scale.X;
		Y *= scale.Y;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static Vector2d Sub(Vector2d a, Vector2d b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		return a;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static void Sub(ref Vector2d a, ref Vector2d b, out Vector2d result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static Vector2d Mult(Vector2d a, double d)
	{
		a.X *= d;
		a.Y *= d;
		return a;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static void Mult(ref Vector2d a, double d, out Vector2d result)
	{
		result.X = a.X * d;
		result.Y = a.Y * d;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static Vector2d Div(Vector2d a, double d)
	{
		double num = 1.0 / d;
		a.X *= num;
		a.Y *= num;
		return a;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static void Div(ref Vector2d a, double d, out Vector2d result)
	{
		double num = 1.0 / d;
		result.X = a.X * num;
		result.Y = a.Y * num;
	}

	public static Vector2d Add(Vector2d a, Vector2d b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector2d a, ref Vector2d b, out Vector2d result)
	{
		result = new Vector2d(a.X + b.X, a.Y + b.Y);
	}

	public static Vector2d Subtract(Vector2d a, Vector2d b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector2d a, ref Vector2d b, out Vector2d result)
	{
		result = new Vector2d(a.X - b.X, a.Y - b.Y);
	}

	public static Vector2d Multiply(Vector2d vector, double scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector2d vector, double scale, out Vector2d result)
	{
		result = new Vector2d(vector.X * scale, vector.Y * scale);
	}

	public static Vector2d Multiply(Vector2d vector, Vector2d scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector2d vector, ref Vector2d scale, out Vector2d result)
	{
		result = new Vector2d(vector.X * scale.X, vector.Y * scale.Y);
	}

	public static Vector2d Divide(Vector2d vector, double scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector2d vector, double scale, out Vector2d result)
	{
		Multiply(ref vector, 1.0 / scale, out result);
	}

	public static Vector2d Divide(Vector2d vector, Vector2d scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector2d vector, ref Vector2d scale, out Vector2d result)
	{
		result = new Vector2d(vector.X / scale.X, vector.Y / scale.Y);
	}

	public static Vector2d Min(Vector2d a, Vector2d b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		return a;
	}

	public static void Min(ref Vector2d a, ref Vector2d b, out Vector2d result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
	}

	public static Vector2d Max(Vector2d a, Vector2d b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		return a;
	}

	public static void Max(ref Vector2d a, ref Vector2d b, out Vector2d result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
	}

	public static Vector2d Clamp(Vector2d vec, Vector2d min, Vector2d max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		return vec;
	}

	public static void Clamp(ref Vector2d vec, ref Vector2d min, ref Vector2d max, out Vector2d result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
	}

	public static Vector2d Normalize(Vector2d vec)
	{
		double num = 1.0 / vec.Length;
		vec.X *= num;
		vec.Y *= num;
		return vec;
	}

	public static void Normalize(ref Vector2d vec, out Vector2d result)
	{
		double num = 1.0 / vec.Length;
		result.X = vec.X * num;
		result.Y = vec.Y * num;
	}

	public static Vector2d NormalizeFast(Vector2d vec)
	{
		double num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
		vec.X *= num;
		vec.Y *= num;
		return vec;
	}

	public static void NormalizeFast(ref Vector2d vec, out Vector2d result)
	{
		double num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
		result.X = vec.X * num;
		result.Y = vec.Y * num;
	}

	public static double Dot(Vector2d left, Vector2d right)
	{
		return left.X * right.X + left.Y * right.Y;
	}

	public static void Dot(ref Vector2d left, ref Vector2d right, out double result)
	{
		result = left.X * right.X + left.Y * right.Y;
	}

	public static Vector2d Lerp(Vector2d a, Vector2d b, double blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		return a;
	}

	public static void Lerp(ref Vector2d a, ref Vector2d b, double blend, out Vector2d result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
	}

	public static Vector2d BaryCentric(Vector2d a, Vector2d b, Vector2d c, double u, double v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref Vector2d a, ref Vector2d b, ref Vector2d c, double u, double v, out Vector2d result)
	{
		result = a;
		Vector2d a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static Vector2d Transform(Vector2d vec, Quaterniond quat)
	{
		Transform(ref vec, ref quat, out var result);
		return result;
	}

	public static void Transform(ref Vector2d vec, ref Quaterniond quat, out Vector2d result)
	{
		Quaterniond right = new Quaterniond(vec.X, vec.Y, 0.0, 0.0);
		Quaterniond.Invert(ref quat, out var result2);
		Quaterniond.Multiply(ref quat, ref right, out var result3);
		Quaterniond.Multiply(ref result3, ref result2, out right);
		result = new Vector2d(right.X, right.Y);
	}

	public static Vector2d operator +(Vector2d left, Vector2d right)
	{
		left.X += right.X;
		left.Y += right.Y;
		return left;
	}

	public static Vector2d operator -(Vector2d left, Vector2d right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		return left;
	}

	public static Vector2d operator -(Vector2d vec)
	{
		vec.X = 0.0 - vec.X;
		vec.Y = 0.0 - vec.Y;
		return vec;
	}

	public static Vector2d operator *(Vector2d vec, double f)
	{
		vec.X *= f;
		vec.Y *= f;
		return vec;
	}

	public static Vector2d operator *(double f, Vector2d vec)
	{
		vec.X *= f;
		vec.Y *= f;
		return vec;
	}

	public static Vector2d operator /(Vector2d vec, double f)
	{
		double num = 1.0 / f;
		vec.X *= num;
		vec.Y *= num;
		return vec;
	}

	public static bool operator ==(Vector2d left, Vector2d right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector2d left, Vector2d right)
	{
		return !left.Equals(right);
	}

	public static explicit operator Vector2d(Vector2 v2)
	{
		return new Vector2d(v2.X, v2.Y);
	}

	public static explicit operator Vector2(Vector2d v2d)
	{
		return new Vector2((float)v2d.X, (float)v2d.Y);
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
		if (!(obj is Vector2d))
		{
			return false;
		}
		return Equals((Vector2d)obj);
	}

	public bool Equals(Vector2d other)
	{
		if (X == other.X)
		{
			return Y == other.Y;
		}
		return false;
	}
}
