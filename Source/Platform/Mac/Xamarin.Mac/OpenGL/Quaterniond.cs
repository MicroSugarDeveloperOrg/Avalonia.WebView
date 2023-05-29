using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OpenGL;

[Serializable]
public struct Quaterniond : IEquatable<Quaterniond>
{
	private Vector3d xyz;

	private double w;

	public static readonly Quaterniond Identity = new Quaterniond(0.0, 0.0, 0.0, 1.0);

	[Obsolete("Use Xyz property instead.")]
	[CLSCompliant(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlIgnore]
	public Vector3d XYZ
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

	public Vector3d Xyz
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

	[XmlIgnore]
	public double X
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

	[XmlIgnore]
	public double Y
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

	[XmlIgnore]
	public double Z
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

	public double W
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

	public double Length => Math.Sqrt(W * W + Xyz.LengthSquared);

	public double LengthSquared => W * W + Xyz.LengthSquared;

	public Quaterniond(Vector3d v, double w)
	{
		xyz = v;
		this.w = w;
	}

	public Quaterniond(double x, double y, double z, double w)
		: this(new Vector3d(x, y, z), w)
	{
	}

	public void ToAxisAngle(out Vector3d axis, out double angle)
	{
		Vector4d vector4d = ToAxisAngle();
		axis = vector4d.Xyz;
		angle = vector4d.W;
	}

	public Vector4d ToAxisAngle()
	{
		Quaterniond quaterniond = this;
		if (quaterniond.W > 1.0)
		{
			quaterniond.Normalize();
		}
		Vector4d result = default(Vector4d);
		result.W = 2f * (float)Math.Acos(quaterniond.W);
		float num = (float)Math.Sqrt(1.0 - quaterniond.W * quaterniond.W);
		if (num > 0.0001f)
		{
			result.Xyz = quaterniond.Xyz / num;
		}
		else
		{
			result.Xyz = Vector3d.UnitX;
		}
		return result;
	}

	public void Normalize()
	{
		double num = 1.0 / Length;
		Xyz *= num;
		W *= num;
	}

	public void Conjugate()
	{
		Xyz = -Xyz;
	}

	public static Quaterniond Add(Quaterniond left, Quaterniond right)
	{
		return new Quaterniond(left.Xyz + right.Xyz, left.W + right.W);
	}

	public static void Add(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
	{
		result = new Quaterniond(left.Xyz + right.Xyz, left.W + right.W);
	}

	public static Quaterniond Sub(Quaterniond left, Quaterniond right)
	{
		return new Quaterniond(left.Xyz - right.Xyz, left.W - right.W);
	}

	public static void Sub(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
	{
		result = new Quaterniond(left.Xyz - right.Xyz, left.W - right.W);
	}

	[Obsolete("Use Multiply instead.")]
	public static Quaterniond Mult(Quaterniond left, Quaterniond right)
	{
		return new Quaterniond(right.W * left.Xyz + left.W * right.Xyz + Vector3d.Cross(left.Xyz, right.Xyz), left.W * right.W - Vector3d.Dot(left.Xyz, right.Xyz));
	}

	[Obsolete("Use Multiply instead.")]
	public static void Mult(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
	{
		result = new Quaterniond(right.W * left.Xyz + left.W * right.Xyz + Vector3d.Cross(left.Xyz, right.Xyz), left.W * right.W - Vector3d.Dot(left.Xyz, right.Xyz));
	}

	public static Quaterniond Multiply(Quaterniond left, Quaterniond right)
	{
		Multiply(ref left, ref right, out var result);
		return result;
	}

	public static void Multiply(ref Quaterniond left, ref Quaterniond right, out Quaterniond result)
	{
		result = new Quaterniond(right.W * left.Xyz + left.W * right.Xyz + Vector3d.Cross(left.Xyz, right.Xyz), left.W * right.W - Vector3d.Dot(left.Xyz, right.Xyz));
	}

	public static void Multiply(ref Quaterniond quaternion, double scale, out Quaterniond result)
	{
		result = new Quaterniond(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
	}

	public static Quaterniond Multiply(Quaterniond quaternion, double scale)
	{
		return new Quaterniond(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
	}

	public static Quaterniond Conjugate(Quaterniond q)
	{
		return new Quaterniond(-q.Xyz, q.W);
	}

	public static void Conjugate(ref Quaterniond q, out Quaterniond result)
	{
		result = new Quaterniond(-q.Xyz, q.W);
	}

	public static Quaterniond Invert(Quaterniond q)
	{
		Invert(ref q, out var result);
		return result;
	}

	public static void Invert(ref Quaterniond q, out Quaterniond result)
	{
		double lengthSquared = q.LengthSquared;
		if (lengthSquared != 0.0)
		{
			double num = 1.0 / lengthSquared;
			result = new Quaterniond(q.Xyz * (0.0 - num), q.W * num);
		}
		else
		{
			result = q;
		}
	}

	public static Quaterniond Normalize(Quaterniond q)
	{
		Normalize(ref q, out var result);
		return result;
	}

	public static void Normalize(ref Quaterniond q, out Quaterniond result)
	{
		double num = 1.0 / q.Length;
		result = new Quaterniond(q.Xyz * num, q.W * num);
	}

	public static Quaterniond FromAxisAngle(Vector3d axis, double angle)
	{
		if (axis.LengthSquared == 0.0)
		{
			return Identity;
		}
		Quaterniond identity = Identity;
		angle *= 0.5;
		axis.Normalize();
		identity.Xyz = axis * Math.Sin(angle);
		identity.W = Math.Cos(angle);
		return Normalize(identity);
	}

	public static Quaterniond Slerp(Quaterniond q1, Quaterniond q2, double blend)
	{
		if (q1.LengthSquared == 0.0)
		{
			if (q2.LengthSquared == 0.0)
			{
				return Identity;
			}
			return q2;
		}
		if (q2.LengthSquared == 0.0)
		{
			return q1;
		}
		double num = q1.W * q2.W + Vector3d.Dot(q1.Xyz, q2.Xyz);
		if (num >= 1.0 || num <= -1.0)
		{
			return q1;
		}
		if (num < 0.0)
		{
			q2.Xyz = -q2.Xyz;
			q2.W = 0.0 - q2.W;
			num = 0.0 - num;
		}
		double num5;
		double num6;
		if (num < 0.9900000095367432)
		{
			double num2 = Math.Acos(num);
			double num3 = Math.Sin(num2);
			double num4 = 1.0 / num3;
			num5 = Math.Sin(num2 * (1.0 - blend)) * num4;
			num6 = Math.Sin(num2 * blend) * num4;
		}
		else
		{
			num5 = 1.0 - blend;
			num6 = blend;
		}
		Quaterniond q3 = new Quaterniond(num5 * q1.Xyz + num6 * q2.Xyz, num5 * q1.W + num6 * q2.W);
		if (q3.LengthSquared > 0.0)
		{
			return Normalize(q3);
		}
		return Identity;
	}

	public static Quaterniond operator +(Quaterniond left, Quaterniond right)
	{
		left.Xyz += right.Xyz;
		left.W += right.W;
		return left;
	}

	public static Quaterniond operator -(Quaterniond left, Quaterniond right)
	{
		left.Xyz -= right.Xyz;
		left.W -= right.W;
		return left;
	}

	public static Quaterniond operator *(Quaterniond left, Quaterniond right)
	{
		Multiply(ref left, ref right, out left);
		return left;
	}

	public static Quaterniond operator *(Quaterniond quaternion, double scale)
	{
		Multiply(ref quaternion, scale, out quaternion);
		return quaternion;
	}

	public static Quaterniond operator *(double scale, Quaterniond quaternion)
	{
		return new Quaterniond(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
	}

	public static bool operator ==(Quaterniond left, Quaterniond right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Quaterniond left, Quaterniond right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"V: {Xyz}, W: {W}";
	}

	public override bool Equals(object other)
	{
		if (!(other is Quaterniond))
		{
			return false;
		}
		return this == (Quaterniond)other;
	}

	public override int GetHashCode()
	{
		return Xyz.GetHashCode() ^ W.GetHashCode();
	}

	public bool Equals(Quaterniond other)
	{
		if (Xyz == other.Xyz)
		{
			return W == other.W;
		}
		return false;
	}
}
