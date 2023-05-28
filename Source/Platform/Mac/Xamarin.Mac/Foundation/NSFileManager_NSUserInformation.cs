using System;
using ObjCRuntime;

namespace Foundation;

public static class NSFileManager_NSUserInformation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHomeDirectoryForCurrentUser = "homeDirectoryForCurrentUser";

	private static readonly IntPtr selHomeDirectoryForCurrentUserHandle = Selector.GetHandle("homeDirectoryForCurrentUser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHomeDirectoryForUser_ = "homeDirectoryForUser:";

	private static readonly IntPtr selHomeDirectoryForUser_Handle = Selector.GetHandle("homeDirectoryForUser:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryDirectory = "temporaryDirectory";

	private static readonly IntPtr selTemporaryDirectoryHandle = Selector.GetHandle("temporaryDirectory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSFileManager");

	[Export("homeDirectoryForUser:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl? GetHomeDirectory(this NSFileManager This, string userName)
	{
		if (userName == null)
		{
			throw new ArgumentNullException("userName");
		}
		IntPtr intPtr = NSString.CreateNative(userName);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selHomeDirectoryForUser_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[Export("homeDirectoryForCurrentUser")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl GetHomeDirectoryForCurrentUser(this NSFileManager This)
	{
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(This.Handle, selHomeDirectoryForCurrentUserHandle));
	}

	[Export("temporaryDirectory")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl GetTemporaryDirectory(this NSFileManager This)
	{
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(This.Handle, selTemporaryDirectoryHandle));
	}
}
