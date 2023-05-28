using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public class CFException : Exception
{
	public nint Code { get; private set; }

	public NSString Domain { get; private set; }

	public string FailureReason { get; private set; }

	public string RecoverySuggestion { get; private set; }

	public CFException(string description, NSString domain, nint code, string failureReason, string recoverySuggestion)
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
			throw new ArgumentNullException("cfErrorHandle");
		}
		CFException ex = new CFException(CFString.FetchString(CFErrorCopyDescription(cfErrorHandle), releaseHandle: true), (NSString)Runtime.GetNSObject(CFErrorGetDomain(cfErrorHandle)), CFErrorGetCode(cfErrorHandle), CFString.FetchString(CFErrorCopyFailureReason(cfErrorHandle), releaseHandle: true), CFString.FetchString(CFErrorCopyRecoverySuggestion(cfErrorHandle), releaseHandle: true));
		IntPtr intPtr = CFErrorCopyUserInfo(cfErrorHandle);
		if (intPtr != IntPtr.Zero)
		{
			using NSDictionary nSDictionary = new NSDictionary(intPtr);
			foreach (KeyValuePair<NSObject, NSObject> item in nSDictionary)
			{
				ex.Data.Add(item.Key?.ToString(), item.Value?.ToString());
			}
		}
		if (release)
		{
			CFObject.CFRelease(cfErrorHandle);
		}
		return ex;
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
	private static extern nint CFErrorGetCode(IntPtr err);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFErrorGetDomain(IntPtr err);
}
