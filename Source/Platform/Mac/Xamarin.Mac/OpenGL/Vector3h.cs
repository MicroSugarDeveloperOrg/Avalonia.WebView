using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OpenGL;

[Serializable]
public struct Vector3h : ISerializable, IEquatable<Vector3h>
{
	public Half X;

	public Half Y;

	public Half Z;

	public static readonly int SizeInBytes = 6;

	[XmlIgnore]
	public Vector2h Xy
	{
		get
		{
			return new Vector2h(X, Y);
		}
		set
		{
			X = value.X;
			Y = value.Y;
		}
	}

	public Vector3h(Half value)
	{
		X = value;
		Y = value;
		Z = value;
	}

	public Vector3h(float value)
	{
		X = new Half(value);
		Y = new Half(value);
		Z = new Half(value);
	}

	public Vector3h(Half x, Half y, Half z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public Vector3h(float x, float y, float z)
	{
		X = new Half(x);
		Y = new Half(y);
		Z = new Half(z);
	}

	public Vector3h(float x, float y, float z, bool throwOnError)
	{
		X = new Half(x, throwOnError);
		Y = new Half(y, throwOnError);
		Z = new Half(z, throwOnError);
	}

	[CLSCompliant(false)]
	public Vector3h(Vector3 v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
	}

	[CLSCompliant(false)]
	public Vector3h(Vector3 v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
	}

	public Vector3h(ref Vector3 v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
	}

	public Vector3h(ref Vector3 v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
	}

	public Vector3h(Vector3d v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
	}

	public Vector3h(Vector3d v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
	}

	[CLSCompliant(false)]
	public Vector3h(ref Vector3d v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
	}

	[CLSCompliant(false)]
	public Vector3h(ref Vector3d v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
	}

	public Vector3 ToVector3()
	{
		return new Vector3(X, Y, Z);
	}

	public Vector3d ToVector3d()
	{
		return new Vector3d(X, Y, Z);
	}

	public static explicit operator Vector3h(Vector3 v3f)
	{
		return new Vector3h(v3f);
	}

	public static explicit operator Vector3h(Vector3d v3d)
	{
		return new Vector3h(v3d);
	}

	public static explicit operator Vector3(Vector3h h3)
	{
		Vector3 result = default(Vector3);
		result.X = h3.X.ToSingle();
		result.Y = h3.Y.ToSingle();
		result.Z = h3.Z.ToSingle();
		return result;
	}

	public static explicit operator Vector3d(Vector3h h3)
	{
		Vector3d result = default(Vector3d);
		result.X = h3.X.ToSingle();
		result.Y = h3.Y.ToSingle();
		result.Z = h3.Z.ToSingle();
		return result;
	}

	public Vector3h(SerializationInfo info, StreamingContext context)
	{
		X = (Half)info.GetValue("X", typeof(Half));
		Y = (Half)info.GetValue("Y", typeof(Half));
		Z = (Half)info.GetValue("Z", typeof(Half));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("X", X);
		info.AddValue("Y", Y);
		info.AddValue("Z", Z);
	}

	public void FromBinaryStream(BinaryReader bin)
	{
		X.FromBinaryStream(bin);
		Y.FromBinaryStream(bin);
		Z.FromBinaryStream(bin);
	}

	public void ToBinaryStream(BinaryWriter bin)
	{
		X.ToBinaryStream(bin);
		Y.ToBinaryStream(bin);
		Z.ToBinaryStream(bin);
	}

	public bool Equals(Vector3h other)
	{
		if (X.Equals(other.X) && Y.Equals(other.Y))
		{
			return Z.Equals(other.Z);
		}
		return false;
	}

	public override string ToString()
	{
		return $"({X.ToString()}, {Y.ToString()}, {Z.ToString()})";
	}

	public static byte[] GetBytes(Vector3h h)
	{
		byte[] array = new byte[SizeInBytes];
		byte[] bytes = Half.GetBytes(h.X);
		array[0] = bytes[0];
		array[1] = bytes[1];
		bytes = Half.GetBytes(h.Y);
		array[2] = bytes[0];
		array[3] = bytes[1];
		bytes = Half.GetBytes(h.Z);
		array[4] = bytes[0];
		array[5] = bytes[1];
		return array;
	}

	public static Vector3h FromBytes(byte[] value, int startIndex)
	{
		Vector3h result = default(Vector3h);
		result.X = Half.FromBytes(value, startIndex);
		result.Y = Half.FromBytes(value, startIndex + 2);
		result.Z = Half.FromBytes(value, startIndex + 4);
		return result;
	}
}
