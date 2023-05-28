using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class DispatchData : DispatchObject
{
	public nuint Size => dispatch_data_get_size(base.Handle);

	[Field("_dispatch_data_destructor_free", "/usr/lib/system/libdispatch.dylib")]
	internal static IntPtr free => Dlfcn.GetIntPtr(Libraries.libdispatch.Handle, "_dispatch_data_destructor_free");

	public DispatchData(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public DispatchData(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_data_create(IntPtr buffer, nuint size, IntPtr dispatchQueue, IntPtr destructor);

	public static DispatchData FromByteBuffer(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(buffer.Length);
		Marshal.Copy(buffer, 0, intPtr, buffer.Length);
		IntPtr intPtr2 = dispatch_data_create(intPtr, (nuint)buffer.Length, IntPtr.Zero, free);
		return new DispatchData(intPtr2, owns: true);
	}

	public static DispatchData FromByteBuffer(byte[] buffer, int start, int length)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (start < 0 || start >= buffer.Length)
		{
			throw new ArgumentException("start");
		}
		if (length < 0)
		{
			throw new ArgumentException("length");
		}
		if (start > buffer.Length + length)
		{
			throw new ArgumentException("Start+Length go beyond the buffer.Length");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(length);
		Marshal.Copy(buffer, start, intPtr, length);
		IntPtr intPtr2 = dispatch_data_create(intPtr, (nuint)length, IntPtr.Zero, free);
		return new DispatchData(intPtr2, owns: true);
	}

	public static DispatchData FromBuffer(IntPtr buffer, nuint size)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		IntPtr intPtr = dispatch_data_create(buffer, size, IntPtr.Zero, IntPtr.Zero);
		return new DispatchData(intPtr, owns: true);
	}

	public unsafe static DispatchData FromReadOnlySpan(ReadOnlySpan<byte> content)
	{
		fixed (byte* ptr = &content.GetPinnableReference())
		{
			IntPtr intPtr = dispatch_data_create((IntPtr)ptr, (nuint)content.Length, IntPtr.Zero, IntPtr.Zero);
			return new DispatchData(intPtr, owns: true);
		}
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern nuint dispatch_data_get_size(IntPtr handle);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_data_create_map(IntPtr handle, out IntPtr bufferPtr, out nuint size);

	public DispatchData CreateMap(out IntPtr bufferPtr, out nuint size)
	{
		IntPtr intPtr = dispatch_data_create_map(base.Handle, out bufferPtr, out size);
		return new DispatchData(intPtr, owns: true);
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_data_create_concat(IntPtr h1, IntPtr h2);

	public static DispatchData Concat(DispatchData data1, DispatchData data2)
	{
		if (data1 == null)
		{
			throw new ArgumentNullException("data1");
		}
		if (data2 == null)
		{
			throw new ArgumentNullException("data2");
		}
		return new DispatchData(dispatch_data_create_concat(data1.Handle, data2.Handle), owns: true);
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_data_create_subrange(IntPtr handle, nuint offset, nuint size);

	public DispatchData CreateSubrange(nuint offset, nuint size)
	{
		return new DispatchData(dispatch_data_create_subrange(base.Handle, offset, size), owns: true);
	}

	public byte[] ToArray()
	{
		IntPtr bufferPtr = IntPtr.Zero;
		nuint size = (byte)0;
		using (CreateMap(out bufferPtr, out size))
		{
			byte[] array = new byte[(int)size];
			Marshal.Copy(bufferPtr, array, 0, (int)size);
			return array;
		}
	}
}
