using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK;

[Serializable]
public struct Vector3i : IEquatable<Vector3i>
{
	public int X;

	public int Y;

	public int Z;

	public static readonly Vector3i UnitX = new Vector3i(1, 0, 0);

	public static readonly Vector3i UnitY = new Vector3i(0, 1, 0);

	public static readonly Vector3i UnitZ = new Vector3i(0, 0, 1);

	public static readonly Vector3i Zero = new Vector3i(0, 0, 0);

	public static readonly Vector3i One = new Vector3i(1, 1, 1);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector3i));

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

	public Vector3i(int x, int y, int z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public Vector3i(Vector2i v)
	{
		X = v.X;
		Y = v.Y;
		Z = 0;
	}

	public Vector3i(Vector3i v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
	}

	public static Vector3i Add(Vector3i a, Vector3i b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector3i a, ref Vector3i b, out Vector3i result)
	{
		result = new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	public static Vector3i Subtract(Vector3i a, Vector3i b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector3i a, ref Vector3i b, out Vector3i result)
	{
		result = new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	}

	public static Vector3i ComponentMin(Vector3i a, Vector3i b)
	{
		a.X = ((a.X < b.X) ? a.X : b.X);
		a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z < b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMin(ref Vector3i a, ref Vector3i b, out Vector3i result)
	{
		result.X = ((a.X < b.X) ? a.X : b.X);
		result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z < b.Z) ? a.Z : b.Z);
	}

	public static Vector3i ComponentMax(Vector3i a, Vector3i b)
	{
		a.X = ((a.X > b.X) ? a.X : b.X);
		a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		a.Z = ((a.Z > b.Z) ? a.Z : b.Z);
		return a;
	}

	public static void ComponentMax(ref Vector3i a, ref Vector3i b, out Vector3i result)
	{
		result.X = ((a.X > b.X) ? a.X : b.X);
		result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
		result.Z = ((a.Z > b.Z) ? a.Z : b.Z);
	}

	public static Vector3i Clamp(Vector3i vec, Vector3i min, Vector3i max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		vec.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
		return vec;
	}

	public static void Clamp(ref Vector3i vec, ref Vector3i min, ref Vector3i max, out Vector3i result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		result.Z = ((vec.Z < min.Z) ? min.Z : ((vec.Z > max.Z) ? max.Z : vec.Z));
	}

	public static Vector3i operator +(Vector3i left, Vector3i right)
	{
		left.X += right.X;
		left.Y += right.Y;
		left.Z += right.Z;
		return left;
	}

	public static Vector3i operator -(Vector3i left, Vector3i right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		left.Z -= right.Z;
		return left;
	}

	public static Vector3i operator -(Vector3i vec)
	{
		vec.X = -vec.X;
		vec.Y = -vec.Y;
		vec.Z = -vec.Z;
		return vec;
	}

	public static bool operator ==(Vector3i left, Vector3i right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector3i left, Vector3i right)
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
		if (!(obj is Vector3i))
		{
			return false;
		}
		return Equals((Vector3i)obj);
	}

	public bool Equals(Vector3i other)
	{
		return X == other.X && Y == other.Y && Z == other.Z;
	}
}
