using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVErrorKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Device;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DiscontinuityFlags;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSubType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentTrackID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Pid;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresentationTimeStamp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordingSuccessfullyFinished;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Time;

	[Field("AVErrorDeviceKey", "AVFoundation")]
	public static NSString Device
	{
		get
		{
			if (_Device == null)
			{
				_Device = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorDeviceKey");
			}
			return _Device;
		}
	}

	[Field("AVErrorDiscontinuityFlagsKey", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString DiscontinuityFlags
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_DiscontinuityFlags == null)
			{
				_DiscontinuityFlags = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorDiscontinuityFlagsKey");
			}
			return _DiscontinuityFlags;
		}
	}

	[Field("AVFoundationErrorDomain", "AVFoundation")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFoundationErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("AVErrorFileSizeKey", "AVFoundation")]
	public static NSString FileSize
	{
		get
		{
			if (_FileSize == null)
			{
				_FileSize = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorFileSizeKey");
			}
			return _FileSize;
		}
	}

	[Field("AVErrorFileTypeKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString FileType
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_FileType == null)
			{
				_FileType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorFileTypeKey");
			}
			return _FileType;
		}
	}

	[Field("AVErrorMediaSubTypeKey", "AVFoundation")]
	public static NSString MediaSubType
	{
		get
		{
			if (_MediaSubType == null)
			{
				_MediaSubType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorMediaSubTypeKey");
			}
			return _MediaSubType;
		}
	}

	[Field("AVErrorMediaTypeKey", "AVFoundation")]
	public static NSString MediaType
	{
		get
		{
			if (_MediaType == null)
			{
				_MediaType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorMediaTypeKey");
			}
			return _MediaType;
		}
	}

	[Field("AVErrorPersistentTrackIDKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString PersistentTrackID
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_PersistentTrackID == null)
			{
				_PersistentTrackID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorPersistentTrackIDKey");
			}
			return _PersistentTrackID;
		}
	}

	[Field("AVErrorPIDKey", "AVFoundation")]
	public static NSString Pid
	{
		get
		{
			if (_Pid == null)
			{
				_Pid = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorPIDKey");
			}
			return _Pid;
		}
	}

	[Field("AVErrorPresentationTimeStampKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString PresentationTimeStamp
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_PresentationTimeStamp == null)
			{
				_PresentationTimeStamp = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorPresentationTimeStampKey");
			}
			return _PresentationTimeStamp;
		}
	}

	[Field("AVErrorRecordingSuccessfullyFinishedKey", "AVFoundation")]
	public static NSString RecordingSuccessfullyFinished
	{
		get
		{
			if (_RecordingSuccessfullyFinished == null)
			{
				_RecordingSuccessfullyFinished = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorRecordingSuccessfullyFinishedKey");
			}
			return _RecordingSuccessfullyFinished;
		}
	}

	[Field("AVErrorTimeKey", "AVFoundation")]
	public static NSString Time
	{
		get
		{
			if (_Time == null)
			{
				_Time = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVErrorTimeKey");
			}
			return _Time;
		}
	}
}
