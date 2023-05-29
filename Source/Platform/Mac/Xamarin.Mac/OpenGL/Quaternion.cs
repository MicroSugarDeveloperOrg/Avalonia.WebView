using System;

namespace OpenGL;

public struct Quaternion : IEquatable<Quaternion>
{
	private Vector3 xyz;

	private float w;

	public static Quaternion Identity = new Quaternion(0f, 0f, 0f, 1f);

	[Obsolete("Use Xyz property instead.")]
	[CLSCompliant(false)]
	public Vector3 XYZ
	{
		get
		{
			return Xyz;
		}
		set
		{
			Xyz = value;
		}
	}

	public Vector3 Xyz
	{
		get
		{
			return xyz;
		}
		set
		{
			xyz = value;
		}
	}

	public float X
	{
		get
		{
			return xyz.X;
		}
		set
		{
			xyz.X = value;
		}
	}

	public float Y
	{
		get
		{
			return xyz.Y;
		}
		set
		{
			xyz.Y = value;
		}
	}

	public float Z
	{
		get
		{
			return xyz.Z;
		}
		set
		{
			xyz.Z = value;
		}
	}

	public float W
	{
		get
		{
			return w;
		}
		set
		{
			w = value;
		}
	}

	public float Length => (float)Math.Sqrt(W * W + Xyz.LengthSquared);

	public float LengthSquared => W * W + Xyz.LengthSquared;

	public Quaternion(Vector3 v, float w)
	{
		xyz = v;
		this.w = w;
	}

	public Quaternion(float x, float y, float z, float w)
		: this(new Vector3(x, y, z), w)
	{
	}

	public void ToAxisAngle(out Vector3 axis, out float angle)
	{
		Vector4 vector = ToAxisAngle();
		axis = vector.Xyz;
		angle = vector.W;
	}

	public Vector4 ToAxisAngle()
	{
		Quaternion quaternion = this;
		if (quaternion.W > 1f)
		{
			quaternion.Normalize();
		}
		Vector4 result = default(Vector4);
		result.W = 2f * (float)Math.Acos(quaternion.W);
		float num = (float)Math.Sqrt(1.0 - (double)(quaternion.W * quaternion.W));
		if (num > 0.0001f)
		{
			result.Xyz = quaternion.Xyz / num;
		}
		else
		{
			result.Xyz = Vector3.UnitX;
		}
		return result;
	}

	public void Normalize()
	{
		float num = 1f / Length;
		Xyz *= num;
		W *= num;
	}

	public void Conjugate()
	{
		Xyz = -Xyz;
	}

	public static Quaternion Add(Quaternion left, Quaternion right)
	{
		return new Quaternion(left.Xyz + right.Xyz, left.W + right.W);
	}

	public static void Add(ref Quaternion left, ref Quaternion right, out Quaternion result)
	{
		result = new Quaternion(left.Xyz + right.Xyz, left.W + right.W);
	}

	public static Quaternion Sub(Quaternion left, Quaternion right)
	{
		return new Quaternion(left.Xyz - right.Xyz, left.W - right.W);
	}

	public static void Sub(ref Quaternion left, ref Quaternion right, out Quaternion result)
	{
		result = new Quaternion(left.Xyz - right.Xyz, left.W - right.W);
	}

	[Obsolete("Use Multiply instead.")]
	public static Quaternion Mult(Quaternion left, Quaternion right)
	{
		return new Quaternion(right.W * left.Xyz + left.W * right.Xyz + Vector3.Cross(left.Xyz, right.Xyz), left.W * right.W - Vector3.Dot(left.Xyz, right.Xyz));
	}

	[Obsolete("Use Multiply instead.")]
	public static void Mult(ref Quaternion left, ref Quaternion right, out Quaternion result)
	{
		result = new Quaternion(right.W * left.Xyz + left.W * right.Xyz + Vector3.Cross(left.Xyz, right.Xyz), left.W * right.W - Vector3.Dot(left.Xyz, right.Xyz));
	}

	public static Quaternion Multiply(Quaternion left, Quaternion right)
	{
		Multiply(ref left, ref right, out var result);
		return result;
	}

	public static void Multiply(ref Quaternion left, ref Quaternion right, out Quaternion result)
	{
		result = new Quaternion(right.W * left.Xyz + left.W * right.Xyz + Vector3.Cross(left.Xyz, right.Xyz), left.W * right.W - Vector3.Dot(left.Xyz, right.Xyz));
	}

	public static void Multiply(ref Quaternion quaternion, float scale, out Quaternion result)
	{
		result = new Quaternion(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
	}

	public static Quaternion Multiply(Quaternion quaternion, float scale)
	{
		return new Quaternion(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
	}

	public static Quaternion Conjugate(Quaternion q)
	{
		return new Quaternion(-q.Xyz, q.W);
	}

	public static void Conjugate(ref Quaternion q, out Quaternion result)
	{
		result = new Quaternion(-q.Xyz, q.W);
	}

	public static Quaternion Invert(Quaternion q)
	{
		Invert(ref q, out var result);
		return result;
	}

	public static void Invert(ref Quaternion q, out Quaternion result)
	{
		float lengthSquared = q.LengthSquared;
		if ((double)lengthSquared != 0.0)
		{
			float num = 1f / lengthSquared;
			result = new Quaternion(q.Xyz * (0f - num), q.W * num);
		}
		else
		{
			result = q;
		}
	}

	public static Quaternion Normalize(Quaternion q)
	{
		Normalize(ref q, out var result);
		return result;
	}

	public static void Normalize(ref Quaternion q, out Quaternion result)
	{
		float num = 1f / q.Length;
		result = new Quaternion(q.Xyz * num, q.W * num);
	}

	public static Quaternion FromAxisAngle(Vector3 axis, float angle)
	{
		if (axis.LengthSquared == 0f)
		{
			return Identity;
		}
		Quaternion identity = Identity;
		angle *= 0.5f;
		axis.Normalize();
		identity.Xyz = axis * (float)Math.Sin(angle);
		identity.W = (float)Math.Cos(angle);
		return Normalize(identity);
	}

	public static Quaternion Slerp(Quaternion q1, Quaternion q2, float blend)
	{
		if (q1.LengthSquared == 0f)
		{
			if (q2.LengthSquared == 0f)
			{
				return Identity;
			}
			return q2;
		}
		if (q2.LengthSquared == 0f)
		{
			return q1;
		}
		float num = q1.W * q2.W + Vector3.Dot(q1.Xyz, q2.Xyz);
		if (num >= 1f || num <= -1f)
		{
			return q1;
		}
		if (num < 0f)
		{
			q2.Xyz = -q2.Xyz;
			q2.W = 0f - q2.W;
			num = 0f - num;
		}
		float num5;
		float num6;
		if (num < 0.99f)
		{
			float num2 = (float)Math.Acos(num);
			float num3 = (float)Math.Sin(num2);
			float num4 = 1f / num3;
			num5 = (float)Math.Sin(num2 * (1f - blend)) * num4;
			num6 = (float)Math.Sin(num2 * blend) * num4;
		}
		else
		{
			num5 = 1f - blend;
			num6 = blend;
		}
		Quaternion q3 = new Quaternion(num5 * q1.Xyz + num6 * q2.Xyz, num5 * q1.W + num6 * q2.W);
		if (q3.LengthSquared > 0f)
		{
			return Normalize(q3);
		}
		return Identity;
	}

	public static Quaternion operator +(Quaternion left, Quaternion right)
	{
		left.Xyz += right.Xyz;
		left.W += right.W;
		return left;
	}

	public static Quaternion operator -(Quaternion left, Quaternion right)
	{
		left.Xyz -= right.Xyz;
		left.W -= right.W;
		return left;
	}

	public static Quaternion operator *(Quaternion left, Quaternion right)
	{
		Multiply(ref left, ref right, out left);
		return left;
	}

	public static Quaternion operator *(Quaternion quaternion, float scale)
	{
		Multiply(ref quaternion, scale, out quaternion);
		return quaternion;
	}

	public static Quaternion operator *(float scale, Quaternion quaternion)
	{
		return new Quaternion(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
	}

	public static bool operator ==(Quaternion left, Quaternion right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Quaternion left, Quaternion right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"V: {Xyz}, W: {W}";
	}

	public override bool Equals(object other)
	{
		if (!(other is Quaternion))
		{
			return false;
		}
		return this == (Quaternion)other;
	}

	public override int GetHashCode()
	{
		return Xyz.GetHashCode() ^ W.GetHashCode();
	}

	public bool Equals(Quaternion other)
	{
		if (Xyz == other.Xyz)
		{
			return W == other.W;
		}
		return false;
	}
}
