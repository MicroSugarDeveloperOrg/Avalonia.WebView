using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
internal class CMManagedArrayBlockAllocator : CMCustomBlockAllocator
{
	private GCHandle dataHandle;

	public CMManagedArrayBlockAllocator(byte[] data)
	{
		dataHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
	}

	public override IntPtr Allocate(nuint sizeInBytes)
	{
		return dataHandle.AddrOfPinnedObject();
	}

	public override void Free(IntPtr doomedMemoryBlock, nuint sizeInBytes)
	{
		if (dataHandle.IsAllocated)
		{
			dataHandle.Free();
		}
	}
}
