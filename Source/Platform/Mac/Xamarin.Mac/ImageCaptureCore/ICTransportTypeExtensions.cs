using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ICTransportTypeExtensions
{
	private static IntPtr[] values = new IntPtr[5];

	[Field("ICTransportTypeUSB", "ImageCaptureCore")]
	internal unsafe static IntPtr ICTransportTypeUSB
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.ImageCaptureCore.Handle, "ICTransportTypeUSB", storage);
			}
		}
	}

	[Field("ICTransportTypeFireWire", "ImageCaptureCore")]
	internal unsafe static IntPtr ICTransportTypeFireWire
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.ImageCaptureCore.Handle, "ICTransportTypeFireWire", storage);
			}
		}
	}

	[Field("ICTransportTypeBluetooth", "ImageCaptureCore")]
	internal unsafe static IntPtr ICTransportTypeBluetooth
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.ImageCaptureCore.Handle, "ICTransportTypeBluetooth", storage);
			}
		}
	}

	[Field("ICTransportTypeTCPIP", "ImageCaptureCore")]
	internal unsafe static IntPtr ICTransportTypeTCPIP
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.ImageCaptureCore.Handle, "ICTransportTypeTCPIP", storage);
			}
		}
	}

	[Field("ICTransportTypeMassStorage", "ImageCaptureCore")]
	internal unsafe static IntPtr ICTransportTypeMassStorage
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.ImageCaptureCore.Handle, "ICTransportTypeMassStorage", storage);
			}
		}
	}

	public static NSString? GetConstant(this ICTransportType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = ICTransportTypeUSB;
			break;
		case 1:
			ptr = ICTransportTypeFireWire;
			break;
		case 2:
			ptr = ICTransportTypeBluetooth;
			break;
		case 3:
			ptr = ICTransportTypeTCPIP;
			break;
		case 4:
			ptr = ICTransportTypeMassStorage;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static ICTransportType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(ICTransportTypeUSB))
		{
			return ICTransportType.Usb;
		}
		if (constant.IsEqualTo(ICTransportTypeFireWire))
		{
			return ICTransportType.FireWire;
		}
		if (constant.IsEqualTo(ICTransportTypeBluetooth))
		{
			return ICTransportType.Bluetooth;
		}
		if (constant.IsEqualTo(ICTransportTypeTCPIP))
		{
			return ICTransportType.TcpIp;
		}
		if (constant.IsEqualTo(ICTransportTypeMassStorage))
		{
			return ICTransportType.MassStorage;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
