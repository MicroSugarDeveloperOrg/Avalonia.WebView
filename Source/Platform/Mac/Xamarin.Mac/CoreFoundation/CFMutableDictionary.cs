using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

internal static class CFMutableDictionary
{
	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFDictionarySetValue(IntPtr theDict, IntPtr key, IntPtr value);

	public static void SetValue(IntPtr theDict, IntPtr key, IntPtr value)
	{
		CFDictionarySetValue(theDict, key, value);
	}

	public static void SetValue(IntPtr theDict, IntPtr key, bool value)
	{
		SetValue(theDict, key, value ? CFBoolean.True.Handle : CFBoolean.False.Handle);
	}
}
