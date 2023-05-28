using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVContentKeySystemExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("AVContentKeySystemFairPlayStreaming", "AVFoundation")]
	internal unsafe static IntPtr AVContentKeySystemFairPlayStreaming
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVContentKeySystemFairPlayStreaming", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVContentKeySystemClearKey", "AVFoundation")]
	internal unsafe static IntPtr AVContentKeySystemClearKey
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVContentKeySystemClearKey", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVContentKeySystemAuthorizationToken", "AVFoundation")]
	internal unsafe static IntPtr AVContentKeySystemAuthorizationToken
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVContentKeySystemAuthorizationToken", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVContentKeySystem self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVContentKeySystemFairPlayStreaming;
			break;
		case 1:
			ptr = AVContentKeySystemClearKey;
			break;
		case 2:
			ptr = AVContentKeySystemAuthorizationToken;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVContentKeySystem GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVContentKeySystemFairPlayStreaming))
		{
			return AVContentKeySystem.FairPlayStreaming;
		}
		if (constant.IsEqualTo(AVContentKeySystemClearKey))
		{
			return AVContentKeySystem.ClearKey;
		}
		if (constant.IsEqualTo(AVContentKeySystemAuthorizationToken))
		{
			return AVContentKeySystem.AuthorizationToken;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
