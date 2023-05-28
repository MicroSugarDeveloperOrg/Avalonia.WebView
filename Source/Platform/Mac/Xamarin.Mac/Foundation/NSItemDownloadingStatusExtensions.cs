using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSItemDownloadingStatusExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("NSMetadataUbiquitousItemDownloadingStatusCurrent", "Foundation")]
	internal unsafe static IntPtr NSMetadataUbiquitousItemDownloadingStatusCurrent
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusCurrent", storage);
			}
		}
	}

	[Field("NSMetadataUbiquitousItemDownloadingStatusDownloaded", "Foundation")]
	internal unsafe static IntPtr NSMetadataUbiquitousItemDownloadingStatusDownloaded
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusDownloaded", storage);
			}
		}
	}

	[Field("NSMetadataUbiquitousItemDownloadingStatusNotDownloaded", "Foundation")]
	internal unsafe static IntPtr NSMetadataUbiquitousItemDownloadingStatusNotDownloaded
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusNotDownloaded", storage);
			}
		}
	}

	public static NSString? GetConstant(this NSItemDownloadingStatus self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NSMetadataUbiquitousItemDownloadingStatusCurrent;
			break;
		case 1:
			ptr = NSMetadataUbiquitousItemDownloadingStatusDownloaded;
			break;
		case 2:
			ptr = NSMetadataUbiquitousItemDownloadingStatusNotDownloaded;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NSItemDownloadingStatus GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return NSItemDownloadingStatus.Unknown;
		}
		if (constant.IsEqualTo(NSMetadataUbiquitousItemDownloadingStatusCurrent))
		{
			return NSItemDownloadingStatus.Current;
		}
		if (constant.IsEqualTo(NSMetadataUbiquitousItemDownloadingStatusDownloaded))
		{
			return NSItemDownloadingStatus.Downloaded;
		}
		if (constant.IsEqualTo(NSMetadataUbiquitousItemDownloadingStatusNotDownloaded))
		{
			return NSItemDownloadingStatus.NotDownloaded;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
