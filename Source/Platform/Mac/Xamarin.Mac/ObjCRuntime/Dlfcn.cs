using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;

namespace ObjCRuntime;

public static class Dlfcn
{
	public enum RTLD
	{
		Next = -1,
		Default = -2,
		Self = -3,
		MainOnly = -5
	}

	internal struct Dl_info
	{
		internal IntPtr dli_fname;

		internal IntPtr dli_fbase;

		internal IntPtr dli_sname;

		internal IntPtr dli_saddr;
	}

	private static bool warningShown;

	[DllImport("/usr/lib/libc.dylib")]
	internal static extern int dladdr(IntPtr addr, out Dl_info info);

	[DllImport("/usr/lib/libSystem.dylib")]
	public static extern int dlclose(IntPtr handle);

	[DllImport("/usr/lib/libSystem.dylib", EntryPoint = "dlopen")]
	internal static extern IntPtr _dlopen(string path, int mode);

	public static IntPtr dlopen(string path, int mode)
	{
		IntPtr intPtr = _dlopen(path, mode);
		if (intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		if (path.IndexOf('/') == -1)
		{
			if (!warningShown)
			{
				Console.WriteLine("You are using dlopen without a full path, retrying by prepending /usr/lib");
				warningShown = true;
			}
			intPtr = _dlopen("/usr/lib/" + path, mode);
			if (intPtr != IntPtr.Zero)
			{
				return intPtr;
			}
		}
		return IntPtr.Zero;
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	public static extern IntPtr dlsym(IntPtr handle, string symbol);

	public static IntPtr dlsym(RTLD lookupType, string symbol)
	{
		return dlsym((IntPtr)(int)lookupType, symbol);
	}

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

	public static uint GetUInt32(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0u;
		}
		return (uint)Marshal.ReadInt32(intPtr);
	}

	public static void SetUInt32(IntPtr handle, string symbol, uint value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteInt32(intPtr, (int)value);
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

	public static ulong GetUInt64(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0uL;
		}
		return (ulong)Marshal.ReadInt64(intPtr);
	}

	[Obsolete("Use 'SetInt64' for long values instead.")]
	public static void SetUInt64(IntPtr handle, string symbol, long value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteInt64(intPtr, value);
		}
	}

	public static void SetUInt64(IntPtr handle, string symbol, ulong value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			Marshal.WriteInt64(intPtr, (long)value);
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

	public static nint GetNInt(IntPtr handle, string symbol)
	{
		return (nint)GetIntPtr(handle, symbol);
	}

	public static void SetNInt(IntPtr handle, string symbol, nint value)
	{
		SetIntPtr(handle, symbol, (IntPtr)value);
	}

	public static nuint GetNUInt(IntPtr handle, string symbol)
	{
		return (nuint)GetIntPtr(handle, symbol);
	}

	public static void SetNUInt(IntPtr handle, string symbol, nuint value)
	{
		SetIntPtr(handle, symbol, (IntPtr)value);
	}

	public unsafe static nfloat GetNFloat(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		if (sizeof(IntPtr) == 4)
		{
			return *(float*)(void*)intPtr;
		}
		return (nfloat)(*(double*)(void*)intPtr);
	}

	public unsafe static void SetNFloat(IntPtr handle, string symbol, nfloat value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			nfloat* ptr = (nfloat*)(void*)intPtr;
			*ptr = value;
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

	public unsafe static CGRect GetCGRect(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return CGRect.Empty;
		}
		nfloat* ptr = (nfloat*)(void*)intPtr;
		return new CGRect(*ptr, ptr[1], ptr[2], ptr[3]);
	}

	public unsafe static CGSize GetCGSize(IntPtr handle, string symbol)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (intPtr == IntPtr.Zero)
		{
			return CGSize.Empty;
		}
		nfloat* ptr = (nfloat*)(void*)intPtr;
		return new CGSize(*ptr, ptr[1]);
	}

	public unsafe static void SetCGSize(IntPtr handle, string symbol, CGSize value)
	{
		IntPtr intPtr = dlsym(handle, symbol);
		if (!(intPtr == IntPtr.Zero))
		{
			nfloat* ptr = (nfloat*)(void*)intPtr;
			*ptr = value.Width;
			ptr[1] = value.Height;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public unsafe static IntPtr CachePointer(IntPtr handle, string constant, IntPtr* storage)
	{
		if (*storage == IntPtr.Zero)
		{
			*storage = GetIntPtr(handle, constant);
		}
		return *storage;
	}
}
