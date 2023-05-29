using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenAL;

public static class Alc
{
	private const string Lib = "/System/Library/Frameworks/OpenAL.framework/OpenAL";

	private const CallingConvention Style = CallingConvention.Cdecl;

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcCreateContext", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern IntPtr sys_CreateContext([In] IntPtr device, [In] int* attrlist);

	[CLSCompliant(false)]
	public unsafe static ContextHandle CreateContext([In] IntPtr device, [In] int* attrlist)
	{
		return new ContextHandle(sys_CreateContext(device, attrlist));
	}

	public unsafe static ContextHandle CreateContext(IntPtr device, int[] attriblist)
	{
		fixed (int* attrlist = attriblist)
		{
			return CreateContext(device, attrlist);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcMakeContextCurrent", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool MakeContextCurrent(IntPtr context);

	public static bool MakeContextCurrent(ContextHandle context)
	{
		return MakeContextCurrent(context.Handle);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcProcessContext", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void ProcessContext(IntPtr context);

	public static void ProcessContext(ContextHandle context)
	{
		ProcessContext(context.Handle);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcSuspendContext", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SuspendContext(IntPtr context);

	public static void SuspendContext(ContextHandle context)
	{
		SuspendContext(context.Handle);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcDestroyContext", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DestroyContext(IntPtr context);

	public static void DestroyContext(ContextHandle context)
	{
		DestroyContext(context.Handle);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcGetCurrentContext", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr sys_GetCurrentContext();

	public static ContextHandle GetCurrentContext()
	{
		return new ContextHandle(sys_GetCurrentContext());
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcGetContextsDevice", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetContextsDevice(IntPtr context);

	public static IntPtr GetContextsDevice(ContextHandle context)
	{
		return GetContextsDevice(context.Handle);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcOpenDevice", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern IntPtr OpenDevice([In] string devicename);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcCloseDevice", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool CloseDevice([In] IntPtr device);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcGetError", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern AlcError GetError([In] IntPtr device);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcIsExtensionPresent", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool IsExtensionPresent([In] IntPtr device, [In] string extname);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetProcAddress", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern IntPtr GetProcAddress([In] IntPtr device, [In] string funcname);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetEnumValue", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int GetEnumValue([In] IntPtr device, [In] string enumname);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetString", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetStringPrivate([In] IntPtr device, AlcGetString param);

	public static string GetString(IntPtr device, AlcGetString param)
	{
		return Marshal.PtrToStringAnsi(GetStringPrivate(device, param));
	}

	public static IList<string> GetString(IntPtr device, AlcGetStringList param)
	{
		List<string> list = new List<string>();
		IntPtr stringPrivate = GetStringPrivate(IntPtr.Zero, (AlcGetString)param);
		StringBuilder stringBuilder = new StringBuilder();
		int ofs = 0;
		while (true)
		{
			byte b = Marshal.ReadByte(stringPrivate, ofs++);
			if (b != 0)
			{
				stringBuilder.Append((char)b);
			}
			if (b == 0)
			{
				list.Add(stringBuilder.ToString());
				if (Marshal.ReadByte(stringPrivate, ofs) == 0)
				{
					break;
				}
				stringBuilder.Remove(0, stringBuilder.Length);
			}
		}
		return list;
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetIntegerv", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void GetInteger(IntPtr device, AlcGetInteger param, int size, int* data);

	public unsafe static void GetInteger(IntPtr device, AlcGetInteger param, int size, out int data)
	{
		fixed (int* data2 = &data)
		{
			GetInteger(device, param, size, data2);
		}
	}

	public unsafe static void GetInteger(IntPtr device, AlcGetInteger param, int size, int[] data)
	{
		fixed (int* data2 = data)
		{
			GetInteger(device, param, size, data2);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern IntPtr CaptureOpenDevice(string devicename, uint frequency, ALFormat format, int buffersize);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern IntPtr CaptureOpenDevice(string devicename, int frequency, ALFormat format, int buffersize);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcCaptureCloseDevice", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool CaptureCloseDevice([In] IntPtr device);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcCaptureStart", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void CaptureStart([In] IntPtr device);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcCaptureStop", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void CaptureStop([In] IntPtr device);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alcCaptureSamples", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void CaptureSamples(IntPtr device, IntPtr buffer, int samples);

	public static void CaptureSamples<T>(IntPtr device, ref T buffer, int samples) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		try
		{
			CaptureSamples(device, gCHandle.AddrOfPinnedObject(), samples);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static void CaptureSamples<T>(IntPtr device, T[] buffer, int samples) where T : struct
	{
		CaptureSamples(device, ref buffer[0], samples);
	}

	public static void CaptureSamples<T>(IntPtr device, T[,] buffer, int samples) where T : struct
	{
		CaptureSamples(device, ref buffer[0, 0], samples);
	}

	public static void CaptureSamples<T>(IntPtr device, T[,,] buffer, int samples) where T : struct
	{
		CaptureSamples(device, ref buffer[0, 0, 0], samples);
	}
}
