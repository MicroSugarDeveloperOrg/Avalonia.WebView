using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreMedia;

namespace MediaToolbox;

public static class MTFormatNames
{
	[DllImport("/System/Library/Frameworks/MediaToolbox.framework/MediaToolbox")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern IntPtr MTCopyLocalizedNameForMediaType(CMMediaType mediaType);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static string GetLocalizedName(this CMMediaType mediaType)
	{
		return CFString.FetchString(MTCopyLocalizedNameForMediaType(mediaType), releaseHandle: true);
	}

	[DllImport("/System/Library/Frameworks/MediaToolbox.framework/MediaToolbox")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern IntPtr MTCopyLocalizedNameForMediaSubType(CMMediaType mediaType, uint mediaSubType);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static string GetLocalizedName(this CMMediaType mediaType, uint mediaSubType)
	{
		return CFString.FetchString(MTCopyLocalizedNameForMediaSubType(mediaType, mediaSubType), releaseHandle: true);
	}
}
