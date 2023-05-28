using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AudioToolbox;

public class MidiMetaEvent : _MidiData
{
	public byte MetaEventType;

	internal unsafe override IntPtr ToUnmanaged()
	{
		byte* ptr = (byte*)(void*)Marshal.AllocHGlobal(8 + len);
		*ptr = MetaEventType;
		int* ptr2 = (int*)(ptr + 4);
		*ptr2 = len;
		byte* ptr3 = ptr + 8;
		if (data != null)
		{
			Marshal.Copy(data, start, (IntPtr)ptr3, len);
		}
		else
		{
			Runtime.memcpy(ptr3, (byte*)(void*)buffer, len);
		}
		return (IntPtr)ptr;
	}
}
