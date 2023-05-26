using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenGL;

[Serializable]
public struct Vector3d : IEquatable<Vector3d>
{
	public double X;

	public double Y;

	public double Z;

	public static readonly Vector3d UnitX = new Vector3d(1.0, 0.0, 0.0);

	public static readonly Vector3d UnitY = new Vector3d(0.0, 1.0, 0.0);

	public static readonly Vector3d UnitZ = new Vector3d(0.0, 0.0, 1.0);

	public static readonly Vector3d Zero = new Vector3d(0.0, 0.0, 0.0);

	public static readonly Vector3d One = new Vector3d(1.0, 1.0, 1.0);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector3d));

	public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

	public double LengthFast => 1.0 / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);

	public double LengthSquared => X * X + Y * Y + Z * Z;

	[XmlIgnore]
	public Vector2d Xy
	{
		get
		{
			return new Vector2d(X, Y);
		}
		set
		{
			X = value.X;
			Y = value.Y;
		}
	}

	public Vector3d(double value)
	{
		X = value;
		Y = value;
		Z = value;
	}

	public Vector3d(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public Vector3d(Vector2d v)
	{
		X = v.X;
		Y = v.Y;
		Z = 0.0;
	}

	public Vector3d(Vector3d v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	public Vector3d(Vector4d v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	[Obsolete("Use static Add() method instead.")]
	public void Add(Vector3d right)
	{
		X += right.X;
		Y += right.Y;
		Z += right.Z;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Add() method instead.")]
	public void Add(ref Vector3d right)
	{
		X += right.X;
		Y += right.Y;
		Z += right.Z;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(Vector3d right)
	{
		X -= right.X;
		Y -= right.Y;
		Z -= right.Z;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Subtract() method instead.")]
	public void Sub(ref Vector3d right)
	{
		X -= right.X;
		Y -= right.Y;
		Z -= right.Z;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Mult(double f)
	{
		X *= f;
		Y *= f;
		Z *= f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public void Div(double f)
	{
		double num = 1.0 / f;
		X *= num;
		Y *= num;
		Z *= num;
	}

	public void Normalize()
	{
		double num = 1.0 / Length;
		X *= num;
		Y *= num;
		Z *= num;
	}

	public void NormalizeFast()
	{
		double num = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
		X *= num;
		Y *= num;
		Z *= num;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(double sx, double sy, double sz)
	{
		X *= sx;
		Y *= sy;
		Z *= sz;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(Vector3d scale)
	{
		X *= scale.X;
		Y *= scale.Y;
		Z *= scale.Z;
	}

	[CLSCompliant(false)]
	[Obsolete("Use static Multiply() method instead.")]
	public void Scale(ref Vector3d scale)
	{
		X *= scale.X;
		Y *= scale.Y;
		Z *= scale.Z;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static Vector3d Sub(Vector3d a, Vector3d b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		a.Z -= b.Z;
		return a;
	}

	[Obsolete("Use static Subtract() method instead.")]
	public static void Sub(ref Vector3d a, ref Vector3d b, out Vector3d result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static Vector3d Mult(Vector3d a, double f)
	{
		a.X *= f;
		a.Y *= f;
		a.Z *= f;
		return a;
	}

	[Obsolete("Use static Multiply() method instead.")]
	public static void Mult(ref Vector3d a, double f, out Vector3d result)
	{
		result.X = a.X * f;
		result.Y = a.Y * f;
		result.Z = a.Z * f;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static Vector3d Div(Vector3d a, double f)
	{
		double num = 1.0 / f;
		a.X *= num;
		a.Y *= num;
		a.Z *= num;
		return a;
	}

	[Obsolete("Use static Divide() method instead.")]
	public static void Div(ref Vector3d a, double f, out Vector3d result)
	{
		double num = 1.0 / f;
		result.X = a.X * num;
		result.Y = a.Y * num;
		result.Z = a.Z * num;
	}

	public static Vector3d Add(Vector3d a, Vector3d b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector3d a, ref Vector3d b, out Vector3d result)
	{
		result = new Vector3d(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	public static Vector3d Subtract(Vector3d a, Vector3d b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector3d a, ref Vector3d b, out Vector3d result)
	{
		result = new Vector3d(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	}

	public static Vector3d Multiply(Vector3d vector, double scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector3d vector, double scale, out Vector3d result)
	{
		result = new Vector3d(vector.X * scale, vector.Y * scale, vector.Z * scale);
	}

	public static Vector3d Multiply(Vector3d vector, Vector3d scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref Vector3d vector, ref Vector3d scale, out Vector3d result)
	{
		result = new Vector3d(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z);
	}

	public static Vector3d Divide(Vector3d vector, double scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector3d vector, double scale, out Vector3d result)
	{
		Multiply(ref vector, 1.0 / scale, out result);
	}

	public static Vector3d Divide(Vector3d vector, Vector3d scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref Vector3d vector, ref Vector3d scale, out Vector3d result)
	{
		result = new Vector3d(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z);
	}

	public static Vector3d ComponentMin(Vector3d a, Vector3d b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMin(ref Vector3d a, ref Vector3d b, out Vector3d result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
	}

	public static Vector3d ComponentMax(Vector3d a, Vector3d b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMax(ref Vector3d a, ref Vector3d b, out Vector3d result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
	}

	public static Vector3d Min(Vector3d left, Vector3d right)
	{
		if (!(left.LengthSquared < right.LengthSquared))
		{
			return right;
		}
		return left;
	}

	public static Vector3d Max(Vector3d left, Vector3d right)
	{
		if (!(left.LengthSquared >= right.LengthSquared))
		{
			return right;
		}
		return left;
	}

	public static Vector3d Clamp(Vector3d vec, Vector3d min, Vector3d max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		return vec;
	}

	public static void Clamp(ref Vector3d vec, ref Vector3d min, ref Vector3d max, out Vector3d result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
	}

	public static Vector3d Normalize(Vector3d vec)
	{
		double num = 1.0 / vec.Length;
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		return vec;
	}

	public static void Normalize(ref Vector3d vec, out Vector3d result)
	{
		double num = 1.0 / vec.Length;
		result.X = vec.X * num;
		result.Y = vec.Y * num;
		result.Z = vec.Z * num;
	}

	public static Vector3d NormalizeFast(Vector3d vec)
	{
		double num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		return vec;
	}

	public static void NormalizeFast(ref Vector3d vec, out Vector3d result)
	{
		double num = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
		result.X = vec.X * num;
		result.Y = vec.Y * num;
		result.Z = vec.Z * num;
	}

	public static double Dot(Vector3d left, Vector3d right)
	{
		return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
	}

	public static void Dot(ref Vector3d left, ref Vector3d right, out double result)
	{
		result = left.X * right.X + left.Y * right.Y + left.Z * right.Z;
	}

	public static Vector3d Cross(Vector3d left, Vector3d right)
	{
		Cross(ref left, ref right, out var result);
		return result;
	}

	public static void Cross(ref Vector3d left, ref Vector3d right, out Vector3d result)
	{
		result = new Vector3d(left.Y * right.Z - left.Z * right.Y, left.Z * right.X - left.X * right.Z, left.X * right.Y - left.Y * right.X);
	}

	public static Vector3d Lerp(Vector3d a, Vector3d b, double blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		a.Z = blend * (b.Z - a.Z) + a.Z;
		return a;
	}

	public static void Lerp(ref Vector3d a, ref Vector3d b, double blend, out Vector3d result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
		result.Z = blend * (b.Z - a.Z) + a.Z;
	}

	public static Vector3d BaryCentric(Vector3d a, Vector3d b, Vector3d c, double u, double v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref Vector3d a, ref Vector3d b, ref Vector3d c, double u, double v, out Vector3d result)
	{
		result = a;
		Vector3d a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static Vector3d TransformVector(Vector3d vec, Matrix4d mat)
	{
		return new Vector3d(Dot(vec, new Vector3d(mat.Column0)), Dot(vec, new Vector3d(mat.Column1)), Dot(vec, new Vector3d(mat.Column2)));
	}

	public static void TransformVector(ref Vector3d vec, ref Matrix4d mat, out Vector3d result)
	{
		result.X = vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X;
		result.Y = vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y;
		result.Z = vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z;
	}

	public static Vector3d TransformNormal(Vector3d norm, Matrix4d mat)
	{
		mat.Invert();
		return TransformNormalInverse(norm, mat);
	}

	public static void TransformNormal(ref Vector3d norm, ref Matrix4d mat, out Vector3d result)
	{
		Matrix4d invMat = Matrix4d.Invert(mat);
		TransformNormalInverse(ref norm, ref invMat, out result);
	}

	public static Vector3d TransformNormalInverse(Vector3d norm, Matrix4d invMat)
	{
		return new Vector3d(Dot(norm, new Vector3d(invMat.Row0)), Dot(norm, new Vector3d(invMat.Row1)), Dot(norm, new Vector3d(invMat.Row2)));
	}

	public static void TransformNormalInverse(ref Vector3d norm, ref Matrix4d invMat, out Vector3d result)
	{
		result.X = norm.X * invMat.Row0.X + norm.Y * invMat.Row0.Y + norm.Z * invMat.Row0.Z;
		result.Y = norm.X * invMat.Row1.X + norm.Y * invMat.Row1.Y + norm.Z * invMat.Row1.Z;
		result.Z = norm.X * invMat.Row2.X + norm.Y * invMat.Row2.Y + norm.Z * invMat.Row2.Z;
	}

	public static Vector3d TransformPosition(Vector3d pos, Matrix4d mat)
	{
		return new Vector3d(Dot(pos, new Vector3d(mat.Column0)) + mat.Row3.X, Dot(pos, new Vector3d(mat.Column1)) + mat.Row3.Y, Dot(pos, new Vector3d(mat.Column2)) + mat.Row3.Z);
	}

	public static void TransformPosition(ref Vector3d pos, ref Matrix4d mat, out Vector3d result)
	{
		result.X = pos.X * mat.Row0.X + pos.Y * mat.Row1.X + pos.Z * mat.Row2.X + mat.Row3.X;
		result.Y = pos.X * mat.Row0.Y + pos.Y * mat.Row1.Y + pos.Z * mat.Row2.Y + mat.Row3.Y;
		result.Z = pos.X * mat.Row0.Z + pos.Y * mat.Row1.Z + pos.Z * mat.Row2.Z + mat.Row3.Z;
	}

	public static Vector3d Transform(Vector3d vec, Matrix4d mat)
	{
		Transform(ref vec, ref mat, out var result);
		return result;
	}

	public static void Transform(ref Vector3d vec, ref Matrix4d mat, out Vector3d result)
	{
		Vector4d vec2 = new Vector4d(vec.X, vec.Y, vec.Z, 1.0);
		Vector4d.Transform(ref vec2, ref mat, out vec2);
		result = vec2.Xyz;
	}

	public static Vector3d Transform(Vector3d vec, Quaterniond quat)
	{
		Transform(ref vec, ref quat, out var result);
		return result;
	}

	public static void Transform(ref Vector3d vec, ref Quaterniond quat, out Vector3d result)
	{
		Vector3d left = quat.Xyz;
		Cross(ref left, ref vec, out var result2);
		Multiply(ref vec, quat.W, out var result3);
		Add(ref result2, ref result3, out result2);
		Cross(ref left, ref result2, out result2);
		Multiply(ref result2, 2.0, out result2);
		Add(ref vec, ref result2, out result);
	}

	public static Vector3d TransformPerspective(Vector3d vec, Matrix4d mat)
	{
		TransformPerspective(ref vec, ref mat, out var result);
		return result;
	}

	public static void TransformPerspective(ref Vector3d vec, ref Matrix4d mat, out Vector3d result)
	{
		Vector4d vec2 = new Vector4d(vec, 1.0);
		Vector4d.Transform(ref vec2, ref mat, out vec2);
		result.X = vec2.X / vec2.W;
		result.Y = vec2.Y / vec2.W;
		result.Z = vec2.Z / vec2.W;
	}

	public static double CalculateAngle(Vector3d first, Vector3d second)
	{
		return Math.Acos(Dot(first, second) / (first.Length * second.Length));
	}

	public static void CalculateAngle(ref Vector3d first, ref Vector3d second, out double result)
	{
		Dot(ref first, ref second, out var result2);
		result = Math.Acos(result2 / (first.Length * second.Length));
	}

	public static Vector3d operator +(Vector3d left, Vector3d right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		return left;
	}

	public static Vector3d operator -(Vector3d left, Vector3d right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		return left;
	}

	public static Vector3d operator -(Vector3d vec)
	{
		vec.X = 0.0 - vec.X;
		vec.Y = 0.0 - vec.Y;
		vec.Z = 0.0 - vec.Z;
		return vec;
	}

	public static Vector3d operator *(Vector3d vec, double scale)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		return vec;
	}

	public static Vector3d operator *(double scale, Vector3d vec)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		return vec;
	}

	public static Vector3d operator /(Vector3d vec, double scale)
	{
		double num = 1.0 / scale;
		vec.X *= num;
		vec.Y *= num;
		vec.Z *= num;
		return vec;
	}

	public static bool operator ==(Vector3d left, Vector3d right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector3d left, Vector3d right)
	{
		return !left.Equals(right);
	}

	public static explicit operator Vector3d(Vector3 v3)
	{
		return new Vector3d(v3.X, v3.Y, v3.Z);
	}

	public static explicit operator Vector3(Vector3d v3d)
	{
		return new Vector3((float)v3d.X, (float)v3d.Y, (float)v3d.Z);
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
		if (!(obj is Vector3d))
		{
			return false;
		}
		return Equals((Vector3d)obj);
	}

	public bool Equals(Vector3d other)
	{
		if (X == other.X && Y == other.Y)
		{
			return Z == other.Z;
		}
		return false;
	}
}
