using System;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public static class CFExceptionDataKey
{
	public static readonly NSString Description;

	public static readonly NSString LocalizedDescription;

	public static readonly NSString LocalizedFailureReason;

	public static readonly NSString LocalizedRecoverySuggestion;

	public static readonly NSString UnderlyingError;

	static CFExceptionDataKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Description = Dlfcn.GetStringConstant(intPtr, "kCFErrorDescriptionKey");
			LocalizedDescription = Dlfcn.GetStringConstant(intPtr, "kCFErrorLocalizedDescriptionKey");
			LocalizedFailureReason = Dlfcn.GetStringConstant(intPtr, "kCFErrorLocalizedFailureReasonKey");
			LocalizedRecoverySuggestion = Dlfcn.GetStringConstant(intPtr, "kCFErrorLocalizedRecoverySuggestionKey");
			UnderlyingError = Dlfcn.GetStringConstant(intPtr, "kCFErrorUnderlyingErrorKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
