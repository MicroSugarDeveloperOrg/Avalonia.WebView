using System;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public static class CFErrorDomain
{
	public static readonly NSString Cocoa;

	public static readonly NSString Mach;

	public static readonly NSString OSStatus;

	public static readonly NSString Posix;

	static CFErrorDomain()
	{
		IntPtr handle = Libraries.CoreFoundation.Handle;
		Cocoa = Dlfcn.GetStringConstant(handle, "kCFErrorDomainCocoa");
		Mach = Dlfcn.GetStringConstant(handle, "kCFErrorDomainMach");
		OSStatus = Dlfcn.GetStringConstant(handle, "kCFErrorDomainOSStatus");
		Posix = Dlfcn.GetStringConstant(handle, "kCFErrorDomainPosix");
	}
}
