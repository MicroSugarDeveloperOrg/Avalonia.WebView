using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public static class CFPreferences
{
	public static readonly NSString CurrentApplication;

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFPreferencesCopyAppValue(IntPtr key, IntPtr applicationId);

	static CFPreferences()
	{
		IntPtr handle = Libraries.CoreFoundation.Handle;
		CurrentApplication = Dlfcn.GetStringConstant(handle, "kCFPreferencesCurrentApplication");
	}

	public static object GetAppValue(string key)
	{
		return GetAppValue(key, CurrentApplication);
	}

	public static object GetAppValue(string key, string applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using NSString applicationId2 = new NSString(applicationId);
		return GetAppValue(key, applicationId2);
	}

	public static object GetAppValue(string key, NSString applicationId)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		IntPtr intPtr;
		using (CFString cFString = new CFString(key))
		{
			intPtr = CFPreferencesCopyAppValue(cFString.Handle, applicationId.Handle);
		}
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		using CFPropertyList cFPropertyList = new CFPropertyList(intPtr, owns: true);
		return cFPropertyList.Value;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFPreferencesSetAppValue(IntPtr key, IntPtr value, IntPtr applicationId);

	public static void SetAppValue(string key, object value)
	{
		SetAppValue(key, value, CurrentApplication);
	}

	public static void SetAppValue(string key, object value, string applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using NSString applicationId2 = new NSString(applicationId);
		SetAppValue(key, value, applicationId2);
	}

	public static void SetAppValue(string key, object value, NSString applicationId)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using CFString cFString = new CFString(key);
		if (value == null)
		{
			CFPreferencesSetAppValue(cFString.Handle, IntPtr.Zero, applicationId.Handle);
		}
		else
		{
			if (value is string)
			{
				using CFString cFString2 = new CFString((string)value);
				CFPreferencesSetAppValue(cFString.Handle, cFString2.Handle, applicationId.Handle);
				return;
			}
			if (value is NSString || value is CFString || value is NSData || value is CFData || value is NSArray || value is CFArray || value is NSDictionary || value is CFDictionary || value is NSNumber || value is CFBoolean)
			{
				CFPreferencesSetAppValue(cFString.Handle, ((INativeObject)value).Handle, applicationId.Handle);
				return;
			}
		}
		NSNumber nSNumber = NSNumber.FromObject(value);
		if (nSNumber != null)
		{
			using (nSNumber)
			{
				CFPreferencesSetAppValue(cFString.Handle, nSNumber.Handle, applicationId.Handle);
				return;
			}
		}
		throw new ArgumentException("unsupported type: " + value.GetType(), "value");
	}

	public static void RemoveAppValue(string key)
	{
		SetAppValue(key, null, CurrentApplication);
	}

	public static void RemoveAppValue(string key, string applicationId)
	{
		SetAppValue(key, null, applicationId);
	}

	public static void RemoveAppValue(string key, NSString applicationId)
	{
		SetAppValue(key, null, applicationId);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFPreferencesGetAppBooleanValue(IntPtr key, IntPtr applicationId, IntPtr keyExistsAndHasValidFormat);

	public static bool GetAppBooleanValue(string key)
	{
		return GetAppBooleanValue(key, CurrentApplication);
	}

	public static bool GetAppBooleanValue(string key, string applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using NSString applicationId2 = new NSString(applicationId);
		return GetAppBooleanValue(key, applicationId2);
	}

	public static bool GetAppBooleanValue(string key, NSString applicationId)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using CFString cFString = new CFString(key);
		return CFPreferencesGetAppBooleanValue(cFString.Handle, applicationId.Handle, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFPreferencesGetAppIntegerValue(IntPtr key, IntPtr applicationId, IntPtr keyExistsAndHasValidFormat);

	public static nint GetAppIntegerValue(string key)
	{
		return GetAppIntegerValue(key, CurrentApplication);
	}

	public static nint GetAppIntegerValue(string key, string applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using NSString applicationId2 = new NSString(applicationId);
		return GetAppIntegerValue(key, applicationId2);
	}

	public static nint GetAppIntegerValue(string key, NSString applicationId)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using CFString cFString = new CFString(key);
		return CFPreferencesGetAppIntegerValue(cFString.Handle, applicationId.Handle, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFPreferencesAddSuitePreferencesToApp(IntPtr applicationId, IntPtr suiteId);

	public static void AddSuitePreferencesToApp(string suiteId)
	{
		AddSuitePreferencesToApp(CurrentApplication, suiteId);
	}

	public static void AddSuitePreferencesToApp(string applicationId, string suiteId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException(applicationId);
		}
		using NSString applicationId2 = new NSString(applicationId);
		AddSuitePreferencesToApp(applicationId2, suiteId);
	}

	public static void AddSuitePreferencesToApp(NSString applicationId, string suiteId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		if (suiteId == null)
		{
			throw new ArgumentNullException("suiteId");
		}
		using CFString cFString = new CFString(suiteId);
		CFPreferencesAddSuitePreferencesToApp(applicationId.Handle, cFString.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFPreferencesRemoveSuitePreferencesFromApp(IntPtr applicationId, IntPtr suiteId);

	public static void RemoveSuitePreferencesFromApp(string suiteId)
	{
		RemoveSuitePreferencesFromApp(CurrentApplication, suiteId);
	}

	public static void RemoveSuitePreferencesFromApp(string applicationId, string suiteId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException(applicationId);
		}
		using NSString applicationId2 = new NSString(applicationId);
		RemoveSuitePreferencesFromApp(applicationId2, suiteId);
	}

	public static void RemoveSuitePreferencesFromApp(NSString applicationId, string suiteId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		if (suiteId == null)
		{
			throw new ArgumentNullException("suiteId");
		}
		using CFString cFString = new CFString(suiteId);
		CFPreferencesRemoveSuitePreferencesFromApp(applicationId.Handle, cFString.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFPreferencesAppSynchronize(IntPtr applicationId);

	public static bool AppSynchronize()
	{
		return AppSynchronize(CurrentApplication);
	}

	public static bool AppSynchronize(string applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException(applicationId);
		}
		using NSString applicationId2 = new NSString(applicationId);
		return AppSynchronize(applicationId2);
	}

	public static bool AppSynchronize(NSString applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		return CFPreferencesAppSynchronize(applicationId.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFPreferencesAppValueIsForced(IntPtr key, IntPtr applicationId);

	public static bool AppValueIsForced(string key)
	{
		return AppValueIsForced(key, CurrentApplication);
	}

	public static bool AppValueIsForced(string key, string applicationId)
	{
		if (applicationId == null)
		{
			throw new ArgumentNullException(applicationId);
		}
		using NSString applicationId2 = new NSString(applicationId);
		return AppValueIsForced(key, applicationId2);
	}

	public static bool AppValueIsForced(string key, NSString applicationId)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (applicationId == null)
		{
			throw new ArgumentNullException("applicationId");
		}
		using CFString cFString = new CFString(key);
		return CFPreferencesAppValueIsForced(cFString.Handle, applicationId.Handle);
	}
}
