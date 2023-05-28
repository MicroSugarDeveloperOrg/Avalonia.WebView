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
		IntPtr handle = Libraries.CoreFoundation.Handle;
		Description = Dlfcn.GetStringConstant(handle, "kCFErrorDescriptionKey");
		LocalizedDescription = Dlfcn.GetStringConstant(handle, "kCFErrorLocalizedDescriptionKey");
		LocalizedFailureReason = Dlfcn.GetStringConstant(handle, "kCFErrorLocalizedFailureReasonKey");
		LocalizedRecoverySuggestion = Dlfcn.GetStringConstant(handle, "kCFErrorLocalizedRecoverySuggestionKey");
		UnderlyingError = Dlfcn.GetStringConstant(handle, "kCFErrorUnderlyingErrorKey");
	}
}
