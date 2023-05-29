using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace ObjCRuntime;

public static class Dlfcn
{
	[DllImport("/usr/lib/libSystem.dylib")]
	public static extern int dlclose(IntPtr handle);

	[DllImport("/usr/lib/libSystem.dylib")]
	public static extern IntPtr dlopen(string path, int mode);

	[DllImport("/usr/lib/libSystem.dylib")]
	public static extern IntPtr dlsym(IntPtr handle, string symbol);

	[DllImport("/usr/lib/libSystem.dylib", EntryPoint = "dlerror")]
	internal static extern IntPtr dlerror_();

	public static string dlerror()
	{
		return Marshal.PtrToStringAnsi(dlerror_());
	}

	public static NSString GetStringConstant(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			return null;
		}
		return (NSString)Runtime.GetNSObject(intPtr2);
	}

	public static IntPtr GetIndirect(IntPtr handle, string symbol)
	{
		return dlsym(handle, symbol);
	}

	public static NSNumber GetNSNumber(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			return null;
		}
		return (NSNumber)Runtime.GetNSObject(intPtr2);
	}

	public static int GetInt32(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		return Marshal.ReadInt32(intPtr);
	}

	public static void SetInt32(IntPtr handle, string symbol, int value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteInt32(intPtr, value);
		}
	}

	public static long GetInt64(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0L;
		}
		return Marshal.ReadInt64(intPtr);
	}

	public static void SetInt64(IntPtr handle, string symbol, long value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteInt64(intPtr, value);
		}
	}

	public static void SetString(IntPtr handle, string symbol, string value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteIntPtr(intPtr, (value == null) ? IntPtr.Zero : NSString.CreateNative(value));
		}
	}

	public static void SetString(IntPtr handle, string symbol, NSString value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			IntPtr intPtr2 = ((value == null) ? IntPtr.Zero : value.Handle);
			if (intPtr2 != IntPtr.Zero)
			{
				CFObject.CFRetain(intPtr2);
			}
			Marshal.WriteIntPtr(intPtr, intPtr2);
		}
	}

	public static void SetArray(IntPtr handle, string symbol, NSArray array)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			IntPtr intPtr2 = array?.Handle ?? IntPtr.Zero;
			if (intPtr2 != IntPtr.Zero)
			{
				CFObject.CFRetain(intPtr2);
			}
			Marshal.WriteIntPtr(intPtr, intPtr2);
		}
	}

	public static IntPtr GetIntPtr(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return Marshal.ReadIntPtr(intPtr);
	}

	public static void SetIntPtr(IntPtr handle, string symbol, IntPtr value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteIntPtr(intPtr, value);
		}
	}

	public unsafe static double GetDouble(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0.0;
		}
		double* ptr = (double*)(void*)intPtr;
		return *ptr;
	}

	public unsafe static void SetDouble(IntPtr handle, string symbol, double value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			*(double*)(void*)intPtr = value;
		}
	}

	public unsafe static float GetFloat(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0f;
		}
		float* ptr = (float*)(void*)intPtr;
		return *ptr;
	}

	public unsafe static void SetFloat(IntPtr handle, string symbol, float value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			*(float*)(void*)intPtr = value;
		}
	}

	internal static int SlowGetInt32(string lib, string symbol)
	{
		IntPtr intPtr = dlopen(lib, 0);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		try
		{
			return GetInt32(intPtr, symbol);
		}
		finally
		{
			dlclose(intPtr);
		}
	}

	internal static long SlowGetInt64(string lib, string symbol)
	{
		IntPtr intPtr = dlopen(lib, 0);
		if (intPtr == IntPtr.Zero)
		{
			return 0L;
		}
		try
		{
			return GetInt64(intPtr, symbol);
		}
		finally
		{
			dlclose(intPtr);
		}
	}

	internal static IntPtr SlowGetIntPtr(string lib, string symbol)
	{
		IntPtr intPtr = dlopen(lib, 0);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		try
		{
			return GetIntPtr(intPtr, symbol);
		}
		finally
		{
			dlclose(intPtr);
		}
	}

	internal static double SlowGetDouble(string lib, string symbol)
	{
		IntPtr intPtr = dlopen(lib, 0);
		if (intPtr == IntPtr.Zero)
		{
			return 0.0;
		}
		try
		{
			return GetDouble(intPtr, symbol);
		}
		finally
		{
			dlclose(intPtr);
		}
	}

	internal static NSString SlowGetStringConstant(string lib, string symbol)
	{
		IntPtr intPtr = dlopen(lib, 0);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			return GetStringConstant(intPtr, symbol);
		}
		finally
		{
			dlclose(intPtr);
		}
	}
}
