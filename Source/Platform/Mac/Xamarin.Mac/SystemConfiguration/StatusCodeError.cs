using System;
using System.Runtime.InteropServices;

namespace SystemConfiguration;

public static class StatusCodeError
{
	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	internal static extern StatusCode SCError();

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr SCErrorString(int code);

	public static string GetErrorDescription(StatusCode statusCode)
	{
		IntPtr ptr = SCErrorString((int)statusCode);
		return Marshal.PtrToStringAnsi(ptr);
	}
}
