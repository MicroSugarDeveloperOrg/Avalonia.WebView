using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AudioToolbox;

public class MidiRawData : _MidiData
{
	internal unsafe override IntPtr ToUnmanaged()
	{
		byte* ptr = (byte*)(void*)Marshal.AllocHGlobal(4 + len);
		*(int*)ptr = len;
		byte* ptr2 = ptr + 4;
		if (data != null)
		{
			Marshal.Copy(data, start, (IntPtr)ptr2, len);
		}
		else
		{
			Runtime.memcpy(ptr2, (byte*)(void*)buffer, len);
		}
		return (IntPtr)ptr;
	}
}
