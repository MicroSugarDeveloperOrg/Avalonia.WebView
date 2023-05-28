using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public static class AVMovie_AVMovieMovieHeaderSupport
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompatibleWithFileType_ = "isCompatibleWithFileType:";

	private static readonly IntPtr selIsCompatibleWithFileType_Handle = Selector.GetHandle("isCompatibleWithFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieHeaderWithFileType_Error_ = "movieHeaderWithFileType:error:";

	private static readonly IntPtr selMovieHeaderWithFileType_Error_Handle = Selector.GetHandle("movieHeaderWithFileType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteMovieHeaderToURL_FileType_Options_Error_ = "writeMovieHeaderToURL:fileType:options:error:";

	private static readonly IntPtr selWriteMovieHeaderToURL_FileType_Options_Error_Handle = Selector.GetHandle("writeMovieHeaderToURL:fileType:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMovie");

	[Export("movieHeaderWithFileType:error:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetMovieHeader(this AVMovie This, string fileType, out NSError? outError)
	{
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(fileType);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, selMovieHeaderWithFileType_Error_Handle, intPtr, ref arg));
		NSString.ReleaseNative(intPtr);
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("isCompatibleWithFileType:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsCompatibleWithFileType(this AVMovie This, string fileType)
	{
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr intPtr = NSString.CreateNative(fileType);
		bool result = Messaging.bool_objc_msgSend_IntPtr(This.Handle, selIsCompatibleWithFileType_Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Export("writeMovieHeaderToURL:fileType:options:error:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteMovieHeader(this AVMovie This, NSUrl URL, string fileType, AVMovieWritingOptions options, out NSError? outError)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(fileType);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(This.Handle, selWriteMovieHeaderToURL_FileType_Options_Error_Handle, URL.Handle, intPtr, (ulong)options, ref arg);
		NSString.ReleaseNative(intPtr);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
