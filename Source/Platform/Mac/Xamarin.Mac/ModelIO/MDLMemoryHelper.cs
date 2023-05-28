using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace ModelIO;

internal static class MDLMemoryHelper
{
	private static IntPtr GetAlignedPtrForArray(int typeSize, int managedArrayCount, out int nativeArrayLength, out IntPtr alignedPtr)
	{
		nativeArrayLength = typeSize * managedArrayCount;
		IntPtr intPtr = Marshal.AllocHGlobal(nativeArrayLength + 16);
		alignedPtr = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
		return intPtr;
	}

	internal static void SetValues(int typeSize, IntPtr arrptr, int arrLength, Action<IntPtr, nuint> setFunc)
	{
		IntPtr alignedPtr = arrptr;
		IntPtr intPtr = IntPtr.Zero;
		if ((nuint)alignedPtr % (byte)16 != (byte)0)
		{
			intPtr = GetAlignedPtrForArray(typeSize, arrLength, out var nativeArrayLength, out alignedPtr);
			Runtime.memcpy(alignedPtr, arrptr, nativeArrayLength);
		}
		setFunc(alignedPtr, (nuint)arrLength);
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	internal static void SetValues(int typeSize, IntPtr arrptr, int arrLength, double time, Action<IntPtr, nuint, double> setFunc)
	{
		IntPtr alignedPtr = arrptr;
		IntPtr intPtr = IntPtr.Zero;
		if ((nuint)alignedPtr % (byte)16 != (byte)0)
		{
			intPtr = GetAlignedPtrForArray(typeSize, arrLength, out var nativeArrayLength, out alignedPtr);
			Runtime.memcpy(alignedPtr, arrptr, nativeArrayLength);
		}
		setFunc(alignedPtr, (nuint)arrLength, time);
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	internal static nuint FetchValues(int typeSize, IntPtr arrptr, nuint count, Func<IntPtr, nuint, nuint> getFunc)
	{
		IntPtr alignedPtr = arrptr;
		IntPtr intPtr = IntPtr.Zero;
		nuint result;
		if ((nuint)alignedPtr % (byte)16 != (byte)0)
		{
			intPtr = GetAlignedPtrForArray(typeSize, (int)count, out var nativeArrayLength, out alignedPtr);
			result = getFunc(alignedPtr, count);
			Runtime.memcpy(arrptr, alignedPtr, nativeArrayLength);
		}
		else
		{
			result = getFunc(arrptr, count);
		}
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	internal static nuint FetchValues(int typeSize, IntPtr arrptr, nuint count, double time, Func<IntPtr, nuint, double, nuint> getFunc)
	{
		IntPtr alignedPtr = arrptr;
		IntPtr intPtr = IntPtr.Zero;
		nuint result;
		if ((nuint)alignedPtr % (byte)16 != (byte)0)
		{
			intPtr = GetAlignedPtrForArray(typeSize, (int)count, out var nativeArrayLength, out alignedPtr);
			result = getFunc(alignedPtr, count, time);
			Runtime.memcpy(arrptr, alignedPtr, nativeArrayLength);
		}
		else
		{
			result = getFunc(arrptr, count, time);
		}
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	internal unsafe static void Reset(int typeSize, IntPtr valuesPtr, double[] times, Action<IntPtr, IntPtr, nuint> resetFunc)
	{
		IntPtr alignedPtr = valuesPtr;
		IntPtr intPtr = IntPtr.Zero;
		if ((nuint)alignedPtr % (byte)16 != (byte)0)
		{
			intPtr = GetAlignedPtrForArray(typeSize, times.Length, out var nativeArrayLength, out alignedPtr);
			Runtime.memcpy(alignedPtr, valuesPtr, nativeArrayLength);
		}
		fixed (double* ptr = times)
		{
			resetFunc(alignedPtr, (IntPtr)ptr, (nuint)times.Length);
		}
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	internal unsafe static void Reset(int typeSize, IntPtr valuesPtr, int valuesLength, double[] times, Action<IntPtr, nuint, IntPtr, nuint> resetFunc)
	{
		IntPtr alignedPtr = valuesPtr;
		IntPtr intPtr = IntPtr.Zero;
		if ((nuint)alignedPtr % (byte)16 != (byte)0)
		{
			intPtr = GetAlignedPtrForArray(typeSize, valuesLength, out var nativeArrayLength, out alignedPtr);
			Runtime.memcpy(alignedPtr, valuesPtr, nativeArrayLength);
		}
		fixed (double* ptr = times)
		{
			resetFunc(alignedPtr, (nuint)valuesLength, (IntPtr)ptr, (nuint)times.Length);
		}
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}
}
