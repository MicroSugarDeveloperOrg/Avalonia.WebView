using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public struct CMTimeMapping
{
	public CMTimeRange Source;

	public CMTimeRange Target;

	[iOS(9, 0)]
	[Mac(10, 11)]
	public string Description => new NSString(CMTimeMappingCopyDescription(IntPtr.Zero, this), alloced: true);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CMTimeMapping Create(CMTimeRange source, CMTimeRange target)
	{
		return CMTimeMappingMake(source, target);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CMTimeMapping CreateEmpty(CMTimeRange target)
	{
		return CMTimeMappingMakeEmpty(target);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CMTimeMapping CreateFromDictionary(NSDictionary dict)
	{
		return CMTimeMappingMakeFromDictionary(dict.Handle);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public NSDictionary AsDictionary()
	{
		return new NSDictionary(CMTimeMappingCopyAsDictionary(this, IntPtr.Zero), alloced: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern CMTimeMapping CMTimeMappingMake(CMTimeRange source, CMTimeRange target);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern CMTimeMapping CMTimeMappingMakeEmpty(CMTimeRange target);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern IntPtr CMTimeMappingCopyAsDictionary(CMTimeMapping mapping, IntPtr allocator);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern CMTimeMapping CMTimeMappingMakeFromDictionary(IntPtr dict);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern IntPtr CMTimeMappingCopyDescription(IntPtr allocator, CMTimeMapping mapping);
}
