using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVAssetWriterInputMediaDataLocationExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("AVAssetWriterInputMediaDataLocationInterleavedWithMainMediaData", "AVFoundation")]
	internal unsafe static IntPtr AVAssetWriterInputMediaDataLocationInterleavedWithMainMediaData
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetWriterInputMediaDataLocationInterleavedWithMainMediaData", storage);
			}
		}
	}

	[Field("AVAssetWriterInputMediaDataLocationBeforeMainMediaDataNotInterleaved", "AVFoundation")]
	internal unsafe static IntPtr AVAssetWriterInputMediaDataLocationBeforeMainMediaDataNotInterleaved
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetWriterInputMediaDataLocationBeforeMainMediaDataNotInterleaved", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVAssetWriterInputMediaDataLocation self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVAssetWriterInputMediaDataLocationInterleavedWithMainMediaData;
			break;
		case 1:
			ptr = AVAssetWriterInputMediaDataLocationBeforeMainMediaDataNotInterleaved;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVAssetWriterInputMediaDataLocation GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVAssetWriterInputMediaDataLocationInterleavedWithMainMediaData))
		{
			return AVAssetWriterInputMediaDataLocation.InterleavedWithMainMediaData;
		}
		if (constant.IsEqualTo(AVAssetWriterInputMediaDataLocationBeforeMainMediaDataNotInterleaved))
		{
			return AVAssetWriterInputMediaDataLocation.BeforeMainMediaDataNotInterleaved;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
