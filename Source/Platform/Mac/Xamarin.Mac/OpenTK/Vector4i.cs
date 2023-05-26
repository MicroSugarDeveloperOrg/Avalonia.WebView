using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK;

[Serializable]
public struct Vector4i : IEquatable<Vector4i>
{
	public int X;

	public int Y;

	public int Z;

	public int W;

	public static Vector4i UnitX = new Vector4i(1, 0, 0, 0);

	public static Vector4i UnitY = new Vector4i(0, 1, 0, 0);

	public static Vector4i UnitZ = new Vector4i(0, 0, 1, 0);

	public static Vector4i UnitW = new Vector4i(0, 0, 0, 1);

	public static Vector4i Zero = new Vector4i(0, 0, 0, 0);

	public static readonly Vector4i One = new Vector4i(1, 1, 1, 1);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector4i));

	[XmlIgnore]
	public Vector2i Xy
	{
		get
		{
			return new Vector2i(X, Y);
		}
		set
		{
			X = value.X;
			Y = value.Y;
		}
	}

	[XmlIgnore]
	public Vector3i Xyz
	{
		get
		{
			return new Vector3i(X, Y, Z);
		}
		set
		{
			X = value.X;
			Y = value.Y;
			Z = value.Z;
		}
	}

	public Vector4i(int x, int y, int z, int w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public Vector4i(Vector2i v)
	{
		X = v.X;
		Y = v.Y;
		Z = 0;
		W = 0;
	}

	public Vector4i(Vector3i v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = 0;
	}

	public Vector4i(Vector3i v, int w)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = w;
	}

	public Vector4i(Vector4i v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = v.W;
	}

	public static Vector4i Sub(Vector4i a, Vector4i b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		a.Z -= b.Z;
		a.W -= b.W;
		return a;
	}

	public static void Sub(ref Vector4i a, ref Vector4i b, out Vector4i result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
		result.W = a.W - b.W;
	}

	public static Vector4i Add(Vector4i a, Vector4i b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector4i a, ref Vector4i b, out Vector4i result)
	{
		result = new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
	}

	public static Vector4i Subtract(Vector4i a, Vector4i b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector4i a, ref Vector4i b, out Vector4i result)
	{
		result = new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
	}

	public static Vector4i Min(Vector4i a, Vector4i b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		a.W = ((a.W < b.W) ? a.W : b.W);
		return a;
	}

	public static void Min(ref Vector4i a, ref Vector4i b, out Vector4i result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		result.W = ((a.W < b.W) ? a.W : b.W);
	}

	public static Vector4i Max(Vector4i a, Vector4i b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		a.W = ((a.W > b.W) ? a.W : b.W);
		return a;
	}

	public static void Max(ref Vector4i a, ref Vector4i b, out Vector4i result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		result.W = ((a.W > b.W) ? a.W : b.W);
	}

	public static Vector4i Clamp(Vector4i vec, Vector4i min, Vector4i max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.X < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		vec.W = ((vec.Y < min.W) ? min.W : ((vec.W > max.W) ? max.W : vec.W));
		return vec;
	}

	public static void Clamp(ref Vector4i vec, ref Vector4i min, ref Vector4i max, out Vector4i result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.X < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		result.W = ((vec.Y < min.W) ? min.W : ((vec.W > max.W) ? max.W : vec.W));
	}

	public static Vector4i operator +(Vector4i left, Vector4i right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		left.W += right.W;
		return left;
	}

	public static Vector4i operator -(Vector4i left, Vector4i right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		left.W -= right.W;
		return left;
	}

	public static Vector4i operator -(Vector4i vec)
	{
		vec.X = -vec.X;
		vec.Y = -vec.Y;
		vec.Z = -vec.Z;
		vec.W = -vec.W;
		return vec;
	}

	public static bool operator ==(Vector4i left, Vector4i right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector4i left, Vector4i right)
	{
		return !left.Equals(right);
	}

	public unsafe static explicit operator IntPtr(Vector4i v)
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
		if (!(obj is Vector4i))
		{
			return false;
		}
		return Equals((Vector4i)obj);
	}

	public bool Equals(Vector4i other)
	{
		return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
	}
}
