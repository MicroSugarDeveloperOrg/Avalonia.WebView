using System;
using System.Runtime.InteropServices;

namespace OpenTK;

[Serializable]
public struct Vector2i : IEquatable<Vector2i>
{
	public int X;

	public int Y;

	public static readonly Vector2i UnitX = new Vector2i(1, 0);

	public static readonly Vector2i UnitY = new Vector2i(0, 1);

	public static readonly Vector2i Zero = new Vector2i(0, 0);

	public static readonly Vector2i One = new Vector2i(1, 1);

	public static readonly int SizeInBytes = Marshal.SizeOf(default(Vector2i));

	public Vector2i(int x, int y)
	{
		X = x;
		Y = y;
	}

	public static Vector2i Add(Vector2i a, Vector2i b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref Vector2i a, ref Vector2i b, out Vector2i result)
	{
		result = new Vector2i(a.X + b.X, a.Y + b.Y);
	}

	public static Vector2i Subtract(Vector2i a, Vector2i b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref Vector2i a, ref Vector2i b, out Vector2i result)
	{
		result = new Vector2i(a.X - b.X, a.Y - b.Y);
	}

	public static Vector2i Clamp(Vector2i vec, Vector2i min, Vector2i max)
	{
		vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
		return vec;
	}

	public static void Clamp(ref Vector2i vec, ref Vector2i min, ref Vector2i max, out Vector2i result)
	{
		result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
		result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
	}

	public static Vector2i operator +(Vector2i left, Vector2i right)
	{
		left.X += right.X;
		left.Y += right.Y;
		return left;
	}

	public static Vector2i operator -(Vector2i left, Vector2i right)
	{
		left.X -= right.X;
		left.Y -= right.Y;
		return left;
	}

	public static Vector2i operator -(Vector2i vec)
	{
		vec.X = -vec.X;
		vec.Y = -vec.Y;
		return vec;
	}

	public static bool operator ==(Vector2i left, Vector2i right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Vector2i left, Vector2i right)
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
		if (!(obj is Vector2i))
		{
			return false;
		}
		return Equals((Vector2i)obj);
	}

	public bool Equals(Vector2i other)
	{
		return X == other.X && Y == other.Y;
	}
}
