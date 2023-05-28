using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGCopyImageSourceOptions
{
	[iOS(7, 0)]
	public CGImageMetadata Metadata { get; set; }

	[iOS(7, 0)]
	public bool MergeMetadata { get; set; }

	[iOS(7, 0)]
	public bool ShouldExcludeXMP { get; set; }

	[Mac(10, 10)]
	[iOS(8, 0)]
	public bool ShouldExcludeGPS { get; set; }

	[iOS(7, 0)]
	public DateTime? DateTime { get; set; }

	[iOS(7, 0)]
	public int? Orientation { get; set; }

	[Field("kCGImageDestinationDateTime", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static IntPtr kDateTime
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageDestinationDateTime");
		}
	}

	[Field("kCGImageDestinationMergeMetadata", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static IntPtr kMergeMetadata
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageDestinationMergeMetadata");
		}
	}

	[Field("kCGImageDestinationMetadata", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static IntPtr kMetadata
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageDestinationMetadata");
		}
	}

	[Field("kCGImageDestinationOrientation", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static IntPtr kOrientation
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageDestinationOrientation");
		}
	}

	[Field("kCGImageMetadataShouldExcludeGPS", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	internal static IntPtr kShouldExcludeGPS
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageMetadataShouldExcludeGPS");
		}
	}

	[Field("kCGImageMetadataShouldExcludeXMP", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static IntPtr kShouldExcludeXMP
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageMetadataShouldExcludeXMP");
		}
	}

	internal NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (Metadata != null)
		{
			nSMutableDictionary.LowlevelSetObject(Metadata.Handle, kMetadata);
			if (MergeMetadata)
			{
				nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, kMergeMetadata);
			}
			if (ShouldExcludeXMP)
			{
				nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, kShouldExcludeXMP);
			}
		}
		else if (DateTime.HasValue)
		{
			DateTime? dateTime = DateTime;
			nSMutableDictionary.LowlevelSetObject(dateTime.HasValue ? ((NSDate)dateTime.GetValueOrDefault()) : null, kDateTime);
		}
		if (ShouldExcludeGPS && kShouldExcludeGPS != IntPtr.Zero)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, kShouldExcludeGPS);
		}
		if (Orientation.HasValue)
		{
			using NSNumber nSNumber = new NSNumber(Orientation.Value);
			nSMutableDictionary.LowlevelSetObject(nSNumber.Handle, kOrientation);
		}
		return nSMutableDictionary;
	}
}
