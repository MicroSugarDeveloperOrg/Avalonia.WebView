using System;

namespace OpenTK;

public struct NVector3d : IEquatable<NVector3d>
{
	public double X;

	public double Y;

	public double Z;

	private double dummy;

	public NVector3d(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
		dummy = 0.0;
	}

	public static bool operator ==(NVector3d left, NVector3d right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(NVector3d left, NVector3d right)
	{
		return !left.Equals(right);
	}

	public static explicit operator Vector3d(NVector3d value)
	{
		return new Vector3d(value.X, value.Y, value.Z);
	}

	public static explicit operator NVector3d(Vector3d value)
	{
		return new NVector3d(value.X, value.Y, value.Z);
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
		if (!(obj is NVector3d))
		{
			return false;
		}
		return Equals((NVector3d)obj);
	}

	public bool Equals(NVector3d other)
	{
		return X == other.X && Y == other.Y && Z == other.Z;
	}
}
