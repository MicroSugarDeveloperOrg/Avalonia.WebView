using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace MediaAccessibility;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
public static class MAImageCaptioning
{
	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MAImageCaptioningCopyCaption(IntPtr url, out IntPtr error);

	public static string GetCaption(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr error2;
		IntPtr handle = MAImageCaptioningCopyCaption(url.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return CFString.FetchString(handle, releaseHandle: true);
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool MAImageCaptioningSetCaption(IntPtr url, IntPtr @string, out IntPtr error);

	public static bool SetCaption(NSUrl url, string @string, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = NSString.CreateNative(@string);
		try
		{
			IntPtr error2;
			bool result = MAImageCaptioningSetCaption(url.Handle, intPtr, out error2);
			error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
			return result;
		}
		finally
		{
			NSString.ReleaseNative(intPtr);
		}
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MAImageCaptioningCopyMetadataTagPath();

	public static string GetMetadataTagPath()
	{
		return CFString.FetchString(MAImageCaptioningCopyMetadataTagPath(), releaseHandle: true);
	}
}
