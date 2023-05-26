using System;
using System.Runtime.InteropServices;
using System.Security;
using OpenGL;

namespace OpenAL;

public static class AL
{
	internal const string Lib = "/System/Library/Frameworks/OpenAL.framework/OpenAL";

	private const CallingConvention Style = CallingConvention.Cdecl;

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alEnable", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Enable(ALCapability capability);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDisable", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Disable(ALCapability capability);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alIsEnabled", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool IsEnabled(ALCapability capability);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetString", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetStringPrivate(ALGetString param);

	public static string Get(ALGetString param)
	{
		return Marshal.PtrToStringAnsi(GetStringPrivate(param));
	}

	public static string GetErrorString(ALError param)
	{
		return Marshal.PtrToStringAnsi(GetStringPrivate((ALGetString)param));
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetInteger", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int Get(ALGetInteger param);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetFloat", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern float Get(ALGetFloat param);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetError", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern ALError GetError();

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsExtensionPresent", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool IsExtensionPresent([In] string extname);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetProcAddress", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern IntPtr GetProcAddress([In] string fname);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetEnumValue", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int GetEnumValue([In] string ename);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alListenerf", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Listener(ALListenerf param, float value);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alListener3f", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Listener(ALListener3f param, float value1, float value2, float value3);

	public static void Listener(ALListener3f param, ref Vector3 values)
	{
		Listener(param, values.X, values.Y, values.Z);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alListenerfv", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void ListenerPrivate(ALListenerfv param, float* values);

	public unsafe static void Listener(ALListenerfv param, ref float[] values)
	{
		fixed (float* values2 = &values[0])
		{
			ListenerPrivate(param, values2);
		}
	}

	public unsafe static void Listener(ALListenerfv param, ref Vector3 at, ref Vector3 up)
	{
		fixed (float* values = &(new float[6] { at.X, at.Y, at.Z, up.X, up.Y, up.Z })[0])
		{
			ListenerPrivate(param, values);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetListenerf", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void GetListener(ALListenerf param, out float value);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetListener3f", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void GetListener(ALListener3f param, out float value1, out float value2, out float value3);

	public static void GetListener(ALListener3f param, out Vector3 values)
	{
		GetListener(param, out values.X, out values.Y, out values.Z);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetListenerfv", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void GetListener(ALListenerfv param, float* values);

	public unsafe static void GetListener(ALListenerfv param, out Vector3 at, out Vector3 up)
	{
		float[] array = new float[6];
		fixed (float* values = &array[0])
		{
			GetListener(param, values);
			at.X = array[0];
			at.Y = array[1];
			at.Z = array[2];
			up.X = array[3];
			up.Y = array[4];
			up.Z = array[5];
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGenSources", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void GenSourcesPrivate(int n, [Out] uint* sources);

	[CLSCompliant(false)]
	public unsafe static void GenSources(int n, out uint sources)
	{
		fixed (uint* sources2 = &sources)
		{
			GenSourcesPrivate(n, sources2);
		}
	}

	public unsafe static void GenSources(int n, out int sources)
	{
		fixed (int* sources2 = &sources)
		{
			GenSourcesPrivate(n, (uint*)sources2);
		}
	}

	public static void GenSources(int[] sources)
	{
		uint[] array = new uint[sources.Length];
		GenSources(array.Length, out array[0]);
		for (int i = 0; i < array.Length; i++)
		{
			sources[i] = (int)array[i];
		}
	}

	public static int[] GenSources(int n)
	{
		uint[] array = new uint[n];
		GenSources(array.Length, out array[0]);
		int[] array2 = new int[n];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (int)array[i];
		}
		return array2;
	}

	public static int GenSource()
	{
		GenSources(1, out int sources);
		return sources;
	}

	[CLSCompliant(false)]
	public static void GenSource(out uint source)
	{
		GenSources(1, out source);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDeleteSources", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void DeleteSources(int n, [In] uint* sources);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDeleteSources", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void DeleteSources(int n, ref uint sources);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDeleteSources", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void DeleteSources(int n, ref int sources);

	[CLSCompliant(false)]
	public static void DeleteSources(uint[] sources)
	{
		if (sources == null)
		{
			throw new ArgumentNullException();
		}
		if (sources.Length == 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		DeleteBuffers(sources.Length, ref sources[0]);
	}

	public static void DeleteSources(int[] sources)
	{
		if (sources == null)
		{
			throw new ArgumentNullException();
		}
		if (sources.Length == 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		DeleteBuffers(sources.Length, ref sources[0]);
	}

	[CLSCompliant(false)]
	public static void DeleteSource(ref uint source)
	{
		DeleteSources(1, ref source);
	}

	public static void DeleteSource(int source)
	{
		DeleteSources(1, ref source);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alIsSource", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool IsSource(uint sid);

	public static bool IsSource(int sid)
	{
		return IsSource((uint)sid);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSourcef", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Source(uint sid, ALSourcef param, float value);

	public static void Source(int sid, ALSourcef param, float value)
	{
		Source((uint)sid, param, value);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSource3f", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Source(uint sid, ALSource3f param, float value1, float value2, float value3);

	public static void Source(int sid, ALSource3f param, float value1, float value2, float value3)
	{
		Source((uint)sid, param, value1, value2, value3);
	}

	[CLSCompliant(false)]
	public static void Source(uint sid, ALSource3f param, ref Vector3 values)
	{
		Source(sid, param, values.X, values.Y, values.Z);
	}

	public static void Source(int sid, ALSource3f param, ref Vector3 values)
	{
		Source((uint)sid, param, values.X, values.Y, values.Z);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSourcei", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Source(uint sid, ALSourcei param, int value);

	public static void Source(int sid, ALSourcei param, int value)
	{
		Source((uint)sid, param, value);
	}

	[CLSCompliant(false)]
	public static void Source(uint sid, ALSourceb param, bool value)
	{
		Source(sid, (ALSourcei)param, value ? 1 : 0);
	}

	public static void Source(int sid, ALSourceb param, bool value)
	{
		Source((uint)sid, (ALSourcei)param, value ? 1 : 0);
	}

	[CLSCompliant(false)]
	public static void BindBufferToSource(uint source, uint buffer)
	{
		Source(source, ALSourcei.Buffer, (int)buffer);
	}

	public static void BindBufferToSource(int source, int buffer)
	{
		Source((uint)source, ALSourcei.Buffer, buffer);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSource3i", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Source(uint sid, ALSource3i param, int value1, int value2, int value3);

	public static void Source(int sid, ALSource3i param, int value1, int value2, int value3)
	{
		Source((uint)sid, param, value1, value2, value3);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetSourcef", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void GetSource(uint sid, ALSourcef param, out float value);

	public static void GetSource(int sid, ALSourcef param, out float value)
	{
		GetSource((uint)sid, param, out value);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetSource3f", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void GetSource(uint sid, ALSource3f param, out float value1, out float value2, out float value3);

	public static void GetSource(int sid, ALSource3f param, out float value1, out float value2, out float value3)
	{
		GetSource((uint)sid, param, out value1, out value2, out value3);
	}

	[CLSCompliant(false)]
	public static void GetSource(uint sid, ALSource3f param, out Vector3 values)
	{
		GetSource(sid, param, out values.X, out values.Y, out values.Z);
	}

	public static void GetSource(int sid, ALSource3f param, out Vector3 values)
	{
		GetSource((uint)sid, param, out values.X, out values.Y, out values.Z);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetSourcei", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void GetSource(uint sid, ALGetSourcei param, out int value);

	public static void GetSource(int sid, ALGetSourcei param, out int value)
	{
		GetSource((uint)sid, param, out value);
	}

	[CLSCompliant(false)]
	public static void GetSource(uint sid, ALSourceb param, out bool value)
	{
		GetSource(sid, (ALGetSourcei)param, out var value2);
		value = value2 != 0;
	}

	public static void GetSource(int sid, ALSourceb param, out bool value)
	{
		GetSource((uint)sid, (ALGetSourcei)param, out var value2);
		value = value2 != 0;
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourcePlayv")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void SourcePlay(int ns, [In] uint* sids);

	[CLSCompliant(false)]
	public unsafe static void SourcePlay(int ns, uint[] sids)
	{
		fixed (uint* sids2 = sids)
		{
			SourcePlay(ns, sids2);
		}
	}

	public static void SourcePlay(int ns, int[] sids)
	{
		uint[] array = new uint[ns];
		for (int i = 0; i < ns; i++)
		{
			array[i] = (uint)sids[i];
		}
		SourcePlay(ns, array);
	}

	[CLSCompliant(false)]
	public unsafe static void SourcePlay(int ns, ref uint sids)
	{
		fixed (uint* sids2 = &sids)
		{
			SourcePlay(ns, sids2);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceStopv")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void SourceStop(int ns, [In] uint* sids);

	[CLSCompliant(false)]
	public unsafe static void SourceStop(int ns, uint[] sids)
	{
		fixed (uint* sids2 = sids)
		{
			SourceStop(ns, sids2);
		}
	}

	public static void SourceStop(int ns, int[] sids)
	{
		uint[] array = new uint[ns];
		for (int i = 0; i < ns; i++)
		{
			array[i] = (uint)sids[i];
		}
		SourceStop(ns, array);
	}

	[CLSCompliant(false)]
	public unsafe static void SourceStop(int ns, ref uint sids)
	{
		fixed (uint* sids2 = &sids)
		{
			SourceStop(ns, sids2);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceRewindv")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void SourceRewind(int ns, [In] uint* sids);

	[CLSCompliant(false)]
	public unsafe static void SourceRewind(int ns, uint[] sids)
	{
		fixed (uint* sids2 = sids)
		{
			SourceRewind(ns, sids2);
		}
	}

	public static void SourceRewind(int ns, int[] sids)
	{
		uint[] array = new uint[ns];
		for (int i = 0; i < ns; i++)
		{
			array[i] = (uint)sids[i];
		}
		SourceRewind(ns, array);
	}

	[CLSCompliant(false)]
	public unsafe static void SourceRewind(int ns, ref uint sids)
	{
		fixed (uint* sids2 = &sids)
		{
			SourceRewind(ns, sids2);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourcePausev")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void SourcePause(int ns, [In] uint* sids);

	[CLSCompliant(false)]
	public unsafe static void SourcePause(int ns, uint[] sids)
	{
		fixed (uint* sids2 = sids)
		{
			SourcePause(ns, sids2);
		}
	}

	public static void SourcePause(int ns, int[] sids)
	{
		uint[] array = new uint[ns];
		for (int i = 0; i < ns; i++)
		{
			array[i] = (uint)sids[i];
		}
		SourcePause(ns, array);
	}

	[CLSCompliant(false)]
	public unsafe static void SourcePause(int ns, ref uint sids)
	{
		fixed (uint* sids2 = &sids)
		{
			SourcePause(ns, sids2);
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSourcePlay", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourcePlay(uint sid);

	public static void SourcePlay(int sid)
	{
		SourcePlay((uint)sid);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSourceStop", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourceStop(uint sid);

	public static void SourceStop(int sid)
	{
		SourceStop((uint)sid);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSourceRewind", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourceRewind(uint sid);

	public static void SourceRewind(int sid)
	{
		SourceRewind((uint)sid);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSourcePause", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourcePause(uint sid);

	public static void SourcePause(int sid)
	{
		SourcePause((uint)sid);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceQueueBuffers")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void SourceQueueBuffers(uint sid, int numEntries, [In] uint* bids);

	[CLSCompliant(false)]
	public unsafe static void SourceQueueBuffers(uint sid, int numEntries, uint[] bids)
	{
		fixed (uint* bids2 = bids)
		{
			SourceQueueBuffers(sid, numEntries, bids2);
		}
	}

	public static void SourceQueueBuffers(int sid, int numEntries, int[] bids)
	{
		uint[] array = new uint[numEntries];
		for (int i = 0; i < numEntries; i++)
		{
			array[i] = (uint)bids[i];
		}
		SourceQueueBuffers((uint)sid, numEntries, array);
	}

	[CLSCompliant(false)]
	public unsafe static void SourceQueueBuffers(uint sid, int numEntries, ref uint bids)
	{
		fixed (uint* bids2 = &bids)
		{
			SourceQueueBuffers(sid, numEntries, bids2);
		}
	}

	public unsafe static void SourceQueueBuffer(int source, int buffer)
	{
		SourceQueueBuffers((uint)source, 1, (uint*)(&buffer));
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceUnqueueBuffers")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void SourceUnqueueBuffers(uint sid, int numEntries, [In] uint* bids);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceUnqueueBuffers")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourceUnqueueBuffers(uint sid, int numEntries, [Out] uint[] bids);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceUnqueueBuffers")]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourceUnqueueBuffers(int sid, int numEntries, [Out] int[] bids);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceUnqueueBuffers")]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourceUnqueueBuffers(uint sid, int numEntries, ref uint bids);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", EntryPoint = "alSourceUnqueueBuffers")]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SourceUnqueueBuffers(int sid, int numEntries, ref int bids);

	public unsafe static int SourceUnqueueBuffer(int sid)
	{
		uint result = default(uint);
		SourceUnqueueBuffers((uint)sid, 1, &result);
		return (int)result;
	}

	public static int[] SourceUnqueueBuffers(int sid, int numEntries)
	{
		if (numEntries <= 0)
		{
			throw new ArgumentOutOfRangeException("numEntries", "Must be greater than zero.");
		}
		int[] array = new int[numEntries];
		SourceUnqueueBuffers(sid, numEntries, array);
		return array;
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGenBuffers", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void GenBuffers(int n, [Out] uint* buffers);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGenBuffers", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void GenBuffers(int n, [Out] int* buffers);

	[CLSCompliant(false)]
	public unsafe static void GenBuffers(int n, out uint buffers)
	{
		fixed (uint* buffers2 = &buffers)
		{
			GenBuffers(n, buffers2);
		}
	}

	public unsafe static void GenBuffers(int n, out int buffers)
	{
		fixed (int* buffers2 = &buffers)
		{
			GenBuffers(n, buffers2);
		}
	}

	public static int[] GenBuffers(int n)
	{
		int[] array = new int[n];
		GenBuffers(array.Length, out array[0]);
		return array;
	}

	public static int GenBuffer()
	{
		GenBuffers(1, out int buffers);
		return buffers;
	}

	[CLSCompliant(false)]
	public static void GenBuffer(out uint buffer)
	{
		GenBuffers(1, out buffer);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDeleteBuffers", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void DeleteBuffers(int n, [In] uint* buffers);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDeleteBuffers", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void DeleteBuffers(int n, [In] int* buffers);

	[CLSCompliant(false)]
	public unsafe static void DeleteBuffers(int n, [In] ref uint buffers)
	{
		fixed (uint* buffers2 = &buffers)
		{
			DeleteBuffers(n, buffers2);
		}
	}

	public unsafe static void DeleteBuffers(int n, [In] ref int buffers)
	{
		fixed (int* buffers2 = &buffers)
		{
			DeleteBuffers(n, buffers2);
		}
	}

	[CLSCompliant(false)]
	public static void DeleteBuffers(uint[] buffers)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException();
		}
		if (buffers.Length == 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		DeleteBuffers(buffers.Length, ref buffers[0]);
	}

	public static void DeleteBuffers(int[] buffers)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException();
		}
		if (buffers.Length == 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		DeleteBuffers(buffers.Length, ref buffers[0]);
	}

	[CLSCompliant(false)]
	public static void DeleteBuffer(ref uint buffer)
	{
		DeleteBuffers(1, ref buffer);
	}

	public static void DeleteBuffer(int buffer)
	{
		DeleteBuffers(1, ref buffer);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alIsBuffer", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool IsBuffer(uint bid);

	public static bool IsBuffer(int bid)
	{
		return IsBuffer((uint)bid);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alBufferData", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void BufferData(uint bid, ALFormat format, IntPtr buffer, int size, int freq);

	public static void BufferData(int bid, ALFormat format, IntPtr buffer, int size, int freq)
	{
		BufferData((uint)bid, format, buffer, size, freq);
	}

	public static void BufferData<TBuffer>(int bid, ALFormat format, TBuffer[] buffer, int size, int freq) where TBuffer : struct
	{
		if (!BlittableValueType.Check(buffer))
		{
			throw new ArgumentException("buffer");
		}
		GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		try
		{
			BufferData(bid, format, gCHandle.AddrOfPinnedObject(), size, freq);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alGetBufferi", ExactSpelling = true)]
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void GetBuffer(uint bid, ALGetBufferi param, out int value);

	public static void GetBuffer(int bid, ALGetBufferi param, out int value)
	{
		GetBuffer((uint)bid, param, out value);
	}

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDopplerFactor", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void DopplerFactor(float value);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDopplerVelocity", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void DopplerVelocity(float value);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alSpeedOfSound", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SpeedOfSound(float value);

	[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, EntryPoint = "alDistanceModel", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void DistanceModel(ALDistanceModel distancemodel);

	[CLSCompliant(false)]
	public static ALSourceState GetSourceState(uint sid)
	{
		GetSource(sid, ALGetSourcei.SourceState, out var value);
		return (ALSourceState)value;
	}

	public static ALSourceState GetSourceState(int sid)
	{
		GetSource(sid, ALGetSourcei.SourceState, out var value);
		return (ALSourceState)value;
	}

	[CLSCompliant(false)]
	public static ALSourceType GetSourceType(uint sid)
	{
		GetSource(sid, ALGetSourcei.SourceType, out var value);
		return (ALSourceType)value;
	}

	public static ALSourceType GetSourceType(int sid)
	{
		GetSource(sid, ALGetSourcei.SourceType, out var value);
		return (ALSourceType)value;
	}

	public static ALDistanceModel GetDistanceModel()
	{
		return (ALDistanceModel)Get(ALGetInteger.DistanceModel);
	}
}
