using System;

namespace OpenAL;

public struct ContextHandle : IComparable<ContextHandle>, IEquatable<ContextHandle>
{
	private IntPtr handle;

	public static readonly ContextHandle Zero = new ContextHandle(IntPtr.Zero);

	public IntPtr Handle => handle;

	public ContextHandle(IntPtr h)
	{
		handle = h;
	}

	public override string ToString()
	{
		return Handle.ToString();
	}

	public override bool Equals(object obj)
	{
		if (obj is ContextHandle)
		{
			return Equals((ContextHandle)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Handle.GetHashCode();
	}

	public static explicit operator IntPtr(ContextHandle c)
	{
		if (!(c != Zero))
		{
			return IntPtr.Zero;
		}
		return c.handle;
	}

	public static explicit operator ContextHandle(IntPtr p)
	{
		return new ContextHandle(p);
	}

	public static bool operator ==(ContextHandle left, ContextHandle right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ContextHandle left, ContextHandle right)
	{
		return !left.Equals(right);
	}

	public unsafe int CompareTo(ContextHandle other)
	{
		return (int)((nint)((byte*)other.handle.ToPointer() - (nuint)handle.ToPointer()) / (nint)4);
	}

	public bool Equals(ContextHandle other)
	{
		return Handle == other.Handle;
	}
}
