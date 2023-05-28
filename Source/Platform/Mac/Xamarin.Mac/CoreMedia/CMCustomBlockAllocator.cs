using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreMedia;

[Watch(6, 0)]
public class CMCustomBlockAllocator : IDisposable
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct CMBlockBufferCustomBlockSource
	{
		public uint Version;

		public CMAllocateCallback Allocate;

		public CMFreeCallback Free;

		public IntPtr RefCon;
	}

	internal delegate IntPtr CMAllocateCallback(IntPtr refCon, nuint sizeInBytes);

	internal delegate void CMFreeCallback(IntPtr refCon, IntPtr doomedMemoryBlock, nuint sizeInBytes);

	private GCHandle gch;

	internal CMBlockBufferCustomBlockSource Cblock;

	private static CMAllocateCallback static_AllocateCallback = AllocateCallback;

	private static CMFreeCallback static_FreeCallback = FreeCallback;

	public CMCustomBlockAllocator()
	{
		gch = GCHandle.Alloc(this);
		Cblock.Version = 0u;
		Cblock.Allocate = static_AllocateCallback;
		Cblock.Free = static_FreeCallback;
		Cblock.RefCon = GCHandle.ToIntPtr(gch);
	}

	private static IntPtr AllocateCallback(IntPtr refCon, nuint sizeInBytes)
	{
		return ((CMCustomBlockAllocator)GCHandle.FromIntPtr(refCon).Target).Allocate(sizeInBytes);
	}

	public virtual IntPtr Allocate(nuint sizeInBytes)
	{
		return Marshal.AllocHGlobal((int)sizeInBytes);
	}

	private static void FreeCallback(IntPtr refCon, IntPtr doomedMemoryBlock, nuint sizeInBytes)
	{
		((CMCustomBlockAllocator)GCHandle.FromIntPtr(refCon).Target).Free(doomedMemoryBlock, sizeInBytes);
	}

	public virtual void Free(IntPtr doomedMemoryBlock, nuint sizeInBytes)
	{
		Marshal.FreeHGlobal(doomedMemoryBlock);
	}

	~CMCustomBlockAllocator()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}
}
