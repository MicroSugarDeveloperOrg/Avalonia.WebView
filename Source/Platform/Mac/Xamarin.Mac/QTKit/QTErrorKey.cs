using Foundation;
using ObjCRuntime;

namespace QTKit;

public static class QTErrorKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CaptureInput;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CaptureOutput;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Device;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Domain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExcludingDevice;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordingSuccesfullyFinished;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Time;

	[Field("QTErrorCaptureInputKey", "QTKit")]
	public static NSString CaptureInput
	{
		get
		{
			if (_CaptureInput == null)
			{
				_CaptureInput = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorCaptureInputKey");
			}
			return _CaptureInput;
		}
	}

	[Field("QTErrorCaptureOutputKey", "QTKit")]
	public static NSString CaptureOutput
	{
		get
		{
			if (_CaptureOutput == null)
			{
				_CaptureOutput = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorCaptureOutputKey");
			}
			return _CaptureOutput;
		}
	}

	[Field("QTErrorDeviceKey", "QTKit")]
	public static NSString Device
	{
		get
		{
			if (_Device == null)
			{
				_Device = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorDeviceKey");
			}
			return _Device;
		}
	}

	[Field("QTKitErrorDomain", "QTKit")]
	public static NSString Domain
	{
		get
		{
			if (_Domain == null)
			{
				_Domain = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTKitErrorDomain");
			}
			return _Domain;
		}
	}

	[Field("QTErrorExcludingDeviceKey", "QTKit")]
	public static NSString ExcludingDevice
	{
		get
		{
			if (_ExcludingDevice == null)
			{
				_ExcludingDevice = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorExcludingDeviceKey");
			}
			return _ExcludingDevice;
		}
	}

	[Field("QTErrorFileSizeKey", "QTKit")]
	public static NSString FileSize
	{
		get
		{
			if (_FileSize == null)
			{
				_FileSize = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorFileSizeKey");
			}
			return _FileSize;
		}
	}

	[Field("QTErrorRecordingSuccesfullyFinishedKey", "QTKit")]
	public static NSString RecordingSuccesfullyFinished
	{
		get
		{
			if (_RecordingSuccesfullyFinished == null)
			{
				_RecordingSuccesfullyFinished = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorRecordingSuccesfullyFinishedKey");
			}
			return _RecordingSuccesfullyFinished;
		}
	}

	[Field("QTErrorTimeKey", "QTKit")]
	public static NSString Time
	{
		get
		{
			if (_Time == null)
			{
				_Time = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTErrorTimeKey");
			}
			return _Time;
		}
	}
}
