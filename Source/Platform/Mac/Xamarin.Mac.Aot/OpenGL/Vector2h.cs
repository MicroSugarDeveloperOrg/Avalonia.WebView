using System;
using System.IO;
using System.Runtime.Serialization;

namespace OpenGL;

[Serializable]
public struct Vector2h : ISerializable, IEquatable<Vector2h>
{
	public Half X;

	public Half Y;

	public static readonly int SizeInBytes = 4;

	public Vector2h(Half value)
	{
		X = value;
		Y = value;
	}

	public Vector2h(float value)
	{
		X = new Half(value);
		Y = new Half(value);
	}

	public Vector2h(Half x, Half y)
	{
		X = x;
		Y = y;
	}

	public Vector2h(float x, float y)
	{
		X = new Half(x);
		Y = new Half(y);
	}

	public Vector2h(float x, float y, bool throwOnError)
	{
		X = new Half(x, throwOnError);
		Y = new Half(y, throwOnError);
	}

	[CLSCompliant(false)]
	public Vector2h(Vector2 v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
	}

	[CLSCompliant(false)]
	public Vector2h(Vector2 v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
	}

	public Vector2h(ref Vector2 v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
	}

	public Vector2h(ref Vector2 v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
	}

	public Vector2h(Vector2d v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
	}

	public Vector2h(Vector2d v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
	}

	[CLSCompliant(false)]
	public Vector2h(ref Vector2d v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
	}

	[CLSCompliant(false)]
	public Vector2h(ref Vector2d v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
	}

	public Vector2 ToVector2()
	{
		return new Vector2(X, Y);
	}

	public Vector2d ToVector2d()
	{
		return new Vector2d(X, Y);
	}

	public static explicit operator Vector2h(Vector2 v)
	{
		return new Vector2h(v);
	}

	public static explicit operator Vector2h(Vector2d v)
	{
		return new Vector2h(v);
	}

	public static explicit operator Vector2(Vector2h h)
	{
		return new Vector2(h.X, h.Y);
	}

	public static explicit operator Vector2d(Vector2h h)
	{
		return new Vector2d(h.X, h.Y);
	}

	public Vector2h(SerializationInfo info, StreamingContext context)
	{
		X = (Half)info.GetValue("X", typeof(Half));
		Y = (Half)info.GetValue("Y", typeof(Half));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("X", X);
		info.AddValue("Y", Y);
	}

	public void FromBinaryStream(BinaryReader bin)
	{
		X.FromBinaryStream(bin);
		Y.FromBinaryStream(bin);
	}

	public void ToBinaryStream(BinaryWriter bin)
	{
		X.ToBinaryStream(bin);
		Y.ToBinaryStream(bin);
	}

	public bool Equals(Vector2h other)
	{
		if (X.Equals(other.X))
		{
			return Y.Equals(other.Y);
		}
		return false;
	}

	public override string ToString()
	{
		return $"({X.ToString()}, {Y.ToString()})";
	}

	public static byte[] GetBytes(Vector2h h)
	{
		byte[] array = new byte[SizeInBytes];
		byte[] bytes = Half.GetBytes(h.X);
		array[0] = bytes[0];
		array[1] = bytes[1];
		bytes = Half.GetBytes(h.Y);
		array[2] = bytes[0];
		array[3] = bytes[1];
		return array;
	}

	public static Vector2h FromBytes(byte[] value, int startIndex)
	{
		Vector2h result = default(Vector2h);
		result.X = Half.FromBytes(value, startIndex);
		result.Y = Half.FromBytes(value, startIndex + 2);
		return result;
	}
}
