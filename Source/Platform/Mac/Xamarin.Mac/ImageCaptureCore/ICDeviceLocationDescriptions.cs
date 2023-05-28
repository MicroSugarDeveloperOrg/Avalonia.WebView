using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICDeviceLocationDescriptions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Bluetooth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FireWire;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MassStorage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Usb;

	[Field("ICDeviceLocationDescriptionBluetooth", "ImageCaptureCore")]
	public static NSString Bluetooth
	{
		get
		{
			if (_Bluetooth == null)
			{
				_Bluetooth = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionBluetooth");
			}
			return _Bluetooth;
		}
	}

	[Field("ICDeviceLocationDescriptionFireWire", "ImageCaptureCore")]
	public static NSString FireWire
	{
		get
		{
			if (_FireWire == null)
			{
				_FireWire = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionFireWire");
			}
			return _FireWire;
		}
	}

	[Field("ICDeviceLocationDescriptionMassStorage", "ImageCaptureCore")]
	public static NSString MassStorage
	{
		get
		{
			if (_MassStorage == null)
			{
				_MassStorage = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionMassStorage");
			}
			return _MassStorage;
		}
	}

	[Field("ICDeviceLocationDescriptionUSB", "ImageCaptureCore")]
	public static NSString Usb
	{
		get
		{
			if (_Usb == null)
			{
				_Usb = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDeviceLocationDescriptionUSB");
			}
			return _Usb;
		}
	}
}
