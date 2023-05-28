using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using OpenTK;

namespace SceneKit;

[Serializable]
public struct SCNVector4 : IEquatable<SCNVector4>
{
	public nfloat X;

	public nfloat Y;

	public nfloat Z;

	public nfloat W;

	public static readonly SCNVector4 UnitX = new SCNVector4(1, 0, 0, 0);

	public static readonly SCNVector4 UnitY = new SCNVector4(0, 1, 0, 0);

	public static readonly SCNVector4 UnitZ = new SCNVector4(0, 0, 1, 0);

	public static readonly SCNVector4 UnitW = new SCNVector4(0, 0, 0, 1);

	public static readonly SCNVector4 Zero = new SCNVector4(0, 0, 0, 0);

	public static readonly SCNVector4 One = new SCNVector4(1, 1, 1, 1);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(SCNVector4));

	public nfloat Length => (nfloat)Math.Sqrt(X * X + Y * Y + Z * Z + W * W);

	public nfloat LengthFast => (nfloat)(1.0 / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W));

	public nfloat LengthSquared => X * X + Y * Y + Z * Z + W * W;

	[XmlIgnore]
	public Vector2 Xy
	{
		get
		{
			return new Vector2((float)X, (float)Y);
		}
		set
		{
			X = value.X;
			Y = value.Y;
		}
	}

	[XmlIgnore]
	public SCNVector3 Xyz
	{
		get
		{
			return new SCNVector3(X, Y, Z);
		}
		set
		{
			X = value.X;
			Y = value.Y;
			Z = value.Z;
		}
	}

	public SCNVector4(nfloat x, nfloat y, nfloat z, nfloat w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public SCNVector4(Vector2 v)
	{
		X = v.X;
		Y = v.Y;
		Z = 0f;
		W = 0f;
	}

	public SCNVector4(SCNVector3 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = 0f;
	}

	public SCNVector4(Vector3 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = 0f;
	}

	public SCNVector4(Vector4 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = v.W;
	}

	public SCNVector4(SCNVector3 v, nfloat w)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = w;
	}

	public SCNVector4(SCNVector4 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = v.W;
	}

	public void Normalize()
	{
		nfloat nfloat = 1f / Length;
		X *= nfloat;
		Y *= nfloat;
		Z *= nfloat;
		W *= nfloat;
	}

	public void NormalizeFast()
	{
		nfloat nfloat = (nfloat)MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
		X *= nfloat;
		Y *= nfloat;
		Z *= nfloat;
		W *= nfloat;
	}

	public static SCNVector4 Sub(SCNVector4 a, SCNVector4 b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		a.Z -= b.Z;
		a.W -= b.W;
		return a;
	}

	public static void Sub(ref SCNVector4 a, ref SCNVector4 b, out SCNVector4 result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
		result.W = a.W - b.W;
	}

	public static SCNVector4 Mult(SCNVector4 a, nfloat f)
	{
		a.X *= f;
		a.Y *= f;
		a.Z *= f;
		a.W *= f;
		return a;
	}

	public static void Mult(ref SCNVector4 a, nfloat f, out SCNVector4 result)
	{
		result.X = a.X * f;
		result.Y = a.Y * f;
		result.Z = a.Z * f;
		result.W = a.W * f;
	}

	public static SCNVector4 Div(SCNVector4 a, nfloat f)
	{
		nfloat nfloat = 1f / f;
		a.X *= nfloat;
		a.Y *= nfloat;
		a.Z *= nfloat;
		a.W *= nfloat;
		return a;
	}

	public static void Div(ref SCNVector4 a, nfloat f, out SCNVector4 result)
	{
		nfloat nfloat = 1f / f;
		result.X = a.X * nfloat;
		result.Y = a.Y * nfloat;
		result.Z = a.Z * nfloat;
		result.W = a.W * nfloat;
	}

	public static SCNVector4 Add(SCNVector4 a, SCNVector4 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref SCNVector4 a, ref SCNVector4 b, out SCNVector4 result)
	{
		result = new SCNVector4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
	}

	public static SCNVector4 Subtract(SCNVector4 a, SCNVector4 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref SCNVector4 a, ref SCNVector4 b, out SCNVector4 result)
	{
		result = new SCNVector4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
	}

	public static SCNVector4 Multiply(SCNVector4 vector, nfloat scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref SCNVector4 vector, nfloat scale, out SCNVector4 result)
	{
		result = new SCNVector4(vector.X * scale, vector.Y * scale, vector.Z * scale, vector.W * scale);
	}

	public static SCNVector4 Multiply(SCNVector4 vector, SCNVector4 scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref SCNVector4 vector, ref SCNVector4 scale, out SCNVector4 result)
	{
		result = new SCNVector4(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z, vector.W * scale.W);
	}

	public static SCNVector4 Divide(SCNVector4 vector, nfloat scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref SCNVector4 vector, nfloat scale, out SCNVector4 result)
	{
		Multiply(ref vector, 1 / scale, out result);
	}

	public static SCNVector4 Divide(SCNVector4 vector, SCNVector4 scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref SCNVector4 vector, ref SCNVector4 scale, out SCNVector4 result)
	{
		result = new SCNVector4(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z, vector.W / scale.W);
	}

	public static SCNVector4 Min(SCNVector4 a, SCNVector4 b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		a.W = ((a.W < b.W) ? a.W : b.W);
		return a;
	}

	public static void Min(ref SCNVector4 a, ref SCNVector4 b, out SCNVector4 result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		result.W = ((a.W < b.W) ? a.W : b.W);
	}

	public static SCNVector4 Max(SCNVector4 a, SCNVector4 b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		a.W = ((a.W > b.W) ? a.W : b.W);
		return a;
	}

	public static void Max(ref SCNVector4 a, ref SCNVector4 b, out SCNVector4 result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		result.W = ((a.W > b.W) ? a.W : b.W);
	}

	public static SCNVector4 Clamp(SCNVector4 vec, SCNVector4 min, SCNVector4 max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.X < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		vec.W = ((vec.Y < min.W) ? min.W : ((vec.W > max.W) ? max.W : vec.W));
		return vec;
	}

	public static void Clamp(ref SCNVector4 vec, ref SCNVector4 min, ref SCNVector4 max, out SCNVector4 result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.X < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		result.W = ((vec.Y < min.W) ? min.W : ((vec.W > max.W) ? max.W : vec.W));
	}

	public static SCNVector4 Normalize(SCNVector4 vec)
	{
		nfloat nfloat = 1f / vec.Length;
		vec.X *= nfloat;
		vec.Y *= nfloat;
		vec.Z *= nfloat;
		vec.W *= nfloat;
		return vec;
	}

	public static void Normalize(ref SCNVector4 vec, out SCNVector4 result)
	{
		nfloat nfloat = 1f / vec.Length;
		result.X = vec.X * nfloat;
		result.Y = vec.Y * nfloat;
		result.Z = vec.Z * nfloat;
		result.W = vec.W * nfloat;
	}

	public static SCNVector4 NormalizeFast(SCNVector4 vec)
	{
		nfloat nfloat = (nfloat)MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z + vec.W * vec.W);
		vec.X *= nfloat;
		vec.Y *= nfloat;
		vec.Z *= nfloat;
		vec.W *= nfloat;
		return vec;
	}

	public static void NormalizeFast(ref SCNVector4 vec, out SCNVector4 result)
	{
		nfloat nfloat = (nfloat)MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z + vec.W * vec.W);
		result.X = vec.X * nfloat;
		result.Y = vec.Y * nfloat;
		result.Z = vec.Z * nfloat;
		result.W = vec.W * nfloat;
	}

	public static nfloat Dot(SCNVector4 left, SCNVector4 right)
	{
		return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
	}

	public static void Dot(ref SCNVector4 left, ref SCNVector4 right, out nfloat result)
	{
		result = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
	}

	public static SCNVector4 Lerp(SCNVector4 a, SCNVector4 b, nfloat blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		a.Z = blend * (b.Z - a.Z) + a.Z;
		a.W = blend * (b.W - a.W) + a.W;
		return a;
	}

	public static void Lerp(ref SCNVector4 a, ref SCNVector4 b, nfloat blend, out SCNVector4 result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
		result.Z = blend * (b.Z - a.Z) + a.Z;
		result.W = blend * (b.W - a.W) + a.W;
	}

	public static SCNVector4 BaryCentric(SCNVector4 a, SCNVector4 b, SCNVector4 c, nfloat u, nfloat v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref SCNVector4 a, ref SCNVector4 b, ref SCNVector4 c, nfloat u, nfloat v, out SCNVector4 result)
	{
		result = a;
		SCNVector4 a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static SCNVector4 Transform(SCNVector4 vec, SCNMatrix4 mat)
	{
		SCNVector4 result = default(SCNVector4);
		result.X = Dot(vec, mat.Column0);
		result.Y = Dot(vec, mat.Column1);
		result.Z = Dot(vec, mat.Column2);
		result.W = Dot(vec, mat.Column3);
		return result;
	}

	public static void Transform(ref SCNVector4 vec, ref SCNMatrix4 mat, out SCNVector4 result)
	{
		result.X = vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X + vec.W * mat.Row3.X;
		result.Y = vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y + vec.W * mat.Row3.Y;
		result.Z = vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z + vec.W * mat.Row3.Z;
		result.W = vec.X * mat.Row0.W + vec.Y * mat.Row1.W + vec.Z * mat.Row2.W + vec.W * mat.Row3.W;
	}

	public static SCNVector4 operator +(SCNVector4 left, SCNVector4 right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		left.W += right.W;
		return left;
	}

	public static SCNVector4 operator -(SCNVector4 left, SCNVector4 right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		left.W -= right.W;
		return left;
	}

	public static SCNVector4 operator -(SCNVector4 vec)
	{
		vec.X = -vec.X;
		vec.Y = -vec.Y;
		vec.Z = -vec.Z;
		vec.W = -vec.W;
		return vec;
	}

	public static SCNVector4 operator *(SCNVector4 vec, nfloat scale)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		vec.W *= scale;
		return vec;
	}

	public static SCNVector4 operator *(nfloat scale, SCNVector4 vec)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		vec.W *= scale;
		return vec;
	}

	public static SCNVector4 operator /(SCNVector4 vec, nfloat scale)
	{
		nfloat nfloat = 1f / scale;
		vec.X *= nfloat;
		vec.Y *= nfloat;
		vec.Z *= nfloat;
		vec.W *= nfloat;
		return vec;
	}

	public static bool operator ==(SCNVector4 left, SCNVector4 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(SCNVector4 left, SCNVector4 right)
	{
		return !left.Equals(right);
	}

	[CLSCompliant(false)]
	public unsafe static explicit operator nfloat*(SCNVector4 v)
	{
		return &v.X;
	}

	public unsafe static explicit operator IntPtr(SCNVector4 v)
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
		if (!(obj is SCNVector4))
		{
			return false;
		}
		return Equals((SCNVector4)obj);
	}

	public bool Equals(SCNVector4 other)
	{
		return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
	}

	public static implicit operator SCNVector4(Vector4 vector)
	{
		return new SCNVector4(vector.X, vector.Y, vector.Z, vector.W);
	}

	public static explicit operator Vector4(SCNVector4 source)
	{
		return new Vector4((float)source.X, (float)source.Y, (float)source.Z, (float)source.W);
	}
}
