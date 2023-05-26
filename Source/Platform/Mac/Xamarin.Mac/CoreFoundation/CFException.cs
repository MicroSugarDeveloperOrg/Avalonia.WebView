using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFException : Exception
{
	public int Code { get; private set; }

	public NSString Domain { get; private set; }

	public string FailureReason { get; private set; }

	public string RecoverySuggestion { get; private set; }

	public CFException(string description, NSString domain, int code, string failureReason, string recoverySuggestion)
		: base(description)
	{
		Code = code;
		Domain = domain;
		FailureReason = failureReason;
		RecoverySuggestion = recoverySuggestion;
	}

	public static CFException FromCFError(IntPtr cfErrorHandle)
	{
		return FromCFError(cfErrorHandle, release: true);
	}

	public static CFException FromCFError(IntPtr cfErrorHandle, bool release)
	{
		if (cfErrorHandle == IntPtr.Zero)
		{
			throw new ArgumentException("cfErrorHandle must not be null.", "cfErrorHandle");
		}
		CFException ex = new CFException(ToString(CFErrorCopyDescription(cfErrorHandle)), (NSString)Runtime.GetNSObject(CFErrorGetDomain(cfErrorHandle)), CFErrorGetCode(cfErrorHandle), ToString(CFErrorCopyFailureReason(cfErrorHandle)), ToString(CFErrorCopyRecoverySuggestion(cfErrorHandle)));
		IntPtr intPtr = CFErrorCopyUserInfo(cfErrorHandle);
		if (intPtr != IntPtr.Zero)
		{
			using NSDictionary nSDictionary = new NSDictionary(intPtr);
			foreach (KeyValuePair<NSObject, NSObject> item in nSDictionary)
			{
				ex.Data.Add(item.Key, item.Value);
			}
		}
		if (release)
		{
			CFObject.CFRelease(cfErrorHandle);
		}
		return ex;
	}

	private static string ToString(IntPtr cfStringRef)
	{
		return ToString(cfStringRef, release: true);
	}

	private static string ToString(IntPtr cfStringRef, bool release)
	{
		string result = CFString.FetchString(cfStringRef);
		if (release && cfStringRef != IntPtr.Zero)
		{
			CFObject.CFRelease(cfStringRef);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFErrorCopyDescription(IntPtr err);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFErrorCopyFailureReason(IntPtr err);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFErrorCopyRecoverySuggestion(IntPtr err);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFErrorCopyUserInfo(IntPtr err);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern int CFErrorGetCode(IntPtr err);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFErrorGetDomain(IntPtr err);
}
