using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OpenGL;

[Serializable]
public struct Vector4h : ISerializable, IEquatable<Vector4h>
{
	public Half X;

	public Half Y;

	public Half Z;

	public Half W;

	public static readonly int SizeInBytes = 8;

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

	[XmlIgnore]
	public Vector3h Xyz
	{
		get
		{
			return new Vector3h(X, Y, Z);
		}
		set
		{
			X = value.X;
			Y = value.Y;
			Z = value.Z;
		}
	}

	public Vector4h(Half value)
	{
		X = value;
		Y = value;
		Z = value;
		W = value;
	}

	public Vector4h(float value)
	{
		X = new Half(value);
		Y = new Half(value);
		Z = new Half(value);
		W = new Half(value);
	}

	public Vector4h(Half x, Half y, Half z, Half w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public Vector4h(float x, float y, float z, float w)
	{
		X = new Half(x);
		Y = new Half(y);
		Z = new Half(z);
		W = new Half(w);
	}

	public Vector4h(float x, float y, float z, float w, bool throwOnError)
	{
		X = new Half(x, throwOnError);
		Y = new Half(y, throwOnError);
		Z = new Half(z, throwOnError);
		W = new Half(w, throwOnError);
	}

	[CLSCompliant(false)]
	public Vector4h(Vector4 v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
		W = new Half(v.W);
	}

	[CLSCompliant(false)]
	public Vector4h(Vector4 v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
		W = new Half(v.W, throwOnError);
	}

	public Vector4h(ref Vector4 v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
		W = new Half(v.W);
	}

	public Vector4h(ref Vector4 v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
		W = new Half(v.W, throwOnError);
	}

	public Vector4h(Vector4d v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
		W = new Half(v.W);
	}

	public Vector4h(Vector4d v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
		W = new Half(v.W, throwOnError);
	}

	[CLSCompliant(false)]
	public Vector4h(ref Vector4d v)
	{
		X = new Half(v.X);
		Y = new Half(v.Y);
		Z = new Half(v.Z);
		W = new Half(v.W);
	}

	[CLSCompliant(false)]
	public Vector4h(ref Vector4d v, bool throwOnError)
	{
		X = new Half(v.X, throwOnError);
		Y = new Half(v.Y, throwOnError);
		Z = new Half(v.Z, throwOnError);
		W = new Half(v.W, throwOnError);
	}

	public Vector4 ToVector4()
	{
		return new Vector4(X, Y, Z, W);
	}

	public Vector4d ToVector4d()
	{
		return new Vector4d(X, Y, Z, W);
	}

	public static explicit operator Vector4h(Vector4 v4f)
	{
		return new Vector4h(v4f);
	}

	public static explicit operator Vector4h(Vector4d v4d)
	{
		return new Vector4h(v4d);
	}

	public static explicit operator Vector4(Vector4h h4)
	{
		Vector4 result = default(Vector4);
		result.X = h4.X.ToSingle();
		result.Y = h4.Y.ToSingle();
		result.Z = h4.Z.ToSingle();
		result.W = h4.W.ToSingle();
		return result;
	}

	public static explicit operator Vector4d(Vector4h h4)
	{
		Vector4d result = default(Vector4d);
		result.X = h4.X.ToSingle();
		result.Y = h4.Y.ToSingle();
		result.Z = h4.Z.ToSingle();
		result.W = h4.W.ToSingle();
		return result;
	}

	public Vector4h(SerializationInfo info, StreamingContext context)
	{
		X = (Half)info.GetValue("X", typeof(Half));
		Y = (Half)info.GetValue("Y", typeof(Half));
		Z = (Half)info.GetValue("Z", typeof(Half));
		W = (Half)info.GetValue("W", typeof(Half));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("X", X);
		info.AddValue("Y", Y);
		info.AddValue("Z", Z);
		info.AddValue("W", W);
	}

	public void FromBinaryStream(BinaryReader bin)
	{
		X.FromBinaryStream(bin);
		Y.FromBinaryStream(bin);
		Z.FromBinaryStream(bin);
		W.FromBinaryStream(bin);
	}

	public void ToBinaryStream(BinaryWriter bin)
	{
		X.ToBinaryStream(bin);
		Y.ToBinaryStream(bin);
		Z.ToBinaryStream(bin);
		W.ToBinaryStream(bin);
	}

	public bool Equals(Vector4h other)
	{
		if (X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z))
		{
			return W.Equals(other.W);
		}
		return false;
	}

	public override string ToString()
	{
		return $"({X.ToString()}, {Y.ToString()}, {Z.ToString()}, {W.ToString()})";
	}

	public static byte[] GetBytes(Vector4h h)
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
		bytes = Half.GetBytes(h.W);
		array[6] = bytes[0];
		array[7] = bytes[1];
		return array;
	}

	public static Vector4h FromBytes(byte[] value, int startIndex)
	{
		Vector4h result = default(Vector4h);
		result.X = Half.FromBytes(value, startIndex);
		result.Y = Half.FromBytes(value, startIndex + 2);
		result.Z = Half.FromBytes(value, startIndex + 4);
		result.W = Half.FromBytes(value, startIndex + 6);
		return result;
	}
}
