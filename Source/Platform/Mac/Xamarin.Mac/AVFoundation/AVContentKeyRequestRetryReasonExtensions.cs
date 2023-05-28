using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVContentKeyRequestRetryReasonExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("AVContentKeyRequestRetryReasonTimedOut", "AVFoundation")]
	internal unsafe static IntPtr AVContentKeyRequestRetryReasonTimedOut
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVContentKeyRequestRetryReasonTimedOut", storage);
			}
		}
	}

	[Field("AVContentKeyRequestRetryReasonReceivedResponseWithExpiredLease", "AVFoundation")]
	internal unsafe static IntPtr AVContentKeyRequestRetryReasonReceivedResponseWithExpiredLease
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVContentKeyRequestRetryReasonReceivedResponseWithExpiredLease", storage);
			}
		}
	}

	[Field("AVContentKeyRequestRetryReasonReceivedObsoleteContentKey", "AVFoundation")]
	internal unsafe static IntPtr AVContentKeyRequestRetryReasonReceivedObsoleteContentKey
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVContentKeyRequestRetryReasonReceivedObsoleteContentKey", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVContentKeyRequestRetryReason self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVContentKeyRequestRetryReasonTimedOut;
			break;
		case 1:
			ptr = AVContentKeyRequestRetryReasonReceivedResponseWithExpiredLease;
			break;
		case 2:
			ptr = AVContentKeyRequestRetryReasonReceivedObsoleteContentKey;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVContentKeyRequestRetryReason GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVContentKeyRequestRetryReasonTimedOut))
		{
			return AVContentKeyRequestRetryReason.TimedOut;
		}
		if (constant.IsEqualTo(AVContentKeyRequestRetryReasonReceivedResponseWithExpiredLease))
		{
			return AVContentKeyRequestRetryReason.ReceivedResponseWithExpiredLease;
		}
		if (constant.IsEqualTo(AVContentKeyRequestRetryReasonReceivedObsoleteContentKey))
		{
			return AVContentKeyRequestRetryReason.ReceivedObsoleteContentKey;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
