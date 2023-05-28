using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using OpenTK;

namespace SceneKit;

[Serializable]
public struct SCNVector3 : IEquatable<SCNVector3>
{
	public nfloat X;

	public nfloat Y;

	public nfloat Z;

	public static readonly SCNVector3 UnitX = new SCNVector3(1, 0, 0);

	public static readonly SCNVector3 UnitY = new SCNVector3(0, 1, 0);

	public static readonly SCNVector3 UnitZ = new SCNVector3(0, 0, 1);

	public static readonly SCNVector3 Zero = new SCNVector3(0, 0, 0);

	public static readonly SCNVector3 One = new SCNVector3(1, 1, 1);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(SCNVector3));

	public nfloat Length => (nfloat)Math.Sqrt(X * X + Y * Y + Z * Z);

	public nfloat LengthFast => (nfloat)(1.0 / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z));

	public nfloat LengthSquared => X * X + Y * Y + Z * Z;

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

	public SCNVector3(nfloat x, nfloat y, nfloat z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public SCNVector3(Vector3 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	public SCNVector3(SCNVector3 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	public SCNVector3(SCNVector4 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	public void Normalize()
	{
		nfloat nfloat = 1f / Length;
		X *= nfloat;
		Y *= nfloat;
		Z *= nfloat;
	}

	public void NormalizeFast()
	{
		nfloat nfloat = (nfloat)MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
		X *= nfloat;
		Y *= nfloat;
		Z *= nfloat;
	}

	public static SCNVector3 Add(SCNVector3 a, SCNVector3 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref SCNVector3 a, ref SCNVector3 b, out SCNVector3 result)
	{
		result = new SCNVector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	public static SCNVector3 Subtract(SCNVector3 a, SCNVector3 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref SCNVector3 a, ref SCNVector3 b, out SCNVector3 result)
	{
		result = new SCNVector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	}

	public static SCNVector3 Multiply(SCNVector3 vector, nfloat scale)
	{
		Multiply(ref vector, scale, out vector);
		return vector;
	}

	public static void Multiply(ref SCNVector3 vector, nfloat scale, out SCNVector3 result)
	{
		result = new SCNVector3(vector.X * scale, vector.Y * scale, vector.Z * scale);
	}

	public static SCNVector3 Multiply(SCNVector3 vector, SCNVector3 scale)
	{
		Multiply(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Multiply(ref SCNVector3 vector, ref SCNVector3 scale, out SCNVector3 result)
	{
		result = new SCNVector3(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z);
	}

	public static SCNVector3 Divide(SCNVector3 vector, nfloat scale)
	{
		Divide(ref vector, scale, out vector);
		return vector;
	}

	public static void Divide(ref SCNVector3 vector, nfloat scale, out SCNVector3 result)
	{
		Multiply(ref vector, 1 / scale, out result);
	}

	public static SCNVector3 Divide(SCNVector3 vector, SCNVector3 scale)
	{
		Divide(ref vector, ref scale, out vector);
		return vector;
	}

	public static void Divide(ref SCNVector3 vector, ref SCNVector3 scale, out SCNVector3 result)
	{
		result = new SCNVector3(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z);
	}

	public static SCNVector3 ComponentMin(SCNVector3 a, SCNVector3 b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMin(ref SCNVector3 a, ref SCNVector3 b, out SCNVector3 result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
	}

	public static SCNVector3 ComponentMax(SCNVector3 a, SCNVector3 b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMax(ref SCNVector3 a, ref SCNVector3 b, out SCNVector3 result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
	}

	public static SCNVector3 Min(SCNVector3 left, SCNVector3 right)
	{
		return (left.LengthSquared < right.LengthSquared) ? left : right;
	}

	public static SCNVector3 Max(SCNVector3 left, SCNVector3 right)
	{
		return (left.LengthSquared >= right.LengthSquared) ? left : right;
	}

	public static SCNVector3 Clamp(SCNVector3 vec, SCNVector3 min, SCNVector3 max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		return vec;
	}

	public static void Clamp(ref SCNVector3 vec, ref SCNVector3 min, ref SCNVector3 max, out SCNVector3 result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
	}

	public static SCNVector3 Normalize(SCNVector3 vec)
	{
		nfloat nfloat = 1f / vec.Length;
		vec.X *= nfloat;
		vec.Y *= nfloat;
		vec.Z *= nfloat;
		return vec;
	}

	public static void Normalize(ref SCNVector3 vec, out SCNVector3 result)
	{
		nfloat nfloat = 1f / vec.Length;
		result.X = vec.X * nfloat;
		result.Y = vec.Y * nfloat;
		result.Z = vec.Z * nfloat;
	}

	public static SCNVector3 NormalizeFast(SCNVector3 vec)
	{
		nfloat nfloat = (nfloat)MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
		vec.X *= nfloat;
		vec.Y *= nfloat;
		vec.Z *= nfloat;
		return vec;
	}

	public static void NormalizeFast(ref SCNVector3 vec, out SCNVector3 result)
	{
		nfloat nfloat = (nfloat)MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
		result.X = vec.X * nfloat;
		result.Y = vec.Y * nfloat;
		result.Z = vec.Z * nfloat;
	}

	public static nfloat Dot(SCNVector3 left, SCNVector3 right)
	{
		return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
	}

	public static void Dot(ref SCNVector3 left, ref SCNVector3 right, out nfloat result)
	{
		result = left.X * right.X + left.Y * right.Y + left.Z * right.Z;
	}

	public static SCNVector3 Cross(SCNVector3 left, SCNVector3 right)
	{
		return new SCNVector3(left.Y * right.Z - left.Z * right.Y, left.Z * right.X - left.X * right.Z, left.X * right.Y - left.Y * right.X);
	}

	public static void Cross(ref SCNVector3 left, ref SCNVector3 right, out SCNVector3 result)
	{
		result.X = left.Y * right.Z - left.Z * right.Y;
		result.Y = left.Z * right.X - left.X * right.Z;
		result.Z = left.X * right.Y - left.Y * right.X;
	}

	public static SCNVector3 Lerp(SCNVector3 a, SCNVector3 b, nfloat blend)
	{
		a.X = blend * (b.X - a.X) + a.X;
		a.Y = blend * (b.Y - a.Y) + a.Y;
		a.Z = blend * (b.Z - a.Z) + a.Z;
		return a;
	}

	public static void Lerp(ref SCNVector3 a, ref SCNVector3 b, nfloat blend, out SCNVector3 result)
	{
		result.X = blend * (b.X - a.X) + a.X;
		result.Y = blend * (b.Y - a.Y) + a.Y;
		result.Z = blend * (b.Z - a.Z) + a.Z;
	}

	public static SCNVector3 BaryCentric(SCNVector3 a, SCNVector3 b, SCNVector3 c, nfloat u, nfloat v)
	{
		return a + u * (b - a) + v * (c - a);
	}

	public static void BaryCentric(ref SCNVector3 a, ref SCNVector3 b, ref SCNVector3 c, nfloat u, nfloat v, out SCNVector3 result)
	{
		result = a;
		SCNVector3 a2 = b;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, u, out a2);
		Add(ref result, ref a2, out result);
		a2 = c;
		Subtract(ref a2, ref a, out a2);
		Multiply(ref a2, v, out a2);
		Add(ref result, ref a2, out result);
	}

	public static SCNVector3 TransformVector(SCNVector3 vec, SCNMatrix4 mat)
	{
		SCNVector3 result = default(SCNVector3);
		result.X = Dot(vec, new SCNVector3(mat.Column0));
		result.Y = Dot(vec, new SCNVector3(mat.Column1));
		result.Z = Dot(vec, new SCNVector3(mat.Column2));
		return result;
	}

	public static void TransformVector(ref SCNVector3 vec, ref SCNMatrix4 mat, out SCNVector3 result)
	{
		result.X = vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X;
		result.Y = vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y;
		result.Z = vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z;
	}

	public static SCNVector3 TransformNormal(SCNVector3 norm, SCNMatrix4 mat)
	{
		mat.Invert();
		return TransformNormalInverse(norm, mat);
	}

	public static void TransformNormal(ref SCNVector3 norm, ref SCNMatrix4 mat, out SCNVector3 result)
	{
		SCNMatrix4 invMat = SCNMatrix4.Invert(mat);
		TransformNormalInverse(ref norm, ref invMat, out result);
	}

	public static SCNVector3 TransformNormalInverse(SCNVector3 norm, SCNMatrix4 invMat)
	{
		SCNVector3 result = default(SCNVector3);
		result.X = Dot(norm, new SCNVector3(invMat.Row0));
		result.Y = Dot(norm, new SCNVector3(invMat.Row1));
		result.Z = Dot(norm, new SCNVector3(invMat.Row2));
		return result;
	}

	public static void TransformNormalInverse(ref SCNVector3 norm, ref SCNMatrix4 invMat, out SCNVector3 result)
	{
		result.X = norm.X * invMat.Row0.X + norm.Y * invMat.Row0.Y + norm.Z * invMat.Row0.Z;
		result.Y = norm.X * invMat.Row1.X + norm.Y * invMat.Row1.Y + norm.Z * invMat.Row1.Z;
		result.Z = norm.X * invMat.Row2.X + norm.Y * invMat.Row2.Y + norm.Z * invMat.Row2.Z;
	}

	public static SCNVector3 TransformPosition(SCNVector3 pos, SCNMatrix4 mat)
	{
		SCNVector3 result = default(SCNVector3);
		result.X = Dot(pos, new SCNVector3(mat.Column0)) + mat.Row3.X;
		result.Y = Dot(pos, new SCNVector3(mat.Column1)) + mat.Row3.Y;
		result.Z = Dot(pos, new SCNVector3(mat.Column2)) + mat.Row3.Z;
		return result;
	}

	public static void TransformPosition(ref SCNVector3 pos, ref SCNMatrix4 mat, out SCNVector3 result)
	{
		result.X = pos.X * mat.Row0.X + pos.Y * mat.Row1.X + pos.Z * mat.Row2.X + mat.Row3.X;
		result.Y = pos.X * mat.Row0.Y + pos.Y * mat.Row1.Y + pos.Z * mat.Row2.Y + mat.Row3.Y;
		result.Z = pos.X * mat.Row0.Z + pos.Y * mat.Row1.Z + pos.Z * mat.Row2.Z + mat.Row3.Z;
	}

	public static SCNVector4 Transform(SCNVector3 vec, SCNMatrix4 mat)
	{
		SCNVector4 left = new SCNVector4(vec.X, vec.Y, vec.Z, 1f);
		SCNVector4 result = default(SCNVector4);
		result.X = SCNVector4.Dot(left, mat.Column0);
		result.Y = SCNVector4.Dot(left, mat.Column1);
		result.Z = SCNVector4.Dot(left, mat.Column2);
		result.W = SCNVector4.Dot(left, mat.Column3);
		return result;
	}

	public static void Transform(ref SCNVector3 vec, ref SCNMatrix4 mat, out SCNVector4 result)
	{
		SCNVector4 vec2 = new SCNVector4(vec.X, vec.Y, vec.Z, 1f);
		SCNVector4.Transform(ref vec2, ref mat, out result);
	}

	public static SCNVector3 TransformPerspective(SCNVector3 vec, SCNMatrix4 mat)
	{
		SCNVector4 sCNVector = Transform(vec, mat);
		return new SCNVector3(sCNVector.X / sCNVector.W, sCNVector.Y / sCNVector.W, sCNVector.Z / sCNVector.W);
	}

	public static void TransformPerspective(ref SCNVector3 vec, ref SCNMatrix4 mat, out SCNVector3 result)
	{
		Transform(ref vec, ref mat, out var result2);
		result.X = result2.X / result2.W;
		result.Y = result2.Y / result2.W;
		result.Z = result2.Z / result2.W;
	}

	public static nfloat CalculateAngle(SCNVector3 first, SCNVector3 second)
	{
		return (nfloat)Math.Acos(Dot(first, second) / (first.Length * second.Length));
	}

	public static void CalculateAngle(ref SCNVector3 first, ref SCNVector3 second, out nfloat result)
	{
		Dot(ref first, ref second, out var result2);
		result = (nfloat)Math.Acos(result2 / (first.Length * second.Length));
	}

	public static SCNVector3 operator +(SCNVector3 left, SCNVector3 right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		return left;
	}

	public static SCNVector3 operator -(SCNVector3 left, SCNVector3 right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		return left;
	}

	public static SCNVector3 operator -(SCNVector3 vec)
	{
		vec.X = -vec.X;
		vec.Y = -vec.Y;
		vec.Z = -vec.Z;
		return vec;
	}

	public static SCNVector3 operator *(SCNVector3 vec, nfloat scale)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		return vec;
	}

	public static SCNVector3 operator *(nfloat scale, SCNVector3 vec)
	{
		vec.X *= scale;
		vec.Y *= scale;
		vec.Z *= scale;
		return vec;
	}

	public static SCNVector3 operator /(SCNVector3 vec, nfloat scale)
	{
		nfloat nfloat = 1f / scale;
		vec.X *= nfloat;
		vec.Y *= nfloat;
		vec.Z *= nfloat;
		return vec;
	}

	public static bool operator ==(SCNVector3 left, SCNVector3 right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(SCNVector3 left, SCNVector3 right)
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
		if (!(obj is SCNVector3))
		{
			return false;
		}
		return Equals((SCNVector3)obj);
	}

	public bool Equals(SCNVector3 other)
	{
		return X == other.X && Y == other.Y && Z == other.Z;
	}

	public static implicit operator SCNVector3(Vector3 vector)
	{
		return new SCNVector3(vector.X, vector.Y, vector.Z);
	}

	public static explicit operator Vector3(SCNVector3 source)
	{
		return new Vector3((float)source.X, (float)source.Y, (float)source.Z);
	}
}
