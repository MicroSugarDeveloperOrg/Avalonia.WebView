using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenAL;

public static class BlittableValueType<T>
{
	private static readonly Type Type;

	private static readonly int stride;

	public static int Stride => stride;

	static BlittableValueType()
	{
		Type = typeof(T);
		if (Type.IsValueType && !Type.IsGenericType)
		{
			stride = Marshal.SizeOf(typeof(T));
		}
	}

	public static bool Check()
	{
		return Check(Type);
	}

	public static bool Check(Type type)
	{
		CheckStructLayoutAttribute(type);
		return CheckType(type);
	}

	private static bool CheckType(Type type)
	{
		if (type.IsPrimitive)
		{
			return true;
		}
		if (!type.IsValueType)
		{
			return false;
		}
		FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		for (int i = 0; i < fields.Length; i++)
		{
			if (!CheckType(fields[i].FieldType))
			{
				return false;
			}
		}
		return Stride != 0;
	}

	private static bool CheckStructLayoutAttribute(Type type)
	{
		StructLayoutAttribute[] array = (StructLayoutAttribute[])type.GetCustomAttributes(typeof(StructLayoutAttribute), inherit: true);
		if (array == null || (array != null && array.Length != 0 && array[0].Value != LayoutKind.Explicit && array[0].Pack != 1))
		{
			return false;
		}
		return true;
	}
}
public static class BlittableValueType
{
	public static bool Check<T>(T type)
	{
		return BlittableValueType<T>.Check();
	}

	public static bool Check<T>(T[] type)
	{
		return BlittableValueType<T>.Check();
	}

	public static bool Check<T>(T[,] type)
	{
		return BlittableValueType<T>.Check();
	}

	public static bool Check<T>(T[,,] type)
	{
		return BlittableValueType<T>.Check();
	}

	[CLSCompliant(false)]
	public static bool Check<T>(T[][] type)
	{
		return BlittableValueType<T>.Check();
	}

	public static int StrideOf<T>(T type)
	{
		if (!Check(type))
		{
			throw new ArgumentException("type");
		}
		return BlittableValueType<T>.Stride;
	}

	public static int StrideOf<T>(T[] type)
	{
		if (!Check(type))
		{
			throw new ArgumentException("type");
		}
		return BlittableValueType<T>.Stride;
	}

	public static int StrideOf<T>(T[,] type)
	{
		if (!Check(type))
		{
			throw new ArgumentException("type");
		}
		return BlittableValueType<T>.Stride;
	}

	public static int StrideOf<T>(T[,,] type)
	{
		if (!Check(type))
		{
			throw new ArgumentException("type");
		}
		return BlittableValueType<T>.Stride;
	}
}
