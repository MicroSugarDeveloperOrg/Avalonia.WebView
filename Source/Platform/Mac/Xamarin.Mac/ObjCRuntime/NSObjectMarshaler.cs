using System;
using System.Runtime.InteropServices;
using Foundation;

namespace ObjCRuntime;

public class NSObjectMarshaler<T> : ICustomMarshaler where T : NSObject
{
	private static NSObjectMarshaler<T> marshaler;

	public object MarshalNativeToManaged(IntPtr handle)
	{
		return (T)Runtime.GetNSObject(handle);
	}

	public IntPtr MarshalManagedToNative(object obj)
	{
		if (obj == null)
		{
			return IntPtr.Zero;
		}
		if (!(obj is T))
		{
			throw new MarshalDirectiveException("This custom marshaler must be used on a NSObject derived type.");
		}
		return (obj as T).Handle;
	}

	public void CleanUpNativeData(IntPtr handle)
	{
	}

	public void CleanUpManagedData(object obj)
	{
	}

	public int GetNativeDataSize()
	{
		return -1;
	}

	public static ICustomMarshaler GetInstance(string cookie)
	{
		if (marshaler == null)
		{
			return marshaler = new NSObjectMarshaler<T>();
		}
		return marshaler;
	}
}
